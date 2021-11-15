using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_15() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214276"},
        {"Hipparcos Number", "HIP 111735"},
        {"Smithsonian Astrophysical Observation", "SAO 247524"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.50988430),
        dec: Angle.Degrees(-52.77067177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137865"},
        {"Hipparcos Number", "HIP 75955"},
        {"Smithsonian Astrophysical Observation", "SAO 242637"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.69756097),
        dec: Angle.Degrees(-52.77045129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210054"},
        {"Hipparcos Number", "HIP 109333"},
        {"Smithsonian Astrophysical Observation", "SAO 247329"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.24748465),
        dec: Angle.Degrees(-52.76884069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104021"},
        {"Hipparcos Number", "HIP 58416"},
        {"Smithsonian Astrophysical Observation", "SAO 239542"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.66235618),
        dec: Angle.Degrees(-52.76869125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147974"},
        {"Hipparcos Number", "HIP 80615"},
        {"Smithsonian Astrophysical Observation", "SAO 243829"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.89691437),
        dec: Angle.Degrees(-52.76829794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200059"},
        {"Hipparcos Number", "HIP 103898"},
        {"Smithsonian Astrophysical Observation", "SAO 246836"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.77801701),
        dec: Angle.Degrees(-52.76806948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39547"},
        {"Henry Draper 2", "HD 39548"},
        {"Hipparcos Number", "HIP 27583"},
        {"Geneva Identification System", "GEN# +1.00039547J"},
        {"Smithsonian Astrophysical Observation", "SAO 234162"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.62012003),
        dec: Angle.Degrees(-52.76790524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64830"},
        {"Hipparcos Number", "HIP 38508"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.29833993),
        dec: Angle.Degrees(-52.76654876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 96.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91049"},
        {"Hipparcos Number", "HIP 51363"},
        {"Geneva Identification System", "GEN# +1.00091049J"},
        {"Smithsonian Astrophysical Observation", "SAO 238115"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.37014182),
        dec: Angle.Degrees(-52.76617053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109526"},
        {"Hipparcos Number", "HIP 61461"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.91534819),
        dec: Angle.Degrees(-52.76462061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92346"},
        {"Hipparcos Number", "HIP 52100"},
        {"Smithsonian Astrophysical Observation", "SAO 238290"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.68190054),
        dec: Angle.Degrees(-52.76427527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72020"},
        {"Hipparcos Number", "HIP 41527"},
        {"Smithsonian Astrophysical Observation", "SAO 236006"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.04470107),
        dec: Angle.Degrees(-52.76049183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69887"},
        {"Hipparcos Number", "HIP 40528"},
        {"Celescope Catalog", "CEL 2310"},
        {"Geneva Identification System", "GEN# +1.00069887"},
        {"Smithsonian Astrophysical Observation", "SAO 235850"},
    },
    visualMagnitude: 7.13,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.13064475),
        dec: Angle.Degrees(-52.76003851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62195"},
        {"Smithsonian Astrophysical Observation", "SAO 240205"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.20963344),
        dec: Angle.Degrees(-52.75886317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17832"},
        {"Hipparcos Number", "HIP 13185"},
        {"Smithsonian Astrophysical Observation", "SAO 232908"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.42067326),
        dec: Angle.Degrees(-52.75842209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76970"},
        {"Hipparcos Number", "HIP 43972"},
        {"Smithsonian Astrophysical Observation", "SAO 236438"},
    },
    visualMagnitude: 8.91,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.31914586),
        dec: Angle.Degrees(-52.75815447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115618"},
        {"Hipparcos Number", "HIP 64988"},
        {"Smithsonian Astrophysical Observation", "SAO 240738"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.80651135),
        dec: Angle.Degrees(-52.75795962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117169"},
        {"Hipparcos Number", "HIP 65824"},
        {"Fundamental Katalog 5th Edition", "FK5 5189"},
        {"Smithsonian Astrophysical Observation", "SAO 240885"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.41015916),
        dec: Angle.Degrees(-52.75736039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74497"},
        {"Hipparcos Number", "HIP 42695"},
        {"Geneva Identification System", "GEN# +3.23910028"},
        {"Smithsonian Astrophysical Observation", "SAO 236196"},
        {"Wilson Evans Batten Catalogue", "WEB 8245"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.52769397),
        dec: Angle.Degrees(-52.75648226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110770"},
        {"Hipparcos Number", "HIP 62196"},
        {"Geneva Identification System", "GEN# +1.00110770"},
        {"Smithsonian Astrophysical Observation", "SAO 240206"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.21417029),
        dec: Angle.Degrees(-52.75582120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217364"},
        {"Hipparcos Number", "HIP 113638"},
        {"Fundamental Katalog 5th Edition", "FK5 868"},
        {"Geneva Identification System", "GEN# +1.00217364"},
        {"Smithsonian Astrophysical Observation", "SAO 247680"},
        {"Wilson Evans Batten Catalogue", "WEB 20194"},
    },
    visualMagnitude: 4.11,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.22030979),
        dec: Angle.Degrees(-52.75410562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167530"},
        {"Hipparcos Number", "HIP 89713"},
        {"Geneva Identification System", "GEN# +1.00167530"},
        {"Smithsonian Astrophysical Observation", "SAO 245389"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.63955601),
        dec: Angle.Degrees(-52.75234523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128570"},
        {"Hipparcos Number", "HIP 71660"},
        {"Smithsonian Astrophysical Observation", "SAO 241880"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.85705540),
        dec: Angle.Degrees(-52.75082357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109909"},
        {"Hipparcos Number", "HIP 61702"},
        {"Smithsonian Astrophysical Observation", "SAO 240113"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.71643098),
        dec: Angle.Degrees(-52.75081001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117594",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117594"},
        {"Geneva Identification System", "GEN# +6.20145145"},
    },
    visualMagnitude: 10.83,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.73057772),
        dec: Angle.Degrees(-52.74965109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169546"},
        {"Hipparcos Number", "HIP 90506"},
        {"Smithsonian Astrophysical Observation", "SAO 245496"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.02362843),
        dec: Angle.Degrees(-52.74890057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81370"},
        {"Hipparcos Number", "HIP 46032"},
        {"Geneva Identification System", "GEN# +1.00081370"},
        {"Smithsonian Astrophysical Observation", "SAO 236918"},
        {"Wilson Evans Batten Catalogue", "WEB 8722"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.82389754),
        dec: Angle.Degrees(-52.74786586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115823"},
        {"Hipparcos Number", "HIP 65112"},
        {"Celescope Catalog", "CEL 4237"},
        {"Geneva Identification System", "GEN# +1.00115823"},
        {"Smithsonian Astrophysical Observation", "SAO 240762"},
        {"Wilson Evans Batten Catalogue", "WEB 11497"},
    },
    visualMagnitude: 5.47,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.15772684),
        dec: Angle.Degrees(-52.74778497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25149"},
        {"Hipparcos Number", "HIP 18495"},
        {"Smithsonian Astrophysical Observation", "SAO 233337"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.30236256),
        dec: Angle.Degrees(-52.74752557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98519"},
        {"Hipparcos Number", "HIP 55301"},
        {"Smithsonian Astrophysical Observation", "SAO 238962"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.88192896),
        dec: Angle.Degrees(-52.74713123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224554"},
        {"Hipparcos Number", "HIP 118234"},
        {"Fundamental Katalog 5th Edition", "FK5 901"},
        {"Geneva Identification System", "GEN# +1.00224554"},
        {"Smithsonian Astrophysical Observation", "SAO 248087"},
        {"Wilson Evans Batten Catalogue", "WEB 20781"},
    },
    visualMagnitude: 5.13,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.73218118),
        dec: Angle.Degrees(-52.74595629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130377"},
        {"Hipparcos Number", "HIP 72533"},
        {"Geneva Identification System", "GEN# +1.00130377"},
        {"Smithsonian Astrophysical Observation", "SAO 242042"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.44667566),
        dec: Angle.Degrees(-52.74481659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35444"},
        {"Hipparcos Number", "HIP 25049"},
        {"Smithsonian Astrophysical Observation", "SAO 233947"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.45291422),
        dec: Angle.Degrees(-52.74387153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192571"},
        {"Hipparcos Number", "HIP 100057"},
        {"Smithsonian Astrophysical Observation", "SAO 246518"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.49579670),
        dec: Angle.Degrees(-52.74047168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143491"},
        {"Hipparcos Number", "HIP 78631"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.78526068),
        dec: Angle.Degrees(-52.73866247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101159"},
        {"Hipparcos Number", "HIP 56752"},
        {"Smithsonian Astrophysical Observation", "SAO 239243"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.52752397),
        dec: Angle.Degrees(-52.73785309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204873"},
        {"Hipparcos Number", "HIP 106419"},
        {"Geneva Identification System", "GEN# +1.00204873"},
        {"Smithsonian Astrophysical Observation", "SAO 247080"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.32342232),
        dec: Angle.Degrees(-52.73773902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204457"},
        {"Hipparcos Number", "HIP 106176"},
        {"Smithsonian Astrophysical Observation", "SAO 247054"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.59052407),
        dec: Angle.Degrees(-52.73750658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146293"},
        {"Hipparcos Number", "HIP 79870"},
        {"Smithsonian Astrophysical Observation", "SAO 243568"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.54476246),
        dec: Angle.Degrees(-52.73727497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111639"},
        {"Hipparcos Number", "HIP 62730"},
        {"Geneva Identification System", "GEN# +1.00111639"},
        {"Smithsonian Astrophysical Observation", "SAO 240320"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.81917569),
        dec: Angle.Degrees(-52.73318636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44267"},
        {"Hipparcos Number", "HIP 29913"},
        {"Geneva Identification System", "GEN# +1.00044267"},
        {"Smithsonian Astrophysical Observation", "SAO 234430"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.46557314),
        dec: Angle.Degrees(-52.73303375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89513"},
        {"Hipparcos Number", "HIP 50474"},
        {"Smithsonian Astrophysical Observation", "SAO 237893"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.59111189),
        dec: Angle.Degrees(-52.73287261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101372"},
        {"Hipparcos Number", "HIP 56868"},
        {"Geneva Identification System", "GEN# +1.00101372"},
        {"Smithsonian Astrophysical Observation", "SAO 239266"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.88985414),
        dec: Angle.Degrees(-52.72792084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -311.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207590"},
        {"Hipparcos Number", "HIP 107892"},
        {"Geneva Identification System", "GEN# +1.00207590"},
        {"Smithsonian Astrophysical Observation", "SAO 247206"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.90354401),
        dec: Angle.Degrees(-52.72781645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203569"},
        {"Hipparcos Number", "HIP 105728"},
        {"Smithsonian Astrophysical Observation", "SAO 247017"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.21198315),
        dec: Angle.Degrees(-52.72716365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76805"},
        {"Hipparcos Number", "HIP 43878"},
        {"Celescope Catalog", "CEL 3094"},
        {"Geneva Identification System", "GEN# +1.00076805"},
        {"Smithsonian Astrophysical Observation", "SAO 236417"},
        {"Wilson Evans Batten Catalogue", "WEB 8438"},
    },
    visualMagnitude: 4.68,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.08032510),
        dec: Angle.Degrees(-52.72351071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180909"},
        {"Hipparcos Number", "HIP 95125"},
        {"Geneva Identification System", "GEN# +1.00180909"},
        {"Smithsonian Astrophysical Observation", "SAO 246040"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.27362456),
        dec: Angle.Degrees(-52.72286774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88402",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88402"},
    },
    visualMagnitude: 12.17,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.76789627),
        dec: Angle.Degrees(-52.72229897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220729"},
        {"Hipparcos Number", "HIP 115713"},
        {"Fundamental Katalog 5th Edition", "FK5 883"},
        {"Geneva Identification System", "GEN# +1.00220729"},
        {"Smithsonian Astrophysical Observation", "SAO 247874"},
        {"Wilson Evans Batten Catalogue", "WEB 20476"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.65226789),
        dec: Angle.Degrees(-52.72191900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 130.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110565"},
        {"Hipparcos Number", "HIP 62094"},
        {"Smithsonian Astrophysical Observation", "SAO 240189"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.88448727),
        dec: Angle.Degrees(-52.71614728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136707"},
        {"Hipparcos Number", "HIP 75395"},
        {"Geneva Identification System", "GEN# +1.00136707"},
        {"Smithsonian Astrophysical Observation", "SAO 242482"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.08408533),
        dec: Angle.Degrees(-52.71555021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6826"},
        {"Hipparcos Number", "HIP 5322"},
        {"Geneva Identification System", "GEN# +1.00006826"},
        {"Smithsonian Astrophysical Observation", "SAO 232304"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.01644873),
        dec: Angle.Degrees(-52.71432451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17365"},
        {"Hipparcos Number", "HIP 12852"},
        {"Smithsonian Astrophysical Observation", "SAO 232878"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.30967098),
        dec: Angle.Degrees(-52.71407196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29398"},
        {"Hipparcos Number", "HIP 21358"},
        {"Smithsonian Astrophysical Observation", "SAO 233572"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.74044357),
        dec: Angle.Degrees(-52.71271194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33702"},
    },
    visualMagnitude: 11.20,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.03281083),
        dec: Angle.Degrees(-52.71105769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36788"},
        {"Hipparcos Number", "HIP 25854"},
        {"Smithsonian Astrophysical Observation", "SAO 234012"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.78543323),
        dec: Angle.Degrees(-52.71055157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111776"},
        {"Hipparcos Number", "HIP 62811"},
        {"Smithsonian Astrophysical Observation", "SAO 240336"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.06150258),
        dec: Angle.Degrees(-52.70956423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113950"},
        {"Hipparcos Number", "HIP 64072"},
        {"Smithsonian Astrophysical Observation", "SAO 240580"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.96802930),
        dec: Angle.Degrees(-52.70797118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197959"},
        {"Hipparcos Number", "HIP 102757"},
        {"Geneva Identification System", "GEN# +1.00197959"},
        {"Smithsonian Astrophysical Observation", "SAO 246743"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.30880998),
        dec: Angle.Degrees(-52.70708751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70265"},
        {"Hipparcos Number", "HIP 40703"},
        {"Smithsonian Astrophysical Observation", "SAO 235875"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.63392446),
        dec: Angle.Degrees(-52.70670551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71805"},
        {"Hipparcos Number", "HIP 41426"},
        {"Geneva Identification System", "GEN# +1.00071805J"},
        {"Smithsonian Astrophysical Observation", "SAO 235988"},
        {"Wilson Evans Batten Catalogue", "WEB 8013"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.74097365),
        dec: Angle.Degrees(-52.70484071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105270"},
        {"Hipparcos Number", "HIP 59113"},
        {"Geneva Identification System", "GEN# +1.00105270"},
        {"Smithsonian Astrophysical Observation", "SAO 239679"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.81964419),
        dec: Angle.Degrees(-52.70420572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108311"},
        {"Hipparcos Number", "HIP 60744"},
        {"Smithsonian Astrophysical Observation", "SAO 239952"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.74539677),
        dec: Angle.Degrees(-52.70290594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76955"},
        {"Hipparcos Number", "HIP 43965"},
        {"Celescope Catalog", "CEL 3104"},
        {"Geneva Identification System", "GEN# +1.00076955"},
        {"Smithsonian Astrophysical Observation", "SAO 236435"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.30220032),
        dec: Angle.Degrees(-52.70274016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32892"},
        {"Hipparcos Number", "HIP 23528"},
        {"Smithsonian Astrophysical Observation", "SAO 233804"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.87338603),
        dec: Angle.Degrees(-52.70166755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220507"},
        {"Hipparcos Number", "HIP 115577"},
        {"Geneva Identification System", "GEN# +1.00220507"},
        {"Smithsonian Astrophysical Observation", "SAO 247863"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.17554882),
        dec: Angle.Degrees(-52.70149473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210963"},
        {"Hipparcos Number", "HIP 109883"},
        {"Geneva Identification System", "GEN# +1.00210963"},
        {"Smithsonian Astrophysical Observation", "SAO 247376"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.82512504),
        dec: Angle.Degrees(-52.70123018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100005"},
        {"Hipparcos Number", "HIP 56090"},
        {"Smithsonian Astrophysical Observation", "SAO 239116"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.45587251),
        dec: Angle.Degrees(-52.69981042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23175"},
        {"Hipparcos Number", "HIP 17164"},
        {"Geneva Identification System", "GEN# +1.00023175"},
        {"Smithsonian Astrophysical Observation", "SAO 233219"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.14019929),
        dec: Angle.Degrees(-52.69779982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48609"},
        {"Hipparcos Number", "HIP 32017"},
        {"Geneva Identification System", "GEN# +1.00048609"},
        {"Smithsonian Astrophysical Observation", "SAO 234655"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.33271922),
        dec: Angle.Degrees(-52.69720620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160998"},
        {"Hipparcos Number", "HIP 86945"},
        {"Smithsonian Astrophysical Observation", "SAO 245008"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.49141629),
        dec: Angle.Degrees(-52.69675576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196877"},
        {"Hipparcos Number", "HIP 102186"},
        {"Cincinnati Publication", "Ci 20 1221"},
        {"Geneva Identification System", "GEN# +1.00196877"},
        {"Wilson Evans Batten Catalogue", "WEB 18488"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.57793029),
        dec: Angle.Degrees(-52.69667207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1065.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30438",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Canopus"},
        {"Henry Draper", "HD 45348"},
        {"Hipparcos Number", "HIP 30438"},
        {"Celescope Catalog", "CEL 1228"},
        {"Fundamental Katalog 5th Edition", "FK5 245"},
        {"Geneva Identification System", "GEN# +1.00045348"},
        {"Smithsonian Astrophysical Observation", "SAO 234480"},
        {"Wilson Evans Batten Catalogue", "WEB 6060"},
    },
    visualMagnitude: -0.62,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.98787763),
        dec: Angle.Degrees(-52.69571799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190018"},
        {"Hipparcos Number", "HIP 98958"},
        {"Smithsonian Astrophysical Observation", "SAO 246428"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.37960969),
        dec: Angle.Degrees(-52.69323219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83655"},
        {"Hipparcos Number", "HIP 47289"},
        {"Celescope Catalog", "CEL 3350"},
        {"Smithsonian Astrophysical Observation", "SAO 237166"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.55556442),
        dec: Angle.Degrees(-52.69311119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172862"},
        {"Hipparcos Number", "HIP 92019"},
        {"Smithsonian Astrophysical Observation", "SAO 245683"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.33534679),
        dec: Angle.Degrees(-52.69285280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214441"},
        {"Hipparcos Number", "HIP 111833"},
        {"Geneva Identification System", "GEN# +1.00214441"},
        {"Smithsonian Astrophysical Observation", "SAO 247531"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.78501843),
        dec: Angle.Degrees(-52.69195231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11653"},
        {"Hipparcos Number", "HIP 8787"},
        {"Smithsonian Astrophysical Observation", "SAO 232557"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.25211614),
        dec: Angle.Degrees(-52.69169983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219145"},
        {"Hipparcos Number", "HIP 114710"},
        {"Geneva Identification System", "GEN# +1.00219145"},
        {"Smithsonian Astrophysical Observation", "SAO 247789"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.53820286),
        dec: Angle.Degrees(-52.69117229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102235"},
        {"Hipparcos Number", "HIP 57375"},
        {"Geneva Identification System", "GEN# +1.00102235"},
        {"Smithsonian Astrophysical Observation", "SAO 239354"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.43675853),
        dec: Angle.Degrees(-52.69047162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24863"},
        {"Hipparcos Number", "HIP 18275"},
        {"Fundamental Katalog 5th Edition", "FK5 2282"},
        {"Geneva Identification System", "GEN# +1.00024863"},
        {"Smithsonian Astrophysical Observation", "SAO 233321"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.64139696),
        dec: Angle.Degrees(-52.69033035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188946"},
        {"Hipparcos Number", "HIP 98462"},
        {"Smithsonian Astrophysical Observation", "SAO 246380"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.06833593),
        dec: Angle.Degrees(-52.68680804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63886"},
        {"Hipparcos Number", "HIP 38107"},
        {"Smithsonian Astrophysical Observation", "SAO 235534"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.14044372),
        dec: Angle.Degrees(-52.68417983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95083"},
        {"Hipparcos Number", "HIP 53586"},
        {"Smithsonian Astrophysical Observation", "SAO 238634"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.44127299),
        dec: Angle.Degrees(-52.68176242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56074"},
        {"Hipparcos Number", "HIP 34847"},
        {"Smithsonian Astrophysical Observation", "SAO 235013"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.17341366),
        dec: Angle.Degrees(-52.68111347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127501"},
        {"Hipparcos Number", "HIP 71182"},
        {"Geneva Identification System", "GEN# +1.00127501"},
        {"Smithsonian Astrophysical Observation", "SAO 241793"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.37487581),
        dec: Angle.Degrees(-52.67948076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221099"},
        {"Hipparcos Number", "HIP 115942"},
        {"Geneva Identification System", "GEN# +1.00221099"},
        {"Smithsonian Astrophysical Observation", "SAO 247901"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.35747594),
        dec: Angle.Degrees(-52.67856620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35934"},
        {"Hipparcos Number", "HIP 25344"},
        {"Smithsonian Astrophysical Observation", "SAO 233972"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.30696853),
        dec: Angle.Degrees(-52.67693657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64810"},
        {"Hipparcos Number", "HIP 38504"},
        {"Geneva Identification System", "GEN# +1.00064810"},
        {"Smithsonian Astrophysical Observation", "SAO 235593"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.27337037),
        dec: Angle.Degrees(-52.67477302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119597"},
        {"Hipparcos Number", "HIP 67116"},
        {"Geneva Identification System", "GEN# +1.00119597"},
        {"Smithsonian Astrophysical Observation", "SAO 241139"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.33720473),
        dec: Angle.Degrees(-52.67396634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218961"},
        {"Hipparcos Number", "HIP 114585"},
        {"Geneva Identification System", "GEN# +1.00218961"},
        {"Smithsonian Astrophysical Observation", "SAO 247774"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.19670666),
        dec: Angle.Degrees(-52.67114443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159426"},
        {"Hipparcos Number", "HIP 86255"},
        {"Smithsonian Astrophysical Observation", "SAO 244893"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.38139049),
        dec: Angle.Degrees(-52.67011044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206949"},
        {"Hipparcos Number", "HIP 107570"},
        {"Smithsonian Astrophysical Observation", "SAO 247176"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.79952714),
        dec: Angle.Degrees(-52.66955632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170131"},
        {"Hipparcos Number", "HIP 90732"},
        {"Geneva Identification System", "GEN# +1.00170131"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.68207509),
        dec: Angle.Degrees(-52.66937562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20294"},
        {"Hipparcos Number", "HIP 15034"},
        {"Geneva Identification System", "GEN# +1.00020294"},
        {"Smithsonian Astrophysical Observation", "SAO 233042"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.42519509),
        dec: Angle.Degrees(-52.66821854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111822"},
        {"Hipparcos Number", "HIP 62829"},
        {"Geneva Identification System", "GEN# +1.00111822"},
        {"Smithsonian Astrophysical Observation", "SAO 240340"},
        {"Wilson Evans Batten Catalogue", "WEB 11140"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.12797818),
        dec: Angle.Degrees(-52.66733662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34541"},
        {"Hipparcos Number", "HIP 24490"},
        {"Smithsonian Astrophysical Observation", "SAO 233893"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.81732496),
        dec: Angle.Degrees(-52.66530014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97315"},
        {"Hipparcos Number", "HIP 54664"},
        {"Geneva Identification System", "GEN# +1.00097315"},
        {"Smithsonian Astrophysical Observation", "SAO 238846"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.85327979),
        dec: Angle.Degrees(-52.66476784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62993"},
        {"Hipparcos Number", "HIP 37696"},
        {"Smithsonian Astrophysical Observation", "SAO 235457"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.00763766),
        dec: Angle.Degrees(-52.66367534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154707"},
        {"Hipparcos Number", "HIP 83964"},
        {"Smithsonian Astrophysical Observation", "SAO 244473"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.45109914),
        dec: Angle.Degrees(-52.66336608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121639"},
        {"Hipparcos Number", "HIP 68226"},
        {"Celescope Catalog", "CEL 4290"},
        {"Geneva Identification System", "GEN# +1.00121639"},
        {"Smithsonian Astrophysical Observation", "SAO 241332"},
    },
    visualMagnitude: 8.32,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.50416409),
        dec: Angle.Degrees(-52.66191146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98179"},
        {"Hipparcos Number", "HIP 55117"},
        {"Geneva Identification System", "GEN# +1.00098179"},
        {"Smithsonian Astrophysical Observation", "SAO 238931"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.26995523),
        dec: Angle.Degrees(-52.65726950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115595"},
        {"Hipparcos Number", "HIP 64982"},
        {"Smithsonian Astrophysical Observation", "SAO 240733"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.77262552),
        dec: Angle.Degrees(-52.65484396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38526"},
        {"Geneva Identification System", "GEN# -0.05201324J"},
        {"Smithsonian Astrophysical Observation", "SAO 235595"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.33815181),
        dec: Angle.Degrees(-52.65378545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94731"},
        {"Hipparcos Number", "HIP 53395"},
        {"Smithsonian Astrophysical Observation", "SAO 238596"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.82592593),
        dec: Angle.Degrees(-52.65324348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89176"},
        {"Hipparcos Number", "HIP 50262"},
        {"Geneva Identification System", "GEN# +1.00089176"},
        {"Smithsonian Astrophysical Observation", "SAO 237845"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.95217189),
        dec: Angle.Degrees(-52.65324341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110075"},
        {"Hipparcos Number", "HIP 61806"},
        {"Smithsonian Astrophysical Observation", "SAO 240130"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.00091151),
        dec: Angle.Degrees(-52.65162759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1273"},
        {"Hipparcos Number", "HIP 1349"},
        {"Geneva Identification System", "GEN# +1.00001273"},
        {"Smithsonian Astrophysical Observation", "SAO 231987"},
        {"Wilson Evans Batten Catalogue", "WEB 243"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.22329974),
        dec: Angle.Degrees(-52.65159230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 314.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 182.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60060"},
        {"Hipparcos Number", "HIP 36444"},
        {"Geneva Identification System", "GEN# +1.00060060"},
        {"Smithsonian Astrophysical Observation", "SAO 235239"},
    },
    visualMagnitude: 5.87,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.49893731),
        dec: Angle.Degrees(-52.65128759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8189"},
        {"Hipparcos Number", "HIP 6258"},
        {"Geneva Identification System", "GEN# +1.00008189"},
        {"Smithsonian Astrophysical Observation", "SAO 232383"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.06554889),
        dec: Angle.Degrees(-52.65127522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33825"},
        {"Hipparcos Number", "HIP 24040"},
        {"Geneva Identification System", "GEN# +1.00033825"},
        {"Smithsonian Astrophysical Observation", "SAO 233855"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.51186303),
        dec: Angle.Degrees(-52.65106811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152337"},
        {"Hipparcos Number", "HIP 82816"},
        {"Smithsonian Astrophysical Observation", "SAO 244274"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.87113330),
        dec: Angle.Degrees(-52.65081841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79140"},
        {"Hipparcos Number", "HIP 45020"},
        {"Geneva Identification System", "GEN# +1.00079140"},
        {"Smithsonian Astrophysical Observation", "SAO 236677"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.54824662),
        dec: Angle.Degrees(-52.64987750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52298"},
        {"Hipparcos Number", "HIP 33495"},
        {"Geneva Identification System", "GEN# +1.00052298"},
        {"Smithsonian Astrophysical Observation", "SAO 234815"},
        {"Wilson Evans Batten Catalogue", "WEB 6737"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.43938420),
        dec: Angle.Degrees(-52.64755477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -374.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94419",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94419"},
    },
    visualMagnitude: 11.85,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.26695584),
        dec: Angle.Degrees(-52.64661262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71135"},
    },
    visualMagnitude: 10.53,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.21858693),
        dec: Angle.Degrees(-52.64614731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -250.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129165"},
        {"Hipparcos Number", "HIP 71947"},
        {"Smithsonian Astrophysical Observation", "SAO 241932"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.72973053),
        dec: Angle.Degrees(-52.64559432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122308"},
        {"Hipparcos Number", "HIP 68598"},
        {"Geneva Identification System", "GEN# +1.00122308"},
        {"Smithsonian Astrophysical Observation", "SAO 241386"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.63627168),
        dec: Angle.Degrees(-52.64470735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153180"},
        {"Hipparcos Number", "HIP 83234"},
        {"Smithsonian Astrophysical Observation", "SAO 244350"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.14787327),
        dec: Angle.Degrees(-52.64427244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89175"},
        {"Hipparcos Number", "HIP 50259"},
        {"Geneva Identification System", "GEN# +1.00089175"},
        {"Smithsonian Astrophysical Observation", "SAO 237844"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.94434939),
        dec: Angle.Degrees(-52.64373446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142133"},
        {"Hipparcos Number", "HIP 77959"},
        {"Smithsonian Astrophysical Observation", "SAO 243118"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.82217509),
        dec: Angle.Degrees(-52.64205242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118014"},
        {"Hipparcos Number", "HIP 66298"},
        {"Geneva Identification System", "GEN# +1.00118014"},
        {"Smithsonian Astrophysical Observation", "SAO 240975"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.81342556),
        dec: Angle.Degrees(-52.63997121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118273"},
        {"Hipparcos Number", "HIP 66403"},
        {"Smithsonian Astrophysical Observation", "SAO 240998"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.20543477),
        dec: Angle.Degrees(-52.63951324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86466"},
        {"Hipparcos Number", "HIP 48799"},
        {"Celescope Catalog", "CEL 3414"},
        {"Geneva Identification System", "GEN# +1.00086466"},
        {"Smithsonian Astrophysical Observation", "SAO 237526"},
        {"Wilson Evans Batten Catalogue", "WEB 9074"},
    },
    visualMagnitude: 6.13,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.29562255),
        dec: Angle.Degrees(-52.63879276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9054"},
        {"Hipparcos Number", "HIP 6856"},
        {"Geneva Identification System", "GEN# +1.00009054"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.03566055),
        dec: Angle.Degrees(-52.63854657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40292"},
        {"Hipparcos Number", "HIP 27947"},
        {"Geneva Identification System", "GEN# +1.00040292"},
        {"Renson", "Renson 10740"},
        {"Smithsonian Astrophysical Observation", "SAO 234199"},
        {"Wilson Evans Batten Catalogue", "WEB 5476"},
    },
    visualMagnitude: 5.29,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.70878524),
        dec: Angle.Degrees(-52.63607272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 243.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134914"},
        {"Hipparcos Number", "HIP 74599"},
        {"Smithsonian Astrophysical Observation", "SAO 242338"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.62962341),
        dec: Angle.Degrees(-52.63582859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40735"},
        {"Hipparcos Number", "HIP 28223"},
        {"Smithsonian Astrophysical Observation", "SAO 234226"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.44812452),
        dec: Angle.Degrees(-52.63486970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157817"},
        {"Hipparcos Number", "HIP 85497"},
        {"Smithsonian Astrophysical Observation", "SAO 244769"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.08807011),
        dec: Angle.Degrees(-52.63482505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103210"},
        {"Hipparcos Number", "HIP 57945"},
        {"Renson", "Renson 29770"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.24904934),
        dec: Angle.Degrees(-52.63296955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30879"},
        {"Hipparcos Number", "HIP 22322"},
        {"Smithsonian Astrophysical Observation", "SAO 233693"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.12639091),
        dec: Angle.Degrees(-52.62934421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 190.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37278"},
        {"Hipparcos Number", "HIP 26140"},
        {"Smithsonian Astrophysical Observation", "SAO 234031"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.60304377),
        dec: Angle.Degrees(-52.62904751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30373"},
        {"Hipparcos Number", "HIP 22037"},
        {"Geneva Identification System", "GEN# +1.00030373"},
        {"Smithsonian Astrophysical Observation", "SAO 233653"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.06847206),
        dec: Angle.Degrees(-52.62832227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148925"},
        {"Hipparcos Number", "HIP 81134"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.54161957),
        dec: Angle.Degrees(-52.62818041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31173"},
        {"Hipparcos Number", "HIP 22516"},
        {"Geneva Identification System", "GEN# +1.00031173"},
        {"Smithsonian Astrophysical Observation", "SAO 233708"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.67580000),
        dec: Angle.Degrees(-52.62783269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171528"},
        {"Hipparcos Number", "HIP 91378"},
        {"Geneva Identification System", "GEN# +1.00171528"},
        {"Smithsonian Astrophysical Observation", "SAO 245598"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.54929642),
        dec: Angle.Degrees(-52.62756393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160072"},
        {"Hipparcos Number", "HIP 86518"},
        {"Smithsonian Astrophysical Observation", "SAO 244940"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.21195876),
        dec: Angle.Degrees(-52.62631716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30053"},
        {"Hipparcos Number", "HIP 21821"},
        {"Geneva Identification System", "GEN# +1.00030053"},
        {"Smithsonian Astrophysical Observation", "SAO 233627"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.33231676),
        dec: Angle.Degrees(-52.62526827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202120"},
        {"Hipparcos Number", "HIP 104975"},
        {"Geneva Identification System", "GEN# +1.00202120"},
        {"Smithsonian Astrophysical Observation", "SAO 246930"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.93643655),
        dec: Angle.Degrees(-52.62511798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111249"},
        {"Hipparcos Number", "HIP 62506"},
        {"Smithsonian Astrophysical Observation", "SAO 240272"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.13590524),
        dec: Angle.Degrees(-52.62435106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182914"},
        {"Hipparcos Number", "HIP 95848"},
        {"Smithsonian Astrophysical Observation", "SAO 246122"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.40819311),
        dec: Angle.Degrees(-52.62359283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148938"},
        {"Hipparcos Number", "HIP 81137"},
        {"Smithsonian Astrophysical Observation", "SAO 243953"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.55043669),
        dec: Angle.Degrees(-52.62147211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35875"},
        {"Hipparcos Number", "HIP 25307"},
        {"Smithsonian Astrophysical Observation", "SAO 233967"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.20102914),
        dec: Angle.Degrees(-52.62120193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101927"},
        {"Hipparcos Number", "HIP 57179"},
        {"Smithsonian Astrophysical Observation", "SAO 239323"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.88914006),
        dec: Angle.Degrees(-52.61968161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76442"},
        {"Hipparcos Number", "HIP 43699"},
        {"Celescope Catalog", "CEL 3062"},
        {"Geneva Identification System", "GEN# +1.00076442"},
        {"Smithsonian Astrophysical Observation", "SAO 236385"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.50004960),
        dec: Angle.Degrees(-52.61862999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192725"},
        {"Hipparcos Number", "HIP 100137"},
    },
    visualMagnitude: 11.96,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.69659050),
        dec: Angle.Degrees(-52.61784273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68117"},
        {"Hipparcos Number", "HIP 39850"},
        {"Renson", "Renson 18830"},
        {"Smithsonian Astrophysical Observation", "SAO 235768"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.11855796),
        dec: Angle.Degrees(-52.61718616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212166"},
        {"Hipparcos Number", "HIP 110530"},
        {"Smithsonian Astrophysical Observation", "SAO 247432"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.87845110),
        dec: Angle.Degrees(-52.61711499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85228"},
        {"Hipparcos Number", "HIP 48133"},
        {"Geneva Identification System", "GEN# +1.00085228J"},
        {"Smithsonian Astrophysical Observation", "SAO 237371"},
        {"Wilson Evans Batten Catalogue", "WEB 8992"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.19571335),
        dec: Angle.Degrees(-52.61627821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -229.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 233.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97239",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97239"},
        {"Smithsonian Astrophysical Observation", "SAO 246257"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.44166607),
        dec: Angle.Degrees(-52.61604000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9580"},
        {"Hipparcos Number", "HIP 7211"},
        {"Geneva Identification System", "GEN# +1.00009580"},
        {"Smithsonian Astrophysical Observation", "SAO 232458"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.22150996),
        dec: Angle.Degrees(-52.61580756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 190.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112509"},
        {"Hipparcos Number", "HIP 63272"},
        {"Geneva Identification System", "GEN# +1.00112509"},
        {"Smithsonian Astrophysical Observation", "SAO 240422"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.49090199),
        dec: Angle.Degrees(-52.61512123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9924"},
        {"Hipparcos Number", "HIP 7438"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.94978613),
        dec: Angle.Degrees(-52.61398501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160653"},
        {"Hipparcos Number", "HIP 86784"},
        {"Smithsonian Astrophysical Observation", "SAO 244976"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.00290335),
        dec: Angle.Degrees(-52.61267140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34191"},
    },
    visualMagnitude: 11.23,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.35047555),
        dec: Angle.Degrees(-52.60976649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54290"},
        {"Hipparcos Number", "HIP 34184"},
        {"Smithsonian Astrophysical Observation", "SAO 234909"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.34045211),
        dec: Angle.Degrees(-52.60953777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59425"},
        {"Hipparcos Number", "HIP 36184"},
        {"Smithsonian Astrophysical Observation", "SAO 235202"},
    },
    visualMagnitude: 9.08,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.78228112),
        dec: Angle.Degrees(-52.60707404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118964"},
        {"Hipparcos Number", "HIP 66799"},
        {"Geneva Identification System", "GEN# +1.00118964"},
        {"Smithsonian Astrophysical Observation", "SAO 241071"},
        {"Wilson Evans Batten Catalogue", "WEB 11776"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.37437541),
        dec: Angle.Degrees(-52.60673818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3697"},
        {"Hipparcos Number", "HIP 3085"},
        {"Smithsonian Astrophysical Observation", "SAO 232133"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.80067407),
        dec: Angle.Degrees(-52.60486551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38682"},
        {"Hipparcos Number", "HIP 27081"},
        {"Geneva Identification System", "GEN# +1.00038682"},
        {"Smithsonian Astrophysical Observation", "SAO 234114"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.13629524),
        dec: Angle.Degrees(-52.60466135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88498"},
        {"Hipparcos Number", "HIP 49876"},
        {"Smithsonian Astrophysical Observation", "SAO 237763"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.76242179),
        dec: Angle.Degrees(-52.60336844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218270"},
        {"Hipparcos Number", "HIP 114179"},
        {"Geneva Identification System", "GEN# +1.00218270"},
        {"Smithsonian Astrophysical Observation", "SAO 247741"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.83560470),
        dec: Angle.Degrees(-52.60264488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89767"},
        {"Hipparcos Number", "HIP 50598"},
        {"Geneva Identification System", "GEN# +1.00089767"},
        {"Smithsonian Astrophysical Observation", "SAO 237930"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.04894756),
        dec: Angle.Degrees(-52.60172085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101976"},
        {"Hipparcos Number", "HIP 57216"},
        {"Geneva Identification System", "GEN# +1.00101976"},
        {"Smithsonian Astrophysical Observation", "SAO 239330"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.98244700),
        dec: Angle.Degrees(-52.60003334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 149.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124923"},
        {"Hipparcos Number", "HIP 69872"},
        {"Geneva Identification System", "GEN# +1.00124923"},
        {"Smithsonian Astrophysical Observation", "SAO 241604"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.47714095),
        dec: Angle.Degrees(-52.59879240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182507"},
        {"Hipparcos Number", "HIP 95671"},
        {"Renson", "Renson 50470"},
        {"Smithsonian Astrophysical Observation", "SAO 246107"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.89728949),
        dec: Angle.Degrees(-52.59834272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130017"},
        {"Hipparcos Number", "HIP 72354"},
        {"Geneva Identification System", "GEN# +1.00130017"},
        {"Smithsonian Astrophysical Observation", "SAO 242000"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.93376463),
        dec: Angle.Degrees(-52.59791785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94873"},
        {"Hipparcos Number", "HIP 53466"},
        {"Geneva Identification System", "GEN# +1.00094873"},
        {"Renson", "Renson 27350"},
        {"Smithsonian Astrophysical Observation", "SAO 238609"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.06078539),
        dec: Angle.Degrees(-52.59754856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165775"},
        {"Hipparcos Number", "HIP 89054"},
        {"Geneva Identification System", "GEN# +1.00165775"},
        {"Smithsonian Astrophysical Observation", "SAO 245285"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.65001576),
        dec: Angle.Degrees(-52.59089600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105417"},
        {"Hipparcos Number", "HIP 59186"},
        {"Smithsonian Astrophysical Observation", "SAO 239688"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.07355870),
        dec: Angle.Degrees(-52.59043453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174409"},
        {"Hipparcos Number", "HIP 92692"},
        {"Geneva Identification System", "GEN# +1.00174409"},
        {"Smithsonian Astrophysical Observation", "SAO 245782"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.30821209),
        dec: Angle.Degrees(-52.58878669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70731"},
        {"Hipparcos Number", "HIP 40929"},
        {"Geneva Identification System", "GEN# +1.00070731"},
        {"Smithsonian Astrophysical Observation", "SAO 235911"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.28892214),
        dec: Angle.Degrees(-52.58740954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65189"},
        {"Hipparcos Number", "HIP 38667"},
        {"Celescope Catalog", "CEL 2099"},
        {"Geneva Identification System", "GEN# +1.00065189"},
        {"Smithsonian Astrophysical Observation", "SAO 235612"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.75182427),
        dec: Angle.Degrees(-52.58335768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6013"},
        {"Hipparcos Number", "HIP 4724"},
        {"Smithsonian Astrophysical Observation", "SAO 232258"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.16691021),
        dec: Angle.Degrees(-52.58277600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114080"},
        {"Hipparcos Number", "HIP 64153"},
        {"Smithsonian Astrophysical Observation", "SAO 240596"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.22302276),
        dec: Angle.Degrees(-52.58228988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64154",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64154"},
    },
    visualMagnitude: 11.19,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.22580119),
        dec: Angle.Degrees(-52.57997092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5511"},
        {"Hipparcos Number", "HIP 4388"},
        {"Smithsonian Astrophysical Observation", "SAO 232228"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.06029906),
        dec: Angle.Degrees(-52.57974643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42227"},
    },
    visualMagnitude: 9.50,
    bvColour: 2.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.15143743),
        dec: Angle.Degrees(-52.57789302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190580"},
        {"Hipparcos Number", "HIP 99188"},
        {"Geneva Identification System", "GEN# +1.00190580"},
        {"Smithsonian Astrophysical Observation", "SAO 246453"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.03988388),
        dec: Angle.Degrees(-52.57774840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107123"},
        {"Hipparcos Number", "HIP 60080"},
        {"Geneva Identification System", "GEN# +1.00107123"},
        {"Smithsonian Astrophysical Observation", "SAO 239841"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.80498396),
        dec: Angle.Degrees(-52.57503062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68371"},
        {"Hipparcos Number", "HIP 39951"},
        {"Geneva Identification System", "GEN# +1.00068371"},
        {"Smithsonian Astrophysical Observation", "SAO 235782"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.38012378),
        dec: Angle.Degrees(-52.57448245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 968"},
        {"Hipparcos Number", "HIP 1111"},
        {"Smithsonian Astrophysical Observation", "SAO 231975"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.45941592),
        dec: Angle.Degrees(-52.57099754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26354"},
        {"Hipparcos Number", "HIP 19248"},
        {"Geneva Identification System", "GEN# +1.00026354"},
        {"Smithsonian Astrophysical Observation", "SAO 233401"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.87108656),
        dec: Angle.Degrees(-52.57088584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107960"},
        {"Hipparcos Number", "HIP 60542"},
        {"Geneva Identification System", "GEN# +1.00107960"},
        {"Smithsonian Astrophysical Observation", "SAO 239930"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.16732904),
        dec: Angle.Degrees(-52.57058420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17254"},
        {"Hipparcos Number", "HIP 12775"},
        {"Geneva Identification System", "GEN# +1.00017254"},
        {"Smithsonian Astrophysical Observation", "SAO 232871"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.04414752),
        dec: Angle.Degrees(-52.57056106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43956"},
        {"Hipparcos Number", "HIP 29769"},
        {"Smithsonian Astrophysical Observation", "SAO 234411"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.02920918),
        dec: Angle.Degrees(-52.57055407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143429"},
        {"Hipparcos Number", "HIP 78579"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.67985951),
        dec: Angle.Degrees(-52.56858058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114365"},
        {"Hipparcos Number", "HIP 64320"},
        {"Celescope Catalog", "CEL 4210"},
        {"Geneva Identification System", "GEN# +1.00114365"},
        {"Renson", "Renson 33070"},
        {"Smithsonian Astrophysical Observation", "SAO 240627"},
        {"Wilson Evans Batten Catalogue", "WEB 11368"},
    },
    visualMagnitude: 6.05,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.74360793),
        dec: Angle.Degrees(-52.56685355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140354"},
        {"Hipparcos Number", "HIP 77171"},
        {"Geneva Identification System", "GEN# +1.00140354"},
        {"Smithsonian Astrophysical Observation", "SAO 242925"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.36053281),
        dec: Angle.Degrees(-52.56681711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90451"},
        {"Hipparcos Number", "HIP 51013"},
        {"Smithsonian Astrophysical Observation", "SAO 238049"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.32002211),
        dec: Angle.Degrees(-52.56535325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57764"},
        {"Hipparcos Number", "HIP 35515"},
        {"Geneva Identification System", "GEN# +1.00057764"},
        {"Smithsonian Astrophysical Observation", "SAO 235105"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.96550596),
        dec: Angle.Degrees(-52.56501177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164131"},
        {"Hipparcos Number", "HIP 88358"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.65107330),
        dec: Angle.Degrees(-52.56397217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90885"},
        {"Hipparcos Number", "HIP 51266"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.07758525),
        dec: Angle.Degrees(-52.56179763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197807"},
        {"Hipparcos Number", "HIP 102651"},
        {"Geneva Identification System", "GEN# +1.00197807"},
        {"Smithsonian Astrophysical Observation", "SAO 246732"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.03344355),
        dec: Angle.Degrees(-52.56097688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18025"},
        {"Hipparcos Number", "HIP 13341"},
        {"Smithsonian Astrophysical Observation", "SAO 232919"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.92802280),
        dec: Angle.Degrees(-52.55923001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172039"},
        {"Hipparcos Number", "HIP 91596"},
        {"Smithsonian Astrophysical Observation", "SAO 245631"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.19694428),
        dec: Angle.Degrees(-52.55919066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19379"},
        {"Hipparcos Number", "HIP 14335"},
        {"Smithsonian Astrophysical Observation", "SAO 232988"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.20941381),
        dec: Angle.Degrees(-52.55869819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22586"},
        {"Hipparcos Number", "HIP 16758"},
        {"Geneva Identification System", "GEN# +1.00022586"},
        {"Smithsonian Astrophysical Observation", "SAO 233173"},
        {"Wilson Evans Batten Catalogue", "WEB 3190"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.90850578),
        dec: Angle.Degrees(-52.55667285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97171"},
        {"Hipparcos Number", "HIP 54602"},
        {"Geneva Identification System", "GEN# +1.00097171"},
        {"Smithsonian Astrophysical Observation", "SAO 238838"},
    },
    visualMagnitude: 8.81,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.62569094),
        dec: Angle.Degrees(-52.55498774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122277"},
        {"Hipparcos Number", "HIP 68575"},
        {"Smithsonian Astrophysical Observation", "SAO 241382"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.58493518),
        dec: Angle.Degrees(-52.55322627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162497"},
        {"Hipparcos Number", "HIP 87649"},
        {"Smithsonian Astrophysical Observation", "SAO 245104"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.54957325),
        dec: Angle.Degrees(-52.55205402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205946"},
        {"Hipparcos Number", "HIP 107017"},
        {"Smithsonian Astrophysical Observation", "SAO 247131"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.10980787),
        dec: Angle.Degrees(-52.55125564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76393"},
        {"Hipparcos Number", "HIP 43659"},
        {"Smithsonian Astrophysical Observation", "SAO 236379"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.41394543),
        dec: Angle.Degrees(-52.55090677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71239"},
        {"Hipparcos Number", "HIP 41160"},
        {"Smithsonian Astrophysical Observation", "SAO 235944"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.96701558),
        dec: Angle.Degrees(-52.54888896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59262"},
        {"Hipparcos Number", "HIP 36119"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.60346191),
        dec: Angle.Degrees(-52.54875005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31828"},
        {"Hipparcos Number", "HIP 22932"},
        {"Smithsonian Astrophysical Observation", "SAO 233738"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.02151401),
        dec: Angle.Degrees(-52.54729006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30294"},
        {"Hipparcos Number", "HIP 21979"},
        {"Smithsonian Astrophysical Observation", "SAO 233646"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.87349734),
        dec: Angle.Degrees(-52.54603531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 978"},
        {"Hipparcos Number", "HIP 1116"},
        {"Smithsonian Astrophysical Observation", "SAO 231977"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.48246268),
        dec: Angle.Degrees(-52.54548897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 245.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83388"},
        {"Hipparcos Number", "HIP 47131"},
        {"Smithsonian Astrophysical Observation", "SAO 237135"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.06108189),
        dec: Angle.Degrees(-52.54467671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7881",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7881"},
    },
    visualMagnitude: 12.81,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.34468730),
        dec: Angle.Degrees(-52.54453295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 436.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -218.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16555"},
        {"Hipparcos Number", "HIP 12225"},
        {"Fundamental Katalog 5th Edition", "FK5 2182"},
        {"Geneva Identification System", "GEN# +1.00016555"},
        {"Smithsonian Astrophysical Observation", "SAO 232835"},
        {"Wilson Evans Batten Catalogue", "WEB 2510"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.35110362),
        dec: Angle.Degrees(-52.54308845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66080"},
        {"Hipparcos Number", "HIP 39051"},
        {"Smithsonian Astrophysical Observation", "SAO 235661"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.84335253),
        dec: Angle.Degrees(-52.54289979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80900"},
        {"Hipparcos Number", "HIP 45808"},
        {"Smithsonian Astrophysical Observation", "SAO 236864"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.11527681),
        dec: Angle.Degrees(-52.54106890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101361"},
        {"Hipparcos Number", "HIP 56866"},
        {"Smithsonian Astrophysical Observation", "SAO 239264"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.88457198),
        dec: Angle.Degrees(-52.54074023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57553"},
        {"Hipparcos Number", "HIP 35439"},
        {"Smithsonian Astrophysical Observation", "SAO 235090"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.74500756),
        dec: Angle.Degrees(-52.53966900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42537"},
        {"Hipparcos Number", "HIP 29099"},
        {"Geneva Identification System", "GEN# +1.00042537"},
        {"Smithsonian Astrophysical Observation", "SAO 234336"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.07153897),
        dec: Angle.Degrees(-52.53812689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209402"},
        {"Hipparcos Number", "HIP 108965"},
        {"Smithsonian Astrophysical Observation", "SAO 247298"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.13179640),
        dec: Angle.Degrees(-52.53803696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134313"},
        {"Hipparcos Number", "HIP 74297"},
        {"Smithsonian Astrophysical Observation", "SAO 242288"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.78824982),
        dec: Angle.Degrees(-52.53620086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149729"},
        {"Hipparcos Number", "HIP 81557"},
        {"Geneva Identification System", "GEN# +1.00149729"},
        {"Smithsonian Astrophysical Observation", "SAO 244032"},
        {"Wilson Evans Batten Catalogue", "WEB 13776"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.84824399),
        dec: Angle.Degrees(-52.53594084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87966"},
        {"Hipparcos Number", "HIP 49568"},
        {"Smithsonian Astrophysical Observation", "SAO 237705"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.78826323),
        dec: Angle.Degrees(-52.53434784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61248"},
        {"Hipparcos Number", "HIP 36942"},
        {"Fundamental Katalog 5th Edition", "FK5 1198"},
        {"Geneva Identification System", "GEN# +1.00061248"},
        {"Smithsonian Astrophysical Observation", "SAO 235336"},
        {"Wilson Evans Batten Catalogue", "WEB 7330"},
    },
    visualMagnitude: 4.93,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.91541745),
        dec: Angle.Degrees(-52.53380809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12671"},
        {"Hipparcos Number", "HIP 9532"},
        {"Geneva Identification System", "GEN# +1.00012671"},
        {"Smithsonian Astrophysical Observation", "SAO 232610"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.64588568),
        dec: Angle.Degrees(-52.53266823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186268"},
        {"Hipparcos Number", "HIP 97248"},
        {"Geneva Identification System", "GEN# +1.00186268"},
        {"Smithsonian Astrophysical Observation", "SAO 246260"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.47743172),
        dec: Angle.Degrees(-52.53100932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104533J"},
        {"Hipparcos Number", "HIP 58692"},
        {"Smithsonian Astrophysical Observation", "SAO 239600"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.56359917),
        dec: Angle.Degrees(-52.52977322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102087"},
        {"Hipparcos Number", "HIP 57273"},
        {"Smithsonian Astrophysical Observation", "SAO 239339"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.16805103),
        dec: Angle.Degrees(-52.52892675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154095"},
        {"Hipparcos Number", "HIP 83671"},
        {"Renson", "Renson 43550"},
        {"Smithsonian Astrophysical Observation", "SAO 244432"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.51951144),
        dec: Angle.Degrees(-52.52753962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1807",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1807"},
        {"Cincinnati Publication", "Ci 20 27"},
        {"Geneva Identification System", "GEN# -0.05300077"},
        {"Smithsonian Astrophysical Observation", "SAO 232013"},
        {"Wilson Evans Batten Catalogue", "WEB 323"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.73599468),
        dec: Angle.Degrees(-52.52522409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -474.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126488"},
        {"Hipparcos Number", "HIP 70689"},
        {"Smithsonian Astrophysical Observation", "SAO 241724"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.87698160),
        dec: Angle.Degrees(-52.52505529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113949"},
        {"Hipparcos Number", "HIP 64075"},
        {"Smithsonian Astrophysical Observation", "SAO 240581"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.97158559),
        dec: Angle.Degrees(-52.52442247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198756"},
        {"Hipparcos Number", "HIP 103201"},
        {"Geneva Identification System", "GEN# +1.00198756"},
        {"Smithsonian Astrophysical Observation", "SAO 246785"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.64215352),
        dec: Angle.Degrees(-52.52369006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75201"},
        {"Hipparcos Number", "HIP 43065"},
        {"Smithsonian Astrophysical Observation", "SAO 236260"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.59114694),
        dec: Angle.Degrees(-52.52366122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31640"},
        {"Hipparcos Number", "HIP 22818"},
        {"Renson", "Renson 8070"},
        {"Smithsonian Astrophysical Observation", "SAO 233729"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.63943769),
        dec: Angle.Degrees(-52.52361465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136354"},
        {"Hipparcos Number", "HIP 75238"},
        {"Smithsonian Astrophysical Observation", "SAO 242457"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.61193937),
        dec: Angle.Degrees(-52.52297393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190205"},
        {"Hipparcos Number", "HIP 99032"},
        {"Geneva Identification System", "GEN# +1.00190205"},
        {"Smithsonian Astrophysical Observation", "SAO 246433"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.59764784),
        dec: Angle.Degrees(-52.52158948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58424"},
        {"Hipparcos Number", "HIP 35779"},
        {"Geneva Identification System", "GEN# +1.00058424"},
        {"Smithsonian Astrophysical Observation", "SAO 235152"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.70338811),
        dec: Angle.Degrees(-52.51922937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73569"},
        {"Hipparcos Number", "HIP 42245"},
        {"Geneva Identification System", "GEN# +1.00073569"},
        {"Smithsonian Astrophysical Observation", "SAO 236123"},
        {"Wilson Evans Batten Catalogue", "WEB 8118"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.19043609),
        dec: Angle.Degrees(-52.51635124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84051",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84051"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.74746440),
        dec: Angle.Degrees(-52.51589200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -250.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 158.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85167"},
        {"Hipparcos Number", "HIP 48102"},
        {"Geneva Identification System", "GEN# +1.00085167"},
        {"Smithsonian Astrophysical Observation", "SAO 237359"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.11105965),
        dec: Angle.Degrees(-52.51567249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52651",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52651"},
    },
    visualMagnitude: 11.90,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.50276797),
        dec: Angle.Degrees(-52.51403435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39976"},
        {"Hipparcos Number", "HIP 27807"},
        {"Smithsonian Astrophysical Observation", "SAO 234185"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.26745313),
        dec: Angle.Degrees(-52.51236623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8631"},
        {"Hipparcos Number", "HIP 6546"},
        {"Smithsonian Astrophysical Observation", "SAO 232411"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.03068609),
        dec: Angle.Degrees(-52.51140664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48499",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48499"},
    },
    visualMagnitude: 10.51,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.35815861),
        dec: Angle.Degrees(-52.50938270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141258"},
        {"Hipparcos Number", "HIP 77595"},
        {"Smithsonian Astrophysical Observation", "SAO 243033"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.62908180),
        dec: Angle.Degrees(-52.50817988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 299043"},
        {"Hipparcos Number", "HIP 50694"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.28403256),
        dec: Angle.Degrees(-52.50585246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 211.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25873"},
        {"Hipparcos Number", "HIP 18929"},
        {"Geneva Identification System", "GEN# +1.00025873"},
        {"Smithsonian Astrophysical Observation", "SAO 233380"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.86659997),
        dec: Angle.Degrees(-52.50567742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61855"},
        {"Hipparcos Number", "HIP 37213"},
        {"Smithsonian Astrophysical Observation", "SAO 235381"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.66299825),
        dec: Angle.Degrees(-52.50484837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87650"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.55311778),
        dec: Angle.Degrees(-52.50379974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14625",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14625"},
        {"Smithsonian Astrophysical Observation", "SAO 233009"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.22233674),
        dec: Angle.Degrees(-52.50266977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120886"},
        {"Hipparcos Number", "HIP 67815"},
        {"Smithsonian Astrophysical Observation", "SAO 241260"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.38242746),
        dec: Angle.Degrees(-52.50130920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169594"},
        {"Hipparcos Number", "HIP 90519"},
        {"Renson", "Renson 47500"},
        {"Smithsonian Astrophysical Observation", "SAO 245498"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.04879797),
        dec: Angle.Degrees(-52.49992583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56705"},
        {"Hipparcos Number", "HIP 35084"},
        {"Geneva Identification System", "GEN# +1.00056705"},
        {"Smithsonian Astrophysical Observation", "SAO 235040"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.83861519),
        dec: Angle.Degrees(-52.49951781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9221"},
        {"Hipparcos Number", "HIP 6962"},
        {"Smithsonian Astrophysical Observation", "SAO 232438"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.40433013),
        dec: Angle.Degrees(-52.49728445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103177"},
        {"Hipparcos Number", "HIP 57913"},
        {"Smithsonian Astrophysical Observation", "SAO 239451"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.17718613),
        dec: Angle.Degrees(-52.49670253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2722",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2722"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.66228777),
        dec: Angle.Degrees(-52.49400274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9293"},
        {"Hipparcos Number", "HIP 7015"},
        {"Smithsonian Astrophysical Observation", "SAO 232443"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.58086803),
        dec: Angle.Degrees(-52.49352180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132352"},
        {"Hipparcos Number", "HIP 73451"},
        {"Smithsonian Astrophysical Observation", "SAO 242168"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.14929329),
        dec: Angle.Degrees(-52.49261681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98542"},
        {"Hipparcos Number", "HIP 55319"},
        {"Smithsonian Astrophysical Observation", "SAO 238964"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.92445000),
        dec: Angle.Degrees(-52.49193442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37896"},
        {"Hipparcos Number", "HIP 26553"},
        {"Smithsonian Astrophysical Observation", "SAO 234066"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.69474550),
        dec: Angle.Degrees(-52.48903491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298986"},
        {"Hipparcos Number", "HIP 50382"},
        {"Cincinnati Publication", "Ci 20 573"},
        {"Geneva Identification System", "GEN# +1.00298986"},
        {"Wilson Evans Batten Catalogue", "WEB 9247"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.31036783),
        dec: Angle.Degrees(-52.48854121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 408.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101962"},
        {"Hipparcos Number", "HIP 57197"},
        {"Smithsonian Astrophysical Observation", "SAO 239329"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.94040208),
        dec: Angle.Degrees(-52.48637669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13781"},
        {"Hipparcos Number", "HIP 10297"},
        {"Smithsonian Astrophysical Observation", "SAO 232673"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.16691042),
        dec: Angle.Degrees(-52.48604101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196900"},
        {"Hipparcos Number", "HIP 102197"},
        {"Smithsonian Astrophysical Observation", "SAO 246702"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.61442704),
        dec: Angle.Degrees(-52.48511957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47002"},
        {"Hipparcos Number", "HIP 31264"},
        {"Smithsonian Astrophysical Observation", "SAO 234573"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.35266208),
        dec: Angle.Degrees(-52.48402062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27477"},
        {"Hipparcos Number", "HIP 20016"},
        {"Smithsonian Astrophysical Observation", "SAO 233466"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.39825377),
        dec: Angle.Degrees(-52.48369712)
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
    primaryId: "HIP 87502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162206"},
        {"Hipparcos Number", "HIP 87502"},
        {"Smithsonian Astrophysical Observation", "SAO 245087"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.17239735),
        dec: Angle.Degrees(-52.48040111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15613"},
        {"Hipparcos Number", "HIP 11555"},
        {"Smithsonian Astrophysical Observation", "SAO 232788"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.21868908),
        dec: Angle.Degrees(-52.47971478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202947"},
        {"Hipparcos Number", "HIP 105404"},
        {"Geneva Identification System", "GEN# +1.00202947"},
        {"Smithsonian Astrophysical Observation", "SAO 246978"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.24906413),
        dec: Angle.Degrees(-52.47754306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87503"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.17317937),
        dec: Angle.Degrees(-52.47700981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147973"},
        {"Hipparcos Number", "HIP 80614"},
        {"Smithsonian Astrophysical Observation", "SAO 243830"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.89663917),
        dec: Angle.Degrees(-52.47667996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59875",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59875"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.18683168),
        dec: Angle.Degrees(-52.47461196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22177"},
        {"Hipparcos Number", "HIP 16460"},
        {"Geneva Identification System", "GEN# +1.00022177"},
        {"Smithsonian Astrophysical Observation", "SAO 233148"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.00705473),
        dec: Angle.Degrees(-52.47371172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127897"},
        {"Hipparcos Number", "HIP 71365"},
        {"Smithsonian Astrophysical Observation", "SAO 241826"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.92390869),
        dec: Angle.Degrees(-52.47345214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139505"},
        {"Hipparcos Number", "HIP 76795"},
        {"Geneva Identification System", "GEN# +1.00139505"},
        {"Smithsonian Astrophysical Observation", "SAO 242825"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.19498087),
        dec: Angle.Degrees(-52.47343219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76441"},
        {"Hipparcos Number", "HIP 43689"},
        {"Celescope Catalog", "CEL 3059"},
        {"Geneva Identification System", "GEN# +1.00076441"},
        {"Smithsonian Astrophysical Observation", "SAO 236383"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.48580366),
        dec: Angle.Degrees(-52.47272862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94108"},
        {"Hipparcos Number", "HIP 53018"},
        {"Geneva Identification System", "GEN# +1.00094108"},
        {"Smithsonian Astrophysical Observation", "SAO 238527"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.70735795),
        dec: Angle.Degrees(-52.47139546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151230"},
        {"Hipparcos Number", "HIP 82285"},
        {"Smithsonian Astrophysical Observation", "SAO 244156"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.20793050),
        dec: Angle.Degrees(-52.47096779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66767"},
        {"Hipparcos Number", "HIP 39338"},
        {"Smithsonian Astrophysical Observation", "SAO 235699"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.62353010),
        dec: Angle.Degrees(-52.47044762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154951"},
        {"Hipparcos Number", "HIP 84085"},
        {"Geneva Identification System", "GEN# +1.00154951"},
        {"Smithsonian Astrophysical Observation", "SAO 244500"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.85523686),
        dec: Angle.Degrees(-52.46980548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146911"},
        {"Hipparcos Number", "HIP 80115"},
        {"Smithsonian Astrophysical Observation", "SAO 243680"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.30228309),
        dec: Angle.Degrees(-52.46975838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100788"},
        {"Hipparcos Number", "HIP 56540"},
        {"Smithsonian Astrophysical Observation", "SAO 239203"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.89380564),
        dec: Angle.Degrees(-52.46908859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172445"},
        {"Hipparcos Number", "HIP 91797"},
        {"Smithsonian Astrophysical Observation", "SAO 245654"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.76884905),
        dec: Angle.Degrees(-52.46878000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58847",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58847"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.03324023),
        dec: Angle.Degrees(-52.46642292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81948"},
        {"Hipparcos Number", "HIP 46352"},
        {"Celescope Catalog", "CEL 3301"},
        {"Geneva Identification System", "GEN# +1.00081948"},
        {"Smithsonian Astrophysical Observation", "SAO 236989"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.75645622),
        dec: Angle.Degrees(-52.46606086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206630"},
        {"Hipparcos Number", "HIP 107385"},
        {"Geneva Identification System", "GEN# +1.00206630"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.25244452),
        dec: Angle.Degrees(-52.46457223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 151.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208184"},
        {"Hipparcos Number", "HIP 108268"},
        {"Fundamental Katalog 5th Edition", "FK5 3748"},
        {"Smithsonian Astrophysical Observation", "SAO 247229"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.01426556),
        dec: Angle.Degrees(-52.46366589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50569"},
        {"Hipparcos Number", "HIP 32860"},
        {"Smithsonian Astrophysical Observation", "SAO 234744"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.73292322),
        dec: Angle.Degrees(-52.46355272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170239"},
        {"Hipparcos Number", "HIP 90779"},
        {"Smithsonian Astrophysical Observation", "SAO 245524"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.80939425),
        dec: Angle.Degrees(-52.46091629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76345"},
        {"Hipparcos Number", "HIP 43646"},
        {"Smithsonian Astrophysical Observation", "SAO 236374"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.34584052),
        dec: Angle.Degrees(-52.46021104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167760"},
        {"Hipparcos Number", "HIP 89795"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.88299627),
        dec: Angle.Degrees(-52.46019827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11199"},
        {"Hipparcos Number", "HIP 8430"},
        {"Smithsonian Astrophysical Observation", "SAO 232528"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.16979075),
        dec: Angle.Degrees(-52.45489683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96154"},
        {"Hipparcos Number", "HIP 54143"},
        {"Geneva Identification System", "GEN# +1.00096154"},
        {"Smithsonian Astrophysical Observation", "SAO 238736"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.14138480),
        dec: Angle.Degrees(-52.45467792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67638",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67638"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.88201179),
        dec: Angle.Degrees(-52.45462351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34768"},
        {"Hipparcos Number", "HIP 24626"},
        {"Geneva Identification System", "GEN# +1.00034768"},
        {"Smithsonian Astrophysical Observation", "SAO 233907"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.22659606),
        dec: Angle.Degrees(-52.45269492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66102",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66102"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.25614668),
        dec: Angle.Degrees(-52.44637357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191829"},
        {"Hipparcos Number", "HIP 99747"},
        {"Geneva Identification System", "GEN# +1.00191829"},
        {"Smithsonian Astrophysical Observation", "SAO 246495"},
        {"Wilson Evans Batten Catalogue", "WEB 17900"},
    },
    visualMagnitude: 5.65,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.57919847),
        dec: Angle.Degrees(-52.44564171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116500"},
        {"Geneva Identification System", "GEN# +6.20145140"},
    },
    visualMagnitude: 11.53,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.11334053),
        dec: Angle.Degrees(-52.44521150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61214"},
        {"Hipparcos Number", "HIP 36927"},
        {"Smithsonian Astrophysical Observation", "SAO 235329"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.86227454),
        dec: Angle.Degrees(-52.44316453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 259.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101849"},
        {"Hipparcos Number", "HIP 57142"},
        {"Smithsonian Astrophysical Observation", "SAO 239316"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.77463259),
        dec: Angle.Degrees(-52.44314093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113538"},
        {"Hipparcos Number", "HIP 63833"},
        {"Cincinnati Publication", "Ci 20 758"},
        {"Geneva Identification System", "GEN# +1.00113538"},
        {"Wilson Evans Batten Catalogue", "WEB 11289"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.24261916),
        dec: Angle.Degrees(-52.44099000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -785.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -795.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148382"},
        {"Hipparcos Number", "HIP 80820"},
        {"Smithsonian Astrophysical Observation", "SAO 243890"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.56564927),
        dec: Angle.Degrees(-52.44083201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36649"},
        {"Hipparcos Number", "HIP 25784"},
        {"Smithsonian Astrophysical Observation", "SAO 234001"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.58194264),
        dec: Angle.Degrees(-52.44072275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158481"},
        {"Hipparcos Number", "HIP 85834"},
        {"Smithsonian Astrophysical Observation", "SAO 244823"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.08542141),
        dec: Angle.Degrees(-52.43897550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140979"},
        {"Hipparcos Number", "HIP 77454"},
        {"Geneva Identification System", "GEN# +1.00140979J"},
        {"Smithsonian Astrophysical Observation", "SAO 243001"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.21006296),
        dec: Angle.Degrees(-52.43822730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179775"},
        {"Hipparcos Number", "HIP 94735"},
        {"Geneva Identification System", "GEN# +1.00179775"},
        {"Smithsonian Astrophysical Observation", "SAO 246003"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.15274091),
        dec: Angle.Degrees(-52.43773290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68149",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68149"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.27964390),
        dec: Angle.Degrees(-52.43180969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81433"},
        {"Hipparcos Number", "HIP 46070"},
        {"Geneva Identification System", "GEN# +1.00081433"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.92118507),
        dec: Angle.Degrees(-52.42702589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81667"},
        {"Hipparcos Number", "HIP 46200"},
        {"Celescope Catalog", "CEL 3287"},
        {"Geneva Identification System", "GEN# +1.00081667"},
        {"Smithsonian Astrophysical Observation", "SAO 236948"},
    },
    visualMagnitude: 8.88,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.30106362),
        dec: Angle.Degrees(-52.42547736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53762"},
        {"Hipparcos Number", "HIP 34006"},
        {"Geneva Identification System", "GEN# +1.00053762"},
        {"Smithsonian Astrophysical Observation", "SAO 234883"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.85253058),
        dec: Angle.Degrees(-52.42536561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146524"},
        {"Hipparcos Number", "HIP 79964"},
        {"Smithsonian Astrophysical Observation", "SAO 243620"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.82386031),
        dec: Angle.Degrees(-52.42499745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82278"},
        {"Hipparcos Number", "HIP 46518"},
        {"Celescope Catalog", "CEL 3309"},
        {"Geneva Identification System", "GEN# +1.00082278"},
        {"Smithsonian Astrophysical Observation", "SAO 237029"},
    },
    visualMagnitude: 7.25,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.31794400),
        dec: Angle.Degrees(-52.42459364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26822"},
        {"Hipparcos Number", "HIP 19593"},
        {"Geneva Identification System", "GEN# +1.00026822"},
        {"Smithsonian Astrophysical Observation", "SAO 233430"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.98491684),
        dec: Angle.Degrees(-52.42393125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49284"},
        {"Hipparcos Number", "HIP 32314"},
        {"Smithsonian Astrophysical Observation", "SAO 234684"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.19279215),
        dec: Angle.Degrees(-52.42361821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66590"},
        {"Hipparcos Number", "HIP 39257"},
        {"Geneva Identification System", "GEN# +1.00066590"},
        {"Smithsonian Astrophysical Observation", "SAO 235691"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.42004332),
        dec: Angle.Degrees(-52.42313278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125952"},
        {"Hipparcos Number", "HIP 70402"},
        {"Smithsonian Astrophysical Observation", "SAO 241695"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.05034178),
        dec: Angle.Degrees(-52.42278491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107758"},
        {"Hipparcos Number", "HIP 60408"},
        {"Smithsonian Astrophysical Observation", "SAO 239905"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.79119566),
        dec: Angle.Degrees(-52.42049035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189609"},
        {"Hipparcos Number", "HIP 98745"},
        {"Smithsonian Astrophysical Observation", "SAO 246411"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.84708204),
        dec: Angle.Degrees(-52.41930157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109593"},
        {"Hipparcos Number", "HIP 61513"},
        {"Fundamental Katalog 5th Edition", "FK5 3006"},
        {"Smithsonian Astrophysical Observation", "SAO 240086"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.05110362),
        dec: Angle.Degrees(-52.41769260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149767"},
        {"Hipparcos Number", "HIP 81574"},
        {"Smithsonian Astrophysical Observation", "SAO 244040"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.89869001),
        dec: Angle.Degrees(-52.41740956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124670"},
        {"Hipparcos Number", "HIP 69736"},
        {"Smithsonian Astrophysical Observation", "SAO 241584"},
    },
    visualMagnitude: 9.56,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.10562748),
        dec: Angle.Degrees(-52.41683655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163562"},
        {"Hipparcos Number", "HIP 88099"},
        {"Smithsonian Astrophysical Observation", "SAO 245157"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.89904401),
        dec: Angle.Degrees(-52.41625441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109473"},
        {"Hipparcos Number", "HIP 61434"},
        {"Smithsonian Astrophysical Observation", "SAO 240080"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.82797901),
        dec: Angle.Degrees(-52.41556366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115159"},
        {"Hipparcos Number", "HIP 64749"},
        {"Smithsonian Astrophysical Observation", "SAO 240699"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.05316268),
        dec: Angle.Degrees(-52.41473841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31094"},
        {"Hipparcos Number", "HIP 22473"},
        {"Smithsonian Astrophysical Observation", "SAO 233702"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.53678938),
        dec: Angle.Degrees(-52.41363210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220100"},
        {"Hipparcos Number", "HIP 115330"},
        {"Smithsonian Astrophysical Observation", "SAO 247841"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.39488313),
        dec: Angle.Degrees(-52.41093629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51122"},
        {"Hipparcos Number", "HIP 33063"},
        {"Smithsonian Astrophysical Observation", "SAO 234767"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.30400484),
        dec: Angle.Degrees(-52.41012687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49517"},
        {"Hipparcos Number", "HIP 32402"},
        {"Geneva Identification System", "GEN# +1.00049517"},
        {"Smithsonian Astrophysical Observation", "SAO 234699"},
        {"Wilson Evans Batten Catalogue", "WEB 6536"},
    },
    visualMagnitude: 5.81,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.47383863),
        dec: Angle.Degrees(-52.40971351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215147"},
        {"Hipparcos Number", "HIP 112251"},
        {"Renson", "Renson 59460"},
        {"Smithsonian Astrophysical Observation", "SAO 247559"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.03797579),
        dec: Angle.Degrees(-52.40942282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114773"},
        {"Hipparcos Number", "HIP 64519"},
        {"Geneva Identification System", "GEN# +1.00114773"},
        {"Smithsonian Astrophysical Observation", "SAO 240656"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.35756901),
        dec: Angle.Degrees(-52.40732393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148308"},
        {"Hipparcos Number", "HIP 80790"},
        {"Fundamental Katalog 5th Edition", "FK5 5459"},
        {"Smithsonian Astrophysical Observation", "SAO 243880"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.44116265),
        dec: Angle.Degrees(-52.40477589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96805"},
        {"Hipparcos Number", "HIP 54424"},
        {"Geneva Identification System", "GEN# +1.00096805"},
        {"Smithsonian Astrophysical Observation", "SAO 238805"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.05639258),
        dec: Angle.Degrees(-52.40248108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 115.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197600"},
        {"Hipparcos Number", "HIP 102550"},
        {"Smithsonian Astrophysical Observation", "SAO 246728"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.72035881),
        dec: Angle.Degrees(-52.40132395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194572"},
        {"Hipparcos Number", "HIP 101001"},
        {"Smithsonian Astrophysical Observation", "SAO 246601"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.16002937),
        dec: Angle.Degrees(-52.40104696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33379"},
        {"Hipparcos Number", "HIP 23808"},
        {"Smithsonian Astrophysical Observation", "SAO 233829"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.75808145),
        dec: Angle.Degrees(-52.40078072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174121"},
        {"Hipparcos Number", "HIP 92567"},
        {"Smithsonian Astrophysical Observation", "SAO 245759"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.94165321),
        dec: Angle.Degrees(-52.39518669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107719"},
        {"Hipparcos Number", "HIP 60390"},
        {"Smithsonian Astrophysical Observation", "SAO 239903"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.73661128),
        dec: Angle.Degrees(-52.39006035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170948"},
        {"Hipparcos Number", "HIP 91093"},
        {"Fundamental Katalog 5th Edition", "FK5 3473"},
        {"Smithsonian Astrophysical Observation", "SAO 245562"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.72342329),
        dec: Angle.Degrees(-52.38735081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96282"},
        {"Hipparcos Number", "HIP 54202"},
        {"Smithsonian Astrophysical Observation", "SAO 238752"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.33145259),
        dec: Angle.Degrees(-52.38595572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130454"},
        {"Hipparcos Number", "HIP 72572"},
        {"Geneva Identification System", "GEN# +1.00130454"},
        {"Smithsonian Astrophysical Observation", "SAO 242050"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.57597990),
        dec: Angle.Degrees(-52.38531894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94256"},
        {"Hipparcos Number", "HIP 53103"},
        {"Smithsonian Astrophysical Observation", "SAO 238538"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.95711921),
        dec: Angle.Degrees(-52.38467580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109342"},
        {"Hipparcos Number", "HIP 61352"},
        {"Smithsonian Astrophysical Observation", "SAO 240068"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.57030526),
        dec: Angle.Degrees(-52.38414605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129893"},
        {"Hipparcos Number", "HIP 72290"},
        {"Fundamental Katalog 5th Edition", "FK5 546"},
        {"Geneva Identification System", "GEN# +1.00129893"},
        {"Smithsonian Astrophysical Observation", "SAO 241992"},
        {"Wilson Evans Batten Catalogue", "WEB 12431"},
    },
    visualMagnitude: 5.22,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.75546088),
        dec: Angle.Degrees(-52.38331777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21462"},
        {"Hipparcos Number", "HIP 15957"},
        {"Smithsonian Astrophysical Observation", "SAO 233112"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.35384298),
        dec: Angle.Degrees(-52.38168611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149401"},
        {"Hipparcos Number", "HIP 81376"},
        {"Smithsonian Astrophysical Observation", "SAO 243994"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.28545936),
        dec: Angle.Degrees(-52.38163143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123959"},
        {"Hipparcos Number", "HIP 69381"},
        {"Smithsonian Astrophysical Observation", "SAO 241525"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.04216991),
        dec: Angle.Degrees(-52.38159862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113870"},
        {"Hipparcos Number", "HIP 64006"},
        {"Geneva Identification System", "GEN# +1.00113870"},
        {"Smithsonian Astrophysical Observation", "SAO 204134"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.73530256),
        dec: Angle.Degrees(-34.12173307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298983"},
        {"Hipparcos Number", "HIP 50298"},
        {"Geneva Identification System", "GEN# +1.00298983"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.04686795),
        dec: Angle.Degrees(-52.37938474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116469"},
        {"Hipparcos Number", "HIP 65452"},
        {"Smithsonian Astrophysical Observation", "SAO 240820"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.21567800),
        dec: Angle.Degrees(-52.37897437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200540"},
        {"Hipparcos Number", "HIP 104153"},
        {"Geneva Identification System", "GEN# +1.00200540"},
        {"Smithsonian Astrophysical Observation", "SAO 246866"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.51903355),
        dec: Angle.Degrees(-52.37892839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93325",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93325"},
        {"Geneva Identification System", "GEN# +6.20145027"},
    },
    visualMagnitude: 12.10,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.12533248),
        dec: Angle.Degrees(-52.37642899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3158"},
        {"Hipparcos Number", "HIP 2711"},
        {"Fundamental Katalog 5th Edition", "FK5 1014"},
        {"Geneva Identification System", "GEN# +1.00003158"},
        {"Smithsonian Astrophysical Observation", "SAO 232091"},
        {"Wilson Evans Batten Catalogue", "WEB 490"},
    },
    visualMagnitude: 5.57,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.61506261),
        dec: Angle.Degrees(-52.37318294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 227.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139129"},
        {"Hipparcos Number", "HIP 76618"},
        {"Fundamental Katalog 5th Edition", "FK5 1411"},
        {"Geneva Identification System", "GEN# +1.00139129"},
        {"Smithsonian Astrophysical Observation", "SAO 242793"},
        {"Wilson Evans Batten Catalogue", "WEB 13006"},
    },
    visualMagnitude: 5.43,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.70626982),
        dec: Angle.Degrees(-52.37261965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118868"},
        {"Hipparcos Number", "HIP 66736"},
        {"Smithsonian Astrophysical Observation", "SAO 241063"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.18317883),
        dec: Angle.Degrees(-52.37072531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145846"},
        {"Hipparcos Number", "HIP 79674"},
        {"Geneva Identification System", "GEN# +1.00145846"},
        {"Smithsonian Astrophysical Observation", "SAO 243514"},
        {"Wilson Evans Batten Catalogue", "WEB 13484"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.91675424),
        dec: Angle.Degrees(-52.37027418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105937"},
        {"Hipparcos Number", "HIP 59449"},
        {"Geneva Identification System", "GEN# +1.00105937"},
        {"Smithsonian Astrophysical Observation", "SAO 239737"},
        {"Wilson Evans Batten Catalogue", "WEB 10567"},
    },
    visualMagnitude: 3.97,
    bvColour: -0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.91313090),
        dec: Angle.Degrees(-52.36841559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9207"},
        {"Hipparcos Number", "HIP 6958"},
        {"Smithsonian Astrophysical Observation", "SAO 232437"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.38636559),
        dec: Angle.Degrees(-52.36611096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61518"},
        {"Hipparcos Number", "HIP 37068"},
        {"Geneva Identification System", "GEN# +1.00061518"},
        {"Smithsonian Astrophysical Observation", "SAO 235361"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.26177049),
        dec: Angle.Degrees(-52.36585581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49337"},
        {"Hipparcos Number", "HIP 32343"},
        {"Geneva Identification System", "GEN# +1.00049337"},
        {"Smithsonian Astrophysical Observation", "SAO 234689"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.27306289),
        dec: Angle.Degrees(-52.36243036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101846"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.58289912),
        dec: Angle.Degrees(-52.36062991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -196.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205877"},
        {"Hipparcos Number", "HIP 106978"},
        {"Fundamental Katalog 5th Edition", "FK5 3726"},
        {"Geneva Identification System", "GEN# +1.00205877"},
        {"Smithsonian Astrophysical Observation", "SAO 247128"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.99889909),
        dec: Angle.Degrees(-52.35902626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3306"},
        {"Cincinnati Publication", "Ci 20 47"},
    },
    visualMagnitude: 12.20,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.53458045),
        dec: Angle.Degrees(-52.35817438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 628.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -329.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94900"},
        {"Smithsonian Astrophysical Observation", "SAO 246020"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.67779074),
        dec: Angle.Degrees(-52.35633853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97884"},
        {"Hipparcos Number", "HIP 54934"},
        {"Geneva Identification System", "GEN# +1.00097884"},
        {"Smithsonian Astrophysical Observation", "SAO 238899"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.73714781),
        dec: Angle.Degrees(-52.35433242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104897"},
        {"Hipparcos Number", "HIP 58899"},
        {"Smithsonian Astrophysical Observation", "SAO 239643"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.18546392),
        dec: Angle.Degrees(-52.35431770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65000"},
        {"Hipparcos Number", "HIP 38585"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.51702433),
        dec: Angle.Degrees(-52.35233074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15545"},
        {"Hipparcos Number", "HIP 11502"},
        {"Geneva Identification System", "GEN# +1.00015545"},
        {"Smithsonian Astrophysical Observation", "SAO 232783"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.07619859),
        dec: Angle.Degrees(-52.35066622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79344",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79344"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.89611225),
        dec: Angle.Degrees(-52.34986376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100452"},
        {"Hipparcos Number", "HIP 56357"},
        {"Smithsonian Astrophysical Observation", "SAO 239163"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.28854621),
        dec: Angle.Degrees(-52.34958205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56934",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56934"},
    },
    visualMagnitude: 12.47,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)40, 18.8800),
        dec: Angle.DegreesMinutesSeconds((int)-52, (int)20, 51.400)
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
    primaryId: "HIP 37966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63563"},
        {"Hipparcos Number", "HIP 37966"},
        {"Celescope Catalog", "CEL 2036"},
        {"Geneva Identification System", "GEN# +1.00063563"},
        {"Renson", "Renson 17515"},
        {"Smithsonian Astrophysical Observation", "SAO 235508"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.73627350),
        dec: Angle.Degrees(-52.34717802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47721"},
        {"Hipparcos Number", "HIP 31630"},
        {"Smithsonian Astrophysical Observation", "SAO 234614"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.28047394),
        dec: Angle.Degrees(-52.34715110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12296",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12296"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.59628255),
        dec: Angle.Degrees(-52.34650099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177171"},
        {"Hipparcos Number", "HIP 93815"},
        {"Geneva Identification System", "GEN# +1.00177171"},
        {"Smithsonian Astrophysical Observation", "SAO 245921"},
        {"Wilson Evans Batten Catalogue", "WEB 16309"},
    },
    visualMagnitude: 5.17,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.58301929),
        dec: Angle.Degrees(-52.34063012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47427"},
        {"Hipparcos Number", "HIP 31482"},
        {"Smithsonian Astrophysical Observation", "SAO 234595"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.90145938),
        dec: Angle.Degrees(-52.33937341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201427"},
        {"Hipparcos Number", "HIP 104604"},
        {"Smithsonian Astrophysical Observation", "SAO 246896"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.84502064),
        dec: Angle.Degrees(-52.33929197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7913"},
        {"Hipparcos Number", "HIP 6051"},
        {"Smithsonian Astrophysical Observation", "SAO 232366"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.42799152),
        dec: Angle.Degrees(-52.33864329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3669"},
        {"Hipparcos Number", "HIP 3068"},
        {"Smithsonian Astrophysical Observation", "SAO 232130"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.73338062),
        dec: Angle.Degrees(-52.33670168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105269"},
        {"Hipparcos Number", "HIP 59105"},
        {"Smithsonian Astrophysical Observation", "SAO 239678"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.80730416),
        dec: Angle.Degrees(-52.33623409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186061"},
        {"Hipparcos Number", "HIP 97156"},
        {"Geneva Identification System", "GEN# +1.00186061"},
        {"Smithsonian Astrophysical Observation", "SAO 246245"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.21851623),
        dec: Angle.Degrees(-52.33611437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193941"},
        {"Hipparcos Number", "HIP 100729"},
        {"Smithsonian Astrophysical Observation", "SAO 246573"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.32524446),
        dec: Angle.Degrees(-52.33607093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 838"},
        {"Hipparcos Number", "HIP 1002"},
        {"Smithsonian Astrophysical Observation", "SAO 231971"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.13317674),
        dec: Angle.Degrees(-52.33337574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209161"},
        {"Hipparcos Number", "HIP 108813"},
        {"Smithsonian Astrophysical Observation", "SAO 247283"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.65533123),
        dec: Angle.Degrees(-52.33324847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80626"},
        {"Hipparcos Number", "HIP 45698"},
        {"Smithsonian Astrophysical Observation", "SAO 236842"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.74467465),
        dec: Angle.Degrees(-52.33261653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223724"},
        {"Hipparcos Number", "HIP 117701"},
        {"Smithsonian Astrophysical Observation", "SAO 248046"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.05287230),
        dec: Angle.Degrees(-52.33247197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89494"},
        {"Hipparcos Number", "HIP 50471"},
        {"Smithsonian Astrophysical Observation", "SAO 237892"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.58831637),
        dec: Angle.Degrees(-52.33158900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166355"},
        {"Hipparcos Number", "HIP 89286"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.28825236),
        dec: Angle.Degrees(-52.33127431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160799"},
        {"Hipparcos Number", "HIP 86843"},
        {"Geneva Identification System", "GEN# +1.00160799"},
        {"Smithsonian Astrophysical Observation", "SAO 244990"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.16438470),
        dec: Angle.Degrees(-52.33090633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47001"},
        {"Hipparcos Number", "HIP 31265"},
        {"Geneva Identification System", "GEN# +1.00047001"},
        {"Smithsonian Astrophysical Observation", "SAO 234574"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.35963588),
        dec: Angle.Degrees(-52.32931746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31507"},
        {"Hipparcos Number", "HIP 22748"},
        {"Smithsonian Astrophysical Observation", "SAO 233726"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.40349333),
        dec: Angle.Degrees(-52.32917373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 429"},
        {"Hipparcos Number", "HIP 702"},
        {"Smithsonian Astrophysical Observation", "SAO 231942"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.18732032),
        dec: Angle.Degrees(-52.32795054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125400"},
        {"Hipparcos Number", "HIP 70103"},
        {"Geneva Identification System", "GEN# +1.00125400"},
        {"Smithsonian Astrophysical Observation", "SAO 241651"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.17673558),
        dec: Angle.Degrees(-52.32578107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27245"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.61799085),
        dec: Angle.Degrees(-52.32404294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73341"},
        {"Hipparcos Number", "HIP 42161"},
        {"Smithsonian Astrophysical Observation", "SAO 236108"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.92103390),
        dec: Angle.Degrees(-52.32234158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125498"},
        {"Hipparcos Number", "HIP 70164"},
        {"Geneva Identification System", "GEN# +1.00125498"},
        {"Smithsonian Astrophysical Observation", "SAO 241657"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.33839469),
        dec: Angle.Degrees(-52.32146912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42170"},
        {"Hipparcos Number", "HIP 28924"},
        {"Smithsonian Astrophysical Observation", "SAO 234309"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.57691012),
        dec: Angle.Degrees(-52.32128276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220429"},
        {"Hipparcos Number", "HIP 115531"},
        {"Smithsonian Astrophysical Observation", "SAO 247857"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.03919282),
        dec: Angle.Degrees(-52.32039022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195912"},
        {"Hipparcos Number", "HIP 101655"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.09337682),
        dec: Angle.Degrees(-52.31996487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3243",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3243"},
    },
    visualMagnitude: 10.84,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.31330599),
        dec: Angle.Degrees(-52.31720615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35860"},
        {"Hipparcos Number", "HIP 25303"},
        {"Geneva Identification System", "GEN# +1.00035860"},
        {"Smithsonian Astrophysical Observation", "SAO 233965"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.19288289),
        dec: Angle.Degrees(-52.31617828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187520"},
        {"Hipparcos Number", "HIP 97843"},
        {"Smithsonian Astrophysical Observation", "SAO 246315"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.24561245),
        dec: Angle.Degrees(-52.31525662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14615"},
        {"Hipparcos Number", "HIP 10876"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.99216717),
        dec: Angle.Degrees(-52.31467667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74044"},
        {"Hipparcos Number", "HIP 42450"},
        {"Geneva Identification System", "GEN# +3.23910011"},
        {"Renson", "Renson 20620"},
        {"Smithsonian Astrophysical Observation", "SAO 236149"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.81896386),
        dec: Angle.Degrees(-52.31388821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35859"},
        {"Hipparcos Number", "HIP 25298"},
        {"Geneva Identification System", "GEN# +1.00035859"},
        {"Smithsonian Astrophysical Observation", "SAO 233964"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.17636352),
        dec: Angle.Degrees(-52.31297479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30082"},
        {"Hipparcos Number", "HIP 21838"},
        {"Smithsonian Astrophysical Observation", "SAO 233630"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.42610260),
        dec: Angle.Degrees(-52.31230237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35564"},
    },
    visualMagnitude: 5.50,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.08940661),
        dec: Angle.Degrees(-52.31188250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 147.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108604"},
        {"Hipparcos Number", "HIP 60899"},
        {"Geneva Identification System", "GEN# +1.00108604"},
        {"Smithsonian Astrophysical Observation", "SAO 239984"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.21237957),
        dec: Angle.Degrees(-52.30889295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155708"},
        {"Hipparcos Number", "HIP 84456"},
        {"Smithsonian Astrophysical Observation", "SAO 244568"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.99579038),
        dec: Angle.Degrees(-52.30782790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119725"},
        {"Hipparcos Number", "HIP 67182"},
        {"Smithsonian Astrophysical Observation", "SAO 241149"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.51791331),
        dec: Angle.Degrees(-52.30748233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155521"},
        {"Hipparcos Number", "HIP 84365"},
        {"Smithsonian Astrophysical Observation", "SAO 244550"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.71539543),
        dec: Angle.Degrees(-52.30651216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106970"},
        {"Hipparcos Number", "HIP 59987"},
        {"Geneva Identification System", "GEN# +1.00106970"},
        {"Smithsonian Astrophysical Observation", "SAO 239822"},
    },
    visualMagnitude: 6.84,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.54627420),
        dec: Angle.Degrees(-52.30628900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82457"},
        {"Hipparcos Number", "HIP 46614"},
        {"Celescope Catalog", "CEL 3314"},
        {"Geneva Identification System", "GEN# +1.00082457"},
        {"Smithsonian Astrophysical Observation", "SAO 237051"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.57796102),
        dec: Angle.Degrees(-52.30570976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93692"},
        {"Hipparcos Number", "HIP 52834"},
        {"Geneva Identification System", "GEN# +1.00093692"},
        {"Smithsonian Astrophysical Observation", "SAO 238492"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.04963345),
        dec: Angle.Degrees(-52.30466193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14591"},
        {"Hipparcos Number", "HIP 10857"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.93545883),
        dec: Angle.Degrees(-52.30439320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96913"},
        {"Hipparcos Number", "HIP 54490"},
        {"Smithsonian Astrophysical Observation", "SAO 238817"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.22918444),
        dec: Angle.Degrees(-52.30399843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217538"},
        {"Hipparcos Number", "HIP 113742"},
        {"Geneva Identification System", "GEN# +1.00217538"},
        {"Smithsonian Astrophysical Observation", "SAO 247691"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.52659685),
        dec: Angle.Degrees(-52.30353777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115781",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "HD 220829BC"},
        {"Hipparcos Number", "HIP 115781"},
    },
    visualMagnitude: 13.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.84787774),
        dec: Angle.Degrees(-52.30309700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220829"},
        {"Hipparcos Number", "HIP 115780"},
        {"Smithsonian Astrophysical Observation", "SAO 247885"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.84308611),
        dec: Angle.Degrees(-52.30300898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137753"},
        {"Hipparcos Number", "HIP 75884"},
        {"Smithsonian Astrophysical Observation", "SAO 242614"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.49326295),
        dec: Angle.Degrees(-52.30281281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208783"},
        {"Hipparcos Number", "HIP 108611"},
        {"Geneva Identification System", "GEN# +1.00208783"},
        {"Smithsonian Astrophysical Observation", "SAO 247261"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.03111876),
        dec: Angle.Degrees(-52.30276465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204110"},
        {"Hipparcos Number", "HIP 106004"},
        {"Smithsonian Astrophysical Observation", "SAO 247038"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.04374715),
        dec: Angle.Degrees(-52.30238677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113201"},
    },
    visualMagnitude: 11.60,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.86276157),
        dec: Angle.Degrees(-52.30234371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68544",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68544"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.48345658),
        dec: Angle.Degrees(-52.30145933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93985"},
        {"Hipparcos Number", "HIP 52972"},
        {"Smithsonian Astrophysical Observation", "SAO 238517"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.51011757),
        dec: Angle.Degrees(-52.30095426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173933"},
        {"Hipparcos Number", "HIP 92482"},
        {"Geneva Identification System", "GEN# +1.00173933"},
        {"Smithsonian Astrophysical Observation", "SAO 245752"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.72141286),
        dec: Angle.Degrees(-52.29996132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147331"},
        {"Hipparcos Number", "HIP 80323"},
        {"Geneva Identification System", "GEN# +1.00147331"},
        {"Smithsonian Astrophysical Observation", "SAO 243743"},
        {"Wilson Evans Batten Catalogue", "WEB 13591"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.98552624),
        dec: Angle.Degrees(-52.29784416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79885"},
        {"Hipparcos Number", "HIP 45370"},
        {"Smithsonian Astrophysical Observation", "SAO 236753"},
    },
    visualMagnitude: 8.74,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.69045835),
        dec: Angle.Degrees(-52.29707361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157753"},
        {"Hipparcos Number", "HIP 85470"},
        {"Fundamental Katalog 5th Edition", "FK5 3386"},
        {"Geneva Identification System", "GEN# +1.00157753"},
        {"Smithsonian Astrophysical Observation", "SAO 244763"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.99006555),
        dec: Angle.Degrees(-52.29702909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5159"},
        {"Hipparcos Number", "HIP 4122"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.20855455),
        dec: Angle.Degrees(-52.29684140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161125"},
        {"Hipparcos Number", "HIP 86994"},
        {"Smithsonian Astrophysical Observation", "SAO 245014"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.65469102),
        dec: Angle.Degrees(-52.29501698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159750"},
        {"Hipparcos Number", "HIP 86393"},
        {"Smithsonian Astrophysical Observation", "SAO 244914"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.79147081),
        dec: Angle.Degrees(-52.29441827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65820"},
        {"Hipparcos Number", "HIP 38933"},
        {"Geneva Identification System", "GEN# +1.00065820"},
        {"Smithsonian Astrophysical Observation", "SAO 235644"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.49461219),
        dec: Angle.Degrees(-52.29406200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107695"},
        {"Hipparcos Number", "HIP 60374"},
        {"Smithsonian Astrophysical Observation", "SAO 239900"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.69412642),
        dec: Angle.Degrees(-52.29301205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120430"},
        {"Hipparcos Number", "HIP 67554"},
        {"Smithsonian Astrophysical Observation", "SAO 241218"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.64042874),
        dec: Angle.Degrees(-52.29222746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199933"},
        {"Hipparcos Number", "HIP 103820"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.57578703),
        dec: Angle.Degrees(-52.29159063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175098"},
        {"Hipparcos Number", "HIP 92979"},
        {"Smithsonian Astrophysical Observation", "SAO 245819"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.14062317),
        dec: Angle.Degrees(-52.28796235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123333"},
        {"Hipparcos Number", "HIP 69075"},
        {"Geneva Identification System", "GEN# +1.00123333"},
        {"Smithsonian Astrophysical Observation", "SAO 241474"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.08999978),
        dec: Angle.Degrees(-52.28741299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -200.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135551"},
        {"Hipparcos Number", "HIP 74859"},
        {"Smithsonian Astrophysical Observation", "SAO 242391"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.47139504),
        dec: Angle.Degrees(-52.28646748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92518"},
        {"Hipparcos Number", "HIP 52203"},
        {"Geneva Identification System", "GEN# +1.00092518"},
        {"Smithsonian Astrophysical Observation", "SAO 238321"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.99140311),
        dec: Angle.Degrees(-52.28412671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152527"},
        {"Hipparcos Number", "HIP 82902"},
        {"Geneva Identification System", "GEN# +1.00152527"},
        {"Smithsonian Astrophysical Observation", "SAO 244285"},
        {"Wilson Evans Batten Catalogue", "WEB 14016"},
    },
    visualMagnitude: 5.94,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.12000822),
        dec: Angle.Degrees(-52.28364331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110993"},
        {"Hipparcos Number", "HIP 62346"},
        {"Smithsonian Astrophysical Observation", "SAO 240239"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.63033361),
        dec: Angle.Degrees(-52.28234201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179116"},
        {"Hipparcos Number", "HIP 94391"},
        {"Geneva Identification System", "GEN# +1.00179116J"},
        {"Smithsonian Astrophysical Observation", "SAO 211045"},
    },
    visualMagnitude: 7.79,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.18300737),
        dec: Angle.Degrees(-33.85384693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73086",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73086"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.05426859),
        dec: Angle.Degrees(-52.28158764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58893"},
        {"Hipparcos Number", "HIP 35963"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.19982207),
        dec: Angle.Degrees(-52.27983426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84585"},
        {"Hipparcos Number", "HIP 47789"},
        {"Smithsonian Astrophysical Observation", "SAO 237289"},
    },
    visualMagnitude: 8.77,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.15006852),
        dec: Angle.Degrees(-52.27698413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130908"},
        {"Hipparcos Number", "HIP 72785"},
        {"Smithsonian Astrophysical Observation", "SAO 242082"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.16276695),
        dec: Angle.Degrees(-52.27674997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112009"},
        {"Hipparcos Number", "HIP 62946"},
        {"Smithsonian Astrophysical Observation", "SAO 240357"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.48585433),
        dec: Angle.Degrees(-52.27647396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59469"},
        {"Hipparcos Number", "HIP 36201"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.83540369),
        dec: Angle.Degrees(-52.27547553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153160"},
        {"Hipparcos Number", "HIP 83220"},
        {"Smithsonian Astrophysical Observation", "SAO 244347"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.11783496),
        dec: Angle.Degrees(-52.27393232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190483"},
        {"Hipparcos Number", "HIP 99141"},
        {"Smithsonian Astrophysical Observation", "SAO 246447"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.91450499),
        dec: Angle.Degrees(-52.27005616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298863"},
        {"Hipparcos Number", "HIP 49504"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.61295905),
        dec: Angle.Degrees(-52.26953688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183929"},
        {"Hipparcos Number", "HIP 96267"},
        {"Smithsonian Astrophysical Observation", "SAO 246168"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.61763462),
        dec: Angle.Degrees(-52.26953182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62842"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.18538274),
        dec: Angle.Degrees(-52.26930221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119884"},
        {"Hipparcos Number", "HIP 67260"},
        {"Celescope Catalog", "CEL 4280"},
        {"Geneva Identification System", "GEN# +1.00119884"},
        {"Smithsonian Astrophysical Observation", "SAO 241165"},
        {"Smithsonian Astrophysical Observation 2", "SAO 241167"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.79410990),
        dec: Angle.Degrees(-52.26921575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298354"},
        {"Hipparcos Number", "HIP 45650"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.57777065),
        dec: Angle.Degrees(-52.26881712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14121"},
        {"Hipparcos Number", "HIP 10508"},
        {"Smithsonian Astrophysical Observation", "SAO 232687"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.85733422),
        dec: Angle.Degrees(-52.26817135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217309"},
        {"Hipparcos Number", "HIP 113607"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.15389629),
        dec: Angle.Degrees(-52.26768398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5671"},
        {"Hipparcos Number", "HIP 4497"},
        {"Geneva Identification System", "GEN# +1.00005671"},
        {"Smithsonian Astrophysical Observation", "SAO 232237"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.40831471),
        dec: Angle.Degrees(-52.26611373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143056"},
        {"Hipparcos Number", "HIP 78415"},
        {"Smithsonian Astrophysical Observation", "SAO 243236"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.13073786),
        dec: Angle.Degrees(-52.26470747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130534"},
        {"Hipparcos Number", "HIP 72605"},
        {"Geneva Identification System", "GEN# +4.21180001"},
        {"Smithsonian Astrophysical Observation", "SAO 242059"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.67266939),
        dec: Angle.Degrees(-52.26463730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57659",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57659"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.36952165),
        dec: Angle.Degrees(-52.26408980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30317"},
        {"Hipparcos Number", "HIP 21999"},
        {"Geneva Identification System", "GEN# +1.00030317"},
        {"Smithsonian Astrophysical Observation", "SAO 233647"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.93479237),
        dec: Angle.Degrees(-52.26341247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107865"},
    },
    visualMagnitude: 11.47,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.80036647),
        dec: Angle.Degrees(-52.26066235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 257.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -220.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60205"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.18427431),
        dec: Angle.Degrees(-52.25691847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115855"},
        {"Hipparcos Number", "HIP 65126"},
        {"Smithsonian Astrophysical Observation", "SAO 240766"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.19677101),
        dec: Angle.Degrees(-52.25567966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174476"},
        {"Hipparcos Number", "HIP 92705"},
        {"Geneva Identification System", "GEN# +1.00174476"},
        {"Smithsonian Astrophysical Observation", "SAO 245786"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.35008525),
        dec: Angle.Degrees(-52.25488901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298437"},
        {"Hipparcos Number", "HIP 46611"},
        {"Smithsonian Astrophysical Observation", "SAO 237049"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.56736029),
        dec: Angle.Degrees(-52.25366428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210726"},
        {"Hipparcos Number", "HIP 109735"},
        {"Geneva Identification System", "GEN# +1.00210726"},
        {"Smithsonian Astrophysical Observation", "SAO 247363"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.43110580),
        dec: Angle.Degrees(-52.25310015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80294",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80294"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.85676343),
        dec: Angle.Degrees(-52.24928085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19264"},
        {"Hipparcos Number", "HIP 14251"},
        {"Smithsonian Astrophysical Observation", "SAO 232979"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.94982557),
        dec: Angle.Degrees(-52.24851111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211866"},
        {"Hipparcos Number", "HIP 110374"},
        {"Geneva Identification System", "GEN# +1.00211866"},
        {"Smithsonian Astrophysical Observation", "SAO 247418"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.34242786),
        dec: Angle.Degrees(-52.24826849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25006"},
        {"Hipparcos Number", "HIP 18384"},
        {"Smithsonian Astrophysical Observation", "SAO 233331"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.94947719),
        dec: Angle.Degrees(-52.24788975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23495"},
        {"Hipparcos Number", "HIP 17376"},
        {"Geneva Identification System", "GEN# +1.00023495"},
        {"Smithsonian Astrophysical Observation", "SAO 233240"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.80161780),
        dec: Angle.Degrees(-52.24759827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172708"},
        {"Hipparcos Number", "HIP 91930"},
        {"Geneva Identification System", "GEN# +1.00172708"},
        {"Smithsonian Astrophysical Observation", "SAO 245667"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.10990529),
        dec: Angle.Degrees(-52.24717050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12278"},
        {"Hipparcos Number", "HIP 9261"},
        {"Smithsonian Astrophysical Observation", "SAO 232592"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.76142342),
        dec: Angle.Degrees(-52.24702713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191325"},
        {"Hipparcos Number", "HIP 99517"},
        {"Smithsonian Astrophysical Observation", "SAO 246477"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.94952363),
        dec: Angle.Degrees(-52.24632007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93668"},
        {"Hipparcos Number", "HIP 52816"},
        {"Geneva Identification System", "GEN# +1.00093668"},
        {"Smithsonian Astrophysical Observation", "SAO 238484"},
    },
    visualMagnitude: 6.74,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.98119977),
        dec: Angle.Degrees(-52.24610816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141150"},
        {"Hipparcos Number", "HIP 77527"},
        {"Smithsonian Astrophysical Observation", "SAO 243016"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.45474438),
        dec: Angle.Degrees(-52.24483302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94348",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94348"},
        {"Geneva Identification System", "GEN# +6.20145030"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.05498534),
        dec: Angle.Degrees(-52.24250153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165273"},
        {"Hipparcos Number", "HIP 88835"},
        {"Smithsonian Astrophysical Observation", "SAO 245256"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.00830614),
        dec: Angle.Degrees(-52.23773427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125071"},
        {"Hipparcos Number", "HIP 69935"},
        {"Geneva Identification System", "GEN# +1.00125071"},
        {"Smithsonian Astrophysical Observation", "SAO 241622"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.67558371),
        dec: Angle.Degrees(-52.23744192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69171"},
        {"Hipparcos Number", "HIP 40251"},
        {"Smithsonian Astrophysical Observation", "SAO 235818"},
    },
    visualMagnitude: 7.16,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.31287868),
        dec: Angle.Degrees(-52.23619284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187068"},
        {"Hipparcos Number", "HIP 97625"},
        {"Fundamental Katalog 5th Edition", "FK5 5752"},
        {"Smithsonian Astrophysical Observation", "SAO 246294"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.63134337),
        dec: Angle.Degrees(-52.23493602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222971"},
        {"Hipparcos Number", "HIP 117191"},
        {"Smithsonian Astrophysical Observation", "SAO 248009"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.42692674),
        dec: Angle.Degrees(-52.23437283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58211",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58211"},
    },
    visualMagnitude: 11.02,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.08441154),
        dec: Angle.Degrees(-52.23429420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154139"},
        {"Hipparcos Number", "HIP 83694"},
        {"Smithsonian Astrophysical Observation", "SAO 244437"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.58571261),
        dec: Angle.Degrees(-52.23198530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91370"},
        {"Hipparcos Number", "HIP 51558"},
        {"Smithsonian Astrophysical Observation", "SAO 238152"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.96585983),
        dec: Angle.Degrees(-52.23196047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31394"},
        {"Hipparcos Number", "HIP 22698"},
        {"Smithsonian Astrophysical Observation", "SAO 233721"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.19814781),
        dec: Angle.Degrees(-52.23122885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8392"},
        {"Hipparcos Number", "HIP 6394"},
        {"Smithsonian Astrophysical Observation", "SAO 232397"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.53908113),
        dec: Angle.Degrees(-52.23111612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70703"},
        {"Hipparcos Number", "HIP 40916"},
        {"Geneva Identification System", "GEN# +1.00070703"},
        {"Smithsonian Astrophysical Observation", "SAO 235908"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.25200275),
        dec: Angle.Degrees(-52.22801676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58210",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58210"},
        {"Smithsonian Astrophysical Observation", "SAO 239506"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.08131398),
        dec: Angle.Degrees(-52.22766279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191698"},
        {"Hipparcos Number", "HIP 99684"},
        {"Smithsonian Astrophysical Observation", "SAO 246492"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.42769810),
        dec: Angle.Degrees(-52.22653992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216293"},
        {"Hipparcos Number", "HIP 112965"},
        {"Geneva Identification System", "GEN# +1.00216293"},
        {"Smithsonian Astrophysical Observation", "SAO 247625"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.15904368),
        dec: Angle.Degrees(-52.22520866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98690"},
        {"Hipparcos Number", "HIP 55411"},
        {"Smithsonian Astrophysical Observation", "SAO 238983"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.22217537),
        dec: Angle.Degrees(-52.22514548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93416"},
        {"Hipparcos Number", "HIP 52677"},
        {"Smithsonian Astrophysical Observation", "SAO 238453"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.56693842),
        dec: Angle.Degrees(-52.22407182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211535"},
        {"Hipparcos Number", "HIP 110178"},
        {"Smithsonian Astrophysical Observation", "SAO 247403"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.75197563),
        dec: Angle.Degrees(-52.22344249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170947"},
        {"Hipparcos Number", "HIP 91094"},
        {"Smithsonian Astrophysical Observation", "SAO 245563"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.72837774),
        dec: Angle.Degrees(-52.21920971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105874"},
        {"Hipparcos Number", "HIP 59413"},
        {"Smithsonian Astrophysical Observation", "SAO 239730"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.81185007),
        dec: Angle.Degrees(-52.21752835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141054"},
        {"Hipparcos Number", "HIP 77480"},
        {"Fundamental Katalog 5th Edition", "FK5 5399"},
        {"Smithsonian Astrophysical Observation", "SAO 243008"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.30700927),
        dec: Angle.Degrees(-52.21581817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132999"},
        {"Hipparcos Number", "HIP 73718"},
        {"Smithsonian Astrophysical Observation", "SAO 242199"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.03476215),
        dec: Angle.Degrees(-52.21319283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209388"},
        {"Hipparcos Number", "HIP 108956"},
        {"Geneva Identification System", "GEN# +1.00209388"},
        {"Smithsonian Astrophysical Observation", "SAO 247296"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.10785634),
        dec: Angle.Degrees(-52.21274245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148903"},
        {"Hipparcos Number", "HIP 81112"},
        {"Geneva Identification System", "GEN# +1.00148903"},
        {"Smithsonian Astrophysical Observation", "SAO 243950"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.49143563),
        dec: Angle.Degrees(-52.21258914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205068"},
        {"Hipparcos Number", "HIP 106523"},
        {"Smithsonian Astrophysical Observation", "SAO 247091"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.63624812),
        dec: Angle.Degrees(-52.21029052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74713"},
        {"Hipparcos Number", "HIP 42809"},
        {"Geneva Identification System", "GEN# +1.00074713"},
        {"Smithsonian Astrophysical Observation", "SAO 236220"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.84220680),
        dec: Angle.Degrees(-52.20890356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158828"},
        {"Hipparcos Number", "HIP 85971"},
        {"Smithsonian Astrophysical Observation", "SAO 244853"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.55420717),
        dec: Angle.Degrees(-52.20852178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14151"},
        {"Hipparcos Number", "HIP 10536"},
        {"Geneva Identification System", "GEN# +1.00014151"},
        {"Smithsonian Astrophysical Observation", "SAO 232689"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.93080838),
        dec: Angle.Degrees(-52.20681234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62940"},
        {"Hipparcos Number", "HIP 37676"},
        {"Smithsonian Astrophysical Observation", "SAO 235453"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.95177319),
        dec: Angle.Degrees(-52.20595014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129932"},
        {"Hipparcos Number", "HIP 72308"},
        {"Geneva Identification System", "GEN# +1.00129932"},
        {"Smithsonian Astrophysical Observation", "SAO 241995"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.80246860),
        dec: Angle.Degrees(-52.20524925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54792"},
        {"Hipparcos Number", "HIP 34370"},
        {"Smithsonian Astrophysical Observation", "SAO 234943"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.86596575),
        dec: Angle.Degrees(-52.20467501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40767"},
        {"Hipparcos Number", "HIP 28240"},
        {"Smithsonian Astrophysical Observation", "SAO 234227"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.51098143),
        dec: Angle.Degrees(-52.20466444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223223"},
        {"Hipparcos Number", "HIP 117361"},
        {"Geneva Identification System", "GEN# +1.00223223"},
        {"Smithsonian Astrophysical Observation", "SAO 248020"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.94902934),
        dec: Angle.Degrees(-52.20442788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89174"},
        {"Hipparcos Number", "HIP 50269"},
        {"Geneva Identification System", "GEN# +1.00089174"},
        {"Smithsonian Astrophysical Observation", "SAO 237847"},
        {"Wilson Evans Batten Catalogue", "WEB 9233"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.96173386),
        dec: Angle.Degrees(-52.20407751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49396"},
        {"Hipparcos Number", "HIP 32375"},
        {"Geneva Identification System", "GEN# +1.00049396"},
        {"Smithsonian Astrophysical Observation", "SAO 234693"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.35855546),
        dec: Angle.Degrees(-52.20093117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171986"},
        {"Hipparcos Number", "HIP 91575"},
        {"Smithsonian Astrophysical Observation", "SAO 245626"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.10218091),
        dec: Angle.Degrees(-52.20086426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12108"},
        {"Hipparcos Number", "HIP 9114"},
        {"Smithsonian Astrophysical Observation", "SAO 232585"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.37209253),
        dec: Angle.Degrees(-52.20022556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149443"},
        {"Hipparcos Number", "HIP 81399"},
        {"Smithsonian Astrophysical Observation", "SAO 243999"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.37297635),
        dec: Angle.Degrees(-52.20000836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57918"},
        {"Hipparcos Number", "HIP 35588"},
        {"Smithsonian Astrophysical Observation", "SAO 235117"},
    },
    visualMagnitude: 6.90,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.16258840),
        dec: Angle.Degrees(-52.19871393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35585",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35585"},
        {"Smithsonian Astrophysical Observation", "SAO 235113"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.14973692),
        dec: Angle.Degrees(-52.19743691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107959"},
        {"Hipparcos Number", "HIP 60540"},
        {"Geneva Identification System", "GEN# +1.00107959"},
        {"Smithsonian Astrophysical Observation", "SAO 239928"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.16166702),
        dec: Angle.Degrees(-52.19684949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210919"},
        {"Hipparcos Number", "HIP 109855"},
        {"Smithsonian Astrophysical Observation", "SAO 247373"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.74759755),
        dec: Angle.Degrees(-52.19655670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80922"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.87021427),
        dec: Angle.Degrees(-52.19621666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224411"},
        {"Hipparcos Number", "HIP 118128"},
        {"Renson", "Renson 61480"},
        {"Smithsonian Astrophysical Observation", "SAO 248079"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.41490164),
        dec: Angle.Degrees(-52.19579458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102771"},
        {"Hipparcos Number", "HIP 57684"},
        {"Smithsonian Astrophysical Observation", "SAO 239407"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.45637722),
        dec: Angle.Degrees(-52.19557475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51121"},
        {"Hipparcos Number", "HIP 33065"},
        {"Smithsonian Astrophysical Observation", "SAO 234766"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.30560928),
        dec: Angle.Degrees(-52.19186696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77653"},
        {"Hipparcos Number", "HIP 44337"},
        {"Celescope Catalog", "CEL 3152"},
        {"Geneva Identification System", "GEN# +1.00077653J"},
        {"Renson", "Renson 21970"},
        {"Smithsonian Astrophysical Observation", "SAO 236518"},
        {"Wilson Evans Batten Catalogue", "WEB 8501"},
    },
    visualMagnitude: 5.23,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.43572156),
        dec: Angle.Degrees(-52.18871825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87816"},
        {"Hipparcos Number", "HIP 49477"},
        {"Geneva Identification System", "GEN# +1.00087816"},
        {"Smithsonian Astrophysical Observation", "SAO 237690"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.53026467),
        dec: Angle.Degrees(-52.18797821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116084"},
        {"Hipparcos Number", "HIP 65247"},
        {"Celescope Catalog", "CEL 4244"},
        {"Geneva Identification System", "GEN# +1.00116084"},
        {"Smithsonian Astrophysical Observation", "SAO 240782"},
        {"Wilson Evans Batten Catalogue", "WEB 11515"},
    },
    visualMagnitude: 5.81,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.56787422),
        dec: Angle.Degrees(-52.18295165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34587"},
        {"Hipparcos Number", "HIP 24520"},
        {"Geneva Identification System", "GEN# +1.00034587"},
        {"Smithsonian Astrophysical Observation", "SAO 233895"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.91166823),
        dec: Angle.Degrees(-52.18223022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91677"},
        {"Hipparcos Number", "HIP 51724"},
        {"Geneva Identification System", "GEN# +1.00091677"},
        {"Smithsonian Astrophysical Observation", "SAO 238193"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.52662649),
        dec: Angle.Degrees(-52.18180798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79624"},
        {"Hipparcos Number", "HIP 45240"},
        {"Celescope Catalog", "CEL 3228"},
        {"Geneva Identification System", "GEN# +1.00079624"},
        {"Smithsonian Astrophysical Observation", "SAO 236724"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.32451877),
        dec: Angle.Degrees(-52.18173125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46502",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46502"},
    },
    visualMagnitude: 12.43,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.25592107),
        dec: Angle.Degrees(-52.18168411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33075"},
        {"Hipparcos Number", "HIP 23638"},
        {"Geneva Identification System", "GEN# +1.00033075"},
        {"Smithsonian Astrophysical Observation", "SAO 233811"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.21244809),
        dec: Angle.Degrees(-52.18078565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71035",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71035"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.92046328),
        dec: Angle.Degrees(-52.18060861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46500",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 10.91,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)29, 00.5300),
        dec: Angle.DegreesMinutesSeconds((int)-52, (int)10, 48.500)
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
    primaryId: "HIP 98427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188907"},
        {"Hipparcos Number", "HIP 98427"},
        {"Smithsonian Astrophysical Observation", "SAO 246375"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.98090165),
        dec: Angle.Degrees(-52.17960968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108603"},
        {"Hipparcos Number", "HIP 60906"},
        {"Smithsonian Astrophysical Observation", "SAO 239986"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.23260949),
        dec: Angle.Degrees(-52.17832420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113453"},
        {"Hipparcos Number", "HIP 63799"},
        {"Smithsonian Astrophysical Observation", "SAO 240521"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.13969268),
        dec: Angle.Degrees(-52.17830252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192863"},
        {"Hipparcos Number", "HIP 100207"},
        {"Smithsonian Astrophysical Observation", "SAO 246529"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.86629340),
        dec: Angle.Degrees(-52.17679966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199489"},
        {"Hipparcos Number", "HIP 103620"},
        {"Smithsonian Astrophysical Observation", "SAO 246818"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.91765841),
        dec: Angle.Degrees(-52.17463637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157161"},
        {"Hipparcos Number", "HIP 85178"},
        {"Smithsonian Astrophysical Observation", "SAO 244709"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.10712349),
        dec: Angle.Degrees(-52.17359849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12767",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12767"},
    },
    visualMagnitude: 10.61,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.01764159),
        dec: Angle.Degrees(-52.16986926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 219.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25526"},
        {"Hipparcos Number", "HIP 18720"},
        {"Smithsonian Astrophysical Observation", "SAO 233357"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.16532685),
        dec: Angle.Degrees(-52.16969918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60218"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.22457601),
        dec: Angle.Degrees(-52.16532347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62848"},
        {"Hipparcos Number", "HIP 37635"},
        {"Geneva Identification System", "GEN# +1.00062848"},
        {"Smithsonian Astrophysical Observation", "SAO 235442"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.83975980),
        dec: Angle.Degrees(-52.16450303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 164.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88693"},
        {"Hipparcos Number", "HIP 49994"},
        {"Geneva Identification System", "GEN# +1.00088693"},
        {"Smithsonian Astrophysical Observation", "SAO 237784"},
    },
    visualMagnitude: 6.16,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.09572184),
        dec: Angle.Degrees(-52.16335203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201451"},
        {"Hipparcos Number", "HIP 104621"},
        {"Smithsonian Astrophysical Observation", "SAO 246898"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.89989526),
        dec: Angle.Degrees(-52.16286942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83171"},
        {"Hipparcos Number", "HIP 47004"},
        {"Smithsonian Astrophysical Observation", "SAO 237121"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.70265208),
        dec: Angle.Degrees(-52.16159167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121190"},
        {"Hipparcos Number", "HIP 67973"},
        {"Celescope Catalog", "CEL 4287"},
        {"Geneva Identification System", "GEN# +1.00121190"},
        {"Smithsonian Astrophysical Observation", "SAO 241294"},
        {"Wilson Evans Batten Catalogue", "WEB 11940"},
    },
    visualMagnitude: 5.66,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.80070669),
        dec: Angle.Degrees(-52.16076937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211054"},
        {"Hipparcos Number", "HIP 109923"},
        {"Fundamental Katalog 5th Edition", "FK5 5964"},
        {"Smithsonian Astrophysical Observation", "SAO 247380"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.95935723),
        dec: Angle.Degrees(-52.15849185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1781",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1781"},
        {"Smithsonian Astrophysical Observation", "SAO 232011"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.66376117),
        dec: Angle.Degrees(-52.15660381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55103"},
        {"Hipparcos Number", "HIP 34488"},
        {"Smithsonian Astrophysical Observation", "SAO 234958"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.20480125),
        dec: Angle.Degrees(-52.15469563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13235"},
        {"Hipparcos Number", "HIP 9921"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.92949102),
        dec: Angle.Degrees(-52.15449847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80780",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80780"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.41503659),
        dec: Angle.Degrees(-52.15444569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102176"},
        {"Hipparcos Number", "HIP 57327"},
        {"Smithsonian Astrophysical Observation", "SAO 239351"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.31972841),
        dec: Angle.Degrees(-52.15263967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66040"},
        {"Hipparcos Number", "HIP 39039"},
        {"Smithsonian Astrophysical Observation", "SAO 235659"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.80843134),
        dec: Angle.Degrees(-52.15154702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23"},
        {"Hipparcos Number", "HIP 420"},
        {"Geneva Identification System", "GEN# +1.00000023"},
        {"Smithsonian Astrophysical Observation", "SAO 231920"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.28166779),
        dec: Angle.Degrees(-52.15142338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140605"},
        {"Hipparcos Number", "HIP 77289"},
        {"Geneva Identification System", "GEN# +1.00140605"},
        {"Smithsonian Astrophysical Observation", "SAO 242951"},
        {"Wilson Evans Batten Catalogue", "WEB 13097"},
    },
    visualMagnitude: 7.08,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.69740765),
        dec: Angle.Degrees(-52.14615892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100409"},
        {"Hipparcos Number", "HIP 56317"},
        {"Smithsonian Astrophysical Observation", "SAO 239156"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.19483094),
        dec: Angle.Degrees(-52.14571567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105610"},
        {"Hipparcos Number", "HIP 59279"},
        {"Geneva Identification System", "GEN# +1.00105610"},
        {"Smithsonian Astrophysical Observation", "SAO 239706"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.40280539),
        dec: Angle.Degrees(-52.14403438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11912"},
        {"Hipparcos Number", "HIP 8977"},
        {"Smithsonian Astrophysical Observation", "SAO 232571"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.92460662),
        dec: Angle.Degrees(-52.14161101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82098",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82098"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.55686156),
        dec: Angle.Degrees(-52.13899999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222510"},
        {"Hipparcos Number", "HIP 116875"},
        {"Smithsonian Astrophysical Observation", "SAO 247978"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.35204609),
        dec: Angle.Degrees(-52.13715768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69728",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69728"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.08942010),
        dec: Angle.Degrees(-52.13708829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42627"},
        {"Hipparcos Number", "HIP 29142"},
        {"Smithsonian Astrophysical Observation", "SAO 234343"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.20258070),
        dec: Angle.Degrees(-52.13581236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204396"},
        {"Hipparcos Number", "HIP 106150"},
        {"Smithsonian Astrophysical Observation", "SAO 247052"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.52067727),
        dec: Angle.Degrees(-52.13486306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216378"},
        {"Hipparcos Number", "HIP 113016"},
        {"Smithsonian Astrophysical Observation", "SAO 247631"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.31302401),
        dec: Angle.Degrees(-52.13471190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14813"},
        {"Hipparcos Number", "HIP 10984"},
        {"Smithsonian Astrophysical Observation", "SAO 232729"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.39571379),
        dec: Angle.Degrees(-52.13448092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110402"},
        {"Hipparcos Number", "HIP 61994"},
        {"Geneva Identification System", "GEN# +1.00110402"},
        {"Smithsonian Astrophysical Observation", "SAO 240168"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.57378453),
        dec: Angle.Degrees(-52.12992781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76230"},
        {"Hipparcos Number", "HIP 43593"},
        {"Celescope Catalog", "CEL 3034"},
        {"Geneva Identification System", "GEN# +1.00076230J"},
        {"Smithsonian Astrophysical Observation", "SAO 236362"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.17011719),
        dec: Angle.Degrees(-52.12894176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111709"},
        {"Hipparcos Number", "HIP 62774"},
        {"Renson", "Renson 32420"},
        {"Smithsonian Astrophysical Observation", "SAO 240327"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.96156386),
        dec: Angle.Degrees(-52.12866800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85341"},
        {"Hipparcos Number", "HIP 48199"},
        {"Celescope Catalog", "CEL 3385"},
        {"Geneva Identification System", "GEN# +1.00085341"},
        {"Smithsonian Astrophysical Observation", "SAO 237381"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.38995139),
        dec: Angle.Degrees(-52.12732569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81220"},
        {"Hipparcos Number", "HIP 45977"},
        {"Smithsonian Astrophysical Observation", "SAO 236896"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.64193390),
        dec: Angle.Degrees(-52.12501049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56814"},
        {"Hipparcos Number", "HIP 35142"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.96393928),
        dec: Angle.Degrees(-52.12421153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22478"},
        {"Hipparcos Number", "HIP 16665"},
        {"Smithsonian Astrophysical Observation", "SAO 233165"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.62388541),
        dec: Angle.Degrees(-52.12386757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71043"},
        {"Hipparcos Number", "HIP 41081"},
        {"Geneva Identification System", "GEN# +1.00071043"},
        {"Smithsonian Astrophysical Observation", "SAO 235933"},
        {"Wilson Evans Batten Catalogue", "WEB 7960"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.72991589),
        dec: Angle.Degrees(-52.12377702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209527"},
        {"Hipparcos Number", "HIP 109048"},
        {"Smithsonian Astrophysical Observation", "SAO 247302"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.36275978),
        dec: Angle.Degrees(-52.12359327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1436"},
        {"Hipparcos Number", "HIP 1471"},
        {"Smithsonian Astrophysical Observation", "SAO 231992"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.57747565),
        dec: Angle.Degrees(-52.12342900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135688"},
        {"Hipparcos Number", "HIP 74910"},
        {"Smithsonian Astrophysical Observation", "SAO 242398"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.63250739),
        dec: Angle.Degrees(-52.12333681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142511"},
        {"Hipparcos Number", "HIP 78140"},
        {"Smithsonian Astrophysical Observation", "SAO 243157"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.33448125),
        dec: Angle.Degrees(-52.12268577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173794"},
        {"Hipparcos Number", "HIP 92412"},
        {"Smithsonian Astrophysical Observation", "SAO 245738"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.48859436),
        dec: Angle.Degrees(-52.12200279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102562"},
        {"Hipparcos Number", "HIP 57578"},
        {"Smithsonian Astrophysical Observation", "SAO 239382"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.05001304),
        dec: Angle.Degrees(-52.12105934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198829"},
        {"Hipparcos Number", "HIP 103260"},
        {"Smithsonian Astrophysical Observation", "SAO 246790"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.78402350),
        dec: Angle.Degrees(-52.11958400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113602"},
        {"Hipparcos Number", "HIP 63883"},
        {"Geneva Identification System", "GEN# +1.00113602"},
        {"Smithsonian Astrophysical Observation", "SAO 240535"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.37844611),
        dec: Angle.Degrees(-52.11568200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144696"},
        {"Hipparcos Number", "HIP 79179"},
        {"Smithsonian Astrophysical Observation", "SAO 243383"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.41115325),
        dec: Angle.Degrees(-52.11524483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41576"},
        {"Hipparcos Number", "HIP 28652"},
        {"Geneva Identification System", "GEN# +1.00041576"},
        {"Smithsonian Astrophysical Observation", "SAO 234273"},
        {"Wilson Evans Batten Catalogue", "WEB 5603"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.75502031),
        dec: Angle.Degrees(-52.11393920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26779"},
        {"Hipparcos Number", "HIP 19574"},
        {"Geneva Identification System", "GEN# +1.00026779"},
        {"Smithsonian Astrophysical Observation", "SAO 233428"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.91522804),
        dec: Angle.Degrees(-52.11139492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79278"},
        {"Hipparcos Number", "HIP 45095"},
        {"Celescope Catalog", "CEL 3205"},
        {"Geneva Identification System", "GEN# +1.00079278"},
        {"Smithsonian Astrophysical Observation", "SAO 236690"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.78831535),
        dec: Angle.Degrees(-52.11102906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39640"},
        {"Hipparcos Number", "HIP 27621"},
        {"Fundamental Katalog 5th Edition", "FK5 1159"},
        {"Geneva Identification System", "GEN# +1.00039640"},
        {"Smithsonian Astrophysical Observation", "SAO 234169"},
        {"Wilson Evans Batten Catalogue", "WEB 5424"},
    },
    visualMagnitude: 5.16,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.72174399),
        dec: Angle.Degrees(-52.10868730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168825"},
        {"Hipparcos Number", "HIP 90227"},
        {"Smithsonian Astrophysical Observation", "SAO 245447"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.14726931),
        dec: Angle.Degrees(-52.10770826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202341"},
        {"Hipparcos Number", "HIP 105067"},
        {"Smithsonian Astrophysical Observation", "SAO 246945"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.26088122),
        dec: Angle.Degrees(-52.10727688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174295"},
        {"Hipparcos Number", "HIP 92646"},
        {"Fundamental Katalog 5th Edition", "FK5 3499"},
        {"Geneva Identification System", "GEN# +1.00174295"},
        {"Smithsonian Astrophysical Observation", "SAO 245772"},
        {"Wilson Evans Batten Catalogue", "WEB 16027"},
    },
    visualMagnitude: 5.18,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.16502568),
        dec: Angle.Degrees(-52.10713766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7934"},
        {"Hipparcos Number", "HIP 6076"},
        {"Geneva Identification System", "GEN# +1.00007934"},
        {"Renson", "Renson 1980"},
        {"Smithsonian Astrophysical Observation", "SAO 232371"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.49645684),
        dec: Angle.Degrees(-52.10578927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66408",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66408"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.22195648),
        dec: Angle.Degrees(-52.10486664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150726"},
        {"Hipparcos Number", "HIP 82044"},
        {"Smithsonian Astrophysical Observation", "SAO 244118"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.39223139),
        dec: Angle.Degrees(-52.10399012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212984"},
        {"Hipparcos Number", "HIP 111007"},
        {"Smithsonian Astrophysical Observation", "SAO 247463"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.34318642),
        dec: Angle.Degrees(-52.10068314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103805"},
        {"Hipparcos Number", "HIP 58275"},
        {"Smithsonian Astrophysical Observation", "SAO 239520"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.27093637),
        dec: Angle.Degrees(-52.10025061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119341"},
        {"Hipparcos Number", "HIP 67003"},
        {"Fundamental Katalog 5th Edition", "FK5 5214"},
        {"Smithsonian Astrophysical Observation", "SAO 241118"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.97077736),
        dec: Angle.Degrees(-52.09960018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134505"},
        {"Hipparcos Number", "HIP 74395"},
        {"Fundamental Katalog 5th Edition", "FK5 558"},
        {"Geneva Identification System", "GEN# +1.00134505"},
        {"Smithsonian Astrophysical Observation", "SAO 242304"},
        {"Wilson Evans Batten Catalogue", "WEB 12699"},
    },
    visualMagnitude: 3.41,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.07167982),
        dec: Angle.Degrees(-52.09907465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96022"},
        {"Hipparcos Number", "HIP 54067"},
        {"Smithsonian Astrophysical Observation", "SAO 238722"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.94274762),
        dec: Angle.Degrees(-52.09807835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18754"},
        {"Hipparcos Number", "HIP 13889"},
        {"Geneva Identification System", "GEN# +1.00018754"},
        {"Smithsonian Astrophysical Observation", "SAO 232955"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.71268905),
        dec: Angle.Degrees(-52.09597316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217471"},
        {"Hipparcos Number", "HIP 113704"},
        {"Smithsonian Astrophysical Observation", "SAO 247686"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.43008833),
        dec: Angle.Degrees(-52.08713665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57917"},
        {"Hipparcos Number", "HIP 35589"},
        {"Geneva Identification System", "GEN# +1.00057917"},
        {"Smithsonian Astrophysical Observation", "SAO 235116"},
        {"Wilson Evans Batten Catalogue", "WEB 7089"},
    },
    visualMagnitude: 5.38,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.16172862),
        dec: Angle.Degrees(-52.08592527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79091"},
        {"Hipparcos Number", "HIP 45002"},
        {"Geneva Identification System", "GEN# +1.00079091"},
        {"Smithsonian Astrophysical Observation", "SAO 236673"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.48813265),
        dec: Angle.Degrees(-52.08299346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109195"},
        {"Hipparcos Number", "HIP 61257"},
        {"Geneva Identification System", "GEN# +1.00109195"},
        {"Smithsonian Astrophysical Observation", "SAO 240050"},
    },
    visualMagnitude: 6.55,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.30090532),
        dec: Angle.Degrees(-52.08281279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59576"},
        {"Hipparcos Number", "HIP 36252"},
        {"Smithsonian Astrophysical Observation", "SAO 235213"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.97285289),
        dec: Angle.Degrees(-52.08215492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80540",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80540"},
    },
    visualMagnitude: 9.88,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.65936056),
        dec: Angle.Degrees(-52.08183017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23721"},
        {"Hipparcos Number", "HIP 17507"},
        {"Smithsonian Astrophysical Observation", "SAO 233255"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.23647705),
        dec: Angle.Degrees(-52.08086910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24306"},
        {"Hipparcos Number", "HIP 17889"},
        {"Smithsonian Astrophysical Observation", "SAO 233291"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.39917420),
        dec: Angle.Degrees(-52.08001129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152043"},
        {"Hipparcos Number", "HIP 82661"},
        {"Smithsonian Astrophysical Observation", "SAO 244251"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.45917692),
        dec: Angle.Degrees(-52.07879189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8341"},
        {"Hipparcos Number", "HIP 6364"},
        {"Smithsonian Astrophysical Observation", "SAO 232393"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.43464901),
        dec: Angle.Degrees(-52.07652490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108498"},
        {"Hipparcos Number", "HIP 60835"},
        {"Geneva Identification System", "GEN# +1.00108498"},
        {"Smithsonian Astrophysical Observation", "SAO 239970"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.03429945),
        dec: Angle.Degrees(-52.07528751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95534"},
        {"Hipparcos Number", "HIP 53836"},
        {"Geneva Identification System", "GEN# +1.00095534"},
        {"Smithsonian Astrophysical Observation", "SAO 238692"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.20747218),
        dec: Angle.Degrees(-52.07496592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85867"},
        {"Hipparcos Number", "HIP 48478"},
        {"Smithsonian Astrophysical Observation", "SAO 237452"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.30695127),
        dec: Angle.Degrees(-52.07460841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128673"},
        {"Hipparcos Number", "HIP 71701"},
        {"Smithsonian Astrophysical Observation", "SAO 241892"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.00940105),
        dec: Angle.Degrees(-52.06546060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177480"},
        {"Hipparcos Number", "HIP 93927"},
        {"Smithsonian Astrophysical Observation", "SAO 245931"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.88486586),
        dec: Angle.Degrees(-52.06242317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124337"},
        {"Hipparcos Number", "HIP 69581"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.63951627),
        dec: Angle.Degrees(-52.06028110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69655"},
        {"Hipparcos Number", "HIP 40438"},
        {"Geneva Identification System", "GEN# +1.00069655"},
        {"Smithsonian Astrophysical Observation", "SAO 235839"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.85508167),
        dec: Angle.Degrees(-52.06016056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122479"},
        {"Hipparcos Number", "HIP 68677"},
        {"Celescope Catalog", "CEL 4297"},
        {"Geneva Identification System", "GEN# +1.00122479"},
        {"Smithsonian Astrophysical Observation", "SAO 241404"},
    },
    visualMagnitude: 7.38,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.87871854),
        dec: Angle.Degrees(-52.05938529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123734"},
        {"Hipparcos Number", "HIP 69286"},
        {"Geneva Identification System", "GEN# +1.00123734"},
        {"Smithsonian Astrophysical Observation", "SAO 241510"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.74062900),
        dec: Angle.Degrees(-52.05934417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179727"},
        {"Hipparcos Number", "HIP 94711"},
        {"Smithsonian Astrophysical Observation", "SAO 245999"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.08061396),
        dec: Angle.Degrees(-52.05890683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87844"},
        {"Hipparcos Number", "HIP 49498"},
        {"Geneva Identification System", "GEN# +1.00087844"},
        {"Smithsonian Astrophysical Observation", "SAO 237693"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.58622847),
        dec: Angle.Degrees(-52.05678376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31761",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31761"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.64991039),
        dec: Angle.Degrees(-52.05665165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 194.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208782"},
        {"Hipparcos Number", "HIP 108604"},
        {"Geneva Identification System", "GEN# +1.00208782"},
        {"Smithsonian Astrophysical Observation", "SAO 247260"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.01634467),
        dec: Angle.Degrees(-52.05659148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39875"},
        {"Hipparcos Number", "HIP 27749"},
        {"Smithsonian Astrophysical Observation", "SAO 234179"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.10217731),
        dec: Angle.Degrees(-52.05516300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118303"},
        {"Hipparcos Number", "HIP 66434"},
        {"Smithsonian Astrophysical Observation", "SAO 241001"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.29580766),
        dec: Angle.Degrees(-52.05381361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89903"},
    },
    visualMagnitude: 11.91,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.17670042),
        dec: Angle.Degrees(-52.05326756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32604"},
        {"Hipparcos Number", "HIP 23376"},
        {"Smithsonian Astrophysical Observation", "SAO 233789"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.39335105),
        dec: Angle.Degrees(-52.05266919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108936"},
        {"Hipparcos Number", "HIP 61098"},
        {"Smithsonian Astrophysical Observation", "SAO 240024"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.82528615),
        dec: Angle.Degrees(-52.05220000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99783"},
        {"Hipparcos Number", "HIP 55975"},
        {"Smithsonian Astrophysical Observation", "SAO 239095"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.06025223),
        dec: Angle.Degrees(-52.05141780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87611"},
        {"Hipparcos Number", "HIP 49364"},
        {"Smithsonian Astrophysical Observation", "SAO 237670"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.15187953),
        dec: Angle.Degrees(-52.05136002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298781"},
        {"Hipparcos Number", "HIP 48999"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.94886717),
        dec: Angle.Degrees(-52.05094402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112439"},
        {"Hipparcos Number", "HIP 63224"},
        {"Smithsonian Astrophysical Observation", "SAO 240409"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.32044822),
        dec: Angle.Degrees(-52.04908445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162844"},
        {"Hipparcos Number", "HIP 87775"},
        {"Smithsonian Astrophysical Observation", "SAO 245122"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.96016247),
        dec: Angle.Degrees(-52.04826689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23592"},
        {"Hipparcos Number", "HIP 17419"},
        {"Geneva Identification System", "GEN# +1.00023592"},
        {"Smithsonian Astrophysical Observation", "SAO 233244"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.97913506),
        dec: Angle.Degrees(-52.04687217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6804",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6804"},
    },
    visualMagnitude: 10.98,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.89271532),
        dec: Angle.Degrees(-52.04486454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 295.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35139"},
        {"Hipparcos Number", "HIP 24859"},
        {"Geneva Identification System", "GEN# +1.00035139"},
        {"Smithsonian Astrophysical Observation", "SAO 233930"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.93664752),
        dec: Angle.Degrees(-52.03821966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37864"},
        {"Hipparcos Number", "HIP 26532"},
        {"Smithsonian Astrophysical Observation", "SAO 234064"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.65461181),
        dec: Angle.Degrees(-52.03768907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84326"},
        {"Hipparcos Number", "HIP 47643"},
        {"Geneva Identification System", "GEN# +1.00084326"},
        {"Smithsonian Astrophysical Observation", "SAO 237250"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.70588874),
        dec: Angle.Degrees(-52.03752806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53102"},
        {"Hipparcos Number", "HIP 33792"},
        {"Smithsonian Astrophysical Observation", "SAO 234857"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.25038539),
        dec: Angle.Degrees(-52.03744479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121402"},
        {"Hipparcos Number", "HIP 68088"},
        {"Smithsonian Astrophysical Observation", "SAO 241313"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.11077328),
        dec: Angle.Degrees(-52.03558277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20916"},
        {"Hipparcos Number", "HIP 15539"},
        {"Geneva Identification System", "GEN# +1.00020916"},
        {"Smithsonian Astrophysical Observation", "SAO 233075"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.04935180),
        dec: Angle.Degrees(-52.03156278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34347"},
        {"Hipparcos Number", "HIP 24384"},
        {"Geneva Identification System", "GEN# +1.00034347"},
        {"Smithsonian Astrophysical Observation", "SAO 233886"},
    },
    visualMagnitude: 6.03,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.47222426),
        dec: Angle.Degrees(-52.03072111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89956"},
        {"Hipparcos Number", "HIP 50735"},
        {"Geneva Identification System", "GEN# +2.32280010"},
        {"Smithsonian Astrophysical Observation", "SAO 237981"},
        {"New General Catalogue", "NGC 3228 10"},
    },
    visualMagnitude: 8.18,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.39760845),
        dec: Angle.Degrees(-52.02975329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133518"},
        {"Hipparcos Number", "HIP 73966"},
        {"Geneva Identification System", "GEN# +1.00133518"},
        {"Renson", "Renson 37890"},
        {"Smithsonian Astrophysical Observation", "SAO 242229"},
        {"Wilson Evans Batten Catalogue", "WEB 12631"},
    },
    visualMagnitude: 6.40,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.73322523),
        dec: Angle.Degrees(-52.02974968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134598"},
        {"Hipparcos Number", "HIP 74447"},
        {"Smithsonian Astrophysical Observation", "SAO 242314"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.20575896),
        dec: Angle.Degrees(-52.02909486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83170"},
        {"Hipparcos Number", "HIP 47000"},
        {"Geneva Identification System", "GEN# +1.00083170"},
        {"Smithsonian Astrophysical Observation", "SAO 237118"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.68872130),
        dec: Angle.Degrees(-52.02834354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87642"},
        {"Hipparcos Number", "HIP 49380"},
        {"Fundamental Katalog 5th Edition", "FK5 4896"},
        {"Smithsonian Astrophysical Observation", "SAO 237674"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.22270142),
        dec: Angle.Degrees(-52.02528751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219122"},
        {"Hipparcos Number", "HIP 114709"},
        {"Geneva Identification System", "GEN# +1.00219122"},
        {"Smithsonian Astrophysical Observation", "SAO 247788"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.53577342),
        dec: Angle.Degrees(-52.02347969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 254.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198719"},
        {"Hipparcos Number", "HIP 103183"},
        {"Smithsonian Astrophysical Observation", "SAO 246780"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.58178514),
        dec: Angle.Degrees(-52.02299929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60692",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60692"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.58455580),
        dec: Angle.Degrees(-52.01862765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113854"},
        {"Hipparcos Number", "HIP 64026"},
        {"Smithsonian Astrophysical Observation", "SAO 240564"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.80514969),
        dec: Angle.Degrees(-52.01646816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156010"},
        {"Hipparcos Number", "HIP 84620"},
        {"Smithsonian Astrophysical Observation", "SAO 244595"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.47914620),
        dec: Angle.Degrees(-52.01637690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22706"},
        {"Hipparcos Number", "HIP 16839"},
        {"Smithsonian Astrophysical Observation", "SAO 233180"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.18120860),
        dec: Angle.Degrees(-52.01450068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59261"},
        {"Hipparcos Number", "HIP 36127"},
        {"Smithsonian Astrophysical Observation", "SAO 235195"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.62027975),
        dec: Angle.Degrees(-52.01205952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3656",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3656"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.70280873),
        dec: Angle.Degrees(-52.00998608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108197"},
        {"Hipparcos Number", "HIP 60674"},
        {"Smithsonian Astrophysical Observation", "SAO 239943"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.51950850),
        dec: Angle.Degrees(-52.00747611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113948"},
        {"Hipparcos Number", "HIP 64070"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.95720969),
        dec: Angle.Degrees(-52.00463284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108016"},
        {"Hipparcos Number", "HIP 60567"},
        {"Smithsonian Astrophysical Observation", "SAO 239933"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.22892485),
        dec: Angle.Degrees(-52.00437264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74734"},
        {"Hipparcos Number", "HIP 42823"},
        {"Geneva Identification System", "GEN# +1.00074734"},
        {"Smithsonian Astrophysical Observation", "SAO 236222"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.88686532),
        dec: Angle.Degrees(-52.00385185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4545"},
        {"Hipparcos Number", "HIP 3653"},
        {"Smithsonian Astrophysical Observation", "SAO 232181"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.69417777),
        dec: Angle.Degrees(-52.00380319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134979"},
        {"Hipparcos Number", "HIP 74620"},
        {"Geneva Identification System", "GEN# +1.00134979"},
        {"Smithsonian Astrophysical Observation", "SAO 242342"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.69742098),
        dec: Angle.Degrees(-52.00279796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61629",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61629"},
        {"Cincinnati Publication", "Ci 20 724"},
        {"Geneva Identification System", "GEN# -0.05106859"},
    },
    visualMagnitude: 10.65,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.47165252),
        dec: Angle.Degrees(-52.00155006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1034.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15818"},
        {"Hipparcos Number", "HIP 11702"},
        {"Smithsonian Astrophysical Observation", "SAO 232798"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.73626561),
        dec: Angle.Degrees(-52.00038015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81594",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81594"},
        {"Smithsonian Astrophysical Observation", "SAO 244044"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.94804238),
        dec: Angle.Degrees(-51.99978224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149813"},
        {"Hipparcos Number", "HIP 81592"},
        {"Smithsonian Astrophysical Observation", "SAO 244042"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.94521205),
        dec: Angle.Degrees(-51.99410768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129402"},
        {"Hipparcos Number", "HIP 72039"},
        {"Smithsonian Astrophysical Observation", "SAO 241958"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.03886049),
        dec: Angle.Degrees(-51.99334596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38316"},
        {"Hipparcos Number", "HIP 26843"},
        {"Smithsonian Astrophysical Observation", "SAO 234100"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.49469166),
        dec: Angle.Degrees(-51.99333302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12979"},
        {"Hipparcos Number", "HIP 9768"},
        {"Geneva Identification System", "GEN# +1.00012979"},
        {"Smithsonian Astrophysical Observation", "SAO 232629"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.39750476),
        dec: Angle.Degrees(-51.99122672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2950"},
        {"Hipparcos Number", "HIP 2542"},
        {"Smithsonian Astrophysical Observation", "SAO 232081"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.08759430),
        dec: Angle.Degrees(-51.99045524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165881"},
        {"Hipparcos Number", "HIP 89089"},
        {"Smithsonian Astrophysical Observation", "SAO 245289"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.73717592),
        dec: Angle.Degrees(-51.98926495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98023"},
        {"Hipparcos Number", "HIP 55026"},
        {"Smithsonian Astrophysical Observation", "SAO 238917"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.97789141),
        dec: Angle.Degrees(-51.98775172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91883"},
        {"Hipparcos Number", "HIP 51844"},
        {"Smithsonian Astrophysical Observation", "SAO 238219"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.87891264),
        dec: Angle.Degrees(-51.98602767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205036"},
        {"Hipparcos Number", "HIP 106496"},
        {"Smithsonian Astrophysical Observation", "SAO 247088"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.56755642),
        dec: Angle.Degrees(-51.98429474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61195"},
        {"Hipparcos Number", "HIP 36923"},
        {"Smithsonian Astrophysical Observation", "SAO 235327"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.85590265),
        dec: Angle.Degrees(-51.98406204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30502"},
        {"Hipparcos Number", "HIP 22107"},
        {"Smithsonian Astrophysical Observation", "SAO 233667"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.36827930),
        dec: Angle.Degrees(-51.97957676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1630"},
        {"Hipparcos Number", "HIP 1624"},
        {"Smithsonian Astrophysical Observation", "SAO 232003"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.07301567),
        dec: Angle.Degrees(-51.97847298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158145"},
        {"Hipparcos Number", "HIP 85656"},
        {"Smithsonian Astrophysical Observation", "SAO 244796"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.58087149),
        dec: Angle.Degrees(-51.97746240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156386"},
        {"Hipparcos Number", "HIP 84802"},
        {"Smithsonian Astrophysical Observation", "SAO 244635"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.99997096),
        dec: Angle.Degrees(-51.96532369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211260"},
        {"Hipparcos Number", "HIP 110029"},
        {"Smithsonian Astrophysical Observation", "SAO 247390"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.28608202),
        dec: Angle.Degrees(-51.97722439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78205"},
        {"Hipparcos Number", "HIP 44573"},
        {"Celescope Catalog", "CEL 3174"},
        {"Geneva Identification System", "GEN# +1.00078205"},
        {"Smithsonian Astrophysical Observation", "SAO 236574"},
    },
    visualMagnitude: 8.46,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.22356002),
        dec: Angle.Degrees(-51.97611884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138029"},
        {"Hipparcos Number", "HIP 76029"},
        {"Smithsonian Astrophysical Observation", "SAO 242655"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.92812167),
        dec: Angle.Degrees(-51.97594550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102865"},
    },
    visualMagnitude: 11.55,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.60570837),
        dec: Angle.Degrees(-51.97581494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58649",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58649"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.39637159),
        dec: Angle.Degrees(-51.97579278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84304"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.53772141),
        dec: Angle.Degrees(-51.97554643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6355"},
        {"Hipparcos Number", "HIP 4972"},
        {"Smithsonian Astrophysical Observation", "SAO 232281"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.92857937),
        dec: Angle.Degrees(-51.97499210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134642"},
        {"Hipparcos Number", "HIP 74461"},
        {"Smithsonian Astrophysical Observation", "SAO 242318"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.24673463),
        dec: Angle.Degrees(-51.97274453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93558"},
        {"Hipparcos Number", "HIP 52753"},
        {"Smithsonian Astrophysical Observation", "SAO 238471"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.79491640),
        dec: Angle.Degrees(-51.97232301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127346"},
        {"Hipparcos Number", "HIP 71105"},
        {"Geneva Identification System", "GEN# +1.00127346"},
        {"Smithsonian Astrophysical Observation", "SAO 241780"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.12092182),
        dec: Angle.Degrees(-51.97069544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100986"},
        {"Hipparcos Number", "HIP 56651"},
        {"Smithsonian Astrophysical Observation", "SAO 239222"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.24441326),
        dec: Angle.Degrees(-51.97036640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40668"},
    },
    visualMagnitude: 11.22,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.53291447),
        dec: Angle.Degrees(-51.96955812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43492"},
        {"Hipparcos Number", "HIP 29547"},
        {"Smithsonian Astrophysical Observation", "SAO 234382"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.39044905),
        dec: Angle.Degrees(-51.96886812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144901"},
        {"Hipparcos Number", "HIP 79260"},
        {"Smithsonian Astrophysical Observation", "SAO 243404"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.65063187),
        dec: Angle.Degrees(-51.96875597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54732"},
        {"Hipparcos Number", "HIP 34349"},
        {"Geneva Identification System", "GEN# +1.00054732"},
        {"Smithsonian Astrophysical Observation", "SAO 234940"},
        {"Wilson Evans Batten Catalogue", "WEB 6879"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.80542082),
        dec: Angle.Degrees(-51.96838790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8934"},
        {"Hipparcos Number", "HIP 6772"},
        {"Smithsonian Astrophysical Observation", "SAO 232425"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.77289930),
        dec: Angle.Degrees(-51.96595740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 294.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7877"},
        {"Hipparcos Number", "HIP 6026"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.35713636),
        dec: Angle.Degrees(-51.96493668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143036"},
        {"Hipparcos Number", "HIP 78412"},
        {"Geneva Identification System", "GEN# +1.00143036"},
        {"Smithsonian Astrophysical Observation", "SAO 243232"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.10875333),
        dec: Angle.Degrees(-51.96488402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139967"},
        {"Hipparcos Number", "HIP 77012"},
        {"Smithsonian Astrophysical Observation", "SAO 242874"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.86218740),
        dec: Angle.Degrees(-51.96451649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68868"},
        {"Hipparcos Number", "HIP 40152"},
        {"Fundamental Katalog 5th Edition", "FK5 4738"},
        {"Smithsonian Astrophysical Observation", "SAO 235801"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.98895582),
        dec: Angle.Degrees(-51.96262720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210236"},
        {"Hipparcos Number", "HIP 109443"},
        {"Geneva Identification System", "GEN# +1.00210236"},
        {"Smithsonian Astrophysical Observation", "SAO 247337"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.58847042),
        dec: Angle.Degrees(-51.95983936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 220.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92892"},
        {"Hipparcos Number", "HIP 52402"},
        {"Smithsonian Astrophysical Observation", "SAO 238376"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.65719522),
        dec: Angle.Degrees(-51.95911127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103232"},
        {"Hipparcos Number", "HIP 57953"},
        {"Smithsonian Astrophysical Observation", "SAO 239461"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.29660868),
        dec: Angle.Degrees(-51.95861958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54941"},
        {"Hipparcos Number", "HIP 34410"},
        {"Geneva Identification System", "GEN# +1.00054941"},
        {"Smithsonian Astrophysical Observation", "SAO 234947"},
        {"Wilson Evans Batten Catalogue", "WEB 6894"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.00980147),
        dec: Angle.Degrees(-51.95773595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77005"},
        {"Smithsonian Astrophysical Observation", "SAO 242872"},
    },
    visualMagnitude: 9.68,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.85283545),
        dec: Angle.Degrees(-51.95629360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20159"},
        {"Hipparcos Number", "HIP 14885"},
        {"Smithsonian Astrophysical Observation", "SAO 233032"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.03016567),
        dec: Angle.Degrees(-51.95586158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143795"},
        {"Hipparcos Number", "HIP 78767"},
        {"Geneva Identification System", "GEN# +4.24060001"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.21362654),
        dec: Angle.Degrees(-51.95525067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141032"},
        {"Hipparcos Number", "HIP 77477"},
        {"Smithsonian Astrophysical Observation", "SAO 243007"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.28947957),
        dec: Angle.Degrees(-51.95513487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13575",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13575"},
        {"Smithsonian Astrophysical Observation", "SAO 232938"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.71969044),
        dec: Angle.Degrees(-51.95370436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78771",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78771"},
    },
    visualMagnitude: 11.48,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.23011815),
        dec: Angle.Degrees(-51.95350795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178470"},
        {"Hipparcos Number", "HIP 94286"},
        {"Smithsonian Astrophysical Observation", "SAO 245962"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.85983708),
        dec: Angle.Degrees(-51.95344450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2802"},
        {"Hipparcos Number", "HIP 2435"},
        {"Smithsonian Astrophysical Observation", "SAO 232073"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.75798550),
        dec: Angle.Degrees(-51.95290859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110401"},
        {"Hipparcos Number", "HIP 61996"},
        {"Smithsonian Astrophysical Observation", "SAO 240169"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.58104227),
        dec: Angle.Degrees(-51.94917111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157599"},
        {"Hipparcos Number", "HIP 85393"},
        {"Geneva Identification System", "GEN# +1.00157599"},
        {"Smithsonian Astrophysical Observation", "SAO 244749"},
        {"Wilson Evans Batten Catalogue", "WEB 14423"},
    },
    visualMagnitude: 6.17,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.73477483),
        dec: Angle.Degrees(-51.94878604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37637"},
        {"Hipparcos Number", "HIP 26379"},
        {"Smithsonian Astrophysical Observation", "SAO 234049"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.25494526),
        dec: Angle.Degrees(-51.94873275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195317"},
        {"Hipparcos Number", "HIP 101377"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.20150979),
        dec: Angle.Degrees(-51.94737720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95492"},
        {"Hipparcos Number", "HIP 53806"},
        {"Geneva Identification System", "GEN# +1.00095492"},
        {"Smithsonian Astrophysical Observation", "SAO 238684"},
    },
    visualMagnitude: 7.63,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.13913089),
        dec: Angle.Degrees(-51.94728267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123625"},
        {"Hipparcos Number", "HIP 69212"},
        {"Smithsonian Astrophysical Observation", "SAO 241498"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.55439754),
        dec: Angle.Degrees(-51.94536314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111755"},
        {"Hipparcos Number", "HIP 62803"},
        {"Smithsonian Astrophysical Observation", "SAO 240331"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.03970609),
        dec: Angle.Degrees(-51.94451832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93291",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93291"},
    },
    visualMagnitude: 11.10,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.01980353),
        dec: Angle.Degrees(-51.94451136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98288"},
        {"Hipparcos Number", "HIP 55177"},
        {"Smithsonian Astrophysical Observation", "SAO 238945"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.45443367),
        dec: Angle.Degrees(-51.94306616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116898",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116898"},
    },
    visualMagnitude: 11.60,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.43168550),
        dec: Angle.Degrees(-51.94305408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -251.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203277"},
        {"Hipparcos Number", "HIP 105577"},
        {"Smithsonian Astrophysical Observation", "SAO 247004"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.76196560),
        dec: Angle.Degrees(-51.94228376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70510"},
        {"Hipparcos Number", "HIP 40824"},
        {"Geneva Identification System", "GEN# +1.00070510"},
        {"Smithsonian Astrophysical Observation", "SAO 235888"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.99086918),
        dec: Angle.Degrees(-51.94197177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74168"},
        {"Hipparcos Number", "HIP 42519"},
        {"Celescope Catalog", "CEL 2759"},
        {"Geneva Identification System", "GEN# +3.23910017"},
        {"Renson", "Renson 20650"},
        {"Smithsonian Astrophysical Observation", "SAO 236163"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.03484839),
        dec: Angle.Degrees(-51.94158307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298621"},
        {"Hipparcos Number", "HIP 47708"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.90683964),
        dec: Angle.Degrees(-51.94093954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85608"},
        {"Hipparcos Number", "HIP 48352"},
        {"Smithsonian Astrophysical Observation", "SAO 237413"},
    },
    visualMagnitude: 8.86,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.84173688),
        dec: Angle.Degrees(-51.94055608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91835"},
        {"Hipparcos Number", "HIP 51815"},
        {"Smithsonian Astrophysical Observation", "SAO 238216"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.79307142),
        dec: Angle.Degrees(-51.93963694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67763"},
        {"Hipparcos Number", "HIP 39709"},
        {"Geneva Identification System", "GEN# +1.00067763"},
        {"Smithsonian Astrophysical Observation", "SAO 235749"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.75085579),
        dec: Angle.Degrees(-51.93942267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16077"},
        {"Hipparcos Number", "HIP 11877"},
        {"Geneva Identification System", "GEN# +1.00016077"},
        {"Smithsonian Astrophysical Observation", "SAO 232813"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.30575034),
        dec: Angle.Degrees(-51.93865900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 166.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129401"},
        {"Hipparcos Number", "HIP 72041"},
        {"Geneva Identification System", "GEN# +1.00129401"},
        {"Smithsonian Astrophysical Observation", "SAO 241959"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.04036575),
        dec: Angle.Degrees(-51.93801812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123433"},
        {"Hipparcos Number", "HIP 69129"},
        {"Smithsonian Astrophysical Observation", "SAO 241484"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.25659487),
        dec: Angle.Degrees(-51.93738697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -324.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154925"},
        {"Hipparcos Number", "HIP 84067"},
        {"Smithsonian Astrophysical Observation", "SAO 244496"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.79827727),
        dec: Angle.Degrees(-51.93703332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33683"},
        {"Hipparcos Number", "HIP 23973"},
        {"Smithsonian Astrophysical Observation", "SAO 233846"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.28746009),
        dec: Angle.Degrees(-51.93606020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28329"},
        {"Hipparcos Number", "HIP 20640"},
        {"Smithsonian Astrophysical Observation", "SAO 233511"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.35215832),
        dec: Angle.Degrees(-51.93558011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112242"},
        {"Hipparcos Number", "HIP 63108"},
        {"Smithsonian Astrophysical Observation", "SAO 240384"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.97054025),
        dec: Angle.Degrees(-51.93443748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126525"},
        {"Hipparcos Number", "HIP 70695"},
        {"Geneva Identification System", "GEN# +1.00126525"},
        {"Smithsonian Astrophysical Observation", "SAO 241727"},
        {"Wilson Evans Batten Catalogue", "WEB 12250"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.88858596),
        dec: Angle.Degrees(-51.93318344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -305.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177366"},
        {"Hipparcos Number", "HIP 93872"},
        {"Smithsonian Astrophysical Observation", "SAO 245926"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.76316134),
        dec: Angle.Degrees(-51.93151435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174430"},
        {"Hipparcos Number", "HIP 92687"},
        {"Geneva Identification System", "GEN# +1.00174430"},
        {"Smithsonian Astrophysical Observation", "SAO 245783"},
        {"Wilson Evans Batten Catalogue", "WEB 16030"},
    },
    visualMagnitude: 6.30,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.30000134),
        dec: Angle.Degrees(-51.93140800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125951"},
        {"Hipparcos Number", "HIP 70406"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.06107680),
        dec: Angle.Degrees(-51.93131917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25912"},
        {"Hipparcos Number", "HIP 18944"},
        {"Geneva Identification System", "GEN# +1.00025912"},
        {"Smithsonian Astrophysical Observation", "SAO 233383"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.90824751),
        dec: Angle.Degrees(-51.93046471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15308",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15308"},
        {"Smithsonian Astrophysical Observation", "SAO 233063"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.37494457),
        dec: Angle.Degrees(-51.92862473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128036"},
        {"Hipparcos Number", "HIP 71421"},
        {"Smithsonian Astrophysical Observation", "SAO 241836"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.08383658),
        dec: Angle.Degrees(-51.92389523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93094"},
        {"Hipparcos Number", "HIP 52506"},
        {"Smithsonian Astrophysical Observation", "SAO 238399"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.04019370),
        dec: Angle.Degrees(-51.92372823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75351"},
        {"Hipparcos Number", "HIP 43141"},
        {"Geneva Identification System", "GEN# +1.00075351J"},
        {"Smithsonian Astrophysical Observation", "SAO 236272"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.81230206),
        dec: Angle.Degrees(-51.92130795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197157"},
        {"Hipparcos Number", "HIP 102333"},
        {"Fundamental Katalog 5th Edition", "FK5 776"},
        {"Geneva Identification System", "GEN# +1.00197157"},
        {"Renson", "Renson 54990"},
        {"Smithsonian Astrophysical Observation", "SAO 246709"},
        {"Wilson Evans Batten Catalogue", "WEB 18527"},
    },
    visualMagnitude: 4.51,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.00911122),
        dec: Angle.Degrees(-51.92084051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214151"},
        {"Hipparcos Number", "HIP 111673"},
        {"Smithsonian Astrophysical Observation", "SAO 247514"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.34210648),
        dec: Angle.Degrees(-51.92058744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218484"},
        {"Hipparcos Number", "HIP 114301"},
        {"Smithsonian Astrophysical Observation", "SAO 247756"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.23204832),
        dec: Angle.Degrees(-51.91866650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132606"},
        {"Hipparcos Number", "HIP 73557"},
        {"Smithsonian Astrophysical Observation", "SAO 242180"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.48734866),
        dec: Angle.Degrees(-51.91827562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86525"},
        {"Hipparcos Number", "HIP 48822"},
        {"Geneva Identification System", "GEN# +1.00086525"},
        {"Smithsonian Astrophysical Observation", "SAO 237531"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.38736161),
        dec: Angle.Degrees(-51.91761209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215854"},
        {"Hipparcos Number", "HIP 112682"},
        {"Smithsonian Astrophysical Observation", "SAO 247597"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.27338945),
        dec: Angle.Degrees(-51.91691425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192530"},
        {"Hipparcos Number", "HIP 100035"},
        {"Geneva Identification System", "GEN# +1.00192530"},
        {"Smithsonian Astrophysical Observation", "SAO 246517"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.43265946),
        dec: Angle.Degrees(-51.91684951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120154"},
        {"Hipparcos Number", "HIP 67417"},
        {"Smithsonian Astrophysical Observation", "SAO 241195"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.25008546),
        dec: Angle.Degrees(-51.91646649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111567"},
        {"Hipparcos Number", "HIP 62681"},
        {"Geneva Identification System", "GEN# +1.00111567"},
        {"Smithsonian Astrophysical Observation", "SAO 240310"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.66478306),
        dec: Angle.Degrees(-51.91279215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116922"},
        {"Hipparcos Number", "HIP 65667"},
        {"Smithsonian Astrophysical Observation", "SAO 240858"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.95410536),
        dec: Angle.Degrees(-51.90799346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188534"},
        {"Hipparcos Number", "HIP 98278"},
        {"Geneva Identification System", "GEN# +1.00188534"},
        {"Smithsonian Astrophysical Observation", "SAO 246356"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.53140630),
        dec: Angle.Degrees(-51.90565204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200015"},
        {"Hipparcos Number", "HIP 103866"},
        {"Smithsonian Astrophysical Observation", "SAO 246833"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.68947361),
        dec: Angle.Degrees(-51.90497439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140079"},
        {"Hipparcos Number", "HIP 77056"},
        {"Geneva Identification System", "GEN# +1.00140079"},
        {"Smithsonian Astrophysical Observation", "SAO 242888"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.01507702),
        dec: Angle.Degrees(-51.90471195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7154",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7154"},
        {"Cincinnati Publication", "Ci 20 109"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.05579980),
        dec: Angle.Degrees(-51.90457519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 384.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 248.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81314"},
        {"Hipparcos Number", "HIP 46016"},
        {"Geneva Identification System", "GEN# +1.00081314"},
        {"Smithsonian Astrophysical Observation", "SAO 236909"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.77226551),
        dec: Angle.Degrees(-51.90425081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214777"},
        {"Hipparcos Number", "HIP 112033"},
        {"Smithsonian Astrophysical Observation", "SAO 247549"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.38034254),
        dec: Angle.Degrees(-51.90289010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160226"},
        {"Hipparcos Number", "HIP 86573"},
        {"Smithsonian Astrophysical Observation", "SAO 244947"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.38136001),
        dec: Angle.Degrees(-51.90255871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83201"},
        {"Hipparcos Number", "HIP 47021"},
        {"Geneva Identification System", "GEN# +1.00083201"},
        {"Smithsonian Astrophysical Observation", "SAO 237123"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.74448909),
        dec: Angle.Degrees(-51.90202791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78688"},
        {"Hipparcos Number", "HIP 44779"},
        {"Smithsonian Astrophysical Observation", "SAO 236624"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.89166504),
        dec: Angle.Degrees(-51.89997968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135312"},
        {"Hipparcos Number", "HIP 74747"},
        {"Smithsonian Astrophysical Observation", "SAO 242373"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.14041028),
        dec: Angle.Degrees(-51.89919884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75874"},
        {"Hipparcos Number", "HIP 43402"},
        {"Geneva Identification System", "GEN# +1.00075874"},
        {"Smithsonian Astrophysical Observation", "SAO 236325"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.61036255),
        dec: Angle.Degrees(-51.89738696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152440"},
        {"Hipparcos Number", "HIP 82866"},
        {"Geneva Identification System", "GEN# +1.00152440"},
        {"Smithsonian Astrophysical Observation", "SAO 244279"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.02359888),
        dec: Angle.Degrees(-51.89736486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101310"},
        {"Henry Draper 2", "HD 101311"},
        {"Hipparcos Number", "HIP 56842"},
        {"Smithsonian Astrophysical Observation", "SAO 239260"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.80248299),
        dec: Angle.Degrees(-51.89678133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219915"},
        {"Hipparcos Number", "HIP 115205"},
        {"Smithsonian Astrophysical Observation", "SAO 247833"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.01277998),
        dec: Angle.Degrees(-51.89651362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200264"},
        {"Hipparcos Number", "HIP 104017"},
        {"Smithsonian Astrophysical Observation", "SAO 246847"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.09700256),
        dec: Angle.Degrees(-51.89549188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188557"},
        {"Hipparcos Number", "HIP 98294"},
        {"Geneva Identification System", "GEN# +1.00188557"},
        {"Smithsonian Astrophysical Observation", "SAO 246357"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.56354383),
        dec: Angle.Degrees(-51.89526465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99310"},
        {"Hipparcos Number", "HIP 55722"},
        {"Geneva Identification System", "GEN# +1.00099310"},
        {"Smithsonian Astrophysical Observation", "SAO 239046"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.26773993),
        dec: Angle.Degrees(-51.89403396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224707"},
        {"Hipparcos Number", "HIP 4"},
        {"Geneva Identification System", "GEN# +1.00224707"},
        {"Smithsonian Astrophysical Observation", "SAO 248095"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.00838170),
        dec: Angle.Degrees(-51.89354612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121835"},
        {"Hipparcos Number", "HIP 68335"},
        {"Smithsonian Astrophysical Observation", "SAO 241351"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.82537485),
        dec: Angle.Degrees(-51.89279122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71862"},
        {"Hipparcos Number", "HIP 41458"},
        {"Smithsonian Astrophysical Observation", "SAO 235995"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.83171716),
        dec: Angle.Degrees(-51.89183589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220440"},
        {"Hipparcos Number", "HIP 115537"},
        {"Geneva Identification System", "GEN# +1.00220440"},
        {"Smithsonian Astrophysical Observation", "SAO 247858"},
    },
    visualMagnitude: 5.75,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.05516142),
        dec: Angle.Degrees(-51.89108428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197995"},
        {"Hipparcos Number", "HIP 102789"},
        {"Geneva Identification System", "GEN# +1.00197995"},
        {"Smithsonian Astrophysical Observation", "SAO 246744"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.37011597),
        dec: Angle.Degrees(-51.89057225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158400"},
        {"Hipparcos Number", "HIP 85787"},
        {"Smithsonian Astrophysical Observation", "SAO 244818"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.95350773),
        dec: Angle.Degrees(-51.89041749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210114"},
        {"Hipparcos Number", "HIP 109367"},
        {"Smithsonian Astrophysical Observation", "SAO 247333"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.35943058),
        dec: Angle.Degrees(-51.88993720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170914"},
        {"Hipparcos Number", "HIP 91082"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.66966887),
        dec: Angle.Degrees(-51.88878134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82976",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82976"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.34358353),
        dec: Angle.Degrees(-51.88799403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169383"},
        {"Hipparcos Number", "HIP 90442"},
        {"Geneva Identification System", "GEN# +1.00169383"},
        {"Smithsonian Astrophysical Observation", "SAO 245481"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.80335999),
        dec: Angle.Degrees(-51.88401980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98128"},
        {"Hipparcos Number", "HIP 55087"},
        {"Smithsonian Astrophysical Observation", "SAO 238925"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.17775795),
        dec: Angle.Degrees(-51.88385981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51120"},
        {"Hipparcos Number", "HIP 33066"},
        {"Smithsonian Astrophysical Observation", "SAO 234765"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.30594292),
        dec: Angle.Degrees(-51.88373825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196652"},
        {"Hipparcos Number", "HIP 102064"},
        {"Smithsonian Astrophysical Observation", "SAO 246691"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.25569134),
        dec: Angle.Degrees(-51.88078060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64413"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.02250387),
        dec: Angle.Degrees(-51.87963954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209839"},
        {"Hipparcos Number", "HIP 109221"},
        {"Smithsonian Astrophysical Observation", "SAO 247317"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.90601609),
        dec: Angle.Degrees(-51.87761008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68328",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68328"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.80769172),
        dec: Angle.Degrees(-51.87740804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5578"},
        {"Hipparcos Number", "HIP 4448"},
        {"Smithsonian Astrophysical Observation", "SAO 232234"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.23075943),
        dec: Angle.Degrees(-51.87554417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203125"},
        {"Hipparcos Number", "HIP 105501"},
        {"Smithsonian Astrophysical Observation", "SAO 246995"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.51830768),
        dec: Angle.Degrees(-51.87548297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116398"},
        {"Hipparcos Number", "HIP 65413"},
        {"Smithsonian Astrophysical Observation", "SAO 240807"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.10828367),
        dec: Angle.Degrees(-51.87518830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116538"},
        {"Hipparcos Number", "HIP 65475"},
        {"Celescope Catalog", "CEL 4255"},
        {"Geneva Identification System", "GEN# +1.00116538"},
        {"Smithsonian Astrophysical Observation", "SAO 240823"},
        {"Wilson Evans Batten Catalogue", "WEB 11555"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.30091071),
        dec: Angle.Degrees(-51.84179405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128053"},
        {"Hipparcos Number", "HIP 71433"},
        {"Smithsonian Astrophysical Observation", "SAO 241837"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.10767065),
        dec: Angle.Degrees(-51.87465396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219392"},
        {"Hipparcos Number", "HIP 114874"},
        {"Smithsonian Astrophysical Observation", "SAO 247806"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.01854625),
        dec: Angle.Degrees(-51.87204427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91966"},
        {"Hipparcos Number", "HIP 51889"},
        {"Smithsonian Astrophysical Observation", "SAO 238234"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.02685791),
        dec: Angle.Degrees(-51.87136474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219521"},
        {"Hipparcos Number", "HIP 114946"},
        {"Smithsonian Astrophysical Observation", "SAO 247810"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.23608478),
        dec: Angle.Degrees(-51.86217770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83530",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83530"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.07801578),
        dec: Angle.Degrees(-51.86165181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89856"},
        {"Hipparcos Number", "HIP 50677"},
        {"Geneva Identification System", "GEN# +2.32280003"},
        {"Renson", "Renson 25810"},
        {"Smithsonian Astrophysical Observation", "SAO 237956"},
        {"New General Catalogue", "NGC 3228 3"},
    },
    visualMagnitude: 9.06,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.23053490),
        dec: Angle.Degrees(-51.86159121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141925"},
        {"Hipparcos Number", "HIP 77862"},
        {"Smithsonian Astrophysical Observation", "SAO 243094"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.48813501),
        dec: Angle.Degrees(-51.86023911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156725"},
        {"Hipparcos Number", "HIP 84967"},
        {"Smithsonian Astrophysical Observation", "SAO 244666"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.49536336),
        dec: Angle.Degrees(-51.85037901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200473"},
        {"Hipparcos Number", "HIP 104117"},
        {"Smithsonian Astrophysical Observation", "SAO 246861"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.40489280),
        dec: Angle.Degrees(-51.84585734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298657"},
        {"Hipparcos Number", "HIP 48071"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.99604506),
        dec: Angle.Degrees(-51.84534174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196260"},
        {"Hipparcos Number", "HIP 101845"},
        {"Smithsonian Astrophysical Observation", "SAO 246672"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.58191136),
        dec: Angle.Degrees(-51.84472097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24417"},
        {"Hipparcos Number", "HIP 17974"},
        {"Smithsonian Astrophysical Observation", "SAO 233297"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.64155874),
        dec: Angle.Degrees(-51.84432676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160448"},
        {"Hipparcos Number", "HIP 86688"},
        {"Smithsonian Astrophysical Observation", "SAO 244962"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.68488376),
        dec: Angle.Degrees(-51.84288397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68346"},
        {"Hipparcos Number", "HIP 39947"},
        {"Geneva Identification System", "GEN# +1.00068346"},
        {"Smithsonian Astrophysical Observation", "SAO 235781"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.37554115),
        dec: Angle.Degrees(-51.84283272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40155"},
        {"Hipparcos Number", "HIP 27905"},
        {"Smithsonian Astrophysical Observation", "SAO 234193"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.57404130),
        dec: Angle.Degrees(-51.84248418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64763",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64763"},
    },
    visualMagnitude: 11.78,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.09117040),
        dec: Angle.Degrees(-33.79545330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -205.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29597"},
        {"Hipparcos Number", "HIP 21495"},
        {"Fundamental Katalog 5th Edition", "FK5 4415"},
        {"Geneva Identification System", "GEN# +1.00029597"},
        {"Smithsonian Astrophysical Observation", "SAO 233592"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.857,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.25169662),
        dec: Angle.Degrees(-51.84068101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202966"},
        {"Hipparcos Number", "HIP 105403"},
        {"Smithsonian Astrophysical Observation", "SAO 246979"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.24490386),
        dec: Angle.Degrees(-51.83985463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45555"},
        {"Hipparcos Number", "HIP 30546"},
        {"Smithsonian Astrophysical Observation", "SAO 234491"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.32112993),
        dec: Angle.Degrees(-51.83966378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110808"},
        {"Hipparcos Number", "HIP 62225"},
        {"Smithsonian Astrophysical Observation", "SAO 240213"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.29388739),
        dec: Angle.Degrees(-51.83833895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117535"},
        {"Hipparcos Number", "HIP 66013"},
        {"Smithsonian Astrophysical Observation", "SAO 240925"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.00985869),
        dec: Angle.Degrees(-51.83829007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131943"},
        {"Hipparcos Number", "HIP 73270"},
        {"Smithsonian Astrophysical Observation", "SAO 242139"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.62839076),
        dec: Angle.Degrees(-51.83790115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298679"},
        {"Hipparcos Number", "HIP 48409"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.04593744),
        dec: Angle.Degrees(-51.83466389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86796",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Cervantes"},
        {"Henry Draper", "HD 160691"},
        {"Hipparcos Number", "HIP 86796"},
        {"Fundamental Katalog 5th Edition", "FK5 662"},
        {"Geneva Identification System", "GEN# +1.00160691"},
        {"Smithsonian Astrophysical Observation", "SAO 244981"},
        {"Wilson Evans Batten Catalogue", "WEB 14636"},
    },
    visualMagnitude: 5.12,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.03632110),
        dec: Angle.Degrees(-51.83358836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4328",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4328"},
    },
    visualMagnitude: 12.38,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.85453209),
        dec: Angle.Degrees(-51.83348668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 336.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 348.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86385"},
        {"Hipparcos Number", "HIP 48755"},
        {"Celescope Catalog", "CEL 3410"},
        {"Geneva Identification System", "GEN# +1.00086385"},
        {"Smithsonian Astrophysical Observation", "SAO 237515"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.16197778),
        dec: Angle.Degrees(-51.83163416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10143"},
        {"Hipparcos Number", "HIP 7602"},
        {"Smithsonian Astrophysical Observation", "SAO 232482"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.48004941),
        dec: Angle.Degrees(-51.83130131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168805"},
        {"Hipparcos Number", "HIP 90215"},
        {"Geneva Identification System", "GEN# +1.00168805"},
        {"Smithsonian Astrophysical Observation", "SAO 245445"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.11741131),
        dec: Angle.Degrees(-51.82823809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298405"},
        {"Hipparcos Number", "HIP 46169"},
        {"Geneva Identification System", "GEN# +1.00298405"},
        {"Smithsonian Astrophysical Observation", "SAO 236942"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.23363021),
        dec: Angle.Degrees(-51.82786706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95029"},
        {"Hipparcos Number", "HIP 53560"},
        {"Geneva Identification System", "GEN# +1.00095029"},
        {"Smithsonian Astrophysical Observation", "SAO 238628"},
        {"Wilson Evans Batten Catalogue", "WEB 9721"},
    },
    visualMagnitude: 8.87,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.34890582),
        dec: Angle.Degrees(-51.82769247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205123"},
        {"Hipparcos Number", "HIP 106566"},
        {"Geneva Identification System", "GEN# +1.00205123"},
        {"Smithsonian Astrophysical Observation", "SAO 247093"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.72197077),
        dec: Angle.Degrees(-51.82701591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -211.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46569"},
        {"Hipparcos Number", "HIP 31079"},
        {"Geneva Identification System", "GEN# +1.00046569"},
        {"Smithsonian Astrophysical Observation", "SAO 234551"},
        {"Wilson Evans Batten Catalogue", "WEB 6189"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.82591372),
        dec: Angle.Degrees(-51.82620719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56289"},
        {"Hipparcos Number", "HIP 34931"},
        {"Smithsonian Astrophysical Observation", "SAO 235021"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.42296028),
        dec: Angle.Degrees(-51.82562689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55223"},
        {"Hipparcos Number", "HIP 34533"},
        {"Geneva Identification System", "GEN# +1.00055223"},
        {"Smithsonian Astrophysical Observation", "SAO 234964"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.33163112),
        dec: Angle.Degrees(-51.82475082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60324",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60324"},
    },
    visualMagnitude: 10.78,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.53654047),
        dec: Angle.Degrees(-51.82302905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6280"},
        {"Hipparcos Number", "HIP 4905"},
        {"Smithsonian Astrophysical Observation", "SAO 232275"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.73556586),
        dec: Angle.Degrees(-51.82286288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120713"},
        {"Hipparcos Number", "HIP 67722"},
        {"Smithsonian Astrophysical Observation", "SAO 241243"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.10465008),
        dec: Angle.Degrees(-51.82267438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15878"},
        {"Hipparcos Number", "HIP 11732"},
        {"Smithsonian Astrophysical Observation", "SAO 232799"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.86233282),
        dec: Angle.Degrees(-51.82260237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6070"},
        {"Hipparcos Number", "HIP 4762"},
        {"Smithsonian Astrophysical Observation", "SAO 232261"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.29863145),
        dec: Angle.Degrees(-51.82144550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104509"},
        {"Hipparcos Number", "HIP 58680"},
        {"Smithsonian Astrophysical Observation", "SAO 239599"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.51417563),
        dec: Angle.Degrees(-51.82098938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166910"},
        {"Hipparcos Number", "HIP 89471"},
        {"Smithsonian Astrophysical Observation", "SAO 245348"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.87799654),
        dec: Angle.Degrees(-51.82084948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73273"},
        {"Hipparcos Number", "HIP 42136"},
        {"Fundamental Katalog 5th Edition", "FK5 4773"},
        {"Geneva Identification System", "GEN# +1.00073273"},
        {"Smithsonian Astrophysical Observation", "SAO 236102"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.84208978),
        dec: Angle.Degrees(-51.82045583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101886"},
        {"Hipparcos Number", "HIP 57157"},
        {"Smithsonian Astrophysical Observation", "SAO 239320"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.82937076),
        dec: Angle.Degrees(-51.81913721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95429"},
        {"Hipparcos Number", "HIP 53771"},
        {"Geneva Identification System", "GEN# +1.00095429"},
        {"Smithsonian Astrophysical Observation", "SAO 238674"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.03474528),
        dec: Angle.Degrees(-51.81780645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17644"},
        {"Hipparcos Number", "HIP 13075"},
        {"Smithsonian Astrophysical Observation", "SAO 232897"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.00519558),
        dec: Angle.Degrees(-51.81549675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64662"},
        {"Hipparcos Number", "HIP 38431"},
        {"Smithsonian Astrophysical Observation", "SAO 235576"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.09022625),
        dec: Angle.Degrees(-51.81453580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88978"},
        {"Hipparcos Number", "HIP 50171"},
        {"Geneva Identification System", "GEN# +1.00088978"},
        {"Smithsonian Astrophysical Observation", "SAO 237822"},
    },
    visualMagnitude: 7.40,
    bvColour: -0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.61795098),
        dec: Angle.Degrees(-51.81432689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178710"},
        {"Hipparcos Number", "HIP 94353"},
        {"Geneva Identification System", "GEN# +1.00178710"},
        {"Smithsonian Astrophysical Observation", "SAO 245968"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.07080302),
        dec: Angle.Degrees(-51.81211763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92162"},
        {"Hipparcos Number", "HIP 51996"},
        {"Smithsonian Astrophysical Observation", "SAO 238263"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.34370164),
        dec: Angle.Degrees(-51.81206238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88206"},
        {"Hipparcos Number", "HIP 49712"},
        {"Geneva Identification System", "GEN# +1.00088206"},
        {"Smithsonian Astrophysical Observation", "SAO 237736"},
        {"Wilson Evans Batten Catalogue", "WEB 9165"},
    },
    visualMagnitude: 4.85,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.23439032),
        dec: Angle.Degrees(-51.81126187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110429"},
        {"Hipparcos Number", "HIP 62004"},
        {"Smithsonian Astrophysical Observation", "SAO 240171"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.61849545),
        dec: Angle.Degrees(-51.81101908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67738"},
        {"Hipparcos Number", "HIP 39704"},
        {"Geneva Identification System", "GEN# +1.00067738"},
        {"Smithsonian Astrophysical Observation", "SAO 235748"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.73402359),
        dec: Angle.Degrees(-51.81048849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225122"},
        {"Hipparcos Number", "HIP 289"},
        {"Smithsonian Astrophysical Observation", "SAO 231909"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.90235854),
        dec: Angle.Degrees(-51.80908752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210084"},
        {"Hipparcos Number", "HIP 109353"},
        {"Smithsonian Astrophysical Observation", "SAO 247331"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.31106680),
        dec: Angle.Degrees(-51.80787312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181899"},
        {"Hipparcos Number", "HIP 95441"},
        {"Smithsonian Astrophysical Observation", "SAO 246077"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.21338462),
        dec: Angle.Degrees(-51.80787303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104463"},
        {"Hipparcos Number", "HIP 58655"},
        {"Renson", "Renson 30230"},
        {"Smithsonian Astrophysical Observation", "SAO 239592"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.41715479),
        dec: Angle.Degrees(-51.80733112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217191"},
        {"Hipparcos Number", "HIP 113534"},
        {"Smithsonian Astrophysical Observation", "SAO 247670"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.90968083),
        dec: Angle.Degrees(-51.80652534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178734"},
        {"Hipparcos Number", "HIP 94365"},
        {"Geneva Identification System", "GEN# +1.00178734"},
        {"Smithsonian Astrophysical Observation", "SAO 245970"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.10049319),
        dec: Angle.Degrees(-51.80555337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114982"},
        {"Hipparcos Number", "HIP 64637"},
        {"Geneva Identification System", "GEN# +1.00114982"},
        {"Smithsonian Astrophysical Observation", "SAO 240673"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.73176161),
        dec: Angle.Degrees(-51.80466966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59368"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.70174934),
        dec: Angle.Degrees(-51.80457562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97688"},
        {"Hipparcos Number", "HIP 54851"},
        {"Smithsonian Astrophysical Observation", "SAO 238880"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.45200558),
        dec: Angle.Degrees(-51.80165216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11051"},
        {"Hipparcos Number", "HIP 8317"},
        {"Smithsonian Astrophysical Observation", "SAO 232524"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.81319913),
        dec: Angle.Degrees(-51.80110939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197097"},
        {"Hipparcos Number", "HIP 102293"},
        {"Smithsonian Astrophysical Observation", "SAO 246707"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.90045853),
        dec: Angle.Degrees(-51.80104393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135750"},
        {"Hipparcos Number", "HIP 74940"},
        {"Smithsonian Astrophysical Observation", "SAO 242404"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.69988768),
        dec: Angle.Degrees(-51.80090996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94327"},
        {"Hipparcos Number", "HIP 53146"},
        {"Geneva Identification System", "GEN# +1.00094327"},
        {"Smithsonian Astrophysical Observation", "SAO 238552"},
    },
    visualMagnitude: 7.52,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.07681180),
        dec: Angle.Degrees(-51.80030478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24977"},
        {"Hipparcos Number", "HIP 18376"},
        {"Geneva Identification System", "GEN# +1.00024977"},
        {"Smithsonian Astrophysical Observation", "SAO 233330"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.91678428),
        dec: Angle.Degrees(-51.79913999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87580"},
        {"Henry Draper 2", "HD 87580A"},
        {"Hipparcos Number", "HIP 49351"},
        {"Smithsonian Astrophysical Observation", "SAO 237664"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.11610716),
        dec: Angle.Degrees(-51.79839496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21646"},
        {"Hipparcos Number", "HIP 16101"},
        {"Smithsonian Astrophysical Observation", "SAO 233125"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.85545203),
        dec: Angle.Degrees(-51.79700448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16216"},
        {"Hipparcos Number", "HIP 11963"},
        {"Smithsonian Astrophysical Observation", "SAO 232821"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.59164179),
        dec: Angle.Degrees(-51.79548546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100356",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100356"},
    },
    visualMagnitude: 10.21,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.29564138),
        dec: Angle.Degrees(-51.79129012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93733"},
        {"Hipparcos Number", "HIP 52847"},
        {"Smithsonian Astrophysical Observation", "SAO 238495"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.08745392),
        dec: Angle.Degrees(-51.79102983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109974"},
        {"Hipparcos Number", "HIP 61752"},
        {"Smithsonian Astrophysical Observation", "SAO 240119"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.82985065),
        dec: Angle.Degrees(-51.79082375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181870"},
        {"Hipparcos Number", "HIP 95430"},
        {"Smithsonian Astrophysical Observation", "SAO 246074"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.17946382),
        dec: Angle.Degrees(-51.79057927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22250"},
        {"Hipparcos Number", "HIP 16521"},
        {"Smithsonian Astrophysical Observation", "SAO 233153"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.17785453),
        dec: Angle.Degrees(-51.78928140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141408"},
        {"Hipparcos Number", "HIP 77658"},
        {"Smithsonian Astrophysical Observation", "SAO 243049"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.81186682),
        dec: Angle.Degrees(-51.78864243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16878"},
        {"Hipparcos Number", "HIP 12471"},
        {"Geneva Identification System", "GEN# +1.00016878"},
        {"Smithsonian Astrophysical Observation", "SAO 232856"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.13276217),
        dec: Angle.Degrees(-51.78817808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212870"},
        {"Hipparcos Number", "HIP 110932"},
        {"Smithsonian Astrophysical Observation", "SAO 247460"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.12531005),
        dec: Angle.Degrees(-51.78803503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63036"},
        {"Hipparcos Number", "HIP 37726"},
        {"Geneva Identification System", "GEN# +1.00063036"},
        {"Smithsonian Astrophysical Observation", "SAO 235464"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.06674368),
        dec: Angle.Degrees(-51.78529899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21209B"},
        {"Hipparcos Number", "HIP 15771"},
        {"Geneva Identification System", "GEN# +1.00021209B"},
        {"Smithsonian Astrophysical Observation", "SAO 233095"},
    },
    visualMagnitude: 10.24,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.81530040),
        dec: Angle.Degrees(-49.99477031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 233.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 261.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90909"},
        {"Hipparcos Number", "HIP 51292"},
        {"Smithsonian Astrophysical Observation", "SAO 238097"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.15363700),
        dec: Angle.Degrees(-51.78522523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64316",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64316"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.73459151),
        dec: Angle.Degrees(-51.78507803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105646"},
        {"Hipparcos Number", "HIP 59290"},
        {"Smithsonian Astrophysical Observation", "SAO 239710"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.44424297),
        dec: Angle.Degrees(-51.78387784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186990"},
        {"Hipparcos Number", "HIP 97583"},
        {"Smithsonian Astrophysical Observation", "SAO 246289"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.51442123),
        dec: Angle.Degrees(-51.77952754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217901"},
        {"Hipparcos Number", "HIP 113955"},
        {"Smithsonian Astrophysical Observation", "SAO 247712"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.15963248),
        dec: Angle.Degrees(-51.77711841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37573"},
        {"Hipparcos Number", "HIP 26340"},
        {"Smithsonian Astrophysical Observation", "SAO 234046"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.13704823),
        dec: Angle.Degrees(-51.77507685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125764"},
        {"Hipparcos Number", "HIP 70312"},
        {"Geneva Identification System", "GEN# +1.00125764"},
        {"Smithsonian Astrophysical Observation", "SAO 241682"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.78091442),
        dec: Angle.Degrees(-51.77457169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185410"},
        {"Hipparcos Number", "HIP 96874"},
        {"Smithsonian Astrophysical Observation", "SAO 246217"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.39068626),
        dec: Angle.Degrees(-51.77441524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84507",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84507"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.13907701),
        dec: Angle.Degrees(-51.77242433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117470"},
        {"Hipparcos Number", "HIP 65977"},
        {"Smithsonian Astrophysical Observation", "SAO 240918"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.90698438),
        dec: Angle.Degrees(-51.77157528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142755"},
        {"Hipparcos Number", "HIP 78249"},
        {"Smithsonian Astrophysical Observation", "SAO 243186"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.64915923),
        dec: Angle.Degrees(-51.77113312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72019"},
        {"Hipparcos Number", "HIP 41539"},
        {"Smithsonian Astrophysical Observation", "SAO 236008"},
    },
    visualMagnitude: 7.45,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.06569040),
        dec: Angle.Degrees(-51.77039852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81907"},
        {"Hipparcos Number", "HIP 46340"},
        {"Celescope Catalog", "CEL 3299"},
        {"Geneva Identification System", "GEN# +1.00081907"},
        {"Smithsonian Astrophysical Observation", "SAO 236984"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.70667755),
        dec: Angle.Degrees(-51.76981901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59712",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59712"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.70061521),
        dec: Angle.Degrees(-51.76905012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15075"},
        {"Hipparcos Number", "HIP 11184"},
        {"Smithsonian Astrophysical Observation", "SAO 232750"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.01013780),
        dec: Angle.Degrees(-51.76902522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12042"},
        {"Hipparcos Number", "HIP 9085"},
        {"Cincinnati Publication", "Ci 20 136"},
        {"Geneva Identification System", "GEN# +1.00012042"},
        {"Smithsonian Astrophysical Observation", "SAO 232581"},
        {"Wilson Evans Batten Catalogue", "WEB 1906"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.24856719),
        dec: Angle.Degrees(-51.76685008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 348.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 249.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108701",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108701"},
        {"Geneva Identification System", "GEN# +6.20145099"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.29915684),
        dec: Angle.Degrees(-51.76216064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50197"},
        {"Hipparcos Number", "HIP 32701"},
        {"Geneva Identification System", "GEN# +1.00050197"},
        {"Smithsonian Astrophysical Observation", "SAO 234732"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.33081577),
        dec: Angle.Degrees(-51.76185806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298739"},
        {"Hipparcos Number", "HIP 48726"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.08330661),
        dec: Angle.Degrees(-51.76167326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48763"},
        {"Hipparcos Number", "HIP 32074"},
        {"Geneva Identification System", "GEN# +1.00048763"},
        {"Smithsonian Astrophysical Observation", "SAO 234660"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.52161086),
        dec: Angle.Degrees(-51.75961193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135861"},
        {"Hipparcos Number", "HIP 75004"},
        {"Smithsonian Astrophysical Observation", "SAO 242413"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.88522170),
        dec: Angle.Degrees(-51.75954064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65505",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65505"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.39650380),
        dec: Angle.Degrees(-51.75908553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85998"},
        {"Hipparcos Number", "HIP 48557"},
        {"Smithsonian Astrophysical Observation", "SAO 237470"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.53907324),
        dec: Angle.Degrees(-51.75754502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61121",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61121"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.89485996),
        dec: Angle.Degrees(-51.75735185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88842"},
        {"Hipparcos Number", "HIP 50078"},
        {"Geneva Identification System", "GEN# +1.00088842"},
        {"Smithsonian Astrophysical Observation", "SAO 237807"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.36685079),
        dec: Angle.Degrees(-51.75580487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29144"},
        {"Hipparcos Number", "HIP 21198"},
        {"Smithsonian Astrophysical Observation", "SAO 233555"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.17416064),
        dec: Angle.Degrees(-51.75470266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7282"},
        {"Hipparcos Number", "HIP 5617"},
        {"Smithsonian Astrophysical Observation", "SAO 232333"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.02621600),
        dec: Angle.Degrees(-51.75390745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203021"},
        {"Hipparcos Number", "HIP 105439"},
        {"Geneva Identification System", "GEN# +1.00203021"},
        {"Smithsonian Astrophysical Observation", "SAO 246985"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.34879161),
        dec: Angle.Degrees(-51.75239817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194879"},
        {"Hipparcos Number", "HIP 101153"},
        {"Smithsonian Astrophysical Observation", "SAO 246616"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.55953924),
        dec: Angle.Degrees(-51.75190154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146981"},
        {"Hipparcos Number", "HIP 80151"},
        {"Smithsonian Astrophysical Observation", "SAO 243687"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.40392791),
        dec: Angle.Degrees(-51.75088884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212345"},
        {"Hipparcos Number", "HIP 110631"},
        {"Smithsonian Astrophysical Observation", "SAO 247439"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.16722203),
        dec: Angle.Degrees(-51.75082136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27145",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27145"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.32065683),
        dec: Angle.Degrees(-51.74960002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89901"},
        {"Hipparcos Number", "HIP 50702"},
        {"Geneva Identification System", "GEN# +2.32280004"},
        {"Smithsonian Astrophysical Observation", "SAO 237963"},
        {"New General Catalogue", "NGC 3228 4"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.29704404),
        dec: Angle.Degrees(-51.74901101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203775"},
        {"Hipparcos Number", "HIP 105834"},
        {"Smithsonian Astrophysical Observation", "SAO 247029"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.53252851),
        dec: Angle.Degrees(-51.74834343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122140"},
        {"Hipparcos Number", "HIP 68490"},
        {"Smithsonian Astrophysical Observation", "SAO 241373"},
    },
    visualMagnitude: 9.00,
    bvColour: -0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.32218722),
        dec: Angle.Degrees(-51.74687384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3797"},
        {"Hipparcos Number", "HIP 3154"},
        {"Smithsonian Astrophysical Observation", "SAO 232138"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.02651850),
        dec: Angle.Degrees(-51.74488418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83358"},
        {"Hipparcos Number", "HIP 47116"},
        {"Celescope Catalog", "CEL 3338"},
        {"Geneva Identification System", "GEN# +1.00083358J"},
        {"Smithsonian Astrophysical Observation", "SAO 237133"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.02392596),
        dec: Angle.Degrees(-51.74468245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218391"},
        {"Hipparcos Number", "HIP 114248"},
        {"Renson", "Renson 60130"},
        {"Smithsonian Astrophysical Observation", "SAO 247752"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.07529126),
        dec: Angle.Degrees(-51.74422517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164896"},
        {"Hipparcos Number", "HIP 88675"},
        {"Smithsonian Astrophysical Observation", "SAO 245238"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.53838778),
        dec: Angle.Degrees(-51.74388948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159179"},
        {"Hipparcos Number", "HIP 86121"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.01072985),
        dec: Angle.Degrees(-51.74230448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71108"},
        {"Hipparcos Number", "HIP 41108"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.82299828),
        dec: Angle.Degrees(-51.74156151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70589"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.58774391),
        dec: Angle.Degrees(-51.74137799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89915"},
        {"Hipparcos Number", "HIP 50717"},
        {"Geneva Identification System", "GEN# +2.32280006"},
        {"Smithsonian Astrophysical Observation", "SAO 237969"},
        {"New General Catalogue", "NGC 3228 6"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.33286614),
        dec: Angle.Degrees(-51.74133492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106520"},
        {"Hipparcos Number", "HIP 59761"},
        {"Smithsonian Astrophysical Observation", "SAO 239792"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.81782336),
        dec: Angle.Degrees(-51.73920756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70587",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70587"},
    },
    visualMagnitude: 11.54,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.58297191),
        dec: Angle.Degrees(-51.73830238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65524",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65524"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.46761165),
        dec: Angle.Degrees(-51.73817851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178078"},
        {"Hipparcos Number", "HIP 94038"},
        {"Smithsonian Astrophysical Observation", "SAO 210979"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.18287594),
        dec: Angle.Degrees(-33.79487184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81471"},
        {"Hipparcos Number", "HIP 46093"},
        {"Geneva Identification System", "GEN# +1.00081471"},
        {"Smithsonian Astrophysical Observation", "SAO 236930"},
        {"Wilson Evans Batten Catalogue", "WEB 8728"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.99724486),
        dec: Angle.Degrees(-51.73709116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 524"},
        {"Hipparcos Number", "HIP 778"},
        {"Smithsonian Astrophysical Observation", "SAO 231949"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.40120624),
        dec: Angle.Degrees(-51.73705907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76140"},
        {"Hipparcos Number", "HIP 43556"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.06503859),
        dec: Angle.Degrees(-51.73685010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136505"},
        {"Hipparcos Number", "HIP 75306"},
        {"Geneva Identification System", "GEN# +1.00136505"},
        {"Smithsonian Astrophysical Observation", "SAO 242466"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.78975297),
        dec: Angle.Degrees(-51.73604699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206600"},
        {"Hipparcos Number", "HIP 107366"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.19891748),
        dec: Angle.Degrees(-51.73486525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222025"},
        {"Hipparcos Number", "HIP 116573"},
        {"Fundamental Katalog 5th Edition", "FK5 6092"},
        {"Smithsonian Astrophysical Observation", "SAO 247953"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.34906510),
        dec: Angle.Degrees(-51.73275659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106457"},
        {"Hipparcos Number", "HIP 59717"},
        {"Geneva Identification System", "GEN# +1.00106457"},
        {"Smithsonian Astrophysical Observation", "SAO 239788"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.71432712),
        dec: Angle.Degrees(-51.73101328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13424"},
        {"Hipparcos Number", "HIP 10091"},
        {"Smithsonian Astrophysical Observation", "SAO 232656"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.43796012),
        dec: Angle.Degrees(-51.73101027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71510"},
        {"Hipparcos Number", "HIP 41296"},
        {"Geneva Identification System", "GEN# +1.00071510"},
        {"Smithsonian Astrophysical Observation", "SAO 235959"},
        {"Smithsonian Astrophysical Observation 2", "SAO 235962"},
        {"Wilson Evans Batten Catalogue", "WEB 7988"},
    },
    visualMagnitude: 5.18,
    bvColour: -0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.38058013),
        dec: Angle.Degrees(-51.72745683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221593"},
        {"Hipparcos Number", "HIP 116289"},
        {"Geneva Identification System", "GEN# +1.00221593"},
        {"Smithsonian Astrophysical Observation", "SAO 247928"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.41890731),
        dec: Angle.Degrees(-51.72743047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31244"},
        {"Henry Draper 2", "HD 31245"},
        {"Hipparcos Number", "HIP 22570"},
        {"Geneva Identification System", "GEN# +1.00031244"},
        {"Smithsonian Astrophysical Observation", "SAO 233715"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.86262071),
        dec: Angle.Degrees(-51.72558824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84790"},
        {"Hipparcos Number", "HIP 47917"},
        {"Smithsonian Astrophysical Observation", "SAO 237318"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.49485174),
        dec: Angle.Degrees(-51.72382365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39090"},
        {"Hipparcos Number", "HIP 27328"},
        {"Smithsonian Astrophysical Observation", "SAO 234136"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.83493664),
        dec: Angle.Degrees(-51.71964381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190954"},
        {"Hipparcos Number", "HIP 99344"},
        {"Geneva Identification System", "GEN# +1.00190954"},
        {"Smithsonian Astrophysical Observation", "SAO 246466"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.45111662),
        dec: Angle.Degrees(-51.71811059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151933"},
        {"Hipparcos Number", "HIP 82599"},
        {"Geneva Identification System", "GEN# +1.00151933"},
        {"Smithsonian Astrophysical Observation", "SAO 244234"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.28446568),
        dec: Angle.Degrees(-51.71769033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61665",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61665"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.61303586),
        dec: Angle.Degrees(-51.71718097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -203.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89900"},
        {"Hipparcos Number", "HIP 50704"},
        {"Geneva Identification System", "GEN# +2.32280005"},
        {"Smithsonian Astrophysical Observation", "SAO 237966"},
        {"New General Catalogue", "NGC 3228 5"},
    },
    visualMagnitude: 8.19,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.30771025),
        dec: Angle.Degrees(-51.71458040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43660",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43660"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.41613290),
        dec: Angle.Degrees(-51.71447440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -354.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162151"},
        {"Hipparcos Number", "HIP 87469"},
        {"Geneva Identification System", "GEN# +1.00162151"},
        {"Smithsonian Astrophysical Observation", "SAO 245082"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.07726823),
        dec: Angle.Degrees(-51.71393618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46729"},
        {"Hipparcos Number", "HIP 31146"},
        {"Smithsonian Astrophysical Observation", "SAO 234559"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.02858411),
        dec: Angle.Degrees(-51.71377866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85777"},
        {"Hipparcos Number", "HIP 48440"},
        {"Celescope Catalog", "CEL 3394"},
        {"Geneva Identification System", "GEN# +1.00085777"},
        {"Smithsonian Astrophysical Observation", "SAO 237436"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.15150414),
        dec: Angle.Degrees(-51.71305747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159536"},
        {"Hipparcos Number", "HIP 86297"},
        {"Geneva Identification System", "GEN# +1.00159536"},
        {"Smithsonian Astrophysical Observation", "SAO 244897"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.50090895),
        dec: Angle.Degrees(-51.71074972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31064"},
        {"Hipparcos Number", "HIP 22459"},
        {"Smithsonian Astrophysical Observation", "SAO 233700"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.49618108),
        dec: Angle.Degrees(-51.71035906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119793"},
        {"Hipparcos Number", "HIP 67223"},
        {"Smithsonian Astrophysical Observation", "SAO 241155"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.62174845),
        dec: Angle.Degrees(-51.71027864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90884"},
        {"Hipparcos Number", "HIP 51271"},
        {"Smithsonian Astrophysical Observation", "SAO 238091"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.09800348),
        dec: Angle.Degrees(-51.70518181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223551"},
        {"Hipparcos Number", "HIP 117570"},
        {"Geneva Identification System", "GEN# +1.00223551"},
        {"Smithsonian Astrophysical Observation", "SAO 248037"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.64305406),
        dec: Angle.Degrees(-51.70514797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15362"},
        {"Hipparcos Number", "HIP 11382"},
        {"Geneva Identification System", "GEN# +1.00015362"},
        {"Smithsonian Astrophysical Observation", "SAO 232769"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.65819441),
        dec: Angle.Degrees(-51.70407600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217260"},
        {"Hipparcos Number", "HIP 113564"},
        {"Geneva Identification System", "GEN# +1.00217260"},
        {"Smithsonian Astrophysical Observation", "SAO 247673"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.03612004),
        dec: Angle.Degrees(-51.70123544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137249"},
        {"Hipparcos Number", "HIP 75626"},
        {"Smithsonian Astrophysical Observation", "SAO 242539"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.78007543),
        dec: Angle.Degrees(-51.69955198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116054"},
        {"Hipparcos Number", "HIP 65226"},
        {"Smithsonian Astrophysical Observation", "SAO 240780"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.50946249),
        dec: Angle.Degrees(-51.69910440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153431"},
        {"Hipparcos Number", "HIP 83362"},
        {"Smithsonian Astrophysical Observation", "SAO 244379"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.56807694),
        dec: Angle.Degrees(-51.69771821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61086",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61086"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.80267337),
        dec: Angle.Degrees(-51.69713926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104081"},
        {"Hipparcos Number", "HIP 58453"},
        {"Fundamental Katalog 5th Edition", "FK5 2959"},
        {"Geneva Identification System", "GEN# +1.00104081"},
        {"Smithsonian Astrophysical Observation", "SAO 239548"},
    },
    visualMagnitude: 6.04,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.79532236),
        dec: Angle.Degrees(-51.69674825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7241",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7241"},
    },
    visualMagnitude: 12.03,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.32148603),
        dec: Angle.Degrees(-51.69451236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52578"},
        {"Hipparcos Number", "HIP 33613"},
        {"Smithsonian Astrophysical Observation", "SAO 234828"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.75931501),
        dec: Angle.Degrees(-51.69195738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221277"},
        {"Hipparcos Number", "HIP 116071"},
        {"Smithsonian Astrophysical Observation", "SAO 247909"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.78685167),
        dec: Angle.Degrees(-51.69184772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103033"},
        {"Hipparcos Number", "HIP 57832"},
        {"Smithsonian Astrophysical Observation", "SAO 239433"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.89558533),
        dec: Angle.Degrees(-51.68852859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51436"},
        {"Hipparcos Number", "HIP 33198"},
        {"Smithsonian Astrophysical Observation", "SAO 234779"},
    },
    visualMagnitude: 8.81,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.64477393),
        dec: Angle.Degrees(-51.68848230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23078"},
        {"Hipparcos Number", "HIP 17111"},
        {"Geneva Identification System", "GEN# +1.00023078"},
        {"Smithsonian Astrophysical Observation", "SAO 233211"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.97830474),
        dec: Angle.Degrees(-51.68689691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218960"},
        {"Hipparcos Number", "HIP 114590"},
        {"Geneva Identification System", "GEN# +1.00218960"},
        {"Smithsonian Astrophysical Observation", "SAO 247775"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.21398715),
        dec: Angle.Degrees(-51.68580486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216337"},
        {"Hipparcos Number", "HIP 112992"},
        {"Smithsonian Astrophysical Observation", "SAO 247628"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.25017960),
        dec: Angle.Degrees(-51.68088553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109472"},
        {"Hipparcos Number", "HIP 61432"},
        {"Smithsonian Astrophysical Observation", "SAO 240079"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.82400822),
        dec: Angle.Degrees(-51.67593302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61541"},
        {"Hipparcos Number", "HIP 37085"},
        {"Smithsonian Astrophysical Observation", "SAO 235364"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.30696643),
        dec: Angle.Degrees(-51.67587629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129057"},
        {"Hipparcos Number", "HIP 71884"},
        {"Smithsonian Astrophysical Observation", "SAO 241919"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.54306640),
        dec: Angle.Degrees(-51.67547746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17126"},
        {"Hipparcos Number", "HIP 12687"},
        {"Geneva Identification System", "GEN# +1.00017126"},
        {"Smithsonian Astrophysical Observation", "SAO 232868"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.74927341),
        dec: Angle.Degrees(-51.67463458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29805"},
        {"Hipparcos Number", "HIP 21666"},
        {"Geneva Identification System", "GEN# +1.00029805"},
        {"Smithsonian Astrophysical Observation", "SAO 233605"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.76787044),
        dec: Angle.Degrees(-51.67279617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115915"},
        {"Hipparcos Number", "HIP 65158"},
        {"Celescope Catalog", "CEL 4239"},
        {"Geneva Identification System", "GEN# +1.00115915"},
        {"Smithsonian Astrophysical Observation", "SAO 240771"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.29314729),
        dec: Angle.Degrees(-51.67115261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76969"},
        {"Hipparcos Number", "HIP 43983"},
        {"Geneva Identification System", "GEN# +1.00076969"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.34549710),
        dec: Angle.Degrees(-51.67106832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -240.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 158.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1413"},
        {"Hipparcos Number", "HIP 1454"},
        {"Smithsonian Astrophysical Observation", "SAO 231990"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.53063171),
        dec: Angle.Degrees(-51.67027447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48465"},
        {"Hipparcos Number", "HIP 31957"},
        {"Smithsonian Astrophysical Observation", "SAO 234650"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.18291884),
        dec: Angle.Degrees(-51.66896856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74636"},
        {"Hipparcos Number", "HIP 42765"},
        {"Renson", "Renson 20870"},
        {"Smithsonian Astrophysical Observation", "SAO 236211"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.72016784),
        dec: Angle.Degrees(-51.66799211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43504"},
        {"Hipparcos Number", "HIP 29561"},
        {"Geneva Identification System", "GEN# +1.00043504"},
        {"Smithsonian Astrophysical Observation", "SAO 234384"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.42403394),
        dec: Angle.Degrees(-51.66746476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105013"},
        {"Hipparcos Number", "HIP 58967"},
        {"Smithsonian Astrophysical Observation", "SAO 239653"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.36221491),
        dec: Angle.Degrees(-51.66541409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194490"},
        {"Hipparcos Number", "HIP 100942"},
        {"Geneva Identification System", "GEN# +1.00194490"},
        {"Smithsonian Astrophysical Observation", "SAO 246596"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.99955895),
        dec: Angle.Degrees(-51.66442706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7326"},
        {"Hipparcos Number", "HIP 5641"},
        {"Smithsonian Astrophysical Observation", "SAO 232337"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.11942675),
        dec: Angle.Degrees(-51.66323022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100004"},
        {"Hipparcos Number", "HIP 56089"},
        {"Geneva Identification System", "GEN# +1.00100004"},
        {"Smithsonian Astrophysical Observation", "SAO 239117"},
        {"Wilson Evans Batten Catalogue", "WEB 10071"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.45174900),
        dec: Angle.Degrees(-51.66321486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -348.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192963"},
        {"Hipparcos Number", "HIP 100260"},
        {"Smithsonian Astrophysical Observation", "SAO 246531"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.01967023),
        dec: Angle.Degrees(-51.65803138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63764"},
        {"Hipparcos Number", "HIP 38049"},
        {"Smithsonian Astrophysical Observation", "SAO 235522"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.98607448),
        dec: Angle.Degrees(-51.65604161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100250"},
        {"Hipparcos Number", "HIP 56241"},
        {"Geneva Identification System", "GEN# +1.00100250"},
        {"Smithsonian Astrophysical Observation", "SAO 239144"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.93680743),
        dec: Angle.Degrees(-51.65409951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166140"},
        {"Hipparcos Number", "HIP 89179"},
        {"Smithsonian Astrophysical Observation", "SAO 245307"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.00144764),
        dec: Angle.Degrees(-51.65345288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119121"},
        {"Hipparcos Number", "HIP 66882"},
        {"Celescope Catalog", "CEL 4278"},
        {"Geneva Identification System", "GEN# +1.00119121"},
        {"Smithsonian Astrophysical Observation", "SAO 241092"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.59919021),
        dec: Angle.Degrees(-51.65342930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40542"},
        {"Hipparcos Number", "HIP 28120"},
        {"Smithsonian Astrophysical Observation", "SAO 234217"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.14631063),
        dec: Angle.Degrees(-51.65289792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79890"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.60320781),
        dec: Angle.Degrees(-51.65242980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171941"},
        {"Hipparcos Number", "HIP 91544"},
        {"Geneva Identification System", "GEN# +1.00171941"},
        {"Smithsonian Astrophysical Observation", "SAO 245625"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.03562330),
        dec: Angle.Degrees(-51.65225637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2823"},
        {"Hipparcos Number", "HIP 2462"},
        {"Smithsonian Astrophysical Observation", "SAO 232075"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.81873668),
        dec: Angle.Degrees(-51.64932569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164249"},
        {"Henry Draper 2", "HD 164249A"},
        {"Hipparcos Number", "HIP 88399"},
        {"Geneva Identification System", "GEN# +1.00164249"},
        {"Smithsonian Astrophysical Observation", "SAO 245201"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.76419861),
        dec: Angle.Degrees(-51.64880010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176151"},
        {"Hipparcos Number", "HIP 93415"},
        {"Geneva Identification System", "GEN# +1.00176151"},
        {"Smithsonian Astrophysical Observation", "SAO 245866"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.37932095),
        dec: Angle.Degrees(-51.64757943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25816"},
        {"Hipparcos Number", "HIP 18898"},
        {"Smithsonian Astrophysical Observation", "SAO 233375"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.76382441),
        dec: Angle.Degrees(-51.64700375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61740"},
        {"Hipparcos Number", "HIP 37161"},
        {"Smithsonian Astrophysical Observation", "SAO 235374"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.54955723),
        dec: Angle.Degrees(-51.64485297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128672"},
        {"Hipparcos Number", "HIP 71696"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.99574965),
        dec: Angle.Degrees(-51.64476058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37119"},
        {"Hipparcos Number", "HIP 26039"},
        {"Geneva Identification System", "GEN# +1.00037119"},
        {"Smithsonian Astrophysical Observation", "SAO 234021"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.32245559),
        dec: Angle.Degrees(-51.64172304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99497"},
        {"Hipparcos Number", "HIP 55818"},
        {"Smithsonian Astrophysical Observation", "SAO 239064"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.59367781),
        dec: Angle.Degrees(-51.63988596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2263"},
        {"Hipparcos Number", "HIP 2071"},
        {"Renson", "Renson 540"},
        {"Smithsonian Astrophysical Observation", "SAO 232041"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.54978596),
        dec: Angle.Degrees(-51.63902101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37895"},
        {"Hipparcos Number", "HIP 26564"},
        {"Smithsonian Astrophysical Observation", "SAO 234067"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.72411924),
        dec: Angle.Degrees(-51.63804609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111558"},
        {"Geneva Identification System", "GEN# -0.05212044"},
        {"Smithsonian Astrophysical Observation", "SAO 247508"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.01355435),
        dec: Angle.Degrees(-51.63717954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 275.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85647",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85647"},
        {"Geneva Identification System", "GEN# -0.05110924"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.54769926),
        dec: Angle.Degrees(-51.63652531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -259.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144417"},
        {"Hipparcos Number", "HIP 79060"},
        {"Smithsonian Astrophysical Observation", "SAO 243357"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.07044699),
        dec: Angle.Degrees(-51.63609083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79257"},
        {"Hipparcos Number", "HIP 45090"},
        {"Smithsonian Astrophysical Observation", "SAO 236689"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.77737800),
        dec: Angle.Degrees(-51.63516194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165699"},
        {"Hipparcos Number", "HIP 89012"},
        {"Geneva Identification System", "GEN# +1.00165699"},
        {"Smithsonian Astrophysical Observation", "SAO 245281"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.50646216),
        dec: Angle.Degrees(-51.63364871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11211"},
        {"Hipparcos Number", "HIP 8440"},
        {"Smithsonian Astrophysical Observation", "SAO 232530"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.20745482),
        dec: Angle.Degrees(-51.63219803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298428"},
        {"Hipparcos Number", "HIP 46656"},
        {"Geneva Identification System", "GEN# +1.00298428"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.69022875),
        dec: Angle.Degrees(-51.63094917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51903"},
        {"Hipparcos Number", "HIP 33366"},
        {"Smithsonian Astrophysical Observation", "SAO 234794"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.08812037),
        dec: Angle.Degrees(-51.62726266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119329"},
        {"Hipparcos Number", "HIP 66990"},
        {"Geneva Identification System", "GEN# +1.00119329"},
        {"Smithsonian Astrophysical Observation", "SAO 241115"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.93640772),
        dec: Angle.Degrees(-51.62633649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -195.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3556"},
        {"Geneva Identification System", "GEN# +6.20145173"},
    },
    visualMagnitude: 11.91,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.36692411),
        dec: Angle.Degrees(-51.62595150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219933"},
        {"Hipparcos Number", "HIP 115221"},
        {"Smithsonian Astrophysical Observation", "SAO 247835"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.06717692),
        dec: Angle.Degrees(-51.62495873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163436"},
        {"Hipparcos Number", "HIP 88041"},
        {"Geneva Identification System", "GEN# +1.00163436"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.74057511),
        dec: Angle.Degrees(-51.62481780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -204.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
