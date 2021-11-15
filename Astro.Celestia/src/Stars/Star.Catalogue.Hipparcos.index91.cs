using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_91() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20180"},
        {"Hipparcos Number", "HIP 15183"},
        {"Smithsonian Astrophysical Observation", "SAO 56290"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.93084452),
        dec: Angle.Degrees(+34.20620548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69907",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9214 AB"},
        {"Henry Draper", "HD 125407"},
        {"Hipparcos Number", "HIP 69907"},
        {"Smithsonian Astrophysical Observation", "SAO 64058"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.60297989),
        dec: Angle.Degrees(+34.20658878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70988"},
        {"Hipparcos Number", "HIP 41356"},
        {"Smithsonian Astrophysical Observation", "SAO 60808"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.55767567),
        dec: Angle.Degrees(+34.20798379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72609"},
        {"Smithsonian Astrophysical Observation", "SAO 64357"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.68183990),
        dec: Angle.Degrees(+34.20869323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21454",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3323 AB"},
        {"Henry Draper", "HD 280026"},
        {"Hipparcos Number", "HIP 21454"},
        {"Geneva Identification System", "GEN# +1.00280026J"},
        {"Smithsonian Astrophysical Observation", "SAO 57335"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.10316529),
        dec: Angle.Degrees(+34.20926294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206295"},
        {"Hipparcos Number", "HIP 107013"},
        {"Geneva Identification System", "GEN# +1.00206295"},
        {"Smithsonian Astrophysical Observation", "SAO 71581"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.10198138),
        dec: Angle.Degrees(+34.21017348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38723"},
        {"Hipparcos Number", "HIP 27494"},
        {"Geneva Identification System", "GEN# +1.00038723"},
        {"Smithsonian Astrophysical Observation", "SAO 58473"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.32941679),
        dec: Angle.Degrees(+34.21075105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82104"},
        {"Hipparcos Number", "HIP 46663"},
        {"Smithsonian Astrophysical Observation", "SAO 61533"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.71242523),
        dec: Angle.Degrees(+34.21098259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94517",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12211 B"},
        {"Hipparcos Number", "HIP 94517"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.55137383),
        dec: Angle.Degrees(+34.21121621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173742"},
        {"Hipparcos Number", "HIP 92026"},
        {"Geneva Identification System", "GEN# +1.00173742"},
        {"Smithsonian Astrophysical Observation", "SAO 67337"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.36744643),
        dec: Angle.Degrees(+34.21366881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94519",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12211 A"},
        {"Henry Draper", "HD 180214"},
        {"Hipparcos Number", "HIP 94519"},
        {"Celescope Catalog", "CEL 4725"},
        {"Geneva Identification System", "GEN# +1.00180214"},
        {"Smithsonian Astrophysical Observation", "SAO 68019"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.55696408),
        dec: Angle.Degrees(+34.21512636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160803"},
        {"Hipparcos Number", "HIP 86488"},
        {"Geneva Identification System", "GEN# +1.00160803"},
        {"Smithsonian Astrophysical Observation", "SAO 66239"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.10305965),
        dec: Angle.Degrees(+34.21539557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53229",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Praecipua"},
        {"Henry Draper", "HD 94264"},
        {"Hipparcos Number", "HIP 53229"},
        {"Fundamental Katalog 5th Edition", "FK5 412"},
        {"Geneva Identification System", "GEN# +1.00094264"},
        {"Smithsonian Astrophysical Observation", "SAO 62297"},
        {"Wilson Evans Batten Catalogue", "WEB 9661"},
    },
    visualMagnitude: 3.79,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.32766612),
        dec: Angle.Degrees(+34.21556641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -286.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71418"},
    },
    visualMagnitude: 11.08,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.07839472),
        dec: Angle.Degrees(+34.21769760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -217.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24190"},
        {"Hipparcos Number", "HIP 18111"},
        {"Geneva Identification System", "GEN# +1.00024190"},
        {"Smithsonian Astrophysical Observation", "SAO 56768"},
        {"Wilson Evans Batten Catalogue", "WEB 3494"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.07898195),
        dec: Angle.Degrees(+34.22212431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194448"},
        {"Hipparcos Number", "HIP 100632"},
        {"Smithsonian Astrophysical Observation", "SAO 69969"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.08151951),
        dec: Angle.Degrees(+34.22224206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20468"},
        {"Hipparcos Number", "HIP 15416"},
        {"Fundamental Katalog 5th Edition", "FK5 2232"},
        {"Geneva Identification System", "GEN# +1.00020468"},
        {"Smithsonian Astrophysical Observation", "SAO 56340"},
        {"Wilson Evans Batten Catalogue", "WEB 2964"},
    },
    visualMagnitude: 4.85,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.68259978),
        dec: Angle.Degrees(+34.22267370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95845"},
        {"Hipparcos Number", "HIP 54086"},
        {"Smithsonian Astrophysical Observation", "SAO 62384"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.00983313),
        dec: Angle.Degrees(+34.22356733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111277",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16034 B"},
        {"Hipparcos Number", "HIP 111277"},
    },
    visualMagnitude: 9.50,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)32, 34.8100),
        dec: Angle.DegreesMinutesSeconds((int)+34, (int)13, 26.500)
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
    primaryId: "HIP 101642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196439"},
        {"Hipparcos Number", "HIP 101642"},
        {"Smithsonian Astrophysical Observation", "SAO 70251"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.04841450),
        dec: Angle.Degrees(+34.22450353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10644",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1739 A"},
        {"Henry Draper", "HD 13974"},
        {"Hipparcos Number", "HIP 10644"},
        {"Cincinnati Publication", "Ci 20 162"},
        {"Geneva Identification System", "GEN# +1.00013974"},
        {"Smithsonian Astrophysical Observation", "SAO 55420"},
        {"Wilson Evans Batten Catalogue", "WEB 2239"},
    },
    visualMagnitude: 4.84,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.26007346),
        dec: Angle.Degrees(+34.22482985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1151.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -246.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82209",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82209"},
        {"Smithsonian Astrophysical Observation", "SAO 65558"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.91953632),
        dec: Angle.Degrees(+34.22630320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213560"},
        {"Hipparcos Number", "HIP 111202"},
        {"Geneva Identification System", "GEN# +1.00213560"},
        {"Smithsonian Astrophysical Observation", "SAO 72434"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.93216012),
        dec: Angle.Degrees(+34.22774996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111279",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16034 A"},
        {"Henry Draper", "HD 213661"},
        {"Hipparcos Number", "HIP 111279"},
        {"Geneva Identification System", "GEN# +1.00213661"},
        {"Smithsonian Astrophysical Observation", "SAO 72448"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.14927612),
        dec: Angle.Degrees(+34.22881084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137002"},
        {"Hipparcos Number", "HIP 75245"},
        {"Smithsonian Astrophysical Observation", "SAO 64661"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.63494526),
        dec: Angle.Degrees(+34.22928355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43681"},
        {"Hipparcos Number", "HIP 30013"},
        {"Smithsonian Astrophysical Observation", "SAO 58977"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.74676574),
        dec: Angle.Degrees(+34.23060332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95600",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95600"},
        {"Smithsonian Astrophysical Observation", "SAO 68317"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.66676092),
        dec: Angle.Degrees(+34.23064593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79675",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79675"},
        {"Smithsonian Astrophysical Observation", "SAO 65179"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.92558177),
        dec: Angle.Degrees(+34.23555643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57836"},
        {"Hipparcos Number", "HIP 35932"},
        {"Geneva Identification System", "GEN# +1.00057836"},
        {"Smithsonian Astrophysical Observation", "SAO 60050"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.10522553),
        dec: Angle.Degrees(+34.23622980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152263"},
        {"Hipparcos Number", "HIP 82438"},
        {"Geneva Identification System", "GEN# +1.00152263"},
        {"Smithsonian Astrophysical Observation", "SAO 65599"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.71913037),
        dec: Angle.Degrees(+34.23638087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257835"},
        {"Hipparcos Number", "HIP 30928"},
        {"Smithsonian Astrophysical Observation", "SAO 59140"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.36474067),
        dec: Angle.Degrees(+34.23645500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144562"},
        {"Hipparcos Number", "HIP 78798"},
        {"Smithsonian Astrophysical Observation", "SAO 65066"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.29697129),
        dec: Angle.Degrees(+34.23669581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68521",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68521"},
        {"Geneva Identification System", "GEN# +0.03402480"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.41726237),
        dec: Angle.Degrees(+34.23887284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25657"},
        {"Hipparcos Number", "HIP 19089"},
        {"Geneva Identification System", "GEN# +1.00025657"},
        {"Smithsonian Astrophysical Observation", "SAO 56960"},
        {"Wilson Evans Batten Catalogue", "WEB 3666"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.40010556),
        dec: Angle.Degrees(+34.23931002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114275"},
        {"Smithsonian Astrophysical Observation", "SAO 73032"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.17112221),
        dec: Angle.Degrees(+34.23968095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107421",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107421"},
    },
    visualMagnitude: 11.77,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.36647424),
        dec: Angle.Degrees(+34.24027930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57278"},
        {"Geneva Identification System", "GEN# +0.03502277"},
        {"Smithsonian Astrophysical Observation", "SAO 62685"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.18149397),
        dec: Angle.Degrees(+34.24144806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 254168"},
        {"Hipparcos Number", "HIP 29835"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.23313976),
        dec: Angle.Degrees(+34.24165206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87883"},
        {"Hipparcos Number", "HIP 49699"},
        {"Smithsonian Astrophysical Observation", "SAO 61890"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.17993726),
        dec: Angle.Degrees(+34.24240630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113141",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113141"},
        {"Smithsonian Astrophysical Observation", "SAO 72830"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.67579098),
        dec: Angle.Degrees(+34.24241894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62609"},
        {"Geneva Identification System", "GEN# +0.03502380"},
        {"Smithsonian Astrophysical Observation", "SAO 63215"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.43873555),
        dec: Angle.Degrees(+34.24255875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98989"},
        {"Hipparcos Number", "HIP 55627"},
        {"Fundamental Katalog 5th Edition", "FK5 5004"},
        {"Geneva Identification System", "GEN# +1.00098989"},
        {"Smithsonian Astrophysical Observation", "SAO 62532"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.94356370),
        dec: Angle.Degrees(+34.24275729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8375"},
        {"Hipparcos Number", "HIP 6512"},
        {"Geneva Identification System", "GEN# +1.00008375"},
        {"Smithsonian Astrophysical Observation", "SAO 54654"},
        {"Wilson Evans Batten Catalogue", "WEB 1434"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.90546597),
        dec: Angle.Degrees(+34.24560145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 231.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 117.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189257"},
        {"Hipparcos Number", "HIP 98239"},
        {"Smithsonian Astrophysical Observation", "SAO 69163"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.45582083),
        dec: Angle.Degrees(+34.24665767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55026"},
        {"Hipparcos Number", "HIP 34853"},
        {"Smithsonian Astrophysical Observation", "SAO 59888"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.19077075),
        dec: Angle.Degrees(+34.25009593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107633"},
        {"Hipparcos Number", "HIP 60314"},
        {"Geneva Identification System", "GEN# +1.00107633"},
        {"Smithsonian Astrophysical Observation", "SAO 62970"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.51091823),
        dec: Angle.Degrees(+34.25585920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99580"},
        {"Hipparcos Number", "HIP 55926"},
        {"Geneva Identification System", "GEN# +1.00099580"},
        {"Smithsonian Astrophysical Observation", "SAO 62562"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.92636567),
        dec: Angle.Degrees(+34.25642460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105946"},
        {"Hipparcos Number", "HIP 59440"},
        {"Fundamental Katalog 5th Edition", "FK5 5080"},
        {"Geneva Identification System", "GEN# +1.00105946"},
        {"Smithsonian Astrophysical Observation", "SAO 62886"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.88360474),
        dec: Angle.Degrees(+34.25890486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140026"},
        {"Hipparcos Number", "HIP 76744"},
        {"Smithsonian Astrophysical Observation", "SAO 64838"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.07282822),
        dec: Angle.Degrees(+34.26029298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42154"},
        {"Hipparcos Number", "HIP 29308"},
        {"Smithsonian Astrophysical Observation", "SAO 58829"},
    },
    visualMagnitude: 7.79,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.68604851),
        dec: Angle.Degrees(+34.26044594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59564"},
        {"Smithsonian Astrophysical Observation", "SAO 62898"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.22267098),
        dec: Angle.Degrees(+34.26093683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65029",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65029"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.94695569),
        dec: Angle.Degrees(+34.26180467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147249"},
        {"Hipparcos Number", "HIP 79976"},
        {"Smithsonian Astrophysical Observation", "SAO 65229"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.86917215),
        dec: Angle.Degrees(+34.26293688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201668"},
        {"Hipparcos Number", "HIP 104509"},
        {"Geneva Identification System", "GEN# +1.00201668"},
        {"Smithsonian Astrophysical Observation", "SAO 71005"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.54223120),
        dec: Angle.Degrees(+34.26304642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114663",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114663"},
        {"Smithsonian Astrophysical Observation", "SAO 73097"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.41567533),
        dec: Angle.Degrees(+34.26307729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118887"},
        {"Hipparcos Number", "HIP 66602"},
        {"Geneva Identification System", "GEN# +1.00118887"},
        {"Smithsonian Astrophysical Observation", "SAO 63664"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.78989293),
        dec: Angle.Degrees(+34.26319011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203974"},
        {"Hipparcos Number", "HIP 105704"},
        {"Smithsonian Astrophysical Observation", "SAO 71299"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.14185079),
        dec: Angle.Degrees(+34.26324638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109255",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109255"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.00221834),
        dec: Angle.Degrees(+34.26373241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16210"},
        {"Hipparcos Number", "HIP 12193"},
        {"Wilson Evans Batten Catalogue", "WEB 2501"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.25964806),
        dec: Angle.Degrees(+34.26428615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 374",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 32 AB"},
        {"Henry Draper", "HD 225220"},
        {"Hipparcos Number", "HIP 374"},
        {"Smithsonian Astrophysical Observation", "SAO 53617"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.16704444),
        dec: Angle.Degrees(+34.26519797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47579",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47579"},
        {"Smithsonian Astrophysical Observation", "SAO 61640"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.52281648),
        dec: Angle.Degrees(+34.26523001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44475"},
        {"Hipparcos Number", "HIP 30403"},
        {"Smithsonian Astrophysical Observation", "SAO 59033"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.89156306),
        dec: Angle.Degrees(+34.26528475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169687"},
        {"Hipparcos Number", "HIP 90210"},
        {"Smithsonian Astrophysical Observation", "SAO 66944"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.10688346),
        dec: Angle.Degrees(+34.26649112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75921"},
        {"Smithsonian Astrophysical Observation", "SAO 64739"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.60002443),
        dec: Angle.Degrees(+34.26734393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34698"},
        {"Hipparcos Number", "HIP 24962"},
        {"Smithsonian Astrophysical Observation", "SAO 57921"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.20806421),
        dec: Angle.Degrees(+34.26748513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5852",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1005 AB"},
        {"Hipparcos Number", "HIP 5852"},
        {"Smithsonian Astrophysical Observation", "SAO 54548"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.76425107),
        dec: Angle.Degrees(+34.26754345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159003"},
        {"Hipparcos Number", "HIP 85706"},
        {"Geneva Identification System", "GEN# +1.00159003"},
        {"Smithsonian Astrophysical Observation", "SAO 66104"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.71165525),
        dec: Angle.Degrees(+34.26812045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31501"},
        {"Hipparcos Number", "HIP 23080"},
        {"Cincinnati Publication", "Ci 18 634"},
        {"Cincinnati Publication 2", "Ci 20 310"},
        {"Geneva Identification System", "GEN# +1.00031501"},
        {"Wilson Evans Batten Catalogue", "WEB 4478"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.49567684),
        dec: Angle.Degrees(+34.26851179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 581.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39224"},
        {"Hipparcos Number", "HIP 27775"},
        {"Geneva Identification System", "GEN# +1.00039224"},
        {"Smithsonian Astrophysical Observation", "SAO 58526"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.16264906),
        dec: Angle.Degrees(+34.26885450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159222"},
        {"Hipparcos Number", "HIP 85810"},
        {"Geneva Identification System", "GEN# +1.00159222"},
        {"Smithsonian Astrophysical Observation", "SAO 66118"},
        {"Wilson Evans Batten Catalogue", "WEB 14479"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.00484063),
        dec: Angle.Degrees(+34.27099419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -239.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32540"},
        {"Hipparcos Number", "HIP 23675"},
        {"Geneva Identification System", "GEN# +1.00032540"},
        {"Smithsonian Astrophysical Observation", "SAO 57620"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.34026063),
        dec: Angle.Degrees(+34.27129494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 375",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 32 C"},
        {"Hipparcos Number", "HIP 375"},
    },
    visualMagnitude: 9.08,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.16729373),
        dec: Angle.Degrees(+34.27150566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207199"},
        {"Hipparcos Number", "HIP 107510"},
        {"Smithsonian Astrophysical Observation", "SAO 71683"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.61817888),
        dec: Angle.Degrees(+34.27278459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103544",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103544"},
    },
    visualMagnitude: 11.21,
    bvColour: 1.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.67385352),
        dec: Angle.Degrees(+34.27453088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 292.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87105",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10807 A"},
        {"Henry Draper", "HD 162094"},
        {"Hipparcos Number", "HIP 87105"},
        {"Smithsonian Astrophysical Observation", "SAO 66336"},
        {"Wilson Evans Batten Catalogue", "WEB 14696"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.96691372),
        dec: Angle.Degrees(+34.27788181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160978"},
        {"Hipparcos Number", "HIP 86567"},
        {"Geneva Identification System", "GEN# +1.00160978"},
        {"Smithsonian Astrophysical Observation", "SAO 66256"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.36301318),
        dec: Angle.Degrees(+34.27910939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65143",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65143"},
        {"Wilson Evans Batten Catalogue", "WEB 11504"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.24044732),
        dec: Angle.Degrees(+34.27966699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 486.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -297.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81578",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81578"},
    },
    visualMagnitude: 11.00,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.90714232),
        dec: Angle.Degrees(+34.27972685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 180.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129269"},
        {"Hipparcos Number", "HIP 71760"},
        {"Fundamental Katalog 5th Edition", "FK5 5304"},
        {"Smithsonian Astrophysical Observation", "SAO 64269"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.17965154),
        dec: Angle.Degrees(+34.27974959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146929"},
        {"Hipparcos Number", "HIP 79819"},
        {"Smithsonian Astrophysical Observation", "SAO 65203"},
        {"Wilson Evans Batten Catalogue", "WEB 13513"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.36409981),
        dec: Angle.Degrees(+34.28125238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208136"},
        {"Hipparcos Number", "HIP 108049"},
        {"Geneva Identification System", "GEN# +1.00208136"},
        {"Smithsonian Astrophysical Observation", "SAO 71802"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.34734935),
        dec: Angle.Degrees(+34.28156360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114879"},
        {"Hipparcos Number", "HIP 64477"},
        {"Geneva Identification System", "GEN# +1.00114879"},
        {"Smithsonian Astrophysical Observation", "SAO 63406"},
        {"Wilson Evans Batten Catalogue", "WEB 11397"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.23062080),
        dec: Angle.Degrees(+34.28158283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12247"},
        {"Hipparcos Number", "HIP 9415"},
        {"Geneva Identification System", "GEN# +1.00012247"},
        {"Smithsonian Astrophysical Observation", "SAO 55189"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.24131271),
        dec: Angle.Degrees(+34.28177899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111"},
    },
    visualMagnitude: 11.28,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.34908697),
        dec: Angle.Degrees(+34.28185977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 258.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48717",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48717"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.04340154),
        dec: Angle.Degrees(+34.28239834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92602"},
        {"Hipparcos Number", "HIP 52354"},
        {"Smithsonian Astrophysical Observation", "SAO 62202"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.49153968),
        dec: Angle.Degrees(+34.28252765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278813"},
        {"Hipparcos Number", "HIP 16621"},
        {"Geneva Identification System", "GEN# +1.00278813"},
        {"Smithsonian Astrophysical Observation", "SAO 56543"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.47133176),
        dec: Angle.Degrees(+34.28508489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20994"},
        {"Hipparcos Number", "HIP 15877"},
        {"Smithsonian Astrophysical Observation", "SAO 56418"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.12428481),
        dec: Angle.Degrees(+34.28612284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119603"},
        {"Hipparcos Number", "HIP 66969"},
        {"Geneva Identification System", "GEN# +1.00119603"},
        {"Smithsonian Astrophysical Observation", "SAO 63709"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.88608354),
        dec: Angle.Degrees(+34.28787315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182055"},
        {"Hipparcos Number", "HIP 95145"},
        {"Smithsonian Astrophysical Observation", "SAO 68191"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.36177661),
        dec: Angle.Degrees(+34.28888529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115610",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115610"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.29800314),
        dec: Angle.Degrees(+34.28895676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -297.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -695.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152305"},
        {"Hipparcos Number", "HIP 82471"},
        {"Geneva Identification System", "GEN# +1.00152305"},
        {"Smithsonian Astrophysical Observation", "SAO 65605"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.81361110),
        dec: Angle.Degrees(+34.28910610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197193"},
        {"Hipparcos Number", "HIP 102065"},
        {"Geneva Identification System", "GEN# +1.00197193"},
        {"Smithsonian Astrophysical Observation", "SAO 70364"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.25744260),
        dec: Angle.Degrees(+34.29383374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202386"},
        {"Hipparcos Number", "HIP 104846"},
        {"Smithsonian Astrophysical Observation", "SAO 71109"},
    },
    visualMagnitude: 7.37,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.58244848),
        dec: Angle.Degrees(+34.29434982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16773"},
        {"Hipparcos Number", "HIP 12628"},
        {"Geneva Identification System", "GEN# +1.00016773"},
        {"Smithsonian Astrophysical Observation", "SAO 55800"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.57692459),
        dec: Angle.Degrees(+34.29468773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114537"},
        {"Hipparcos Number", "HIP 64302"},
        {"Geneva Identification System", "GEN# +1.00114537"},
        {"Smithsonian Astrophysical Observation", "SAO 63383"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.69185975),
        dec: Angle.Degrees(+34.30071706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279187"},
        {"Hipparcos Number", "HIP 18394"},
        {"Geneva Identification System", "GEN# +1.00279187"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.98774351),
        dec: Angle.Degrees(+34.30103433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111342"},
        {"Smithsonian Astrophysical Observation", "SAO 72460"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.35637584),
        dec: Angle.Degrees(+34.30264988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96735"},
        {"Hipparcos Number", "HIP 54491"},
        {"Smithsonian Astrophysical Observation", "SAO 62424"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.23298835),
        dec: Angle.Degrees(+34.30328854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225806"},
        {"Hipparcos Number", "HIP 97379"},
        {"Smithsonian Astrophysical Observation", "SAO 68856"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.86822210),
        dec: Angle.Degrees(+34.30456503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101641"},
        {"Hipparcos Number", "HIP 57069"},
        {"Geneva Identification System", "GEN# +1.00101641"},
        {"Smithsonian Astrophysical Observation", "SAO 62659"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.48701093),
        dec: Angle.Degrees(+34.30808797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119930"},
        {"Hipparcos Number", "HIP 67151"},
        {"Smithsonian Astrophysical Observation", "SAO 63726"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.41598330),
        dec: Angle.Degrees(+34.30992828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70088"},
        {"Hipparcos Number", "HIP 40942"},
        {"Geneva Identification System", "GEN# +1.00070088"},
        {"Smithsonian Astrophysical Observation", "SAO 60753"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.33673284),
        dec: Angle.Degrees(+34.31023621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23730"},
        {"Hipparcos Number", "HIP 17815"},
        {"Geneva Identification System", "GEN# +1.00023730"},
        {"Smithsonian Astrophysical Observation", "SAO 56719"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.18177333),
        dec: Angle.Degrees(+34.31034124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1459",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1459"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.54389791),
        dec: Angle.Degrees(+34.31044650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38402"},
        {"Hipparcos Number", "HIP 27296"},
        {"Geneva Identification System", "GEN# +1.00038402"},
        {"Smithsonian Astrophysical Observation", "SAO 58426"},
    },
    visualMagnitude: 7.07,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.75225314),
        dec: Angle.Degrees(+34.31182878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24575",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3843 A"},
        {"Henry Draper", "HD 34078"},
        {"Hipparcos Number", "HIP 24575"},
        {"Celescope Catalog", "CEL 587"},
        {"Geneva Identification System", "GEN# +1.00034078J"},
        {"Smithsonian Astrophysical Observation", "SAO 57816"},
        {"Wilson Evans Batten Catalogue", "WEB 4757"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.07563540),
        dec: Angle.Degrees(+34.31221188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202393"},
        {"Hipparcos Number", "HIP 104855"},
        {"Geneva Identification System", "GEN# +1.00202393"},
        {"Smithsonian Astrophysical Observation", "SAO 71112"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.60748117),
        dec: Angle.Degrees(+34.31383622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20570",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3185 A"},
        {"Henry Draper", "HD 27770"},
        {"Hipparcos Number", "HIP 20570"},
        {"Smithsonian Astrophysical Observation", "SAO 57211"},
        {"Wilson Evans Batten Catalogue", "WEB 3938"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.10351476),
        dec: Angle.Degrees(+34.31481958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190536"},
        {"Hipparcos Number", "HIP 98817"},
        {"Geneva Identification System", "GEN# +1.00190536"},
        {"Smithsonian Astrophysical Observation", "SAO 69341"},
        {"Wilson Evans Batten Catalogue", "WEB 17518"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.02031816),
        dec: Angle.Degrees(+34.31488218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20573",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3185 B"},
        {"Hipparcos Number", "HIP 20573"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.10932382),
        dec: Angle.Degrees(+34.31742731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220432"},
        {"Hipparcos Number", "HIP 115471"},
        {"Smithsonian Astrophysical Observation", "SAO 73216"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.87219502),
        dec: Angle.Degrees(+34.31786527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3576"},
        {"Hipparcos Number", "HIP 3074"},
        {"Smithsonian Astrophysical Observation", "SAO 54054"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.74784239),
        dec: Angle.Degrees(+34.31859933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149085"},
        {"Hipparcos Number", "HIP 80892"},
        {"Smithsonian Astrophysical Observation", "SAO 65357"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.77661661),
        dec: Angle.Degrees(+34.32034869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41614"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.26090161),
        dec: Angle.Degrees(+34.32076252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215521"},
        {"Hipparcos Number", "HIP 112345"},
        {"Smithsonian Astrophysical Observation", "SAO 72688"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.33536319),
        dec: Angle.Degrees(+34.32175561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81849",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81849"},
        {"Smithsonian Astrophysical Observation", "SAO 65505"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.76776509),
        dec: Angle.Degrees(+34.32294293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36974",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6194 AB"},
        {"Henry Draper", "HD 60456"},
        {"Hipparcos Number", "HIP 36974"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.99915828),
        dec: Angle.Degrees(+34.32811638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194951"},
        {"Hipparcos Number", "HIP 100866"},
        {"Geneva Identification System", "GEN# +1.00194951"},
        {"Smithsonian Astrophysical Observation", "SAO 70044"},
        {"Wilson Evans Batten Catalogue", "WEB 18225"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.78238806),
        dec: Angle.Degrees(+34.32907395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195690"},
        {"Hipparcos Number", "HIP 101268"},
        {"Geneva Identification System", "GEN# +1.00195690"},
        {"Smithsonian Astrophysical Observation", "SAO 70153"},
        {"Wilson Evans Batten Catalogue", "WEB 18297"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.90112040),
        dec: Angle.Degrees(+34.33050116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137704"},
        {"Hipparcos Number", "HIP 75572"},
        {"Fundamental Katalog 5th Edition", "FK5 3218"},
        {"Geneva Identification System", "GEN# +1.00137704"},
        {"Smithsonian Astrophysical Observation", "SAO 64701"},
        {"Wilson Evans Batten Catalogue", "WEB 12878"},
    },
    visualMagnitude: 5.46,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.57277020),
        dec: Angle.Degrees(+34.33584960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44525"},
        {"Smithsonian Astrophysical Observation", "SAO 61235"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.08433470),
        dec: Angle.Degrees(+34.33782203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153807"},
        {"Hipparcos Number", "HIP 83197"},
        {"Geneva Identification System", "GEN# +1.00153807"},
        {"Smithsonian Astrophysical Observation", "SAO 65715"},
        {"Wilson Evans Batten Catalogue", "WEB 14063"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.04184175),
        dec: Angle.Degrees(+34.33836871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10206"},
        {"Hipparcos Number", "HIP 7808"},
        {"Geneva Identification System", "GEN# +1.00010206"},
        {"Smithsonian Astrophysical Observation", "SAO 54892"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.10825951),
        dec: Angle.Degrees(+34.33902831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12050"},
        {"Hipparcos Number", "HIP 9257"},
        {"Geneva Identification System", "GEN# +1.00012050"},
        {"Smithsonian Astrophysical Observation", "SAO 55166"},
        {"Wilson Evans Batten Catalogue", "WEB 1944"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.75044900),
        dec: Angle.Degrees(+34.33967040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216929"},
        {"Hipparcos Number", "HIP 113298"},
        {"Smithsonian Astrophysical Observation", "SAO 72865"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.16903190),
        dec: Angle.Degrees(+34.34304034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81057"},
        {"Hipparcos Number", "HIP 46122"},
        {"Smithsonian Astrophysical Observation", "SAO 61457"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.08771737),
        dec: Angle.Degrees(+34.34315023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110743"},
        {"Hipparcos Number", "HIP 62124"},
        {"Cincinnati Publication", "Ci 18 1615"},
        {"Geneva Identification System", "GEN# +1.00110743"},
        {"Smithsonian Astrophysical Observation", "SAO 63163"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.97756876),
        dec: Angle.Degrees(+34.34395123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -355.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105215"},
        {"Smithsonian Astrophysical Observation", "SAO 71189"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.68308120),
        dec: Angle.Degrees(+34.34684522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22306"},
        {"Hipparcos Number", "HIP 16843"},
        {"Smithsonian Astrophysical Observation", "SAO 56580"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.19544890),
        dec: Angle.Degrees(+34.34767205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7804",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7804"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.09845940),
        dec: Angle.Degrees(+34.34831923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95918"},
        {"Hipparcos Number", "HIP 54119"},
        {"Smithsonian Astrophysical Observation", "SAO 62386"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.10236064),
        dec: Angle.Degrees(+34.35333897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87622"},
        {"Hipparcos Number", "HIP 49529"},
        {"Smithsonian Astrophysical Observation", "SAO 61866"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.69343531),
        dec: Angle.Degrees(+34.35406164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221742"},
        {"Hipparcos Number", "HIP 116348"},
        {"Smithsonian Astrophysical Observation", "SAO 73342"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.64307697),
        dec: Angle.Degrees(+34.35609965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199235"},
        {"Hipparcos Number", "HIP 103233"},
        {"Smithsonian Astrophysical Observation", "SAO 70662"},
    },
    visualMagnitude: 8.50,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.71079220),
        dec: Angle.Degrees(+34.35623299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28048",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28048"},
        {"Smithsonian Astrophysical Observation", "SAO 58577"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.97288879),
        dec: Angle.Degrees(+34.35723209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279262"},
        {"Hipparcos Number", "HIP 18708"},
        {"Geneva Identification System", "GEN# +1.00279262"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.11292437),
        dec: Angle.Degrees(+34.35816464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24131"},
        {"Hipparcos Number", "HIP 18081"},
        {"Geneva Identification System", "GEN# +1.00024131"},
        {"Smithsonian Astrophysical Observation", "SAO 56761"},
        {"Wilson Evans Batten Catalogue", "WEB 3485"},
    },
    visualMagnitude: 5.78,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.97381828),
        dec: Angle.Degrees(+34.35912920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77933",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9838 A"},
        {"Henry Draper", "HD 142742"},
        {"Hipparcos Number", "HIP 77933"},
        {"Geneva Identification System", "GEN# +1.00142742"},
        {"Smithsonian Astrophysical Observation", "SAO 64970"},
        {"Wilson Evans Batten Catalogue", "WEB 13178"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.73686518),
        dec: Angle.Degrees(+34.36251134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120529"},
        {"Hipparcos Number", "HIP 67443"},
        {"Geneva Identification System", "GEN# +1.00120529"},
        {"Smithsonian Astrophysical Observation", "SAO 63766"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.33307638),
        dec: Angle.Degrees(+34.36574082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16377"},
        {"Hipparcos Number", "HIP 12314"},
        {"Geneva Identification System", "GEN# +1.00016377"},
        {"Smithsonian Astrophysical Observation", "SAO 55741"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.64582913),
        dec: Angle.Degrees(+34.36592911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16014"},
        {"Hipparcos Number", "HIP 12052"},
        {"Smithsonian Astrophysical Observation", "SAO 55681"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.84181147),
        dec: Angle.Degrees(+34.36630563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 725"},
        {"Smithsonian Astrophysical Observation", "SAO 53683"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.24799593),
        dec: Angle.Degrees(+34.36795586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9605",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1626 AB"},
        {"Hipparcos Number", "HIP 9605"},
        {"Smithsonian Astrophysical Observation", "SAO 55228"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.88351643),
        dec: Angle.Degrees(+34.36857427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64602"},
        {"Hipparcos Number", "HIP 38754"},
        {"Geneva Identification System", "GEN# +1.00064602"},
        {"Smithsonian Astrophysical Observation", "SAO 60462"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.00813337),
        dec: Angle.Degrees(+34.36959698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83190"},
        {"Smithsonian Astrophysical Observation", "SAO 65714"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.03291996),
        dec: Angle.Degrees(+34.37018891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70560"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.50064188),
        dec: Angle.Degrees(+34.37128385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -286.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102571",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14290 A"},
        {"Henry Draper", "HD 198134"},
        {"Hipparcos Number", "HIP 102571"},
        {"Geneva Identification System", "GEN# +1.00198134A"},
        {"Smithsonian Astrophysical Observation", "SAO 70499"},
        {"Wilson Evans Batten Catalogue", "WEB 18584"},
    },
    visualMagnitude: 4.93,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.79468503),
        dec: Angle.Degrees(+34.37410329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104309",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104309"},
        {"Smithsonian Astrophysical Observation", "SAO 70952"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.96606789),
        dec: Angle.Degrees(+34.37436688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41009"},
        {"Hipparcos Number", "HIP 28725"},
        {"Smithsonian Astrophysical Observation", "SAO 58701"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.01417247),
        dec: Angle.Degrees(+34.37438057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122285"},
        {"Hipparcos Number", "HIP 68408"},
        {"Geneva Identification System", "GEN# +1.00122285"},
        {"Smithsonian Astrophysical Observation", "SAO 63876"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.05707180),
        dec: Angle.Degrees(+34.37443736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130083"},
        {"Hipparcos Number", "HIP 72123"},
        {"Smithsonian Astrophysical Observation", "SAO 64307"},
        {"Wilson Evans Batten Catalogue", "WEB 12411"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.29999148),
        dec: Angle.Degrees(+34.37608813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194281"},
        {"Hipparcos Number", "HIP 100567"},
        {"Smithsonian Astrophysical Observation", "SAO 69943"},
    },
    visualMagnitude: 8.32,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.88947295),
        dec: Angle.Degrees(+34.37753889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8774"},
        {"Hipparcos Number", "HIP 6776"},
        {"Geneva Identification System", "GEN# +1.00008774"},
        {"Smithsonian Astrophysical Observation", "SAO 54705"},
        {"Wilson Evans Batten Catalogue", "WEB 1477"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.77589490),
        dec: Angle.Degrees(+34.37757818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209405"},
        {"Hipparcos Number", "HIP 108796"},
        {"Smithsonian Astrophysical Observation", "SAO 71967"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.60893810),
        dec: Angle.Degrees(+34.37873091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207977"},
        {"Hipparcos Number", "HIP 107964"},
        {"Smithsonian Astrophysical Observation", "SAO 71786"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.08962011),
        dec: Angle.Degrees(+34.38047486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123301"},
        {"Hipparcos Number", "HIP 68851"},
        {"Geneva Identification System", "GEN# +1.00123301"},
        {"Smithsonian Astrophysical Observation", "SAO 63929"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.48365786),
        dec: Angle.Degrees(+34.38283494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154346"},
        {"Hipparcos Number", "HIP 83459"},
        {"Smithsonian Astrophysical Observation", "SAO 65760"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.85898879),
        dec: Angle.Degrees(+34.38347058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216276"},
        {"Hipparcos Number", "HIP 112837"},
        {"Geneva Identification System", "GEN# +1.00216276"},
        {"Smithsonian Astrophysical Observation", "SAO 72779"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.77353790),
        dec: Angle.Degrees(+34.38368018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72237"},
        {"Hipparcos Number", "HIP 41931"},
        {"Cincinnati Publication", "Ci 18 997"},
        {"Smithsonian Astrophysical Observation", "SAO 60891"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.22608175),
        dec: Angle.Degrees(+34.38447178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 226083"},
        {"Hipparcos Number", "HIP 97622"},
        {"Smithsonian Astrophysical Observation", "SAO 68941"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.61873189),
        dec: Angle.Degrees(+34.38535480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101012"},
        {"Smithsonian Astrophysical Observation", "SAO 70083"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.18201506),
        dec: Angle.Degrees(+34.38809104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58832",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58832"},
        {"Smithsonian Astrophysical Observation", "SAO 62820"},
    },
    visualMagnitude: 11.85,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.00749136),
        dec: Angle.Degrees(+34.38951312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13375",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13375"},
        {"Cincinnati Publication", "Ci 20 187"},
        {"Geneva Identification System", "GEN# +0.03300529"},
        {"Wilson Evans Batten Catalogue", "WEB 2679"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.02680569),
        dec: Angle.Degrees(+34.39175902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 994.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -988.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35520"},
        {"Hipparcos Number", "HIP 25471"},
        {"Geneva Identification System", "GEN# +1.00035520"},
        {"Renson", "Renson 9140"},
        {"Smithsonian Astrophysical Observation", "SAO 58028"},
        {"Wilson Evans Batten Catalogue", "WEB 4932"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.70334709),
        dec: Angle.Degrees(+34.39182774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225360"},
        {"Hipparcos Number", "HIP 96833"},
        {"Smithsonian Astrophysical Observation", "SAO 68689"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.22811844),
        dec: Angle.Degrees(+34.39223330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31608"},
        {"Hipparcos Number", "HIP 23132"},
        {"Geneva Identification System", "GEN# +1.00031608"},
        {"Smithsonian Astrophysical Observation", "SAO 57541"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.66367383),
        dec: Angle.Degrees(+34.39230929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80493"},
        {"Hipparcos Number", "HIP 45860"},
        {"Fundamental Katalog 5th Edition", "FK5 352"},
        {"Geneva Identification System", "GEN# +1.00080493"},
        {"Smithsonian Astrophysical Observation", "SAO 61414"},
        {"Wilson Evans Batten Catalogue", "WEB 8697"},
    },
    visualMagnitude: 3.14,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.26441169),
        dec: Angle.Degrees(+34.39252592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -222.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178538"},
        {"Hipparcos Number", "HIP 93929"},
        {"Geneva Identification System", "GEN# +1.00178538"},
        {"Smithsonian Astrophysical Observation", "SAO 67841"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.89088851),
        dec: Angle.Degrees(+34.39309209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174830"},
        {"Hipparcos Number", "HIP 92496"},
        {"Smithsonian Astrophysical Observation", "SAO 67468"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.75509092),
        dec: Angle.Degrees(+34.39389883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79362",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9961 AB"},
        {"Henry Draper", "HD 145850"},
        {"Hipparcos Number", "HIP 79362"},
        {"Smithsonian Astrophysical Observation", "SAO 65131"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.96047275),
        dec: Angle.Degrees(+34.39664771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279633"},
        {"Hipparcos Number", "HIP 19573"},
        {"Smithsonian Astrophysical Observation", "SAO 57055"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.91103273),
        dec: Angle.Degrees(+34.39860982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50300",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50300"},
        {"Fundamental Katalog 5th Edition", "FK5 4912"},
        {"Geneva Identification System", "GEN# +0.03502123"},
        {"Smithsonian Astrophysical Observation", "SAO 61962"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.05260387),
        dec: Angle.Degrees(+34.40087354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77602"},
        {"Hipparcos Number", "HIP 44559"},
        {"Smithsonian Astrophysical Observation", "SAO 61238"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.18733869),
        dec: Angle.Degrees(+34.40105920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64048",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64048"},
        {"Geneva Identification System", "GEN# +0.03502406"},
        {"Smithsonian Astrophysical Observation", "SAO 63355"},
        {"Wilson Evans Batten Catalogue", "WEB 11321"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.89648916),
        dec: Angle.Degrees(+34.40167641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 267516"},
        {"Hipparcos Number", "HIP 33739"},
        {"Smithsonian Astrophysical Observation", "SAO 59680"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.14210828),
        dec: Angle.Degrees(+34.40315167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180101"},
        {"Hipparcos Number", "HIP 94479"},
        {"Smithsonian Astrophysical Observation", "SAO 68006"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.43425363),
        dec: Angle.Degrees(+34.40550822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279184"},
        {"Hipparcos Number", "HIP 18404"},
    },
    visualMagnitude: 11.85,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)56, 09.1400),
        dec: Angle.DegreesMinutesSeconds((int)+34, (int)24, 21.400)
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
    primaryId: "HIP 46757",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46757"},
        {"Smithsonian Astrophysical Observation", "SAO 61545"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.94817708),
        dec: Angle.Degrees(+34.40630563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201654"},
        {"Hipparcos Number", "HIP 104491"},
        {"Geneva Identification System", "GEN# +1.00201654"},
        {"Smithsonian Astrophysical Observation", "SAO 70998"},
    },
    visualMagnitude: 8.83,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.50467281),
        dec: Angle.Degrees(+34.40688513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50791"},
        {"Hipparcos Number", "HIP 33349"},
        {"Smithsonian Astrophysical Observation", "SAO 59621"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.04800995),
        dec: Angle.Degrees(+34.40799978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131762"},
        {"Hipparcos Number", "HIP 72951"},
        {"Geneva Identification System", "GEN# +1.00131762"},
        {"Smithsonian Astrophysical Observation", "SAO 64395"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.63935164),
        dec: Angle.Degrees(+34.41122335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42987",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42987"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.42320436),
        dec: Angle.Degrees(+34.41195222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178209"},
        {"Hipparcos Number", "HIP 93807"},
        {"Smithsonian Astrophysical Observation", "SAO 67815"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.56575998),
        dec: Angle.Degrees(+34.41394472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186702"},
        {"Hipparcos Number", "HIP 97142"},
        {"Geneva Identification System", "GEN# +1.00186702"},
        {"Smithsonian Astrophysical Observation", "SAO 68783"},
        {"Wilson Evans Batten Catalogue", "WEB 17052"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.15904371),
        dec: Angle.Degrees(+34.41415588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 263139"},
        {"Hipparcos Number", "HIP 32427"},
    },
    visualMagnitude: 11.35,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.53800953),
        dec: Angle.Degrees(+34.41469338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34611",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34611"},
        {"Smithsonian Astrophysical Observation", "SAO 59838"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.53199054),
        dec: Angle.Degrees(+34.41509468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171620"},
        {"Hipparcos Number", "HIP 91058"},
        {"Cincinnati Publication", "Ci 18 2438"},
        {"Geneva Identification System", "GEN# +1.00171620"},
        {"Smithsonian Astrophysical Observation", "SAO 67124"},
        {"Wilson Evans Batten Catalogue", "WEB 15629"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.62731322),
        dec: Angle.Degrees(+34.41517244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 196.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 191.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200209"},
        {"Hipparcos Number", "HIP 103725"},
        {"Smithsonian Astrophysical Observation", "SAO 70793"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.27568133),
        dec: Angle.Degrees(+34.41641187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172715"},
        {"Hipparcos Number", "HIP 91554"},
        {"Smithsonian Astrophysical Observation", "SAO 67232"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.06753705),
        dec: Angle.Degrees(+34.41711145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187123"},
        {"Hipparcos Number", "HIP 97336"},
        {"Geneva Identification System", "GEN# +1.00187123"},
        {"Smithsonian Astrophysical Observation", "SAO 68845"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.74171584),
        dec: Angle.Degrees(+34.41982386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202811"},
        {"Hipparcos Number", "HIP 105099"},
        {"Smithsonian Astrophysical Observation", "SAO 71159"},
        {"Wilson Evans Batten Catalogue", "WEB 19090"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.34482816),
        dec: Angle.Degrees(+34.42153113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186439"},
        {"Hipparcos Number", "HIP 97009"},
        {"Celescope Catalog", "CEL 4823"},
        {"Geneva Identification System", "GEN# +1.00186439"},
        {"Smithsonian Astrophysical Observation", "SAO 68741"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.75205918),
        dec: Angle.Degrees(+34.42195798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70445",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70445"},
        {"Smithsonian Astrophysical Observation", "SAO 64128"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.15974072),
        dec: Angle.Degrees(+34.42254886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109676",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109676"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.26253481),
        dec: Angle.Degrees(+34.42274074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189335"},
        {"Hipparcos Number", "HIP 98289"},
        {"Celescope Catalog", "CEL 4890"},
        {"Geneva Identification System", "GEN# +1.00189335"},
        {"Smithsonian Astrophysical Observation", "SAO 69174"},
    },
    visualMagnitude: 7.71,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.55694129),
        dec: Angle.Degrees(+34.42275647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68771",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9102 AB"},
        {"Henry Draper", "HD 123048"},
        {"Hipparcos Number", "HIP 68771"},
        {"Geneva Identification System", "GEN# +1.00123048J"},
        {"Smithsonian Astrophysical Observation", "SAO 63921"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.14017583),
        dec: Angle.Degrees(+34.42276500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191243"},
        {"Hipparcos Number", "HIP 99145"},
        {"Celescope Catalog", "CEL 4938"},
        {"Fundamental Katalog 5th Edition", "FK5 3615"},
        {"Geneva Identification System", "GEN# +1.00191243"},
        {"Smithsonian Astrophysical Observation", "SAO 69457"},
        {"Wilson Evans Batten Catalogue", "WEB 17644"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.92266944),
        dec: Angle.Degrees(+34.42292025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24538",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3834 A"},
        {"Henry Draper", "HD 34030"},
        {"Hipparcos Number", "HIP 24538"},
        {"Geneva Identification System", "GEN# +1.00034030"},
        {"Smithsonian Astrophysical Observation", "SAO 57808"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.97160668),
        dec: Angle.Degrees(+34.42344251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141953"},
        {"Hipparcos Number", "HIP 77605"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.64295875),
        dec: Angle.Degrees(+34.42488987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48081",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48081"},
        {"Smithsonian Astrophysical Observation", "SAO 61689"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.03333370),
        dec: Angle.Degrees(+34.42657733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24539",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 7.76,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)15, 53.6700),
        dec: Angle.DegreesMinutesSeconds((int)+34, (int)25, 37.400)
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
    primaryId: "HIP 16075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21269"},
        {"Hipparcos Number", "HIP 16075"},
        {"Geneva Identification System", "GEN# +1.00021269"},
        {"Smithsonian Astrophysical Observation", "SAO 56455"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.75961526),
        dec: Angle.Degrees(+34.42950064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17118"},
        {"Hipparcos Number", "HIP 12898"},
        {"Smithsonian Astrophysical Observation", "SAO 55849"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.44740143),
        dec: Angle.Degrees(+34.42964023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220941"},
        {"Hipparcos Number", "HIP 115807"},
        {"Geneva Identification System", "GEN# +1.00220941"},
        {"Smithsonian Astrophysical Observation", "SAO 73270"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.91854807),
        dec: Angle.Degrees(+34.43216461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68147",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9067 AB"},
        {"Henry Draper", "HD 121826"},
        {"Hipparcos Number", "HIP 68147"},
        {"Smithsonian Astrophysical Observation", "SAO 63852"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.27671296),
        dec: Angle.Degrees(+34.43471099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58829"},
        {"Hipparcos Number", "HIP 36335"},
        {"Geneva Identification System", "GEN# +1.00058829"},
        {"Smithsonian Astrophysical Observation", "SAO 60107"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.18381500),
        dec: Angle.Degrees(+34.43695005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124997"},
        {"Hipparcos Number", "HIP 69695"},
        {"Geneva Identification System", "GEN# +1.00124997"},
        {"Smithsonian Astrophysical Observation", "SAO 64033"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.99251737),
        dec: Angle.Degrees(+34.43759701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44138",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44138"},
        {"Smithsonian Astrophysical Observation", "SAO 61173"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.84291973),
        dec: Angle.Degrees(+34.43918171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30795"},
        {"Hipparcos Number", "HIP 22639"},
        {"Smithsonian Astrophysical Observation", "SAO 57467"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.05831954),
        dec: Angle.Degrees(+34.44340791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174346"},
        {"Hipparcos Number", "HIP 92295"},
        {"Geneva Identification System", "GEN# +1.00174346"},
        {"Smithsonian Astrophysical Observation", "SAO 67410"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.16158833),
        dec: Angle.Degrees(+34.44362105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143990"},
        {"Hipparcos Number", "HIP 78550"},
        {"Smithsonian Astrophysical Observation", "SAO 65032"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.55679652),
        dec: Angle.Degrees(+34.44420387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120933"},
        {"Hipparcos Number", "HIP 67665"},
        {"Fundamental Katalog 5th Edition", "FK5 3102"},
        {"Geneva Identification System", "GEN# +1.00120933"},
        {"Smithsonian Astrophysical Observation", "SAO 63793"},
        {"Wilson Evans Batten Catalogue", "WEB 11903"},
    },
    visualMagnitude: 4.76,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.94787312),
        dec: Angle.Degrees(+34.44431774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27791",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4463 AB"},
        {"Henry Draper", "HD 39251"},
        {"Hipparcos Number", "HIP 27791"},
        {"Smithsonian Astrophysical Observation", "SAO 58531"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.21972843),
        dec: Angle.Degrees(+34.44529845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68166"},
        {"Hipparcos Number", "HIP 40193"},
        {"Smithsonian Astrophysical Observation", "SAO 60642"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.15334896),
        dec: Angle.Degrees(+34.44573746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171568"},
        {"Hipparcos Number", "HIP 91027"},
        {"Smithsonian Astrophysical Observation", "SAO 67117"},
        {"Wilson Evans Batten Catalogue", "WEB 15621"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.53733560),
        dec: Angle.Degrees(+34.44818745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37177",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37177"},
        {"Geneva Identification System", "GEN# +6.20030116"},
        {"Wilson Evans Batten Catalogue", "WEB 7372"},
    },
    visualMagnitude: 11.26,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.58304518),
        dec: Angle.Degrees(+34.44936723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184171"},
        {"Hipparcos Number", "HIP 96052"},
        {"Celescope Catalog", "CEL 4782"},
        {"Fundamental Katalog 5th Edition", "FK5 1510"},
        {"Geneva Identification System", "GEN# +1.00184171"},
        {"Smithsonian Astrophysical Observation", "SAO 68447"},
        {"Wilson Evans Batten Catalogue", "WEB 16825"},
    },
    visualMagnitude: 4.74,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.94300436),
        dec: Angle.Degrees(+34.45297707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64558"},
        {"Hipparcos Number", "HIP 38745"},
        {"Geneva Identification System", "GEN# +1.00064558"},
        {"Smithsonian Astrophysical Observation", "SAO 60461"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.97963838),
        dec: Angle.Degrees(+34.45452127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18938"},
        {"Hipparcos Number", "HIP 14260"},
        {"Geneva Identification System", "GEN# +1.00018938"},
        {"Smithsonian Astrophysical Observation", "SAO 56121"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.96659999),
        dec: Angle.Degrees(+34.45487138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6062"},
        {"Hipparcos Number", "HIP 4840"},
        {"Smithsonian Astrophysical Observation", "SAO 54363"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.56929552),
        dec: Angle.Degrees(+34.45567908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171780"},
        {"Hipparcos Number", "HIP 91119"},
        {"Geneva Identification System", "GEN# +1.00171780"},
        {"Smithsonian Astrophysical Observation", "SAO 67134"},
        {"Wilson Evans Batten Catalogue", "WEB 15641"},
    },
    visualMagnitude: 6.10,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.80626144),
        dec: Angle.Degrees(+34.45800106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13703"},
        {"Hipparcos Number", "HIP 10432"},
        {"Geneva Identification System", "GEN# +1.00013703"},
        {"Smithsonian Astrophysical Observation", "SAO 55374"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.59921454),
        dec: Angle.Degrees(+34.46048472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 280410"},
        {"Hipparcos Number", "HIP 23584"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.06447418),
        dec: Angle.Degrees(+34.46090596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53801",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53801"},
        {"Smithsonian Astrophysical Observation", "SAO 62350"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.11787713),
        dec: Angle.Degrees(+34.46544104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138422"},
        {"Hipparcos Number", "HIP 75953"},
        {"Geneva Identification System", "GEN# +1.00138422"},
        {"Smithsonian Astrophysical Observation", "SAO 64745"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.69202971),
        dec: Angle.Degrees(+34.46568232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73793",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9496 AB"},
        {"Henry Draper", "HD 133726"},
        {"Hipparcos Number", "HIP 73793"},
        {"Smithsonian Astrophysical Observation", "SAO 64492"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.23459121),
        dec: Angle.Degrees(+34.46742552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15013"},
        {"Hipparcos Number", "HIP 11352"},
        {"Geneva Identification System", "GEN# +1.00015013"},
        {"Smithsonian Astrophysical Observation", "SAO 55552"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.53961438),
        dec: Angle.Degrees(+34.46957654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184107"},
        {"Hipparcos Number", "HIP 96030"},
        {"Smithsonian Astrophysical Observation", "SAO 68438"},
    },
    visualMagnitude: 8.08,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.87642137),
        dec: Angle.Degrees(+34.46972004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165568"},
        {"Hipparcos Number", "HIP 88571"},
        {"Smithsonian Astrophysical Observation", "SAO 66617"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.27283800),
        dec: Angle.Degrees(+34.46984509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3309",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3309"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.53675055),
        dec: Angle.Degrees(+34.46984610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40697",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40697"},
        {"Smithsonian Astrophysical Observation", "SAO 60714"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.61173057),
        dec: Angle.Degrees(+34.47108728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227196"},
        {"Hipparcos Number", "HIP 98639"},
        {"Geneva Identification System", "GEN# +1.00227196"},
        {"Smithsonian Astrophysical Observation", "SAO 69287"},
        {"Wilson Evans Batten Catalogue", "WEB 17451"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.51695727),
        dec: Angle.Degrees(+34.47294272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13653",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2217 B"},
        {"Hipparcos Number", "HIP 13653"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.94933373),
        dec: Angle.Degrees(+34.47308733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53329"},
        {"Hipparcos Number", "HIP 34267"},
        {"Geneva Identification System", "GEN# +1.00053329"},
        {"Smithsonian Astrophysical Observation", "SAO 59773"},
        {"Wilson Evans Batten Catalogue", "WEB 6865"},
    },
    visualMagnitude: 5.55,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.54845981),
        dec: Angle.Degrees(+34.47408682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24242"},
        {"Hipparcos Number", "HIP 18152"},
        {"Geneva Identification System", "GEN# +1.00024242"},
        {"Smithsonian Astrophysical Observation", "SAO 56776"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.20681516),
        dec: Angle.Degrees(+34.47527748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35620"},
        {"Hipparcos Number", "HIP 25541"},
        {"Geneva Identification System", "GEN# +1.00035620J"},
        {"Smithsonian Astrophysical Observation", "SAO 58051"},
        {"Wilson Evans Batten Catalogue", "WEB 4954"},
    },
    visualMagnitude: 5.08,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.91203061),
        dec: Angle.Degrees(+34.47598643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13652",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2217 A"},
        {"Hipparcos Number", "HIP 13652"},
        {"Smithsonian Astrophysical Observation", "SAO 56010"},
    },
    visualMagnitude: 8.78,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.94615287),
        dec: Angle.Degrees(+34.47785483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99532",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13508 AB"},
        {"Henry Draper", "HD 192124"},
        {"Hipparcos Number", "HIP 99532"},
        {"Geneva Identification System", "GEN# +1.00192124J"},
        {"Renson", "Renson 53560"},
        {"Smithsonian Astrophysical Observation", "SAO 69588"},
        {"Wilson Evans Batten Catalogue", "WEB 17805"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.00799535),
        dec: Angle.Degrees(+34.47893850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2801",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 492 AB"},
        {"Henry Draper", "HD 3212"},
        {"Hipparcos Number", "HIP 2801"},
        {"Geneva Identification System", "GEN# +1.00003212J"},
        {"Renson", "Renson 870"},
        {"Smithsonian Astrophysical Observation", "SAO 54008"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.91450055),
        dec: Angle.Degrees(+34.47959859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73144"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.22652728),
        dec: Angle.Degrees(+34.48011108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179985"},
        {"Hipparcos Number", "HIP 94447"},
        {"Geneva Identification System", "GEN# +1.00179985"},
        {"Smithsonian Astrophysical Observation", "SAO 67995"},
        {"Wilson Evans Batten Catalogue", "WEB 16459"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.32751801),
        dec: Angle.Degrees(+34.48068610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279111"},
        {"Hipparcos Number", "HIP 18077"},
        {"Geneva Identification System", "GEN# +1.00279111"},
        {"Smithsonian Astrophysical Observation", "SAO 56758"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.96313938),
        dec: Angle.Degrees(+34.48108571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147044"},
        {"Hipparcos Number", "HIP 79862"},
        {"Geneva Identification System", "GEN# +1.00147044"},
        {"Smithsonian Astrophysical Observation", "SAO 65213"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.52465280),
        dec: Angle.Degrees(+34.48292388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74270",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74270"},
    },
    visualMagnitude: 10.88,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.66409600),
        dec: Angle.Degrees(+34.48391684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114675"},
        {"Hipparcos Number", "HIP 64368"},
        {"Geneva Identification System", "GEN# +1.00114675"},
        {"Smithsonian Astrophysical Observation", "SAO 63392"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.89233898),
        dec: Angle.Degrees(+34.48709920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73248"},
        {"Hipparcos Number", "HIP 42386"},
        {"Smithsonian Astrophysical Observation", "SAO 60942"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.64704164),
        dec: Angle.Degrees(+34.48769054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10774",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1764 A"},
        {"Henry Draper", "HD 14202"},
        {"Hipparcos Number", "HIP 10774"},
        {"Smithsonian Astrophysical Observation", "SAO 55446"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.66525244),
        dec: Angle.Degrees(+34.48784759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199911"},
        {"Hipparcos Number", "HIP 103570"},
        {"Geneva Identification System", "GEN# +1.00199911"},
        {"Smithsonian Astrophysical Observation", "SAO 70754"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.77080867),
        dec: Angle.Degrees(+34.48850334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45351"},
        {"Hipparcos Number", "HIP 30818"},
        {"Smithsonian Astrophysical Observation", "SAO 59121"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.12062380),
        dec: Angle.Degrees(+34.49255506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7334"},
        {"Hipparcos Number", "HIP 5765"},
        {"Geneva Identification System", "GEN# +1.00007334"},
        {"Smithsonian Astrophysical Observation", "SAO 54534"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.50593508),
        dec: Angle.Degrees(+34.49270430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65898",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8927 AB"},
        {"Henry Draper", "HD 117554"},
        {"Hipparcos Number", "HIP 65898"},
        {"Smithsonian Astrophysical Observation", "SAO 63572"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.62510980),
        dec: Angle.Degrees(+34.49284443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169647"},
        {"Hipparcos Number", "HIP 90183"},
        {"Smithsonian Astrophysical Observation", "SAO 66938"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.04149767),
        dec: Angle.Degrees(+34.49452413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 350"},
        {"Hipparcos Number", "HIP 670"},
        {"Geneva Identification System", "GEN# +1.00000350"},
        {"Smithsonian Astrophysical Observation", "SAO 53672"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.07061029),
        dec: Angle.Degrees(+34.49526635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6204",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6204"},
        {"Smithsonian Astrophysical Observation", "SAO 54600"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.88284623),
        dec: Angle.Degrees(+34.49580510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66316",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66316"},
        {"Smithsonian Astrophysical Observation", "SAO 63631"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.87656428),
        dec: Angle.Degrees(+34.50137962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278535"},
        {"Hipparcos Number", "HIP 15693"},
        {"Smithsonian Astrophysical Observation", "SAO 56382"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.54021254),
        dec: Angle.Degrees(+34.50217716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28357",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28357"},
        {"Smithsonian Astrophysical Observation", "SAO 58633"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.88081377),
        dec: Angle.Degrees(+34.50237491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132584"},
        {"Hipparcos Number", "HIP 73304"},
        {"Geneva Identification System", "GEN# +1.00132584"},
        {"Smithsonian Astrophysical Observation", "SAO 64435"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.70996673),
        dec: Angle.Degrees(+34.50273873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210310"},
        {"Hipparcos Number", "HIP 109313"},
        {"Smithsonian Astrophysical Observation", "SAO 72057"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.19081149),
        dec: Angle.Degrees(+34.50440983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 280332"},
        {"Hipparcos Number", "HIP 23337"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.29512116),
        dec: Angle.Degrees(+34.50739400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198087"},
        {"Hipparcos Number", "HIP 102549"},
        {"Geneva Identification System", "GEN# +1.00198087"},
        {"Smithsonian Astrophysical Observation", "SAO 70486"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.71666889),
        dec: Angle.Degrees(+34.50777073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40458"},
        {"Hipparcos Number", "HIP 28448"},
        {"Smithsonian Astrophysical Observation", "SAO 58647"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.10210889),
        dec: Angle.Degrees(+34.50794569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100679"},
        {"Hipparcos Number", "HIP 56523"},
        {"Geneva Identification System", "GEN# +1.00100679"},
        {"Renson", "Renson 28950"},
        {"Smithsonian Astrophysical Observation", "SAO 62614"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.84010659),
        dec: Angle.Degrees(+34.50965434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84346"},
        {"Hipparcos Number", "HIP 47886"},
        {"Geneva Identification System", "GEN# +1.00084346"},
        {"Smithsonian Astrophysical Observation", "SAO 61669"},
        {"Wilson Evans Batten Catalogue", "WEB 8958"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.39283526),
        dec: Angle.Degrees(+34.51189879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108891"},
        {"Hipparcos Number", "HIP 61036"},
        {"Geneva Identification System", "GEN# +1.00108891"},
        {"Smithsonian Astrophysical Observation", "SAO 63033"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.64067206),
        dec: Angle.Degrees(+34.51254435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228545"},
        {"Hipparcos Number", "HIP 99820"},
        {"Wilson Evans Batten Catalogue", "WEB 17939"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.80116783),
        dec: Angle.Degrees(+34.51342511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10400",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1711 AB"},
        {"Henry Draper", "HD 13664"},
        {"Hipparcos Number", "HIP 10400"},
        {"Smithsonian Astrophysical Observation", "SAO 55367"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.49535209),
        dec: Angle.Degrees(+34.51422108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16682"},
        {"Hipparcos Number", "HIP 12557"},
        {"Smithsonian Astrophysical Observation", "SAO 55785"},
        {"Wilson Evans Batten Catalogue", "WEB 2564"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.37735127),
        dec: Angle.Degrees(+34.51609721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146387"},
        {"Hipparcos Number", "HIP 79615"},
        {"Geneva Identification System", "GEN# +1.00146387"},
        {"Smithsonian Astrophysical Observation", "SAO 65167"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.69286331),
        dec: Angle.Degrees(+34.51635810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92060",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11669 AB"},
        {"Henry Draper", "HD 173815"},
        {"Hipparcos Number", "HIP 92060"},
        {"Smithsonian Astrophysical Observation", "SAO 67350"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.45763116),
        dec: Angle.Degrees(+34.51847346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84242",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84242"},
        {"Smithsonian Astrophysical Observation", "SAO 65875"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.30341724),
        dec: Angle.Degrees(+34.52073062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109182",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15646 A"},
        {"Henry Draper", "HD 210073"},
        {"Hipparcos Number", "HIP 109182"},
        {"Geneva Identification System", "GEN# +1.00210073"},
        {"Smithsonian Astrophysical Observation", "SAO 72039"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.76360404),
        dec: Angle.Degrees(+34.52130426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211459"},
        {"Hipparcos Number", "HIP 109983"},
        {"Geneva Identification System", "GEN# +1.00211459"},
        {"Smithsonian Astrophysical Observation", "SAO 72197"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.14017417),
        dec: Angle.Degrees(+34.52154395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223210"},
        {"Hipparcos Number", "HIP 117345"},
        {"Smithsonian Astrophysical Observation", "SAO 73509"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.90013616),
        dec: Angle.Degrees(+34.52160493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173449"},
        {"Hipparcos Number", "HIP 91891"},
        {"Smithsonian Astrophysical Observation", "SAO 67295"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.98450929),
        dec: Angle.Degrees(+34.52170038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103542"},
        {"Hipparcos Number", "HIP 58149"},
        {"Fundamental Katalog 5th Edition", "FK5 5049"},
        {"Geneva Identification System", "GEN# +1.00103542"},
        {"Smithsonian Astrophysical Observation", "SAO 62757"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.88026443),
        dec: Angle.Degrees(+34.52340825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117476"},
        {"Hipparcos Number", "HIP 65853"},
        {"Geneva Identification System", "GEN# +1.00117476"},
        {"Smithsonian Astrophysical Observation", "SAO 63568"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.48390099),
        dec: Angle.Degrees(+34.52423823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 258728"},
        {"Hipparcos Number", "HIP 31142"},
        {"Geneva Identification System", "GEN# +1.00258728"},
        {"Wilson Evans Batten Catalogue", "WEB 6213"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.01001211),
        dec: Angle.Degrees(+34.52486627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -237.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -229.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114838"},
        {"Hipparcos Number", "HIP 64461"},
        {"Geneva Identification System", "GEN# +1.00114838"},
        {"Smithsonian Astrophysical Observation", "SAO 63404"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.19316215),
        dec: Angle.Degrees(+34.52823418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116921"},
        {"Smithsonian Astrophysical Observation", "SAO 73445"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.49056345),
        dec: Angle.Degrees(+34.52961018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35633"},
        {"Hipparcos Number", "HIP 25549"},
        {"Celescope Catalog", "CEL 708"},
        {"Geneva Identification System", "GEN# +1.00035633"},
        {"Smithsonian Astrophysical Observation", "SAO 58053"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.93035068),
        dec: Angle.Degrees(+34.53241545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78139",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78139"},
    },
    visualMagnitude: 11.19,
    bvColour: 1.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.32913586),
        dec: Angle.Degrees(+34.53515605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -242.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32733"},
        {"Hipparcos Number", "HIP 23797"},
        {"Geneva Identification System", "GEN# +1.00032733"},
        {"Smithsonian Astrophysical Observation", "SAO 57642"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.69703882),
        dec: Angle.Degrees(+34.53549855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56184",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56184"},
        {"Geneva Identification System", "GEN# +0.03502257"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.74987179),
        dec: Angle.Degrees(+34.53580277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211836"},
        {"Hipparcos Number", "HIP 110194"},
        {"Smithsonian Astrophysical Observation", "SAO 72231"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.82656710),
        dec: Angle.Degrees(+34.53793039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78158",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78158"},
    },
    visualMagnitude: 10.82,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.39189467),
        dec: Angle.Degrees(+34.53938453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -233.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154274"},
        {"Hipparcos Number", "HIP 83424"},
        {"Geneva Identification System", "GEN# +1.00154274"},
        {"Smithsonian Astrophysical Observation", "SAO 65755"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.77149305),
        dec: Angle.Degrees(+34.54026512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174433"},
        {"Hipparcos Number", "HIP 92325"},
        {"Cincinnati Publication", "Ci 18 2464"},
        {"Geneva Identification System", "GEN# +1.00174433"},
        {"Smithsonian Astrophysical Observation", "SAO 67420"},
        {"Wilson Evans Batten Catalogue", "WEB 15940"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.25407649),
        dec: Angle.Degrees(+34.54095590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 225.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159544"},
        {"Hipparcos Number", "HIP 85938"},
        {"Smithsonian Astrophysical Observation", "SAO 66140"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.44888870),
        dec: Angle.Degrees(+34.54170636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15755"},
        {"Hipparcos Number", "HIP 11840"},
        {"Geneva Identification System", "GEN# +1.00015755"},
        {"Smithsonian Astrophysical Observation", "SAO 55650"},
        {"Wilson Evans Batten Catalogue", "WEB 2453"},
    },
    visualMagnitude: 5.84,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.21940851),
        dec: Angle.Degrees(+34.54245642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24583"},
        {"Hipparcos Number", "HIP 18390"},
        {"Geneva Identification System", "GEN# +1.00024583"},
        {"Smithsonian Astrophysical Observation", "SAO 56817"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.97035896),
        dec: Angle.Degrees(+34.54505794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112800"},
        {"Hipparcos Number", "HIP 63360"},
        {"Geneva Identification System", "GEN# +1.00112800"},
        {"Smithsonian Astrophysical Observation", "SAO 63278"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.74594101),
        dec: Angle.Degrees(+34.54569358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205025"},
        {"Hipparcos Number", "HIP 106272"},
        {"Geneva Identification System", "GEN# +1.00205025"},
        {"Smithsonian Astrophysical Observation", "SAO 71425"},
        {"Wilson Evans Batten Catalogue", "WEB 19250"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.88421481),
        dec: Angle.Degrees(+34.54721243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80966"},
        {"Hipparcos Number", "HIP 46083"},
        {"Smithsonian Astrophysical Observation", "SAO 61446"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.96000173),
        dec: Angle.Degrees(+34.54833073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37475"},
        {"Hipparcos Number", "HIP 26699"},
        {"Smithsonian Astrophysical Observation", "SAO 58316"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.10880200),
        dec: Angle.Degrees(+34.54944474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116098",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116098"},
        {"Smithsonian Astrophysical Observation", "SAO 73314"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.86822424),
        dec: Angle.Degrees(+34.55065720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108932",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15594 A"},
        {"Hipparcos Number", "HIP 108932"},
        {"Smithsonian Astrophysical Observation", "SAO 71990"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.02666513),
        dec: Angle.Degrees(+34.55163973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37861",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6337 A"},
        {"Henry Draper", "HD 62488"},
        {"Hipparcos Number", "HIP 37861"},
        {"Smithsonian Astrophysical Observation", "SAO 60322"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.42245540),
        dec: Angle.Degrees(+34.55539448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173130"},
        {"Hipparcos Number", "HIP 91730"},
        {"Smithsonian Astrophysical Observation", "SAO 67271"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.58623661),
        dec: Angle.Degrees(+34.55730517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166709"},
        {"Hipparcos Number", "HIP 89037"},
        {"Smithsonian Astrophysical Observation", "SAO 66710"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.59843973),
        dec: Angle.Degrees(+34.55836412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171440"},
        {"Hipparcos Number", "HIP 90977"},
        {"Smithsonian Astrophysical Observation", "SAO 67105"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.37009002),
        dec: Angle.Degrees(+34.56333636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94540",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12215 A"},
        {"Henry Draper", "HD 180286"},
        {"Hipparcos Number", "HIP 94540"},
        {"Geneva Identification System", "GEN# +1.00180286"},
        {"Smithsonian Astrophysical Observation", "SAO 68022"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.62151846),
        dec: Angle.Degrees(+34.56416093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53527",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53527"},
        {"Smithsonian Astrophysical Observation", "SAO 62325"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.27847216),
        dec: Angle.Degrees(+34.56563355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133485"},
        {"Hipparcos Number", "HIP 73675"},
        {"Geneva Identification System", "GEN# +1.00133485"},
        {"Smithsonian Astrophysical Observation", "SAO 64484"},
        {"Wilson Evans Batten Catalogue", "WEB 12595"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.90207234),
        dec: Angle.Degrees(+34.56582447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197394"},
        {"Hipparcos Number", "HIP 102174"},
        {"Smithsonian Astrophysical Observation", "SAO 70401"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.54799822),
        dec: Angle.Degrees(+34.56653963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27348"},
        {"Hipparcos Number", "HIP 20252"},
        {"Fundamental Katalog 5th Edition", "FK5 158"},
        {"Geneva Identification System", "GEN# +1.00027348"},
        {"Smithsonian Astrophysical Observation", "SAO 57171"},
        {"Wilson Evans Batten Catalogue", "WEB 3866"},
    },
    visualMagnitude: 4.93,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.10273351),
        dec: Angle.Degrees(+34.56674228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112870"},
        {"Hipparcos Number", "HIP 63408"},
        {"Geneva Identification System", "GEN# +1.00112870"},
        {"Smithsonian Astrophysical Observation", "SAO 63283"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.89019950),
        dec: Angle.Degrees(+34.56932023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27458"},
        {"Hipparcos Number", "HIP 20340"},
        {"Smithsonian Astrophysical Observation", "SAO 57184"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.36157950),
        dec: Angle.Degrees(+34.57110993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83806"},
        {"Hipparcos Number", "HIP 47565"},
        {"Smithsonian Astrophysical Observation", "SAO 61635"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.47071356),
        dec: Angle.Degrees(+34.57483695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95379",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95379"},
        {"Smithsonian Astrophysical Observation", "SAO 68259"},
    },
    visualMagnitude: 9.28,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.04716488),
        dec: Angle.Degrees(+34.57510136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1362"},
        {"Hipparcos Number", "HIP 1441"},
        {"Smithsonian Astrophysical Observation", "SAO 53792"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.48722265),
        dec: Angle.Degrees(+34.57557149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109981"},
        {"Hipparcos Number", "HIP 61689"},
        {"Geneva Identification System", "GEN# +1.00109981"},
        {"Smithsonian Astrophysical Observation", "SAO 63115"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.68662842),
        dec: Angle.Degrees(+34.57605372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59991",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59991"},
        {"Geneva Identification System", "GEN# +0.03502330"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.55322711),
        dec: Angle.Degrees(+34.57990103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8673"},
        {"Hipparcos Number", "HIP 6702"},
        {"Geneva Identification System", "GEN# +1.00008673"},
        {"Smithsonian Astrophysical Observation", "SAO 54695"},
        {"Wilson Evans Batten Catalogue", "WEB 1462"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.53590855),
        dec: Angle.Degrees(+34.57990693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 235.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177303"},
        {"Hipparcos Number", "HIP 93510"},
        {"Smithsonian Astrophysical Observation", "SAO 67731"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.65975416),
        dec: Angle.Degrees(+34.58259179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189983"},
        {"Hipparcos Number", "HIP 98593"},
        {"Geneva Identification System", "GEN# +1.00189983"},
        {"Smithsonian Astrophysical Observation", "SAO 69276"},
        {"Wilson Evans Batten Catalogue", "WEB 17433"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.39109111),
        dec: Angle.Degrees(+34.58309509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188418"},
        {"Hipparcos Number", "HIP 97907"},
        {"Celescope Catalog", "CEL 4871"},
        {"Geneva Identification System", "GEN# +1.00188418"},
        {"Smithsonian Astrophysical Observation", "SAO 69040"},
    },
    visualMagnitude: 7.02,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.44708362),
        dec: Angle.Degrees(+34.58382535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114125"},
        {"Smithsonian Astrophysical Observation", "SAO 73000"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.69167016),
        dec: Angle.Degrees(+34.58419293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37265",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Jishui"},
        {"Henry Draper", "HD 61110"},
        {"Hipparcos Number", "HIP 37265"},
        {"Fundamental Katalog 5th Edition", "FK5 2592"},
        {"Geneva Identification System", "GEN# +1.00061110"},
        {"Renson", "Renson 16715"},
        {"Smithsonian Astrophysical Observation", "SAO 60247"},
        {"Wilson Evans Batten Catalogue", "WEB 7379"},
    },
    visualMagnitude: 4.89,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.79148501),
        dec: Angle.Degrees(+34.58463287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70017",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70017"},
        {"Smithsonian Astrophysical Observation", "SAO 64068"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.89889842),
        dec: Angle.Degrees(+34.58506311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3723",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3723"},
        {"Smithsonian Astrophysical Observation", "SAO 54149"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.94947435),
        dec: Angle.Degrees(+34.58507195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16559"},
        {"Hipparcos Number", "HIP 12450"},
        {"Geneva Identification System", "GEN# +1.00016559"},
        {"Smithsonian Astrophysical Observation", "SAO 55771"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.07349586),
        dec: Angle.Degrees(+34.58513822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124969"},
        {"Hipparcos Number", "HIP 69680"},
        {"Geneva Identification System", "GEN# +1.00124969"},
        {"Smithsonian Astrophysical Observation", "SAO 64031"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.95382641),
        dec: Angle.Degrees(+34.58597096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150749"},
        {"Hipparcos Number", "HIP 81732"},
        {"Geneva Identification System", "GEN# +1.00150749"},
        {"Smithsonian Astrophysical Observation", "SAO 65488"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.41450267),
        dec: Angle.Degrees(+34.58944950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89501"},
        {"Smithsonian Astrophysical Observation", "SAO 66805"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.96080447),
        dec: Angle.Degrees(+34.59328883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102560"},
        {"Geneva Identification System", "GEN# +0.03404152"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.75697989),
        dec: Angle.Degrees(+34.59459170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106574",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106574"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.76120561),
        dec: Angle.Degrees(+34.59599247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44192"},
        {"Hipparcos Number", "HIP 30270"},
        {"Geneva Identification System", "GEN# +1.00044192"},
        {"Smithsonian Astrophysical Observation", "SAO 59016"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.51273832),
        dec: Angle.Degrees(+34.59751121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43220",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7000 A"},
        {"Henry Draper", "HD 74960"},
        {"Hipparcos Number", "HIP 43220"},
        {"Smithsonian Astrophysical Observation", "SAO 61056"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.06848095),
        dec: Angle.Degrees(+34.59903738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94075",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12101 B"},
        {"Henry Draper", "HD 178911B"},
        {"Hipparcos Number", "HIP 94075"},
        {"Geneva Identification System", "GEN# +1.00178911B"},
        {"Smithsonian Astrophysical Observation", "SAO 67875"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.26274156),
        dec: Angle.Degrees(+34.59938067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 192.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94076",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12101 A"},
        {"Henry Draper", "HD 178911"},
        {"Hipparcos Number", "HIP 94076"},
        {"Geneva Identification System", "GEN# +1.00178911A"},
        {"Smithsonian Astrophysical Observation", "SAO 67879"},
        {"Wilson Evans Batten Catalogue", "WEB 16379"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.26812682),
        dec: Angle.Degrees(+34.59997848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 194.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2823",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2823"},
        {"Smithsonian Astrophysical Observation", "SAO 54013"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.96690655),
        dec: Angle.Degrees(+34.60025363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23678"},
        {"Hipparcos Number", "HIP 17769"},
        {"Smithsonian Astrophysical Observation", "SAO 56712"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.06411016),
        dec: Angle.Degrees(+34.60093162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205881"},
        {"Hipparcos Number", "HIP 106745"},
        {"Geneva Identification System", "GEN# +1.00205881"},
        {"Smithsonian Astrophysical Observation", "SAO 71532"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.34990586),
        dec: Angle.Degrees(+34.60292158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43219",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7000 B"},
        {"Hipparcos Number", "HIP 43219"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.06627140),
        dec: Angle.Degrees(+34.60402179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210889"},
        {"Hipparcos Number", "HIP 109654"},
        {"Fundamental Katalog 5th Edition", "FK5 3776"},
        {"Geneva Identification System", "GEN# +1.00210889"},
        {"Smithsonian Astrophysical Observation", "SAO 72132"},
        {"Wilson Evans Batten Catalogue", "WEB 19702"},
    },
    visualMagnitude: 5.34,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.19921276),
        dec: Angle.Degrees(+34.60471273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121368"},
        {"Hipparcos Number", "HIP 67889"},
        {"Geneva Identification System", "GEN# +1.00121368"},
        {"Smithsonian Astrophysical Observation", "SAO 63821"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.56875020),
        dec: Angle.Degrees(+34.60712918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97890"},
        {"Hipparcos Number", "HIP 55015"},
        {"Smithsonian Astrophysical Observation", "SAO 62469"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.96392009),
        dec: Angle.Degrees(+34.60742297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57509"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.82054276),
        dec: Angle.Degrees(+34.60808659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183536"},
        {"Hipparcos Number", "HIP 95769"},
        {"Cincinnati Publication", "Ci 18 2537"},
        {"Geneva Identification System", "GEN# +1.00183536"},
        {"Smithsonian Astrophysical Observation", "SAO 68369"},
        {"Wilson Evans Batten Catalogue", "WEB 16760"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.17402085),
        dec: Angle.Degrees(+34.61060611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 229.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45053"},
        {"Smithsonian Astrophysical Observation", "SAO 61301"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.64013158),
        dec: Angle.Degrees(+34.61133255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278809"},
        {"Hipparcos Number", "HIP 16709"},
        {"Geneva Identification System", "GEN# +6.20030102"},
        {"Wilson Evans Batten Catalogue", "WEB 3184"},
    },
    visualMagnitude: 10.87,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.74793118),
        dec: Angle.Degrees(+34.61139362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6876"},
        {"Hipparcos Number", "HIP 5453"},
        {"Geneva Identification System", "GEN# +1.00006876"},
        {"Smithsonian Astrophysical Observation", "SAO 54474"},
        {"Wilson Evans Batten Catalogue", "WEB 1195"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.44795597),
        dec: Angle.Degrees(+34.61158768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217649"},
        {"Hipparcos Number", "HIP 113719"},
        {"Geneva Identification System", "GEN# +1.00217649"},
        {"Smithsonian Astrophysical Observation", "SAO 72940"},
        {"Wilson Evans Batten Catalogue", "WEB 20207"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.46432080),
        dec: Angle.Degrees(+34.61261848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97732"},
        {"Hipparcos Number", "HIP 54936"},
        {"Smithsonian Astrophysical Observation", "SAO 62459"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.74442761),
        dec: Angle.Degrees(+34.61305953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141267"},
        {"Hipparcos Number", "HIP 77304"},
        {"Smithsonian Astrophysical Observation", "SAO 64900"},
        {"Wilson Evans Batten Catalogue", "WEB 13099"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.73894061),
        dec: Angle.Degrees(+34.61338658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64938"},
        {"Smithsonian Astrophysical Observation", "SAO 63463"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.66851976),
        dec: Angle.Degrees(+34.61498783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48280",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48280"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.65419816),
        dec: Angle.Degrees(+34.61570220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214181"},
        {"Hipparcos Number", "HIP 111559"},
        {"Smithsonian Astrophysical Observation", "SAO 72513"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.01501697),
        dec: Angle.Degrees(+34.61828606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85014"},
        {"Smithsonian Astrophysical Observation", "SAO 65991"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.63147647),
        dec: Angle.Degrees(+34.61912430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64324"},
        {"Hipparcos Number", "HIP 38647"},
        {"Fundamental Katalog 5th Edition", "FK5 4711"},
        {"Geneva Identification System", "GEN# +1.00064324"},
        {"Smithsonian Astrophysical Observation", "SAO 60434"},
        {"Wilson Evans Batten Catalogue", "WEB 7584"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.70241811),
        dec: Angle.Degrees(+34.62020884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58918",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58918"},
    },
    visualMagnitude: 10.66,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.22525550),
        dec: Angle.Degrees(+34.62059298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -295.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217753"},
        {"Hipparcos Number", "HIP 113775"},
        {"Smithsonian Astrophysical Observation", "SAO 72948"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.62238347),
        dec: Angle.Degrees(+34.62090469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217818"},
        {"Hipparcos Number", "HIP 113824"},
        {"Smithsonian Astrophysical Observation", "SAO 72959"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.75193656),
        dec: Angle.Degrees(+34.62107142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175332"},
        {"Hipparcos Number", "HIP 92712"},
        {"Smithsonian Astrophysical Observation", "SAO 67531"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.36868535),
        dec: Angle.Degrees(+34.62309188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108612"},
        {"Hipparcos Number", "HIP 60860"},
        {"Geneva Identification System", "GEN# +1.00108612"},
        {"Smithsonian Astrophysical Observation", "SAO 63013"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.10686355),
        dec: Angle.Degrees(+34.62478371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150463"},
        {"Hipparcos Number", "HIP 81596"},
        {"Smithsonian Astrophysical Observation", "SAO 65468"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.94930707),
        dec: Angle.Degrees(+34.62538162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279307"},
        {"Hipparcos Number", "HIP 18895"},
        {"Geneva Identification System", "GEN# +1.00279307"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.75953667),
        dec: Angle.Degrees(+34.62551691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78931",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78931"},
        {"Cincinnati Publication", "Ci 20 968"},
        {"Wilson Evans Batten Catalogue", "WEB 13340"},
    },
    visualMagnitude: 10.44,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.67450542),
        dec: Angle.Degrees(+34.62582967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -586.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147429"},
        {"Hipparcos Number", "HIP 80073"},
        {"Smithsonian Astrophysical Observation", "SAO 65240"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.14571559),
        dec: Angle.Degrees(+34.62786962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278403"},
        {"Hipparcos Number", "HIP 15146"},
        {"Geneva Identification System", "GEN# +1.00278403"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.81224236),
        dec: Angle.Degrees(+34.62951661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 213.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -218.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209126"},
        {"Hipparcos Number", "HIP 108621"},
        {"Smithsonian Astrophysical Observation", "SAO 71929"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.07121604),
        dec: Angle.Degrees(+34.62960052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79452"},
        {"Hipparcos Number", "HIP 45412"},
        {"Geneva Identification System", "GEN# +1.00079452"},
        {"Smithsonian Astrophysical Observation", "SAO 61361"},
        {"Wilson Evans Batten Catalogue", "WEB 8639"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.80982607),
        dec: Angle.Degrees(+34.63339985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36573"},
        {"Hipparcos Number", "HIP 26118"},
        {"Smithsonian Astrophysical Observation", "SAO 58188"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.55264286),
        dec: Angle.Degrees(+34.63344064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52921"},
        {"Smithsonian Astrophysical Observation", "SAO 62269"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.34889745),
        dec: Angle.Degrees(+34.63893906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8761"},
        {"Hipparcos Number", "HIP 6767"},
        {"Geneva Identification System", "GEN# +1.00008761"},
        {"Smithsonian Astrophysical Observation", "SAO 54703"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.76024355),
        dec: Angle.Degrees(+34.63906194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5018"},
        {"Hipparcos Number", "HIP 4095"},
        {"Geneva Identification System", "GEN# +1.00005018"},
        {"Smithsonian Astrophysical Observation", "SAO 54217"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.14449944),
        dec: Angle.Degrees(+34.63937322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58620"},
        {"Smithsonian Astrophysical Observation", "SAO 62800"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.31891471),
        dec: Angle.Degrees(+34.63983142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86747"},
        {"Hipparcos Number", "HIP 49097"},
        {"Smithsonian Astrophysical Observation", "SAO 61810"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.31529377),
        dec: Angle.Degrees(+34.64010573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43751"},
        {"Hipparcos Number", "HIP 30056"},
        {"Smithsonian Astrophysical Observation", "SAO 58984"},
    },
    visualMagnitude: 7.92,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.88840304),
        dec: Angle.Degrees(+34.64012155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119914"},
        {"Hipparcos Number", "HIP 67138"},
        {"Geneva Identification System", "GEN# +1.00119914"},
        {"Smithsonian Astrophysical Observation", "SAO 63722"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.39210492),
        dec: Angle.Degrees(+34.64741230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212714"},
        {"Hipparcos Number", "HIP 110710"},
        {"Renson", "Renson 59010"},
        {"Smithsonian Astrophysical Observation", "SAO 72328"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.45695343),
        dec: Angle.Degrees(+34.64752854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174222"},
        {"Hipparcos Number", "HIP 92251"},
        {"Smithsonian Astrophysical Observation", "SAO 67398"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.00797474),
        dec: Angle.Degrees(+34.64777438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2439",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2439"},
        {"Smithsonian Astrophysical Observation", "SAO 53950"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.76405345),
        dec: Angle.Degrees(+34.65065848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76897",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76897"},
    },
    visualMagnitude: 11.69,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.51867008),
        dec: Angle.Degrees(+34.65124343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -298.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100655"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.14070497),
        dec: Angle.Degrees(+34.65161462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115357",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115357"},
        {"Smithsonian Astrophysical Observation", "SAO 73206"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.48708994),
        dec: Angle.Degrees(+34.65342993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53992"},
        {"Hipparcos Number", "HIP 34471"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.17017903),
        dec: Angle.Degrees(+34.65393725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198846"},
        {"Hipparcos Number", "HIP 102999"},
        {"Celescope Catalog", "CEL 5189"},
        {"Geneva Identification System", "GEN# +1.00198846"},
        {"Smithsonian Astrophysical Observation", "SAO 70599"},
        {"Wilson Evans Batten Catalogue", "WEB 18699"},
    },
    visualMagnitude: 7.31,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.01489650),
        dec: Angle.Degrees(+34.65767326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9333",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9333"},
        {"Smithsonian Astrophysical Observation", "SAO 55172"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.95998788),
        dec: Angle.Degrees(+34.65804158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208896"},
        {"Hipparcos Number", "HIP 108481"},
        {"Geneva Identification System", "GEN# +1.00208896"},
        {"Smithsonian Astrophysical Observation", "SAO 71898"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.63164754),
        dec: Angle.Degrees(+34.65887770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225239"},
        {"Hipparcos Number", "HIP 394"},
        {"Cincinnati Publication", "Ci 20 2"},
        {"Fundamental Katalog 5th Edition", "FK5 2002"},
        {"Geneva Identification System", "GEN# +1.00225239"},
        {"Smithsonian Astrophysical Observation", "SAO 53622"},
        {"Wilson Evans Batten Catalogue", "WEB 57"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.22172791),
        dec: Angle.Degrees(+34.65955259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 769.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7337",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1227 AB"},
        {"Hipparcos Number", "HIP 7337"},
        {"Geneva Identification System", "GEN# +0.03300257J"},
        {"Smithsonian Astrophysical Observation", "SAO 54792"},
        {"Wilson Evans Batten Catalogue", "WEB 1577"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.62371944),
        dec: Angle.Degrees(+34.66096699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9950",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9950"},
        {"Smithsonian Astrophysical Observation", "SAO 55284"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.02300855),
        dec: Angle.Degrees(+34.66209232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66709"},
        {"Hipparcos Number", "HIP 39649"},
        {"Smithsonian Astrophysical Observation", "SAO 60558"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.53747390),
        dec: Angle.Degrees(+34.66241362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120819"},
        {"Hipparcos Number", "HIP 67605"},
        {"Geneva Identification System", "GEN# +1.00120819"},
        {"Smithsonian Astrophysical Observation", "SAO 63781"},
        {"Wilson Evans Batten Catalogue", "WEB 11888"},
    },
    visualMagnitude: 5.89,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.78836921),
        dec: Angle.Degrees(+34.66453000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213559"},
        {"Hipparcos Number", "HIP 111203"},
        {"Geneva Identification System", "GEN# +1.00213559"},
        {"Smithsonian Astrophysical Observation", "SAO 72435"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.93276757),
        dec: Angle.Degrees(+34.66486631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70799",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70799"},
        {"Smithsonian Astrophysical Observation", "SAO 64165"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.18980108),
        dec: Angle.Degrees(+34.66562197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29620"},
        {"Hipparcos Number", "HIP 21822"},
        {"Smithsonian Astrophysical Observation", "SAO 57374"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.33423825),
        dec: Angle.Degrees(+34.66570617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163308"},
        {"Hipparcos Number", "HIP 87627"},
        {"Smithsonian Astrophysical Observation", "SAO 66447"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.50043856),
        dec: Angle.Degrees(+34.66705963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139761"},
        {"Hipparcos Number", "HIP 76617"},
        {"Fundamental Katalog 5th Edition", "FK5 3238"},
        {"Geneva Identification System", "GEN# +1.00139761"},
        {"Smithsonian Astrophysical Observation", "SAO 64825"},
        {"Wilson Evans Batten Catalogue", "WEB 13007"},
    },
    visualMagnitude: 6.12,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.70356906),
        dec: Angle.Degrees(+34.67507876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206401"},
        {"Hipparcos Number", "HIP 107066"},
        {"Smithsonian Astrophysical Observation", "SAO 71595"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.26575867),
        dec: Angle.Degrees(+34.67515168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15672"},
        {"Hipparcos Number", "HIP 11786"},
        {"Geneva Identification System", "GEN# +1.00015672"},
        {"Smithsonian Astrophysical Observation", "SAO 55637"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.02813527),
        dec: Angle.Degrees(+34.67823616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7334",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1227 C"},
        {"Hipparcos Number", "HIP 7334"},
        {"Geneva Identification System", "GEN# +0.03300256"},
        {"Smithsonian Astrophysical Observation", "SAO 54791"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.61407694),
        dec: Angle.Degrees(+34.67877179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101493",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14016 AB"},
        {"Henry Draper", "HD 196120"},
        {"Hipparcos Number", "HIP 101493"},
        {"Celescope Catalog", "CEL 5116"},
        {"Geneva Identification System", "GEN# +1.00196120J"},
        {"Smithsonian Astrophysical Observation", "SAO 70206"},
        {"Wilson Evans Batten Catalogue", "WEB 18340"},
    },
    visualMagnitude: 6.67,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.50816598),
        dec: Angle.Degrees(+34.67901846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21729"},
        {"Hipparcos Number", "HIP 16427"},
        {"Smithsonian Astrophysical Observation", "SAO 56511"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.87810715),
        dec: Angle.Degrees(+34.67957038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65275"},
        {"Hipparcos Number", "HIP 39057"},
        {"Geneva Identification System", "GEN# +1.00065275"},
        {"Smithsonian Astrophysical Observation", "SAO 60500"},
        {"Wilson Evans Batten Catalogue", "WEB 7658"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.85446164),
        dec: Angle.Degrees(+34.67992878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114927",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114927"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.18365928),
        dec: Angle.Degrees(+34.68017439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55914",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55914"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.91002994),
        dec: Angle.Degrees(+34.68023932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52763"},
        {"Hipparcos Number", "HIP 34064"},
        {"Smithsonian Astrophysical Observation", "SAO 59736"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.98890293),
        dec: Angle.Degrees(+34.68226781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116617"},
        {"Hipparcos Number", "HIP 65396"},
        {"Geneva Identification System", "GEN# +1.00116617"},
        {"Smithsonian Astrophysical Observation", "SAO 63515"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.04881074),
        dec: Angle.Degrees(+34.68382060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41026"},
        {"Hipparcos Number", "HIP 28729"},
        {"Smithsonian Astrophysical Observation", "SAO 58702"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.02552825),
        dec: Angle.Degrees(+34.68426125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128368"},
        {"Hipparcos Number", "HIP 71354"},
        {"Geneva Identification System", "GEN# +1.00128368"},
        {"Smithsonian Astrophysical Observation", "SAO 64231"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.88359298),
        dec: Angle.Degrees(+34.68655314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107486"},
        {"Hipparcos Number", "HIP 60244"},
        {"Geneva Identification System", "GEN# +1.00107486"},
        {"Smithsonian Astrophysical Observation", "SAO 62964"},
        {"Wilson Evans Batten Catalogue", "WEB 10714"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.29644027),
        dec: Angle.Degrees(+34.68675787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16058"},
        {"Hipparcos Number", "HIP 12086"},
        {"Geneva Identification System", "GEN# +1.00016058"},
        {"Smithsonian Astrophysical Observation", "SAO 55687"},
        {"Wilson Evans Batten Catalogue", "WEB 2487"},
    },
    visualMagnitude: 5.38,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.94498948),
        dec: Angle.Degrees(+34.68768289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219497"},
        {"Hipparcos Number", "HIP 114856"},
        {"Geneva Identification System", "GEN# +1.00219497"},
        {"Smithsonian Astrophysical Observation", "SAO 73120"},
        {"Wilson Evans Batten Catalogue", "WEB 20358"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.97426073),
        dec: Angle.Degrees(+34.68793312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144168"},
        {"Hipparcos Number", "HIP 78642"},
        {"Smithsonian Astrophysical Observation", "SAO 65044"},
    },
    visualMagnitude: 8.39,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.80732368),
        dec: Angle.Degrees(+34.68799927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184940"},
        {"Hipparcos Number", "HIP 96348"},
        {"Celescope Catalog", "CEL 4792"},
        {"Geneva Identification System", "GEN# +1.00184940"},
        {"Smithsonian Astrophysical Observation", "SAO 68541"},
        {"Wilson Evans Batten Catalogue", "WEB 16894"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.84101878),
        dec: Angle.Degrees(+34.68800420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92481"},
        {"Hipparcos Number", "HIP 52299"},
        {"Smithsonian Astrophysical Observation", "SAO 62196"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.29277100),
        dec: Angle.Degrees(+34.68831212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15204",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2433 A"},
        {"Henry Draper", "HD 20210"},
        {"Hipparcos Number", "HIP 15204"},
        {"Geneva Identification System", "GEN# +1.00020210"},
        {"Renson", "Renson 5010"},
        {"Smithsonian Astrophysical Observation", "SAO 56296"},
        {"Wilson Evans Batten Catalogue", "WEB 2928"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.00763108),
        dec: Angle.Degrees(+34.68860876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87422"},
        {"Hipparcos Number", "HIP 49438"},
        {"Smithsonian Astrophysical Observation", "SAO 61852"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.40247886),
        dec: Angle.Degrees(+34.69009152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4214",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4214"},
        {"Smithsonian Astrophysical Observation", "SAO 54242"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.45167120),
        dec: Angle.Degrees(+34.69052509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91326",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91326"},
        {"Cincinnati Publication", "Ci 20 1097"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.41164579),
        dec: Angle.Degrees(+34.69079611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -360.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158261"},
        {"Hipparcos Number", "HIP 85382"},
        {"Fundamental Katalog 5th Edition", "FK5 3389"},
        {"Geneva Identification System", "GEN# +1.00158261"},
        {"Renson", "Renson 44530"},
        {"Smithsonian Astrophysical Observation", "SAO 66054"},
        {"Wilson Evans Batten Catalogue", "WEB 14421"},
    },
    visualMagnitude: 5.94,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.69235534),
        dec: Angle.Degrees(+34.69569698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82601"},
        {"Smithsonian Astrophysical Observation", "SAO 65631"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.29082889),
        dec: Angle.Degrees(+34.69631334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61420"},
        {"Hipparcos Number", "HIP 37397"},
        {"Smithsonian Astrophysical Observation", "SAO 60263"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.17112284),
        dec: Angle.Degrees(+34.69639334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35742"},
        {"Hipparcos Number", "HIP 25624"},
        {"Smithsonian Astrophysical Observation", "SAO 58076"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.10999104),
        dec: Angle.Degrees(+34.69748067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108713"},
        {"Hipparcos Number", "HIP 60927"},
        {"Geneva Identification System", "GEN# +1.00108713"},
        {"Smithsonian Astrophysical Observation", "SAO 63022"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.31302517),
        dec: Angle.Degrees(+34.70339209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46386"},
        {"Smithsonian Astrophysical Observation", "SAO 61499"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.88095373),
        dec: Angle.Degrees(+34.70387241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96031",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96031"},
    },
    visualMagnitude: 10.39,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.88091508),
        dec: Angle.Degrees(+34.70498375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30925"},
        {"Hipparcos Number", "HIP 22718"},
        {"Geneva Identification System", "GEN# +1.00030925"},
        {"Smithsonian Astrophysical Observation", "SAO 57482"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.27929683),
        dec: Angle.Degrees(+34.70574038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156361"},
        {"Hipparcos Number", "HIP 84427"},
        {"Smithsonian Astrophysical Observation", "SAO 65900"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.90861192),
        dec: Angle.Degrees(+34.70768659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1822"},
        {"Hipparcos Number", "HIP 1798"},
        {"Geneva Identification System", "GEN# +1.00001822"},
        {"Smithsonian Astrophysical Observation", "SAO 53847"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.70719494),
        dec: Angle.Degrees(+34.70960291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67766"},
        {"Hipparcos Number", "HIP 40048"},
        {"Geneva Identification System", "GEN# +1.00067766"},
        {"Smithsonian Astrophysical Observation", "SAO 60622"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.71172887),
        dec: Angle.Degrees(+34.71001616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7914",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7914"},
        {"Smithsonian Astrophysical Observation", "SAO 54908"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.42649685),
        dec: Angle.Degrees(+34.71080163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146489"},
        {"Hipparcos Number", "HIP 79651"},
        {"Smithsonian Astrophysical Observation", "SAO 65174"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.81242803),
        dec: Angle.Degrees(+34.71323923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20709",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3211 AB"},
        {"Henry Draper", "HD 27961"},
        {"Hipparcos Number", "HIP 20709"},
        {"Smithsonian Astrophysical Observation", "SAO 57230"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.56244527),
        dec: Angle.Degrees(+34.71606508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191588"},
        {"Hipparcos Number", "HIP 99301"},
        {"Smithsonian Astrophysical Observation", "SAO 69515"},
        {"Wilson Evans Batten Catalogue", "WEB 17708"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.35170707),
        dec: Angle.Degrees(+34.71652668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96678"},
        {"Hipparcos Number", "HIP 54460"},
        {"Smithsonian Astrophysical Observation", "SAO 62420"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.14087420),
        dec: Angle.Degrees(+34.71720039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153451"},
        {"Hipparcos Number", "HIP 83052"},
        {"Geneva Identification System", "GEN# +1.00153451"},
        {"Smithsonian Astrophysical Observation", "SAO 65686"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.56374531),
        dec: Angle.Degrees(+34.71801440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84181"},
        {"Hipparcos Number", "HIP 47761"},
        {"Smithsonian Astrophysical Observation", "SAO 61661"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.06475957),
        dec: Angle.Degrees(+34.72079532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126878"},
        {"Hipparcos Number", "HIP 70664"},
        {"Geneva Identification System", "GEN# +1.00126878"},
        {"Smithsonian Astrophysical Observation", "SAO 64148"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.80641966),
        dec: Angle.Degrees(+34.72218624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110642",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110642"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.19846318),
        dec: Angle.Degrees(+34.72377718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16070"},
        {"Hipparcos Number", "HIP 12091"},
        {"Geneva Identification System", "GEN# +1.00016070"},
        {"Smithsonian Astrophysical Observation", "SAO 55688"},
        {"Wilson Evans Batten Catalogue", "WEB 2488"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.95883975),
        dec: Angle.Degrees(+34.72537607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36499"},
        {"Hipparcos Number", "HIP 26071"},
        {"Geneva Identification System", "GEN# +1.00036499"},
        {"Renson", "Renson 9450"},
        {"Smithsonian Astrophysical Observation", "SAO 58182"},
        {"Wilson Evans Batten Catalogue", "WEB 5072"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.40927180),
        dec: Angle.Degrees(+34.72560421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222923"},
        {"Hipparcos Number", "HIP 117138"},
        {"Geneva Identification System", "GEN# +1.00222923"},
        {"Smithsonian Astrophysical Observation", "SAO 73474"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.20455005),
        dec: Angle.Degrees(+34.72572497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7510"},
        {"Hipparcos Number", "HIP 5891"},
        {"Geneva Identification System", "GEN# +1.00007510"},
        {"Smithsonian Astrophysical Observation", "SAO 54559"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.92175727),
        dec: Angle.Degrees(+34.72592248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74162"},
        {"Smithsonian Astrophysical Observation", "SAO 64524"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.30150010),
        dec: Angle.Degrees(+34.73113477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222305"},
        {"Hipparcos Number", "HIP 116720"},
        {"Geneva Identification System", "GEN# +1.00222305"},
        {"Smithsonian Astrophysical Observation", "SAO 73410"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.81415105),
        dec: Angle.Degrees(+34.73114921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93287"},
        {"Hipparcos Number", "HIP 52723"},
        {"Smithsonian Astrophysical Observation", "SAO 62247"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.68444474),
        dec: Angle.Degrees(+34.73122424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21401"},
        {"Hipparcos Number", "HIP 16175"},
        {"Smithsonian Astrophysical Observation", "SAO 56477"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.09420759),
        dec: Angle.Degrees(+34.73161979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85238",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10542 AB"},
        {"Hipparcos Number", "HIP 85238"},
        {"Smithsonian Astrophysical Observation", "SAO 66027"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.26369237),
        dec: Angle.Degrees(+34.73204969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56803"},
        {"Smithsonian Astrophysical Observation", "SAO 62638"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.67449491),
        dec: Angle.Degrees(+34.73399480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73313"},
        {"Hipparcos Number", "HIP 42417"},
        {"Smithsonian Astrophysical Observation", "SAO 60949"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.75055565),
        dec: Angle.Degrees(+34.73440434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58640",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58640"},
        {"Smithsonian Astrophysical Observation", "SAO 62801"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.36757749),
        dec: Angle.Degrees(+34.73557179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75872"},
        {"Smithsonian Astrophysical Observation", "SAO 64729"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.46241277),
        dec: Angle.Degrees(+34.73635742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84679"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.67044879),
        dec: Angle.Degrees(+34.74004012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -234.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204093"},
        {"Hipparcos Number", "HIP 105773"},
        {"Geneva Identification System", "GEN# +1.00204093"},
        {"Smithsonian Astrophysical Observation", "SAO 71315"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.33629908),
        dec: Angle.Degrees(+34.74393704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 280965"},
        {"Hipparcos Number", "HIP 25030"},
        {"Smithsonian Astrophysical Observation", "SAO 57934"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.39823773),
        dec: Angle.Degrees(+34.74406451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103112",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103112"},
        {"Smithsonian Astrophysical Observation", "SAO 70637"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.38285517),
        dec: Angle.Degrees(+34.74612827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91707",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11593 AP"},
        {"Aitken 2", "ADS 11593 AB"},
        {"Henry Draper", "HD 173087"},
        {"Hipparcos Number", "HIP 91707"},
        {"Celescope Catalog", "CEL 4642"},
        {"Geneva Identification System", "GEN# +1.00173087"},
        {"Smithsonian Astrophysical Observation", "SAO 67265"},
        {"Wilson Evans Batten Catalogue", "WEB 15772"},
    },
    visualMagnitude: 6.49,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.53369641),
        dec: Angle.Degrees(+34.74631578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85846",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10624 AB"},
        {"Henry Draper", "HD 159304"},
        {"Hipparcos Number", "HIP 85846"},
        {"Smithsonian Astrophysical Observation", "SAO 66127"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.14201415),
        dec: Angle.Degrees(+34.74654404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222731"},
        {"Hipparcos Number", "HIP 117000"},
        {"Smithsonian Astrophysical Observation", "SAO 73459"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.78168202),
        dec: Angle.Degrees(+34.74672649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91712",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11593 B"},
        {"Hipparcos Number", "HIP 91712"},
        {"Geneva Identification System", "GEN# +1.20173087"},
        {"Geneva Identification System 2", "GEN# +0.03403286"},
        {"Smithsonian Astrophysical Observation", "SAO 67266"},
        {"Wilson Evans Batten Catalogue", "WEB 15777"},
    },
    visualMagnitude: 8.19,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.54208083),
        dec: Angle.Degrees(+34.74724081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159733"},
        {"Hipparcos Number", "HIP 86016"},
        {"Geneva Identification System", "GEN# +1.00159733"},
        {"Smithsonian Astrophysical Observation", "SAO 66150"},
        {"Wilson Evans Batten Catalogue", "WEB 14515"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.68931087),
        dec: Angle.Degrees(+34.75139003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199007"},
        {"Hipparcos Number", "HIP 103073"},
        {"Celescope Catalog", "CEL 5192"},
        {"Geneva Identification System", "GEN# +1.00199007"},
        {"Smithsonian Astrophysical Observation", "SAO 70626"},
    },
    visualMagnitude: 7.95,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.26452926),
        dec: Angle.Degrees(+34.75210931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7943"},
        {"Hipparcos Number", "HIP 6208"},
        {"Smithsonian Astrophysical Observation", "SAO 54601"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.89771659),
        dec: Angle.Degrees(+34.75282831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117100"},
        {"Hipparcos Number", "HIP 65650"},
        {"Smithsonian Astrophysical Observation", "SAO 63550"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.89512805),
        dec: Angle.Degrees(+34.75303580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133947"},
        {"Hipparcos Number", "HIP 73891"},
        {"Smithsonian Astrophysical Observation", "SAO 64498"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.53353565),
        dec: Angle.Degrees(+34.75354629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134693"},
        {"Hipparcos Number", "HIP 74226"},
        {"Smithsonian Astrophysical Observation", "SAO 64529"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.53468335),
        dec: Angle.Degrees(+34.75372662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198692"},
        {"Hipparcos Number", "HIP 102910"},
        {"Smithsonian Astrophysical Observation", "SAO 70575"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.73324994),
        dec: Angle.Degrees(+34.75400092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48787"},
    },
    visualMagnitude: 11.87,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.26456313),
        dec: Angle.Degrees(+34.76013367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -248.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94039",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12093 B"},
        {"Hipparcos Number", "HIP 94039"},
        {"Smithsonian Astrophysical Observation", "SAO 67867"},
        {"Wilson Evans Batten Catalogue", "WEB 16368"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.18366290),
        dec: Angle.Degrees(+34.76019928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94043",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12093 A"},
        {"Henry Draper", "HD 178849"},
        {"Hipparcos Number", "HIP 94043"},
        {"Celescope Catalog", "CEL 4706"},
        {"Geneva Identification System", "GEN# +1.00178849"},
        {"Smithsonian Astrophysical Observation", "SAO 67870"},
        {"Wilson Evans Batten Catalogue", "WEB 16372"},
    },
    visualMagnitude: 7.04,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.18831249),
        dec: Angle.Degrees(+34.76030844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181163"},
        {"Hipparcos Number", "HIP 94850"},
        {"Celescope Catalog", "CEL 4732"},
        {"Geneva Identification System", "GEN# +1.00181163"},
        {"Smithsonian Astrophysical Observation", "SAO 68098"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.49795085),
        dec: Angle.Degrees(+34.76472365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108101"},
        {"Hipparcos Number", "HIP 60587"},
        {"Geneva Identification System", "GEN# +1.00108101"},
        {"Renson", "Renson 31390"},
        {"Smithsonian Astrophysical Observation", "SAO 62992"},
        {"Wilson Evans Batten Catalogue", "WEB 10774"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.26962885),
        dec: Angle.Degrees(+34.76479577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93674",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93674"},
        {"Smithsonian Astrophysical Observation", "SAO 67775"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.14165873),
        dec: Angle.Degrees(+34.76547084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18103"},
        {"Hipparcos Number", "HIP 13628"},
        {"Smithsonian Astrophysical Observation", "SAO 56003"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.88119472),
        dec: Angle.Degrees(+34.76910967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35546"},
        {"Hipparcos Number", "HIP 25485"},
        {"Celescope Catalog", "CEL 695"},
        {"Geneva Identification System", "GEN# +1.00035546"},
        {"Smithsonian Astrophysical Observation", "SAO 58036"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.76166886),
        dec: Angle.Degrees(+34.76913013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31619",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31619"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.25991832),
        dec: Angle.Degrees(+34.76978359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14342",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2328 A"},
        {"Henry Draper", "HD 19059"},
        {"Hipparcos Number", "HIP 14342"},
        {"Geneva Identification System", "GEN# +1.00019059"},
        {"Smithsonian Astrophysical Observation", "SAO 56136"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.23717912),
        dec: Angle.Degrees(+34.77079824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -239.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39667"},
        {"Smithsonian Astrophysical Observation", "SAO 60559"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.58968580),
        dec: Angle.Degrees(+34.77196197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106612",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106612"},
        {"Smithsonian Astrophysical Observation", "SAO 71491"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.89540297),
        dec: Angle.Degrees(+34.77224796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120818"},
        {"Hipparcos Number", "HIP 67596"},
        {"Geneva Identification System", "GEN# +1.00120818"},
        {"Smithsonian Astrophysical Observation", "SAO 63779"},
        {"Wilson Evans Batten Catalogue", "WEB 11887"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.76879062),
        dec: Angle.Degrees(+34.77253613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202385"},
        {"Hipparcos Number", "HIP 104854"},
        {"Geneva Identification System", "GEN# +1.00202385"},
        {"Smithsonian Astrophysical Observation", "SAO 71111"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.59884727),
        dec: Angle.Degrees(+34.77297696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208344"},
        {"Hipparcos Number", "HIP 108172"},
        {"Geneva Identification System", "GEN# +1.00208344"},
        {"Smithsonian Astrophysical Observation", "SAO 71834"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.74452731),
        dec: Angle.Degrees(+34.77316636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66899"},
        {"Hipparcos Number", "HIP 39703"},
        {"Smithsonian Astrophysical Observation", "SAO 60569"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.73394810),
        dec: Angle.Degrees(+34.77450284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86750",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10747 A"},
        {"Henry Draper", "HD 161354"},
        {"Hipparcos Number", "HIP 86750"},
        {"Geneva Identification System", "GEN# +1.00161354"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.89595888),
        dec: Angle.Degrees(+34.77485971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37475",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37475"},
        {"Smithsonian Astrophysical Observation", "SAO 60272"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.38308426),
        dec: Angle.Degrees(+34.77545841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68935",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9112 A"},
        {"Henry Draper", "HD 123408"},
        {"Hipparcos Number", "HIP 68935"},
        {"Geneva Identification System", "GEN# +1.00123408"},
        {"Smithsonian Astrophysical Observation", "SAO 63935"},
        {"Wilson Evans Batten Catalogue", "WEB 12047"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.67332192),
        dec: Angle.Degrees(+34.77857698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86749",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10747 B"},
        {"Hipparcos Number", "HIP 86749"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.89556004),
        dec: Angle.Degrees(+34.77904568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120617"},
        {"Hipparcos Number", "HIP 67499"},
        {"Geneva Identification System", "GEN# +1.00120617"},
        {"Smithsonian Astrophysical Observation", "SAO 63773"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.48519562),
        dec: Angle.Degrees(+34.77982752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47087",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Illyrian"},
        {"Henry Draper", "HD 82886"},
        {"Hipparcos Number", "HIP 47087"},
        {"Geneva Identification System", "GEN# +1.00082886"},
        {"Smithsonian Astrophysical Observation", "SAO 61587"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.93821880),
        dec: Angle.Degrees(+34.78082740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35652"},
        {"Hipparcos Number", "HIP 25565"},
        {"Celescope Catalog", "CEL 711"},
        {"Geneva Identification System", "GEN# +1.00035652"},
        {"Smithsonian Astrophysical Observation", "SAO 58059"},
        {"Wilson Evans Batten Catalogue", "WEB 4962"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.96833196),
        dec: Angle.Degrees(+34.78284785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97322"},
        {"Hipparcos Number", "HIP 54734"},
        {"Smithsonian Astrophysical Observation", "SAO 62448"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.09498615),
        dec: Angle.Degrees(+34.78480862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148928"},
        {"Hipparcos Number", "HIP 80808"},
        {"Smithsonian Astrophysical Observation", "SAO 65342"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.52313303),
        dec: Angle.Degrees(+34.78593582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36694",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36694"},
        {"Smithsonian Astrophysical Observation", "SAO 60165"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.22083958),
        dec: Angle.Degrees(+34.78876901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102807"},
        {"Hipparcos Number", "HIP 57719"},
        {"Geneva Identification System", "GEN# +1.00102807"},
        {"Smithsonian Astrophysical Observation", "SAO 62722"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.55369676),
        dec: Angle.Degrees(+34.78966181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154431"},
        {"Hipparcos Number", "HIP 83494"},
        {"Geneva Identification System", "GEN# +1.00154431"},
        {"Smithsonian Astrophysical Observation", "SAO 65766"},
        {"Wilson Evans Batten Catalogue", "WEB 14115"},
    },
    visualMagnitude: 6.08,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.97341989),
        dec: Angle.Degrees(+34.79023710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91409"},
        {"Hipparcos Number", "HIP 51710"},
        {"Smithsonian Astrophysical Observation", "SAO 62124"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.48288019),
        dec: Angle.Degrees(+34.79128526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219927"},
        {"Hipparcos Number", "HIP 115148"},
        {"Geneva Identification System", "GEN# +1.00219927"},
        {"Renson", "Renson 60395"},
        {"Smithsonian Astrophysical Observation", "SAO 73171"},
        {"Wilson Evans Batten Catalogue", "WEB 20400"},
    },
    visualMagnitude: 6.32,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.86417565),
        dec: Angle.Degrees(+34.79318424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33500"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.45113292),
        dec: Angle.Degrees(+34.79665804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81006"},
        {"Hipparcos Number", "HIP 46098"},
        {"Geneva Identification System", "GEN# +1.00081006"},
        {"Smithsonian Astrophysical Observation", "SAO 61450"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.01038629),
        dec: Angle.Degrees(+34.79687603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9298"},
        {"Hipparcos Number", "HIP 7147"},
        {"Celescope Catalog", "CEL 144"},
        {"Fundamental Katalog 5th Edition", "FK5 2100"},
        {"Geneva Identification System", "GEN# +1.00009298"},
        {"Renson", "Renson 2250"},
        {"Smithsonian Astrophysical Observation", "SAO 54762"},
        {"Wilson Evans Batten Catalogue", "WEB 1543"},
    },
    visualMagnitude: 6.39,
    bvColour: -0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.03159840),
        dec: Angle.Degrees(+34.79997529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28832"},
        {"Hipparcos Number", "HIP 21291"},
        {"Smithsonian Astrophysical Observation", "SAO 57312"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.52026210),
        dec: Angle.Degrees(+34.80032282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54125"},
        {"Hipparcos Number", "HIP 34529"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.31927541),
        dec: Angle.Degrees(+34.80310852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36402",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6111 A"},
        {"Henry Draper", "HD 58987"},
        {"Hipparcos Number", "HIP 36402"},
        {"Smithsonian Astrophysical Observation", "SAO 60125"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.36280460),
        dec: Angle.Degrees(+34.80334070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46393",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46393"},
        {"Smithsonian Astrophysical Observation", "SAO 61501"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.90161927),
        dec: Angle.Degrees(+34.80349905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20064"},
        {"Hipparcos Number", "HIP 15091"},
        {"Geneva Identification System", "GEN# +1.00020064"},
        {"Smithsonian Astrophysical Observation", "SAO 56278"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.66508543),
        dec: Angle.Degrees(+34.80381673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6812"},
        {"Hipparcos Number", "HIP 5425"},
        {"Smithsonian Astrophysical Observation", "SAO 54463"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.32198100),
        dec: Angle.Degrees(+34.80593036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21313"},
        {"Hipparcos Number", "HIP 16107"},
        {"Geneva Identification System", "GEN# +1.00021313"},
        {"Smithsonian Astrophysical Observation", "SAO 56465"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.87245502),
        dec: Angle.Degrees(+34.80680706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177108"},
        {"Hipparcos Number", "HIP 93440"},
        {"Smithsonian Astrophysical Observation", "SAO 67722"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.45468623),
        dec: Angle.Degrees(+34.80831559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82636"},
        {"Hipparcos Number", "HIP 46954"},
        {"Geneva Identification System", "GEN# +1.00082636"},
        {"Smithsonian Astrophysical Observation", "SAO 61571"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.56140530),
        dec: Angle.Degrees(+34.81116926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37032"},
        {"Hipparcos Number", "HIP 26397"},
        {"Geneva Identification System", "GEN# +1.00037032"},
        {"Smithsonian Astrophysical Observation", "SAO 58254"},
        {"Wilson Evans Batten Catalogue", "WEB 5202"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.28746597),
        dec: Angle.Degrees(+34.81196457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140591"},
        {"Hipparcos Number", "HIP 76994"},
        {"Smithsonian Astrophysical Observation", "SAO 64867"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.81337228),
        dec: Angle.Degrees(+34.81205235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200928"},
        {"Hipparcos Number", "HIP 104102"},
        {"Smithsonian Astrophysical Observation", "SAO 70888"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.36263986),
        dec: Angle.Degrees(+34.81211210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114778"},
        {"Hipparcos Number", "HIP 64420"},
        {"Geneva Identification System", "GEN# +1.00114778"},
        {"Smithsonian Astrophysical Observation", "SAO 63401"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.05244590),
        dec: Angle.Degrees(+34.81293357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26799",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26799"},
        {"Smithsonian Astrophysical Observation", "SAO 58336"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.37116657),
        dec: Angle.Degrees(+34.81296871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24809"},
        {"Hipparcos Number", "HIP 18547"},
        {"Geneva Identification System", "GEN# +1.00024809"},
        {"Smithsonian Astrophysical Observation", "SAO 56847"},
        {"Wilson Evans Batten Catalogue", "WEB 3575"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.51302909),
        dec: Angle.Degrees(+34.81404912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31863",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31863"},
        {"Smithsonian Astrophysical Observation", "SAO 59336"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.91143808),
        dec: Angle.Degrees(+34.81423938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26849",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26849"},
        {"Smithsonian Astrophysical Observation", "SAO 58345"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.50467732),
        dec: Angle.Degrees(+34.81598342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41524"},
        {"Hipparcos Number", "HIP 29008"},
        {"Smithsonian Astrophysical Observation", "SAO 58760"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.81879924),
        dec: Angle.Degrees(+34.81682140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1744",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1744"},
        {"Smithsonian Astrophysical Observation", "SAO 53841"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.51693610),
        dec: Angle.Degrees(+34.81912682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80958"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.97348295),
        dec: Angle.Degrees(+34.81971095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92619",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92619"},
        {"Smithsonian Astrophysical Observation", "SAO 67499"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.07489152),
        dec: Angle.Degrees(+34.81977654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278917"},
        {"Hipparcos Number", "HIP 17371"},
        {"Geneva Identification System", "GEN# +1.00278917"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.78901926),
        dec: Angle.Degrees(+34.82010715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17943",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2794 A"},
        {"Henry Draper", "HD 23922"},
        {"Hipparcos Number", "HIP 17943"},
        {"Geneva Identification System", "GEN# +1.00023922"},
        {"Smithsonian Astrophysical Observation", "SAO 56735"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.55514159),
        dec: Angle.Degrees(+34.82029870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73662"},
        {"Hipparcos Number", "HIP 42583"},
        {"Smithsonian Astrophysical Observation", "SAO 60975"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.18431991),
        dec: Angle.Degrees(+34.82057199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47109"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.01587899),
        dec: Angle.Degrees(+34.82203539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33569"},
        {"Hipparcos Number", "HIP 24288"},
        {"Celescope Catalog", "CEL 562"},
        {"Geneva Identification System", "GEN# +1.00033569"},
        {"Smithsonian Astrophysical Observation", "SAO 57743"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.18666903),
        dec: Angle.Degrees(+34.82345816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72906"},
        {"Hipparcos Number", "HIP 42230"},
        {"Geneva Identification System", "GEN# +1.00072906"},
        {"Smithsonian Astrophysical Observation", "SAO 60921"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.15613342),
        dec: Angle.Degrees(+34.82383343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76829"},
        {"Hipparcos Number", "HIP 44169"},
        {"Geneva Identification System", "GEN# +1.00076829"},
        {"Smithsonian Astrophysical Observation", "SAO 61181"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.94279982),
        dec: Angle.Degrees(+34.82520671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166013"},
        {"Hipparcos Number", "HIP 88761"},
        {"Smithsonian Astrophysical Observation", "SAO 66652"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.79780603),
        dec: Angle.Degrees(+34.82527531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90808"},
        {"Hipparcos Number", "HIP 51389"},
        {"Smithsonian Astrophysical Observation", "SAO 62073"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.43905647),
        dec: Angle.Degrees(+34.82749583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57615",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57615"},
        {"Smithsonian Astrophysical Observation", "SAO 62714"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.20035481),
        dec: Angle.Degrees(+34.83019885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279393"},
        {"Hipparcos Number", "HIP 18945"},
        {"Geneva Identification System", "GEN# +1.00279393"},
        {"Smithsonian Astrophysical Observation", "SAO 56931"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.91199632),
        dec: Angle.Degrees(+34.83100779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25373"},
        {"Hipparcos Number", "HIP 18914"},
        {"Smithsonian Astrophysical Observation", "SAO 56929"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.80413800),
        dec: Angle.Degrees(+34.83351263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44898",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44898"},
        {"Smithsonian Astrophysical Observation", "SAO 61287"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.21392438),
        dec: Angle.Degrees(+34.83530692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205573"},
        {"Hipparcos Number", "HIP 106597"},
        {"Geneva Identification System", "GEN# +1.00205573"},
        {"Smithsonian Astrophysical Observation", "SAO 71490"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.83426024),
        dec: Angle.Degrees(+34.83584095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50661"},
        {"Hipparcos Number", "HIP 33314"},
        {"Smithsonian Astrophysical Observation", "SAO 59613"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.93633842),
        dec: Angle.Degrees(+34.83711064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45754"},
        {"Hipparcos Number", "HIP 31049"},
        {"Geneva Identification System", "GEN# +1.00045754"},
        {"Smithsonian Astrophysical Observation", "SAO 59163"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.72241365),
        dec: Angle.Degrees(+34.83812227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96457"},
        {"Hipparcos Number", "HIP 54369"},
        {"Fundamental Katalog 5th Edition", "FK5 4983"},
        {"Geneva Identification System", "GEN# +1.00096457"},
        {"Smithsonian Astrophysical Observation", "SAO 62414"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.85815694),
        dec: Angle.Degrees(+34.84297254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98099"},
        {"Hipparcos Number", "HIP 55143"},
        {"Smithsonian Astrophysical Observation", "SAO 62476"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.33345748),
        dec: Angle.Degrees(+34.84396356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62328",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62328"},
        {"Geneva Identification System", "GEN# +0.03502372"},
        {"Smithsonian Astrophysical Observation", "SAO 63186"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.59565186),
        dec: Angle.Degrees(+34.85178368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192164"},
        {"Hipparcos Number", "HIP 99562"},
        {"Geneva Identification System", "GEN# +1.00192164"},
        {"Smithsonian Astrophysical Observation", "SAO 69595"},
        {"Wilson Evans Batten Catalogue", "WEB 17812"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.07623131),
        dec: Angle.Degrees(+34.85298905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169489"},
        {"Hipparcos Number", "HIP 90114"},
        {"Geneva Identification System", "GEN# +1.00169489"},
        {"Smithsonian Astrophysical Observation", "SAO 66925"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.83871959),
        dec: Angle.Degrees(+34.85363387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 590",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 590"},
        {"Smithsonian Astrophysical Observation", "SAO 53651"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.79242036),
        dec: Angle.Degrees(+34.85379559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25343",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4000 A"},
        {"Henry Draper", "HD 35295"},
        {"Hipparcos Number", "HIP 25343"},
        {"Geneva Identification System", "GEN# +1.00035295A"},
        {"Smithsonian Astrophysical Observation", "SAO 57999"},
        {"Wilson Evans Batten Catalogue", "WEB 4914"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.30393109),
        dec: Angle.Degrees(+34.85515497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112800",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112800"},
        {"Geneva Identification System", "GEN# +9.80189038"},
    },
    visualMagnitude: 11.72,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.65460662),
        dec: Angle.Degrees(+34.85529109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 843.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 315.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176087"},
        {"Hipparcos Number", "HIP 93037"},
        {"Geneva Identification System", "GEN# +1.00176087"},
        {"Smithsonian Astrophysical Observation", "SAO 67618"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.28149005),
        dec: Angle.Degrees(+34.85573304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63641",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63641"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.65645873),
        dec: Angle.Degrees(+34.85911311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98710"},
        {"Hipparcos Number", "HIP 55491"},
        {"Geneva Identification System", "GEN# +1.00098710"},
        {"Renson", "Renson 28460"},
        {"Smithsonian Astrophysical Observation", "SAO 62511"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.46348760),
        dec: Angle.Degrees(+34.86026233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183205"},
        {"Hipparcos Number", "HIP 95629"},
        {"Smithsonian Astrophysical Observation", "SAO 68327"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.76496462),
        dec: Angle.Degrees(+34.86079798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81786",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81786"},
        {"Smithsonian Astrophysical Observation", "SAO 65497"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.57248284),
        dec: Angle.Degrees(+34.86166756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143918"},
        {"Hipparcos Number", "HIP 78520"},
        {"Geneva Identification System", "GEN# +1.00143918"},
        {"Smithsonian Astrophysical Observation", "SAO 65029"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.45121974),
        dec: Angle.Degrees(+34.86169379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8203",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1385 AB"},
        {"Hipparcos Number", "HIP 8203"},
        {"Smithsonian Astrophysical Observation", "SAO 54951"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.36708011),
        dec: Angle.Degrees(+34.86298075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51320",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7788 AB"},
        {"Henry Draper", "HD 90698"},
        {"Hipparcos Number", "HIP 51320"},
        {"Smithsonian Astrophysical Observation", "SAO 62061"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.24400624),
        dec: Angle.Degrees(+34.86334457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25341",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4000 B"},
        {"Henry Draper", "HD 35295B"},
        {"Hipparcos Number", "HIP 25341"},
        {"Geneva Identification System", "GEN# +0.03401030"},
        {"Geneva Identification System 2", "GEN# +1.00035295B"},
        {"Geneva Identification System 3", "GEN# +1.20035295"},
        {"Smithsonian Astrophysical Observation", "SAO 57998"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.30159124),
        dec: Angle.Degrees(+34.86362803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5494"},
        {"Hipparcos Number", "HIP 4457"},
        {"Geneva Identification System", "GEN# +1.00005494"},
        {"Smithsonian Astrophysical Observation", "SAO 54286"},
        {"Wilson Evans Batten Catalogue", "WEB 804"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.29094455),
        dec: Angle.Degrees(+34.86400595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153649"},
        {"Hipparcos Number", "HIP 83130"},
        {"Geneva Identification System", "GEN# +1.00153649"},
        {"Smithsonian Astrophysical Observation", "SAO 65700"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.82714848),
        dec: Angle.Degrees(+34.86436417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45393"},
        {"Hipparcos Number", "HIP 30850"},
        {"Smithsonian Astrophysical Observation", "SAO 59129"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.17801322),
        dec: Angle.Degrees(+34.86471201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52052",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52052"},
        {"Smithsonian Astrophysical Observation", "SAO 62169"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.54766025),
        dec: Angle.Degrees(+34.86560757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33119"},
        {"Hipparcos Number", "HIP 23998"},
        {"Smithsonian Astrophysical Observation", "SAO 57689"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.38792845),
        dec: Angle.Degrees(+34.86725164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72730",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72730"},
        {"Smithsonian Astrophysical Observation", "SAO 64369"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.04502729),
        dec: Angle.Degrees(+34.86752103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99411",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13465 AB"},
        {"Henry Draper", "HD 191833"},
        {"Hipparcos Number", "HIP 99411"},
        {"Wilson Evans Batten Catalogue", "WEB 17751"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.65344230),
        dec: Angle.Degrees(+34.86777811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100698"},
        {"Hipparcos Number", "HIP 56533"},
        {"Geneva Identification System", "GEN# +1.00100698"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.87796665),
        dec: Angle.Degrees(+34.86785484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1073"},
        {"Hipparcos Number", "HIP 1211"},
        {"Geneva Identification System", "GEN# +1.00001073"},
        {"Smithsonian Astrophysical Observation", "SAO 53758"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.78824092),
        dec: Angle.Degrees(+34.86822459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19903",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3088 AB"},
        {"Henry Draper", "HD 26860"},
        {"Hipparcos Number", "HIP 19903"},
        {"Smithsonian Astrophysical Observation", "SAO 57112"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.04418904),
        dec: Angle.Degrees(+34.86881440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71478"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.26474002),
        dec: Angle.Degrees(+34.86915641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75897"},
        {"Hipparcos Number", "HIP 43695"},
        {"Geneva Identification System", "GEN# +1.00075897"},
        {"Smithsonian Astrophysical Observation", "SAO 61120"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.49653949),
        dec: Angle.Degrees(+34.86919246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137201"},
        {"Hipparcos Number", "HIP 75326"},
        {"Smithsonian Astrophysical Observation", "SAO 64677"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.85869934),
        dec: Angle.Degrees(+34.86942381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190468"},
        {"Hipparcos Number", "HIP 98786"},
        {"Geneva Identification System", "GEN# +1.00190468"},
        {"Renson", "Renson 52960"},
        {"Smithsonian Astrophysical Observation", "SAO 69336"},
        {"Wilson Evans Batten Catalogue", "WEB 17504"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.94167402),
        dec: Angle.Degrees(+34.86985557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49536"},
        {"Hipparcos Number", "HIP 32818"},
        {"Geneva Identification System", "GEN# +1.00049536"},
        {"Smithsonian Astrophysical Observation", "SAO 59535"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.61771489),
        dec: Angle.Degrees(+34.87475436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71749",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71749"},
        {"Smithsonian Astrophysical Observation", "SAO 64266"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.14130450),
        dec: Angle.Degrees(+34.87790915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121148"},
        {"Hipparcos Number", "HIP 67766"},
        {"Geneva Identification System", "GEN# +1.00121148"},
        {"Smithsonian Astrophysical Observation", "SAO 63806"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.24386742),
        dec: Angle.Degrees(+34.87833837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54084",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54084"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.00333683),
        dec: Angle.Degrees(+34.88112506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74512",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9547 AB"},
        {"Henry Draper", "HD 135365"},
        {"Hipparcos Number", "HIP 74512"},
        {"Geneva Identification System", "GEN# +1.00135365J"},
        {"Smithsonian Astrophysical Observation", "SAO 64567"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.39672245),
        dec: Angle.Degrees(+34.88187900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36212"},
        {"Hipparcos Number", "HIP 25906"},
        {"Celescope Catalog", "CEL 748"},
        {"Geneva Identification System", "GEN# +1.00036212"},
        {"Smithsonian Astrophysical Observation", "SAO 58145"},
        {"Wilson Evans Batten Catalogue", "WEB 5034"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.93973521),
        dec: Angle.Degrees(+34.88193775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202571"},
        {"Hipparcos Number", "HIP 104981"},
        {"Smithsonian Astrophysical Observation", "SAO 71134"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.94655047),
        dec: Angle.Degrees(+34.88234871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7434"},
        {"Hipparcos Number", "HIP 5849"},
        {"Smithsonian Astrophysical Observation", "SAO 54547"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.75664898),
        dec: Angle.Degrees(+34.88474998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90681"},
        {"Hipparcos Number", "HIP 51312"},
        {"Smithsonian Astrophysical Observation", "SAO 62060"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.21445875),
        dec: Angle.Degrees(+34.88582428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46391"},
        {"Smithsonian Astrophysical Observation", "SAO 61500"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.89673112),
        dec: Angle.Degrees(+34.88628012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117830"},
        {"Hipparcos Number", "HIP 66044"},
        {"Fundamental Katalog 5th Edition", "FK5 5193"},
        {"Geneva Identification System", "GEN# +1.00117830"},
        {"Smithsonian Astrophysical Observation", "SAO 63592"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.09535954),
        dec: Angle.Degrees(+34.88815586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114863"},
        {"Hipparcos Number", "HIP 64469"},
        {"Smithsonian Astrophysical Observation", "SAO 63405"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.20514570),
        dec: Angle.Degrees(+34.88849668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67320"},
        {"Hipparcos Number", "HIP 39881"},
        {"Smithsonian Astrophysical Observation", "SAO 60596"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.19618306),
        dec: Angle.Degrees(+34.89051199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34477"},
        {"Hipparcos Number", "HIP 24821"},
        {"Celescope Catalog", "CEL 605"},
        {"Geneva Identification System", "GEN# +1.00034477J"},
        {"Smithsonian Astrophysical Observation", "SAO 57889"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.81402332),
        dec: Angle.Degrees(+34.89055582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91769"},
        {"Hipparcos Number", "HIP 51921"},
        {"Geneva Identification System", "GEN# +1.00091769"},
        {"Smithsonian Astrophysical Observation", "SAO 62149"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.09668639),
        dec: Angle.Degrees(+34.89602288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105138",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14831 A"},
        {"Henry Draper", "HD 202904"},
        {"Hipparcos Number", "HIP 105138"},
        {"Celescope Catalog", "CEL 5287"},
        {"Fundamental Katalog 5th Edition", "FK5 1559"},
        {"Geneva Identification System", "GEN# +1.00202904A"},
        {"Smithsonian Astrophysical Observation", "SAO 71173"},
        {"Wilson Evans Batten Catalogue", "WEB 19096"},
    },
    visualMagnitude: 4.41,
    bvColour: -0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.47944955),
        dec: Angle.Degrees(+34.89688120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206846"},
        {"Hipparcos Number", "HIP 107298"},
        {"Geneva Identification System", "GEN# +1.00206846"},
        {"Smithsonian Astrophysical Observation", "SAO 71649"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.99600843),
        dec: Angle.Degrees(+34.89988331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82590",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82590"},
        {"Smithsonian Astrophysical Observation", "SAO 65629"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.25530292),
        dec: Angle.Degrees(+34.90023377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188668"},
        {"Hipparcos Number", "HIP 98004"},
        {"Smithsonian Astrophysical Observation", "SAO 69080"},
        {"Wilson Evans Batten Catalogue", "WEB 17256"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.75056563),
        dec: Angle.Degrees(+34.90055680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57246"},
        {"Hipparcos Number", "HIP 35687"},
        {"Geneva Identification System", "GEN# +1.00057246"},
        {"Smithsonian Astrophysical Observation", "SAO 60006"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.45209150),
        dec: Angle.Degrees(+34.90202640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103684"},
        {"Hipparcos Number", "HIP 58222"},
        {"Geneva Identification System", "GEN# +1.00103684"},
        {"Smithsonian Astrophysical Observation", "SAO 62765"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.12350562),
        dec: Angle.Degrees(+34.90355551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11046"},
        {"Hipparcos Number", "HIP 8471"},
        {"Geneva Identification System", "GEN# +1.00011046"},
        {"Smithsonian Astrophysical Observation", "SAO 55000"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.30374649),
        dec: Angle.Degrees(+34.90421456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124440"},
        {"Hipparcos Number", "HIP 69425"},
        {"Geneva Identification System", "GEN# +1.00124440"},
        {"Smithsonian Astrophysical Observation", "SAO 63988"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.22073827),
        dec: Angle.Degrees(+34.90484406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66089",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8939 AB"},
        {"Henry Draper", "HD 117902"},
        {"Hipparcos Number", "HIP 66089"},
        {"Geneva Identification System", "GEN# +1.00117902"},
        {"Smithsonian Astrophysical Observation", "SAO 63599"},
        {"Wilson Evans Batten Catalogue", "WEB 11680"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.21257459),
        dec: Angle.Degrees(+34.90716691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96886"},
        {"Hipparcos Number", "HIP 54548"},
        {"Smithsonian Astrophysical Observation", "SAO 62429"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.43595827),
        dec: Angle.Degrees(+34.90801205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135520"},
        {"Hipparcos Number", "HIP 74578"},
        {"Geneva Identification System", "GEN# +1.00135520"},
        {"Smithsonian Astrophysical Observation", "SAO 64578"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.57636099),
        dec: Angle.Degrees(+34.91106616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227704"},
        {"Hipparcos Number", "HIP 99061"},
        {"Smithsonian Astrophysical Observation", "SAO 69424"},
        {"Wilson Evans Batten Catalogue", "WEB 17613"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.67089036),
        dec: Angle.Degrees(+34.91120242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216998"},
        {"Hipparcos Number", "HIP 113335"},
        {"Geneva Identification System", "GEN# +1.00216998"},
        {"Smithsonian Astrophysical Observation", "SAO 72872"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.28634081),
        dec: Angle.Degrees(+34.91196783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180053"},
        {"Hipparcos Number", "HIP 94465"},
        {"Smithsonian Astrophysical Observation", "SAO 68002"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.40091927),
        dec: Angle.Degrees(+34.91447233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190841"},
        {"Hipparcos Number", "HIP 98971"},
        {"Geneva Identification System", "GEN# +1.00190841"},
        {"Smithsonian Astrophysical Observation", "SAO 69388"},
        {"Wilson Evans Batten Catalogue", "WEB 17575"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.40418986),
        dec: Angle.Degrees(+34.91475073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52735",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52735"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.71282673),
        dec: Angle.Degrees(+34.91531907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228286"},
        {"Hipparcos Number", "HIP 99574"},
        {"Smithsonian Astrophysical Observation", "SAO 69598"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.11035346),
        dec: Angle.Degrees(+34.91547850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207663"},
        {"Hipparcos Number", "HIP 107760"},
        {"Smithsonian Astrophysical Observation", "SAO 71747"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.45353926),
        dec: Angle.Degrees(+34.91675577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6908",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6908"},
        {"Smithsonian Astrophysical Observation", "SAO 54728"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.23479003),
        dec: Angle.Degrees(+34.91713662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104970",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104970"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.92746856),
        dec: Angle.Degrees(+34.91729007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23840"},
        {"Hipparcos Number", "HIP 17880"},
        {"Geneva Identification System", "GEN# +1.00023840"},
        {"Smithsonian Astrophysical Observation", "SAO 56725"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.37157050),
        dec: Angle.Degrees(+34.91753545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89645",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89645"},
        {"Smithsonian Astrophysical Observation", "SAO 66834"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.41401001),
        dec: Angle.Degrees(+34.91835718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132546"},
        {"Hipparcos Number", "HIP 73282"},
        {"Smithsonian Astrophysical Observation", "SAO 64431"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.65936898),
        dec: Angle.Degrees(+34.91854646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203080"},
        {"Hipparcos Number", "HIP 105246"},
        {"Smithsonian Astrophysical Observation", "SAO 71194"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.76461391),
        dec: Angle.Degrees(+34.91917468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112973"},
        {"Hipparcos Number", "HIP 63452"},
        {"Geneva Identification System", "GEN# +1.00112973"},
        {"Smithsonian Astrophysical Observation", "SAO 63286"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.03141279),
        dec: Angle.Degrees(+34.91934679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195854"},
        {"Hipparcos Number", "HIP 101359"},
        {"Smithsonian Astrophysical Observation", "SAO 70169"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.13351334),
        dec: Angle.Degrees(+34.92045942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162093"},
        {"Hipparcos Number", "HIP 87098"},
        {"Fundamental Katalog 5th Edition", "FK5 5563"},
        {"Smithsonian Astrophysical Observation", "SAO 66334"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.93962175),
        dec: Angle.Degrees(+34.92324063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93704",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93704"},
        {"Smithsonian Astrophysical Observation", "SAO 67783"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.21880594),
        dec: Angle.Degrees(+34.92490988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85597"},
        {"Hipparcos Number", "HIP 48520"},
        {"Wilson Evans Batten Catalogue", "WEB 9039"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.42985537),
        dec: Angle.Degrees(+34.92650439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56990",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56990"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.24016067),
        dec: Angle.Degrees(+34.92980435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15562"},
        {"Hipparcos Number", "HIP 11710"},
        {"Geneva Identification System", "GEN# +1.00015562"},
        {"Smithsonian Astrophysical Observation", "SAO 55621"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.78348393),
        dec: Angle.Degrees(+34.93066580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2105",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2105"},
        {"Smithsonian Astrophysical Observation", "SAO 53900"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.67382060),
        dec: Angle.Degrees(+34.93127915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102713"},
        {"Hipparcos Number", "HIP 57670"},
        {"Geneva Identification System", "GEN# +1.00102713"},
        {"Smithsonian Astrophysical Observation", "SAO 62718"},
        {"Wilson Evans Batten Catalogue", "WEB 10357"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.42416287),
        dec: Angle.Degrees(+34.93173940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74737",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74737"},
        {"Smithsonian Astrophysical Observation", "SAO 64603"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.11248415),
        dec: Angle.Degrees(+34.93344846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 375"},
        {"Hipparcos Number", "HIP 689"},
        {"Geneva Identification System", "GEN# +1.00000375"},
        {"Smithsonian Astrophysical Observation", "SAO 53674"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.11827092),
        dec: Angle.Degrees(+34.93452295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85597",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10594 B"},
        {"Hipparcos Number", "HIP 85597"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.37015922),
        dec: Angle.Degrees(+34.93677764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66079",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8939 C"},
        {"Hipparcos Number", "HIP 66079"},
        {"Smithsonian Astrophysical Observation", "SAO 63598"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.19305127),
        dec: Angle.Degrees(+34.93704972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85596",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10594 A"},
        {"Henry Draper", "HD 158756"},
        {"Hipparcos Number", "HIP 85596"},
        {"Smithsonian Astrophysical Observation", "SAO 66085"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.36730853),
        dec: Angle.Degrees(+34.93860320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65062"},
        {"Hipparcos Number", "HIP 38961"},
        {"Smithsonian Astrophysical Observation", "SAO 60486"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.57888037),
        dec: Angle.Degrees(+34.93912304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36280"},
        {"Hipparcos Number", "HIP 25943"},
        {"Celescope Catalog", "CEL 752"},
        {"Geneva Identification System", "GEN# +1.00036280"},
        {"Smithsonian Astrophysical Observation", "SAO 58153"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.04707630),
        dec: Angle.Degrees(+34.94015060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27005"},
        {"Hipparcos Number", "HIP 20013"},
        {"Smithsonian Astrophysical Observation", "SAO 57128"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.38257033),
        dec: Angle.Degrees(+34.94566867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50665",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50665"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.20133393),
        dec: Angle.Degrees(+34.94569515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80509"},
        {"Hipparcos Number", "HIP 45870"},
        {"Geneva Identification System", "GEN# +1.00080509"},
        {"Smithsonian Astrophysical Observation", "SAO 61418"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.29975992),
        dec: Angle.Degrees(+34.94769354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -195.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 226099"},
        {"Hipparcos Number", "HIP 97640"},
        {"Smithsonian Astrophysical Observation", "SAO 68946"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.66960320),
        dec: Angle.Degrees(+34.94957072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 318.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 201.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31431",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5203 AB"},
        {"Hipparcos Number", "HIP 31431"},
        {"Smithsonian Astrophysical Observation", "SAO 59258"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.78948769),
        dec: Angle.Degrees(+34.94964479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35349",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5954 A"},
        {"Henry Draper", "HD 56327"},
        {"Hipparcos Number", "HIP 35349"},
        {"Geneva Identification System", "GEN# +1.00056327"},
        {"Smithsonian Astrophysical Observation", "SAO 59962"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.52283401),
        dec: Angle.Degrees(+34.95175606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29157"},
        {"Hipparcos Number", "HIP 21491"},
        {"Geneva Identification System", "GEN# +1.00029157"},
        {"Smithsonian Astrophysical Observation", "SAO 57339"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.23493508),
        dec: Angle.Degrees(+34.95190691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221491"},
        {"Hipparcos Number", "HIP 116181"},
        {"Geneva Identification System", "GEN# +1.00221491"},
        {"Smithsonian Astrophysical Observation", "SAO 73325"},
        {"Wilson Evans Batten Catalogue", "WEB 20537"},
    },
    visualMagnitude: 6.66,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.10323072),
        dec: Angle.Degrees(+34.95236643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219613"},
        {"Hipparcos Number", "HIP 114931"},
        {"Smithsonian Astrophysical Observation", "SAO 73134"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.20402200),
        dec: Angle.Degrees(+34.95259544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35346",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5954 B"},
        {"Hipparcos Number", "HIP 35346"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.51698748),
        dec: Angle.Degrees(+34.95372293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222367"},
        {"Hipparcos Number", "HIP 116761"},
        {"Smithsonian Astrophysical Observation", "SAO 73418"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.96005980),
        dec: Angle.Degrees(+34.95550010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151935"},
        {"Hipparcos Number", "HIP 82310"},
        {"Geneva Identification System", "GEN# +1.00151935"},
        {"Smithsonian Astrophysical Observation", "SAO 65574"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.26763999),
        dec: Angle.Degrees(+34.95623507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31972"},
        {"Smithsonian Astrophysical Observation", "SAO 59353"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.23171290),
        dec: Angle.Degrees(+34.95880646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167920"},
        {"Hipparcos Number", "HIP 89509"},
        {"Smithsonian Astrophysical Observation", "SAO 66806"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.97878844),
        dec: Angle.Degrees(+34.96007283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50105"},
        {"Hipparcos Number", "HIP 33060"},
        {"Geneva Identification System", "GEN# +1.00050105"},
        {"Smithsonian Astrophysical Observation", "SAO 59579"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.29976025),
        dec: Angle.Degrees(+34.96037749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62765"},
        {"Hipparcos Number", "HIP 37980"},
        {"Smithsonian Astrophysical Observation", "SAO 60331"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.77074514),
        dec: Angle.Degrees(+34.96136654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88366",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88366"},
        {"Smithsonian Astrophysical Observation", "SAO 66577"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.66672286),
        dec: Angle.Degrees(+34.96355090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41820",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6851 AB"},
        {"Henry Draper", "HD 71974"},
        {"Hipparcos Number", "HIP 41820"},
        {"Smithsonian Astrophysical Observation", "SAO 60870"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.89597522),
        dec: Angle.Degrees(+34.96620004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60530",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60530"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.12635713),
        dec: Angle.Degrees(+34.96620786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -143.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8017"},
        {"Hipparcos Number", "HIP 6249"},
        {"Geneva Identification System", "GEN# +1.00008017"},
        {"Smithsonian Astrophysical Observation", "SAO 54609"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.04508444),
        dec: Angle.Degrees(+34.96986172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84238"},
        {"Hipparcos Number", "HIP 47806"},
        {"Geneva Identification System", "GEN# +1.00084238"},
        {"Smithsonian Astrophysical Observation", "SAO 61664"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.18815876),
        dec: Angle.Degrees(+34.97115325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117744",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117744"},
        {"Smithsonian Astrophysical Observation", "SAO 73577"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.18778061),
        dec: Angle.Degrees(+34.97177741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204675"},
        {"Hipparcos Number", "HIP 106082"},
        {"Smithsonian Astrophysical Observation", "SAO 71386"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.31699715),
        dec: Angle.Degrees(+34.97260971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71637"},
        {"Hipparcos Number", "HIP 41669"},
        {"Geneva Identification System", "GEN# +1.00071637"},
        {"Smithsonian Astrophysical Observation", "SAO 60854"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.43519532),
        dec: Angle.Degrees(+34.97306704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278968"},
        {"Hipparcos Number", "HIP 17458"},
        {"Geneva Identification System", "GEN# +1.00278968"},
        {"Wilson Evans Batten Catalogue", "WEB 3310"},
    },
    visualMagnitude: 10.63,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.12835687),
        dec: Angle.Degrees(+34.97351981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 198.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4756"},
        {"Hipparcos Number", "HIP 3897"},
        {"Geneva Identification System", "GEN# +1.00004756"},
        {"Smithsonian Astrophysical Observation", "SAO 54179"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.49406480),
        dec: Angle.Degrees(+34.97421902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160402"},
        {"Hipparcos Number", "HIP 86315"},
        {"Smithsonian Astrophysical Observation", "SAO 66201"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.54372051),
        dec: Angle.Degrees(+34.97533439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208456"},
        {"Hipparcos Number", "HIP 108234"},
        {"Geneva Identification System", "GEN# +1.00208456"},
        {"Smithsonian Astrophysical Observation", "SAO 71844"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.89646547),
        dec: Angle.Degrees(+34.97705866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118296"},
        {"Hipparcos Number", "HIP 66314"},
        {"Geneva Identification System", "GEN# +1.00118296"},
        {"Smithsonian Astrophysical Observation", "SAO 63630"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.86859728),
        dec: Angle.Degrees(+34.97754301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22848"},
        {"Hipparcos Number", "HIP 17226"},
        {"Smithsonian Astrophysical Observation", "SAO 56631"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.34642159),
        dec: Angle.Degrees(+34.98055800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193370"},
        {"Hipparcos Number", "HIP 100122"},
        {"Fundamental Katalog 5th Edition", "FK5 3627"},
        {"Geneva Identification System", "GEN# +1.00193370"},
        {"Smithsonian Astrophysical Observation", "SAO 69806"},
        {"Wilson Evans Batten Catalogue", "WEB 18032"},
    },
    visualMagnitude: 5.14,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.66279104),
        dec: Angle.Degrees(+34.98278431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85585"},
        {"Hipparcos Number", "HIP 48512"},
        {"Geneva Identification System", "GEN# +1.00085585"},
        {"Smithsonian Astrophysical Observation", "SAO 61742"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.40425283),
        dec: Angle.Degrees(+34.98384695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103376"},
        {"Cincinnati Publication", "Ci 20 1246"},
    },
    visualMagnitude: 10.77,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.16243372),
        dec: Angle.Degrees(+34.98405965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 444.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13161"},
        {"Hipparcos Number", "HIP 10064"},
        {"Celescope Catalog", "CEL 212"},
        {"Fundamental Katalog 5th Edition", "FK5 75"},
        {"Geneva Identification System", "GEN# +1.00013161"},
        {"Smithsonian Astrophysical Observation", "SAO 55306"},
        {"Wilson Evans Batten Catalogue", "WEB 2110"},
    },
    visualMagnitude: 3.00,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.38550383),
        dec: Angle.Degrees(+34.98739204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67475",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9032 A"},
        {"Henry Draper", "HD 120582"},
        {"Hipparcos Number", "HIP 67475"},
        {"Smithsonian Astrophysical Observation", "SAO 63771"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.41248912),
        dec: Angle.Degrees(+34.98837376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34773",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5852 AB"},
        {"Henry Draper", "HD 54824"},
        {"Hipparcos Number", "HIP 34773"},
        {"Geneva Identification System", "GEN# +1.00054824J"},
        {"Renson", "Renson 14970"},
        {"Smithsonian Astrophysical Observation", "SAO 59876"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.97805137),
        dec: Angle.Degrees(+34.98855320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91365"},
        {"Hipparcos Number", "HIP 51685"},
        {"Geneva Identification System", "GEN# +1.00091365"},
        {"Smithsonian Astrophysical Observation", "SAO 62121"},
        {"Wilson Evans Batten Catalogue", "WEB 9424"},
    },
    visualMagnitude: 5.57,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.37888150),
        dec: Angle.Degrees(+34.98870207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119458"},
        {"Hipparcos Number", "HIP 66907"},
        {"Fundamental Katalog 5th Edition", "FK5 3089"},
        {"Geneva Identification System", "GEN# +1.00119458"},
        {"Smithsonian Astrophysical Observation", "SAO 63701"},
        {"Wilson Evans Batten Catalogue", "WEB 11794"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.857,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.68092115),
        dec: Angle.Degrees(+34.98899453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194096"},
        {"Hipparcos Number", "HIP 100475"},
        {"Celescope Catalog", "CEL 5041"},
        {"Geneva Identification System", "GEN# +1.00194096"},
        {"Smithsonian Astrophysical Observation", "SAO 69916"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.63416927),
        dec: Angle.Degrees(+34.99077794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141348"},
        {"Hipparcos Number", "HIP 77359"},
        {"Smithsonian Astrophysical Observation", "SAO 64908"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.87798770),
        dec: Angle.Degrees(+34.99093900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67476",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9032 B"},
        {"Henry Draper", "HD 120582B"},
        {"Hipparcos Number", "HIP 67476"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.41386553),
        dec: Angle.Degrees(+34.99119871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14907",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2395 A"},
        {"Henry Draper", "HD 19808"},
        {"Hipparcos Number", "HIP 14907"},
        {"Smithsonian Astrophysical Observation", "SAO 56244"},
        {"Wilson Evans Batten Catalogue", "WEB 2879"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.09698530),
        dec: Angle.Degrees(+34.99227929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2866"},
        {"Hipparcos Number", "HIP 2539"},
        {"Geneva Identification System", "GEN# +1.00002866"},
        {"Smithsonian Astrophysical Observation", "SAO 53969"},
        {"Wilson Evans Batten Catalogue", "WEB 467"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.05851728),
        dec: Angle.Degrees(+34.99394306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38348",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38348"},
        {"Smithsonian Astrophysical Observation", "SAO 60386"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.81317757),
        dec: Angle.Degrees(+34.99800897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112988"},
        {"Hipparcos Number", "HIP 63458"},
        {"Geneva Identification System", "GEN# +1.00112988"},
        {"Smithsonian Astrophysical Observation", "SAO 63287"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.04309827),
        dec: Angle.Degrees(+34.99841300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9023",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9023"},
        {"Smithsonian Astrophysical Observation", "SAO 55108"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.04137422),
        dec: Angle.Degrees(+34.99914581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60201"},
        {"Geneva Identification System", "GEN# +0.03502332J"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.17611550),
        dec: Angle.Degrees(+34.99956752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30443"},
        {"Hipparcos Number", "HIP 22403"},
        {"Geneva Identification System", "GEN# +1.00030443"},
        {"Smithsonian Astrophysical Observation", "SAO 57440"},
        {"Wilson Evans Batten Catalogue", "WEB 4318"},
    },
    visualMagnitude: 8.80,
    bvColour: 2.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.31673940),
        dec: Angle.Degrees(+35.00182118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87462"},
        {"Hipparcos Number", "HIP 49454"},
        {"Smithsonian Astrophysical Observation", "SAO 61854"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.45441870),
        dec: Angle.Degrees(+35.00244459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64126"},
        {"Smithsonian Astrophysical Observation", "SAO 63364"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.14830211),
        dec: Angle.Degrees(+35.00464889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 226502"},
        {"Hipparcos Number", "HIP 97987"},
        {"Geneva Identification System", "GEN# +1.00226502"},
        {"Smithsonian Astrophysical Observation", "SAO 69070"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.70435522),
        dec: Angle.Degrees(+35.00556887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90090"},
        {"Hipparcos Number", "HIP 50968"},
        {"Smithsonian Astrophysical Observation", "SAO 62023"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.16053040),
        dec: Angle.Degrees(+35.00658534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144705"},
        {"Hipparcos Number", "HIP 78859"},
        {"Smithsonian Astrophysical Observation", "SAO 65076"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.46873510),
        dec: Angle.Degrees(+35.00664620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -252.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54706",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8085 AB"},
        {"Henry Draper", "HD 97254"},
        {"Hipparcos Number", "HIP 54706"},
        {"Smithsonian Astrophysical Observation", "SAO 62443"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.01113930),
        dec: Angle.Degrees(+35.00676179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63790",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63790"},
        {"Smithsonian Astrophysical Observation", "SAO 63327"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.11601397),
        dec: Angle.Degrees(+35.00718364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81973",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81973"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.18515196),
        dec: Angle.Degrees(+35.00734727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173689"},
        {"Hipparcos Number", "HIP 91997"},
        {"Celescope Catalog", "CEL 4649"},
        {"Geneva Identification System", "GEN# +1.00173689"},
        {"Smithsonian Astrophysical Observation", "SAO 67325"},
    },
    visualMagnitude: 7.18,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.26554171),
        dec: Angle.Degrees(+35.00841722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83921"},
        {"Hipparcos Number", "HIP 47614"},
        {"Geneva Identification System", "GEN# +1.00083921"},
        {"Smithsonian Astrophysical Observation", "SAO 61646"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.63041044),
        dec: Angle.Degrees(+35.00843352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70771"},
        {"Hipparcos Number", "HIP 41262"},
        {"Fundamental Katalog 5th Edition", "FK5 2652"},
        {"Geneva Identification System", "GEN# +1.00070771"},
        {"Smithsonian Astrophysical Observation", "SAO 60794"},
        {"Wilson Evans Batten Catalogue", "WEB 7983"},
    },
    visualMagnitude: 6.08,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.27039729),
        dec: Angle.Degrees(+35.01143577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2425",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2425"},
        {"Smithsonian Astrophysical Observation", "SAO 53948"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.72880136),
        dec: Angle.Degrees(+35.01245877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97242",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12900 A"},
        {"Henry Draper", "HD 186927"},
        {"Hipparcos Number", "HIP 97242"},
        {"Geneva Identification System", "GEN# +1.00186927A"},
        {"Smithsonian Astrophysical Observation", "SAO 68810"},
        {"Wilson Evans Batten Catalogue", "WEB 17077"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.46394910),
        dec: Angle.Degrees(+35.01276709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118177",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17136 AB"},
        {"Henry Draper", "HD 224492"},
        {"Hipparcos Number", "HIP 118177"},
        {"Smithsonian Astrophysical Observation", "SAO 73640"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.58807585),
        dec: Angle.Degrees(+35.01302304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221217"},
        {"Hipparcos Number", "HIP 115979"},
        {"Smithsonian Astrophysical Observation", "SAO 73299"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.46959647),
        dec: Angle.Degrees(+35.01403966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99887",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99887"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.99303753),
        dec: Angle.Degrees(+35.01473742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219308"},
        {"Hipparcos Number", "HIP 114738"},
        {"Smithsonian Astrophysical Observation", "SAO 73109"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.63704224),
        dec: Angle.Degrees(+35.01602415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41554"},
    },
    visualMagnitude: 10.76,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.09521021),
        dec: Angle.Degrees(+35.01725479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1014.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -328.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55918"},
        {"Hipparcos Number", "HIP 35198"},
        {"Geneva Identification System", "GEN# +1.00055918"},
        {"Smithsonian Astrophysical Observation", "SAO 59929"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.10592621),
        dec: Angle.Degrees(+35.01734903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17730",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2771 A"},
        {"Henry Draper", "HD 23606"},
        {"Hipparcos Number", "HIP 17730"},
        {"Geneva Identification System", "GEN# +1.00023606"},
        {"Smithsonian Astrophysical Observation", "SAO 56706"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.94731582),
        dec: Angle.Degrees(+35.01828333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144147"},
        {"Hipparcos Number", "HIP 78619"},
        {"Smithsonian Astrophysical Observation", "SAO 65043"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.75026333),
        dec: Angle.Degrees(+35.01912399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109645",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109645"},
        {"Smithsonian Astrophysical Observation", "SAO 72129"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.17377681),
        dec: Angle.Degrees(+35.02039859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28169"},
        {"Hipparcos Number", "HIP 20851"},
        {"Smithsonian Astrophysical Observation", "SAO 57243"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.01996092),
        dec: Angle.Degrees(+35.02052947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7343"},
        {"Hipparcos Number", "HIP 5782"},
        {"Smithsonian Astrophysical Observation", "SAO 54536"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.54264228),
        dec: Angle.Degrees(+35.02224368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185435"},
        {"Hipparcos Number", "HIP 96546"},
        {"Smithsonian Astrophysical Observation", "SAO 68596"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.42008887),
        dec: Angle.Degrees(+35.02256120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180350"},
        {"Hipparcos Number", "HIP 94566"},
        {"Geneva Identification System", "GEN# +1.00180350"},
        {"Smithsonian Astrophysical Observation", "SAO 68028"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.69083120),
        dec: Angle.Degrees(+35.02336850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76397"},
        {"Hipparcos Number", "HIP 43949"},
        {"Geneva Identification System", "GEN# +1.00076397"},
        {"Smithsonian Astrophysical Observation", "SAO 61148"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.27045395),
        dec: Angle.Degrees(+35.02340129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40785",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40785"},
        {"Smithsonian Astrophysical Observation", "SAO 60727"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.86539830),
        dec: Angle.Degrees(+35.02365833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98812"},
        {"Hipparcos Number", "HIP 55546"},
        {"Smithsonian Astrophysical Observation", "SAO 62519"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.66720291),
        dec: Angle.Degrees(+35.02621200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203922"},
        {"Hipparcos Number", "HIP 105671"},
        {"Renson", "Renson 56780"},
        {"Smithsonian Astrophysical Observation", "SAO 71284"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.05308330),
        dec: Angle.Degrees(+35.02651221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101073",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101073"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.34094477),
        dec: Angle.Degrees(+35.02753618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 226184"},
        {"Hipparcos Number", "HIP 97711"},
        {"Smithsonian Astrophysical Observation", "SAO 68970"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.86775686),
        dec: Angle.Degrees(+35.03102427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194820"},
        {"Hipparcos Number", "HIP 100827"},
        {"Smithsonian Astrophysical Observation", "SAO 70030"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.66093493),
        dec: Angle.Degrees(+35.03129930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189148"},
        {"Hipparcos Number", "HIP 98193"},
        {"Geneva Identification System", "GEN# +1.00189148"},
        {"Smithsonian Astrophysical Observation", "SAO 69146"},
        {"Wilson Evans Batten Catalogue", "WEB 17313"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.30552785),
        dec: Angle.Degrees(+35.03143981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116667",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16894 A"},
        {"Henry Draper", "HD 222221"},
        {"Hipparcos Number", "HIP 116667"},
        {"Renson", "Renson 60920"},
        {"Smithsonian Astrophysical Observation", "SAO 73398"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.64230527),
        dec: Angle.Degrees(+35.03330534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155179"},
        {"Hipparcos Number", "HIP 83872"},
        {"Smithsonian Astrophysical Observation", "SAO 65821"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.13210328),
        dec: Angle.Degrees(+35.03374847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51413"},
        {"Smithsonian Astrophysical Observation", "SAO 62075"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.51441921),
        dec: Angle.Degrees(+35.03470847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40267",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40267"},
    },
    visualMagnitude: 11.19,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.34358083),
        dec: Angle.Degrees(+35.03560634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2093"},
        {"Hipparcos Number", "HIP 1996"},
        {"Smithsonian Astrophysical Observation", "SAO 53876"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.32392862),
        dec: Angle.Degrees(+35.03725601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200531"},
        {"Hipparcos Number", "HIP 103888"},
        {"Geneva Identification System", "GEN# +1.00200531"},
        {"Smithsonian Astrophysical Observation", "SAO 70828"},
        {"Wilson Evans Batten Catalogue", "WEB 18919"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.74824195),
        dec: Angle.Degrees(+35.03751456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74226"},
        {"Hipparcos Number", "HIP 42856"},
        {"Smithsonian Astrophysical Observation", "SAO 61016"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.00151842),
        dec: Angle.Degrees(+35.03760094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62586",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62586"},
        {"Smithsonian Astrophysical Observation", "SAO 63211"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.36333657),
        dec: Angle.Degrees(+35.03893163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197176"},
        {"Hipparcos Number", "HIP 102049"},
        {"Geneva Identification System", "GEN# +1.00197176"},
        {"Smithsonian Astrophysical Observation", "SAO 70358"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.20848241),
        dec: Angle.Degrees(+35.04014119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14935"},
        {"Hipparcos Number", "HIP 11296"},
        {"Geneva Identification System", "GEN# +1.00014935"},
        {"Smithsonian Astrophysical Observation", "SAO 55537"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.36113241),
        dec: Angle.Degrees(+35.04192339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48736"},
        {"Hipparcos Number", "HIP 32446"},
        {"Smithsonian Astrophysical Observation", "SAO 59468"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.58295289),
        dec: Angle.Degrees(+35.04287859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201523"},
        {"Hipparcos Number", "HIP 104418"},
        {"Smithsonian Astrophysical Observation", "SAO 70976"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.28594736),
        dec: Angle.Degrees(+35.04348668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164842"},
        {"Hipparcos Number", "HIP 88273"},
        {"Geneva Identification System", "GEN# +1.00164842"},
        {"Smithsonian Astrophysical Observation", "SAO 66563"},
        {"Wilson Evans Batten Catalogue", "WEB 14920"},
    },
    visualMagnitude: 9.62,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.39160590),
        dec: Angle.Degrees(+35.04507058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20209"},
        {"Hipparcos Number", "HIP 15205"},
        {"Geneva Identification System", "GEN# +1.00020209"},
        {"Smithsonian Astrophysical Observation", "SAO 56297"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.00780077),
        dec: Angle.Degrees(+35.04527290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -154.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90776"},
        {"Smithsonian Astrophysical Observation", "SAO 67066"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.79851742),
        dec: Angle.Degrees(+35.04553782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69715"},
        {"Hipparcos Number", "HIP 40791"},
        {"Smithsonian Astrophysical Observation", "SAO 60729"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.88249616),
        dec: Angle.Degrees(+35.04568270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37204",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6229 A"},
        {"Henry Draper", "HD 60986"},
        {"Hipparcos Number", "HIP 37204"},
        {"Geneva Identification System", "GEN# +1.00060986"},
        {"Smithsonian Astrophysical Observation", "SAO 60243"},
        {"Wilson Evans Batten Catalogue", "WEB 7370"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.63681646),
        dec: Angle.Degrees(+35.04848403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110438"},
        {"Hipparcos Number", "HIP 61961"},
        {"Geneva Identification System", "GEN# +1.00110438"},
        {"Smithsonian Astrophysical Observation", "SAO 63141"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.47142769),
        dec: Angle.Degrees(+35.04934027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66411"},
        {"Geneva Identification System", "GEN# +0.03502469"},
        {"Smithsonian Astrophysical Observation", "SAO 63643"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.23169746),
        dec: Angle.Degrees(+35.05134175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22327"},
        {"Hipparcos Number", "HIP 16856"},
        {"Geneva Identification System", "GEN# +1.00022327"},
        {"Renson", "Renson 5630"},
        {"Smithsonian Astrophysical Observation", "SAO 56581"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.22886736),
        dec: Angle.Degrees(+35.05208802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223879"},
        {"Hipparcos Number", "HIP 117788"},
        {"Smithsonian Astrophysical Observation", "SAO 73587"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.30059959),
        dec: Angle.Degrees(+35.05242967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218366"},
        {"Hipparcos Number", "HIP 114147"},
        {"Smithsonian Astrophysical Observation", "SAO 73006"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.76029273),
        dec: Angle.Degrees(+35.05268671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66682",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66682"},
        {"Geneva Identification System", "GEN# +0.03502472"},
        {"Smithsonian Astrophysical Observation", "SAO 63675"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.04746923),
        dec: Angle.Degrees(+35.05314619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68522",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68522"},
    },
    visualMagnitude: 11.88,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.42439046),
        dec: Angle.Degrees(+35.05448232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -282.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -456.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53667"},
    },
    visualMagnitude: 11.13,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.70300037),
        dec: Angle.Degrees(+35.05507918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -363.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44128",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44128"},
        {"Smithsonian Astrophysical Observation", "SAO 61170"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.80744675),
        dec: Angle.Degrees(+35.05734128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75934"},
        {"Hipparcos Number", "HIP 43719"},
        {"Smithsonian Astrophysical Observation", "SAO 61122"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.55649062),
        dec: Angle.Degrees(+35.05940563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60296"},
        {"Hipparcos Number", "HIP 36904"},
        {"Smithsonian Astrophysical Observation", "SAO 60205"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.81348825),
        dec: Angle.Degrees(+35.05949632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26262"},
        {"Fundamental Katalog 5th Edition", "FK5 4505"},
        {"Smithsonian Astrophysical Observation", "SAO 58213"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.89737402),
        dec: Angle.Degrees(+35.05955670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50141",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50141"},
        {"Smithsonian Astrophysical Observation", "SAO 61941"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.53674297),
        dec: Angle.Degrees(+35.05979560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17709"},
        {"Hipparcos Number", "HIP 13328"},
        {"Fundamental Katalog 5th Edition", "FK5 2198"},
        {"Geneva Identification System", "GEN# +1.00017709"},
        {"Smithsonian Astrophysical Observation", "SAO 55946"},
        {"Wilson Evans Batten Catalogue", "WEB 2669"},
    },
    visualMagnitude: 4.56,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.87846216),
        dec: Angle.Degrees(+35.05989415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18196",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2834 AB"},
        {"Henry Draper", "HD 24321"},
        {"Hipparcos Number", "HIP 18196"},
        {"Geneva Identification System", "GEN# +1.00024321J"},
        {"Renson", "Renson 6270"},
        {"Smithsonian Astrophysical Observation", "SAO 56791"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.38541474),
        dec: Angle.Degrees(+35.06000639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106174",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15039 AB"},
        {"Henry Draper", "HD 204842"},
        {"Hipparcos Number", "HIP 106174"},
        {"Smithsonian Astrophysical Observation", "SAO 71407"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.58974815),
        dec: Angle.Degrees(+35.06124139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229087"},
        {"Hipparcos Number", "HIP 100418"},
        {"Smithsonian Astrophysical Observation", "SAO 69897"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.43507232),
        dec: Angle.Degrees(+35.06184638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27738"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.08613031),
        dec: Angle.Degrees(+35.06215039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46072"},
        {"Hipparcos Number", "HIP 31200"},
        {"Geneva Identification System", "GEN# +1.00046072"},
        {"Smithsonian Astrophysical Observation", "SAO 59203"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.18770534),
        dec: Angle.Degrees(+35.06296458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114495"},
        {"Smithsonian Astrophysical Observation", "SAO 73066"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.83752178),
        dec: Angle.Degrees(+35.06487591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70578",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70578"},
    },
    visualMagnitude: 11.25,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.54831879),
        dec: Angle.Degrees(+35.06715419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113979",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113979"},
        {"Smithsonian Astrophysical Observation", "SAO 72983"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.24934684),
        dec: Angle.Degrees(+35.06727419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49499"},
        {"Hipparcos Number", "HIP 32794"},
        {"Geneva Identification System", "GEN# +1.00049499"},
        {"Smithsonian Astrophysical Observation", "SAO 59530"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.55181487),
        dec: Angle.Degrees(+35.06853472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43426",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7034 AB"},
        {"Henry Draper", "HD 75353"},
        {"Hipparcos Number", "HIP 43426"},
        {"Smithsonian Astrophysical Observation", "SAO 61077"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.68490125),
        dec: Angle.Degrees(+35.07069302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 114.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216192"},
        {"Hipparcos Number", "HIP 112775"},
        {"Geneva Identification System", "GEN# +1.00216192"},
        {"Smithsonian Astrophysical Observation", "SAO 72768"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.58206586),
        dec: Angle.Degrees(+35.07194559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150430"},
        {"Hipparcos Number", "HIP 81576"},
        {"Smithsonian Astrophysical Observation", "SAO 65465"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.90225494),
        dec: Angle.Degrees(+35.07214663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197604"},
        {"Hipparcos Number", "HIP 102292"},
        {"Geneva Identification System", "GEN# +1.00197604"},
        {"Wilson Evans Batten Catalogue", "WEB 18521"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.89575539),
        dec: Angle.Degrees(+35.07296717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225519"},
        {"Hipparcos Number", "HIP 97054"},
        {"Smithsonian Astrophysical Observation", "SAO 68759"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.86895248),
        dec: Angle.Degrees(+35.07443013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37268"},
        {"Hipparcos Number", "HIP 26560"},
        {"Geneva Identification System", "GEN# +1.00037268"},
        {"Smithsonian Astrophysical Observation", "SAO 58283"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.71890721),
        dec: Angle.Degrees(+35.07811263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208473"},
        {"Hipparcos Number", "HIP 108235"},
        {"Geneva Identification System", "GEN# +1.00208473"},
        {"Smithsonian Astrophysical Observation", "SAO 71846"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.90643328),
        dec: Angle.Degrees(+35.07924761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24640"},
        {"Hipparcos Number", "HIP 18434"},
        {"Celescope Catalog", "CEL 372"},
        {"Geneva Identification System", "GEN# +1.00024640"},
        {"Smithsonian Astrophysical Observation", "SAO 56824"},
        {"Wilson Evans Batten Catalogue", "WEB 3553"},
    },
    visualMagnitude: 5.49,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.11953366),
        dec: Angle.Degrees(+35.08090840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123962"},
        {"Hipparcos Number", "HIP 69193"},
        {"Geneva Identification System", "GEN# +1.00123962"},
        {"Smithsonian Astrophysical Observation", "SAO 63963"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.48557380),
        dec: Angle.Degrees(+35.08183853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91081",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91081"},
        {"Smithsonian Astrophysical Observation", "SAO 67128"},
    },
    visualMagnitude: 11.02,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.66779651),
        dec: Angle.Degrees(+35.08269257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12096"},
        {"Geneva Identification System", "GEN# +0.03400470"},
        {"Smithsonian Astrophysical Observation", "SAO 55689"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.97142609),
        dec: Angle.Degrees(+35.08330256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98110",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13149 A"},
        {"Henry Draper", "HD 188947"},
        {"Hipparcos Number", "HIP 98110"},
        {"Fundamental Katalog 5th Edition", "FK5 1521"},
        {"Geneva Identification System", "GEN# +1.00188947J"},
        {"Smithsonian Astrophysical Observation", "SAO 69116"},
        {"Wilson Evans Batten Catalogue", "WEB 17290"},
    },
    visualMagnitude: 3.89,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.07665069),
        dec: Angle.Degrees(+35.08349079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76347",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76347"},
        {"Fundamental Katalog 5th Edition", "FK5 5378"},
        {"Smithsonian Astrophysical Observation", "SAO 64795"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.90981154),
        dec: Angle.Degrees(+35.08360097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19686"},
        {"Hipparcos Number", "HIP 14822"},
        {"Geneva Identification System", "GEN# +1.00019686"},
        {"Smithsonian Astrophysical Observation", "SAO 56227"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.84327037),
        dec: Angle.Degrees(+35.08581761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110134"},
        {"Hipparcos Number", "HIP 61779"},
        {"Geneva Identification System", "GEN# +1.00110134"},
        {"Smithsonian Astrophysical Observation", "SAO 63124"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.93773461),
        dec: Angle.Degrees(+35.08696286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83951"},
        {"Hipparcos Number", "HIP 47631"},
        {"Fundamental Katalog 5th Edition", "FK5 2776"},
        {"Geneva Identification System", "GEN# +1.00083951"},
        {"Smithsonian Astrophysical Observation", "SAO 61648"},
        {"Wilson Evans Batten Catalogue", "WEB 8926"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.67814044),
        dec: Angle.Degrees(+35.09349974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91346",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91346"},
        {"Smithsonian Astrophysical Observation", "SAO 67185"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.47253780),
        dec: Angle.Degrees(+35.09579601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38644"},
        {"Smithsonian Astrophysical Observation", "SAO 60432"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.69296514),
        dec: Angle.Degrees(+35.09787457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24012"},
        {"Hipparcos Number", "HIP 17998"},
        {"Geneva Identification System", "GEN# +1.00024012"},
        {"Smithsonian Astrophysical Observation", "SAO 56741"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.71371691),
        dec: Angle.Degrees(+35.09978966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132753"},
        {"Hipparcos Number", "HIP 73380"},
        {"Geneva Identification System", "GEN# +1.00132753"},
        {"Smithsonian Astrophysical Observation", "SAO 64450"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.93133840),
        dec: Angle.Degrees(+35.10092365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169357"},
        {"Hipparcos Number", "HIP 90063"},
        {"Geneva Identification System", "GEN# +1.00169357"},
        {"Smithsonian Astrophysical Observation", "SAO 66919"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.68856757),
        dec: Angle.Degrees(+35.10128726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183970"},
        {"Hipparcos Number", "HIP 95938"},
        {"Geneva Identification System", "GEN# +1.00183970"},
        {"Smithsonian Astrophysical Observation", "SAO 68414"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.66657655),
        dec: Angle.Degrees(+35.10237977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87260"},
        {"Hipparcos Number", "HIP 49358"},
        {"Smithsonian Astrophysical Observation", "SAO 61843"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.14182853),
        dec: Angle.Degrees(+35.10339949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82198"},
        {"Hipparcos Number", "HIP 46735"},
        {"Geneva Identification System", "GEN# +1.00082198"},
        {"Smithsonian Astrophysical Observation", "SAO 61540"},
        {"Wilson Evans Batten Catalogue", "WEB 8814"},
    },
    visualMagnitude: 5.39,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.88520681),
        dec: Angle.Degrees(+35.10350902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191291"},
        {"Hipparcos Number", "HIP 99164"},
        {"Celescope Catalog", "CEL 4941"},
        {"Geneva Identification System", "GEN# +1.00191291"},
        {"Smithsonian Astrophysical Observation", "SAO 69469"},
        {"Wilson Evans Batten Catalogue", "WEB 17650"},
    },
    visualMagnitude: 8.12,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.98130936),
        dec: Angle.Degrees(+35.10484630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73377",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73377"},
    },
    visualMagnitude: 12.12,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.92464822),
        dec: Angle.Degrees(+35.10523267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79144"},
        {"Hipparcos Number", "HIP 45258"},
        {"Smithsonian Astrophysical Observation", "SAO 61336"},
    },
    visualMagnitude: 8.53,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.35559288),
        dec: Angle.Degrees(+35.10603035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86846"},
        {"Smithsonian Astrophysical Observation", "SAO 66297"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.17499287),
        dec: Angle.Degrees(+35.10624800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35940"},
        {"Hipparcos Number", "HIP 25735"},
        {"Smithsonian Astrophysical Observation", "SAO 58108"},
        {"Wilson Evans Batten Catalogue", "WEB 4994"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.43181359),
        dec: Angle.Degrees(+35.10878950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65012",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8861 B"},
        {"Hipparcos Number", "HIP 65012"},
        {"Geneva Identification System", "GEN# +0.03502436B"},
    },
    visualMagnitude: 12.03,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.89345734),
        dec: Angle.Degrees(+35.10894812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 380.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -783.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66914",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66914"},
        {"Geneva Identification System", "GEN# +0.03502475"},
        {"Smithsonian Astrophysical Observation", "SAO 63702"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.69858272),
        dec: Angle.Degrees(+35.10901966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212488"},
        {"Hipparcos Number", "HIP 110571"},
        {"Smithsonian Astrophysical Observation", "SAO 72298"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.99204536),
        dec: Angle.Degrees(+35.10907646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7086"},
        {"Hipparcos Number", "HIP 5584"},
        {"Geneva Identification System", "GEN# +1.00007086"},
        {"Smithsonian Astrophysical Observation", "SAO 54499"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.90858087),
        dec: Angle.Degrees(+35.11056917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9585"},
        {"Hipparcos Number", "HIP 7344"},
        {"Smithsonian Astrophysical Observation", "SAO 54793"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.65516093),
        dec: Angle.Degrees(+35.11176144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85426"},
        {"Hipparcos Number", "HIP 48443"},
        {"Cincinnati Publication", "Ci 18 1170"},
        {"Geneva Identification System", "GEN# +1.00085426"},
        {"Smithsonian Astrophysical Observation", "SAO 61731"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.15975079),
        dec: Angle.Degrees(+35.11201918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 264.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65011",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8861 A"},
        {"Hipparcos Number", "HIP 65011"},
        {"Cincinnati Publication", "Ci 18 1719"},
        {"Cincinnati Publication 2", "Ci 20 771"},
        {"Geneva Identification System", "GEN# +0.03502436A"},
        {"Smithsonian Astrophysical Observation", "SAO 63473"},
        {"Wilson Evans Batten Catalogue", "WEB 11486"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.88881477),
        dec: Angle.Degrees(+35.11204745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 387.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -778.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116474",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116474"},
        {"Smithsonian Astrophysical Observation", "SAO 73365"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.01447005),
        dec: Angle.Degrees(+35.11358398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215090"},
        {"Hipparcos Number", "HIP 112089"},
        {"Smithsonian Astrophysical Observation", "SAO 72639"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.54973528),
        dec: Angle.Degrees(+35.11426665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110305",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15848 A"},
        {"Henry Draper", "HD 212003"},
        {"Hipparcos Number", "HIP 110305"},
        {"Geneva Identification System", "GEN# +1.00212003"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.13003432),
        dec: Angle.Degrees(+35.11481991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12776",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2084 A"},
        {"Henry Draper", "HD 16968"},
        {"Hipparcos Number", "HIP 12776"},
        {"Smithsonian Astrophysical Observation", "SAO 55824"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.04781773),
        dec: Angle.Degrees(+35.11501070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87617"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.47884775),
        dec: Angle.Degrees(+35.11677593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176376"},
        {"Hipparcos Number", "HIP 93153"},
        {"Smithsonian Astrophysical Observation", "SAO 67656"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.62547268),
        dec: Angle.Degrees(+35.11730216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110301",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15848 B"},
        {"Hipparcos Number", "HIP 110301"},
        {"Smithsonian Astrophysical Observation", "SAO 72247"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.12132003),
        dec: Angle.Degrees(+35.11755698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8030"},
        {"Hipparcos Number", "HIP 6255"},
        {"Geneva Identification System", "GEN# +1.00008030"},
        {"Smithsonian Astrophysical Observation", "SAO 54610"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.05868618),
        dec: Angle.Degrees(+35.12214348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91768"},
        {"Hipparcos Number", "HIP 51917"},
        {"Fundamental Katalog 5th Edition", "FK5 4943"},
        {"Smithsonian Astrophysical Observation", "SAO 62148"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.09408602),
        dec: Angle.Degrees(+35.12244317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19232"},
        {"Hipparcos Number", "HIP 14480"},
        {"Smithsonian Astrophysical Observation", "SAO 56164"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.71831251),
        dec: Angle.Degrees(+35.12385176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86202"},
        {"Hipparcos Number", "HIP 48851"},
        {"Smithsonian Astrophysical Observation", "SAO 61779"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.45657378),
        dec: Angle.Degrees(+35.12451753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79353",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79353"},
        {"Smithsonian Astrophysical Observation", "SAO 65130"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.93038548),
        dec: Angle.Degrees(+35.12468003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63388"},
        {"Geneva Identification System", "GEN# +0.03502388"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.83781357),
        dec: Angle.Degrees(+35.12647268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -154.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64979",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8861 D"},
        {"Henry Draper", "HD 115810"},
        {"Hipparcos Number", "HIP 64979"},
        {"Fundamental Katalog 5th Edition", "FK5 3064"},
        {"Geneva Identification System", "GEN# +1.00115810"},
        {"Smithsonian Astrophysical Observation", "SAO 63468"},
        {"Wilson Evans Batten Catalogue", "WEB 11483"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.76780333),
        dec: Angle.Degrees(+35.12793546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152814"},
        {"Hipparcos Number", "HIP 82700"},
        {"Geneva Identification System", "GEN# +1.00152814"},
        {"Smithsonian Astrophysical Observation", "SAO 65642"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.57481556),
        dec: Angle.Degrees(+35.12818502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79309",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79309"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.78883084),
        dec: Angle.Degrees(+35.12863267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210388"},
        {"Hipparcos Number", "HIP 109361"},
        {"Geneva Identification System", "GEN# +1.00210388"},
        {"Smithsonian Astrophysical Observation", "SAO 72067"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.34355245),
        dec: Angle.Degrees(+35.12938837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18345",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2857 AB"},
        {"Henry Draper", "HD 279171"},
        {"Hipparcos Number", "HIP 18345"},
        {"Geneva Identification System", "GEN# +1.00279171J"},
        {"Smithsonian Astrophysical Observation", "SAO 56812"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.83077922),
        dec: Angle.Degrees(+35.13119763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191047"},
        {"Hipparcos Number", "HIP 99049"},
        {"Geneva Identification System", "GEN# +1.00191047"},
        {"Smithsonian Astrophysical Observation", "SAO 69421"},
        {"Wilson Evans Batten Catalogue", "WEB 17609"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.64748511),
        dec: Angle.Degrees(+35.13206233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9815"},
        {"Hipparcos Number", "HIP 7490"},
        {"Geneva Identification System", "GEN# +1.00009815"},
        {"Smithsonian Astrophysical Observation", "SAO 54827"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.10735575),
        dec: Angle.Degrees(+35.13402727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31551"},
        {"Hipparcos Number", "HIP 23107"},
        {"Smithsonian Astrophysical Observation", "SAO 57538"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.58032015),
        dec: Angle.Degrees(+35.13547207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89762"},
        {"Smithsonian Astrophysical Observation", "SAO 66850"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.76490818),
        dec: Angle.Degrees(+35.13895083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32723",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32723"},
        {"Geneva Identification System", "GEN# +9.80087009"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.39891451),
        dec: Angle.Degrees(+35.14130669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -309.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65541",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8902 AB"},
        {"Hipparcos Number", "HIP 65541"},
        {"Geneva Identification System", "GEN# +0.03502450J"},
        {"Smithsonian Astrophysical Observation", "SAO 63538"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.53691812),
        dec: Angle.Degrees(+35.14317040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44695"},
        {"Hipparcos Number", "HIP 30499"},
        {"Geneva Identification System", "GEN# +1.00044695"},
        {"Smithsonian Astrophysical Observation", "SAO 59051"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.17653788),
        dec: Angle.Degrees(+35.14512774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228379"},
        {"Hipparcos Number", "HIP 99657"},
        {"Smithsonian Astrophysical Observation", "SAO 69632"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.35119151),
        dec: Angle.Degrees(+35.14556367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6554"},
        {"Hipparcos Number", "HIP 5226"},
        {"Smithsonian Astrophysical Observation", "SAO 54431"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.69855291),
        dec: Angle.Degrees(+35.14566078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57338"},
        {"Smithsonian Astrophysical Observation", "SAO 62691"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.34883667),
        dec: Angle.Degrees(+35.14702379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95101",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95101"},
        {"Smithsonian Astrophysical Observation", "SAO 68178"},
    },
    visualMagnitude: 9.11,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.21310357),
        dec: Angle.Degrees(+35.14754676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96759",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12776 A"},
        {"Henry Draper", "HD 185913"},
        {"Hipparcos Number", "HIP 96759"},
        {"Celescope Catalog", "CEL 4815"},
        {"Geneva Identification System", "GEN# +1.00185913"},
        {"Smithsonian Astrophysical Observation", "SAO 68665"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.02872281),
        dec: Angle.Degrees(+35.14780729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52873",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52873"},
        {"Smithsonian Astrophysical Observation", "SAO 62263"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.19208544),
        dec: Angle.Degrees(+35.14824047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43382"},
        {"Hipparcos Number", "HIP 29882"},
        {"Geneva Identification System", "GEN# +1.00043382"},
        {"Smithsonian Astrophysical Observation", "SAO 58944"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.39038216),
        dec: Angle.Degrees(+35.14909924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79745"},
        {"Hipparcos Number", "HIP 45539"},
        {"Smithsonian Astrophysical Observation", "SAO 61377"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.22763921),
        dec: Angle.Degrees(+35.14914657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15894"},
        {"Hipparcos Number", "HIP 11959"},
        {"Smithsonian Astrophysical Observation", "SAO 55667"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.57354586),
        dec: Angle.Degrees(+35.15020743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117137"},
        {"Hipparcos Number", "HIP 65666"},
        {"Geneva Identification System", "GEN# +1.00117137"},
        {"Smithsonian Astrophysical Observation", "SAO 63554"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.94783628),
        dec: Angle.Degrees(+35.15330809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10569",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10569"},
        {"Smithsonian Astrophysical Observation", "SAO 55398"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.00995757),
        dec: Angle.Degrees(+35.15616502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56563"},
        {"Hipparcos Number", "HIP 35440"},
        {"Geneva Identification System", "GEN# +1.00056563"},
        {"Smithsonian Astrophysical Observation", "SAO 59975"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.75272619),
        dec: Angle.Degrees(+35.15787323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4988",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4988"},
        {"Smithsonian Astrophysical Observation", "SAO 54386"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.98554909),
        dec: Angle.Degrees(+35.15806327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29998"},
        {"Hipparcos Number", "HIP 22092"},
        {"Geneva Identification System", "GEN# +1.00029998"},
        {"Smithsonian Astrophysical Observation", "SAO 57407"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.30134230),
        dec: Angle.Degrees(+35.15821661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27380",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4377 A"},
        {"Henry Draper", "HD 38503"},
        {"Hipparcos Number", "HIP 27380"},
        {"Geneva Identification System", "GEN# +1.00038503J"},
        {"Smithsonian Astrophysical Observation", "SAO 58442"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.98467213),
        dec: Angle.Degrees(+35.15927999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136096"},
        {"Hipparcos Number", "HIP 74833"},
        {"Smithsonian Astrophysical Observation", "SAO 64614"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.40512999),
        dec: Angle.Degrees(+35.15964928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16285"},
        {"Hipparcos Number", "HIP 12259"},
        {"Geneva Identification System", "GEN# +1.00016285"},
        {"Smithsonian Astrophysical Observation", "SAO 55723"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.46077498),
        dec: Angle.Degrees(+35.16094351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13287",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13287"},
    },
    visualMagnitude: 10.06,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.75678498),
        dec: Angle.Degrees(+35.16122026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56155",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56155"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.66646777),
        dec: Angle.Degrees(+35.16396444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59014"},
        {"Hipparcos Number", "HIP 36412"},
        {"Smithsonian Astrophysical Observation", "SAO 60126"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.37884385),
        dec: Angle.Degrees(+35.16404795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88924"},
        {"Hipparcos Number", "HIP 50293"},
        {"Smithsonian Astrophysical Observation", "SAO 61959"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.03907932),
        dec: Angle.Degrees(+35.16452106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155922"},
        {"Hipparcos Number", "HIP 84225"},
        {"Smithsonian Astrophysical Observation", "SAO 65872"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.24028712),
        dec: Angle.Degrees(+35.16462204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86130"},
        {"Hipparcos Number", "HIP 48814"},
        {"Smithsonian Astrophysical Observation", "SAO 61777"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.35598149),
        dec: Angle.Degrees(+35.16489530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25644"},
        {"Hipparcos Number", "HIP 19090"},
        {"Smithsonian Astrophysical Observation", "SAO 56959"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.40247881),
        dec: Angle.Degrees(+35.16520035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92747"},
        {"Hipparcos Number", "HIP 52432"},
        {"Geneva Identification System", "GEN# +1.00092747"},
        {"Smithsonian Astrophysical Observation", "SAO 62215"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.77890447),
        dec: Angle.Degrees(+35.16531012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99235"},
        {"Hipparcos Number", "HIP 55755"},
        {"Geneva Identification System", "GEN# +1.00099235"},
        {"Smithsonian Astrophysical Observation", "SAO 62548"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.36599074),
        dec: Angle.Degrees(+35.16645118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203885"},
        {"Hipparcos Number", "HIP 105651"},
        {"Geneva Identification System", "GEN# +1.00203885"},
        {"Smithsonian Astrophysical Observation", "SAO 71282"},
    },
    visualMagnitude: 9.26,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.99211686),
        dec: Angle.Degrees(+35.16652240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110133",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110133"},
        {"Smithsonian Astrophysical Observation", "SAO 72225"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.63689596),
        dec: Angle.Degrees(+35.16662692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138407"},
        {"Hipparcos Number", "HIP 75947"},
        {"Smithsonian Astrophysical Observation", "SAO 64743"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.67563992),
        dec: Angle.Degrees(+35.16882799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39725"},
        {"Hipparcos Number", "HIP 28065"},
        {"Smithsonian Astrophysical Observation", "SAO 58579"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.00481060),
        dec: Angle.Degrees(+35.16924795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35834",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6025 A"},
        {"Henry Draper", "HD 57587"},
        {"Hipparcos Number", "HIP 35834"},
        {"Smithsonian Astrophysical Observation", "SAO 60035"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.84481435),
        dec: Angle.Degrees(+35.16929120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166729"},
        {"Hipparcos Number", "HIP 89045"},
        {"Geneva Identification System", "GEN# +1.00166729"},
        {"Smithsonian Astrophysical Observation", "SAO 66713"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.61384908),
        dec: Angle.Degrees(+35.17172551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58385"},
        {"Geneva Identification System", "GEN# +0.03502298"},
        {"Smithsonian Astrophysical Observation", "SAO 62777"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.57801396),
        dec: Angle.Degrees(+35.17283421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37744",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37744"},
        {"Smithsonian Astrophysical Observation", "SAO 60308"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.12340812),
        dec: Angle.Degrees(+35.17380187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103505",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103505"},
        {"Wilson Evans Batten Catalogue", "WEB 18827"},
    },
    visualMagnitude: 9.99,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.55603510),
        dec: Angle.Degrees(+35.17494361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88921"},
        {"Smithsonian Astrophysical Observation", "SAO 66683"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.26180405),
        dec: Angle.Degrees(+35.17505751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138246"},
        {"Hipparcos Number", "HIP 75862"},
        {"Geneva Identification System", "GEN# +1.00138246"},
        {"Smithsonian Astrophysical Observation", "SAO 64728"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.43579942),
        dec: Angle.Degrees(+35.17531938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1178"},
        {"Hipparcos Number", "HIP 1297"},
        {"Smithsonian Astrophysical Observation", "SAO 53767"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.06050132),
        dec: Angle.Degrees(+35.17799696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 132.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192260"},
        {"Hipparcos Number", "HIP 99596"},
        {"Geneva Identification System", "GEN# +1.00192260"},
        {"Smithsonian Astrophysical Observation", "SAO 69608"},
        {"Wilson Evans Batten Catalogue", "WEB 17831"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.18060571),
        dec: Angle.Degrees(+35.17800457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34751"},
        {"Smithsonian Astrophysical Observation", "SAO 59871"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.91226388),
        dec: Angle.Degrees(+35.17826849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17530"},
        {"Hipparcos Number", "HIP 13191"},
        {"Geneva Identification System", "GEN# +1.00017530"},
        {"Smithsonian Astrophysical Observation", "SAO 55914"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.43349567),
        dec: Angle.Degrees(+35.17866857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183185"},
        {"Hipparcos Number", "HIP 95621"},
        {"Smithsonian Astrophysical Observation", "SAO 68323"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.73836846),
        dec: Angle.Degrees(+35.17898841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208005"},
        {"Hipparcos Number", "HIP 107980"},
        {"Smithsonian Astrophysical Observation", "SAO 71789"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.13140609),
        dec: Angle.Degrees(+35.18008244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7179"},
        {"Hipparcos Number", "HIP 5652"},
        {"Geneva Identification System", "GEN# +1.00007179"},
        {"Smithsonian Astrophysical Observation", "SAO 54510"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.15439456),
        dec: Angle.Degrees(+35.18071300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22480"},
        {"Hipparcos Number", "HIP 16957"},
        {"Geneva Identification System", "GEN# +1.00022480"},
        {"Smithsonian Astrophysical Observation", "SAO 56596"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.53434564),
        dec: Angle.Degrees(+35.18121617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54001",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54001"},
    },
    visualMagnitude: 11.93,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.70887701),
        dec: Angle.Degrees(+35.18276038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18449"},
        {"Hipparcos Number", "HIP 13905"},
        {"Fundamental Katalog 5th Edition", "FK5 1082"},
        {"Geneva Identification System", "GEN# +1.00018449"},
        {"Smithsonian Astrophysical Observation", "SAO 56052"},
        {"Wilson Evans Batten Catalogue", "WEB 2744"},
    },
    visualMagnitude: 4.94,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.76545740),
        dec: Angle.Degrees(+35.18311415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178972"},
        {"Hipparcos Number", "HIP 94096"},
        {"Fundamental Katalog 5th Edition", "FK5 5683"},
        {"Smithsonian Astrophysical Observation", "SAO 67884"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.32301107),
        dec: Angle.Degrees(+35.18503323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181828"},
        {"Hipparcos Number", "HIP 95067"},
        {"Celescope Catalog", "CEL 4739"},
        {"Fundamental Katalog 5th Edition", "FK5 3545"},
        {"Geneva Identification System", "GEN# +1.00181828"},
        {"Smithsonian Astrophysical Observation", "SAO 68164"},
        {"Wilson Evans Batten Catalogue", "WEB 16604"},
    },
    visualMagnitude: 6.30,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.13771445),
        dec: Angle.Degrees(+35.18595454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111050"},
        {"Smithsonian Astrophysical Observation", "SAO 72401"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.46185041),
        dec: Angle.Degrees(+35.18843919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205572"},
        {"Hipparcos Number", "HIP 106589"},
        {"Smithsonian Astrophysical Observation", "SAO 71487"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.81338973),
        dec: Angle.Degrees(+35.18914033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57835",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57835"},
        {"Geneva Identification System", "GEN# +0.03502288"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.90511966),
        dec: Angle.Degrees(+35.19048656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130849"},
        {"Hipparcos Number", "HIP 72495"},
        {"Smithsonian Astrophysical Observation", "SAO 64346"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.35568801),
        dec: Angle.Degrees(+35.19206884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113252",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113252"},
        {"Smithsonian Astrophysical Observation", "SAO 72857"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.99993783),
        dec: Angle.Degrees(+35.19572418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30923"},
        {"Smithsonian Astrophysical Observation", "SAO 59138"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.34901687),
        dec: Angle.Degrees(+35.19673821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167349"},
        {"Hipparcos Number", "HIP 89296"},
        {"Geneva Identification System", "GEN# +1.00167349"},
        {"Smithsonian Astrophysical Observation", "SAO 66768"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.31783906),
        dec: Angle.Degrees(+35.19694956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35364"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.57682945),
        dec: Angle.Degrees(+35.19773567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94793"},
        {"Hipparcos Number", "HIP 53525"},
        {"Smithsonian Astrophysical Observation", "SAO 62324"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.26939363),
        dec: Angle.Degrees(+35.19831785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68126"},
        {"Geneva Identification System", "GEN# +0.03502508"},
        {"Smithsonian Astrophysical Observation", "SAO 63849"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.20123258),
        dec: Angle.Degrees(+35.19851818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146167"},
        {"Hipparcos Number", "HIP 79501"},
        {"Smithsonian Astrophysical Observation", "SAO 65158"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.35546424),
        dec: Angle.Degrees(+35.19902791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196689"},
        {"Hipparcos Number", "HIP 101784"},
        {"Smithsonian Astrophysical Observation", "SAO 70301"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.42847020),
        dec: Angle.Degrees(+35.19980790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69767"},
        {"Hipparcos Number", "HIP 40814"},
        {"Geneva Identification System", "GEN# +1.00069767"},
        {"Smithsonian Astrophysical Observation", "SAO 60731"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.94820148),
        dec: Angle.Degrees(+35.20133264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96162"},
        {"Hipparcos Number", "HIP 54239"},
        {"Smithsonian Astrophysical Observation", "SAO 62403"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.45680990),
        dec: Angle.Degrees(+35.20155536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 226868"},
        {"Hipparcos Number", "HIP 98298"},
        {"Geneva Identification System", "GEN# +1.00226868"},
        {"Smithsonian Astrophysical Observation", "SAO 69181"},
        {"Wilson Evans Batten Catalogue", "WEB 17338"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.59032641),
        dec: Angle.Degrees(+35.20162271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184294"},
        {"Hipparcos Number", "HIP 96098"},
        {"Smithsonian Astrophysical Observation", "SAO 68459"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.08016705),
        dec: Angle.Degrees(+35.20172326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148882"},
        {"Hipparcos Number", "HIP 80787"},
        {"Smithsonian Astrophysical Observation", "SAO 65339"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.43799459),
        dec: Angle.Degrees(+35.20191405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133392"},
        {"Hipparcos Number", "HIP 73634"},
        {"Fundamental Katalog 5th Edition", "FK5 3191"},
        {"Geneva Identification System", "GEN# +1.00133392"},
        {"Smithsonian Astrophysical Observation", "SAO 64476"},
        {"Wilson Evans Batten Catalogue", "WEB 12591"},
    },
    visualMagnitude: 5.52,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.77534828),
        dec: Angle.Degrees(+35.20577288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43644"},
        {"Hipparcos Number", "HIP 30002"},
        {"Fundamental Katalog 5th Edition", "FK5 4573"},
        {"Geneva Identification System", "GEN# +1.00043644"},
        {"Smithsonian Astrophysical Observation", "SAO 58975"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.72441812),
        dec: Angle.Degrees(+35.20803939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44244",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44244"},
        {"Smithsonian Astrophysical Observation", "SAO 61194"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.15796888),
        dec: Angle.Degrees(+35.21311568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185118"},
        {"Hipparcos Number", "HIP 96415"},
        {"Geneva Identification System", "GEN# +1.00185118"},
        {"Smithsonian Astrophysical Observation", "SAO 68560"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.03106041),
        dec: Angle.Degrees(+35.21365289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41479"},
        {"Hipparcos Number", "HIP 28997"},
        {"Geneva Identification System", "GEN# +1.00041479"},
        {"Smithsonian Astrophysical Observation", "SAO 58756"},
        {"Wilson Evans Batten Catalogue", "WEB 5676"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.77809872),
        dec: Angle.Degrees(+35.21371697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210513"},
        {"Hipparcos Number", "HIP 109418"},
        {"Smithsonian Astrophysical Observation", "SAO 72083"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.52733505),
        dec: Angle.Degrees(+35.21394765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114895"},
        {"Smithsonian Astrophysical Observation", "SAO 73127"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.09196934),
        dec: Angle.Degrees(+35.21408050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 227.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 280067"},
        {"Hipparcos Number", "HIP 21767"},
        {"Smithsonian Astrophysical Observation", "SAO 57369"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.12579477),
        dec: Angle.Degrees(+35.21572429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27716"},
        {"Hipparcos Number", "HIP 20534"},
        {"Geneva Identification System", "GEN# +1.00027716"},
        {"Smithsonian Astrophysical Observation", "SAO 57206"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.99914203),
        dec: Angle.Degrees(+35.21587840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161583"},
        {"Hipparcos Number", "HIP 86859"},
        {"Geneva Identification System", "GEN# +1.00161583"},
        {"Smithsonian Astrophysical Observation", "SAO 66299"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.20737873),
        dec: Angle.Degrees(+35.21763738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89892"},
        {"Hipparcos Number", "HIP 50857"},
        {"Smithsonian Astrophysical Observation", "SAO 62009"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.77219280),
        dec: Angle.Degrees(+35.21763899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10789",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10789"},
    },
    visualMagnitude: 11.75,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.72704787),
        dec: Angle.Degrees(+35.21831866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 199.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47997"},
        {"Smithsonian Astrophysical Observation", "SAO 61681"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.76026373),
        dec: Angle.Degrees(+35.21928133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53176",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53176"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.16751464),
        dec: Angle.Degrees(+35.22135975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43667"},
        {"Geneva Identification System", "GEN# +0.03501890"},
        {"Smithsonian Astrophysical Observation", "SAO 61115"},
        {"Wilson Evans Batten Catalogue", "WEB 8409"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.44748165),
        dec: Angle.Degrees(+35.22287150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -196.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -287.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149084"},
        {"Hipparcos Number", "HIP 80888"},
        {"Fundamental Katalog 5th Edition", "FK5 3308"},
        {"Geneva Identification System", "GEN# +1.00149084"},
        {"Smithsonian Astrophysical Observation", "SAO 65356"},
        {"Wilson Evans Batten Catalogue", "WEB 13680"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.76162298),
        dec: Angle.Degrees(+35.22510682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63253"},
        {"Geneva Identification System", "GEN# +0.03602322A"},
        {"Wilson Evans Batten Catalogue", "WEB 11211"},
    },
    visualMagnitude: 10.57,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.41853629),
        dec: Angle.Degrees(+35.22541982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -263.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279527"},
        {"Hipparcos Number", "HIP 19534"},
        {"Smithsonian Astrophysical Observation", "SAO 57048"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.77027766),
        dec: Angle.Degrees(+35.22589280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81470",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81470"},
        {"Smithsonian Astrophysical Observation", "SAO 65449"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.60052769),
        dec: Angle.Degrees(+35.22625004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66310",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66310"},
        {"Geneva Identification System", "GEN# +0.03502465"},
        {"Renson", "Renson 34137"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.84901200),
        dec: Angle.Degrees(+35.22753425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103120",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14404 AB"},
        {"Henry Draper", "HD 199071"},
        {"Hipparcos Number", "HIP 103120"},
        {"Smithsonian Astrophysical Observation", "SAO 70638"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.39749606),
        dec: Angle.Degrees(+35.22793387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5397"},
        {"Hipparcos Number", "HIP 4390"},
        {"Smithsonian Astrophysical Observation", "SAO 54277"},
        {"Wilson Evans Batten Catalogue", "WEB 784"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.06166113),
        dec: Angle.Degrees(+35.22864018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37867"},
        {"Hipparcos Number", "HIP 26952"},
        {"Geneva Identification System", "GEN# +1.00037867"},
        {"Smithsonian Astrophysical Observation", "SAO 58362"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.78809890),
        dec: Angle.Degrees(+35.23086490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7560"},
        {"Hipparcos Number", "HIP 5923"},
        {"Smithsonian Astrophysical Observation", "SAO 54565"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.04493072),
        dec: Angle.Degrees(+35.23129977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67219",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67219"},
        {"Geneva Identification System", "GEN# +0.03502485"},
        {"Smithsonian Astrophysical Observation", "SAO 63736"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.61789053),
        dec: Angle.Degrees(+35.23166466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74058"},
        {"Smithsonian Astrophysical Observation", "SAO 64513"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.02661059),
        dec: Angle.Degrees(+35.23542432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129468"},
        {"Hipparcos Number", "HIP 71839"},
        {"Geneva Identification System", "GEN# +1.00129468"},
        {"Smithsonian Astrophysical Observation", "SAO 64278"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.43495038),
        dec: Angle.Degrees(+35.24042822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83451"},
        {"Hipparcos Number", "HIP 47403"},
        {"Geneva Identification System", "GEN# +1.00083451"},
        {"Smithsonian Astrophysical Observation", "SAO 61618"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.86706694),
        dec: Angle.Degrees(+35.24309059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117229"},
        {"Geneva Identification System", "GEN# +0.03405002"},
        {"Smithsonian Astrophysical Observation", "SAO 73494"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.53850706),
        dec: Angle.Degrees(+35.24447341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 185.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -233.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87696"},
        {"Hipparcos Number", "HIP 49593"},
        {"Fundamental Katalog 5th Edition", "FK5 2812"},
        {"Geneva Identification System", "GEN# +1.00087696"},
        {"Smithsonian Astrophysical Observation", "SAO 61874"},
        {"Wilson Evans Batten Catalogue", "WEB 9146"},
    },
    visualMagnitude: 4.49,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.85718812),
        dec: Angle.Degrees(+35.24469176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131746"},
        {"Hipparcos Number", "HIP 72932"},
        {"Geneva Identification System", "GEN# +1.00131746"},
        {"Smithsonian Astrophysical Observation", "SAO 64391"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.59055771),
        dec: Angle.Degrees(+35.24536046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10390"},
        {"Hipparcos Number", "HIP 7943"},
        {"Celescope Catalog", "CEL 156"},
        {"Fundamental Katalog 5th Edition", "FK5 1047"},
        {"Geneva Identification System", "GEN# +1.00010390"},
        {"Smithsonian Astrophysical Observation", "SAO 54912"},
        {"Wilson Evans Batten Catalogue", "WEB 1698"},
    },
    visualMagnitude: 5.63,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.51439571),
        dec: Angle.Degrees(+35.24576705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106640"},
        {"Hipparcos Number", "HIP 59806"},
        {"Geneva Identification System", "GEN# +1.00106640"},
        {"Smithsonian Astrophysical Observation", "SAO 62926"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.95459310),
        dec: Angle.Degrees(+35.24688348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225320"},
        {"Hipparcos Number", "HIP 96770"},
        {"Smithsonian Astrophysical Observation", "SAO 68668"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.05249335),
        dec: Angle.Degrees(+35.24885488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196093"},
        {"Henry Draper 2", "HD 196094"},
        {"Hipparcos Number", "HIP 101474"},
        {"Celescope Catalog", "CEL 5113"},
        {"Geneva Identification System", "GEN# +1.00196093"},
        {"Smithsonian Astrophysical Observation", "SAO 70203"},
        {"Wilson Evans Batten Catalogue", "WEB 18335"},
    },
    visualMagnitude: 4.61,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.47578431),
        dec: Angle.Degrees(+35.25086482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48194"},
        {"Hipparcos Number", "HIP 32236"},
        {"Smithsonian Astrophysical Observation", "SAO 59418"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.94400339),
        dec: Angle.Degrees(+35.25109839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193736"},
        {"Hipparcos Number", "HIP 100307"},
        {"Celescope Catalog", "CEL 5032"},
        {"Geneva Identification System", "GEN# +1.00193736"},
        {"Smithsonian Astrophysical Observation", "SAO 69863"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.16279537),
        dec: Angle.Degrees(+35.25228665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209463"},
        {"Hipparcos Number", "HIP 108838"},
        {"Smithsonian Astrophysical Observation", "SAO 71978"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.72446954),
        dec: Angle.Degrees(+35.25366018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206898"},
        {"Hipparcos Number", "HIP 107329"},
        {"Renson", "Renson 57560"},
        {"Smithsonian Astrophysical Observation", "SAO 71654"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.08661804),
        dec: Angle.Degrees(+35.25505932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44694"},
        {"Hipparcos Number", "HIP 30497"},
        {"Fundamental Katalog 5th Edition", "FK5 2487"},
        {"Geneva Identification System", "GEN# +1.00044694"},
        {"Smithsonian Astrophysical Observation", "SAO 59050"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.16232361),
        dec: Angle.Degrees(+35.25510163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40544"},
        {"Hipparcos Number", "HIP 28506"},
        {"Geneva Identification System", "GEN# +1.00040544"},
        {"Smithsonian Astrophysical Observation", "SAO 58655"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.27063405),
        dec: Angle.Degrees(+35.25889129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185526"},
        {"Hipparcos Number", "HIP 96579"},
        {"Smithsonian Astrophysical Observation", "SAO 68603"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.50609950),
        dec: Angle.Degrees(+35.25909214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30854",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5090 A"},
        {"Henry Draper", "HD 45392"},
        {"Hipparcos Number", "HIP 30854"},
        {"Smithsonian Astrophysical Observation", "SAO 59130"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.18147930),
        dec: Angle.Degrees(+35.26201026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28281"},
        {"Hipparcos Number", "HIP 20926"},
        {"Smithsonian Astrophysical Observation", "SAO 57254"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.30132032),
        dec: Angle.Degrees(+35.26582807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116694"},
        {"Hipparcos Number", "HIP 65443"},
        {"Geneva Identification System", "GEN# +1.00116694"},
        {"Smithsonian Astrophysical Observation", "SAO 63521"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.18533309),
        dec: Angle.Degrees(+35.26584216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180052"},
        {"Hipparcos Number", "HIP 94457"},
        {"Smithsonian Astrophysical Observation", "SAO 68001"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.38005784),
        dec: Angle.Degrees(+35.26806560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81298"},
        {"Hipparcos Number", "HIP 46250"},
        {"Geneva Identification System", "GEN# +1.00081298"},
        {"Smithsonian Astrophysical Observation", "SAO 61480"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.43914129),
        dec: Angle.Degrees(+35.26874870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120290",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 120290"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.42067697),
        dec: Angle.Degrees(+35.26971226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61437"},
        {"Geneva Identification System", "GEN# +0.03602285"},
        {"Smithsonian Astrophysical Observation", "SAO 63085"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.83410140),
        dec: Angle.Degrees(+35.26983711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70125"},
        {"Smithsonian Astrophysical Observation", "SAO 64087"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.23142864),
        dec: Angle.Degrees(+35.26990196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218198"},
        {"Hipparcos Number", "HIP 114050"},
        {"Smithsonian Astrophysical Observation", "SAO 72990"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.45676438),
        dec: Angle.Degrees(+35.27040015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57802"},
        {"Geneva Identification System", "GEN# +0.03602219"},
        {"Wilson Evans Batten Catalogue", "WEB 10371"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.78138205),
        dec: Angle.Degrees(+35.27139762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -271.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 254.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51712"},
        {"Hipparcos Number", "HIP 33698"},
        {"Smithsonian Astrophysical Observation", "SAO 59676"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.02461799),
        dec: Angle.Degrees(+35.27400221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114722"},
        {"Hipparcos Number", "HIP 64392"},
        {"Geneva Identification System", "GEN# +1.00114722"},
        {"Smithsonian Astrophysical Observation", "SAO 63395"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.97017475),
        dec: Angle.Degrees(+35.27487630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20654"},
        {"Hipparcos Number", "HIP 15577"},
        {"Geneva Identification System", "GEN# +1.00020654"},
        {"Smithsonian Astrophysical Observation", "SAO 56363"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.17605120),
        dec: Angle.Degrees(+35.27609451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25329"},
        {"Hipparcos Number", "HIP 18915"},
        {"Cincinnati Publication", "Ci 20 276"},
        {"Geneva Identification System", "GEN# +1.00025329"},
        {"Smithsonian Astrophysical Observation", "SAO 56928"},
        {"Wilson Evans Batten Catalogue", "WEB 3638"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.80733764),
        dec: Angle.Degrees(+35.27659465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1732.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1365.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60865"},
    },
    visualMagnitude: 12.12,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.12940785),
        dec: Angle.Degrees(+35.27688094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -277.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57357",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57357"},
        {"Geneva Identification System", "GEN# +0.03602215"},
    },
    visualMagnitude: 10.28,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.38705807),
        dec: Angle.Degrees(+35.27916523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217183"},
        {"Hipparcos Number", "HIP 113436"},
        {"Smithsonian Astrophysical Observation", "SAO 72894"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.61223844),
        dec: Angle.Degrees(+35.28262480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82959",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82959"},
        {"Smithsonian Astrophysical Observation", "SAO 65670"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.29456228),
        dec: Angle.Degrees(+35.28654269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121739"},
        {"Hipparcos Number", "HIP 68091"},
        {"Geneva Identification System", "GEN# +1.00121739"},
        {"Smithsonian Astrophysical Observation", "SAO 63842"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.11535944),
        dec: Angle.Degrees(+35.28729719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -188.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12467"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.13133372),
        dec: Angle.Degrees(+35.28869816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 863"},
        {"Hipparcos Number", "HIP 1048"},
        {"Geneva Identification System", "GEN# +1.00000863"},
        {"Smithsonian Astrophysical Observation", "SAO 53729"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.26791177),
        dec: Angle.Degrees(+35.29166480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46050"},
        {"Hipparcos Number", "HIP 31193"},
        {"Smithsonian Astrophysical Observation", "SAO 59199"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.16759003),
        dec: Angle.Degrees(+35.29376316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96020",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96020"},
        {"Smithsonian Astrophysical Observation", "SAO 68432"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.84529420),
        dec: Angle.Degrees(+35.29440039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15282"},
        {"Hipparcos Number", "HIP 11515"},
        {"Smithsonian Astrophysical Observation", "SAO 55585"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.12481018),
        dec: Angle.Degrees(+35.29809614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9421",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9421"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.26153199),
        dec: Angle.Degrees(+35.30013240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209221"},
        {"Hipparcos Number", "HIP 108680"},
        {"Smithsonian Astrophysical Observation", "SAO 71945"},
    },
    visualMagnitude: 8.48,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.24505373),
        dec: Angle.Degrees(+35.30128888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34771"},
        {"Hipparcos Number", "HIP 25027"},
        {"Celescope Catalog", "CEL 638"},
        {"Geneva Identification System", "GEN# +1.00034771"},
        {"Smithsonian Astrophysical Observation", "SAO 57932"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.37789530),
        dec: Angle.Degrees(+35.30576358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2154"},
        {"Hipparcos Number", "HIP 2040"},
        {"Geneva Identification System", "GEN# +1.00002154"},
        {"Smithsonian Astrophysical Observation", "SAO 53888"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.47391293),
        dec: Angle.Degrees(+35.30587632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12246"},
        {"Hipparcos Number", "HIP 9426"},
        {"Fundamental Katalog 5th Edition", "FK5 4181"},
        {"Geneva Identification System", "GEN# +1.00012246"},
        {"Smithsonian Astrophysical Observation", "SAO 55190"},
        {"Wilson Evans Batten Catalogue", "WEB 1976"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.27108884),
        dec: Angle.Degrees(+35.30607941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227018"},
        {"Hipparcos Number", "HIP 98418"},
        {"Geneva Identification System", "GEN# +1.00227018"},
        {"Wilson Evans Batten Catalogue", "WEB 17374"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.95461239),
        dec: Angle.Degrees(+35.30934017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110688"},
        {"Hipparcos Number", "HIP 62104"},
        {"Geneva Identification System", "GEN# +1.00110688"},
        {"Smithsonian Astrophysical Observation", "SAO 63160"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.90935849),
        dec: Angle.Degrees(+35.31044032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97477",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12972 AB"},
        {"Henry Draper", "HD 187458"},
        {"Hipparcos Number", "HIP 97477"},
        {"Geneva Identification System", "GEN# +1.00187458"},
        {"Smithsonian Astrophysical Observation", "SAO 68893"},
        {"Wilson Evans Batten Catalogue", "WEB 17136"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.18229814),
        dec: Angle.Degrees(+35.31130999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199597"},
        {"Hipparcos Number", "HIP 103422"},
        {"Smithsonian Astrophysical Observation", "SAO 70712"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.30455214),
        dec: Angle.Degrees(+35.31170681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203941"},
        {"Hipparcos Number", "HIP 105681"},
        {"Geneva Identification System", "GEN# +1.00203941"},
        {"Smithsonian Astrophysical Observation", "SAO 71289"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.08109878),
        dec: Angle.Degrees(+35.31461550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75574",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75574"},
        {"Smithsonian Astrophysical Observation", "SAO 64702"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.57388002),
        dec: Angle.Degrees(+35.31530033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14145"},
        {"Hipparcos Number", "HIP 10738"},
        {"Smithsonian Astrophysical Observation", "SAO 55441"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.55009245),
        dec: Angle.Degrees(+35.31565278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79"},
        {"Smithsonian Astrophysical Observation", "SAO 73683"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.23572286),
        dec: Angle.Degrees(+35.31675386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111483"},
        {"Hipparcos Number", "HIP 62575"},
        {"Geneva Identification System", "GEN# +1.00111483"},
        {"Smithsonian Astrophysical Observation", "SAO 63208"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.31771097),
        dec: Angle.Degrees(+35.32052726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183702"},
        {"Hipparcos Number", "HIP 95813"},
        {"Celescope Catalog", "CEL 4775"},
        {"Geneva Identification System", "GEN# +1.00183702"},
        {"Smithsonian Astrophysical Observation", "SAO 68387"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.32868723),
        dec: Angle.Degrees(+35.32059149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58120"},
        {"Hipparcos Number", "HIP 36044"},
        {"Geneva Identification System", "GEN# +1.00058120"},
        {"Smithsonian Astrophysical Observation", "SAO 60064"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.42176053),
        dec: Angle.Degrees(+35.32206739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13521"},
        {"Hipparcos Number", "HIP 10319"},
        {"Smithsonian Astrophysical Observation", "SAO 55354"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.22354311),
        dec: Angle.Degrees(+35.32212704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154888"},
        {"Hipparcos Number", "HIP 83724"},
        {"Fundamental Katalog 5th Edition", "FK5 5508"},
        {"Geneva Identification System", "GEN# +1.00154888"},
        {"Smithsonian Astrophysical Observation", "SAO 65794"},
        {"Wilson Evans Batten Catalogue", "WEB 14157"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.67336830),
        dec: Angle.Degrees(+35.32344152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85974"},
        {"Hipparcos Number", "HIP 48728"},
        {"Smithsonian Astrophysical Observation", "SAO 61769"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.08789604),
        dec: Angle.Degrees(+35.32701132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205880"},
        {"Hipparcos Number", "HIP 106742"},
        {"Smithsonian Astrophysical Observation", "SAO 71531"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.33973249),
        dec: Angle.Degrees(+35.32770625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43438"},
        {"Hipparcos Number", "HIP 29910"},
        {"Geneva Identification System", "GEN# +1.00043438"},
        {"Smithsonian Astrophysical Observation", "SAO 58952"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.46278484),
        dec: Angle.Degrees(+35.32808572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118150"},
        {"Smithsonian Astrophysical Observation", "SAO 73635"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.49651094),
        dec: Angle.Degrees(+35.32945055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70051"},
        {"Hipparcos Number", "HIP 40931"},
        {"Smithsonian Astrophysical Observation", "SAO 60748"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.29728190),
        dec: Angle.Degrees(+35.32992655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215213"},
        {"Hipparcos Number", "HIP 112173"},
        {"Smithsonian Astrophysical Observation", "SAO 72653"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.77173325),
        dec: Angle.Degrees(+35.32999278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77968"},
        {"Hipparcos Number", "HIP 44720"},
        {"Smithsonian Astrophysical Observation", "SAO 61260"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.68437093),
        dec: Angle.Degrees(+35.33020056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46636",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46636"},
        {"Smithsonian Astrophysical Observation", "SAO 61528"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.64750336),
        dec: Angle.Degrees(+35.33043900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221477"},
        {"Hipparcos Number", "HIP 116174"},
        {"Geneva Identification System", "GEN# +1.00221477"},
        {"Smithsonian Astrophysical Observation", "SAO 73323"},
        {"Wilson Evans Batten Catalogue", "WEB 20535"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.09361972),
        dec: Angle.Degrees(+35.33064075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220537"},
        {"Hipparcos Number", "HIP 115539"},
        {"Smithsonian Astrophysical Observation", "SAO 73229"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.06124981),
        dec: Angle.Degrees(+35.33079466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61205"},
        {"Geneva Identification System", "GEN# +0.03602278"},
        {"Smithsonian Astrophysical Observation", "SAO 63052"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.12950405),
        dec: Angle.Degrees(+35.33122246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19858"},
        {"Hipparcos Number", "HIP 14955"},
        {"Geneva Identification System", "GEN# +1.00019858"},
        {"Smithsonian Astrophysical Observation", "SAO 56249"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.19321795),
        dec: Angle.Degrees(+35.33242993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190114"},
        {"Hipparcos Number", "HIP 98637"},
        {"Celescope Catalog", "CEL 4918"},
        {"Geneva Identification System", "GEN# +1.00190114"},
        {"Smithsonian Astrophysical Observation", "SAO 69286"},
        {"Wilson Evans Batten Catalogue", "WEB 17448"},
    },
    visualMagnitude: 7.42,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.50756735),
        dec: Angle.Degrees(+35.33247826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201399"},
        {"Hipparcos Number", "HIP 104342"},
        {"Fundamental Katalog 5th Edition", "FK5 5860"},
        {"Smithsonian Astrophysical Observation", "SAO 70962"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.06018858),
        dec: Angle.Degrees(+35.33292313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96951"},
        {"Hipparcos Number", "HIP 54581"},
        {"Geneva Identification System", "GEN# +1.00096951"},
        {"Smithsonian Astrophysical Observation", "SAO 62433"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.55358031),
        dec: Angle.Degrees(+35.33511260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4755"},
        {"Hipparcos Number", "HIP 3896"},
        {"Smithsonian Astrophysical Observation", "SAO 54178"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.49371612),
        dec: Angle.Degrees(+35.33584859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83525"},
        {"Hipparcos Number", "HIP 47436"},
        {"Geneva Identification System", "GEN# +1.00083525"},
        {"Smithsonian Astrophysical Observation", "SAO 61620"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.99105262),
        dec: Angle.Degrees(+35.33595022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223789"},
        {"Hipparcos Number", "HIP 117727"},
        {"Geneva Identification System", "GEN# +1.00223789"},
        {"Smithsonian Astrophysical Observation", "SAO 73576"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.14612108),
        dec: Angle.Degrees(+35.33655702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98746"},
        {"Hipparcos Number", "HIP 55506"},
        {"Smithsonian Astrophysical Observation", "SAO 62513"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.52294986),
        dec: Angle.Degrees(+35.33706396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216451"},
        {"Hipparcos Number", "HIP 112952"},
        {"Smithsonian Astrophysical Observation", "SAO 72802"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.14126645),
        dec: Angle.Degrees(+35.33760513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9983"},
        {"Hipparcos Number", "HIP 7622"},
        {"Smithsonian Astrophysical Observation", "SAO 54855"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.54589426),
        dec: Angle.Degrees(+35.33919072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105170"},
        {"Hipparcos Number", "HIP 59054"},
        {"Geneva Identification System", "GEN# +1.00105170"},
        {"Smithsonian Astrophysical Observation", "SAO 62838"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.65445334),
        dec: Angle.Degrees(+35.33974605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21183"},
        {"Hipparcos Number", "HIP 16025"},
        {"Geneva Identification System", "GEN# +1.00021183"},
        {"Smithsonian Astrophysical Observation", "SAO 56448"},
        {"Wilson Evans Batten Catalogue", "WEB 3060"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.58769990),
        dec: Angle.Degrees(+35.34058016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103613"},
        {"Hipparcos Number", "HIP 58184"},
        {"Geneva Identification System", "GEN# +1.00103613"},
        {"Smithsonian Astrophysical Observation", "SAO 62759"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.00101946),
        dec: Angle.Degrees(+35.34058715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170003"},
        {"Hipparcos Number", "HIP 90325"},
        {"Geneva Identification System", "GEN# +1.00170003"},
        {"Smithsonian Astrophysical Observation", "SAO 66963"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.44700773),
        dec: Angle.Degrees(+35.34279147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200467"},
        {"Hipparcos Number", "HIP 103845"},
        {"Geneva Identification System", "GEN# +1.00200467"},
        {"Renson", "Renson 55860"},
        {"Smithsonian Astrophysical Observation", "SAO 70821"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.63472599),
        dec: Angle.Degrees(+35.34300924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162704"},
        {"Hipparcos Number", "HIP 87347"},
        {"Geneva Identification System", "GEN# +1.00162704"},
        {"Smithsonian Astrophysical Observation", "SAO 66380"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.72647638),
        dec: Angle.Degrees(+35.34333498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119617"},
        {"Hipparcos Number", "HIP 66971"},
        {"Geneva Identification System", "GEN# +1.00119617"},
        {"Smithsonian Astrophysical Observation", "SAO 63710"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.89663875),
        dec: Angle.Degrees(+35.34601397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42558"},
        {"Hipparcos Number", "HIP 29504"},
        {"Geneva Identification System", "GEN# +1.00042558"},
        {"Smithsonian Astrophysical Observation", "SAO 58860"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.24395157),
        dec: Angle.Degrees(+35.34841766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209872"},
        {"Hipparcos Number", "HIP 109070"},
        {"Smithsonian Astrophysical Observation", "SAO 72019"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.42531282),
        dec: Angle.Degrees(+35.34850408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208686"},
        {"Hipparcos Number", "HIP 108366"},
        {"Fundamental Katalog 5th Edition", "FK5 5940"},
        {"Smithsonian Astrophysical Observation", "SAO 71871"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.30421262),
        dec: Angle.Degrees(+35.34945028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4043"},
        {"Hipparcos Number", "HIP 3389"},
        {"Smithsonian Astrophysical Observation", "SAO 54104"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.79212995),
        dec: Angle.Degrees(+35.35283922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24464",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3815 AB"},
        {"Henry Draper", "HD 33879"},
        {"Hipparcos Number", "HIP 24464"},
        {"Smithsonian Astrophysical Observation", "SAO 57792"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.74559739),
        dec: Angle.Degrees(+35.35757640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33333"},
        {"Hipparcos Number", "HIP 24150"},
        {"Geneva Identification System", "GEN# +1.00033333"},
        {"Smithsonian Astrophysical Observation", "SAO 57723"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.79533681),
        dec: Angle.Degrees(+35.35776714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189777"},
        {"Hipparcos Number", "HIP 98465"},
        {"Smithsonian Astrophysical Observation", "SAO 69241"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.07929823),
        dec: Angle.Degrees(+35.35837861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26407"},
        {"Hipparcos Number", "HIP 19606"},
        {"Fundamental Katalog 5th Edition", "FK5 4381"},
        {"Smithsonian Astrophysical Observation", "SAO 57058"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.01602510),
        dec: Angle.Degrees(+35.35956777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86345",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86345"},
        {"Smithsonian Astrophysical Observation", "SAO 66212"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.66339242),
        dec: Angle.Degrees(+35.36086052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99737",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13562 A"},
        {"Henry Draper", "HD 192557"},
        {"Hipparcos Number", "HIP 99737"},
        {"Geneva Identification System", "GEN# +1.00192557"},
        {"Smithsonian Astrophysical Observation", "SAO 69661"},
        {"Wilson Evans Batten Catalogue", "WEB 17898"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.55790244),
        dec: Angle.Degrees(+35.36187739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78331"},
        {"Hipparcos Number", "HIP 44882"},
        {"Smithsonian Astrophysical Observation", "SAO 61284"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.17538654),
        dec: Angle.Degrees(+35.36225197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9873",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9873"},
        {"Smithsonian Astrophysical Observation", "SAO 55273"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.75140939),
        dec: Angle.Degrees(+35.36256268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 196.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71882"},
        {"Hipparcos Number", "HIP 41770"},
        {"Smithsonian Astrophysical Observation", "SAO 60863"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.76817786),
        dec: Angle.Degrees(+35.36266924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45661",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7286 AB"},
        {"Henry Draper", "HD 80024"},
        {"Hipparcos Number", "HIP 45661"},
        {"Geneva Identification System", "GEN# +1.00080024"},
        {"Smithsonian Astrophysical Observation", "SAO 61387"},
        {"Wilson Evans Batten Catalogue", "WEB 8671"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.60809965),
        dec: Angle.Degrees(+35.36412574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84541"},
        {"Hipparcos Number", "HIP 47993"},
        {"Smithsonian Astrophysical Observation", "SAO 61679"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.74463177),
        dec: Angle.Degrees(+35.36419720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212733"},
        {"Hipparcos Number", "HIP 110716"},
        {"Cincinnati Publication", "Ci 18 2917"},
        {"Smithsonian Astrophysical Observation", "SAO 72331"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.47871205),
        dec: Angle.Degrees(+35.36532314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 184.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113642",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16448 AB"},
        {"Hipparcos Number", "HIP 113642"},
        {"Smithsonian Astrophysical Observation", "SAO 72928"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.23202549),
        dec: Angle.Degrees(+35.36608266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44388"},
        {"Smithsonian Astrophysical Observation", "SAO 61216"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.63025843),
        dec: Angle.Degrees(+35.36852664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99608"},
        {"Hipparcos Number", "HIP 55939"},
        {"Geneva Identification System", "GEN# +1.00099608"},
        {"Smithsonian Astrophysical Observation", "SAO 62567"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.97169598),
        dec: Angle.Degrees(+35.37060242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211526"},
        {"Hipparcos Number", "HIP 110017"},
        {"Geneva Identification System", "GEN# +1.00211526"},
        {"Smithsonian Astrophysical Observation", "SAO 72202"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.24607203),
        dec: Angle.Degrees(+35.37068912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157213"},
        {"Hipparcos Number", "HIP 84847"},
        {"Smithsonian Astrophysical Observation", "SAO 65960"},
    },
    visualMagnitude: 7.47,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.11633907),
        dec: Angle.Degrees(+35.37100737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
