using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_100() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54500"},
        {"Smithsonian Astrophysical Observation", "SAO 43624"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.25024465),
        dec: Angle.Degrees(+44.91626987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62569",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62569"},
        {"Geneva Identification System", "GEN# +0.04502064"},
    },
    visualMagnitude: 10.45,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.29446483),
        dec: Angle.Degrees(+44.91854596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204710"},
        {"Hipparcos Number", "HIP 106071"},
        {"Geneva Identification System", "GEN# +1.00204710J"},
        {"Smithsonian Astrophysical Observation", "SAO 50925"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.27640416),
        dec: Angle.Degrees(+44.92308555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199579"},
        {"Hipparcos Number", "HIP 103371"},
        {"Celescope Catalog", "CEL 5215"},
        {"Geneva Identification System", "GEN# +1.00199579"},
        {"Smithsonian Astrophysical Observation", "SAO 50263"},
        {"Wilson Evans Batten Catalogue", "WEB 18793"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.14490863),
        dec: Angle.Degrees(+44.92472729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22719"},
        {"Hipparcos Number", "HIP 17199"},
        {"Geneva Identification System", "GEN# +1.00022719"},
        {"Smithsonian Astrophysical Observation", "SAO 39037"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.24590779),
        dec: Angle.Degrees(+44.92514303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91782",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11616 A"},
        {"Henry Draper", "HD 173399"},
        {"Hipparcos Number", "HIP 91782"},
        {"Geneva Identification System", "GEN# +1.00173399A"},
        {"Smithsonian Astrophysical Observation", "SAO 47727"},
        {"Wilson Evans Batten Catalogue", "WEB 15791"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.73095962),
        dec: Angle.Degrees(+44.92530485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59976"},
        {"Hipparcos Number", "HIP 36839"},
        {"Smithsonian Astrophysical Observation", "SAO 41858"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.62731317),
        dec: Angle.Degrees(+44.92553080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72666",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9418 AB"},
        {"Henry Draper", "HD 131315"},
        {"Hipparcos Number", "HIP 72666"},
        {"Smithsonian Astrophysical Observation", "SAO 45241"},
        {"Wilson Evans Batten Catalogue", "WEB 12492"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.86479189),
        dec: Angle.Degrees(+44.92848352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177484"},
        {"Hipparcos Number", "HIP 93522"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.71602661),
        dec: Angle.Degrees(+44.92963086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183124"},
        {"Hipparcos Number", "HIP 95534"},
        {"Fundamental Katalog 5th Edition", "FK5 1506"},
        {"Geneva Identification System", "GEN# +1.00183124"},
        {"Smithsonian Astrophysical Observation", "SAO 48433"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.48605629),
        dec: Angle.Degrees(+44.93094370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91783",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11616 B"},
        {"Hipparcos Number", "HIP 91783"},
        {"Geneva Identification System", "GEN# +1.00173399B"},
        {"Smithsonian Astrophysical Observation", "SAO 47728"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.73239766),
        dec: Angle.Degrees(+44.93237303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182736"},
        {"Hipparcos Number", "HIP 95362"},
        {"Geneva Identification System", "GEN# +1.00182736"},
        {"Smithsonian Astrophysical Observation", "SAO 48403"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.01376479),
        dec: Angle.Degrees(+44.93344794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145389"},
        {"Hipparcos Number", "HIP 79101"},
        {"Fundamental Katalog 5th Edition", "FK5 601"},
        {"Geneva Identification System", "GEN# +1.00145389"},
        {"Renson", "Renson 41160"},
        {"Smithsonian Astrophysical Observation", "SAO 45911"},
        {"Wilson Evans Batten Catalogue", "WEB 13373"},
    },
    visualMagnitude: 4.23,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.19249715),
        dec: Angle.Degrees(+44.93481883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114875",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114875"},
        {"Smithsonian Astrophysical Observation", "SAO 52846"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.02484576),
        dec: Angle.Degrees(+44.93504319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42232"},
        {"Smithsonian Astrophysical Observation", "SAO 42446"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.16184416),
        dec: Angle.Degrees(+44.93545948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75025",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75025"},
        {"Smithsonian Astrophysical Observation", "SAO 45490"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.95466494),
        dec: Angle.Degrees(+44.93553194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68953"},
        {"Hipparcos Number", "HIP 40533"},
        {"Geneva Identification System", "GEN# +1.00068953"},
        {"Smithsonian Astrophysical Observation", "SAO 42261"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.13927503),
        dec: Angle.Degrees(+44.93573995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31256"},
        {"Smithsonian Astrophysical Observation", "SAO 41175"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.33300444),
        dec: Angle.Degrees(+44.93695850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164395"},
        {"Hipparcos Number", "HIP 88006"},
        {"Geneva Identification System", "GEN# +1.00164395"},
        {"Smithsonian Astrophysical Observation", "SAO 47103"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.65858131),
        dec: Angle.Degrees(+44.93741930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24560"},
        {"Hipparcos Number", "HIP 18424"},
        {"Geneva Identification System", "GEN# +1.00024560"},
        {"Smithsonian Astrophysical Observation", "SAO 39202"},
        {"Wilson Evans Batten Catalogue", "WEB 3551"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.08484544),
        dec: Angle.Degrees(+44.93749406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216257"},
        {"Hipparcos Number", "HIP 112819"},
        {"Smithsonian Astrophysical Observation", "SAO 52417"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.70345586),
        dec: Angle.Degrees(+44.93811722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81878"},
        {"Smithsonian Astrophysical Observation", "SAO 46245"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.87332370),
        dec: Angle.Degrees(+44.94364081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41181",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6783 B"},
        {"Hipparcos Number", "HIP 41181"},
        {"Smithsonian Astrophysical Observation", "SAO 42336"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.05531197),
        dec: Angle.Degrees(+44.94635313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71535"},
        {"Hipparcos Number", "HIP 41675"},
        {"Geneva Identification System", "GEN# +1.00071535"},
        {"Smithsonian Astrophysical Observation", "SAO 42388"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.44053455),
        dec: Angle.Degrees(+44.94708418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28360",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Menkalinan"},
        {"Aitken", "ADS 4556 A"},
        {"Henry Draper", "HD 40183"},
        {"Hipparcos Number", "HIP 28360"},
        {"Fundamental Katalog 5th Edition", "FK5 227"},
        {"Geneva Identification System", "GEN# +1.00040183"},
        {"Renson", "Renson 10720"},
        {"Smithsonian Astrophysical Observation", "SAO 40750"},
        {"Wilson Evans Batten Catalogue", "WEB 5543"},
    },
    visualMagnitude: 1.90,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.88237261),
        dec: Angle.Degrees(+44.94743492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208513"},
        {"Hipparcos Number", "HIP 108224"},
        {"Celescope Catalog", "CEL 5405"},
        {"Fundamental Katalog 5th Edition", "FK5 5936"},
        {"Geneva Identification System", "GEN# +1.00208513"},
        {"Renson", "Renson 57970"},
        {"Smithsonian Astrophysical Observation", "SAO 51447"},
        {"Wilson Evans Batten Catalogue", "WEB 19505"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.87423725),
        dec: Angle.Degrees(+44.94855156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117321"},
        {"Smithsonian Astrophysical Observation", "SAO 53372"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.84211000),
        dec: Angle.Degrees(+44.94946962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41184",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6783 A"},
        {"Henry Draper", "HD 70516"},
        {"Hipparcos Number", "HIP 41184"},
        {"Geneva Identification System", "GEN# +1.00070516A"},
        {"Smithsonian Astrophysical Observation", "SAO 42337"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.06545092),
        dec: Angle.Degrees(+44.95014247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92764"},
        {"Hipparcos Number", "HIP 52458"},
        {"Geneva Identification System", "GEN# +1.00092764"},
        {"Renson", "Renson 26780"},
        {"Smithsonian Astrophysical Observation", "SAO 43442"},
        {"Wilson Evans Batten Catalogue", "WEB 9554"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.85633265),
        dec: Angle.Degrees(+44.95051061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139440"},
        {"Hipparcos Number", "HIP 76412"},
        {"Geneva Identification System", "GEN# +1.00139440"},
        {"Smithsonian Astrophysical Observation", "SAO 45634"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.10562487),
        dec: Angle.Degrees(+44.95053832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42128"},
        {"Hipparcos Number", "HIP 29345"},
        {"Geneva Identification System", "GEN# +1.00042128"},
        {"Smithsonian Astrophysical Observation", "SAO 40921"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.80498863),
        dec: Angle.Degrees(+44.95207636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18071",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18071"},
    },
    visualMagnitude: 11.51,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.93475124),
        dec: Angle.Degrees(+44.95309357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202617"},
        {"Hipparcos Number", "HIP 104958"},
        {"Celescope Catalog", "CEL 5282"},
        {"Geneva Identification System", "GEN# +1.00202617"},
        {"Renson", "Renson 56440"},
        {"Smithsonian Astrophysical Observation", "SAO 50627"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.89807761),
        dec: Angle.Degrees(+44.95452284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4581",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 808 AB"},
        {"Henry Draper", "HD 5639"},
        {"Hipparcos Number", "HIP 4581"},
        {"Smithsonian Astrophysical Observation", "SAO 36816"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.67267382),
        dec: Angle.Degrees(+44.95626783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142592"},
        {"Hipparcos Number", "HIP 77823"},
        {"Smithsonian Astrophysical Observation", "SAO 45781"},
        {"Wilson Evans Batten Catalogue", "WEB 13162"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.37026558),
        dec: Angle.Degrees(+44.95852631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23624",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3647 AB"},
        {"Henry Draper", "HD 32358"},
        {"Hipparcos Number", "HIP 23624"},
        {"Geneva Identification System", "GEN# +1.00032358J"},
        {"Smithsonian Astrophysical Observation", "SAO 39997"},
        {"Wilson Evans Batten Catalogue", "WEB 4606"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.18398413),
        dec: Angle.Degrees(+44.95862558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86131"},
        {"Wilson Evans Batten Catalogue", "WEB 14528"},
    },
    visualMagnitude: 11.20,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.03686028),
        dec: Angle.Degrees(+44.96057563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88467"},
        {"Smithsonian Astrophysical Observation", "SAO 47184"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.96600350),
        dec: Angle.Degrees(+44.96185763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11396",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11396"},
        {"Smithsonian Astrophysical Observation", "SAO 38029"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.70684031),
        dec: Angle.Degrees(+44.96300140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186994"},
        {"Hipparcos Number", "HIP 97225"},
        {"Celescope Catalog", "CEL 4836"},
        {"Geneva Identification System", "GEN# +1.00186994"},
        {"Smithsonian Astrophysical Observation", "SAO 48806"},
        {"Wilson Evans Batten Catalogue", "WEB 17070"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.40821704),
        dec: Angle.Degrees(+44.96375263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201397"},
        {"Hipparcos Number", "HIP 104303"},
        {"Geneva Identification System", "GEN# +1.00201397"},
        {"Smithsonian Astrophysical Observation", "SAO 50480"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.94809526),
        dec: Angle.Degrees(+44.96424212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20810"},
        {"Hipparcos Number", "HIP 15753"},
        {"Smithsonian Astrophysical Observation", "SAO 38765"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.73770262),
        dec: Angle.Degrees(+44.96632213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23838"},
        {"Hipparcos Number", "HIP 17932"},
        {"Geneva Identification System", "GEN# +1.00023838"},
        {"Smithsonian Astrophysical Observation", "SAO 39134"},
        {"Wilson Evans Batten Catalogue", "WEB 3454"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.51854760),
        dec: Angle.Degrees(+44.96792105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22540",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3468 A"},
        {"Henry Draper", "HD 30584"},
        {"Hipparcos Number", "HIP 22540"},
        {"Geneva Identification System", "GEN# +1.00030584"},
        {"Renson", "Renson 7910"},
        {"Smithsonian Astrophysical Observation", "SAO 39800"},
        {"Wilson Evans Batten Catalogue", "WEB 4353"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.77014705),
        dec: Angle.Degrees(+44.96882887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52594",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7914 AB"},
        {"Henry Draper", "HD 93013"},
        {"Hipparcos Number", "HIP 52594"},
        {"Smithsonian Astrophysical Observation", "SAO 43459"},
        {"Wilson Evans Batten Catalogue", "WEB 9581"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.31503390),
        dec: Angle.Degrees(+44.96978110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9636"},
        {"Hipparcos Number", "HIP 7389"},
        {"Smithsonian Astrophysical Observation", "SAO 37334"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.82590673),
        dec: Angle.Degrees(+44.97135971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22539",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3468 B"},
        {"Henry Draper", "HD 30584B"},
        {"Hipparcos Number", "HIP 22539"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.76848602),
        dec: Angle.Degrees(+44.97148484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3779",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 667 A"},
        {"Henry Draper", "HD 4617"},
        {"Hipparcos Number", "HIP 3779"},
        {"Smithsonian Astrophysical Observation", "SAO 36678"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.14015751),
        dec: Angle.Degrees(+44.97274862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75172"},
        {"Hipparcos Number", "HIP 43372"},
        {"Geneva Identification System", "GEN# +1.00075172"},
        {"Smithsonian Astrophysical Observation", "SAO 42565"},
        {"Wilson Evans Batten Catalogue", "WEB 8358"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.52119479),
        dec: Angle.Degrees(+44.97291571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89213"},
        {"Smithsonian Astrophysical Observation", "SAO 47300"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.09005797),
        dec: Angle.Degrees(+44.97366358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22638",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22638"},
        {"Geneva Identification System", "GEN# +0.04401040"},
        {"Smithsonian Astrophysical Observation", "SAO 39817"},
        {"Wilson Evans Batten Catalogue", "WEB 4378"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.05581661),
        dec: Angle.Degrees(+44.97399031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157441"},
        {"Hipparcos Number", "HIP 84906"},
        {"Smithsonian Astrophysical Observation", "SAO 46659"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.28107828),
        dec: Angle.Degrees(+44.97624308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207445"},
        {"Hipparcos Number", "HIP 107615"},
        {"Smithsonian Astrophysical Observation", "SAO 51310"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.95226616),
        dec: Angle.Degrees(+44.97783405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75117"},
        {"Hipparcos Number", "HIP 43337"},
        {"Geneva Identification System", "GEN# +1.00075117"},
        {"Smithsonian Astrophysical Observation", "SAO 42563"},
        {"Wilson Evans Batten Catalogue", "WEB 8345"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.43614765),
        dec: Angle.Degrees(+44.97783789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106396",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106396"},
        {"Smithsonian Astrophysical Observation", "SAO 51014"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.24476131),
        dec: Angle.Degrees(+44.97818645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195985"},
        {"Hipparcos Number", "HIP 101375"},
        {"Celescope Catalog", "CEL 5107"},
        {"Geneva Identification System", "GEN# +1.00195985"},
        {"Smithsonian Astrophysical Observation", "SAO 49770"},
        {"Wilson Evans Batten Catalogue", "WEB 18317"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.19570671),
        dec: Angle.Degrees(+44.97895462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51497"},
        {"Hipparcos Number", "HIP 33674"},
        {"Smithsonian Astrophysical Observation", "SAO 41479"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.93872512),
        dec: Angle.Degrees(+44.97943426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118955"},
        {"Hipparcos Number", "HIP 66622"},
        {"Geneva Identification System", "GEN# +1.00118955"},
        {"Smithsonian Astrophysical Observation", "SAO 44696"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.83895520),
        dec: Angle.Degrees(+44.98245870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119111"},
        {"Hipparcos Number", "HIP 66698"},
        {"Smithsonian Astrophysical Observation", "SAO 44704"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.08518238),
        dec: Angle.Degrees(+44.98733325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163966"},
        {"Hipparcos Number", "HIP 87840"},
        {"Smithsonian Astrophysical Observation", "SAO 47077"},
        {"Wilson Evans Batten Catalogue", "WEB 14828"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.17915079),
        dec: Angle.Degrees(+44.98738396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176390"},
        {"Hipparcos Number", "HIP 93100"},
        {"Smithsonian Astrophysical Observation", "SAO 47955"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.49554740),
        dec: Angle.Degrees(+44.98814004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77940"},
        {"Smithsonian Astrophysical Observation", "SAO 45789"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.75276228),
        dec: Angle.Degrees(+44.98902900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133564"},
        {"Hipparcos Number", "HIP 73677"},
        {"Geneva Identification System", "GEN# +1.00133564"},
        {"Smithsonian Astrophysical Observation", "SAO 45354"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.90381464),
        dec: Angle.Degrees(+44.98961945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 307.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66212"},
        {"Hipparcos Number", "HIP 39505"},
        {"Geneva Identification System", "GEN# +1.00066212"},
        {"Smithsonian Astrophysical Observation", "SAO 42155"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.12300031),
        dec: Angle.Degrees(+44.99048442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222641"},
        {"Hipparcos Number", "HIP 116941"},
        {"Smithsonian Astrophysical Observation", "SAO 53292"},
        {"Wilson Evans Batten Catalogue", "WEB 20627"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.56117891),
        dec: Angle.Degrees(+44.99175706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4313"},
        {"Smithsonian Astrophysical Observation", "SAO 36766"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.80144753),
        dec: Angle.Degrees(+44.99261920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2285"},
        {"Smithsonian Astrophysical Observation", "SAO 36410"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.29643458),
        dec: Angle.Degrees(+44.99505600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35797",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6018 A"},
        {"Henry Draper", "HD 57378"},
        {"Hipparcos Number", "HIP 35797"},
        {"Smithsonian Astrophysical Observation", "SAO 41729"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.76066527),
        dec: Angle.Degrees(+44.99541210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62995"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.62348176),
        dec: Angle.Degrees(+44.99594731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200102"},
        {"Hipparcos Number", "HIP 103637"},
        {"Geneva Identification System", "GEN# +1.00200102"},
        {"Smithsonian Astrophysical Observation", "SAO 50333"},
        {"Wilson Evans Batten Catalogue", "WEB 18858"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.96373697),
        dec: Angle.Degrees(+44.99644911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98526"},
        {"Hipparcos Number", "HIP 55391"},
        {"Geneva Identification System", "GEN# +1.00098526"},
        {"Smithsonian Astrophysical Observation", "SAO 43702"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.13349537),
        dec: Angle.Degrees(+44.99835227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35799",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6018 B"},
        {"Hipparcos Number", "HIP 35799"},
    },
    visualMagnitude: 11.27,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.76429800),
        dec: Angle.Degrees(+45.00023307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16669"},
        {"Hipparcos Number", "HIP 12587"},
        {"Smithsonian Astrophysical Observation", "SAO 38238"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.46936253),
        dec: Angle.Degrees(+45.00187366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4778"},
        {"Hipparcos Number", "HIP 3919"},
        {"Celescope Catalog", "CEL 93"},
        {"Fundamental Katalog 5th Edition", "FK5 2055"},
        {"Geneva Identification System", "GEN# +1.00004778"},
        {"Renson", "Renson 1250"},
        {"Smithsonian Astrophysical Observation", "SAO 36702"},
        {"Wilson Evans Batten Catalogue", "WEB 700"},
    },
    visualMagnitude: 6.13,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.57589036),
        dec: Angle.Degrees(+45.00224079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214008"},
        {"Hipparcos Number", "HIP 111444"},
        {"Smithsonian Astrophysical Observation", "SAO 52156"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.65473496),
        dec: Angle.Degrees(+45.00498206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2600"},
        {"Hipparcos Number", "HIP 2341"},
        {"Smithsonian Astrophysical Observation", "SAO 36418"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.47747905),
        dec: Angle.Degrees(+45.00648148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154887"},
        {"Hipparcos Number", "HIP 83673"},
        {"Smithsonian Astrophysical Observation", "SAO 46487"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.52184655),
        dec: Angle.Degrees(+45.00673858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214946"},
        {"Hipparcos Number", "HIP 112000"},
        {"Geneva Identification System", "GEN# +1.00214946"},
        {"Renson", "Renson 59427"},
        {"Smithsonian Astrophysical Observation", "SAO 52262"},
        {"Wilson Evans Batten Catalogue", "WEB 19995"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.29028157),
        dec: Angle.Degrees(+45.00866040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54212",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54212"},
    },
    visualMagnitude: 11.10,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.38975604),
        dec: Angle.Degrees(+45.00923614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -220.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220395"},
        {"Hipparcos Number", "HIP 115446"},
        {"Smithsonian Astrophysical Observation", "SAO 52958"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.77107878),
        dec: Angle.Degrees(+45.00998437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103796"},
        {"Hipparcos Number", "HIP 58295"},
        {"Smithsonian Astrophysical Observation", "SAO 43965"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.32017277),
        dec: Angle.Degrees(+45.01045261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171242"},
        {"Hipparcos Number", "HIP 90813"},
        {"Cincinnati Publication", "Ci 18 2431"},
        {"Geneva Identification System", "GEN# +1.00171242"},
        {"Smithsonian Astrophysical Observation", "SAO 47565"},
        {"Wilson Evans Batten Catalogue", "WEB 15568"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.87557686),
        dec: Angle.Degrees(+45.01063741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -358.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34380"},
        {"Hipparcos Number", "HIP 24816"},
        {"Smithsonian Astrophysical Observation", "SAO 40231"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.79452038),
        dec: Angle.Degrees(+45.01150683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52174"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.88834821),
        dec: Angle.Degrees(+45.01301970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183142"},
        {"Hipparcos Number", "HIP 95543"},
        {"Renson", "Renson 50623"},
        {"Smithsonian Astrophysical Observation", "SAO 48438"},
    },
    visualMagnitude: 7.08,
    bvColour: -0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.50505262),
        dec: Angle.Degrees(+45.01307406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209945"},
        {"Hipparcos Number", "HIP 109102"},
        {"Fundamental Katalog 5th Edition", "FK5 3769"},
        {"Geneva Identification System", "GEN# +1.00209945"},
        {"Smithsonian Astrophysical Observation", "SAO 51650"},
        {"Wilson Evans Batten Catalogue", "WEB 19615"},
    },
    visualMagnitude: 5.09,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.50816631),
        dec: Angle.Degrees(+45.01438566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106906",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106906"},
        {"Smithsonian Astrophysical Observation", "SAO 51143"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.77053085),
        dec: Angle.Degrees(+45.01448514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118406"},
        {"Hipparcos Number", "HIP 66350"},
        {"Smithsonian Astrophysical Observation", "SAO 44679"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.99305743),
        dec: Angle.Degrees(+45.01523876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191872"},
        {"Hipparcos Number", "HIP 99370"},
        {"Celescope Catalog", "CEL 4956"},
        {"Geneva Identification System", "GEN# +1.00191872"},
        {"Smithsonian Astrophysical Observation", "SAO 49261"},
    },
    visualMagnitude: 7.79,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.53897333),
        dec: Angle.Degrees(+45.01672309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136362"},
        {"Hipparcos Number", "HIP 74928"},
        {"Smithsonian Astrophysical Observation", "SAO 45480"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.66527723),
        dec: Angle.Degrees(+45.01723027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89070"},
        {"Hipparcos Number", "HIP 50400"},
        {"Geneva Identification System", "GEN# +1.00089070"},
        {"Smithsonian Astrophysical Observation", "SAO 43271"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.37633500),
        dec: Angle.Degrees(+45.01883522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19627"},
        {"Hipparcos Number", "HIP 14811"},
        {"Smithsonian Astrophysical Observation", "SAO 38624"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.80954230),
        dec: Angle.Degrees(+45.01898384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10212"},
        {"Hipparcos Number", "HIP 7837"},
        {"Smithsonian Astrophysical Observation", "SAO 37422"},
        {"Wilson Evans Batten Catalogue", "WEB 1675"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.20723264),
        dec: Angle.Degrees(+45.01908157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141244"},
        {"Hipparcos Number", "HIP 77241"},
        {"Smithsonian Astrophysical Observation", "SAO 45719"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.56854340),
        dec: Angle.Degrees(+45.02191479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213312"},
        {"Hipparcos Number", "HIP 111035"},
        {"Smithsonian Astrophysical Observation", "SAO 52059"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.41731015),
        dec: Angle.Degrees(+45.02263248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155542"},
        {"Hipparcos Number", "HIP 83993"},
        {"Smithsonian Astrophysical Observation", "SAO 46532"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.54810317),
        dec: Angle.Degrees(+45.02656908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41127",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41127"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.87385653),
        dec: Angle.Degrees(+45.02722717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181827"},
        {"Hipparcos Number", "HIP 95005"},
        {"Smithsonian Astrophysical Observation", "SAO 48343"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.97939244),
        dec: Angle.Degrees(+45.03202143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161569"},
        {"Hipparcos Number", "HIP 86791"},
        {"Smithsonian Astrophysical Observation", "SAO 46917"},
        {"Wilson Evans Batten Catalogue", "WEB 14637"},
    },
    visualMagnitude: 6.75,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.01796114),
        dec: Angle.Degrees(+45.03466307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31195"},
        {"Hipparcos Number", "HIP 22917"},
        {"Celescope Catalog", "CEL 487"},
        {"Geneva Identification System", "GEN# +1.00031195"},
        {"Smithsonian Astrophysical Observation", "SAO 39872"},
        {"Wilson Evans Batten Catalogue", "WEB 4449"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.97779153),
        dec: Angle.Degrees(+45.03475441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45000",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7208 AB"},
        {"Hipparcos Number", "HIP 45000"},
        {"Smithsonian Astrophysical Observation", "SAO 42728"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.48636964),
        dec: Angle.Degrees(+45.03503736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60481",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60481"},
        {"Geneva Identification System", "GEN# +0.04502030"},
        {"Smithsonian Astrophysical Observation", "SAO 44157"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.98493758),
        dec: Angle.Degrees(+45.03527359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48713"},
        {"Hipparcos Number", "HIP 32495"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.72167071),
        dec: Angle.Degrees(+45.03628157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42232"},
        {"Hipparcos Number", "HIP 29412"},
        {"Smithsonian Astrophysical Observation", "SAO 40934"},
    },
    visualMagnitude: 8.44,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.95817063),
        dec: Angle.Degrees(+45.03631929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34746",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5845 AB"},
        {"Henry Draper", "HD 54614"},
        {"Hipparcos Number", "HIP 34746"},
        {"Smithsonian Astrophysical Observation", "SAO 41609"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.90726802),
        dec: Angle.Degrees(+45.03800655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41123",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41123"},
        {"Smithsonian Astrophysical Observation", "SAO 42328"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.86796428),
        dec: Angle.Degrees(+45.03808545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42244",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42244"},
        {"Smithsonian Astrophysical Observation", "SAO 42447"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.18401201),
        dec: Angle.Degrees(+45.04257086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55619"},
        {"Hipparcos Number", "HIP 35140"},
        {"Geneva Identification System", "GEN# +1.00055619"},
        {"Smithsonian Astrophysical Observation", "SAO 41648"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.96416032),
        dec: Angle.Degrees(+45.04334878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 184.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88935"},
        {"Hipparcos Number", "HIP 50318"},
        {"Geneva Identification System", "GEN# +1.00088935"},
        {"Smithsonian Astrophysical Observation", "SAO 43261"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.13016747),
        dec: Angle.Degrees(+45.04345701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20861",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20861"},
        {"Smithsonian Astrophysical Observation", "SAO 39550"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.05612463),
        dec: Angle.Degrees(+45.04566712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42309"},
        {"Hipparcos Number", "HIP 29448"},
        {"Fundamental Katalog 5th Edition", "FK5 4565"},
        {"Geneva Identification System", "GEN# +1.00042309"},
        {"Smithsonian Astrophysical Observation", "SAO 40939"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.07139061),
        dec: Angle.Degrees(+45.04777708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88823",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88823"},
        {"Smithsonian Astrophysical Observation", "SAO 47245"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.97017569),
        dec: Angle.Degrees(+45.04809235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16235",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2559"},
        {"Henry Draper", "HD 21448"},
        {"Hipparcos Number", "HIP 16235"},
        {"Geneva Identification System", "GEN# +1.00021448J"},
        {"Smithsonian Astrophysical Observation", "SAO 38873"},
        {"Wilson Evans Batten Catalogue", "WEB 3094"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.30728150),
        dec: Angle.Degrees(+45.04932852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11006"},
        {"Hipparcos Number", "HIP 8461"},
        {"Smithsonian Astrophysical Observation", "SAO 37534"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.27600192),
        dec: Angle.Degrees(+45.05048398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117758",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117758"},
        {"Smithsonian Astrophysical Observation", "SAO 53443"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.21653283),
        dec: Angle.Degrees(+45.05175666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22338"},
        {"Hipparcos Number", "HIP 16906"},
        {"Smithsonian Astrophysical Observation", "SAO 38990"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.38682054),
        dec: Angle.Degrees(+45.05420823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222108"},
        {"Hipparcos Number", "HIP 116583"},
        {"Smithsonian Astrophysical Observation", "SAO 53203"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.38414331),
        dec: Angle.Degrees(+45.05466997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203341"},
        {"Hipparcos Number", "HIP 105332"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.03350733),
        dec: Angle.Degrees(+45.05691507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15463"},
        {"Hipparcos Number", "HIP 11684"},
        {"Geneva Identification System", "GEN# +1.00015463"},
        {"Smithsonian Astrophysical Observation", "SAO 38079"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.67492859),
        dec: Angle.Degrees(+45.05710824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221661"},
        {"Hipparcos Number", "HIP 116292"},
        {"Geneva Identification System", "GEN# +1.00221661"},
        {"Smithsonian Astrophysical Observation", "SAO 53147"},
        {"Wilson Evans Batten Catalogue", "WEB 20552"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.42912951),
        dec: Angle.Degrees(+45.05807278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32446"},
        {"Hipparcos Number", "HIP 23682"},
        {"Celescope Catalog", "CEL 525"},
        {"Geneva Identification System", "GEN# +1.00032446"},
        {"Smithsonian Astrophysical Observation", "SAO 40009"},
        {"Wilson Evans Batten Catalogue", "WEB 4617"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.35569117),
        dec: Angle.Degrees(+45.05818074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43150"},
        {"Smithsonian Astrophysical Observation", "SAO 42544"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.83702748),
        dec: Angle.Degrees(+45.05899362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60653"},
        {"Hipparcos Number", "HIP 37125"},
        {"Geneva Identification System", "GEN# +1.00060653"},
        {"Smithsonian Astrophysical Observation", "SAO 41892"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.42806902),
        dec: Angle.Degrees(+45.05932458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17671"},
        {"Hipparcos Number", "HIP 13343"},
        {"Smithsonian Astrophysical Observation", "SAO 38398"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.93005413),
        dec: Angle.Degrees(+45.05977592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87600"},
        {"Hipparcos Number", "HIP 49563"},
        {"Fundamental Katalog 5th Edition", "FK5 4900"},
        {"Geneva Identification System", "GEN# +1.00087600"},
        {"Smithsonian Astrophysical Observation", "SAO 43197"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.78328719),
        dec: Angle.Degrees(+45.05997506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91348",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91348"},
        {"Smithsonian Astrophysical Observation", "SAO 47664"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.47939917),
        dec: Angle.Degrees(+45.06151220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97711"},
        {"Hipparcos Number", "HIP 54947"},
        {"Geneva Identification System", "GEN# +1.00097711"},
        {"Smithsonian Astrophysical Observation", "SAO 43657"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.77983442),
        dec: Angle.Degrees(+45.06154791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52607"},
        {"Hipparcos Number", "HIP 34089"},
        {"Geneva Identification System", "GEN# +1.00052607"},
        {"Smithsonian Astrophysical Observation", "SAO 41535"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.02853579),
        dec: Angle.Degrees(+45.06344072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47984",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47984"},
        {"Smithsonian Astrophysical Observation", "SAO 43033"},
        {"Wilson Evans Batten Catalogue", "WEB 8977"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.70739150),
        dec: Angle.Degrees(+45.07013734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47019"},
        {"Hipparcos Number", "HIP 31780"},
        {"Smithsonian Astrophysical Observation", "SAO 41229"},
        {"Wilson Evans Batten Catalogue", "WEB 6377"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.67642661),
        dec: Angle.Degrees(+45.07057786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39891"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.21920074),
        dec: Angle.Degrees(+45.07216547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222416"},
        {"Hipparcos Number", "HIP 116789"},
        {"Renson", "Renson 61000"},
        {"Smithsonian Astrophysical Observation", "SAO 53259"},
        {"Wilson Evans Batten Catalogue", "WEB 20609"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.05058379),
        dec: Angle.Degrees(+45.07367888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77368"},
        {"Smithsonian Astrophysical Observation", "SAO 45730"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.89772081),
        dec: Angle.Degrees(+45.07465623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82228"},
        {"Hipparcos Number", "HIP 46795"},
        {"Smithsonian Astrophysical Observation", "SAO 42905"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.03845384),
        dec: Angle.Degrees(+45.07657206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20494",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20494"},
        {"Smithsonian Astrophysical Observation", "SAO 39499"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.88648156),
        dec: Angle.Degrees(+45.07904763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25081",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3932 AB"},
        {"Henry Draper", "HD 34788"},
        {"Hipparcos Number", "HIP 25081"},
        {"Celescope Catalog", "CEL 640"},
        {"Smithsonian Astrophysical Observation", "SAO 40280"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.54595255),
        dec: Angle.Degrees(+45.08167682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216862"},
        {"Hipparcos Number", "HIP 113239"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.97421803),
        dec: Angle.Degrees(+45.08295364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85039"},
        {"Hipparcos Number", "HIP 48271"},
        {"Geneva Identification System", "GEN# +1.00085039"},
        {"Smithsonian Astrophysical Observation", "SAO 43063"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.62425766),
        dec: Angle.Degrees(+45.08391127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88630"},
        {"Hipparcos Number", "HIP 50147"},
        {"Geneva Identification System", "GEN# +1.00088630"},
        {"Smithsonian Astrophysical Observation", "SAO 43243"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.55243478),
        dec: Angle.Degrees(+45.08714980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19056"},
        {"Hipparcos Number", "HIP 14383"},
        {"Smithsonian Astrophysical Observation", "SAO 38561"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.38772448),
        dec: Angle.Degrees(+45.08803094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1918"},
        {"Hipparcos Number", "HIP 1879"},
        {"Geneva Identification System", "GEN# +1.00001918"},
        {"Smithsonian Astrophysical Observation", "SAO 36322"},
        {"Wilson Evans Batten Catalogue", "WEB 332"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.93004111),
        dec: Angle.Degrees(+45.08909823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211431"},
        {"Hipparcos Number", "HIP 109944"},
        {"Smithsonian Astrophysical Observation", "SAO 51817"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.00386818),
        dec: Angle.Degrees(+45.08912515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59885"},
        {"Geneva Identification System", "GEN# +0.04502016"},
        {"Smithsonian Astrophysical Observation", "SAO 44104"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.22060363),
        dec: Angle.Degrees(+45.08913652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14401"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.44213538),
        dec: Angle.Degrees(+45.09008840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 235.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27554",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4414 AB"},
        {"Henry Draper", "HD 38730"},
        {"Hipparcos Number", "HIP 27554"},
        {"Celescope Catalog", "CEL 991"},
        {"Geneva Identification System", "GEN# +1.00038730J"},
        {"Smithsonian Astrophysical Observation", "SAO 40631"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.52680126),
        dec: Angle.Degrees(+45.09243499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22141",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22141"},
        {"Smithsonian Astrophysical Observation", "SAO 39729"},
        {"Wilson Evans Batten Catalogue", "WEB 4260"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.46675624),
        dec: Angle.Degrees(+45.09250610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9740",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9740"},
        {"Smithsonian Astrophysical Observation", "SAO 37752"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.32569389),
        dec: Angle.Degrees(+45.09282588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50973"},
        {"Hipparcos Number", "HIP 33485"},
        {"Fundamental Katalog 5th Edition", "FK5 2537"},
        {"Geneva Identification System", "GEN# +1.00050973"},
        {"Smithsonian Astrophysical Observation", "SAO 41463"},
        {"Wilson Evans Batten Catalogue", "WEB 6732"},
    },
    visualMagnitude: 4.90,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.40468738),
        dec: Angle.Degrees(+45.09410202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69474",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69474"},
        {"Smithsonian Astrophysical Observation", "SAO 44942"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.34575957),
        dec: Angle.Degrees(+45.09728103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114435",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114435"},
        {"Smithsonian Astrophysical Observation", "SAO 52763"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.63981534),
        dec: Angle.Degrees(+45.09946235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115883"},
        {"Hipparcos Number", "HIP 64991"},
        {"Geneva Identification System", "GEN# +1.00115883"},
        {"Smithsonian Astrophysical Observation", "SAO 44563"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.81760626),
        dec: Angle.Degrees(+45.09996146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82013",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82013"},
        {"Smithsonian Astrophysical Observation", "SAO 46263"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.29950103),
        dec: Angle.Degrees(+45.10367488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88767",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88767"},
        {"Smithsonian Astrophysical Observation", "SAO 47234"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.83100460),
        dec: Angle.Degrees(+45.10411787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207181"},
        {"Hipparcos Number", "HIP 107468"},
        {"Smithsonian Astrophysical Observation", "SAO 51275"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.50944096),
        dec: Angle.Degrees(+45.10583884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102895"},
        {"Hipparcos Number", "HIP 57780"},
        {"Smithsonian Astrophysical Observation", "SAO 43912"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.73172231),
        dec: Angle.Degrees(+45.10616194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65375",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65375"},
        {"Geneva Identification System", "GEN# +0.04502107"},
    },
    visualMagnitude: 10.70,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.97191364),
        dec: Angle.Degrees(+45.10661167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43962"},
        {"Hipparcos Number", "HIP 30208"},
        {"Smithsonian Astrophysical Observation", "SAO 41038"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.33295182),
        dec: Angle.Degrees(+45.10704984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35956",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35956"},
        {"Smithsonian Astrophysical Observation", "SAO 41746"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.18175929),
        dec: Angle.Degrees(+45.10740524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101177"},
        {"Hipparcos Number", "HIP 56809"},
        {"Cincinnati Publication", "Ci 20 653"},
        {"Wilson Evans Batten Catalogue", "WEB 10228"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.68913216),
        dec: Angle.Degrees(+45.10837959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -593.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63026",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63026"},
        {"Geneva Identification System", "GEN# +0.04502069"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.73768452),
        dec: Angle.Degrees(+45.10884458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116044"},
        {"Hipparcos Number", "HIP 65079"},
        {"Geneva Identification System", "GEN# +1.00116044"},
        {"Smithsonian Astrophysical Observation", "SAO 44571"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.09657688),
        dec: Angle.Degrees(+45.10940634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103167",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14411 AB"},
        {"Henry Draper", "HD 199206"},
        {"Hipparcos Number", "HIP 103167"},
        {"Celescope Catalog", "CEL 5198"},
        {"Geneva Identification System", "GEN# +1.00199206J"},
        {"Smithsonian Astrophysical Observation", "SAO 50205"},
        {"Wilson Evans Batten Catalogue", "WEB 18739"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.52473619),
        dec: Angle.Degrees(+45.11014799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59330"},
        {"Hipparcos Number", "HIP 36593"},
        {"Geneva Identification System", "GEN# +1.00059330"},
        {"Smithsonian Astrophysical Observation", "SAO 41831"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.88909505),
        dec: Angle.Degrees(+45.11208434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209932"},
        {"Hipparcos Number", "HIP 109079"},
        {"Celescope Catalog", "CEL 5433"},
        {"Geneva Identification System", "GEN# +1.00209932"},
        {"Smithsonian Astrophysical Observation", "SAO 51640"},
        {"Wilson Evans Batten Catalogue", "WEB 19612"},
    },
    visualMagnitude: 6.50,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.46015723),
        dec: Angle.Degrees(+45.11251200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84453"},
        {"Hipparcos Number", "HIP 47973"},
        {"Geneva Identification System", "GEN# +1.00084453"},
        {"Smithsonian Astrophysical Observation", "SAO 43030"},
        {"Wilson Evans Batten Catalogue", "WEB 8975"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.67683150),
        dec: Angle.Degrees(+45.11471410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71660"},
        {"Hipparcos Number", "HIP 41725"},
        {"Smithsonian Astrophysical Observation", "SAO 42398"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.62249108),
        dec: Angle.Degrees(+45.11500712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54939",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54939"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.76166103),
        dec: Angle.Degrees(+45.11586153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139937"},
        {"Hipparcos Number", "HIP 76653"},
        {"Geneva Identification System", "GEN# +1.00139937"},
        {"Smithsonian Astrophysical Observation", "SAO 45663"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.79911840),
        dec: Angle.Degrees(+45.11736616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110815",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110815"},
        {"Smithsonian Astrophysical Observation", "SAO 52014"},
    },
    visualMagnitude: 9.14,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.77139546),
        dec: Angle.Degrees(+45.11873174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18188"},
        {"Hipparcos Number", "HIP 13734"},
        {"Smithsonian Astrophysical Observation", "SAO 38461"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.21541301),
        dec: Angle.Degrees(+45.12207256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11969"},
        {"Hipparcos Number", "HIP 9218"},
        {"Smithsonian Astrophysical Observation", "SAO 37668"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.63491283),
        dec: Angle.Degrees(+45.12287119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81038",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81038"},
        {"Smithsonian Astrophysical Observation", "SAO 46155"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.26106143),
        dec: Angle.Degrees(+45.12773017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56149"},
        {"Hipparcos Number", "HIP 35339"},
        {"Geneva Identification System", "GEN# +1.00056149"},
        {"Smithsonian Astrophysical Observation", "SAO 41676"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.50567303),
        dec: Angle.Degrees(+45.12873794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60848",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60848"},
        {"Geneva Identification System", "GEN# +0.04502039"},
        {"Smithsonian Astrophysical Observation", "SAO 44191"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.07226450),
        dec: Angle.Degrees(+45.12887226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165220"},
        {"Hipparcos Number", "HIP 88367"},
        {"Smithsonian Astrophysical Observation", "SAO 47164"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.67517915),
        dec: Angle.Degrees(+45.12984760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97165",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Fawaris"},
        {"Aitken", "ADS 12880 A"},
        {"Henry Draper", "HD 186882"},
        {"Hipparcos Number", "HIP 97165"},
        {"Celescope Catalog", "CEL 4834"},
        {"Geneva Identification System", "GEN# +1.00186882"},
        {"Smithsonian Astrophysical Observation", "SAO 48796"},
        {"Wilson Evans Batten Catalogue", "WEB 17060"},
    },
    visualMagnitude: 2.86,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.24350878),
        dec: Angle.Degrees(+45.13069195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8572"},
        {"Hipparcos Number", "HIP 6671"},
        {"Smithsonian Astrophysical Observation", "SAO 37194"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.40566889),
        dec: Angle.Degrees(+45.13338684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5006"},
        {"Hipparcos Number", "HIP 4100"},
        {"Smithsonian Astrophysical Observation", "SAO 36732"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.15835174),
        dec: Angle.Degrees(+45.13346368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175055"},
        {"Hipparcos Number", "HIP 92541"},
        {"Smithsonian Astrophysical Observation", "SAO 47863"},
        {"Wilson Evans Batten Catalogue", "WEB 16006"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.87309637),
        dec: Angle.Degrees(+45.13371853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109216",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109216"},
        {"Smithsonian Astrophysical Observation", "SAO 51668"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.87755570),
        dec: Angle.Degrees(+45.13602569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199312"},
        {"Hipparcos Number", "HIP 103222"},
        {"Celescope Catalog", "CEL 5206"},
        {"Geneva Identification System", "GEN# +1.00199312"},
        {"Smithsonian Astrophysical Observation", "SAO 50219"},
        {"Wilson Evans Batten Catalogue", "WEB 18756"},
    },
    visualMagnitude: 7.66,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.68871987),
        dec: Angle.Degrees(+45.13627626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216256"},
        {"Hipparcos Number", "HIP 112820"},
        {"Smithsonian Astrophysical Observation", "SAO 52418"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.70467855),
        dec: Angle.Degrees(+45.13632856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219891"},
        {"Hipparcos Number", "HIP 115120"},
        {"Geneva Identification System", "GEN# +1.00219891"},
        {"Smithsonian Astrophysical Observation", "SAO 52892"},
        {"Wilson Evans Batten Catalogue", "WEB 20393"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.75985783),
        dec: Angle.Degrees(+45.13677118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77103"},
        {"Hipparcos Number", "HIP 44350"},
        {"Fundamental Katalog 5th Edition", "FK5 4803"},
        {"Smithsonian Astrophysical Observation", "SAO 42649"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.48413694),
        dec: Angle.Degrees(+45.13732935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87679"},
        {"Hipparcos Number", "HIP 49632"},
        {"Geneva Identification System", "GEN# +1.00087679"},
        {"Smithsonian Astrophysical Observation", "SAO 43202"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.93773628),
        dec: Angle.Degrees(+45.13742814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213519"},
        {"Hipparcos Number", "HIP 111148"},
        {"Geneva Identification System", "GEN# +1.00213519"},
        {"Smithsonian Astrophysical Observation", "SAO 52097"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.77446029),
        dec: Angle.Degrees(+45.14501181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -176.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46822"},
        {"Hipparcos Number", "HIP 31684"},
        {"Smithsonian Astrophysical Observation", "SAO 41218"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.43587965),
        dec: Angle.Degrees(+45.14645770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126510"},
        {"Hipparcos Number", "HIP 70449"},
        {"Smithsonian Astrophysical Observation", "SAO 45044"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.16434606),
        dec: Angle.Degrees(+45.14789835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42603"},
        {"Smithsonian Astrophysical Observation", "SAO 42486"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.24419870),
        dec: Angle.Degrees(+45.14974820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103525"},
        {"Geneva Identification System", "GEN# +0.04403655"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.60632318),
        dec: Angle.Degrees(+45.14975732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97578",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13010 A"},
        {"Henry Draper", "HD 187810"},
        {"Hipparcos Number", "HIP 97578"},
        {"Smithsonian Astrophysical Observation", "SAO 48880"},
        {"Wilson Evans Batten Catalogue", "WEB 17160"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.49741824),
        dec: Angle.Degrees(+45.15148735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6882",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1160 AB"},
        {"Henry Draper", "HD 8893"},
        {"Hipparcos Number", "HIP 6882"},
        {"Smithsonian Astrophysical Observation", "SAO 37249"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.15500275),
        dec: Angle.Degrees(+45.15212755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214097"},
        {"Hipparcos Number", "HIP 111487"},
        {"Smithsonian Astrophysical Observation", "SAO 52162"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.81527097),
        dec: Angle.Degrees(+45.15342245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191331"},
        {"Hipparcos Number", "HIP 99136"},
        {"Geneva Identification System", "GEN# +1.00191331"},
        {"Smithsonian Astrophysical Observation", "SAO 49205"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.89337741),
        dec: Angle.Degrees(+45.15342514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121933"},
        {"Hipparcos Number", "HIP 68187"},
        {"Smithsonian Astrophysical Observation", "SAO 44815"},
        {"Wilson Evans Batten Catalogue", "WEB 11962"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.39196845),
        dec: Angle.Degrees(+45.15582950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120082",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8250 D"},
        {"Henry Draper", "HD 101319"},
        {"Hipparcos Number", "HIP 120082"},
        {"Geneva Identification System", "GEN# +1.00101319"},
        {"Smithsonian Astrophysical Observation", "SAO 43853"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.95776533),
        dec: Angle.Degrees(+45.15661385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168564"},
        {"Hipparcos Number", "HIP 89689"},
        {"Fundamental Katalog 5th Edition", "FK5 5612"},
        {"Smithsonian Astrophysical Observation", "SAO 47369"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.55039828),
        dec: Angle.Degrees(+45.15669021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95896"},
        {"Hipparcos Number", "HIP 54135"},
        {"Smithsonian Astrophysical Observation", "SAO 43604"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.12922213),
        dec: Angle.Degrees(+45.15712675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97576",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13010 D"},
        {"Hipparcos Number", "HIP 97576"},
        {"Smithsonian Astrophysical Observation", "SAO 48879"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.49064655),
        dec: Angle.Degrees(+45.15859639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96735",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96735"},
        {"Smithsonian Astrophysical Observation", "SAO 48701"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.96717956),
        dec: Angle.Degrees(+45.15916632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 281.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40470"},
        {"Hipparcos Number", "HIP 28527"},
        {"Geneva Identification System", "GEN# +1.00040470"},
        {"Smithsonian Astrophysical Observation", "SAO 40788"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.32320393),
        dec: Angle.Degrees(+45.16049139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53446",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53446"},
        {"Smithsonian Astrophysical Observation", "SAO 43528"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.00192129),
        dec: Angle.Degrees(+45.16361208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74388"},
        {"Smithsonian Astrophysical Observation", "SAO 45429"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.02732913),
        dec: Angle.Degrees(+45.16390924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 152.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219668"},
        {"Hipparcos Number", "HIP 114981"},
        {"Geneva Identification System", "GEN# +1.00219668"},
        {"Smithsonian Astrophysical Observation", "SAO 52865"},
        {"Wilson Evans Batten Catalogue", "WEB 20370"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.31912592),
        dec: Angle.Degrees(+45.16431817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99750"},
        {"Hipparcos Number", "HIP 56017"},
        {"Smithsonian Astrophysical Observation", "SAO 43762"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.20709220),
        dec: Angle.Degrees(+45.16484586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44538"},
        {"Hipparcos Number", "HIP 30490"},
        {"Smithsonian Astrophysical Observation", "SAO 41073"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.13802939),
        dec: Angle.Degrees(+45.16730509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59932",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59932"},
        {"Cincinnati Publication", "Ci 18 1538"},
        {"Geneva Identification System", "GEN# +0.04502018"},
        {"Smithsonian Astrophysical Observation", "SAO 44110"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.39803004),
        dec: Angle.Degrees(+45.16873666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -283.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202312"},
        {"Hipparcos Number", "HIP 104781"},
        {"Geneva Identification System", "GEN# +1.00202312"},
        {"Smithsonian Astrophysical Observation", "SAO 50590"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.40042346),
        dec: Angle.Degrees(+45.16877098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170560"},
        {"Hipparcos Number", "HIP 90489"},
        {"Smithsonian Astrophysical Observation", "SAO 47513"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.96291909),
        dec: Angle.Degrees(+45.16892193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42877"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.07455093),
        dec: Angle.Degrees(+45.17012346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120462"},
        {"Hipparcos Number", "HIP 67382"},
        {"Smithsonian Astrophysical Observation", "SAO 44758"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.15221919),
        dec: Angle.Degrees(+45.17042972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195788"},
        {"Hipparcos Number", "HIP 101271"},
        {"Celescope Catalog", "CEL 5097"},
        {"Geneva Identification System", "GEN# +1.00195788"},
        {"Smithsonian Astrophysical Observation", "SAO 49746"},
    },
    visualMagnitude: 7.95,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.91409600),
        dec: Angle.Degrees(+45.17129062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7074"},
        {"Hipparcos Number", "HIP 5599"},
        {"Smithsonian Astrophysical Observation", "SAO 37006"},
    },
    visualMagnitude: 8.66,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.94528223),
        dec: Angle.Degrees(+45.17186912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131381"},
        {"Hipparcos Number", "HIP 72693"},
        {"Smithsonian Astrophysical Observation", "SAO 45244"},
        {"Wilson Evans Batten Catalogue", "WEB 12499"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.93803273),
        dec: Angle.Degrees(+45.17232040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180551"},
        {"Hipparcos Number", "HIP 94586"},
        {"Smithsonian Astrophysical Observation", "SAO 48235"},
    },
    visualMagnitude: 8.08,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.74159864),
        dec: Angle.Degrees(+45.17496575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105804"},
        {"Hipparcos Number", "HIP 59362"},
        {"Smithsonian Astrophysical Observation", "SAO 44063"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.68350235),
        dec: Angle.Degrees(+45.17506864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196133"},
        {"Hipparcos Number", "HIP 101452"},
        {"Celescope Catalog", "CEL 5114"},
        {"Geneva Identification System", "GEN# +1.00196133"},
        {"Renson", "Renson 54660"},
        {"Smithsonian Astrophysical Observation", "SAO 49795"},
        {"Wilson Evans Batten Catalogue", "WEB 18330"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.41508749),
        dec: Angle.Degrees(+45.17555196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77983"},
        {"Hipparcos Number", "HIP 44758"},
        {"Geneva Identification System", "GEN# +1.00077983"},
        {"Smithsonian Astrophysical Observation", "SAO 42700"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.83153413),
        dec: Angle.Degrees(+45.17611139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220221"},
        {"Hipparcos Number", "HIP 115341"},
        {"Smithsonian Astrophysical Observation", "SAO 52939"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.43453700),
        dec: Angle.Degrees(+45.17623102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 197.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75744",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75744"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.11399835),
        dec: Angle.Degrees(+45.17909114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1081"},
        {"Hipparcos Number", "HIP 1229"},
        {"Smithsonian Astrophysical Observation", "SAO 36200"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.81774766),
        dec: Angle.Degrees(+45.17922002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64306"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.70098049),
        dec: Angle.Degrees(+45.17982916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115120"},
        {"Hipparcos Number", "HIP 64596"},
        {"Smithsonian Astrophysical Observation", "SAO 44524"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.60456530),
        dec: Angle.Degrees(+45.18056905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85842"},
        {"Hipparcos Number", "HIP 48689"},
        {"Smithsonian Astrophysical Observation", "SAO 43104"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.94137787),
        dec: Angle.Degrees(+45.18138472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199098"},
        {"Hipparcos Number", "HIP 103094"},
        {"Geneva Identification System", "GEN# +1.00199098"},
        {"Smithsonian Astrophysical Observation", "SAO 50182"},
        {"Wilson Evans Batten Catalogue", "WEB 18718"},
    },
    visualMagnitude: 5.48,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.32732775),
        dec: Angle.Degrees(+45.18168341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214558"},
        {"Hipparcos Number", "HIP 111753"},
        {"Geneva Identification System", "GEN# +1.00214558"},
        {"Smithsonian Astrophysical Observation", "SAO 52211"},
        {"Wilson Evans Batten Catalogue", "WEB 19965"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.57252472),
        dec: Angle.Degrees(+45.18295148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99592"},
        {"Hipparcos Number", "HIP 55936"},
        {"Geneva Identification System", "GEN# +1.00099592"},
        {"Smithsonian Astrophysical Observation", "SAO 43748"},
        {"Wilson Evans Batten Catalogue", "WEB 10043"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.95994485),
        dec: Angle.Degrees(+45.18525332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130044"},
        {"Hipparcos Number", "HIP 72066"},
        {"Geneva Identification System", "GEN# +1.00130044"},
        {"Smithsonian Astrophysical Observation", "SAO 45197"},
        {"Wilson Evans Batten Catalogue", "WEB 12400"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.11735772),
        dec: Angle.Degrees(+45.18601895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3498"},
        {"Hipparcos Number", "HIP 3015"},
        {"Smithsonian Astrophysical Observation", "SAO 36533"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.59684483),
        dec: Angle.Degrees(+45.18682260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216670"},
        {"Hipparcos Number", "HIP 113087"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.53439891),
        dec: Angle.Degrees(+45.18776070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9867"},
        {"Cincinnati Publication", "Ci 20 146"},
        {"Wilson Evans Batten Catalogue", "WEB 2071"},
    },
    visualMagnitude: 10.23,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)06, 56.5400),
        dec: Angle.DegreesMinutesSeconds((int)+45, (int)11, 19.700)
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
    primaryId: "HIP 59347",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59347"},
    },
    visualMagnitude: 10.86,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.61532211),
        dec: Angle.Degrees(+45.19388860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37192",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37192"},
        {"Smithsonian Astrophysical Observation", "SAO 41901"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.61077293),
        dec: Angle.Degrees(+45.19434884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12073",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12073"},
        {"Smithsonian Astrophysical Observation", "SAO 38149"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.91215899),
        dec: Angle.Degrees(+45.19464545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86839",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86839"},
        {"Renson", "Renson 45590"},
        {"Smithsonian Astrophysical Observation", "SAO 46925"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.15528492),
        dec: Angle.Degrees(+45.19466350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215027"},
        {"Hipparcos Number", "HIP 112044"},
        {"Smithsonian Astrophysical Observation", "SAO 52275"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.41198503),
        dec: Angle.Degrees(+45.19479667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191508"},
        {"Hipparcos Number", "HIP 99213"},
        {"Geneva Identification System", "GEN# +1.00191508"},
        {"Smithsonian Astrophysical Observation", "SAO 49229"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.11600415),
        dec: Angle.Degrees(+45.19654622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72356"},
        {"Hipparcos Number", "HIP 42051"},
        {"Geneva Identification System", "GEN# +1.00072356"},
        {"Smithsonian Astrophysical Observation", "SAO 42432"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.56625703),
        dec: Angle.Degrees(+45.19670114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48995"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.93529149),
        dec: Angle.Degrees(+45.19695564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124474"},
        {"Hipparcos Number", "HIP 69405"},
        {"Smithsonian Astrophysical Observation", "SAO 44938"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.15103441),
        dec: Angle.Degrees(+45.19783860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95045"},
        {"Hipparcos Number", "HIP 53681"},
        {"Geneva Identification System", "GEN# +1.00095045"},
        {"Smithsonian Astrophysical Observation", "SAO 43552"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.75252129),
        dec: Angle.Degrees(+45.19789252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152030"},
        {"Hipparcos Number", "HIP 82297"},
        {"Smithsonian Astrophysical Observation", "SAO 46301"},
        {"Wilson Evans Batten Catalogue", "WEB 13895"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.23765329),
        dec: Angle.Degrees(+45.20103909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5385",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 936 AB"},
        {"Henry Draper", "HD 6757"},
        {"Hipparcos Number", "HIP 5385"},
        {"Renson", "Renson 1750"},
        {"Smithsonian Astrophysical Observation", "SAO 36962"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.22145461),
        dec: Angle.Degrees(+45.20747613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67872"},
        {"Hipparcos Number", "HIP 40149"},
        {"Smithsonian Astrophysical Observation", "SAO 42220"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.97918393),
        dec: Angle.Degrees(+45.20931691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168009"},
        {"Hipparcos Number", "HIP 89474"},
        {"Geneva Identification System", "GEN# +1.00168009"},
        {"Smithsonian Astrophysical Observation", "SAO 47343"},
        {"Wilson Evans Batten Catalogue", "WEB 15226"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.88553064),
        dec: Angle.Degrees(+45.20959588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14104"},
        {"Hipparcos Number", "HIP 10734"},
        {"Fundamental Katalog 5th Edition", "FK5 4213"},
        {"Smithsonian Astrophysical Observation", "SAO 37934"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.53887857),
        dec: Angle.Degrees(+45.21038776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90602"},
        {"Hipparcos Number", "HIP 51290"},
        {"Fundamental Katalog 5th Edition", "FK5 2838"},
        {"Geneva Identification System", "GEN# +1.00090602"},
        {"Smithsonian Astrophysical Observation", "SAO 43356"},
        {"Wilson Evans Batten Catalogue", "WEB 9369"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.15224061),
        dec: Angle.Degrees(+45.21226261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215458"},
        {"Hipparcos Number", "HIP 112279"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.13675553),
        dec: Angle.Degrees(+45.21228576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28943"},
        {"Hipparcos Number", "HIP 21413"},
        {"Smithsonian Astrophysical Observation", "SAO 39630"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.93643578),
        dec: Angle.Degrees(+45.21458035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193631"},
        {"Hipparcos Number", "HIP 100203"},
        {"Smithsonian Astrophysical Observation", "SAO 49470"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.86152067),
        dec: Angle.Degrees(+45.21501731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8150"},
        {"Hipparcos Number", "HIP 6357"},
        {"Smithsonian Astrophysical Observation", "SAO 37147"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.41189622),
        dec: Angle.Degrees(+45.21598443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48172"},
        {"Hipparcos Number", "HIP 32283"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.09181065),
        dec: Angle.Degrees(+45.21654297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147441"},
        {"Hipparcos Number", "HIP 80020"},
        {"Smithsonian Astrophysical Observation", "SAO 46030"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.01700434),
        dec: Angle.Degrees(+45.21663000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163608"},
        {"Hipparcos Number", "HIP 87694"},
        {"Geneva Identification System", "GEN# +1.00163608"},
        {"Smithsonian Astrophysical Observation", "SAO 47057"},
        {"Wilson Evans Batten Catalogue", "WEB 14801"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.68434412),
        dec: Angle.Degrees(+45.21700474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109979"},
        {"Hipparcos Number", "HIP 61674"},
        {"Geneva Identification System", "GEN# +1.00109979"},
        {"Smithsonian Astrophysical Observation", "SAO 44263"},
        {"Wilson Evans Batten Catalogue", "WEB 10971"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.63697709),
        dec: Angle.Degrees(+45.21717883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160401"},
        {"Hipparcos Number", "HIP 86251"},
        {"Geneva Identification System", "GEN# +1.00160401"},
        {"Smithsonian Astrophysical Observation", "SAO 46847"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.36972033),
        dec: Angle.Degrees(+45.21954109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169572"},
        {"Hipparcos Number", "HIP 90088"},
        {"Smithsonian Astrophysical Observation", "SAO 47451"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.76743575),
        dec: Angle.Degrees(+45.22039025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7924",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7924"},
        {"Smithsonian Astrophysical Observation", "SAO 37436"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.46297237),
        dec: Angle.Degrees(+45.22100438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65596"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.73903795),
        dec: Angle.Degrees(+45.22309290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109068"},
        {"Hipparcos Number", "HIP 61132"},
        {"Geneva Identification System", "GEN# +1.00109068"},
        {"Wilson Evans Batten Catalogue", "WEB 10883"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.91014533),
        dec: Angle.Degrees(+45.22563684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 421",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 46 C"},
        {"Hipparcos Number", "HIP 421"},
    },
    visualMagnitude: 8.83,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)05, 08.1100),
        dec: Angle.DegreesMinutesSeconds((int)+45, (int)13, 32.400)
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
    primaryId: "HIP 116280",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116280"},
        {"Smithsonian Astrophysical Observation", "SAO 53145"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.40133136),
        dec: Angle.Degrees(+45.22736589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56963"},
        {"Hipparcos Number", "HIP 35643"},
        {"Fundamental Katalog 5th Edition", "FK5 2567"},
        {"Geneva Identification System", "GEN# +1.00056963"},
        {"Renson", "Renson 15546"},
        {"Smithsonian Astrophysical Observation", "SAO 41708"},
        {"Wilson Evans Batten Catalogue", "WEB 7102"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.32308085),
        dec: Angle.Degrees(+45.22817039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35201"},
        {"Hipparcos Number", "HIP 25348"},
        {"Smithsonian Astrophysical Observation", "SAO 40320"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.32648836),
        dec: Angle.Degrees(+45.22858946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 424",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 46 A"},
        {"Henry Draper", "HD 3"},
        {"Hipparcos Number", "HIP 424"},
        {"Fundamental Katalog 5th Edition", "FK5 4009"},
        {"Geneva Identification System", "GEN# +1.00000003"},
        {"Smithsonian Astrophysical Observation", "SAO 36042"},
        {"Wilson Evans Batten Catalogue", "WEB 68"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.29075302),
        dec: Angle.Degrees(+45.22907883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114647",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114647"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.37536651),
        dec: Angle.Degrees(+45.23642645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38520"},
        {"Hipparcos Number", "HIP 27449"},
        {"Geneva Identification System", "GEN# +1.00038520"},
        {"Smithsonian Astrophysical Observation", "SAO 40617"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.18282425),
        dec: Angle.Degrees(+45.23720122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36333"},
        {"Hipparcos Number", "HIP 26038"},
        {"Smithsonian Astrophysical Observation", "SAO 40421"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.32069122),
        dec: Angle.Degrees(+45.23919198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20345"},
        {"Hipparcos Number", "HIP 15369"},
        {"Smithsonian Astrophysical Observation", "SAO 38708"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.54068303),
        dec: Angle.Degrees(+45.24128174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54402"},
        {"Hipparcos Number", "HIP 34676"},
        {"Smithsonian Astrophysical Observation", "SAO 41601"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.71604424),
        dec: Angle.Degrees(+45.24731486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78356",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78356"},
    },
    visualMagnitude: 10.53,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.97780983),
        dec: Angle.Degrees(+45.24866838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209993"},
        {"Hipparcos Number", "HIP 109121"},
        {"Celescope Catalog", "CEL 5435"},
        {"Geneva Identification System", "GEN# +1.00209993"},
        {"Smithsonian Astrophysical Observation", "SAO 51652"},
        {"Wilson Evans Batten Catalogue", "WEB 19618"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.55102489),
        dec: Angle.Degrees(+45.24870296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54959",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54959"},
        {"Smithsonian Astrophysical Observation", "SAO 43658"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.82190235),
        dec: Angle.Degrees(+45.25102160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224801"},
        {"Hipparcos Number", "HIP 63"},
        {"Geneva Identification System", "GEN# +1.00224801"},
        {"Renson", "Renson 61610"},
        {"Smithsonian Astrophysical Observation", "SAO 53568"},
        {"Wilson Evans Batten Catalogue", "WEB 6"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.18174950),
        dec: Angle.Degrees(+45.25333305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109838"},
        {"Hipparcos Number", "HIP 61612"},
        {"Geneva Identification System", "GEN# +1.00109838"},
        {"Smithsonian Astrophysical Observation", "SAO 44256"},
        {"Wilson Evans Batten Catalogue", "WEB 10959"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.38945684),
        dec: Angle.Degrees(+45.25372102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23288",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23288"},
        {"Smithsonian Astrophysical Observation", "SAO 39930"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.14096349),
        dec: Angle.Degrees(+45.25387160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36289"},
        {"Smithsonian Astrophysical Observation", "SAO 41785"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.04857722),
        dec: Angle.Degrees(+45.25551052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91635"},
        {"Hipparcos Number", "HIP 51862"},
        {"Smithsonian Astrophysical Observation", "SAO 43397"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.93540351),
        dec: Angle.Degrees(+45.25667962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26858"},
        {"Hipparcos Number", "HIP 19958"},
        {"Geneva Identification System", "GEN# +1.00026858"},
    },
    visualMagnitude: 9.11,
    bvColour: 2.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.19322830),
        dec: Angle.Degrees(+45.25979815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174504"},
        {"Hipparcos Number", "HIP 92291"},
        {"Geneva Identification System", "GEN# +1.00174504"},
        {"Smithsonian Astrophysical Observation", "SAO 47824"},
        {"Wilson Evans Batten Catalogue", "WEB 15927"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.15108358),
        dec: Angle.Degrees(+45.26155339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63916",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8775 AB"},
        {"Henry Draper", "HD 113847"},
        {"Hipparcos Number", "HIP 63916"},
        {"Fundamental Katalog 5th Edition", "FK5 1338"},
        {"Geneva Identification System", "GEN# +1.00113847J"},
        {"Smithsonian Astrophysical Observation", "SAO 44465"},
        {"Wilson Evans Batten Catalogue", "WEB 11295"},
    },
    visualMagnitude: 5.64,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.46783055),
        dec: Angle.Degrees(+45.26848988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201174"},
        {"Hipparcos Number", "HIP 104170"},
        {"Geneva Identification System", "GEN# +2.70390205"},
        {"Renson", "Renson 56130"},
        {"Smithsonian Astrophysical Observation", "SAO 50453"},
        {"New General Catalogue", "NGC 7039 205"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.59413667),
        dec: Angle.Degrees(+45.27051234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137390"},
        {"Hipparcos Number", "HIP 75369"},
        {"Fundamental Katalog 5th Edition", "FK5 3216"},
        {"Geneva Identification System", "GEN# +1.00137390"},
        {"Smithsonian Astrophysical Observation", "SAO 45521"},
        {"Wilson Evans Batten Catalogue", "WEB 12856"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.02136799),
        dec: Angle.Degrees(+45.27102537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11071"},
        {"Hipparcos Number", "HIP 8515"},
        {"Smithsonian Astrophysical Observation", "SAO 37546"},
        {"Wilson Evans Batten Catalogue", "WEB 1811"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.46292654),
        dec: Angle.Degrees(+45.27197641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93879",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93879"},
        {"Smithsonian Astrophysical Observation", "SAO 48100"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.77842924),
        dec: Angle.Degrees(+45.27752741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211622"},
        {"Hipparcos Number", "HIP 110050"},
        {"Smithsonian Astrophysical Observation", "SAO 51841"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.35520373),
        dec: Angle.Degrees(+45.27975075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102098",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Deneb"},
        {"Aitken", "ADS 14172 A"},
        {"Henry Draper", "HD 197345"},
        {"Hipparcos Number", "HIP 102098"},
        {"Celescope Catalog", "CEL 5144"},
        {"Fundamental Katalog 5th Edition", "FK5 777"},
        {"Geneva Identification System", "GEN# +1.00197345"},
        {"Smithsonian Astrophysical Observation", "SAO 49941"},
        {"Wilson Evans Batten Catalogue", "WEB 18466"},
    },
    visualMagnitude: 1.25,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.35797270),
        dec: Angle.Degrees(+45.28033423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72504",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72504"},
        {"Geneva Identification System", "GEN# +0.04502224"},
    },
    visualMagnitude: 10.70,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.36777971),
        dec: Angle.Degrees(+45.28059264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -162.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43694",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43694"},
        {"Smithsonian Astrophysical Observation", "SAO 42589"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.49572661),
        dec: Angle.Degrees(+45.28526042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122484"},
        {"Hipparcos Number", "HIP 68479"},
        {"Smithsonian Astrophysical Observation", "SAO 44847"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.29535887),
        dec: Angle.Degrees(+45.28585198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110510"},
        {"Smithsonian Astrophysical Observation", "SAO 51944"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.80688544),
        dec: Angle.Degrees(+45.28611620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82555"},
        {"Hipparcos Number", "HIP 46936"},
        {"Renson", "Renson 23465"},
        {"Smithsonian Astrophysical Observation", "SAO 42921"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.49166700),
        dec: Angle.Degrees(+45.28657786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94119"},
        {"Hipparcos Number", "HIP 53159"},
        {"Smithsonian Astrophysical Observation", "SAO 43502"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.13468143),
        dec: Angle.Degrees(+45.28703735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223892"},
        {"Hipparcos Number", "HIP 117798"},
        {"Smithsonian Astrophysical Observation", "SAO 53451"},
    },
    visualMagnitude: 8.41,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.34128212),
        dec: Angle.Degrees(+45.28807187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78678",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78678"},
        {"Geneva Identification System", "GEN# +0.04502368"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.92596693),
        dec: Angle.Degrees(+45.28960986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -180.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -229.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69917"},
        {"Hipparcos Number", "HIP 40917"},
        {"Smithsonian Astrophysical Observation", "SAO 42301"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.26148049),
        dec: Angle.Degrees(+45.29079119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79451"},
        {"Hipparcos Number", "HIP 45447"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.93256523),
        dec: Angle.Degrees(+45.29379050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12325"},
        {"Hipparcos Number", "HIP 9486"},
        {"Geneva Identification System", "GEN# +1.00012325"},
        {"Smithsonian Astrophysical Observation", "SAO 37711"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.50907360),
        dec: Angle.Degrees(+45.29426689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3691",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 654 AB"},
        {"Henry Draper", "HD 4478"},
        {"Hipparcos Number", "HIP 3691"},
        {"Renson", "Renson 1220"},
        {"Smithsonian Astrophysical Observation", "SAO 36657"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.83298045),
        dec: Angle.Degrees(+45.29489807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131861"},
        {"Hipparcos Number", "HIP 72939"},
        {"Geneva Identification System", "GEN# +1.00131861"},
        {"Smithsonian Astrophysical Observation", "SAO 45269"},
        {"Wilson Evans Batten Catalogue", "WEB 12518"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.60239523),
        dec: Angle.Degrees(+45.29866734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21108"},
        {"Hipparcos Number", "HIP 15999"},
        {"Smithsonian Astrophysical Observation", "SAO 38823"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.51763012),
        dec: Angle.Degrees(+45.29956012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47332"},
        {"Smithsonian Astrophysical Observation", "SAO 42960"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.67992294),
        dec: Angle.Degrees(+45.30009686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20426"},
        {"Hipparcos Number", "HIP 15435"},
        {"Smithsonian Astrophysical Observation", "SAO 38713"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.73440849),
        dec: Angle.Degrees(+45.30450783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47114",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47114"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.02182103),
        dec: Angle.Degrees(+45.30588517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157224"},
        {"Hipparcos Number", "HIP 84785"},
        {"Geneva Identification System", "GEN# +1.00157224"},
        {"Smithsonian Astrophysical Observation", "SAO 46638"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.96227688),
        dec: Angle.Degrees(+45.30841433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159659"},
        {"Hipparcos Number", "HIP 85932"},
        {"Geneva Identification System", "GEN# +1.00159659"},
        {"Smithsonian Astrophysical Observation", "SAO 46796"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.42238769),
        dec: Angle.Degrees(+45.30988204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125919"},
        {"Hipparcos Number", "HIP 70151"},
        {"Smithsonian Astrophysical Observation", "SAO 45007"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.30588151),
        dec: Angle.Degrees(+45.31149268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75523"},
        {"Hipparcos Number", "HIP 43553"},
        {"Geneva Identification System", "GEN# +1.00075523"},
        {"Smithsonian Astrophysical Observation", "SAO 42580"},
        {"Wilson Evans Batten Catalogue", "WEB 8393"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.04907327),
        dec: Angle.Degrees(+45.31290010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140869"},
        {"Hipparcos Number", "HIP 77061"},
        {"Geneva Identification System", "GEN# +1.00140869"},
        {"Smithsonian Astrophysical Observation", "SAO 45701"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.02299241),
        dec: Angle.Degrees(+45.31598657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113468",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113468"},
        {"Smithsonian Astrophysical Observation", "SAO 52552"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.68933401),
        dec: Angle.Degrees(+45.31999337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174600"},
        {"Hipparcos Number", "HIP 92334"},
        {"Geneva Identification System", "GEN# +1.00174600"},
        {"Smithsonian Astrophysical Observation", "SAO 47829"},
        {"Wilson Evans Batten Catalogue", "WEB 15942"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.27963062),
        dec: Angle.Degrees(+45.32136717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10486"},
        {"Hipparcos Number", "HIP 8044"},
        {"Geneva Identification System", "GEN# +1.00010486"},
        {"Smithsonian Astrophysical Observation", "SAO 37460"},
        {"Wilson Evans Batten Catalogue", "WEB 1723"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.81828533),
        dec: Angle.Degrees(+45.32263641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67825"},
        {"Hipparcos Number", "HIP 40125"},
        {"Smithsonian Astrophysical Observation", "SAO 42219"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.94258765),
        dec: Angle.Degrees(+45.32356139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21973"},
        {"Hipparcos Number", "HIP 16657"},
        {"Smithsonian Astrophysical Observation", "SAO 38954"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.58049800),
        dec: Angle.Degrees(+45.32411881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155816"},
        {"Hipparcos Number", "HIP 84106"},
        {"Smithsonian Astrophysical Observation", "SAO 46556"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.91604265),
        dec: Angle.Degrees(+45.32446486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214695"},
        {"Hipparcos Number", "HIP 111847"},
        {"Smithsonian Astrophysical Observation", "SAO 52229"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.82756751),
        dec: Angle.Degrees(+45.32840056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129001"},
        {"Hipparcos Number", "HIP 71611"},
        {"Smithsonian Astrophysical Observation", "SAO 45152"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.68685194),
        dec: Angle.Degrees(+45.33091450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55490",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8139 A"},
        {"Henry Draper", "HD 98696"},
        {"Hipparcos Number", "HIP 55490"},
        {"Geneva Identification System", "GEN# +1.00098696"},
        {"Smithsonian Astrophysical Observation", "SAO 43712"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.46174977),
        dec: Angle.Degrees(+45.33238474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8317"},
        {"Hipparcos Number", "HIP 6481"},
        {"Smithsonian Astrophysical Observation", "SAO 37166"},
        {"Wilson Evans Batten Catalogue", "WEB 1430"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.82543455),
        dec: Angle.Degrees(+45.33293722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155920"},
        {"Hipparcos Number", "HIP 84159"},
        {"Smithsonian Astrophysical Observation", "SAO 46566"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.08392379),
        dec: Angle.Degrees(+45.33330699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 158.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180681"},
        {"Hipparcos Number", "HIP 94636"},
        {"Smithsonian Astrophysical Observation", "SAO 48245"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.85907476),
        dec: Angle.Degrees(+45.33570336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109268"},
        {"Hipparcos Number", "HIP 61254"},
        {"Geneva Identification System", "GEN# +1.00109268"},
        {"Smithsonian Astrophysical Observation", "SAO 44225"},
        {"Wilson Evans Batten Catalogue", "WEB 10901"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.29117223),
        dec: Angle.Degrees(+45.33742973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7158"},
        {"Hipparcos Number", "HIP 5650"},
        {"Geneva Identification System", "GEN# +1.00007158"},
        {"Smithsonian Astrophysical Observation", "SAO 37023"},
        {"Wilson Evans Batten Catalogue", "WEB 1276"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.14192241),
        dec: Angle.Degrees(+45.33747997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220821"},
        {"Hipparcos Number", "HIP 115715"},
        {"Cincinnati Publication", "Ci 20 1427"},
        {"Cincinnati Publication 2", "Ci 18 3074"},
        {"Geneva Identification System", "GEN# +1.00220821"},
        {"Smithsonian Astrophysical Observation", "SAO 53025"},
        {"Wilson Evans Batten Catalogue", "WEB 20478"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.66664421),
        dec: Angle.Degrees(+45.33787529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 438.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193090"},
        {"Hipparcos Number", "HIP 99936"},
        {"Geneva Identification System", "GEN# +1.00193090"},
        {"Smithsonian Astrophysical Observation", "SAO 49406"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.14992172),
        dec: Angle.Degrees(+45.33910931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63349"},
        {"Hipparcos Number", "HIP 38278"},
        {"Smithsonian Astrophysical Observation", "SAO 42029"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.63763512),
        dec: Angle.Degrees(+45.34069211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87244"},
        {"Hipparcos Number", "HIP 49377"},
        {"Smithsonian Astrophysical Observation", "SAO 43173"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.21757502),
        dec: Angle.Degrees(+45.34145379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216118"},
        {"Hipparcos Number", "HIP 112713"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.38225635),
        dec: Angle.Degrees(+45.34259052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39414"},
        {"Hipparcos Number", "HIP 27945"},
        {"Celescope Catalog", "CEL 1021"},
        {"Fundamental Katalog 5th Edition", "FK5 4540"},
        {"Geneva Identification System", "GEN# +1.00039414"},
        {"Smithsonian Astrophysical Observation", "SAO 40692"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.70213414),
        dec: Angle.Degrees(+45.34435659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66953",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66953"},
        {"Smithsonian Astrophysical Observation", "SAO 44725"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.84012174),
        dec: Angle.Degrees(+45.34513859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102835",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14351 A"},
        {"Hipparcos Number", "HIP 102835"},
        {"Smithsonian Astrophysical Observation", "SAO 50120"},
        {"Wilson Evans Batten Catalogue", "WEB 18654"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.50272611),
        dec: Angle.Degrees(+45.34619550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20162"},
        {"Hipparcos Number", "HIP 15209"},
        {"Geneva Identification System", "GEN# +1.00020162"},
        {"Smithsonian Astrophysical Observation", "SAO 38685"},
        {"Wilson Evans Batten Catalogue", "WEB 2931"},
    },
    visualMagnitude: 6.15,
    bvColour: 1.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.01846748),
        dec: Angle.Degrees(+45.34621535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182441"},
        {"Hipparcos Number", "HIP 95238"},
        {"Smithsonian Astrophysical Observation", "SAO 48378"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.65407567),
        dec: Angle.Degrees(+45.34670348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220721"},
        {"Hipparcos Number", "HIP 115655"},
        {"Geneva Identification System", "GEN# +1.00220721"},
        {"Smithsonian Astrophysical Observation", "SAO 53008"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.44021336),
        dec: Angle.Degrees(+45.34752061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14916"},
        {"Smithsonian Astrophysical Observation", "SAO 38639"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.11238399),
        dec: Angle.Degrees(+45.34919425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110539",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15900 A"},
        {"Henry Draper", "HD 212468"},
        {"Hipparcos Number", "HIP 110539"},
        {"Smithsonian Astrophysical Observation", "SAO 51957"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.89173199),
        dec: Angle.Degrees(+45.34998125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164898"},
        {"Hipparcos Number", "HIP 88239"},
        {"Geneva Identification System", "GEN# +1.00164898A"},
        {"Smithsonian Astrophysical Observation", "SAO 47139"},
        {"Wilson Evans Batten Catalogue", "WEB 14908"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.27984832),
        dec: Angle.Degrees(+45.35085953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163990"},
        {"Hipparcos Number", "HIP 87850"},
        {"Geneva Identification System", "GEN# +1.00163990"},
        {"Smithsonian Astrophysical Observation", "SAO 47080"},
        {"Wilson Evans Batten Catalogue", "WEB 14831"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.20214415),
        dec: Angle.Degrees(+45.35092731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70223"},
        {"Hipparcos Number", "HIP 41045"},
        {"Geneva Identification System", "GEN# +1.00070223"},
        {"Smithsonian Astrophysical Observation", "SAO 42316"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.64530903),
        dec: Angle.Degrees(+45.35129757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158035"},
        {"Hipparcos Number", "HIP 85200"},
        {"Smithsonian Astrophysical Observation", "SAO 46699"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.16111715),
        dec: Angle.Degrees(+45.35216404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79116",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9940 AB"},
        {"Henry Draper", "HD 145424"},
        {"Hipparcos Number", "HIP 79116"},
        {"Smithsonian Astrophysical Observation", "SAO 45912"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.22813141),
        dec: Angle.Degrees(+45.35327703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23256"},
        {"Hipparcos Number", "HIP 17554"},
        {"Geneva Identification System", "GEN# +1.00023256"},
        {"Smithsonian Astrophysical Observation", "SAO 39081"},
        {"Wilson Evans Batten Catalogue", "WEB 3331"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.38985423),
        dec: Angle.Degrees(+45.35408397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23566"},
        {"Hipparcos Number", "HIP 17756"},
        {"Geneva Identification System", "GEN# +1.00023566"},
        {"Smithsonian Astrophysical Observation", "SAO 39107"},
        {"Wilson Evans Batten Catalogue", "WEB 3397"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.01777640),
        dec: Angle.Degrees(+45.35497610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20569"},
        {"Hipparcos Number", "HIP 15543"},
        {"Smithsonian Astrophysical Observation", "SAO 38734"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.06925560),
        dec: Angle.Degrees(+45.35988923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100241",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13723 AB"},
        {"Aitken 2", "ADS 13723"},
        {"Henry Draper", "HD 193701"},
        {"Hipparcos Number", "HIP 100241"},
        {"Geneva Identification System", "GEN# +1.00193701A"},
        {"Smithsonian Astrophysical Observation", "SAO 49481"},
        {"Wilson Evans Batten Catalogue", "WEB 18068"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.95694238),
        dec: Angle.Degrees(+45.36388089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172714"},
        {"Hipparcos Number", "HIP 91483"},
        {"Geneva Identification System", "GEN# +1.00172714"},
        {"Renson", "Renson 48410"},
        {"Smithsonian Astrophysical Observation", "SAO 47677"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.86814417),
        dec: Angle.Degrees(+45.36419233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200722"},
        {"Hipparcos Number", "HIP 103945"},
        {"Celescope Catalog", "CEL 5238"},
        {"Geneva Identification System", "GEN# +1.00200722"},
        {"Smithsonian Astrophysical Observation", "SAO 50404"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.91016229),
        dec: Angle.Degrees(+45.36794541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220909"},
        {"Hipparcos Number", "HIP 115778"},
        {"Smithsonian Astrophysical Observation", "SAO 53044"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.83626967),
        dec: Angle.Degrees(+45.36813338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37734",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6316 A"},
        {"Henry Draper", "HD 62068"},
        {"Hipparcos Number", "HIP 37734"},
        {"Smithsonian Astrophysical Observation", "SAO 41969"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.08556934),
        dec: Angle.Degrees(+45.36850347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80461"},
        {"Hipparcos Number", "HIP 45888"},
        {"Smithsonian Astrophysical Observation", "SAO 42820"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.34837898),
        dec: Angle.Degrees(+45.37014999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109085",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15633 AB"},
        {"Hipparcos Number", "HIP 109085"},
        {"Smithsonian Astrophysical Observation", "SAO 51642"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.46603768),
        dec: Angle.Degrees(+45.37144328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156110"},
        {"Hipparcos Number", "HIP 84260"},
        {"Geneva Identification System", "GEN# +1.00156110"},
        {"Smithsonian Astrophysical Observation", "SAO 46575"},
        {"Wilson Evans Batten Catalogue", "WEB 14230"},
    },
    visualMagnitude: 7.56,
    bvColour: -0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.36551697),
        dec: Angle.Degrees(+45.37225621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205730"},
        {"Hipparcos Number", "HIP 106642"},
        {"Geneva Identification System", "GEN# +1.00205730"},
        {"Smithsonian Astrophysical Observation", "SAO 51079"},
        {"Wilson Evans Batten Catalogue", "WEB 19289"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.01017560),
        dec: Angle.Degrees(+45.37458683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217491"},
        {"Hipparcos Number", "HIP 113603"},
        {"Geneva Identification System", "GEN# +1.00217491"},
        {"Smithsonian Astrophysical Observation", "SAO 52587"},
        {"Wilson Evans Batten Catalogue", "WEB 20191"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.14329381),
        dec: Angle.Degrees(+45.37481803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148346"},
        {"Hipparcos Number", "HIP 80451"},
        {"Geneva Identification System", "GEN# +1.00148346"},
        {"Smithsonian Astrophysical Observation", "SAO 46080"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.33009049),
        dec: Angle.Degrees(+45.37855151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79037",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9935 AB"},
        {"Henry Draper", "HD 145246"},
        {"Hipparcos Number", "HIP 79037"},
        {"Smithsonian Astrophysical Observation", "SAO 45905"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.99747665),
        dec: Angle.Degrees(+45.38026504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20867"},
        {"Smithsonian Astrophysical Observation", "SAO 39552"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.08947306),
        dec: Angle.Degrees(+45.38084421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19458"},
        {"Hipparcos Number", "HIP 14661"},
        {"Smithsonian Astrophysical Observation", "SAO 38607"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.35077242),
        dec: Angle.Degrees(+45.38310945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199137"},
        {"Hipparcos Number", "HIP 103113"},
        {"Smithsonian Astrophysical Observation", "SAO 50188"},
        {"Wilson Evans Batten Catalogue", "WEB 18724"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.38393771),
        dec: Angle.Degrees(+45.38396855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113379"},
        {"Hipparcos Number", "HIP 63653"},
        {"Geneva Identification System", "GEN# +1.00113379"},
        {"Smithsonian Astrophysical Observation", "SAO 44439"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.68508663),
        dec: Angle.Degrees(+45.38471507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15652",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2483 A"},
        {"Henry Draper", "HD 20676"},
        {"Hipparcos Number", "HIP 15652"},
        {"Geneva Identification System", "GEN# +1.00020676"},
        {"Smithsonian Astrophysical Observation", "SAO 38749"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.37418461),
        dec: Angle.Degrees(+45.38705631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112379",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112379"},
        {"Cincinnati Publication", "Ci 20 1380"},
        {"Wilson Evans Batten Catalogue", "WEB 20047"},
    },
    visualMagnitude: 10.46,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.41491161),
        dec: Angle.Degrees(+45.38969140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 332.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17112",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17112"},
        {"Renson", "Renson 5740"},
        {"Smithsonian Astrophysical Observation", "SAO 39024"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.98151664),
        dec: Angle.Degrees(+45.39156816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58917",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58917"},
    },
    visualMagnitude: 11.73,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.22362319),
        dec: Angle.Degrees(+53.84893986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -203.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148615"},
        {"Hipparcos Number", "HIP 80588"},
        {"Smithsonian Astrophysical Observation", "SAO 46098"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.80534236),
        dec: Angle.Degrees(+45.39275257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215909"},
        {"Hipparcos Number", "HIP 112564"},
        {"Smithsonian Astrophysical Observation", "SAO 52373"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.97693596),
        dec: Angle.Degrees(+45.39348723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39181"},
        {"Hipparcos Number", "HIP 27809"},
        {"Geneva Identification System", "GEN# +1.00039181"},
        {"Smithsonian Astrophysical Observation", "SAO 40673"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.27664304),
        dec: Angle.Degrees(+45.39429445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26735"},
        {"Hipparcos Number", "HIP 19874"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.93727177),
        dec: Angle.Degrees(+45.39429997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53410"},
        {"Hipparcos Number", "HIP 34345"},
        {"Geneva Identification System", "GEN# +1.00053410"},
        {"Smithsonian Astrophysical Observation", "SAO 41563"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.79397574),
        dec: Angle.Degrees(+45.39574782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118790"},
        {"Hipparcos Number", "HIP 66526"},
        {"Smithsonian Astrophysical Observation", "SAO 44691"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.54433263),
        dec: Angle.Degrees(+45.39579852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73854"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.40605820),
        dec: Angle.Degrees(+45.39719699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50538",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50538"},
        {"Smithsonian Astrophysical Observation", "SAO 43284"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.83236529),
        dec: Angle.Degrees(+45.39854669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9996"},
        {"Hipparcos Number", "HIP 7651"},
        {"Geneva Identification System", "GEN# +1.00009996"},
        {"Renson", "Renson 2470"},
        {"Smithsonian Astrophysical Observation", "SAO 37393"},
        {"Wilson Evans Batten Catalogue", "WEB 1636"},
    },
    visualMagnitude: 6.38,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.63265671),
        dec: Angle.Degrees(+45.39970504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26253"},
        {"Hipparcos Number", "HIP 19541"},
        {"Geneva Identification System", "GEN# +1.00026253"},
        {"Smithsonian Astrophysical Observation", "SAO 39359"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.78387152),
        dec: Angle.Degrees(+45.40217992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191781"},
        {"Hipparcos Number", "HIP 99347"},
        {"Geneva Identification System", "GEN# +1.00191781"},
        {"Smithsonian Astrophysical Observation", "SAO 49256"},
        {"Wilson Evans Batten Catalogue", "WEB 17726"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.46076938),
        dec: Angle.Degrees(+45.40292395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50943"},
        {"Smithsonian Astrophysical Observation", "SAO 43320"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.06087679),
        dec: Angle.Degrees(+45.40381239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189504"},
        {"Hipparcos Number", "HIP 98306"},
        {"Smithsonian Astrophysical Observation", "SAO 49047"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.61535857),
        dec: Angle.Degrees(+45.40568958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4639",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4639"},
    },
    visualMagnitude: 11.82,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.89363754),
        dec: Angle.Degrees(+45.40672403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6813",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1152 A"},
        {"Henry Draper", "HD 8799"},
        {"Hipparcos Number", "HIP 6813"},
        {"Fundamental Katalog 5th Edition", "FK5 1040"},
        {"Geneva Identification System", "GEN# +1.00008799"},
        {"Smithsonian Astrophysical Observation", "SAO 37228"},
        {"Wilson Evans Batten Catalogue", "WEB 1486"},
    },
    visualMagnitude: 4.83,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.91285470),
        dec: Angle.Degrees(+45.40695287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 356.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214488"},
        {"Hipparcos Number", "HIP 111716"},
        {"Geneva Identification System", "GEN# +1.00214488"},
        {"Smithsonian Astrophysical Observation", "SAO 52200"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.44452823),
        dec: Angle.Degrees(+45.40814189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55576"},
        {"Hipparcos Number", "HIP 35113"},
        {"Smithsonian Astrophysical Observation", "SAO 41643"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.90736947),
        dec: Angle.Degrees(+45.40954087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102754",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102754"},
        {"Geneva Identification System", "GEN# +0.04403594"},
        {"Geneva Identification System 2", "GEN# +6.20055293"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.29833983),
        dec: Angle.Degrees(+45.41106512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129426"},
        {"Hipparcos Number", "HIP 71791"},
        {"Geneva Identification System", "GEN# +1.00129426"},
        {"Smithsonian Astrophysical Observation", "SAO 45171"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.27569865),
        dec: Angle.Degrees(+45.41383947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86166"},
        {"Hipparcos Number", "HIP 48861"},
        {"Fundamental Katalog 5th Edition", "FK5 2798"},
        {"Geneva Identification System", "GEN# +1.00086166"},
        {"Smithsonian Astrophysical Observation", "SAO 43117"},
        {"Wilson Evans Batten Catalogue", "WEB 9079"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.48683606),
        dec: Angle.Degrees(+45.41438050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50162"},
        {"Hipparcos Number", "HIP 33171"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.56346263),
        dec: Angle.Degrees(+45.41466476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39048",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39048"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.83214530),
        dec: Angle.Degrees(+45.41633599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124731"},
        {"Hipparcos Number", "HIP 69527"},
        {"Smithsonian Astrophysical Observation", "SAO 44949"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.49505250),
        dec: Angle.Degrees(+45.42414847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6085"},
        {"Hipparcos Number", "HIP 4887"},
        {"Geneva Identification System", "GEN# +1.00006085"},
        {"Smithsonian Astrophysical Observation", "SAO 36869"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.69078301),
        dec: Angle.Degrees(+45.42530390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73470",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73470"},
        {"Cincinnati Publication", "Ci 18 1996"},
        {"Cincinnati Publication 2", "Ci 20 904"},
        {"Geneva Identification System", "GEN# +0.04502247"},
        {"Smithsonian Astrophysical Observation", "SAO 45329"},
        {"Wilson Evans Batten Catalogue", "WEB 12573"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.23074748),
        dec: Angle.Degrees(+45.42530804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 241.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 370.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115089",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115089"},
        {"Smithsonian Astrophysical Observation", "SAO 52886"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.65550850),
        dec: Angle.Degrees(+45.42541652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67824"},
        {"Hipparcos Number", "HIP 40119"},
        {"Smithsonian Astrophysical Observation", "SAO 42216"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.91649060),
        dec: Angle.Degrees(+45.42563824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70585",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70585"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.58035062),
        dec: Angle.Degrees(+45.42630505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4364"},
        {"Hipparcos Number", "HIP 3621"},
        {"Smithsonian Astrophysical Observation", "SAO 36646"},
        {"Wilson Evans Batten Catalogue", "WEB 646"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.61286296),
        dec: Angle.Degrees(+45.42653331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55929",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55929"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.93127010),
        dec: Angle.Degrees(+45.42895047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216535"},
        {"Hipparcos Number", "HIP 112999"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.26824009),
        dec: Angle.Degrees(+45.42949973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11662",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1899 AB"},
        {"Henry Draper", "HD 15436"},
        {"Hipparcos Number", "HIP 11662"},
        {"Smithsonian Astrophysical Observation", "SAO 38075"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.60405063),
        dec: Angle.Degrees(+45.43166054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146586"},
        {"Hipparcos Number", "HIP 79632"},
        {"Geneva Identification System", "GEN# +1.00146586"},
        {"Smithsonian Astrophysical Observation", "SAO 45992"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.74130617),
        dec: Angle.Degrees(+45.43204471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88923"},
        {"Hipparcos Number", "HIP 50315"},
        {"Geneva Identification System", "GEN# +1.00088923"},
        {"Smithsonian Astrophysical Observation", "SAO 43259"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.10908401),
        dec: Angle.Degrees(+45.43333659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79263"},
        {"Hipparcos Number", "HIP 45360"},
        {"Smithsonian Astrophysical Observation", "SAO 42764"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.65170186),
        dec: Angle.Degrees(+45.43355137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212313"},
        {"Henry Draper 2", "HD 212314"},
        {"Hipparcos Number", "HIP 110458"},
        {"Geneva Identification System", "GEN# +1.00212313"},
        {"Smithsonian Astrophysical Observation", "SAO 51931"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.61135237),
        dec: Angle.Degrees(+45.43420946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214166"},
        {"Hipparcos Number", "HIP 111525"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.92199751),
        dec: Angle.Degrees(+45.43524408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11979"},
        {"Hipparcos Number", "HIP 9234"},
        {"Smithsonian Astrophysical Observation", "SAO 37673"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.68456650),
        dec: Angle.Degrees(+45.43524721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185117"},
        {"Hipparcos Number", "HIP 96357"},
        {"Smithsonian Astrophysical Observation", "SAO 48621"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.87485976),
        dec: Angle.Degrees(+45.43571026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22874"},
        {"Hipparcos Number", "HIP 17307"},
        {"Smithsonian Astrophysical Observation", "SAO 39050"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.57360770),
        dec: Angle.Degrees(+45.43733551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223309"},
        {"Hipparcos Number", "HIP 117407"},
        {"Renson", "Renson 61196"},
        {"Smithsonian Astrophysical Observation", "SAO 53388"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.10134275),
        dec: Angle.Degrees(+45.43844623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62223",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "La Superba"},
        {"Henry Draper", "HD 110914"},
        {"Hipparcos Number", "HIP 62223"},
        {"Fundamental Katalog 5th Edition", "FK5 1327"},
        {"Geneva Identification System", "GEN# +1.00110914"},
        {"Smithsonian Astrophysical Observation", "SAO 44317"},
        {"Wilson Evans Batten Catalogue", "WEB 11053"},
    },
    visualMagnitude: 5.42,
    bvColour: 2.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.28262003),
        dec: Angle.Degrees(+45.44022447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211096"},
        {"Hipparcos Number", "HIP 109745"},
        {"Geneva Identification System", "GEN# +1.00211096"},
        {"Smithsonian Astrophysical Observation", "SAO 51783"},
        {"Wilson Evans Batten Catalogue", "WEB 19715"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.45491277),
        dec: Angle.Degrees(+45.44060328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5017"},
        {"Hipparcos Number", "HIP 4115"},
        {"Geneva Identification System", "GEN# +1.00005017"},
        {"Smithsonian Astrophysical Observation", "SAO 36736"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.18889321),
        dec: Angle.Degrees(+45.44138107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113266"},
        {"Hipparcos Number", "HIP 63594"},
        {"Smithsonian Astrophysical Observation", "SAO 44433"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.48372525),
        dec: Angle.Degrees(+45.44221955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69824"},
        {"Smithsonian Astrophysical Observation", "SAO 44975"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.35143860),
        dec: Angle.Degrees(+45.44452103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31844"},
        {"Hipparcos Number", "HIP 23348"},
        {"Celescope Catalog", "CEL 503"},
        {"Geneva Identification System", "GEN# +1.00031844"},
        {"Smithsonian Astrophysical Observation", "SAO 39943"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.32652724),
        dec: Angle.Degrees(+45.44627802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48708",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48708"},
        {"Smithsonian Astrophysical Observation", "SAO 43106"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.02267777),
        dec: Angle.Degrees(+45.44766758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73360",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73360"},
        {"Wilson Evans Batten Catalogue", "WEB 12561"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.87758464),
        dec: Angle.Degrees(+45.44778108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139321"},
        {"Hipparcos Number", "HIP 76350"},
        {"Smithsonian Astrophysical Observation", "SAO 45628"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.91423165),
        dec: Angle.Degrees(+45.44789338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37199"},
        {"Hipparcos Number", "HIP 26580"},
        {"Geneva Identification System", "GEN# +1.00037199"},
        {"Smithsonian Astrophysical Observation", "SAO 40510"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.75713030),
        dec: Angle.Degrees(+45.44813044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195528"},
        {"Hipparcos Number", "HIP 101142"},
        {"Geneva Identification System", "GEN# +1.00195528"},
        {"Smithsonian Astrophysical Observation", "SAO 49708"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.52889123),
        dec: Angle.Degrees(+45.44880146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154542"},
        {"Hipparcos Number", "HIP 83497"},
        {"Smithsonian Astrophysical Observation", "SAO 46465"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.97985699),
        dec: Angle.Degrees(+45.44921513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22039"},
        {"Hipparcos Number", "HIP 16716"},
        {"Geneva Identification System", "GEN# +1.00022039"},
        {"Smithsonian Astrophysical Observation", "SAO 38962"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.76472706),
        dec: Angle.Degrees(+45.44943022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64645"},
        {"Hipparcos Number", "HIP 38841"},
        {"Geneva Identification System", "GEN# +1.00064645"},
        {"Smithsonian Astrophysical Observation", "SAO 42083"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.22903718),
        dec: Angle.Degrees(+45.45025465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17115"},
        {"Hipparcos Number", "HIP 12930"},
        {"Geneva Identification System", "GEN# +1.00017115"},
        {"Smithsonian Astrophysical Observation", "SAO 38317"},
        {"Wilson Evans Batten Catalogue", "WEB 2621"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.58177185),
        dec: Angle.Degrees(+45.45090854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52777",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52777"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.85835096),
        dec: Angle.Degrees(+45.45172214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198414"},
        {"Hipparcos Number", "HIP 102687"},
        {"Celescope Catalog", "CEL 5171"},
        {"Geneva Identification System", "GEN# +1.00198414"},
        {"Smithsonian Astrophysical Observation", "SAO 50084"},
        {"Wilson Evans Batten Catalogue", "WEB 18613"},
    },
    visualMagnitude: 7.66,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.10972047),
        dec: Angle.Degrees(+45.45209803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5916"},
        {"Hipparcos Number", "HIP 4771"},
        {"Geneva Identification System", "GEN# +1.00005916"},
        {"Smithsonian Astrophysical Observation", "SAO 36851"},
        {"Wilson Evans Batten Catalogue", "WEB 905"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.32892379),
        dec: Angle.Degrees(+45.45211529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143628"},
        {"Hipparcos Number", "HIP 78335"},
        {"Smithsonian Astrophysical Observation", "SAO 45826"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.92618634),
        dec: Angle.Degrees(+45.45290217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74132"},
        {"Hipparcos Number", "HIP 42851"},
        {"Geneva Identification System", "GEN# +1.00074132"},
        {"Smithsonian Astrophysical Observation", "SAO 42514"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.97820623),
        dec: Angle.Degrees(+45.45381362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118263"},
        {"Hipparcos Number", "HIP 66264"},
        {"Smithsonian Astrophysical Observation", "SAO 44671"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.71063308),
        dec: Angle.Degrees(+45.45612463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70617"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.67599594),
        dec: Angle.Degrees(+45.45632504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90767",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90767"},
        {"Smithsonian Astrophysical Observation", "SAO 47561"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.78298258),
        dec: Angle.Degrees(+45.45647024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201924"},
        {"Hipparcos Number", "HIP 104587"},
        {"Cincinnati Publication", "Ci 18 2751"},
        {"Geneva Identification System", "GEN# +2.70390125"},
        {"Smithsonian Astrophysical Observation", "SAO 50545"},
        {"New General Catalogue", "NGC 7039 125"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.79605824),
        dec: Angle.Degrees(+45.45663927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -239.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -297.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85535",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85535"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.20626222),
        dec: Angle.Degrees(+45.45710780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15998"},
        {"Geneva Identification System", "GEN# +0.04400697"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.51697801),
        dec: Angle.Degrees(+45.45836276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 243.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110962"},
        {"Smithsonian Astrophysical Observation", "SAO 52047"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.22196353),
        dec: Angle.Degrees(+45.46015912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132830"},
        {"Hipparcos Number", "HIP 73365"},
        {"Smithsonian Astrophysical Observation", "SAO 45320"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.88730089),
        dec: Angle.Degrees(+45.46393240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60289"},
        {"Geneva Identification System", "GEN# +0.04601779"},
        {"Smithsonian Astrophysical Observation", "SAO 44139"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.43701535),
        dec: Angle.Degrees(+45.46420077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27332"},
        {"Hipparcos Number", "HIP 20287"},
        {"Geneva Identification System", "GEN# +1.00027332"},
        {"Smithsonian Astrophysical Observation", "SAO 39475"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.22128111),
        dec: Angle.Degrees(+45.46434860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69604"},
        {"Hipparcos Number", "HIP 40796"},
        {"Smithsonian Astrophysical Observation", "SAO 42288"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.89547880),
        dec: Angle.Degrees(+45.46710488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105369"},
        {"Geneva Identification System", "GEN# +0.04403779"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.13709723),
        dec: Angle.Degrees(+45.46751419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33135"},
        {"Hipparcos Number", "HIP 24081"},
        {"Smithsonian Astrophysical Observation", "SAO 40070"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.59651065),
        dec: Angle.Degrees(+45.46849549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188537"},
        {"Hipparcos Number", "HIP 97906"},
        {"Geneva Identification System", "GEN# +1.00188537"},
        {"Smithsonian Astrophysical Observation", "SAO 48949"},
        {"Wilson Evans Batten Catalogue", "WEB 17227"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.44230488),
        dec: Angle.Degrees(+45.47041468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164429"},
        {"Hipparcos Number", "HIP 88030"},
        {"Geneva Identification System", "GEN# +1.00164429"},
        {"Renson", "Renson 46480"},
        {"Smithsonian Astrophysical Observation", "SAO 47106"},
        {"Wilson Evans Batten Catalogue", "WEB 14870"},
    },
    visualMagnitude: 6.48,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.71794193),
        dec: Angle.Degrees(+45.47615489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190165"},
        {"Hipparcos Number", "HIP 98614"},
        {"Geneva Identification System", "GEN# +1.00190165"},
        {"Renson", "Renson 52810"},
        {"Smithsonian Astrophysical Observation", "SAO 49108"},
        {"Wilson Evans Batten Catalogue", "WEB 17440"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.44453195),
        dec: Angle.Degrees(+45.47659973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218032"},
        {"Hipparcos Number", "HIP 113927"},
        {"Smithsonian Astrophysical Observation", "SAO 52650"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.06599578),
        dec: Angle.Degrees(+45.48154227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13235",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 12.07,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)50, 22.6100),
        dec: Angle.DegreesMinutesSeconds((int)+45, (int)28, 53.600)
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
    primaryId: "HIP 13230",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13230"},
    },
    visualMagnitude: 10.43,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.58115467),
        dec: Angle.Degrees(+45.48223448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67549",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67549"},
    },
    visualMagnitude: 11.35,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.61599293),
        dec: Angle.Degrees(+56.16966629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52142"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.78684857),
        dec: Angle.Degrees(+45.48336923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183985"},
        {"Hipparcos Number", "HIP 95888"},
        {"Smithsonian Astrophysical Observation", "SAO 48518"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.52081291),
        dec: Angle.Degrees(+45.48479618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221233"},
        {"Hipparcos Number", "HIP 115985"},
        {"Smithsonian Astrophysical Observation", "SAO 53086"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.48542981),
        dec: Angle.Degrees(+45.48751194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41054"},
        {"Hipparcos Number", "HIP 28826"},
        {"Smithsonian Astrophysical Observation", "SAO 40839"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.26911075),
        dec: Angle.Degrees(+45.48792563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219749"},
        {"Hipparcos Number", "HIP 115036"},
        {"Geneva Identification System", "GEN# +1.00219749"},
        {"Renson", "Renson 60320"},
        {"Smithsonian Astrophysical Observation", "SAO 52876"},
        {"Wilson Evans Batten Catalogue", "WEB 20381"},
    },
    visualMagnitude: 6.48,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.48329731),
        dec: Angle.Degrees(+45.48894828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26181"},
        {"Hipparcos Number", "HIP 19493"},
        {"Smithsonian Astrophysical Observation", "SAO 39350"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.64276377),
        dec: Angle.Degrees(+45.48898657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30221"},
        {"Hipparcos Number", "HIP 22284"},
        {"Smithsonian Astrophysical Observation", "SAO 39758"},
        {"Wilson Evans Batten Catalogue", "WEB 4295"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.97219376),
        dec: Angle.Degrees(+45.48942577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36244"},
        {"Hipparcos Number", "HIP 25986"},
        {"Geneva Identification System", "GEN# +1.00036244"},
        {"Smithsonian Astrophysical Observation", "SAO 40411"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.18412591),
        dec: Angle.Degrees(+45.49129532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36662"},
        {"Hipparcos Number", "HIP 26278"},
        {"Celescope Catalog", "CEL 802"},
        {"Geneva Identification System", "GEN# +1.00036662"},
        {"Renson", "Renson 9557"},
        {"Smithsonian Astrophysical Observation", "SAO 40461"},
        {"Wilson Evans Batten Catalogue", "WEB 5155"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.93479252),
        dec: Angle.Degrees(+45.49324549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204860"},
        {"Hipparcos Number", "HIP 106145"},
        {"Celescope Catalog", "CEL 5324"},
        {"Geneva Identification System", "GEN# +1.00204860"},
        {"Smithsonian Astrophysical Observation", "SAO 50942"},
        {"Wilson Evans Batten Catalogue", "WEB 19238"},
    },
    visualMagnitude: 6.95,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.50370977),
        dec: Angle.Degrees(+45.49419316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16663"},
        {"Hipparcos Number", "HIP 12580"},
        {"Geneva Identification System", "GEN# +1.00016663"},
        {"Smithsonian Astrophysical Observation", "SAO 38232"},
        {"Wilson Evans Batten Catalogue", "WEB 2567"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.44261961),
        dec: Angle.Degrees(+45.49449567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195463"},
        {"Hipparcos Number", "HIP 101112"},
        {"Celescope Catalog", "CEL 5084"},
        {"Geneva Identification System", "GEN# +1.00195463"},
        {"Smithsonian Astrophysical Observation", "SAO 49697"},
        {"Wilson Evans Batten Catalogue", "WEB 18261"},
    },
    visualMagnitude: 8.90,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.43505723),
        dec: Angle.Degrees(+45.49456659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144836"},
        {"Hipparcos Number", "HIP 78867"},
        {"Geneva Identification System", "GEN# +1.00144836"},
        {"Smithsonian Astrophysical Observation", "SAO 45891"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.47853028),
        dec: Angle.Degrees(+45.49534526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161194"},
        {"Hipparcos Number", "HIP 86613"},
        {"Smithsonian Astrophysical Observation", "SAO 46894"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.48359931),
        dec: Angle.Degrees(+45.49636642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61186",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61186"},
        {"Geneva Identification System", "GEN# +0.04601792"},
        {"Smithsonian Astrophysical Observation", "SAO 44219"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.05988909),
        dec: Angle.Degrees(+45.49732945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164646"},
        {"Hipparcos Number", "HIP 88122"},
        {"Fundamental Katalog 5th Edition", "FK5 3433"},
        {"Geneva Identification System", "GEN# +1.00164646"},
        {"Smithsonian Astrophysical Observation", "SAO 47121"},
        {"Wilson Evans Batten Catalogue", "WEB 14883"},
    },
    visualMagnitude: 5.69,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.98417988),
        dec: Angle.Degrees(+45.50146059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201733"},
        {"Hipparcos Number", "HIP 104483"},
        {"Celescope Catalog", "CEL 5255"},
        {"Geneva Identification System", "GEN# +2.70390170"},
        {"Smithsonian Astrophysical Observation", "SAO 50521"},
        {"Wilson Evans Batten Catalogue", "WEB 19020"},
        {"New General Catalogue", "NGC 7039 170"},
    },
    visualMagnitude: 6.60,
    bvColour: -0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.49427056),
        dec: Angle.Degrees(+45.50255474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30784"},
        {"Smithsonian Astrophysical Observation", "SAO 41111"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.01836240),
        dec: Angle.Degrees(+45.50498999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176071"},
        {"Hipparcos Number", "HIP 92962"},
        {"Geneva Identification System", "GEN# +1.00176071"},
        {"Smithsonian Astrophysical Observation", "SAO 47938"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.09210786),
        dec: Angle.Degrees(+45.50690299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78847"},
        {"Hipparcos Number", "HIP 45160"},
        {"Smithsonian Astrophysical Observation", "SAO 42738"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.00292417),
        dec: Angle.Degrees(+45.50895484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1642",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 277 AB"},
        {"Henry Draper", "HD 1614"},
        {"Hipparcos Number", "HIP 1642"},
        {"Geneva Identification System", "GEN# +1.00001614"},
        {"Smithsonian Astrophysical Observation", "SAO 36280"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.13725248),
        dec: Angle.Degrees(+45.50898081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14594"},
        {"Hipparcos Number", "HIP 11087"},
        {"Smithsonian Astrophysical Observation", "SAO 37982"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.68912090),
        dec: Angle.Degrees(+45.50960658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217635"},
        {"Hipparcos Number", "HIP 113690"},
        {"Smithsonian Astrophysical Observation", "SAO 52605"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.39135493),
        dec: Angle.Degrees(+45.51020085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103904"},
        {"Hipparcos Number", "HIP 58344"},
        {"Smithsonian Astrophysical Observation", "SAO 43972"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.47221474),
        dec: Angle.Degrees(+45.51080287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24310"},
        {"Hipparcos Number", "HIP 18237"},
        {"Smithsonian Astrophysical Observation", "SAO 39181"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.50351608),
        dec: Angle.Degrees(+45.51183646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95843",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95843"},
        {"Smithsonian Astrophysical Observation", "SAO 48509"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.39726446),
        dec: Angle.Degrees(+45.51287382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92409"},
        {"Hipparcos Number", "HIP 52284"},
        {"Smithsonian Astrophysical Observation", "SAO 43432"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.25527938),
        dec: Angle.Degrees(+45.51291110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218868"},
        {"Hipparcos Number", "HIP 114456"},
        {"Geneva Identification System", "GEN# +1.00218868"},
        {"Smithsonian Astrophysical Observation", "SAO 52768"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.70896034),
        dec: Angle.Degrees(+45.51297000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -286.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82408"},
        {"Hipparcos Number", "HIP 46879"},
        {"Smithsonian Astrophysical Observation", "SAO 42916"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.29692419),
        dec: Angle.Degrees(+45.51385304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76417"},
        {"Smithsonian Astrophysical Observation", "SAO 45636"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.11344612),
        dec: Angle.Degrees(+45.51443613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92961"},
        {"Smithsonian Astrophysical Observation", "SAO 47937"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.08851943),
        dec: Angle.Degrees(+45.51464459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107467"},
        {"Hipparcos Number", "HIP 60229"},
        {"Geneva Identification System", "GEN# +1.00107467"},
        {"Smithsonian Astrophysical Observation", "SAO 44135"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.26045906),
        dec: Angle.Degrees(+45.51477381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221992"},
        {"Hipparcos Number", "HIP 116508"},
        {"Geneva Identification System", "GEN# +1.00221992"},
        {"Smithsonian Astrophysical Observation", "SAO 53179"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.13134731),
        dec: Angle.Degrees(+45.51523106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15972",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2525 AB"},
        {"Henry Draper", "HD 21060"},
        {"Hipparcos Number", "HIP 15972"},
        {"Geneva Identification System", "GEN# +1.00021060J"},
        {"Smithsonian Astrophysical Observation", "SAO 38815"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.40707670),
        dec: Angle.Degrees(+45.51556723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215136"},
        {"Hipparcos Number", "HIP 112107"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.60800356),
        dec: Angle.Degrees(+45.51691869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83888"},
        {"Hipparcos Number", "HIP 47640"},
        {"Smithsonian Astrophysical Observation", "SAO 42993"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.69715179),
        dec: Angle.Degrees(+45.51722313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2516"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.97448280),
        dec: Angle.Degrees(+45.51751063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128493"},
        {"Hipparcos Number", "HIP 71371"},
        {"Geneva Identification System", "GEN# +1.00128493"},
        {"Smithsonian Astrophysical Observation", "SAO 45125"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.94019883),
        dec: Angle.Degrees(+45.51963899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44474",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44474"},
        {"Smithsonian Astrophysical Observation", "SAO 42663"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.92294721),
        dec: Angle.Degrees(+45.51992574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119637"},
        {"Hipparcos Number", "HIP 66958"},
        {"Smithsonian Astrophysical Observation", "SAO 44727"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.85776233),
        dec: Angle.Degrees(+45.52025104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108756"},
        {"Smithsonian Astrophysical Observation", "SAO 51572"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.45553289),
        dec: Angle.Degrees(+45.52043161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109755"},
        {"Hipparcos Number", "HIP 61552"},
        {"Smithsonian Astrophysical Observation", "SAO 44250"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.18285761),
        dec: Angle.Degrees(+45.52054665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120829"},
        {"Hipparcos Number", "HIP 67582"},
        {"Smithsonian Astrophysical Observation", "SAO 44775"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.72040890),
        dec: Angle.Degrees(+45.52294777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94292",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94292"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.88554854),
        dec: Angle.Degrees(+45.52298488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186155"},
        {"Hipparcos Number", "HIP 96825"},
        {"Fundamental Katalog 5th Edition", "FK5 3575"},
        {"Geneva Identification System", "GEN# +1.00186155"},
        {"Smithsonian Astrophysical Observation", "SAO 48718"},
        {"Wilson Evans Batten Catalogue", "WEB 16993"},
    },
    visualMagnitude: 5.06,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.20880618),
        dec: Angle.Degrees(+45.52464940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20899"},
        {"Hipparcos Number", "HIP 15832"},
        {"Smithsonian Astrophysical Observation", "SAO 38782"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.98597015),
        dec: Angle.Degrees(+45.52560955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95212"},
        {"Hipparcos Number", "HIP 53781"},
        {"Fundamental Katalog 5th Edition", "FK5 2878"},
        {"Geneva Identification System", "GEN# +1.00095212"},
        {"Smithsonian Astrophysical Observation", "SAO 43562"},
        {"Wilson Evans Batten Catalogue", "WEB 9742"},
    },
    visualMagnitude: 5.47,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.06123415),
        dec: Angle.Degrees(+45.52626916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115898"},
        {"Hipparcos Number", "HIP 65006"},
        {"Geneva Identification System", "GEN# +1.00115898"},
        {"Smithsonian Astrophysical Observation", "SAO 44564"},
        {"Wilson Evans Batten Catalogue", "WEB 11485"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.86582421),
        dec: Angle.Degrees(+45.52715848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51525"},
        {"Cincinnati Publication", "Ci 20 582"},
        {"Geneva Identification System", "GEN# +0.04601635"},
        {"Wilson Evans Batten Catalogue", "WEB 9401"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.85287346),
        dec: Angle.Degrees(+45.52749552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -567.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -594.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43189",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6994 AB"},
        {"Hipparcos Number", "HIP 43189"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.98050982),
        dec: Angle.Degrees(+45.52800024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215253"},
        {"Hipparcos Number", "HIP 112177"},
        {"Smithsonian Astrophysical Observation", "SAO 52297"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.80371662),
        dec: Angle.Degrees(+45.52851647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6411",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Adhil"},
        {"Henry Draper", "HD 8207"},
        {"Hipparcos Number", "HIP 6411"},
        {"Fundamental Katalog 5th Edition", "FK5 1035"},
        {"Geneva Identification System", "GEN# +1.00008207"},
        {"Smithsonian Astrophysical Observation", "SAO 37155"},
        {"Wilson Evans Batten Catalogue", "WEB 1417"},
    },
    visualMagnitude: 4.87,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.58497087),
        dec: Angle.Degrees(+45.52875660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211302"},
        {"Hipparcos Number", "HIP 109882"},
        {"Smithsonian Astrophysical Observation", "SAO 51810"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.82486381),
        dec: Angle.Degrees(+45.53336015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36243"},
        {"Hipparcos Number", "HIP 25977"},
        {"Geneva Identification System", "GEN# +1.00036243"},
        {"Smithsonian Astrophysical Observation", "SAO 40409"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.16162682),
        dec: Angle.Degrees(+45.53700024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108521",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108521"},
        {"Smithsonian Astrophysical Observation", "SAO 51512"},
    },
    visualMagnitude: 9.53,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.77774790),
        dec: Angle.Degrees(+45.54214539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69050",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9120"},
        {"Hipparcos Number", "HIP 69050"},
    },
    visualMagnitude: 10.60,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.00684540),
        dec: Angle.Degrees(+45.54234891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208310"},
        {"Hipparcos Number", "HIP 108114"},
        {"Smithsonian Astrophysical Observation", "SAO 51417"},
        {"Wilson Evans Batten Catalogue", "WEB 19492"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.56413366),
        dec: Angle.Degrees(+45.54314099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191455"},
        {"Hipparcos Number", "HIP 99182"},
        {"Geneva Identification System", "GEN# +1.00191455"},
        {"Smithsonian Astrophysical Observation", "SAO 49225"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.03471941),
        dec: Angle.Degrees(+45.54321742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128954"},
        {"Hipparcos Number", "HIP 71587"},
        {"Smithsonian Astrophysical Observation", "SAO 45149"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.61318909),
        dec: Angle.Degrees(+45.54331699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55648",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55648"},
    },
    visualMagnitude: 11.93,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.99894793),
        dec: Angle.Degrees(+45.54343412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 215.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -234.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1121"},
        {"Hipparcos Number", "HIP 1255"},
        {"Geneva Identification System", "GEN# +1.00001121"},
        {"Smithsonian Astrophysical Observation", "SAO 36210"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.93715322),
        dec: Angle.Degrees(+45.54392193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58195",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8354 AB"},
        {"Henry Draper", "HD 103626"},
        {"Hipparcos Number", "HIP 58195"},
        {"Smithsonian Astrophysical Observation", "SAO 43950"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.02638677),
        dec: Angle.Degrees(+45.54595442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85108"},
        {"Hipparcos Number", "HIP 48314"},
        {"Geneva Identification System", "GEN# +1.00085108"},
        {"Smithsonian Astrophysical Observation", "SAO 43066"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.74012418),
        dec: Angle.Degrees(+45.54838434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55265",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55265"},
        {"Smithsonian Astrophysical Observation", "SAO 43693"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.78204707),
        dec: Angle.Degrees(+45.54964056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163589"},
        {"Hipparcos Number", "HIP 87691"},
        {"Geneva Identification System", "GEN# +1.00163589"},
        {"Smithsonian Astrophysical Observation", "SAO 47055"},
        {"Wilson Evans Batten Catalogue", "WEB 14800"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.66677611),
        dec: Angle.Degrees(+45.55407123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41578"},
        {"Hipparcos Number", "HIP 29108"},
        {"Geneva Identification System", "GEN# +1.00041578"},
        {"Smithsonian Astrophysical Observation", "SAO 40877"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.07907146),
        dec: Angle.Degrees(+45.55438114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47891"},
        {"Smithsonian Astrophysical Observation", "SAO 43018"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.41843509),
        dec: Angle.Degrees(+45.55477720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -257.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89560"},
        {"Geneva Identification System", "GEN# +0.04502688"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.12957087),
        dec: Angle.Degrees(+45.55703347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 338.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160506"},
        {"Hipparcos Number", "HIP 86302"},
        {"Geneva Identification System", "GEN# +1.00160506"},
        {"Smithsonian Astrophysical Observation", "SAO 46855"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.51559658),
        dec: Angle.Degrees(+45.55729909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56919",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56919"},
        {"Smithsonian Astrophysical Observation", "SAO 43855"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.03149101),
        dec: Angle.Degrees(+45.55888922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108668"},
        {"Renson", "Renson 58203"},
        {"Smithsonian Astrophysical Observation", "SAO 51550"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.22095255),
        dec: Angle.Degrees(+45.55988520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62379"},
        {"Hipparcos Number", "HIP 37877"},
        {"Smithsonian Astrophysical Observation", "SAO 41985"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.46119801),
        dec: Angle.Degrees(+45.56309719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125076"},
        {"Hipparcos Number", "HIP 69704"},
        {"Geneva Identification System", "GEN# +1.00125076"},
        {"Smithsonian Astrophysical Observation", "SAO 44963"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.01003162),
        dec: Angle.Degrees(+45.56611067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93033"},
        {"Hipparcos Number", "HIP 52599"},
        {"Geneva Identification System", "GEN# +1.00093033"},
        {"Smithsonian Astrophysical Observation", "SAO 43460"},
        {"Wilson Evans Batten Catalogue", "WEB 9582"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.33540313),
        dec: Angle.Degrees(+45.56631835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209596"},
        {"Hipparcos Number", "HIP 108892"},
        {"Geneva Identification System", "GEN# +1.00209596A"},
        {"Wilson Evans Batten Catalogue", "WEB 19587"},
    },
    visualMagnitude: 10.05,
    bvColour: 2.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.86593342),
        dec: Angle.Degrees(+45.56861799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68058"},
        {"Smithsonian Astrophysical Observation", "SAO 44807"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.02449306),
        dec: Angle.Degrees(+45.57182195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210887"},
        {"Hipparcos Number", "HIP 109630"},
        {"Smithsonian Astrophysical Observation", "SAO 51762"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.12091303),
        dec: Angle.Degrees(+45.57188272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143434"},
        {"Hipparcos Number", "HIP 78224"},
        {"Smithsonian Astrophysical Observation", "SAO 45812"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.60221181),
        dec: Angle.Degrees(+45.57463639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68436"},
        {"Hipparcos Number", "HIP 40352"},
        {"Smithsonian Astrophysical Observation", "SAO 42237"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.58450374),
        dec: Angle.Degrees(+45.57545234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50123",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50123"},
        {"Smithsonian Astrophysical Observation", "SAO 43240"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.48590026),
        dec: Angle.Degrees(+45.57570780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10322"},
        {"Hipparcos Number", "HIP 7928"},
        {"Smithsonian Astrophysical Observation", "SAO 37438"},
        {"Wilson Evans Batten Catalogue", "WEB 1694"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.47730324),
        dec: Angle.Degrees(+45.57726749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204570"},
        {"Hipparcos Number", "HIP 106002"},
        {"Geneva Identification System", "GEN# +1.00204570"},
        {"Smithsonian Astrophysical Observation", "SAO 50897"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.03032973),
        dec: Angle.Degrees(+45.57782869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147544"},
        {"Hipparcos Number", "HIP 80074"},
        {"Smithsonian Astrophysical Observation", "SAO 46037"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.14582125),
        dec: Angle.Degrees(+45.57905124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192985"},
        {"Hipparcos Number", "HIP 99889"},
        {"Geneva Identification System", "GEN# +1.00192985"},
        {"Smithsonian Astrophysical Observation", "SAO 49395"},
        {"Wilson Evans Batten Catalogue", "WEB 17965"},
    },
    visualMagnitude: 5.87,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.00252971),
        dec: Angle.Degrees(+45.57965867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102585",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14298 A"},
        {"Henry Draper", "HD 198237"},
        {"Hipparcos Number", "HIP 102585"},
        {"Geneva Identification System", "GEN# +1.00198237"},
        {"Smithsonian Astrophysical Observation", "SAO 50060"},
        {"Wilson Evans Batten Catalogue", "WEB 18586"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.83652247),
        dec: Angle.Degrees(+45.57998871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137644"},
        {"Hipparcos Number", "HIP 75505"},
        {"Smithsonian Astrophysical Observation", "SAO 45531"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.35522894),
        dec: Angle.Degrees(+45.58005773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216784"},
        {"Hipparcos Number", "HIP 113181"},
        {"Geneva Identification System", "GEN# +1.00216784"},
        {"Smithsonian Astrophysical Observation", "SAO 52489"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.78600961),
        dec: Angle.Degrees(+45.58050048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60564"},
        {"Geneva Identification System", "GEN# +0.04601784"},
        {"Smithsonian Astrophysical Observation", "SAO 44163"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.22427866),
        dec: Angle.Degrees(+45.58467608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115638"},
        {"Hipparcos Number", "HIP 64872"},
        {"Geneva Identification System", "GEN# +1.00115638"},
        {"Smithsonian Astrophysical Observation", "SAO 44551"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.45369259),
        dec: Angle.Degrees(+45.58512947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115119"},
        {"Hipparcos Number", "HIP 64599"},
        {"Smithsonian Astrophysical Observation", "SAO 44525"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.60779071),
        dec: Angle.Degrees(+45.58589495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28775",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4639 AB"},
        {"Henry Draper", "HD 40957"},
        {"Hipparcos Number", "HIP 28775"},
        {"Geneva Identification System", "GEN# +1.00040957J"},
        {"Smithsonian Astrophysical Observation", "SAO 40831"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.14023254),
        dec: Angle.Degrees(+45.58634843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46450"},
        {"Hipparcos Number", "HIP 31493"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.94040714),
        dec: Angle.Degrees(+45.58937496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81512"},
        {"Smithsonian Astrophysical Observation", "SAO 46212"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.74688661),
        dec: Angle.Degrees(+45.59000104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49988"},
        {"Hipparcos Number", "HIP 33080"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.34205616),
        dec: Angle.Degrees(+45.59138280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205435"},
        {"Hipparcos Number", "HIP 106481"},
        {"Fundamental Katalog 5th Edition", "FK5 1568"},
        {"Geneva Identification System", "GEN# +1.00205435"},
        {"Smithsonian Astrophysical Observation", "SAO 51035"},
        {"Wilson Evans Batten Catalogue", "WEB 19273"},
    },
    visualMagnitude: 3.98,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.49530361),
        dec: Angle.Degrees(+45.59206564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152566"},
        {"Hipparcos Number", "HIP 82520"},
        {"Smithsonian Astrophysical Observation", "SAO 46335"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.98861629),
        dec: Angle.Degrees(+45.59406992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99826",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99826"},
        {"Smithsonian Astrophysical Observation", "SAO 49372"},
    },
    visualMagnitude: 8.57,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.81876440),
        dec: Angle.Degrees(+45.59433418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181961"},
        {"Hipparcos Number", "HIP 95052"},
        {"Fundamental Katalog 5th Edition", "FK5 5701"},
        {"Smithsonian Astrophysical Observation", "SAO 48350"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.10728159),
        dec: Angle.Degrees(+45.59461415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127662"},
        {"Hipparcos Number", "HIP 70999"},
        {"Smithsonian Astrophysical Observation", "SAO 45088"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.80990699),
        dec: Angle.Degrees(+45.59515345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83825"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.97830866),
        dec: Angle.Degrees(+45.59603974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7657"},
        {"Hipparcos Number", "HIP 6007"},
        {"Smithsonian Astrophysical Observation", "SAO 37080"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.31441780),
        dec: Angle.Degrees(+45.59635869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5596"},
        {"Hipparcos Number", "HIP 4555"},
        {"Geneva Identification System", "GEN# +1.00005596"},
        {"Smithsonian Astrophysical Observation", "SAO 36806"},
        {"Wilson Evans Batten Catalogue", "WEB 830"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.56857935),
        dec: Angle.Degrees(+45.59720588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80953",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10105 A"},
        {"Henry Draper", "HD 149303"},
        {"Henry Draper 2", "HD 149303A"},
        {"Hipparcos Number", "HIP 80953"},
        {"Geneva Identification System", "GEN# +1.00149303A"},
        {"Smithsonian Astrophysical Observation", "SAO 46147"},
        {"Wilson Evans Batten Catalogue", "WEB 13692"},
    },
    visualMagnitude: 5.61,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.94681111),
        dec: Angle.Degrees(+45.59818403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16979"},
        {"Hipparcos Number", "HIP 12818"},
        {"Geneva Identification System", "GEN# +1.00016979"},
        {"Smithsonian Astrophysical Observation", "SAO 38298"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.19551919),
        dec: Angle.Degrees(+45.59947098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11894"},
        {"Hipparcos Number", "HIP 9154"},
        {"Geneva Identification System", "GEN# +1.00011894"},
        {"Smithsonian Astrophysical Observation", "SAO 37647"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.48238777),
        dec: Angle.Degrees(+45.59951925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118095"},
        {"Hipparcos Number", "HIP 66181"},
        {"Geneva Identification System", "GEN# +1.00118095"},
        {"Smithsonian Astrophysical Observation", "SAO 44660"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.46506627),
        dec: Angle.Degrees(+45.59957849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23287"},
        {"Hipparcos Number", "HIP 17577"},
        {"Geneva Identification System", "GEN# +1.00023287"},
        {"Smithsonian Astrophysical Observation", "SAO 39084"},
        {"Wilson Evans Batten Catalogue", "WEB 3338"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.47171645),
        dec: Angle.Degrees(+45.60000602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15992",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2526 AB"},
        {"Hipparcos Number", "HIP 15992"},
        {"Smithsonian Astrophysical Observation", "SAO 38820"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.50443772),
        dec: Angle.Degrees(+45.60042088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46471",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Intercrus"},
        {"Henry Draper", "HD 81688"},
        {"Hipparcos Number", "HIP 46471"},
        {"Fundamental Katalog 5th Edition", "FK5 2751"},
        {"Geneva Identification System", "GEN# +1.00081688"},
        {"Smithsonian Astrophysical Observation", "SAO 42876"},
        {"Wilson Evans Batten Catalogue", "WEB 8774"},
    },
    visualMagnitude: 5.40,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.16664439),
        dec: Angle.Degrees(+45.60179470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57353",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8292 A"},
        {"Henry Draper", "HD 102130"},
        {"Hipparcos Number", "HIP 57353"},
        {"Smithsonian Astrophysical Observation", "SAO 43883"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.38401037),
        dec: Angle.Degrees(+45.60361366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137870"},
        {"Hipparcos Number", "HIP 75595"},
        {"Geneva Identification System", "GEN# +1.00137870"},
        {"Smithsonian Astrophysical Observation", "SAO 45546"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.68183055),
        dec: Angle.Degrees(+45.60379081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3430"},
        {"Hipparcos Number", "HIP 2962"},
        {"Smithsonian Astrophysical Observation", "SAO 36522"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.40722806),
        dec: Angle.Degrees(+45.60424052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101229"},
        {"Smithsonian Astrophysical Observation", "SAO 49734"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.78910212),
        dec: Angle.Degrees(+45.60435932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57355",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8292 B"},
        {"Hipparcos Number", "HIP 57355"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.38727182),
        dec: Angle.Degrees(+45.60560538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177723"},
        {"Hipparcos Number", "HIP 93607"},
        {"Smithsonian Astrophysical Observation", "SAO 48043"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.93797732),
        dec: Angle.Degrees(+45.60840164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6633",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1126 AB"},
        {"Henry Draper", "HD 8528"},
        {"Hipparcos Number", "HIP 6633"},
        {"Geneva Identification System", "GEN# +1.00008528J"},
        {"Smithsonian Astrophysical Observation", "SAO 37184"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.27812680),
        dec: Angle.Degrees(+45.60861225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42892"},
        {"Hipparcos Number", "HIP 29718"},
        {"Smithsonian Astrophysical Observation", "SAO 40976"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.89686605),
        dec: Angle.Degrees(+45.61051716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44029"},
        {"Hipparcos Number", "HIP 30246"},
        {"Geneva Identification System", "GEN# +1.00044029"},
        {"Smithsonian Astrophysical Observation", "SAO 41041"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.43878193),
        dec: Angle.Degrees(+45.61113821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202347"},
        {"Hipparcos Number", "HIP 104787"},
        {"Celescope Catalog", "CEL 5278"},
        {"Geneva Identification System", "GEN# +2.70390228"},
        {"Smithsonian Astrophysical Observation", "SAO 50592"},
        {"Wilson Evans Batten Catalogue", "WEB 19058"},
        {"New General Catalogue", "NGC 7039 228"},
    },
    visualMagnitude: 7.52,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.42440865),
        dec: Angle.Degrees(+45.61146814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95514"},
        {"Hipparcos Number", "HIP 53936"},
        {"Smithsonian Astrophysical Observation", "SAO 43584"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.54344703),
        dec: Angle.Degrees(+45.61171296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63191",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8714 A"},
        {"Henry Draper", "HD 112515"},
        {"Hipparcos Number", "HIP 63191"},
        {"Geneva Identification System", "GEN# +1.00112515A"},
        {"Renson", "Renson 32720"},
        {"Wilson Evans Batten Catalogue", "WEB 11202"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.18662906),
        dec: Angle.Degrees(+45.61258099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56582"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.00857687),
        dec: Angle.Degrees(+45.61296682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20413"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.58010561),
        dec: Angle.Degrees(+45.61466758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63190",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8714 B"},
        {"Hipparcos Number", "HIP 63190"},
        {"Geneva Identification System", "GEN# +1.00112515B"},
        {"Smithsonian Astrophysical Observation", "SAO 44396"},
        {"Wilson Evans Batten Catalogue", "WEB 11203"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.18598078),
        dec: Angle.Degrees(+45.61615754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88988",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88988"},
        {"Smithsonian Astrophysical Observation", "SAO 47271"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.44886029),
        dec: Angle.Degrees(+45.61689314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107286"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.96958074),
        dec: Angle.Degrees(+45.61747001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65915"},
        {"Hipparcos Number", "HIP 39384"},
        {"Geneva Identification System", "GEN# +1.00065915"},
        {"Smithsonian Astrophysical Observation", "SAO 42138"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.77930143),
        dec: Angle.Degrees(+45.61907903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28349",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4551 A"},
        {"Henry Draper", "HD 40143"},
        {"Hipparcos Number", "HIP 28349"},
        {"Smithsonian Astrophysical Observation", "SAO 40746"},
        {"Wilson Evans Batten Catalogue", "WEB 5540"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.85365917),
        dec: Angle.Degrees(+45.61965578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136290"},
        {"Hipparcos Number", "HIP 74885"},
        {"Geneva Identification System", "GEN# +1.00136290"},
        {"Smithsonian Astrophysical Observation", "SAO 45475"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.56237147),
        dec: Angle.Degrees(+45.61981881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21701",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21701"},
        {"Smithsonian Astrophysical Observation", "SAO 39671"},
        {"Wilson Evans Batten Catalogue", "WEB 4171"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.89110583),
        dec: Angle.Degrees(+45.62042981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61827"},
        {"Smithsonian Astrophysical Observation", "SAO 44276"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.06647696),
        dec: Angle.Degrees(+45.62217577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19101",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2972 AB"},
        {"Henry Draper", "HD 25582"},
        {"Hipparcos Number", "HIP 19101"},
        {"Smithsonian Astrophysical Observation", "SAO 39306"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.42105559),
        dec: Angle.Degrees(+45.62256252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82029",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82029"},
        {"Smithsonian Astrophysical Observation", "SAO 46265"},
        {"Wilson Evans Batten Catalogue", "WEB 13851"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.34688601),
        dec: Angle.Degrees(+45.62307650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46421"},
        {"Hipparcos Number", "HIP 31484"},
        {"Smithsonian Astrophysical Observation", "SAO 41193"},
        {"Wilson Evans Batten Catalogue", "WEB 6296"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.90452414),
        dec: Angle.Degrees(+45.62310046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198479"},
        {"Hipparcos Number", "HIP 102722"},
        {"Geneva Identification System", "GEN# +1.00198479"},
        {"Smithsonian Astrophysical Observation", "SAO 50098"},
        {"Wilson Evans Batten Catalogue", "WEB 18625"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.22912903),
        dec: Angle.Degrees(+45.62423469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9344"},
        {"Hipparcos Number", "HIP 7205"},
        {"Smithsonian Astrophysical Observation", "SAO 37300"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.21031041),
        dec: Angle.Degrees(+45.62547295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108858",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108858"},
        {"Smithsonian Astrophysical Observation", "SAO 51598"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.78989659),
        dec: Angle.Degrees(+45.62671954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106462"},
        {"Hipparcos Number", "HIP 59704"},
        {"Geneva Identification System", "GEN# +1.00106462"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.66793659),
        dec: Angle.Degrees(+45.62808113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34259",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34259"},
        {"Smithsonian Astrophysical Observation", "SAO 41551"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.52232669),
        dec: Angle.Degrees(+45.63012879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21947"},
        {"Geneva Identification System", "GEN# +0.04500973"},
        {"Smithsonian Astrophysical Observation", "SAO 39700"},
        {"Wilson Evans Batten Catalogue", "WEB 4218"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.75821521),
        dec: Angle.Degrees(+45.63040635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76291"},
        {"Hipparcos Number", "HIP 43923"},
        {"Geneva Identification System", "GEN# +1.00076291"},
        {"Smithsonian Astrophysical Observation", "SAO 42612"},
        {"Wilson Evans Batten Catalogue", "WEB 8444"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.20857178),
        dec: Angle.Degrees(+45.63175477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100652"},
        {"Smithsonian Astrophysical Observation", "SAO 49588"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.13595441),
        dec: Angle.Degrees(+45.63371089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8918"},
        {"Hipparcos Number", "HIP 6887"},
        {"Smithsonian Astrophysical Observation", "SAO 37251"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.17658791),
        dec: Angle.Degrees(+45.63373014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28747"},
        {"Hipparcos Number", "HIP 21289"},
        {"Geneva Identification System", "GEN# +1.00028747"},
        {"Smithsonian Astrophysical Observation", "SAO 39609"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.51856589),
        dec: Angle.Degrees(+45.63579827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14164"},
        {"Hipparcos Number", "HIP 10777"},
        {"Smithsonian Astrophysical Observation", "SAO 37939"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.67640362),
        dec: Angle.Degrees(+45.63974323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9144"},
        {"Geneva Identification System", "GEN# +0.04400391"},
        {"Smithsonian Astrophysical Observation", "SAO 37643"},
    },
    visualMagnitude: 9.33,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.46183404),
        dec: Angle.Degrees(+45.64030628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87387"},
        {"Hipparcos Number", "HIP 49460"},
        {"Smithsonian Astrophysical Observation", "SAO 43180"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.46962589),
        dec: Angle.Degrees(+45.64259398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35351",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35351"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.53329792),
        dec: Angle.Degrees(+45.64320472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159049"},
        {"Hipparcos Number", "HIP 85646"},
        {"Smithsonian Astrophysical Observation", "SAO 46755"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.54747367),
        dec: Angle.Degrees(+45.64410925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62440",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62440"},
        {"Smithsonian Astrophysical Observation", "SAO 44329"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.95502475),
        dec: Angle.Degrees(+45.64557167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50401"},
        {"Hipparcos Number", "HIP 33280"},
        {"Smithsonian Astrophysical Observation", "SAO 41430"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.83549063),
        dec: Angle.Degrees(+45.64611921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57864"},
        {"Smithsonian Astrophysical Observation", "SAO 43921"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.02067388),
        dec: Angle.Degrees(+45.64700182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14855"},
        {"Hipparcos Number", "HIP 11266"},
        {"Geneva Identification System", "GEN# +1.00014855"},
        {"Smithsonian Astrophysical Observation", "SAO 38012"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.26566892),
        dec: Angle.Degrees(+45.64753357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51846",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7838 AB"},
        {"Henry Draper", "HD 91603"},
        {"Hipparcos Number", "HIP 51846"},
        {"Geneva Identification System", "GEN# +1.00091603J"},
        {"Smithsonian Astrophysical Observation", "SAO 43396"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.88017408),
        dec: Angle.Degrees(+45.65372834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71148"},
        {"Hipparcos Number", "HIP 41484"},
        {"Fundamental Katalog 5th Edition", "FK5 2660"},
        {"Geneva Identification System", "GEN# +1.00071148"},
        {"Smithsonian Astrophysical Observation", "SAO 42369"},
        {"Wilson Evans Batten Catalogue", "WEB 8017"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.90333880),
        dec: Angle.Degrees(+45.65384111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -351.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80964"},
        {"Hipparcos Number", "HIP 46123"},
        {"Smithsonian Astrophysical Observation", "SAO 42840"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.08836531),
        dec: Angle.Degrees(+45.65420010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133542"},
        {"Hipparcos Number", "HIP 73665"},
        {"Smithsonian Astrophysical Observation", "SAO 45351"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.87585682),
        dec: Angle.Degrees(+45.65428381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103153"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.49154270),
        dec: Angle.Degrees(+45.65635024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 166.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16704"},
        {"Hipparcos Number", "HIP 12622"},
        {"Smithsonian Astrophysical Observation", "SAO 38250"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.56185122),
        dec: Angle.Degrees(+45.65672749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79006"},
        {"Hipparcos Number", "HIP 45224"},
        {"Smithsonian Astrophysical Observation", "SAO 42747"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.24264669),
        dec: Angle.Degrees(+45.65854553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65340",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65340"},
        {"Geneva Identification System", "GEN# +0.04601866"},
        {"Smithsonian Astrophysical Observation", "SAO 44593"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.88271244),
        dec: Angle.Degrees(+45.66273162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136795"},
        {"Hipparcos Number", "HIP 75107"},
        {"Smithsonian Astrophysical Observation", "SAO 45500"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.22035370),
        dec: Angle.Degrees(+45.66493406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130816"},
        {"Hipparcos Number", "HIP 72441"},
        {"Smithsonian Astrophysical Observation", "SAO 45222"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.20384483),
        dec: Angle.Degrees(+45.66569009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167587"},
        {"Hipparcos Number", "HIP 89325"},
        {"Smithsonian Astrophysical Observation", "SAO 47323"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.39646441),
        dec: Angle.Degrees(+45.66649238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197036"},
        {"Hipparcos Number", "HIP 101934"},
        {"Celescope Catalog", "CEL 5135"},
        {"Geneva Identification System", "GEN# +1.00197036"},
        {"Smithsonian Astrophysical Observation", "SAO 49898"},
        {"Wilson Evans Batten Catalogue", "WEB 18423"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.84635680),
        dec: Angle.Degrees(+45.66691280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155876"},
        {"Hipparcos Number", "HIP 84140"},
        {"Cincinnati Publication", "Ci 20 1023"},
        {"Geneva Identification System", "GEN# +1.00155876"},
        {"Wilson Evans Batten Catalogue", "WEB 14210"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.03174636),
        dec: Angle.Degrees(+45.66984247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 325.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1591.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57203"},
        {"Hipparcos Number", "HIP 35742"},
        {"Smithsonian Astrophysical Observation", "SAO 41720"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.58726364),
        dec: Angle.Degrees(+45.67006226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59082"},
        {"Hipparcos Number", "HIP 36490"},
        {"Smithsonian Astrophysical Observation", "SAO 41820"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.62023678),
        dec: Angle.Degrees(+45.67035747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85502"},
        {"Hipparcos Number", "HIP 48500"},
        {"Smithsonian Astrophysical Observation", "SAO 43087"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.36406947),
        dec: Angle.Degrees(+45.67070080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61092"},
        {"Hipparcos Number", "HIP 37316"},
        {"Geneva Identification System", "GEN# +1.00061092"},
        {"Smithsonian Astrophysical Observation", "SAO 41916"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.91785086),
        dec: Angle.Degrees(+45.67159347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172309"},
        {"Hipparcos Number", "HIP 91289"},
        {"Geneva Identification System", "GEN# +1.00172309"},
        {"Smithsonian Astrophysical Observation", "SAO 47656"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.30883257),
        dec: Angle.Degrees(+45.67170067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 404",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 41 AB"},
        {"Aitken 2", "ADS 41"},
        {"Henry Draper", "HD 225291"},
        {"Hipparcos Number", "HIP 404"},
        {"Geneva Identification System", "GEN# +1.00225291J"},
        {"Wilson Evans Batten Catalogue", "WEB 62"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.23961728),
        dec: Angle.Degrees(+45.67395209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156819"},
        {"Hipparcos Number", "HIP 84589"},
        {"Smithsonian Astrophysical Observation", "SAO 46614"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.37087616),
        dec: Angle.Degrees(+45.67406125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201935"},
        {"Hipparcos Number", "HIP 104592"},
        {"Geneva Identification System", "GEN# +2.70390072"},
        {"Smithsonian Astrophysical Observation", "SAO 50547"},
        {"New General Catalogue", "NGC 7039 72"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.81482272),
        dec: Angle.Degrees(+45.67423867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102609"},
        {"Geneva Identification System", "GEN# +0.04503279"},
        {"Wilson Evans Batten Catalogue", "WEB 18592"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.90355959),
        dec: Angle.Degrees(+45.67480171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201270"},
        {"Henry Draper 2", "HD 201271"},
        {"Hipparcos Number", "HIP 104220"},
        {"Geneva Identification System", "GEN# +1.00201270"},
        {"Smithsonian Astrophysical Observation", "SAO 50461"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.71871130),
        dec: Angle.Degrees(+45.67557086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8731"},
        {"Hipparcos Number", "HIP 6745"},
        {"Smithsonian Astrophysical Observation", "SAO 37218"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.70950379),
        dec: Angle.Degrees(+45.67745352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31016"},
        {"Hipparcos Number", "HIP 22817"},
        {"Geneva Identification System", "GEN# +1.00031016"},
        {"Smithsonian Astrophysical Observation", "SAO 39846"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.63897076),
        dec: Angle.Degrees(+45.68109346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58335"},
        {"Hipparcos Number", "HIP 36199"},
        {"Smithsonian Astrophysical Observation", "SAO 41775"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.82592009),
        dec: Angle.Degrees(+45.68143492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17584",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2746 A"},
        {"Henry Draper", "HD 23300"},
        {"Hipparcos Number", "HIP 17584"},
        {"Geneva Identification System", "GEN# +1.00023300J"},
        {"Smithsonian Astrophysical Observation", "SAO 39085"},
        {"Wilson Evans Batten Catalogue", "WEB 3344"},
    },
    visualMagnitude: 5.66,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.49685459),
        dec: Angle.Degrees(+45.68194432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131745"},
        {"Hipparcos Number", "HIP 72887"},
        {"Smithsonian Astrophysical Observation", "SAO 45265"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.45551242),
        dec: Angle.Degrees(+45.68270997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5353"},
        {"Hipparcos Number", "HIP 4364"},
        {"Geneva Identification System", "GEN# +1.00005353"},
        {"Smithsonian Astrophysical Observation", "SAO 36777"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.98367907),
        dec: Angle.Degrees(+45.68288202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100870"},
        {"Smithsonian Astrophysical Observation", "SAO 49642"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.78922203),
        dec: Angle.Degrees(+45.68402692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57557",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8308 A"},
        {"Henry Draper", "HD 102482"},
        {"Hipparcos Number", "HIP 57557"},
        {"Geneva Identification System", "GEN# +1.00102482"},
        {"Smithsonian Astrophysical Observation", "SAO 43893"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.96617310),
        dec: Angle.Degrees(+45.68493322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117143",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117143"},
        {"Wilson Evans Batten Catalogue", "WEB 20647"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.22309434),
        dec: Angle.Degrees(+45.68652957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107836",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107836"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.70037580),
        dec: Angle.Degrees(+45.68735786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141021"},
        {"Hipparcos Number", "HIP 77143"},
        {"Smithsonian Astrophysical Observation", "SAO 45707"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.25300039),
        dec: Angle.Degrees(+45.68790246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1978"},
        {"Smithsonian Astrophysical Observation", "SAO 36345"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.26681860),
        dec: Angle.Degrees(+45.68902231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 267.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93320",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93320"},
    },
    visualMagnitude: 11.22,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.11336178),
        dec: Angle.Degrees(+45.69278005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -226.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216560"},
        {"Hipparcos Number", "HIP 113012"},
        {"Geneva Identification System", "GEN# +1.00216560"},
        {"Smithsonian Astrophysical Observation", "SAO 52454"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.30007446),
        dec: Angle.Degrees(+45.69310214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221057"},
        {"Hipparcos Number", "HIP 115864"},
        {"Geneva Identification System", "GEN# +1.00221057"},
        {"Smithsonian Astrophysical Observation", "SAO 53059"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.11359184),
        dec: Angle.Degrees(+45.69319359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24959"},
        {"Hipparcos Number", "HIP 18675"},
        {"Fundamental Katalog 5th Edition", "FK5 4362"},
        {"Geneva Identification System", "GEN# +1.00024959"},
        {"Smithsonian Astrophysical Observation", "SAO 39235"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.98245876),
        dec: Angle.Degrees(+45.69797762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8276",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1400 A"},
        {"Henry Draper", "HD 10792"},
        {"Hipparcos Number", "HIP 8276"},
        {"Smithsonian Astrophysical Observation", "SAO 37496"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.66335773),
        dec: Angle.Degrees(+45.69929092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87190"},
        {"Smithsonian Astrophysical Observation", "SAO 46973"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.19673887),
        dec: Angle.Degrees(+45.69987239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165718"},
        {"Hipparcos Number", "HIP 88569"},
        {"Smithsonian Astrophysical Observation", "SAO 47201"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.26793863),
        dec: Angle.Degrees(+45.70292239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131581"},
        {"Hipparcos Number", "HIP 72815"},
        {"Smithsonian Astrophysical Observation", "SAO 45257"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.25043765),
        dec: Angle.Degrees(+45.70302446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104671",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14745 A"},
        {"Henry Draper", "HD 202068"},
        {"Hipparcos Number", "HIP 104671"},
        {"Celescope Catalog", "CEL 5269"},
        {"Geneva Identification System", "GEN# +2.70390217"},
        {"Smithsonian Astrophysical Observation", "SAO 50561"},
        {"New General Catalogue", "NGC 7039 217"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.02889103),
        dec: Angle.Degrees(+45.70350521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7862"},
        {"Hipparcos Number", "HIP 6162"},
        {"Smithsonian Astrophysical Observation", "SAO 37108"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.76308208),
        dec: Angle.Degrees(+45.70586519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37404"},
        {"Hipparcos Number", "HIP 26717"},
        {"Smithsonian Astrophysical Observation", "SAO 40525"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.17161714),
        dec: Angle.Degrees(+45.70760537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56380",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56380"},
        {"Smithsonian Astrophysical Observation", "SAO 43804"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.36634036),
        dec: Angle.Degrees(+45.71152567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49271"},
        {"Hipparcos Number", "HIP 32763"},
        {"Smithsonian Astrophysical Observation", "SAO 41369"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.47389198),
        dec: Angle.Degrees(+45.71405594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158034"},
        {"Hipparcos Number", "HIP 85205"},
        {"Smithsonian Astrophysical Observation", "SAO 46700"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.17075852),
        dec: Angle.Degrees(+45.71697191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201089"},
        {"Hipparcos Number", "HIP 104140"},
        {"Geneva Identification System", "GEN# +1.00201089"},
        {"Smithsonian Astrophysical Observation", "SAO 50443"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.48708451),
        dec: Angle.Degrees(+45.71759295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195322"},
        {"Hipparcos Number", "HIP 101020"},
        {"Celescope Catalog", "CEL 5078"},
        {"Geneva Identification System", "GEN# +1.00195322"},
        {"Smithsonian Astrophysical Observation", "SAO 49678"},
    },
    visualMagnitude: 7.40,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.20294686),
        dec: Angle.Degrees(+45.71883659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116726",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16904 AB"},
        {"Henry Draper", "HD 222326"},
        {"Hipparcos Number", "HIP 116726"},
        {"Geneva Identification System", "GEN# +1.00222326J"},
        {"Renson", "Renson 60940"},
        {"Smithsonian Astrophysical Observation", "SAO 53242"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.83668255),
        dec: Angle.Degrees(+45.71993892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160214"},
        {"Hipparcos Number", "HIP 86166"},
        {"Geneva Identification System", "GEN# +1.00160214"},
        {"Smithsonian Astrophysical Observation", "SAO 46832"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.12294202),
        dec: Angle.Degrees(+45.72050003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133087"},
        {"Hipparcos Number", "HIP 73478"},
        {"Geneva Identification System", "GEN# +1.00133087"},
        {"Smithsonian Astrophysical Observation", "SAO 45331"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.25534031),
        dec: Angle.Degrees(+45.72351984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222087"},
        {"Hipparcos Number", "HIP 116569"},
        {"Smithsonian Astrophysical Observation", "SAO 53196"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.34309247),
        dec: Angle.Degrees(+45.72851937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104270",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104270"},
        {"Geneva Identification System", "GEN# +0.04503417"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.85335040),
        dec: Angle.Degrees(+45.72929166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202664"},
        {"Hipparcos Number", "HIP 105001"},
        {"Celescope Catalog", "CEL 5284"},
        {"Geneva Identification System", "GEN# +1.00202664"},
        {"Smithsonian Astrophysical Observation", "SAO 50644"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.99128495),
        dec: Angle.Degrees(+45.73163720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141525"},
        {"Hipparcos Number", "HIP 77381"},
        {"Smithsonian Astrophysical Observation", "SAO 45732"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.94328739),
        dec: Angle.Degrees(+45.73288132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47625"},
        {"Hipparcos Number", "HIP 32063"},
        {"Geneva Identification System", "GEN# +1.00047625"},
        {"Smithsonian Astrophysical Observation", "SAO 41274"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.48250370),
        dec: Angle.Degrees(+45.73356098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14669"},
        {"Cincinnati Publication", "Ci 20 210"},
        {"Wilson Evans Batten Catalogue", "WEB 2849"},
    },
    visualMagnitude: 10.11,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.37980007),
        dec: Angle.Degrees(+45.73367767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -429.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -384.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174367"},
        {"Hipparcos Number", "HIP 92249"},
        {"Smithsonian Astrophysical Observation", "SAO 47817"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.00559806),
        dec: Angle.Degrees(+45.73393136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25197"},
        {"Hipparcos Number", "HIP 18829"},
        {"Smithsonian Astrophysical Observation", "SAO 39258"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.53988121),
        dec: Angle.Degrees(+45.73428544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22858",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22858"},
    },
    visualMagnitude: 11.04,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.76861873),
        dec: Angle.Degrees(+45.73474848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 356.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117543"},
        {"Hipparcos Number", "HIP 65876"},
        {"Smithsonian Astrophysical Observation", "SAO 44630"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.55289356),
        dec: Angle.Degrees(+45.73523732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187120"},
        {"Hipparcos Number", "HIP 97282"},
        {"Smithsonian Astrophysical Observation", "SAO 48820"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.57286286),
        dec: Angle.Degrees(+45.73620654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201666"},
        {"Hipparcos Number", "HIP 104454"},
        {"Celescope Catalog", "CEL 5252"},
        {"Geneva Identification System", "GEN# +2.70390206"},
        {"Smithsonian Astrophysical Observation", "SAO 50510"},
        {"New General Catalogue", "NGC 7039 206"},
    },
    visualMagnitude: 7.66,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.39421841),
        dec: Angle.Degrees(+45.73849479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76704"},
        {"Hipparcos Number", "HIP 44142"},
        {"Smithsonian Astrophysical Observation", "SAO 42634"},
        {"Wilson Evans Batten Catalogue", "WEB 8480"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.85136112),
        dec: Angle.Degrees(+45.73852162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192866"},
        {"Hipparcos Number", "HIP 99827"},
        {"Celescope Catalog", "CEL 4997"},
        {"Geneva Identification System", "GEN# +1.00192866"},
        {"Smithsonian Astrophysical Observation", "SAO 49373"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.82164614),
        dec: Angle.Degrees(+45.74102998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63903"},
        {"Hipparcos Number", "HIP 38527"},
        {"Geneva Identification System", "GEN# +1.00063903"},
        {"Smithsonian Astrophysical Observation", "SAO 42049"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.34532084),
        dec: Angle.Degrees(+45.74134007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210334"},
        {"Hipparcos Number", "HIP 109303"},
        {"Geneva Identification System", "GEN# +1.00210334"},
        {"Smithsonian Astrophysical Observation", "SAO 51684"},
        {"Wilson Evans Batten Catalogue", "WEB 19641"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.17025791),
        dec: Angle.Degrees(+45.74213801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91128",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91128"},
        {"Cincinnati Publication", "Ci 20 1095"},
        {"Geneva Identification System", "GEN# +0.04502743"},
        {"Wilson Evans Batten Catalogue", "WEB 15645"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.82505166),
        dec: Angle.Degrees(+45.74315534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 451.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 364.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213354"},
        {"Hipparcos Number", "HIP 111055"},
        {"Smithsonian Astrophysical Observation", "SAO 52064"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.46918467),
        dec: Angle.Degrees(+45.74474726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6873"},
        {"Hipparcos Number", "HIP 5466"},
        {"Smithsonian Astrophysical Observation", "SAO 36978"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.48856431),
        dec: Angle.Degrees(+45.74730707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94967",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94967"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.88114318),
        dec: Angle.Degrees(+45.74776571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19174"},
        {"Hipparcos Number", "HIP 14472"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.69888177),
        dec: Angle.Degrees(+45.75087655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23880"},
        {"Celescope Catalog", "CEL 536"},
        {"Geneva Identification System", "GEN# +0.04501044"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.97290947),
        dec: Angle.Degrees(+45.75223471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81560"},
        {"Hipparcos Number", "HIP 46408"},
        {"Smithsonian Astrophysical Observation", "SAO 42872"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.95772208),
        dec: Angle.Degrees(+45.75322746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122675"},
        {"Hipparcos Number", "HIP 68567"},
        {"Fundamental Katalog 5th Edition", "FK5 3115"},
        {"Geneva Identification System", "GEN# +1.00122675"},
        {"Smithsonian Astrophysical Observation", "SAO 44858"},
        {"Wilson Evans Batten Catalogue", "WEB 12007"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.55068753),
        dec: Angle.Degrees(+45.75364748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38287"},
        {"Hipparcos Number", "HIP 27298"},
        {"Geneva Identification System", "GEN# +1.00038287"},
        {"Smithsonian Astrophysical Observation", "SAO 40605"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.76150441),
        dec: Angle.Degrees(+45.75780949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24260"},
        {"Hipparcos Number", "HIP 18214"},
        {"Smithsonian Astrophysical Observation", "SAO 39176"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.41447459),
        dec: Angle.Degrees(+45.75818922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129845"},
        {"Hipparcos Number", "HIP 71996"},
        {"Smithsonian Astrophysical Observation", "SAO 45187"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.85735626),
        dec: Angle.Degrees(+45.76132020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140612"},
        {"Hipparcos Number", "HIP 76936"},
        {"Geneva Identification System", "GEN# +1.00140612"},
        {"Smithsonian Astrophysical Observation", "SAO 45692"},
        {"Wilson Evans Batten Catalogue", "WEB 13048"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.65813446),
        dec: Angle.Degrees(+45.76190849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68011",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68011"},
        {"Geneva Identification System", "GEN# +0.04601913"},
        {"Renson", "Renson 34980"},
        {"Smithsonian Astrophysical Observation", "SAO 44803"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.91386768),
        dec: Angle.Degrees(+45.76230333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41626"},
    },
    visualMagnitude: 11.14,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.29241501),
        dec: Angle.Degrees(+45.76251050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76238"},
        {"Hipparcos Number", "HIP 43898"},
        {"Geneva Identification System", "GEN# +1.00076238"},
        {"Smithsonian Astrophysical Observation", "SAO 42610"},
        {"Wilson Evans Batten Catalogue", "WEB 8441"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.14100168),
        dec: Angle.Degrees(+45.76412023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117896",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17094 A"},
        {"Henry Draper", "HD 224068"},
        {"Hipparcos Number", "HIP 117896"},
        {"Renson", "Renson 61410"},
        {"Smithsonian Astrophysical Observation", "SAO 53473"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.71086432),
        dec: Angle.Degrees(+45.76567977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206632"},
        {"Hipparcos Number", "HIP 107140"},
        {"Geneva Identification System", "GEN# +1.00206632"},
        {"Smithsonian Astrophysical Observation", "SAO 51204"},
        {"Wilson Evans Batten Catalogue", "WEB 19352"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.53480768),
        dec: Angle.Degrees(+45.76574535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1307"},
        {"Hipparcos Number", "HIP 1400"},
        {"Smithsonian Astrophysical Observation", "SAO 36240"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.37733461),
        dec: Angle.Degrees(+45.76597577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45370"},
        {"Hipparcos Number", "HIP 30915"},
        {"Smithsonian Astrophysical Observation", "SAO 41126"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.32915763),
        dec: Angle.Degrees(+45.76749026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67318"},
        {"Hipparcos Number", "HIP 39935"},
        {"Geneva Identification System", "GEN# +1.00067318"},
        {"Smithsonian Astrophysical Observation", "SAO 42197"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.33604495),
        dec: Angle.Degrees(+45.76758493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94633"},
        {"Hipparcos Number", "HIP 53467"},
        {"Smithsonian Astrophysical Observation", "SAO 43534"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.06331224),
        dec: Angle.Degrees(+45.77041954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189684"},
        {"Hipparcos Number", "HIP 98383"},
        {"Celescope Catalog", "CEL 4897"},
        {"Geneva Identification System", "GEN# +1.00189684"},
        {"Renson", "Renson 52613"},
        {"Smithsonian Astrophysical Observation", "SAO 49058"},
        {"Wilson Evans Batten Catalogue", "WEB 17363"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.83506255),
        dec: Angle.Degrees(+45.77258164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171383"},
        {"Hipparcos Number", "HIP 90886"},
        {"Smithsonian Astrophysical Observation", "SAO 47577"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.08736150),
        dec: Angle.Degrees(+45.77438165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133157"},
        {"Hipparcos Number", "HIP 73502"},
        {"Geneva Identification System", "GEN# +1.00133157"},
        {"Renson", "Renson 37815"},
        {"Smithsonian Astrophysical Observation", "SAO 45333"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.34918754),
        dec: Angle.Degrees(+45.77611902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63626"},
        {"Geneva Identification System", "GEN# +0.04601838"},
        {"Smithsonian Astrophysical Observation", "SAO 44438"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.60402179),
        dec: Angle.Degrees(+45.77652085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54098",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54098"},
        {"Smithsonian Astrophysical Observation", "SAO 43599"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.04762150),
        dec: Angle.Degrees(+45.77738534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12443"},
        {"Hipparcos Number", "HIP 9581"},
        {"Geneva Identification System", "GEN# +1.00012443"},
        {"Smithsonian Astrophysical Observation", "SAO 37732"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.78587052),
        dec: Angle.Degrees(+45.77741278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94118"},
        {"Hipparcos Number", "HIP 53160"},
        {"Geneva Identification System", "GEN# +1.00094118"},
        {"Smithsonian Astrophysical Observation", "SAO 43501"},
        {"Wilson Evans Batten Catalogue", "WEB 9653"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.13646285),
        dec: Angle.Degrees(+45.77780315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153970"},
        {"Hipparcos Number", "HIP 83222"},
        {"Geneva Identification System", "GEN# +1.00153970"},
        {"Smithsonian Astrophysical Observation", "SAO 46435"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.12068392),
        dec: Angle.Degrees(+45.77863885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32296"},
        {"Hipparcos Number", "HIP 23585"},
        {"Smithsonian Astrophysical Observation", "SAO 39988"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.06739108),
        dec: Angle.Degrees(+45.77950386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109655"},
        {"Hipparcos Number", "HIP 61487"},
        {"Fundamental Katalog 5th Edition", "FK5 5110"},
        {"Geneva Identification System", "GEN# +1.00109655"},
        {"Smithsonian Astrophysical Observation", "SAO 44240"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.97125883),
        dec: Angle.Degrees(+45.78092412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18270",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2842 AB"},
        {"Henry Draper", "HD 24352"},
        {"Hipparcos Number", "HIP 18270"},
        {"Renson", "Renson 6280"},
        {"Smithsonian Astrophysical Observation", "SAO 39183"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.62220346),
        dec: Angle.Degrees(+45.78159120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190274"},
        {"Hipparcos Number", "HIP 98655"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.57109832),
        dec: Angle.Degrees(+45.78277219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216117"},
        {"Hipparcos Number", "HIP 112710"},
        {"Smithsonian Astrophysical Observation", "SAO 52398"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.37269697),
        dec: Angle.Degrees(+45.78318751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108163",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15442 C"},
        {"Hipparcos Number", "HIP 108163"},
    },
    visualMagnitude: 11.00,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.71329354),
        dec: Angle.Degrees(+45.78324279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52875",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52875"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.20681642),
        dec: Angle.Degrees(+45.78536747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 428",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 48 F"},
        {"Hipparcos Number", "HIP 428"},
        {"Cincinnati Publication", "Ci 20 4"},
        {"Geneva Identification System", "GEN# +0.04404548"},
        {"Wilson Evans Batten Catalogue", "WEB 67"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.29233645),
        dec: Angle.Degrees(+45.78693438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 869.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115473",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16720 B"},
        {"Hipparcos Number", "HIP 115473"},
        {"Geneva Identification System", "GEN# +1.00220445B"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.87723854),
        dec: Angle.Degrees(+45.78854386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95126"},
        {"Hipparcos Number", "HIP 53735"},
        {"Geneva Identification System", "GEN# +1.00095126"},
        {"Smithsonian Astrophysical Observation", "SAO 43559"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.91754207),
        dec: Angle.Degrees(+45.78861485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212940"},
        {"Hipparcos Number", "HIP 110810"},
        {"Geneva Identification System", "GEN# +1.00212940"},
        {"Smithsonian Astrophysical Observation", "SAO 52011"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.75543188),
        dec: Angle.Degrees(+45.78949879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108161",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15442 AB"},
        {"Henry Draper", "HD 208395"},
        {"Hipparcos Number", "HIP 108161"},
        {"Smithsonian Astrophysical Observation", "SAO 51429"},
        {"Wilson Evans Batten Catalogue", "WEB 19497"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.70782641),
        dec: Angle.Degrees(+45.79161046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216889"},
        {"Hipparcos Number", "HIP 113266"},
        {"Smithsonian Astrophysical Observation", "SAO 52508"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.04158344),
        dec: Angle.Degrees(+45.79164263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63312"},
        {"Hipparcos Number", "HIP 38266"},
        {"Geneva Identification System", "GEN# +1.00063312"},
        {"Renson", "Renson 17470"},
        {"Smithsonian Astrophysical Observation", "SAO 42027"},
        {"Wilson Evans Batten Catalogue", "WEB 7534"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.59515394),
        dec: Angle.Degrees(+45.79185802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115470",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16720 A"},
        {"Henry Draper", "HD 220445"},
        {"Hipparcos Number", "HIP 115470"},
        {"Geneva Identification System", "GEN# +1.00220445A"},
        {"Smithsonian Astrophysical Observation", "SAO 52963"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.86949292),
        dec: Angle.Degrees(+45.79326087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 194.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77466",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77466"},
        {"Geneva Identification System", "GEN# +0.04602115"},
        {"Smithsonian Astrophysical Observation", "SAO 45746"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.24488147),
        dec: Angle.Degrees(+45.79343202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -272.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156613"},
        {"Hipparcos Number", "HIP 84490"},
        {"Smithsonian Astrophysical Observation", "SAO 46597"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.09640295),
        dec: Angle.Degrees(+45.79435798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194152"},
        {"Hipparcos Number", "HIP 100437"},
        {"Geneva Identification System", "GEN# +1.00194152"},
        {"Smithsonian Astrophysical Observation", "SAO 49531"},
        {"Wilson Evans Batten Catalogue", "WEB 18136"},
    },
    visualMagnitude: 5.58,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.52227775),
        dec: Angle.Degrees(+45.79489737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202163"},
        {"Hipparcos Number", "HIP 104709"},
        {"Celescope Catalog", "CEL 5274"},
        {"Geneva Identification System", "GEN# +2.70390222"},
        {"Smithsonian Astrophysical Observation", "SAO 50573"},
        {"New General Catalogue", "NGC 7039 222"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.15552351),
        dec: Angle.Degrees(+45.79514054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4675"},
        {"Hipparcos Number", "HIP 3844"},
        {"Smithsonian Astrophysical Observation", "SAO 36689"},
    },
    visualMagnitude: 9.05,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.32589677),
        dec: Angle.Degrees(+45.80208371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211835"},
        {"Hipparcos Number", "HIP 110177"},
        {"Geneva Identification System", "GEN# +1.00211835"},
        {"Smithsonian Astrophysical Observation", "SAO 51869"},
    },
    visualMagnitude: 8.37,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.75101246),
        dec: Angle.Degrees(+45.80238016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207486"},
        {"Hipparcos Number", "HIP 107636"},
        {"Smithsonian Astrophysical Observation", "SAO 51317"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.03454401),
        dec: Angle.Degrees(+45.80430625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8679",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1475 B"},
        {"Hipparcos Number", "HIP 8679"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.92336523),
        dec: Angle.Degrees(+45.80623886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16667"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.62483524),
        dec: Angle.Degrees(+45.80835601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8678",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1475 A"},
        {"Henry Draper", "HD 11254"},
        {"Hipparcos Number", "HIP 8678"},
        {"Smithsonian Astrophysical Observation", "SAO 37565"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.92235662),
        dec: Angle.Degrees(+45.81061432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18626"},
        {"Hipparcos Number", "HIP 14068"},
        {"Smithsonian Astrophysical Observation", "SAO 38511"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.31844818),
        dec: Angle.Degrees(+45.81169931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 473",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 48 AB"},
        {"Henry Draper", "HD 38"},
        {"Hipparcos Number", "HIP 473"},
        {"Cincinnati Publication", "Ci 20 6"},
        {"Geneva Identification System", "GEN# +1.00000038"},
        {"Wilson Evans Batten Catalogue", "WEB 74"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.41782275),
        dec: Angle.Degrees(+45.81245496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 878.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104740"},
        {"Hipparcos Number", "HIP 58805"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.92240778),
        dec: Angle.Degrees(+45.81588223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5117"},
        {"Hipparcos Number", "HIP 4202"},
        {"Geneva Identification System", "GEN# +1.00005117"},
        {"Smithsonian Astrophysical Observation", "SAO 36749"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.40972553),
        dec: Angle.Degrees(+45.81796174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61745"},
        {"Hipparcos Number", "HIP 37601"},
        {"Smithsonian Astrophysical Observation", "SAO 41955"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.72596995),
        dec: Angle.Degrees(+45.81801483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20298",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20298"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.24164142),
        dec: Angle.Degrees(+45.82023711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 333.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173129"},
        {"Hipparcos Number", "HIP 91664"},
        {"Smithsonian Astrophysical Observation", "SAO 47711"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.38938682),
        dec: Angle.Degrees(+45.82169290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108350",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108350"},
        {"Smithsonian Astrophysical Observation", "SAO 51474"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.26030409),
        dec: Angle.Degrees(+45.82307976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102189",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14190 A"},
        {"Henry Draper", "HD 197488"},
        {"Hipparcos Number", "HIP 102189"},
        {"Geneva Identification System", "GEN# +1.00197488"},
        {"Smithsonian Astrophysical Observation", "SAO 49960"},
        {"Wilson Evans Batten Catalogue", "WEB 18489"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.58480386),
        dec: Angle.Degrees(+45.82391611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111251"},
        {"Smithsonian Astrophysical Observation", "SAO 52117"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.08830608),
        dec: Angle.Degrees(+45.82474334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9671"},
        {"Smithsonian Astrophysical Observation", "SAO 37739"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.09401811),
        dec: Angle.Degrees(+45.82506221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50384"},
        {"Hipparcos Number", "HIP 33271"},
        {"Geneva Identification System", "GEN# +1.00050384"},
        {"Smithsonian Astrophysical Observation", "SAO 41426"},
        {"Wilson Evans Batten Catalogue", "WEB 6691"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.81338898),
        dec: Angle.Degrees(+45.82658764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74758",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74758"},
        {"Smithsonian Astrophysical Observation", "SAO 45464"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.18217074),
        dec: Angle.Degrees(+45.82798973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214557"},
        {"Hipparcos Number", "HIP 111748"},
        {"Geneva Identification System", "GEN# +1.00214557"},
        {"Smithsonian Astrophysical Observation", "SAO 52209"},
        {"Wilson Evans Batten Catalogue", "WEB 19964"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.54881177),
        dec: Angle.Degrees(+45.82822680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7723",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7723"},
        {"Smithsonian Astrophysical Observation", "SAO 37407"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.85274559),
        dec: Angle.Degrees(+45.82841085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176300"},
        {"Hipparcos Number", "HIP 93061"},
        {"Smithsonian Astrophysical Observation", "SAO 47951"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.34769814),
        dec: Angle.Degrees(+45.83122296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34806"},
        {"Hipparcos Number", "HIP 25099"},
        {"Smithsonian Astrophysical Observation", "SAO 40281"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.60124506),
        dec: Angle.Degrees(+45.83193597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73593"},
        {"Hipparcos Number", "HIP 42604"},
        {"Fundamental Katalog 5th Edition", "FK5 1225"},
        {"Geneva Identification System", "GEN# +1.00073593"},
        {"Smithsonian Astrophysical Observation", "SAO 42490"},
        {"Wilson Evans Batten Catalogue", "WEB 8226"},
    },
    visualMagnitude: 5.35,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.25436677),
        dec: Angle.Degrees(+45.83378521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30649"},
        {"Hipparcos Number", "HIP 22596"},
        {"Cincinnati Publication", "Ci 20 307"},
        {"Geneva Identification System", "GEN# +1.00030649"},
        {"Smithsonian Astrophysical Observation", "SAO 39808"},
        {"Wilson Evans Batten Catalogue", "WEB 4366"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.93017644),
        dec: Angle.Degrees(+45.83553006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 376.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -564.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183299"},
        {"Hipparcos Number", "HIP 95614"},
        {"Geneva Identification System", "GEN# +1.00183299"},
        {"Smithsonian Astrophysical Observation", "SAO 48455"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.72007542),
        dec: Angle.Degrees(+45.83600119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135422"},
        {"Hipparcos Number", "HIP 74489"},
        {"Geneva Identification System", "GEN# +1.00135422"},
        {"Smithsonian Astrophysical Observation", "SAO 45439"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.32136143),
        dec: Angle.Degrees(+45.83778764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13955"},
        {"Hipparcos Number", "HIP 10654"},
        {"Smithsonian Astrophysical Observation", "SAO 37920"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.28132175),
        dec: Angle.Degrees(+45.83840611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5526"},
        {"Hipparcos Number", "HIP 4501"},
        {"Geneva Identification System", "GEN# +1.00005526"},
        {"Smithsonian Astrophysical Observation", "SAO 36795"},
        {"Wilson Evans Batten Catalogue", "WEB 815"},
    },
    visualMagnitude: 6.10,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.41514948),
        dec: Angle.Degrees(+45.83939494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114625",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114625"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.31309769),
        dec: Angle.Degrees(+45.84029681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13076"},
        {"Hipparcos Number", "HIP 10038"},
        {"Geneva Identification System", "GEN# +1.00013076"},
        {"Smithsonian Astrophysical Observation", "SAO 37806"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.29729709),
        dec: Angle.Degrees(+45.84074677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18652"},
        {"Hipparcos Number", "HIP 14085"},
        {"Smithsonian Astrophysical Observation", "SAO 38514"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.40448738),
        dec: Angle.Degrees(+45.84100363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104405"},
        {"Hipparcos Number", "HIP 58636"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.36275705),
        dec: Angle.Degrees(+45.84124440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112029"},
        {"Hipparcos Number", "HIP 62855"},
        {"Geneva Identification System", "GEN# +1.00112029"},
        {"Smithsonian Astrophysical Observation", "SAO 44370"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.25566040),
        dec: Angle.Degrees(+45.84256172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103871",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14585 AB"},
        {"Henry Draper", "HD 200595"},
        {"Hipparcos Number", "HIP 103871"},
        {"Celescope Catalog", "CEL 5236"},
        {"Geneva Identification System", "GEN# +1.00200595J"},
        {"Smithsonian Astrophysical Observation", "SAO 50390"},
        {"Wilson Evans Batten Catalogue", "WEB 18909"},
    },
    visualMagnitude: 6.50,
    bvColour: -0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.70256902),
        dec: Angle.Degrees(+45.84889936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93018",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93018"},
    },
    visualMagnitude: 11.14,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)57, 01.6900),
        dec: Angle.DegreesMinutesSeconds((int)+45, (int)50, 58.500)
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
    primaryId: "HIP 49734",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49734"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.29257112),
        dec: Angle.Degrees(+45.85106220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90790"},
        {"Hipparcos Number", "HIP 51403"},
        {"Geneva Identification System", "GEN# +1.00090790"},
        {"Smithsonian Astrophysical Observation", "SAO 43361"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.48599440),
        dec: Angle.Degrees(+45.85228840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205349"},
        {"Hipparcos Number", "HIP 106420"},
        {"Geneva Identification System", "GEN# +1.00205349"},
        {"Smithsonian Astrophysical Observation", "SAO 51027"},
        {"Wilson Evans Batten Catalogue", "WEB 19266"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.32452708),
        dec: Angle.Degrees(+45.85402371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97812"},
        {"Hipparcos Number", "HIP 55004"},
        {"Smithsonian Astrophysical Observation", "SAO 43665"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.93179868),
        dec: Angle.Degrees(+45.85508900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87877",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10934 AB"},
        {"Henry Draper", "HD 164059"},
        {"Hipparcos Number", "HIP 87877"},
        {"Smithsonian Astrophysical Observation", "SAO 47084"},
        {"Wilson Evans Batten Catalogue", "WEB 14837"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.27118639),
        dec: Angle.Degrees(+45.85569337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176209"},
        {"Hipparcos Number", "HIP 93022"},
        {"Smithsonian Astrophysical Observation", "SAO 47947"},
        {"Wilson Evans Batten Catalogue", "WEB 16109"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.26268253),
        dec: Angle.Degrees(+45.85590365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106616"},
        {"Smithsonian Astrophysical Observation", "SAO 51070"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.91982855),
        dec: Angle.Degrees(+45.85738035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104697",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14752 A"},
        {"Henry Draper", "HD 202144"},
        {"Hipparcos Number", "HIP 104697"},
        {"Geneva Identification System", "GEN# +2.70390221"},
        {"Smithsonian Astrophysical Observation", "SAO 50570"},
        {"New General Catalogue", "NGC 7039 221"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.12228046),
        dec: Angle.Degrees(+45.86005000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43204"},
        {"Hipparcos Number", "HIP 29871"},
        {"Smithsonian Astrophysical Observation", "SAO 40997"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.34096065),
        dec: Angle.Degrees(+45.86061974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82937"},
        {"Smithsonian Astrophysical Observation", "SAO 46386"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.22775660),
        dec: Angle.Degrees(+45.86211242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40064"},
        {"Hipparcos Number", "HIP 28317"},
        {"Geneva Identification System", "GEN# +1.00040064"},
        {"Smithsonian Astrophysical Observation", "SAO 40742"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.74682796),
        dec: Angle.Degrees(+45.86387041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81276"},
    },
    visualMagnitude: 11.24,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.99464387),
        dec: Angle.Degrees(+45.86608650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -154.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 155.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98215"},
        {"Hipparcos Number", "HIP 55216"},
        {"Smithsonian Astrophysical Observation", "SAO 43688"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.61067694),
        dec: Angle.Degrees(+45.86659707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80407"},
        {"Hipparcos Number", "HIP 45864"},
        {"Smithsonian Astrophysical Observation", "SAO 42816"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.28137487),
        dec: Angle.Degrees(+45.86701268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139921"},
        {"Hipparcos Number", "HIP 76649"},
        {"Smithsonian Astrophysical Observation", "SAO 45662"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.78079474),
        dec: Angle.Degrees(+45.86758811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84345"},
        {"Hipparcos Number", "HIP 47924"},
        {"Smithsonian Astrophysical Observation", "SAO 43022"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.50262740),
        dec: Angle.Degrees(+45.87028851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1977"},
        {"Hipparcos Number", "HIP 1916"},
        {"Geneva Identification System", "GEN# +1.00001977"},
        {"Smithsonian Astrophysical Observation", "SAO 36332"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.05763842),
        dec: Angle.Degrees(+45.87288001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20568"},
        {"Hipparcos Number", "HIP 15551"},
        {"Smithsonian Astrophysical Observation", "SAO 38735"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.08735396),
        dec: Angle.Degrees(+45.87367594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110500"},
        {"Hipparcos Number", "HIP 61989"},
        {"Geneva Identification System", "GEN# +1.00110500"},
        {"Renson", "Renson 32120"},
        {"Smithsonian Astrophysical Observation", "SAO 44292"},
        {"Wilson Evans Batten Catalogue", "WEB 11026"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.56214851),
        dec: Angle.Degrees(+45.87706488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162036"},
        {"Hipparcos Number", "HIP 86999"},
        {"Geneva Identification System", "GEN# +1.00162036"},
        {"Smithsonian Astrophysical Observation", "SAO 46945"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.66882099),
        dec: Angle.Degrees(+45.87798991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10086"},
        {"Hipparcos Number", "HIP 7734"},
        {"Geneva Identification System", "GEN# +1.00010086"},
        {"Smithsonian Astrophysical Observation", "SAO 37410"},
        {"Wilson Evans Batten Catalogue", "WEB 1658"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.89931748),
        dec: Angle.Degrees(+45.87832743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 216.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -228.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42351",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42351"},
        {"Smithsonian Astrophysical Observation", "SAO 42462"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.51622051),
        dec: Angle.Degrees(+45.88360946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103859",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14585 C"},
        {"Henry Draper", "HD 200560"},
        {"Henry Draper 2", "HD 200560A"},
        {"Hipparcos Number", "HIP 103859"},
        {"Cincinnati Publication", "Ci 18 2727"},
        {"Cincinnati Publication 2", "Ci 20 1252"},
        {"Geneva Identification System", "GEN# +1.00200560"},
        {"Smithsonian Astrophysical Observation", "SAO 50388"},
        {"Wilson Evans Batten Catalogue", "WEB 18906"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.66841111),
        dec: Angle.Degrees(+45.88442774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 402.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 141.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115628"},
        {"Hipparcos Number", "HIP 64860"},
        {"Geneva Identification System", "GEN# +1.00115628"},
        {"Smithsonian Astrophysical Observation", "SAO 44550"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.42137080),
        dec: Angle.Degrees(+45.88528794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140771"},
        {"Hipparcos Number", "HIP 77028"},
        {"Smithsonian Astrophysical Observation", "SAO 45699"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.90441577),
        dec: Angle.Degrees(+45.88554948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113715",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113715"},
        {"Wilson Evans Batten Catalogue", "WEB 20206"},
    },
    visualMagnitude: 9.66,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.45612683),
        dec: Angle.Degrees(+45.88586461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24610"},
        {"Hipparcos Number", "HIP 18463"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.18246325),
        dec: Angle.Degrees(+45.88833311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221459"},
        {"Hipparcos Number", "HIP 116151"},
        {"Smithsonian Astrophysical Observation", "SAO 53123"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.00089237),
        dec: Angle.Degrees(+45.88895128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31855"},
        {"Hipparcos Number", "HIP 23355"},
        {"Geneva Identification System", "GEN# +1.00031855"},
        {"Smithsonian Astrophysical Observation", "SAO 39945"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.33973283),
        dec: Angle.Degrees(+45.88913940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204814"},
        {"Hipparcos Number", "HIP 106122"},
        {"Cincinnati Publication", "Ci 18 2797"},
        {"Cincinnati Publication 2", "Ci 20 1287"},
        {"Geneva Identification System", "GEN# +1.00204814"},
        {"Smithsonian Astrophysical Observation", "SAO 50940"},
        {"Wilson Evans Batten Catalogue", "WEB 19231"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.44358337),
        dec: Angle.Degrees(+45.89363408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 426.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 352.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146154"},
        {"Hipparcos Number", "HIP 79433"},
        {"Smithsonian Astrophysical Observation", "SAO 45968"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.17929136),
        dec: Angle.Degrees(+45.89433839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17217",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2680 AB"},
        {"Henry Draper", "HD 22743"},
        {"Hipparcos Number", "HIP 17217"},
        {"Smithsonian Astrophysical Observation", "SAO 39041"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.31653531),
        dec: Angle.Degrees(+45.89582949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216107"},
        {"Hipparcos Number", "HIP 112700"},
        {"Smithsonian Astrophysical Observation", "SAO 52395"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.34015348),
        dec: Angle.Degrees(+45.89736113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39863"},
        {"Hipparcos Number", "HIP 28208"},
        {"Geneva Identification System", "GEN# +1.00039863"},
        {"Smithsonian Astrophysical Observation", "SAO 40726"},
        {"Wilson Evans Batten Catalogue", "WEB 5520"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.40561801),
        dec: Angle.Degrees(+45.90134837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48804",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7588 AB"},
        {"Henry Draper", "HD 86057"},
        {"Hipparcos Number", "HIP 48804"},
        {"Smithsonian Astrophysical Observation", "SAO 43111"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.31076063),
        dec: Angle.Degrees(+45.90299777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47250",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7457 AB"},
        {"Henry Draper", "HD 83158"},
        {"Hipparcos Number", "HIP 47250"},
        {"Smithsonian Astrophysical Observation", "SAO 42950"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.46527316),
        dec: Angle.Degrees(+45.90365023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105037",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105037"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.13222657),
        dec: Angle.Degrees(+45.90774981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41641",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41641"},
        {"Cincinnati Publication", "Ci 20 474"},
        {"Wilson Evans Batten Catalogue", "WEB 8037"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.36492981),
        dec: Angle.Degrees(+45.91135834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -343.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -433.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28772"},
        {"Hipparcos Number", "HIP 21301"},
        {"Geneva Identification System", "GEN# +1.00028772"},
        {"Smithsonian Astrophysical Observation", "SAO 39615"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.56898856),
        dec: Angle.Degrees(+45.91361571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91330"},
        {"Hipparcos Number", "HIP 51694"},
        {"Smithsonian Astrophysical Observation", "SAO 43382"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.40241754),
        dec: Angle.Degrees(+45.91453759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62545"},
        {"Hipparcos Number", "HIP 37936"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.61896113),
        dec: Angle.Degrees(+45.91488211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10929"},
        {"Hipparcos Number", "HIP 8400"},
        {"Smithsonian Astrophysical Observation", "SAO 37523"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.09803811),
        dec: Angle.Degrees(+45.91580914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43442"},
        {"Smithsonian Astrophysical Observation", "SAO 42567"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.71411481),
        dec: Angle.Degrees(+45.91596450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17199"},
        {"Hipparcos Number", "HIP 13007"},
        {"Smithsonian Astrophysical Observation", "SAO 38326"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.79555717),
        dec: Angle.Degrees(+45.91671963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173154"},
        {"Hipparcos Number", "HIP 91670"},
        {"Geneva Identification System", "GEN# +1.00173154"},
        {"Smithsonian Astrophysical Observation", "SAO 47714"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.41171072),
        dec: Angle.Degrees(+45.91765040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41994",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41994"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.39565963),
        dec: Angle.Degrees(+45.91933839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177931"},
        {"Hipparcos Number", "HIP 93673"},
        {"Fundamental Katalog 5th Edition", "FK5 5680"},
        {"Geneva Identification System", "GEN# +1.00177931"},
        {"Smithsonian Astrophysical Observation", "SAO 48058"},
        {"Wilson Evans Batten Catalogue", "WEB 16276"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.13755351),
        dec: Angle.Degrees(+45.92162799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10245"},
        {"Geneva Identification System", "GEN# +0.04500564"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.94435823),
        dec: Angle.Degrees(+45.92426666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 277.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178686"},
        {"Hipparcos Number", "HIP 93921"},
        {"Smithsonian Astrophysical Observation", "SAO 48109"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.86081061),
        dec: Angle.Degrees(+45.92430582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81626"},
        {"Hipparcos Number", "HIP 46439"},
        {"Smithsonian Astrophysical Observation", "SAO 42874"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.06359462),
        dec: Angle.Degrees(+45.92535566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100144"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.70991777),
        dec: Angle.Degrees(+45.92567867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2805"},
        {"Hipparcos Number", "HIP 2507"},
        {"Geneva Identification System", "GEN# +1.00002805"},
        {"Smithsonian Astrophysical Observation", "SAO 36443"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.94718717),
        dec: Angle.Degrees(+45.92637299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13243"},
        {"Hipparcos Number", "HIP 10156"},
        {"Geneva Identification System", "GEN# +1.00013243"},
        {"Smithsonian Astrophysical Observation", "SAO 37831"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.65638217),
        dec: Angle.Degrees(+45.92729606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123692"},
        {"Hipparcos Number", "HIP 69045"},
        {"Smithsonian Astrophysical Observation", "SAO 44903"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.99131001),
        dec: Angle.Degrees(+45.92769257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195506"},
        {"Hipparcos Number", "HIP 101133"},
        {"Geneva Identification System", "GEN# +1.00195506"},
        {"Smithsonian Astrophysical Observation", "SAO 49704"},
        {"Wilson Evans Batten Catalogue", "WEB 18265"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.49947843),
        dec: Angle.Degrees(+45.92819432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 148.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14885"},
        {"Hipparcos Number", "HIP 11292"},
        {"Geneva Identification System", "GEN# +1.00014885"},
        {"Smithsonian Astrophysical Observation", "SAO 38015"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.35809978),
        dec: Angle.Degrees(+45.92893107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3989"},
        {"Hipparcos Number", "HIP 3365"},
        {"Geneva Identification System", "GEN# +1.00003989"},
        {"Smithsonian Astrophysical Observation", "SAO 36596"},
        {"Wilson Evans Batten Catalogue", "WEB 597"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.70411741),
        dec: Angle.Degrees(+45.92956081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63630"},
        {"Hipparcos Number", "HIP 38403"},
        {"Smithsonian Astrophysical Observation", "SAO 42034"},
        {"Wilson Evans Batten Catalogue", "WEB 7553"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.01622073),
        dec: Angle.Degrees(+45.93309767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75388"},
        {"Hipparcos Number", "HIP 43481"},
        {"Smithsonian Astrophysical Observation", "SAO 42571"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.84664803),
        dec: Angle.Degrees(+45.93328394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15965"},
        {"Hipparcos Number", "HIP 12056"},
        {"Smithsonian Astrophysical Observation", "SAO 38145"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.85668532),
        dec: Angle.Degrees(+45.93421915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40239"},
        {"Hipparcos Number", "HIP 28404"},
        {"Geneva Identification System", "GEN# +1.00040239"},
        {"Smithsonian Astrophysical Observation", "SAO 40756"},
        {"Wilson Evans Batten Catalogue", "WEB 5551"},
    },
    visualMagnitude: 4.30,
    bvColour: 1.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.98375587),
        dec: Angle.Degrees(+45.93675346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30736"},
        {"Hipparcos Number", "HIP 22650"},
        {"Geneva Identification System", "GEN# +1.00030736"},
        {"Smithsonian Astrophysical Observation", "SAO 39819"},
        {"Wilson Evans Batten Catalogue", "WEB 4381"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.08945847),
        dec: Angle.Degrees(+45.94004302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19540"},
        {"Hipparcos Number", "HIP 14742"},
        {"Geneva Identification System", "GEN# +1.00019540"},
        {"Smithsonian Astrophysical Observation", "SAO 38620"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.58577348),
        dec: Angle.Degrees(+45.94042011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56881",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56881"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.90915380),
        dec: Angle.Degrees(+45.94213188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6756"},
        {"Hipparcos Number", "HIP 5388"},
        {"Celescope Catalog", "CEL 121"},
        {"Geneva Identification System", "GEN# +1.00006756"},
        {"Smithsonian Astrophysical Observation", "SAO 36964"},
    },
    visualMagnitude: 8.08,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.23753223),
        dec: Angle.Degrees(+45.94264705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69573"},
    },
    visualMagnitude: 11.59,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.62197159),
        dec: Angle.Degrees(+45.94266784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83239"},
        {"Hipparcos Number", "HIP 47304"},
        {"Smithsonian Astrophysical Observation", "SAO 42957"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.59622705),
        dec: Angle.Degrees(+45.94322991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148195"},
        {"Hipparcos Number", "HIP 80360"},
        {"Geneva Identification System", "GEN# +1.00148195"},
        {"Smithsonian Astrophysical Observation", "SAO 46069"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.06694973),
        dec: Angle.Degrees(+45.94421843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4223"},
    },
    visualMagnitude: 11.11,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.47081918),
        dec: Angle.Degrees(+45.94440000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 303.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115215"},
        {"Smithsonian Astrophysical Observation", "SAO 52921"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.05462802),
        dec: Angle.Degrees(+45.94564373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137664"},
        {"Hipparcos Number", "HIP 75508"},
        {"Geneva Identification System", "GEN# +1.00137664"},
        {"Smithsonian Astrophysical Observation", "SAO 45533"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.37288633),
        dec: Angle.Degrees(+45.94750530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113140"},
        {"Hipparcos Number", "HIP 63515"},
        {"Geneva Identification System", "GEN# +1.00113140"},
        {"Smithsonian Astrophysical Observation", "SAO 44427"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.23026165),
        dec: Angle.Degrees(+45.94907204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20993",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20993"},
        {"Smithsonian Astrophysical Observation", "SAO 39565"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.53301115),
        dec: Angle.Degrees(+45.95058475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15455",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15455"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.82716206),
        dec: Angle.Degrees(+45.95129197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48525"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.45405273),
        dec: Angle.Degrees(+45.95201688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80723",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80723"},
    },
    visualMagnitude: 10.90,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.21553881),
        dec: Angle.Degrees(+45.95657706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24177"},
        {"Hipparcos Number", "HIP 18166"},
        {"Smithsonian Astrophysical Observation", "SAO 39169"},
        {"Wilson Evans Batten Catalogue", "WEB 3502"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.25956790),
        dec: Angle.Degrees(+45.95687569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185955"},
        {"Hipparcos Number", "HIP 96706"},
        {"Geneva Identification System", "GEN# +1.00185955"},
        {"Smithsonian Astrophysical Observation", "SAO 48697"},
        {"Wilson Evans Batten Catalogue", "WEB 16967"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.89386216),
        dec: Angle.Degrees(+45.95738010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52254"},
        {"Hipparcos Number", "HIP 33954"},
        {"Geneva Identification System", "GEN# +1.00052254"},
        {"Smithsonian Astrophysical Observation", "SAO 41512"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.67940671),
        dec: Angle.Degrees(+45.95742572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 794"},
        {"Hipparcos Number", "HIP 995"},
        {"Smithsonian Astrophysical Observation", "SAO 36154"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.10993546),
        dec: Angle.Degrees(+45.95960688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89536"},
        {"Hipparcos Number", "HIP 50678"},
        {"Geneva Identification System", "GEN# +1.00089536"},
        {"Smithsonian Astrophysical Observation", "SAO 43293"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.23092881),
        dec: Angle.Degrees(+45.96273427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51301",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7785 AB"},
        {"Henry Draper", "HD 90619"},
        {"Hipparcos Number", "HIP 51301"},
        {"Smithsonian Astrophysical Observation", "SAO 43357"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.18276838),
        dec: Angle.Degrees(+45.96418957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43280"},
        {"Hipparcos Number", "HIP 29905"},
        {"Smithsonian Astrophysical Observation", "SAO 41002"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.44902316),
        dec: Angle.Degrees(+45.96788270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11760"},
        {"Hipparcos Number", "HIP 9040"},
        {"Geneva Identification System", "GEN# +1.00011760"},
        {"Smithsonian Astrophysical Observation", "SAO 37622"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.11822196),
        dec: Angle.Degrees(+45.96972427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50278"},
        {"Smithsonian Astrophysical Observation", "SAO 43251"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.98372528),
        dec: Angle.Degrees(+45.97485919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48296"},
        {"Hipparcos Number", "HIP 32341"},
        {"Smithsonian Astrophysical Observation", "SAO 41311"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.26522336),
        dec: Angle.Degrees(+45.97647762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7299",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1218 A"},
        {"Henry Draper", "HD 9480"},
        {"Hipparcos Number", "HIP 7299"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.50272961),
        dec: Angle.Degrees(+45.97658677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13336",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2173 AB"},
        {"Aitken 2", "ADS 2173"},
        {"Henry Draper", "HD 17647"},
        {"Hipparcos Number", "HIP 13336"},
        {"Cincinnati Publication", "Ci 20 186"},
        {"Cincinnati Publication 2", "Ci 18 364"},
        {"Geneva Identification System", "GEN# +1.00017647"},
        {"Smithsonian Astrophysical Observation", "SAO 38396"},
        {"Wilson Evans Batten Catalogue", "WEB 2671"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.91312598),
        dec: Angle.Degrees(+45.98006404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 487.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -285.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118142"},
        {"Hipparcos Number", "HIP 66199"},
        {"Smithsonian Astrophysical Observation", "SAO 44665"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.53158080),
        dec: Angle.Degrees(+45.98074811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41185"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.06631288),
        dec: Angle.Degrees(+45.98140392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220551"},
        {"Hipparcos Number", "HIP 115538"},
        {"Smithsonian Astrophysical Observation", "SAO 52979"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.05607831),
        dec: Angle.Degrees(+45.98178520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113373",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113373"},
        {"Geneva Identification System", "GEN# +6.20055949"},
    },
    visualMagnitude: 12.30,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.42072006),
        dec: Angle.Degrees(+58.82015411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170875"},
        {"Hipparcos Number", "HIP 90612"},
        {"Smithsonian Astrophysical Observation", "SAO 47535"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.34533468),
        dec: Angle.Degrees(+45.98195472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82321",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10227 ABC"},
        {"Henry Draper", "HD 152107"},
        {"Hipparcos Number", "HIP 82321"},
        {"Geneva Identification System", "GEN# +1.00152107"},
        {"Renson", "Renson 43050"},
        {"Smithsonian Astrophysical Observation", "SAO 46305"},
        {"Wilson Evans Batten Catalogue", "WEB 13896"},
    },
    visualMagnitude: 4.82,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.30916380),
        dec: Angle.Degrees(+45.98344780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212692"},
        {"Hipparcos Number", "HIP 110675"},
        {"Smithsonian Astrophysical Observation", "SAO 51977"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.32627771),
        dec: Angle.Degrees(+45.98431149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6891"},
        {"Hipparcos Number", "HIP 5484"},
        {"Smithsonian Astrophysical Observation", "SAO 36981"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.54869150),
        dec: Angle.Degrees(+45.98543796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20467"},
        {"Hipparcos Number", "HIP 15450"},
        {"Smithsonian Astrophysical Observation", "SAO 38716"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.81765781),
        dec: Angle.Degrees(+45.98637892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22246"},
        {"Geneva Identification System", "GEN# +0.04500983"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.82574342),
        dec: Angle.Degrees(+45.98647443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 241.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104407",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104407"},
        {"Smithsonian Astrophysical Observation", "SAO 50500"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.26743840),
        dec: Angle.Degrees(+45.98678844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190427"},
        {"Hipparcos Number", "HIP 98709"},
        {"Celescope Catalog", "CEL 4921"},
        {"Geneva Identification System", "GEN# +1.00190427"},
        {"Smithsonian Astrophysical Observation", "SAO 49124"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.73144804),
        dec: Angle.Degrees(+45.98691863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171285"},
        {"Hipparcos Number", "HIP 90831"},
        {"Smithsonian Astrophysical Observation", "SAO 47569"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.93941614),
        dec: Angle.Degrees(+45.98875694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122674"},
        {"Hipparcos Number", "HIP 68563"},
        {"Geneva Identification System", "GEN# +1.00122674"},
        {"Smithsonian Astrophysical Observation", "SAO 44857"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.54378093),
        dec: Angle.Degrees(+45.98964801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58521"},
        {"Hipparcos Number", "HIP 36288"},
        {"Geneva Identification System", "GEN# +1.00058521"},
        {"Smithsonian Astrophysical Observation", "SAO 41784"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.04840993),
        dec: Angle.Degrees(+45.99063036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62311"},
        {"Smithsonian Astrophysical Observation", "SAO 44322"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.52294169),
        dec: Angle.Degrees(+45.99321335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205496"},
        {"Hipparcos Number", "HIP 106507"},
        {"Celescope Catalog", "CEL 5342"},
        {"Geneva Identification System", "GEN# +1.00205496"},
        {"Smithsonian Astrophysical Observation", "SAO 51041"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.58449214),
        dec: Angle.Degrees(+45.99539831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186857"},
        {"Hipparcos Number", "HIP 97155"},
        {"Smithsonian Astrophysical Observation", "SAO 48795"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.21535068),
        dec: Angle.Degrees(+45.99659356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191420"},
        {"Hipparcos Number", "HIP 99159"},
        {"Geneva Identification System", "GEN# +1.00191420"},
        {"Renson", "Renson 53310"},
        {"Smithsonian Astrophysical Observation", "SAO 49215"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.97160001),
        dec: Angle.Degrees(+45.99852133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24608",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Capella"},
        {"Aitken", "ADS 3841 AP"},
        {"Henry Draper", "HD 34029"},
        {"Hipparcos Number", "HIP 24608"},
        {"Celescope Catalog", "CEL 586"},
        {"Cincinnati Publication", "Ci 20 321"},
        {"Fundamental Katalog 5th Edition", "FK5 193"},
        {"Geneva Identification System", "GEN# +1.00034029"},
        {"Smithsonian Astrophysical Observation", "SAO 40186"},
        {"Wilson Evans Batten Catalogue", "WEB 4762"},
    },
    visualMagnitude: 0.08,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.17206517),
        dec: Angle.Degrees(+45.99902927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -427.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30178"},
        {"Hipparcos Number", "HIP 22261"},
        {"Geneva Identification System", "GEN# +1.00030178"},
        {"Smithsonian Astrophysical Observation", "SAO 39752"},
        {"Wilson Evans Batten Catalogue", "WEB 4284"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.89827457),
        dec: Angle.Degrees(+45.99959082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156402"},
        {"Hipparcos Number", "HIP 84389"},
        {"Smithsonian Astrophysical Observation", "SAO 46586"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.79810450),
        dec: Angle.Degrees(+46.00007768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188712"},
        {"Hipparcos Number", "HIP 97963"},
        {"Smithsonian Astrophysical Observation", "SAO 48964"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.63123052),
        dec: Angle.Degrees(+46.00348644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224276"},
        {"Hipparcos Number", "HIP 118024"},
        {"Smithsonian Astrophysical Observation", "SAO 53497"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.10480785),
        dec: Angle.Degrees(+46.00418583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211854"},
        {"Hipparcos Number", "HIP 110182"},
        {"Smithsonian Astrophysical Observation", "SAO 51870"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.75936930),
        dec: Angle.Degrees(+46.00510343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160762"},
        {"Hipparcos Number", "HIP 86414"},
        {"Fundamental Katalog 5th Edition", "FK5 663"},
        {"Geneva Identification System", "GEN# +1.00160762"},
        {"Smithsonian Astrophysical Observation", "SAO 46872"},
        {"Wilson Evans Batten Catalogue", "WEB 14581"},
    },
    visualMagnitude: 3.82,
    bvColour: -0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.86621847),
        dec: Angle.Degrees(+46.00632216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188666"},
        {"Hipparcos Number", "HIP 97943"},
        {"Geneva Identification System", "GEN# +1.00188666"},
        {"Smithsonian Astrophysical Observation", "SAO 48962"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.57230309),
        dec: Angle.Degrees(+46.00763315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68015"},
        {"Hipparcos Number", "HIP 40195"},
        {"Smithsonian Astrophysical Observation", "SAO 42225"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.15538720),
        dec: Angle.Degrees(+46.00992837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155744"},
        {"Hipparcos Number", "HIP 84075"},
        {"Smithsonian Astrophysical Observation", "SAO 46550"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.83045920),
        dec: Angle.Degrees(+46.01113659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25237"},
        {"Hipparcos Number", "HIP 18845"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.61336520),
        dec: Angle.Degrees(+46.01259753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106767",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106767"},
        {"Smithsonian Astrophysical Observation", "SAO 51111"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.40551205),
        dec: Angle.Degrees(+46.01565038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223230"},
        {"Hipparcos Number", "HIP 117342"},
        {"Smithsonian Astrophysical Observation", "SAO 53375"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.89799533),
        dec: Angle.Degrees(+46.01806820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18231"},
        {"Hipparcos Number", "HIP 13774"},
        {"Smithsonian Astrophysical Observation", "SAO 38466"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.31418237),
        dec: Angle.Degrees(+46.01994835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153881"},
        {"Hipparcos Number", "HIP 83171"},
        {"Smithsonian Astrophysical Observation", "SAO 46425"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.96750200),
        dec: Angle.Degrees(+46.02019597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84737"},
        {"Hipparcos Number", "HIP 48113"},
        {"Fundamental Katalog 5th Edition", "FK5 1255"},
        {"Geneva Identification System", "GEN# +1.00084737"},
        {"Smithsonian Astrophysical Observation", "SAO 43046"},
        {"Wilson Evans Batten Catalogue", "WEB 8991"},
    },
    visualMagnitude: 5.08,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.14660351),
        dec: Angle.Degrees(+46.02123319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 222.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17173",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2669 AB"},
        {"Henry Draper", "HD 22679"},
        {"Hipparcos Number", "HIP 17173"},
        {"Smithsonian Astrophysical Observation", "SAO 39031"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.16923850),
        dec: Angle.Degrees(+46.02336008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154507"},
        {"Hipparcos Number", "HIP 83475"},
        {"Smithsonian Astrophysical Observation", "SAO 46463"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.90376543),
        dec: Angle.Degrees(+46.02398353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116957"},
        {"Hipparcos Number", "HIP 65550"},
        {"Geneva Identification System", "GEN# +1.00116957"},
        {"Smithsonian Astrophysical Observation", "SAO 44611"},
        {"Wilson Evans Batten Catalogue", "WEB 11578"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.56907049),
        dec: Angle.Degrees(+46.02810370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117667"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.95260539),
        dec: Angle.Degrees(+46.02832947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43184"},
        {"Hipparcos Number", "HIP 29857"},
        {"Geneva Identification System", "GEN# +1.00043184"},
        {"Smithsonian Astrophysical Observation", "SAO 40994"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.31157897),
        dec: Angle.Degrees(+46.02843309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110804",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110804"},
        {"Smithsonian Astrophysical Observation", "SAO 52008"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.74274236),
        dec: Angle.Degrees(+46.03022907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49634"},
        {"Smithsonian Astrophysical Observation", "SAO 43204"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.95233716),
        dec: Angle.Degrees(+46.03105971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -248.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15365"},
        {"Hipparcos Number", "HIP 11611"},
        {"Fundamental Katalog 5th Edition", "FK5 2169"},
        {"Geneva Identification System", "GEN# +1.00015365"},
        {"Smithsonian Astrophysical Observation", "SAO 38067"},
        {"Wilson Evans Batten Catalogue", "WEB 2420"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.44208488),
        dec: Angle.Degrees(+46.03200183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113609"},
        {"Renson", "Renson 60010"},
        {"Smithsonian Astrophysical Observation", "SAO 52588"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.15545233),
        dec: Angle.Degrees(+46.03256117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23140"},
        {"Hipparcos Number", "HIP 17491"},
        {"Cincinnati Publication", "Ci 18 497"},
        {"Geneva Identification System", "GEN# +1.00023140"},
        {"Smithsonian Astrophysical Observation", "SAO 39072"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.20246696),
        dec: Angle.Degrees(+46.03608464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 287.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144206"},
        {"Hipparcos Number", "HIP 78592"},
        {"Fundamental Katalog 5th Edition", "FK5 3271"},
        {"Geneva Identification System", "GEN# +1.00144206"},
        {"Renson", "Renson 40850"},
        {"Smithsonian Astrophysical Observation", "SAO 45865"},
        {"Wilson Evans Batten Catalogue", "WEB 13285"},
    },
    visualMagnitude: 4.72,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.69937951),
        dec: Angle.Degrees(+46.03685378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61988",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61988"},
        {"Geneva Identification System", "GEN# +0.04601815"},
        {"Smithsonian Astrophysical Observation", "SAO 44291"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.56198141),
        dec: Angle.Degrees(+46.03704728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82583"},
        {"Hipparcos Number", "HIP 46961"},
        {"Smithsonian Astrophysical Observation", "SAO 42923"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.57620737),
        dec: Angle.Degrees(+46.03876636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184602"},
        {"Hipparcos Number", "HIP 96161"},
        {"Smithsonian Astrophysical Observation", "SAO 48581"},
        {"Wilson Evans Batten Catalogue", "WEB 16848"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.28594962),
        dec: Angle.Degrees(+46.03937353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142532"},
        {"Hipparcos Number", "HIP 77797"},
        {"Fundamental Katalog 5th Edition", "FK5 5405"},
        {"Geneva Identification System", "GEN# +1.00142532"},
        {"Smithsonian Astrophysical Observation", "SAO 45778"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.28537512),
        dec: Angle.Degrees(+46.03999145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102918",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102918"},
        {"Geneva Identification System", "GEN# +0.04503303"},
        {"Renson", "Renson 55340"},
        {"Wilson Evans Batten Catalogue", "WEB 18668"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.75701479),
        dec: Angle.Degrees(+46.04012611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111580",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111580"},
    },
    visualMagnitude: 10.34,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.07484971),
        dec: Angle.Degrees(+46.04161332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2045"},
        {"Hipparcos Number", "HIP 1972"},
        {"Smithsonian Astrophysical Observation", "SAO 36344"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.24075219),
        dec: Angle.Degrees(+46.04218289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111584",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111584"},
    },
    visualMagnitude: 10.52,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.08239145),
        dec: Angle.Degrees(+46.04281722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95777",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95777"},
        {"Wilson Evans Batten Catalogue", "WEB 16764"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.19819296),
        dec: Angle.Degrees(+46.04392984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151543"},
        {"Hipparcos Number", "HIP 82075"},
        {"Smithsonian Astrophysical Observation", "SAO 46271"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.46604667),
        dec: Angle.Degrees(+46.04470786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214280"},
        {"Hipparcos Number", "HIP 111582"},
    },
    visualMagnitude: 10.29,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.07888649),
        dec: Angle.Degrees(+46.04530012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7342"},
        {"Hipparcos Number", "HIP 5792"},
        {"Smithsonian Astrophysical Observation", "SAO 37043"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.58277630),
        dec: Angle.Degrees(+46.05092504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142438"},
        {"Hipparcos Number", "HIP 77762"},
        {"Geneva Identification System", "GEN# +1.00142438"},
        {"Smithsonian Astrophysical Observation", "SAO 45774"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.16998510),
        dec: Angle.Degrees(+46.05148834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128139"},
        {"Hipparcos Number", "HIP 71224"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.47253567),
        dec: Angle.Degrees(+46.05605088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204171"},
        {"Hipparcos Number", "HIP 105771"},
        {"Smithsonian Astrophysical Observation", "SAO 50825"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.33487172),
        dec: Angle.Degrees(+46.05688319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21770"},
        {"Hipparcos Number", "HIP 16499"},
        {"Fundamental Katalog 5th Edition", "FK5 2249"},
        {"Geneva Identification System", "GEN# +1.00021770"},
        {"Smithsonian Astrophysical Observation", "SAO 38924"},
        {"Wilson Evans Batten Catalogue", "WEB 3151"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.10960058),
        dec: Angle.Degrees(+46.05704336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34661",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34661"},
        {"Smithsonian Astrophysical Observation", "SAO 41599"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.67000312),
        dec: Angle.Degrees(+46.06222264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212107"},
        {"Hipparcos Number", "HIP 110339"},
        {"Geneva Identification System", "GEN# +1.00212107"},
        {"Smithsonian Astrophysical Observation", "SAO 51902"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.21440262),
        dec: Angle.Degrees(+46.06236736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56342"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.24987895),
        dec: Angle.Degrees(+46.06443066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158671"},
        {"Hipparcos Number", "HIP 85492"},
        {"Geneva Identification System", "GEN# +1.00158671"},
        {"Smithsonian Astrophysical Observation", "SAO 46738"},
        {"Wilson Evans Batten Catalogue", "WEB 14438"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.06779923),
        dec: Angle.Degrees(+46.06448927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170559"},
        {"Hipparcos Number", "HIP 90488"},
        {"Smithsonian Astrophysical Observation", "SAO 47514"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.96024926),
        dec: Angle.Degrees(+46.06608156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62678",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8681 A"},
        {"Henry Draper", "HD 111689"},
        {"Hipparcos Number", "HIP 62678"},
        {"Geneva Identification System", "GEN# +1.00111689"},
        {"Smithsonian Astrophysical Observation", "SAO 44349"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.65619089),
        dec: Angle.Degrees(+46.06698330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46643",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7401 AB"},
        {"Henry Draper", "HD 81994"},
        {"Hipparcos Number", "HIP 46643"},
        {"Smithsonian Astrophysical Observation", "SAO 42898"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.66316838),
        dec: Angle.Degrees(+46.06788957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218407"},
        {"Hipparcos Number", "HIP 114174"},
        {"Geneva Identification System", "GEN# +1.00218407"},
        {"Smithsonian Astrophysical Observation", "SAO 52707"},
        {"Wilson Evans Batten Catalogue", "WEB 20276"},
    },
    visualMagnitude: 6.66,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.82499966),
        dec: Angle.Degrees(+46.06815326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55550"},
        {"Hipparcos Number", "HIP 35116"},
        {"Smithsonian Astrophysical Observation", "SAO 41641"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.90958084),
        dec: Angle.Degrees(+46.07036528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 571"},
        {"Hipparcos Number", "HIP 841"},
        {"Fundamental Katalog 5th Edition", "FK5 4"},
        {"Geneva Identification System", "GEN# +1.00000571"},
        {"Smithsonian Astrophysical Observation", "SAO 36123"},
        {"Wilson Evans Batten Catalogue", "WEB 140"},
    },
    visualMagnitude: 5.01,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.58017518),
        dec: Angle.Degrees(+46.07227117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88263",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88263"},
        {"Smithsonian Astrophysical Observation", "SAO 47150"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.36998789),
        dec: Angle.Degrees(+46.07240009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202878"},
        {"Hipparcos Number", "HIP 105094"},
        {"Smithsonian Astrophysical Observation", "SAO 50672"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.33583096),
        dec: Angle.Degrees(+46.07370755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16556"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.29868325),
        dec: Angle.Degrees(+46.07387305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104301"},
        {"Hipparcos Number", "HIP 58575"},
        {"Geneva Identification System", "GEN# +1.00104301"},
        {"Smithsonian Astrophysical Observation", "SAO 43995"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.18272582),
        dec: Angle.Degrees(+46.07567958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222132"},
        {"Hipparcos Number", "HIP 116596"},
        {"Smithsonian Astrophysical Observation", "SAO 53207"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.44081469),
        dec: Angle.Degrees(+46.07907310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170357"},
        {"Hipparcos Number", "HIP 90393"},
        {"Cincinnati Publication", "Ci 20 1090"},
        {"Cincinnati Publication 2", "Ci 18 2423"},
        {"Geneva Identification System", "GEN# +1.00170357"},
        {"Smithsonian Astrophysical Observation", "SAO 47499"},
        {"Wilson Evans Batten Catalogue", "WEB 15479"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.65841327),
        dec: Angle.Degrees(+46.08329117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -348.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 199.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178660"},
        {"Hipparcos Number", "HIP 93913"},
        {"Smithsonian Astrophysical Observation", "SAO 48108"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.83903391),
        dec: Angle.Degrees(+46.08529456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69732",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Xuange"},
        {"Henry Draper", "HD 125162"},
        {"Hipparcos Number", "HIP 69732"},
        {"Fundamental Katalog 5th Edition", "FK5 527"},
        {"Geneva Identification System", "GEN# +1.00125162"},
        {"Smithsonian Astrophysical Observation", "SAO 44965"},
        {"Wilson Evans Batten Catalogue", "WEB 12142"},
    },
    visualMagnitude: 4.18,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.09656821),
        dec: Angle.Degrees(+46.08791894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -187.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 159.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35821",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35821"},
        {"Geneva Identification System", "GEN# +6.10010272"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.81248640),
        dec: Angle.Degrees(+46.08799054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -239.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125503"},
        {"Hipparcos Number", "HIP 69919"},
        {"Smithsonian Astrophysical Observation", "SAO 44987"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.63139320),
        dec: Angle.Degrees(+46.08936839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154578"},
        {"Hipparcos Number", "HIP 83517"},
        {"Geneva Identification System", "GEN# +1.00154578"},
        {"Smithsonian Astrophysical Observation", "SAO 46468"},
        {"Wilson Evans Batten Catalogue", "WEB 14118"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.02210431),
        dec: Angle.Degrees(+46.09039448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216002"},
        {"Hipparcos Number", "HIP 112607"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.09931995),
        dec: Angle.Degrees(+46.09159962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108536",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108536"},
        {"Smithsonian Astrophysical Observation", "SAO 51516"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.81322245),
        dec: Angle.Degrees(+46.09166570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171438"},
        {"Hipparcos Number", "HIP 90908"},
        {"Smithsonian Astrophysical Observation", "SAO 47581"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.15777070),
        dec: Angle.Degrees(+46.09252952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 818"},
        {"Hipparcos Number", "HIP 1026"},
        {"Geneva Identification System", "GEN# +1.00000818"},
        {"Smithsonian Astrophysical Observation", "SAO 36160"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.19984759),
        dec: Angle.Degrees(+46.09543717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54344",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54344"},
    },
    visualMagnitude: 11.12,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.76151021),
        dec: Angle.Degrees(+46.09602369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81105"},
        {"Hipparcos Number", "HIP 46199"},
        {"Smithsonian Astrophysical Observation", "SAO 42846"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.29577611),
        dec: Angle.Degrees(+46.09815609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -230.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55254"},
        {"Hipparcos Number", "HIP 35000"},
        {"Smithsonian Astrophysical Observation", "SAO 41633"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.61884631),
        dec: Angle.Degrees(+46.09855845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23139"},
        {"Hipparcos Number", "HIP 17475"},
        {"Fundamental Katalog 5th Edition", "FK5 2266"},
        {"Geneva Identification System", "GEN# +1.00023139"},
        {"Smithsonian Astrophysical Observation", "SAO 39071"},
        {"Wilson Evans Batten Catalogue", "WEB 3312"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.17046065),
        dec: Angle.Degrees(+46.09987096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35989",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35989"},
        {"Cincinnati Publication", "Ci 20 423"},
        {"Cincinnati Publication 2", "Ci 18 884"},
        {"Geneva Identification System", "GEN# +0.04601264"},
        {"Smithsonian Astrophysical Observation", "SAO 41750"},
        {"Wilson Evans Batten Catalogue", "WEB 7167"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.24800482),
        dec: Angle.Degrees(+46.10036780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -289.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -310.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63221"},
        {"Hipparcos Number", "HIP 38223"},
        {"Smithsonian Astrophysical Observation", "SAO 42023"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.46091441),
        dec: Angle.Degrees(+46.10060629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43545"},
        {"Smithsonian Astrophysical Observation", "SAO 42579"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.03223686),
        dec: Angle.Degrees(+46.10604393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68658"},
        {"Hipparcos Number", "HIP 40434"},
        {"Geneva Identification System", "GEN# +1.00068658"},
        {"Smithsonian Astrophysical Observation", "SAO 42246"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.84790626),
        dec: Angle.Degrees(+46.10863496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48711"},
        {"Hipparcos Number", "HIP 32510"},
        {"Smithsonian Astrophysical Observation", "SAO 41339"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.76391597),
        dec: Angle.Degrees(+46.10956751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214819"},
        {"Hipparcos Number", "HIP 111904"},
        {"Renson", "Renson 59423"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.01587434),
        dec: Angle.Degrees(+46.11150961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103055",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14396 AB"},
        {"Hipparcos Number", "HIP 103055"},
        {"Smithsonian Astrophysical Observation", "SAO 50171"},
        {"Wilson Evans Batten Catalogue", "WEB 18708"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.18723559),
        dec: Angle.Degrees(+46.11325121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173665"},
        {"Hipparcos Number", "HIP 91905"},
        {"Smithsonian Astrophysical Observation", "SAO 47747"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.04046335),
        dec: Angle.Degrees(+46.11387240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 161.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102724",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14337 A"},
        {"Henry Draper", "HD 198478"},
        {"Hipparcos Number", "HIP 102724"},
        {"Celescope Catalog", "CEL 5176"},
        {"Geneva Identification System", "GEN# +1.00198478A"},
        {"Smithsonian Astrophysical Observation", "SAO 50099"},
        {"Wilson Evans Batten Catalogue", "WEB 18624"},
    },
    visualMagnitude: 4.81,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.23455583),
        dec: Angle.Degrees(+46.11414081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87620"},
        {"Hipparcos Number", "HIP 49576"},
        {"Geneva Identification System", "GEN# +1.00087620"},
        {"Smithsonian Astrophysical Observation", "SAO 43200"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.80703809),
        dec: Angle.Degrees(+46.11502922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213812"},
        {"Hipparcos Number", "HIP 111328"},
        {"Smithsonian Astrophysical Observation", "SAO 52136"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.33095529),
        dec: Angle.Degrees(+46.11536074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126199"},
        {"Hipparcos Number", "HIP 70284"},
        {"Smithsonian Astrophysical Observation", "SAO 45023"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.70282939),
        dec: Angle.Degrees(+46.11616507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72487",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Merga"},
        {"Henry Draper", "HD 130945"},
        {"Hipparcos Number", "HIP 72487"},
        {"Geneva Identification System", "GEN# +1.00130945"},
        {"Smithsonian Astrophysical Observation", "SAO 45226"},
        {"Wilson Evans Batten Catalogue", "WEB 12459"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.32781437),
        dec: Angle.Degrees(+46.11639336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19756"},
        {"Hipparcos Number", "HIP 14923"},
        {"Geneva Identification System", "GEN# +1.00019756"},
        {"Smithsonian Astrophysical Observation", "SAO 38641"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.12743836),
        dec: Angle.Degrees(+46.11674736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34001",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34001"},
        {"Fundamental Katalog 5th Edition", "FK5 4635"},
        {"Smithsonian Astrophysical Observation", "SAO 41518"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.81883854),
        dec: Angle.Degrees(+46.12023308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116531"},
        {"Hipparcos Number", "HIP 65326"},
        {"Smithsonian Astrophysical Observation", "SAO 44591"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.83557816),
        dec: Angle.Degrees(+46.12266468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219273"},
        {"Hipparcos Number", "HIP 114706"},
        {"Geneva Identification System", "GEN# +1.00219273"},
        {"Smithsonian Astrophysical Observation", "SAO 52819"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.53212329),
        dec: Angle.Degrees(+46.12333052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221588"},
        {"Hipparcos Number", "HIP 116228"},
        {"Smithsonian Astrophysical Observation", "SAO 53137"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.23516947),
        dec: Angle.Degrees(+46.12368402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11659"},
        {"Hipparcos Number", "HIP 8966"},
        {"Renson", "Renson 2980"},
        {"Smithsonian Astrophysical Observation", "SAO 37612"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.86967395),
        dec: Angle.Degrees(+46.12384519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19684"},
        {"Hipparcos Number", "HIP 14871"},
        {"Geneva Identification System", "GEN# +1.00019684"},
        {"Smithsonian Astrophysical Observation", "SAO 38631"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.99509574),
        dec: Angle.Degrees(+46.12866223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114153"},
        {"Smithsonian Astrophysical Observation", "SAO 52697"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.77314498),
        dec: Angle.Degrees(+46.12960727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102570"},
        {"Hipparcos Number", "HIP 57601"},
        {"Geneva Identification System", "GEN# +1.00102570"},
        {"Smithsonian Astrophysical Observation", "SAO 43900"},
        {"Wilson Evans Batten Catalogue", "WEB 10342"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.14505777),
        dec: Angle.Degrees(+46.13010773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204813"},
        {"Hipparcos Number", "HIP 106113"},
        {"Geneva Identification System", "GEN# +1.00204813"},
        {"Smithsonian Astrophysical Observation", "SAO 50936"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.41337156),
        dec: Angle.Degrees(+46.13215502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123875"},
        {"Hipparcos Number", "HIP 69117"},
        {"Smithsonian Astrophysical Observation", "SAO 44908"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.22742976),
        dec: Angle.Degrees(+46.13425535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173814"},
        {"Hipparcos Number", "HIP 91996"},
        {"Smithsonian Astrophysical Observation", "SAO 47767"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.26526122),
        dec: Angle.Degrees(+46.13542938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101729",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101729"},
        {"Geneva Identification System", "GEN# +0.04503230"},
        {"Smithsonian Astrophysical Observation", "SAO 49865"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.30512383),
        dec: Angle.Degrees(+46.13883453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10597"},
        {"Hipparcos Number", "HIP 8127"},
        {"Smithsonian Astrophysical Observation", "SAO 37475"},
        {"Wilson Evans Batten Catalogue", "WEB 1736"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.11055417),
        dec: Angle.Degrees(+46.13976854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14663"},
        {"Hipparcos Number", "HIP 11133"},
        {"Smithsonian Astrophysical Observation", "SAO 37991"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.81852225),
        dec: Angle.Degrees(+46.13991311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100918"},
        {"Hipparcos Number", "HIP 56674"},
        {"Geneva Identification System", "GEN# +1.00100918"},
        {"Smithsonian Astrophysical Observation", "SAO 43829"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.31453846),
        dec: Angle.Degrees(+46.14217060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61528",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61528"},
        {"Geneva Identification System", "GEN# +0.04601799"},
        {"Smithsonian Astrophysical Observation", "SAO 44246"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.08781452),
        dec: Angle.Degrees(+46.14264455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27795"},
        {"Hipparcos Number", "HIP 20647"},
        {"Celescope Catalog", "CEL 394"},
        {"Geneva Identification System", "GEN# +1.00027795"},
        {"Smithsonian Astrophysical Observation", "SAO 39520"},
        {"Wilson Evans Batten Catalogue", "WEB 3958"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.37139802),
        dec: Angle.Degrees(+46.14371303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184008"},
        {"Hipparcos Number", "HIP 95902"},
        {"Smithsonian Astrophysical Observation", "SAO 48521"},
        {"Wilson Evans Batten Catalogue", "WEB 16792"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.55339658),
        dec: Angle.Degrees(+46.14781228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86679"},
        {"Hipparcos Number", "HIP 49102"},
        {"Smithsonian Astrophysical Observation", "SAO 43141"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.32008497),
        dec: Angle.Degrees(+46.14817374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172379"},
        {"Hipparcos Number", "HIP 91318"},
        {"Geneva Identification System", "GEN# +1.00172379"},
        {"Smithsonian Astrophysical Observation", "SAO 47661"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.39529652),
        dec: Angle.Degrees(+46.14987025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157481"},
        {"Hipparcos Number", "HIP 84916"},
        {"Smithsonian Astrophysical Observation", "SAO 46660"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.30482259),
        dec: Angle.Degrees(+46.15031622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28353"},
        {"Hipparcos Number", "HIP 21023"},
        {"Geneva Identification System", "GEN# +1.00028353"},
        {"Renson", "Renson 7260"},
        {"Smithsonian Astrophysical Observation", "SAO 39567"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.62197987),
        dec: Angle.Degrees(+46.15047075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36803",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6167 AB"},
        {"Henry Draper", "HD 59876"},
        {"Hipparcos Number", "HIP 36803"},
        {"Smithsonian Astrophysical Observation", "SAO 41853"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.53849224),
        dec: Angle.Degrees(+46.15088160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39677"},
        {"Smithsonian Astrophysical Observation", "SAO 42172"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.63159289),
        dec: Angle.Degrees(+46.15138038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89617"},
        {"Hipparcos Number", "HIP 50733"},
        {"Smithsonian Astrophysical Observation", "SAO 43302"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.39222149),
        dec: Angle.Degrees(+46.15213494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116039",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116039"},
        {"Smithsonian Astrophysical Observation", "SAO 53102"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.68122355),
        dec: Angle.Degrees(+46.15304171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79889"},
        {"Hipparcos Number", "HIP 45649"},
        {"Fundamental Katalog 5th Edition", "FK5 4827"},
        {"Geneva Identification System", "GEN# +1.00079889"},
        {"Smithsonian Astrophysical Observation", "SAO 42793"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.57155592),
        dec: Angle.Degrees(+46.15313960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131580"},
        {"Hipparcos Number", "HIP 72809"},
        {"Smithsonian Astrophysical Observation", "SAO 45255"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.22435709),
        dec: Angle.Degrees(+46.15440560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86395",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86395"},
        {"Smithsonian Astrophysical Observation", "SAO 46867"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.80559526),
        dec: Angle.Degrees(+46.15496042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94306"},
        {"Hipparcos Number", "HIP 53283"},
        {"Geneva Identification System", "GEN# +1.00094306"},
        {"Smithsonian Astrophysical Observation", "SAO 43509"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.46019585),
        dec: Angle.Degrees(+46.15572724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103732",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14549 A"},
        {"Henry Draper", "HD 200310"},
        {"Hipparcos Number", "HIP 103732"},
        {"Celescope Catalog", "CEL 5232"},
        {"Geneva Identification System", "GEN# +1.00200310"},
        {"Smithsonian Astrophysical Observation", "SAO 50359"},
        {"Wilson Evans Batten Catalogue", "WEB 18880"},
    },
    visualMagnitude: 5.38,
    bvColour: -0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.29551032),
        dec: Angle.Degrees(+46.15576488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115138",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115138"},
        {"Smithsonian Astrophysical Observation", "SAO 52904"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.83833004),
        dec: Angle.Degrees(+46.15776135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42246"},
        {"Smithsonian Astrophysical Observation", "SAO 42448"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.19865356),
        dec: Angle.Degrees(+46.15847097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201701"},
        {"Hipparcos Number", "HIP 104468"},
        {"Geneva Identification System", "GEN# +1.00201701"},
        {"Smithsonian Astrophysical Observation", "SAO 50514"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.42939847),
        dec: Angle.Degrees(+46.15864682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53533",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53533"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.28600893),
        dec: Angle.Degrees(+46.15922011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51841"},
        {"Smithsonian Astrophysical Observation", "SAO 43395"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.87329200),
        dec: Angle.Degrees(+46.16439228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133563"},
        {"Hipparcos Number", "HIP 73668"},
        {"Smithsonian Astrophysical Observation", "SAO 45353"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.88609803),
        dec: Angle.Degrees(+46.16479987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25970"},
        {"Hipparcos Number", "HIP 19357"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.20019155),
        dec: Angle.Degrees(+46.16593365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4734",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4734"},
        {"Smithsonian Astrophysical Observation", "SAO 36842"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.20083032),
        dec: Angle.Degrees(+46.16702703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22742"},
        {"Hipparcos Number", "HIP 17229"},
        {"Smithsonian Astrophysical Observation", "SAO 39042"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.34941461),
        dec: Angle.Degrees(+46.16801681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90291"},
        {"Hipparcos Number", "HIP 51096"},
        {"Smithsonian Astrophysical Observation", "SAO 43335"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.59028128),
        dec: Angle.Degrees(+46.17013202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77820"},
        {"Hipparcos Number", "HIP 44691"},
        {"Smithsonian Astrophysical Observation", "SAO 42693"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.60966057),
        dec: Angle.Degrees(+46.17101117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74360"},
        {"Hipparcos Number", "HIP 42959"},
        {"Fundamental Katalog 5th Edition", "FK5 4785"},
        {"Geneva Identification System", "GEN# +1.00074360"},
        {"Smithsonian Astrophysical Observation", "SAO 42529"},
        {"Wilson Evans Batten Catalogue", "WEB 8304"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.34969091),
        dec: Angle.Degrees(+46.17124905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214945"},
        {"Hipparcos Number", "HIP 111991"},
        {"Smithsonian Astrophysical Observation", "SAO 52260"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.26655501),
        dec: Angle.Degrees(+46.17355951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206212"},
        {"Hipparcos Number", "HIP 106921"},
        {"Smithsonian Astrophysical Observation", "SAO 51150"},
        {"Wilson Evans Batten Catalogue", "WEB 19322"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.81210602),
        dec: Angle.Degrees(+46.17542524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112570"},
        {"Hipparcos Number", "HIP 63211"},
        {"Geneva Identification System", "GEN# +1.00112570"},
        {"Smithsonian Astrophysical Observation", "SAO 44398"},
        {"Wilson Evans Batten Catalogue", "WEB 11205"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.28251288),
        dec: Angle.Degrees(+46.17692019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90566"},
        {"Hipparcos Number", "HIP 51261"},
        {"Geneva Identification System", "GEN# +1.00090566"},
        {"Smithsonian Astrophysical Observation", "SAO 43353"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.06531343),
        dec: Angle.Degrees(+46.17766621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60437"},
        {"Hipparcos Number", "HIP 37023"},
        {"Fundamental Katalog 5th Edition", "FK5 1195"},
        {"Geneva Identification System", "GEN# +1.00060437"},
        {"Smithsonian Astrophysical Observation", "SAO 41879"},
        {"Wilson Evans Batten Catalogue", "WEB 7342"},
    },
    visualMagnitude: 5.66,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.13190951),
        dec: Angle.Degrees(+46.18036783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79576"},
        {"Hipparcos Number", "HIP 45515"},
        {"Smithsonian Astrophysical Observation", "SAO 42782"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.14290483),
        dec: Angle.Degrees(+46.18072463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25403",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25403"},
    },
    visualMagnitude: 9.92,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.51232844),
        dec: Angle.Degrees(+46.18143965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7011"},
        {"Hipparcos Number", "HIP 5551"},
        {"Fundamental Katalog 5th Edition", "FK5 4107"},
        {"Geneva Identification System", "GEN# +1.00007011"},
        {"Smithsonian Astrophysical Observation", "SAO 36999"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.79409811),
        dec: Angle.Degrees(+46.18391354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32774",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5480 A"},
        {"Henry Draper", "HD 49288"},
        {"Hipparcos Number", "HIP 32774"},
        {"Fundamental Katalog 5th Edition", "FK5 4623"},
        {"Geneva Identification System", "GEN# +1.00049288"},
        {"Smithsonian Astrophysical Observation", "SAO 41371"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.50410565),
        dec: Angle.Degrees(+46.18479602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66625",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66625"},
        {"Smithsonian Astrophysical Observation", "SAO 44697"},
        {"Wilson Evans Batten Catalogue", "WEB 11753"},
    },
    visualMagnitude: 10.24,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.85057431),
        dec: Angle.Degrees(+46.18554364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 390.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36438"},
        {"Hipparcos Number", "HIP 26105"},
        {"Smithsonian Astrophysical Observation", "SAO 40432"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.51408108),
        dec: Angle.Degrees(+46.18692183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198212"},
        {"Hipparcos Number", "HIP 102562"},
        {"Geneva Identification System", "GEN# +1.00198212"},
        {"Smithsonian Astrophysical Observation", "SAO 50056"},
        {"Wilson Evans Batten Catalogue", "WEB 18583"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.76541228),
        dec: Angle.Degrees(+46.18749350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
