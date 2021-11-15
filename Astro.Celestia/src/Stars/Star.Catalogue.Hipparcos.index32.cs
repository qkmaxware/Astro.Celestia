using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_32() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8629"},
        {"Hipparcos Number", "HIP 6591"},
        {"Geneva Identification System", "GEN# +1.00008629"},
        {"Smithsonian Astrophysical Observation", "SAO 193101"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.16775112),
        dec: Angle.Degrees(-34.14005696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103714"},
        {"Smithsonian Astrophysical Observation", "SAO 212629"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.24375555),
        dec: Angle.Degrees(-34.13752331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7898"},
        {"Hipparcos Number", "HIP 6082"},
        {"Geneva Identification System", "GEN# +1.00007898"},
        {"Renson", "Renson 1960"},
        {"Smithsonian Astrophysical Observation", "SAO 193037"},
        {"Wilson Evans Batten Catalogue", "WEB 1370"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.51265859),
        dec: Angle.Degrees(-34.13749003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208101"},
        {"Hipparcos Number", "HIP 108149"},
        {"Geneva Identification System", "GEN# +1.00208101"},
        {"Smithsonian Astrophysical Observation", "SAO 213384"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.67475183),
        dec: Angle.Degrees(-34.13672041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179501"},
        {"Hipparcos Number", "HIP 94533"},
        {"Smithsonian Astrophysical Observation", "SAO 211073"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.59296104),
        dec: Angle.Degrees(-34.13615555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164296"},
        {"Hipparcos Number", "HIP 88299"},
        {"Geneva Identification System", "GEN# +1.00164296"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.48024527),
        dec: Angle.Degrees(-34.13614603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 321256"},
        {"Hipparcos Number", "HIP 88800"},
        {"Smithsonian Astrophysical Observation", "SAO 209740"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.90847234),
        dec: Angle.Degrees(-34.13312824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130450"},
        {"Hipparcos Number", "HIP 72484"},
        {"Smithsonian Astrophysical Observation", "SAO 205977"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.32132457),
        dec: Angle.Degrees(-34.13275039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185367"},
        {"Hipparcos Number", "HIP 96758"},
        {"Geneva Identification System", "GEN# +1.00185367"},
        {"Smithsonian Astrophysical Observation", "SAO 211458"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.02459361),
        dec: Angle.Degrees(-34.12963307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219070"},
        {"Hipparcos Number", "HIP 114635"},
        {"Smithsonian Astrophysical Observation", "SAO 214390"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.33495171),
        dec: Angle.Degrees(-34.12945935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122185"},
        {"Hipparcos Number", "HIP 68456"},
        {"Smithsonian Astrophysical Observation", "SAO 205090"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.21889324),
        dec: Angle.Degrees(-34.12793870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89213"},
        {"Hipparcos Number", "HIP 50349"},
        {"Smithsonian Astrophysical Observation", "SAO 201237"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.21563740),
        dec: Angle.Degrees(-34.12734777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106198"},
        {"Hipparcos Number", "HIP 59588"},
        {"Geneva Identification System", "GEN# +1.00106198"},
        {"Smithsonian Astrophysical Observation", "SAO 203245"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.30403548),
        dec: Angle.Degrees(-34.12528736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66059"},
        {"Hipparcos Number", "HIP 39149"},
        {"Celescope Catalog", "CEL 2132"},
        {"Geneva Identification System", "GEN# +1.00066059"},
        {"Smithsonian Astrophysical Observation", "SAO 198689"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.11708035),
        dec: Angle.Degrees(-34.12391202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154090"},
        {"Hipparcos Number", "HIP 83574"},
        {"Geneva Identification System", "GEN# +1.00154090"},
        {"Smithsonian Astrophysical Observation", "SAO 208377"},
        {"Wilson Evans Batten Catalogue", "WEB 14127"},
    },
    visualMagnitude: 4.83,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.20562945),
        dec: Angle.Degrees(-34.12292247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189467"},
        {"Hipparcos Number", "HIP 98585"},
        {"Smithsonian Astrophysical Observation", "SAO 211741"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.37793918),
        dec: Angle.Degrees(-34.12262921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78543"},
        {"Hipparcos Number", "HIP 44797"},
        {"Geneva Identification System", "GEN# +1.00078543"},
        {"Smithsonian Astrophysical Observation", "SAO 200005"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.93648900),
        dec: Angle.Degrees(-34.12248900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141815"},
        {"Hipparcos Number", "HIP 77731"},
        {"Geneva Identification System", "GEN# +1.00141815"},
        {"Smithsonian Astrophysical Observation", "SAO 207065"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.05831405),
        dec: Angle.Degrees(-34.12158804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148536"},
        {"Hipparcos Number", "HIP 80813"},
        {"Geneva Identification System", "GEN# +1.00148536"},
        {"Smithsonian Astrophysical Observation", "SAO 207717"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.53681511),
        dec: Angle.Degrees(-34.12147585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27470"},
        {"Hipparcos Number", "HIP 20116"},
        {"Smithsonian Astrophysical Observation", "SAO 194919"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.69846990),
        dec: Angle.Degrees(-34.12129199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85787"},
        {"Hipparcos Number", "HIP 48495"},
        {"Smithsonian Astrophysical Observation", "SAO 200837"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.34886980),
        dec: Angle.Degrees(-34.11967924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26340"},
        {"Hipparcos Number", "HIP 19339"},
        {"Smithsonian Astrophysical Observation", "SAO 194795"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.15668902),
        dec: Angle.Degrees(-34.11934705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114065"},
        {"Hipparcos Number", "HIP 64112"},
        {"Smithsonian Astrophysical Observation", "SAO 204157"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.09738164),
        dec: Angle.Degrees(-34.11877065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191957"},
        {"Hipparcos Number", "HIP 99681"},
        {"Smithsonian Astrophysical Observation", "SAO 211916"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.42329902),
        dec: Angle.Degrees(-34.11844121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162496"},
        {"Hipparcos Number", "HIP 87516"},
        {"Geneva Identification System", "GEN# +1.00162496"},
        {"Smithsonian Astrophysical Observation", "SAO 209397"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.20509107),
        dec: Angle.Degrees(-34.11482109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26592"},
        {"Hipparcos Number", "HIP 19531"},
        {"Geneva Identification System", "GEN# +1.00026592"},
        {"Smithsonian Astrophysical Observation", "SAO 194813"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.76821160),
        dec: Angle.Degrees(-34.11309071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182582"},
        {"Hipparcos Number", "HIP 95613"},
        {"Smithsonian Astrophysical Observation", "SAO 211268"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.70488326),
        dec: Angle.Degrees(-34.11306169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52092"},
        {"Hipparcos Number", "HIP 33558"},
        {"Celescope Catalog", "CEL 1470"},
        {"Fundamental Katalog 5th Edition", "FK5 2541"},
        {"Geneva Identification System", "GEN# +1.00052092"},
        {"Smithsonian Astrophysical Observation", "SAO 197427"},
        {"Wilson Evans Batten Catalogue", "WEB 6749"},
    },
    visualMagnitude: 5.07,
    bvColour: -0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.60460729),
        dec: Angle.Degrees(-34.11172588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19840"},
        {"Hipparcos Number", "HIP 14733"},
        {"Smithsonian Astrophysical Observation", "SAO 194129"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.57160946),
        dec: Angle.Degrees(-34.11168542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194898"},
        {"Hipparcos Number", "HIP 101072"},
        {"Smithsonian Astrophysical Observation", "SAO 212171"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.34010250),
        dec: Angle.Degrees(-34.11129688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 512"},
        {"Hipparcos Number", "HIP 772"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.37791300),
        dec: Angle.Degrees(-34.11077214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29585"},
        {"Hipparcos Number", "HIP 21592"},
        {"Geneva Identification System", "GEN# +1.00029585"},
        {"Smithsonian Astrophysical Observation", "SAO 195183"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.54081801),
        dec: Angle.Degrees(-34.11028646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167647"},
        {"Hipparcos Number", "HIP 89637"},
        {"Geneva Identification System", "GEN# +1.00167647A"},
        {"Smithsonian Astrophysical Observation", "SAO 209959"},
        {"Wilson Evans Batten Catalogue", "WEB 15269"},
    },
    visualMagnitude: 6.03,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.40103799),
        dec: Angle.Degrees(-34.10723517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199241"},
        {"Hipparcos Number", "HIP 103407"},
        {"Smithsonian Astrophysical Observation", "SAO 212569"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.26016549),
        dec: Angle.Degrees(-34.10412039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80590"},
        {"Hipparcos Number", "HIP 45754"},
        {"Fundamental Katalog 5th Edition", "FK5 2742"},
        {"Geneva Identification System", "GEN# +1.00080590"},
        {"Smithsonian Astrophysical Observation", "SAO 200241"},
    },
    visualMagnitude: 6.40,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.94976336),
        dec: Angle.Degrees(-34.10331577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2584"},
        {"Hipparcos Number", "HIP 2294"},
        {"Geneva Identification System", "GEN# +1.00002584"},
        {"Smithsonian Astrophysical Observation", "SAO 192560"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.32236242),
        dec: Angle.Degrees(-34.10216025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152683"},
        {"Hipparcos Number", "HIP 82881"},
        {"Smithsonian Astrophysical Observation", "SAO 208212"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.07226757),
        dec: Angle.Degrees(-34.10064447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223775"},
        {"Hipparcos Number", "HIP 117723"},
        {"Smithsonian Astrophysical Observation", "SAO 214836"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.13490958),
        dec: Angle.Degrees(-34.10033558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214866"},
        {"Hipparcos Number", "HIP 112046"},
        {"Smithsonian Astrophysical Observation", "SAO 214015"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.41914267),
        dec: Angle.Degrees(-34.09938804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217870"},
        {"Hipparcos Number", "HIP 113914"},
        {"Smithsonian Astrophysical Observation", "SAO 214283"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.02543567),
        dec: Angle.Degrees(-34.09760763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156200"},
        {"Hipparcos Number", "HIP 84613"},
        {"Smithsonian Astrophysical Observation", "SAO 208644"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.44094695),
        dec: Angle.Degrees(-34.09661362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80431"},
        {"Hipparcos Number", "HIP 45679"},
        {"Smithsonian Astrophysical Observation", "SAO 200222"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.68182100),
        dec: Angle.Degrees(-34.09591770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161854"},
        {"Hipparcos Number", "HIP 87230"},
        {"Geneva Identification System", "GEN# +1.00161854"},
        {"Smithsonian Astrophysical Observation", "SAO 209308"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.34959962),
        dec: Angle.Degrees(-34.09460358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46025"},
        {"Hipparcos Number", "HIP 30929"},
        {"Smithsonian Astrophysical Observation", "SAO 196874"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.36572662),
        dec: Angle.Degrees(-34.09416390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157751"},
        {"Hipparcos Number", "HIP 85372"},
        {"Geneva Identification System", "GEN# +1.00157751"},
        {"Renson", "Renson 44320"},
        {"Smithsonian Astrophysical Observation", "SAO 208821"},
    },
    visualMagnitude: 7.63,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.67161471),
        dec: Angle.Degrees(-34.09232987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17060"},
        {"Hipparcos Number", "HIP 12714"},
        {"Smithsonian Astrophysical Observation", "SAO 193877"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.85061982),
        dec: Angle.Degrees(-34.09138241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59864"},
        {"Hipparcos Number", "HIP 36500"},
        {"Celescope Catalog", "CEL 1901"},
        {"Geneva Identification System", "GEN# +1.00059864"},
        {"Smithsonian Astrophysical Observation", "SAO 198063"},
        {"Wilson Evans Batten Catalogue", "WEB 7261"},
    },
    visualMagnitude: 7.62,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.64198628),
        dec: Angle.Degrees(-34.09060775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117437"},
        {"Hipparcos Number", "HIP 65922"},
        {"Smithsonian Astrophysical Observation", "SAO 204542"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.71799386),
        dec: Angle.Degrees(-34.08933646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4955"},
        {"Hipparcos Number", "HIP 3986"},
        {"Smithsonian Astrophysical Observation", "SAO 192777"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.81192088),
        dec: Angle.Degrees(-34.08383377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77164"},
        {"Hipparcos Number", "HIP 44170"},
        {"Smithsonian Astrophysical Observation", "SAO 199865"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.94574154),
        dec: Angle.Degrees(-34.08355160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14910"},
        {"Hipparcos Number", "HIP 11141"},
        {"Geneva Identification System", "GEN# +1.00014910"},
        {"Smithsonian Astrophysical Observation", "SAO 193683"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.84542698),
        dec: Angle.Degrees(-34.08274951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38242"},
        {"Hipparcos Number", "HIP 26917"},
        {"Smithsonian Astrophysical Observation", "SAO 196106"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.70766334),
        dec: Angle.Degrees(-34.08193580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160841"},
        {"Hipparcos Number", "HIP 86752"},
        {"Smithsonian Astrophysical Observation", "SAO 209186"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.90037659),
        dec: Angle.Degrees(-34.08139067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202541"},
        {"Hipparcos Number", "HIP 105118"},
        {"Smithsonian Astrophysical Observation", "SAO 212870"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.40321422),
        dec: Angle.Degrees(-34.07816016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26634",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Phact"},
        {"Henry Draper", "HD 37795"},
        {"Hipparcos Number", "HIP 26634"},
        {"Fundamental Katalog 5th Edition", "FK5 215"},
        {"Geneva Identification System", "GEN# +1.00037795"},
        {"Smithsonian Astrophysical Observation", "SAO 196059"},
        {"Wilson Evans Batten Catalogue", "WEB 5251"},
    },
    visualMagnitude: 2.65,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.91224975),
        dec: Angle.Degrees(-34.07404941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38873",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38873"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.32702001),
        dec: Angle.Degrees(-34.07359513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160461"},
        {"Hipparcos Number", "HIP 86572"},
        {"Geneva Identification System", "GEN# +1.00160461"},
        {"Smithsonian Astrophysical Observation", "SAO 209144"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.37788309),
        dec: Angle.Degrees(-34.07348726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165875"},
        {"Hipparcos Number", "HIP 88971"},
        {"Smithsonian Astrophysical Observation", "SAO 209786"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.40701772),
        dec: Angle.Degrees(-34.07266293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74511"},
        {"Hipparcos Number", "HIP 42802"},
        {"Smithsonian Astrophysical Observation", "SAO 199540"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.80884203),
        dec: Angle.Degrees(-34.07209131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142887"},
        {"Hipparcos Number", "HIP 78213"},
        {"Geneva Identification System", "GEN# +1.00142887"},
        {"Smithsonian Astrophysical Observation", "SAO 207174"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.56593703),
        dec: Angle.Degrees(-34.07148011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166450"},
        {"Hipparcos Number", "HIP 89189"},
        {"Smithsonian Astrophysical Observation", "SAO 209841"},
    },
    visualMagnitude: 7.24,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.02617922),
        dec: Angle.Degrees(-34.06868671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75111"},
        {"Hipparcos Number", "HIP 43118"},
        {"Smithsonian Astrophysical Observation", "SAO 199608"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.71476252),
        dec: Angle.Degrees(-34.06711989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98905"},
        {"Hipparcos Number", "HIP 55548"},
        {"Smithsonian Astrophysical Observation", "SAO 202377"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.67270938),
        dec: Angle.Degrees(-34.06636147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136942"},
        {"Hipparcos Number", "HIP 75421"},
        {"Smithsonian Astrophysical Observation", "SAO 206595"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.13821745),
        dec: Angle.Degrees(-34.06520900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72086"},
        {"Hipparcos Number", "HIP 41666"},
        {"Smithsonian Astrophysical Observation", "SAO 199293"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.42813899),
        dec: Angle.Degrees(-34.06487132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111217"},
        {"Hipparcos Number", "HIP 62450"},
        {"Geneva Identification System", "GEN# +1.00111217"},
        {"Smithsonian Astrophysical Observation", "SAO 203818"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.97923932),
        dec: Angle.Degrees(-34.06078386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182435"},
        {"Hipparcos Number", "HIP 95553"},
        {"Smithsonian Astrophysical Observation", "SAO 211258"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.52913773),
        dec: Angle.Degrees(-34.06060696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142187"},
        {"Hipparcos Number", "HIP 77884"},
        {"Smithsonian Astrophysical Observation", "SAO 207100"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.58846943),
        dec: Angle.Degrees(-34.06023354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54772"},
        {"Hipparcos Number", "HIP 34477"},
        {"Renson", "Renson 14960"},
        {"Smithsonian Astrophysical Observation", "SAO 197626"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.18498082),
        dec: Angle.Degrees(-34.06012609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93905"},
        {"Hipparcos Number", "HIP 52965"},
        {"Celescope Catalog", "CEL 3730"},
        {"Geneva Identification System", "GEN# +1.00093905"},
        {"Smithsonian Astrophysical Observation", "SAO 201805"},
    },
    visualMagnitude: 5.61,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.48769199),
        dec: Angle.Degrees(-34.05819988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23455"},
        {"Hipparcos Number", "HIP 17429"},
        {"Smithsonian Astrophysical Observation", "SAO 194490"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.01133617),
        dec: Angle.Degrees(-34.05805184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28770",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28770"},
        {"Smithsonian Astrophysical Observation", "SAO 196464"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.12792052),
        dec: Angle.Degrees(-34.05769503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60452"},
        {"Hipparcos Number", "HIP 36713"},
        {"Smithsonian Astrophysical Observation", "SAO 198119"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.27119988),
        dec: Angle.Degrees(-34.05626537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43718"},
        {"Hipparcos Number", "HIP 29778"},
        {"Smithsonian Astrophysical Observation", "SAO 196638"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.05404885),
        dec: Angle.Degrees(-34.05456078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164774"},
        {"Hipparcos Number", "HIP 88492"},
        {"Geneva Identification System", "GEN# +1.00164774"},
        {"Smithsonian Astrophysical Observation", "SAO 209659"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.03825353),
        dec: Angle.Degrees(-34.05311132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15157"},
        {"Hipparcos Number", "HIP 11300"},
        {"Fundamental Katalog 5th Edition", "FK5 4226"},
        {"Geneva Identification System", "GEN# +1.00015157"},
        {"Smithsonian Astrophysical Observation", "SAO 193701"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.36679107),
        dec: Angle.Degrees(-34.05205276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104417"},
        {"Hipparcos Number", "HIP 58632"},
        {"Smithsonian Astrophysical Observation", "SAO 203037"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.35361732),
        dec: Angle.Degrees(-34.05030944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196699"},
        {"Hipparcos Number", "HIP 101992"},
        {"Smithsonian Astrophysical Observation", "SAO 212328"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.04140151),
        dec: Angle.Degrees(-34.04987463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210066"},
        {"Hipparcos Number", "HIP 109289"},
        {"Geneva Identification System", "GEN# +1.00210066"},
        {"Smithsonian Astrophysical Observation", "SAO 213577"},
        {"Wilson Evans Batten Catalogue", "WEB 19640"},
    },
    visualMagnitude: 4.99,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.10803368),
        dec: Angle.Degrees(-34.04372111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215920"},
        {"Hipparcos Number", "HIP 112684"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.27826781),
        dec: Angle.Degrees(-34.04358534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 320102"},
        {"Hipparcos Number", "HIP 86197"},
    },
    visualMagnitude: 11.15,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.22343016),
        dec: Angle.Degrees(-34.04354523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67381"},
        {"Hipparcos Number", "HIP 39663"},
        {"Smithsonian Astrophysical Observation", "SAO 198803"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.58111755),
        dec: Angle.Degrees(-34.04172639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172536"},
        {"Hipparcos Number", "HIP 91718"},
        {"Smithsonian Astrophysical Observation", "SAO 210477"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.54783470),
        dec: Angle.Degrees(-34.04025414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64570"},
        {"Hipparcos Number", "HIP 38516"},
        {"Smithsonian Astrophysical Observation", "SAO 198560"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.31660435),
        dec: Angle.Degrees(-34.03889934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136867"},
        {"Hipparcos Number", "HIP 75374"},
        {"Smithsonian Astrophysical Observation", "SAO 206589"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.03666000),
        dec: Angle.Degrees(-34.03735097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219260"},
        {"Hipparcos Number", "HIP 114765"},
        {"Smithsonian Astrophysical Observation", "SAO 214402"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.71521348),
        dec: Angle.Degrees(-34.03480028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34725B"},
        {"Hipparcos Number", "HIP 24712"},
        {"Smithsonian Astrophysical Observation", "SAO 195730"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.51427231),
        dec: Angle.Degrees(-34.03332181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136013"},
        {"Hipparcos Number", "HIP 74985"},
        {"Geneva Identification System", "GEN# +1.00136013"},
        {"Smithsonian Astrophysical Observation", "SAO 206522"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.84309500),
        dec: Angle.Degrees(-34.03240466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55042"},
        {"Hipparcos Number", "HIP 34595"},
        {"Smithsonian Astrophysical Observation", "SAO 197650"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.48420069),
        dec: Angle.Degrees(-34.03131102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7618"},
        {"Hipparcos Number", "HIP 5885"},
        {"Smithsonian Astrophysical Observation", "SAO 193009"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.89111696),
        dec: Angle.Degrees(-34.03100538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176421"},
        {"Hipparcos Number", "HIP 93431"},
        {"Smithsonian Astrophysical Observation", "SAO 210832"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.42754867),
        dec: Angle.Degrees(-34.03022135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82164"},
        {"Hipparcos Number", "HIP 46536"},
        {"Geneva Identification System", "GEN# +1.00082164"},
        {"Smithsonian Astrophysical Observation", "SAO 200421"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.36984404),
        dec: Angle.Degrees(-34.02978246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34725"},
        {"Hipparcos Number", "HIP 24711"},
        {"Smithsonian Astrophysical Observation", "SAO 195729"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.51353698),
        dec: Angle.Degrees(-34.02965925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109540",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109540"},
        {"Smithsonian Astrophysical Observation", "SAO 213619"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.83706040),
        dec: Angle.Degrees(-34.02840240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24221"},
        {"Hipparcos Number", "HIP 17926"},
        {"Smithsonian Astrophysical Observation", "SAO 194562"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.51143953),
        dec: Angle.Degrees(-34.02655362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73089"},
        {"Hipparcos Number", "HIP 42122"},
        {"Geneva Identification System", "GEN# +1.00073089"},
        {"Smithsonian Astrophysical Observation", "SAO 199398"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.79766550),
        dec: Angle.Degrees(-34.02440231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20776"},
        {"Hipparcos Number", "HIP 15493"},
        {"Geneva Identification System", "GEN# +1.00020776"},
        {"Smithsonian Astrophysical Observation", "SAO 194233"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.91197793),
        dec: Angle.Degrees(-34.02371802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64777"},
        {"Hipparcos Number", "HIP 38587"},
        {"Celescope Catalog", "CEL 2084"},
        {"Geneva Identification System", "GEN# +1.00064777"},
        {"Smithsonian Astrophysical Observation", "SAO 198570"},
    },
    visualMagnitude: 7.48,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.52036420),
        dec: Angle.Degrees(-34.02224312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130449"},
        {"Hipparcos Number", "HIP 72485"},
        {"Smithsonian Astrophysical Observation", "SAO 205978"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.32165149),
        dec: Angle.Degrees(-34.02005492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73984"},
        {"Hipparcos Number", "HIP 42510"},
        {"Smithsonian Astrophysical Observation", "SAO 199486"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.01130097),
        dec: Angle.Degrees(-34.01984229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149735"},
        {"Hipparcos Number", "HIP 81447"},
        {"Smithsonian Astrophysical Observation", "SAO 207858"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.52306129),
        dec: Angle.Degrees(-34.01955781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67735"},
        {"Hipparcos Number", "HIP 39800"},
        {"Celescope Catalog", "CEL 2170"},
        {"Geneva Identification System", "GEN# +1.00067735"},
        {"Smithsonian Astrophysical Observation", "SAO 198832"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.99949780),
        dec: Angle.Degrees(-34.01916638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43802"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.81919192),
        dec: Angle.Degrees(-34.01766396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161612"},
        {"Hipparcos Number", "HIP 87116"},
        {"Cincinnati Publication", "Ci 20 1063"},
        {"Geneva Identification System", "GEN# +1.00161612"},
        {"Smithsonian Astrophysical Observation", "SAO 209265"},
        {"Wilson Evans Batten Catalogue", "WEB 14699"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.99039267),
        dec: Angle.Degrees(-34.01749897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -205.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -565.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20535",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Beemim"},
        {"Henry Draper", "HD 28028"},
        {"Hipparcos Number", "HIP 20535"},
        {"Fundamental Katalog 5th Edition", "FK5 1121"},
        {"Geneva Identification System", "GEN# +1.00028028"},
        {"Smithsonian Astrophysical Observation", "SAO 194984"},
        {"Wilson Evans Batten Catalogue", "WEB 3928"},
    },
    visualMagnitude: 3.97,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.00902233),
        dec: Angle.Degrees(-34.01698632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210271"},
        {"Hipparcos Number", "HIP 109404"},
        {"Geneva Identification System", "GEN# +1.00210271"},
        {"Smithsonian Astrophysical Observation", "SAO 213599"},
        {"Wilson Evans Batten Catalogue", "WEB 19657"},
    },
    visualMagnitude: 5.37,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.48213069),
        dec: Angle.Degrees(-34.01503553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20804"},
        {"Hipparcos Number", "HIP 15517"},
        {"Geneva Identification System", "GEN# +1.00020804"},
        {"Smithsonian Astrophysical Observation", "SAO 194236"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.98942181),
        dec: Angle.Degrees(-34.01189715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31006"},
        {"Hipparcos Number", "HIP 22533"},
        {"Smithsonian Astrophysical Observation", "SAO 195348"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.73301988),
        dec: Angle.Degrees(-34.01149823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38867"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.31551504),
        dec: Angle.Degrees(-34.01095686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107493",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107493"},
        {"Smithsonian Astrophysical Observation", "SAO 213272"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.58042096),
        dec: Angle.Degrees(-34.01049331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73947"},
        {"Hipparcos Number", "HIP 42495"},
        {"Smithsonian Astrophysical Observation", "SAO 199480"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.95884213),
        dec: Angle.Degrees(-34.00976759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116788"},
        {"Hipparcos Number", "HIP 65557"},
        {"Geneva Identification System", "GEN# +1.00116788"},
        {"Smithsonian Astrophysical Observation", "SAO 204475"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.61025076),
        dec: Angle.Degrees(-34.00961366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46973"},
        {"Hipparcos Number", "HIP 31374"},
        {"Smithsonian Astrophysical Observation", "SAO 196959"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.68067788),
        dec: Angle.Degrees(-34.00948697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146609"},
        {"Hipparcos Number", "HIP 79896"},
        {"Smithsonian Astrophysical Observation", "SAO 207534"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.61677407),
        dec: Angle.Degrees(-34.00940815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5342"},
        {"Smithsonian Astrophysical Observation", "SAO 192944"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.07507801),
        dec: Angle.Degrees(-34.00893866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77058"},
        {"Hipparcos Number", "HIP 44101"},
        {"Geneva Identification System", "GEN# +1.00077058"},
        {"Smithsonian Astrophysical Observation", "SAO 199851"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.73732940),
        dec: Angle.Degrees(-34.00649324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50822",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50822"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.65763539),
        dec: Angle.Degrees(-34.00580172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94017"},
        {"Hipparcos Number", "HIP 53006"},
        {"Geneva Identification System", "GEN# +1.00094017"},
        {"Smithsonian Astrophysical Observation", "SAO 201817"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.65664804),
        dec: Angle.Degrees(-34.00522706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -287.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30397"},
        {"Hipparcos Number", "HIP 22136"},
        {"Geneva Identification System", "GEN# +1.00030397"},
        {"Smithsonian Astrophysical Observation", "SAO 195275"},
        {"Wilson Evans Batten Catalogue", "WEB 4256"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.45682083),
        dec: Angle.Degrees(-34.00504529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144116"},
        {"Hipparcos Number", "HIP 78826"},
        {"Smithsonian Astrophysical Observation", "SAO 207317"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.36914303),
        dec: Angle.Degrees(-34.00438958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81045"},
        {"Hipparcos Number", "HIP 45958"},
        {"Smithsonian Astrophysical Observation", "SAO 200287"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.58872230),
        dec: Angle.Degrees(-34.00348551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121849"},
        {"Hipparcos Number", "HIP 68273"},
        {"Cincinnati Publication", "Ci 20 823"},
        {"Geneva Identification System", "GEN# +1.00121849"},
        {"Smithsonian Astrophysical Observation", "SAO 205054"},
        {"Wilson Evans Batten Catalogue", "WEB 11977"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.65429453),
        dec: Angle.Degrees(-34.00055067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -460.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -305.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186214"},
        {"Hipparcos Number", "HIP 97127"},
        {"Smithsonian Astrophysical Observation", "SAO 211523"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.10434401),
        dec: Angle.Degrees(-33.99973942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111597"},
        {"Hipparcos Number", "HIP 62683"},
        {"Fundamental Katalog 5th Edition", "FK5 1331"},
        {"Geneva Identification System", "GEN# +1.00111597"},
        {"Smithsonian Astrophysical Observation", "SAO 203863"},
        {"Wilson Evans Batten Catalogue", "WEB 11118"},
    },
    visualMagnitude: 4.90,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.67161238),
        dec: Angle.Degrees(-33.99926779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29718"},
        {"Hipparcos Number", "HIP 21694"},
        {"Geneva Identification System", "GEN# +1.00029718"},
        {"Smithsonian Astrophysical Observation", "SAO 195206"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.86637071),
        dec: Angle.Degrees(-33.99894864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 131.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199227"},
        {"Hipparcos Number", "HIP 103397"},
        {"Geneva Identification System", "GEN# +1.00199227"},
        {"Smithsonian Astrophysical Observation", "SAO 212566"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.21755103),
        dec: Angle.Degrees(-33.99856391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36797",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36797"},
        {"Smithsonian Astrophysical Observation", "SAO 198134"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.52242550),
        dec: Angle.Degrees(-33.99757570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202559"},
        {"Hipparcos Number", "HIP 105126"},
        {"Geneva Identification System", "GEN# +1.00202559"},
        {"Smithsonian Astrophysical Observation", "SAO 212871"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.42355575),
        dec: Angle.Degrees(-33.99744933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82692"},
        {"Hipparcos Number", "HIP 46833"},
        {"Renson", "Renson 23560"},
        {"Smithsonian Astrophysical Observation", "SAO 200479"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.14649246),
        dec: Angle.Degrees(-33.99715114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107733"},
        {"Hipparcos Number", "HIP 60385"},
        {"Geneva Identification System", "GEN# +1.00107733"},
        {"Smithsonian Astrophysical Observation", "SAO 203411"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.71434878),
        dec: Angle.Degrees(-33.99468193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199109"},
        {"Hipparcos Number", "HIP 103321"},
        {"Smithsonian Astrophysical Observation", "SAO 212551"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.99285127),
        dec: Angle.Degrees(-33.99402454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33284"},
        {"Hipparcos Number", "HIP 23851"},
        {"Smithsonian Astrophysical Observation", "SAO 195572"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.90869972),
        dec: Angle.Degrees(-33.99381330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 200",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 200"},
        {"Smithsonian Astrophysical Observation", "SAO 214939"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.63546326),
        dec: Angle.Degrees(-33.99267216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37719"},
    },
    visualMagnitude: 9.89,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.05381937),
        dec: Angle.Degrees(-33.99122588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123020"},
        {"Hipparcos Number", "HIP 68854"},
        {"Smithsonian Astrophysical Observation", "SAO 205175"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.48744763),
        dec: Angle.Degrees(-33.98729902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108565"},
        {"Hipparcos Number", "HIP 60864"},
        {"Smithsonian Astrophysical Observation", "SAO 203510"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.12848037),
        dec: Angle.Degrees(-33.98524963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103780",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103780"},
        {"Smithsonian Astrophysical Observation", "SAO 212644"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.45565997),
        dec: Angle.Degrees(-33.98463911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119191"},
        {"Hipparcos Number", "HIP 66874"},
        {"Geneva Identification System", "GEN# +1.00119191J"},
        {"Smithsonian Astrophysical Observation", "SAO 204749"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.58658920),
        dec: Angle.Degrees(-33.98051681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121759"},
        {"Hipparcos Number", "HIP 68231"},
        {"Geneva Identification System", "GEN# +1.00121759"},
        {"Smithsonian Astrophysical Observation", "SAO 205045"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.51485536),
        dec: Angle.Degrees(-33.97740488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192753"},
        {"Hipparcos Number", "HIP 100042"},
        {"Smithsonian Astrophysical Observation", "SAO 211974"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.44152396),
        dec: Angle.Degrees(-33.97504158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76864"},
    },
    visualMagnitude: 11.04,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.43882078),
        dec: Angle.Degrees(-33.97058244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160410"},
        {"Hipparcos Number", "HIP 86545"},
        {"Geneva Identification System", "GEN# +1.00160410"},
        {"Smithsonian Astrophysical Observation", "SAO 209136"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.29459704),
        dec: Angle.Degrees(-33.96863612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33387",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33387"},
        {"Smithsonian Astrophysical Observation", "SAO 197385"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.15033037),
        dec: Angle.Degrees(-33.96800350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22861"},
        {"Hipparcos Number", "HIP 17030"},
        {"Smithsonian Astrophysical Observation", "SAO 194429"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.76209547),
        dec: Angle.Degrees(-33.96674415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142629"},
        {"Hipparcos Number", "HIP 78105"},
        {"Smithsonian Astrophysical Observation", "SAO 207144"},
        {"Wilson Evans Batten Catalogue", "WEB 13207"},
    },
    visualMagnitude: 5.14,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.22283960),
        dec: Angle.Degrees(-33.96602225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142630"},
        {"Hipparcos Number", "HIP 78106"},
        {"Geneva Identification System", "GEN# +1.00142630"},
        {"Smithsonian Astrophysical Observation", "SAO 207145"},
        {"Wilson Evans Batten Catalogue", "WEB 13208"},
    },
    visualMagnitude: 5.59,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.22543843),
        dec: Angle.Degrees(-33.96415999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138360"},
        {"Hipparcos Number", "HIP 76119"},
        {"Smithsonian Astrophysical Observation", "SAO 206745"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.20336221),
        dec: Angle.Degrees(-33.96361760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3735"},
        {"Hipparcos Number", "HIP 3142"},
        {"Cincinnati Publication", "Ci 18 83"},
        {"Geneva Identification System", "GEN# +1.00003735"},
        {"Smithsonian Astrophysical Observation", "SAO 192663"},
        {"Wilson Evans Batten Catalogue", "WEB 561"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.98996521),
        dec: Angle.Degrees(-33.96118617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 330.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17398"},
        {"Hipparcos Number", "HIP 12942"},
        {"Smithsonian Astrophysical Observation", "SAO 193905"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.61034242),
        dec: Angle.Degrees(-33.96040104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38253"},
        {"Hipparcos Number", "HIP 26924"},
        {"Geneva Identification System", "GEN# +1.00038253"},
        {"Smithsonian Astrophysical Observation", "SAO 196107"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.72273681),
        dec: Angle.Degrees(-33.95833319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5321"},
        {"Hipparcos Number", "HIP 4270"},
        {"Geneva Identification System", "GEN# +1.00005321"},
        {"Smithsonian Astrophysical Observation", "SAO 192812"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.66051997),
        dec: Angle.Degrees(-33.95728996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162874"},
        {"Hipparcos Number", "HIP 87686"},
        {"Geneva Identification System", "GEN# +1.00162874"},
        {"Smithsonian Astrophysical Observation", "SAO 209449"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.65941749),
        dec: Angle.Degrees(-33.95630393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78528",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 13.55,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)01, 54.1100),
        dec: Angle.DegreesMinutesSeconds((int)-33, (int)57, 12.200)
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
    primaryId: "HIP 38910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38910"},
        {"Geneva Identification System", "GEN# -0.03304354"},
        {"Smithsonian Astrophysical Observation", "SAO 198638"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.45166348),
        dec: Angle.Degrees(-33.95292606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 304.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171335"},
        {"Hipparcos Number", "HIP 91153"},
        {"Smithsonian Astrophysical Observation", "SAO 210348"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.94671412),
        dec: Angle.Degrees(-33.95246905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116180"},
        {"Hipparcos Number", "HIP 65253"},
        {"Smithsonian Astrophysical Observation", "SAO 204404"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.59984407),
        dec: Angle.Degrees(-33.95130864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64341"},
        {"Hipparcos Number", "HIP 38401"},
        {"Smithsonian Astrophysical Observation", "SAO 198535"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.00936703),
        dec: Angle.Degrees(-33.95091420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129051"},
        {"Hipparcos Number", "HIP 71815"},
        {"Smithsonian Astrophysical Observation", "SAO 205833"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.35047375),
        dec: Angle.Degrees(-33.95033105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97575"},
        {"Hipparcos Number", "HIP 54823"},
        {"Smithsonian Astrophysical Observation", "SAO 202214"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.34780842),
        dec: Angle.Degrees(-33.94983281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22687"},
        {"Hipparcos Number", "HIP 16904"},
        {"Smithsonian Astrophysical Observation", "SAO 194412"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.38066070),
        dec: Angle.Degrees(-33.94963280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134016"},
        {"Hipparcos Number", "HIP 74102"},
        {"Smithsonian Astrophysical Observation", "SAO 206332"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.17293754),
        dec: Angle.Degrees(-33.94930264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169398"},
        {"Hipparcos Number", "HIP 90336"},
        {"Geneva Identification System", "GEN# +1.00169398"},
        {"Smithsonian Astrophysical Observation", "SAO 210135"},
        {"Wilson Evans Batten Catalogue", "WEB 15462"},
    },
    visualMagnitude: 6.30,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.47752648),
        dec: Angle.Degrees(-33.94569163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204854"},
        {"Hipparcos Number", "HIP 106340"},
        {"Fundamental Katalog 5th Edition", "FK5 1566"},
        {"Geneva Identification System", "GEN# +1.00204854J"},
        {"Smithsonian Astrophysical Observation", "SAO 213078"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.06072952),
        dec: Angle.Degrees(-33.94461293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13559"},
        {"Hipparcos Number", "HIP 10231"},
        {"Smithsonian Astrophysical Observation", "SAO 193563"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.88340635),
        dec: Angle.Degrees(-33.94375876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92327"},
        {"Hipparcos Number", "HIP 52144"},
        {"Celescope Catalog", "CEL 3611"},
        {"Geneva Identification System", "GEN# +1.00092327"},
        {"Smithsonian Astrophysical Observation", "SAO 201593"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.78954910),
        dec: Angle.Degrees(-33.94308703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36102",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36102"},
    },
    visualMagnitude: 12.04,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.55646409),
        dec: Angle.Degrees(-33.94190670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -234.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 303.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41573"},
        {"Hipparcos Number", "HIP 28763"},
        {"Smithsonian Astrophysical Observation", "SAO 196463"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.11301083),
        dec: Angle.Degrees(-33.94184315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176046"},
        {"Hipparcos Number", "HIP 93258"},
        {"Geneva Identification System", "GEN# +1.00176046"},
        {"Smithsonian Astrophysical Observation", "SAO 210796"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.96087996),
        dec: Angle.Degrees(-33.94160200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67181",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67181"},
        {"Geneva Identification System", "GEN# -0.03309314"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.51446045),
        dec: Angle.Degrees(-33.94077257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76226",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76226"},
        {"Geneva Identification System", "GEN# -0.03310593"},
        {"Smithsonian Astrophysical Observation", "SAO 206771"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.56764381),
        dec: Angle.Degrees(-33.94034900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12002"},
        {"Hipparcos Number", "HIP 9088"},
        {"Geneva Identification System", "GEN# +1.00012002"},
        {"Smithsonian Astrophysical Observation", "SAO 193401"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.26394772),
        dec: Angle.Degrees(-33.93981577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170213"},
        {"Hipparcos Number", "HIP 90639"},
        {"Smithsonian Astrophysical Observation", "SAO 210226"},
    },
    visualMagnitude: 7.04,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.40792051),
        dec: Angle.Degrees(-33.93393367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123602"},
        {"Hipparcos Number", "HIP 69149"},
        {"Smithsonian Astrophysical Observation", "SAO 205240"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.33349953),
        dec: Angle.Degrees(-33.93379805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127917"},
        {"Hipparcos Number", "HIP 71306"},
        {"Smithsonian Astrophysical Observation", "SAO 205719"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.73126961),
        dec: Angle.Degrees(-33.93305535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107719"},
        {"Geneva Identification System", "GEN# -0.03415270"},
        {"Smithsonian Astrophysical Observation", "SAO 213314"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.31248673),
        dec: Angle.Degrees(-33.93126517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19715"},
        {"Hipparcos Number", "HIP 14646"},
        {"Geneva Identification System", "GEN# +1.00019715"},
        {"Smithsonian Astrophysical Observation", "SAO 194116"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.31897374),
        dec: Angle.Degrees(-33.93083252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114966"},
        {"Hipparcos Number", "HIP 64602"},
        {"Smithsonian Astrophysical Observation", "SAO 204270"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.61365900),
        dec: Angle.Degrees(-33.93004898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126091"},
        {"Hipparcos Number", "HIP 70407"},
        {"Renson", "Renson 35950"},
        {"Smithsonian Astrophysical Observation", "SAO 205522"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.06215233),
        dec: Angle.Degrees(-33.92819932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102821",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102821"},
        {"Smithsonian Astrophysical Observation", "SAO 212469"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.45332992),
        dec: Angle.Degrees(-33.92388135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70776"},
        {"Hipparcos Number", "HIP 41041"},
        {"Smithsonian Astrophysical Observation", "SAO 199142"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.63692888),
        dec: Angle.Degrees(-33.92341512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172796"},
        {"Hipparcos Number", "HIP 91846"},
        {"Smithsonian Astrophysical Observation", "SAO 210500"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.88036967),
        dec: Angle.Degrees(-33.92321298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195830B"},
        {"Hipparcos Number", "HIP 101549"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.69234213),
        dec: Angle.Degrees(-33.92265738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27746"},
        {"Hipparcos Number", "HIP 20333"},
        {"Smithsonian Astrophysical Observation", "SAO 194950"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.34224346),
        dec: Angle.Degrees(-33.92247726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195830"},
        {"Hipparcos Number", "HIP 101551"},
        {"Geneva Identification System", "GEN# +1.00195830"},
        {"Smithsonian Astrophysical Observation", "SAO 212245"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.69574672),
        dec: Angle.Degrees(-33.92199169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29985"},
        {"Hipparcos Number", "HIP 21865"},
        {"Geneva Identification System", "GEN# +1.00029985"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.52196312),
        dec: Angle.Degrees(-33.91909676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -293.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166133"},
        {"Hipparcos Number", "HIP 89066"},
        {"Smithsonian Astrophysical Observation", "SAO 209811"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.67381714),
        dec: Angle.Degrees(-33.91868049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202759"},
        {"Hipparcos Number", "HIP 105249"},
        {"Geneva Identification System", "GEN# +1.00202759"},
        {"Smithsonian Astrophysical Observation", "SAO 212896"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.77436273),
        dec: Angle.Degrees(-33.91867332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216935"},
        {"Hipparcos Number", "HIP 113362"},
        {"Smithsonian Astrophysical Observation", "SAO 214201"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.39149608),
        dec: Angle.Degrees(-33.91590608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50499"},
        {"Hipparcos Number", "HIP 32970"},
        {"Geneva Identification System", "GEN# +1.00050499"},
        {"Smithsonian Astrophysical Observation", "SAO 197294"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.00863683),
        dec: Angle.Degrees(-33.91572691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 321021"},
        {"Hipparcos Number", "HIP 88182"},
        {"Smithsonian Astrophysical Observation", "SAO 209584"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.13636114),
        dec: Angle.Degrees(-33.91555581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39021",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39021"},
        {"Smithsonian Astrophysical Observation", "SAO 198661"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.77325003),
        dec: Angle.Degrees(-33.91253047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41047"},
        {"Hipparcos Number", "HIP 28524"},
        {"Geneva Identification System", "GEN# +1.00041047"},
        {"Smithsonian Astrophysical Observation", "SAO 196413"},
        {"Wilson Evans Batten Catalogue", "WEB 5578"},
    },
    visualMagnitude: 5.54,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.31789213),
        dec: Angle.Degrees(-33.91177131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88587"},
        {"Hipparcos Number", "HIP 49979"},
        {"Geneva Identification System", "GEN# +1.00088587"},
        {"Smithsonian Astrophysical Observation", "SAO 201163"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.06281561),
        dec: Angle.Degrees(-33.91145495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204046"},
        {"Hipparcos Number", "HIP 105901"},
        {"Smithsonian Astrophysical Observation", "SAO 213005"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.72555121),
        dec: Angle.Degrees(-33.90991608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218665"},
        {"Hipparcos Number", "HIP 114400"},
        {"Smithsonian Astrophysical Observation", "SAO 214353"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.53113894),
        dec: Angle.Degrees(-33.90903648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1524"},
        {"Hipparcos Number", "HIP 1544"},
        {"Smithsonian Astrophysical Observation", "SAO 192460"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.81314548),
        dec: Angle.Degrees(-33.90895092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173410"},
        {"Hipparcos Number", "HIP 92120"},
        {"Geneva Identification System", "GEN# +1.00173410"},
        {"Smithsonian Astrophysical Observation", "SAO 210559"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.62816683),
        dec: Angle.Degrees(-33.90833005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173732"},
        {"Hipparcos Number", "HIP 92268"},
        {"Smithsonian Astrophysical Observation", "SAO 210583"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.06151321),
        dec: Angle.Degrees(-33.90814594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103192"},
        {"Hipparcos Number", "HIP 57936"},
        {"Geneva Identification System", "GEN# +1.00103192"},
        {"Renson", "Renson 29760"},
        {"Smithsonian Astrophysical Observation", "SAO 202901"},
        {"Wilson Evans Batten Catalogue", "WEB 10385"},
    },
    visualMagnitude: 4.29,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.22733867),
        dec: Angle.Degrees(-33.90813014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27490"},
        {"Hipparcos Number", "HIP 20138"},
        {"Geneva Identification System", "GEN# +1.00027490J"},
        {"Smithsonian Astrophysical Observation", "SAO 194923"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.76204095),
        dec: Angle.Degrees(-33.90462785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58798"},
        {"Hipparcos Number", "HIP 36047"},
        {"Smithsonian Astrophysical Observation", "SAO 197987"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.43534992),
        dec: Angle.Degrees(-33.90356630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153594"},
        {"Hipparcos Number", "HIP 83334"},
        {"Geneva Identification System", "GEN# +1.00153594"},
        {"Smithsonian Astrophysical Observation", "SAO 208321"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.46666076),
        dec: Angle.Degrees(-33.90276383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98961"},
        {"Smithsonian Astrophysical Observation", "SAO 211797"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.38546642),
        dec: Angle.Degrees(-33.90223574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75025"},
        {"Hipparcos Number", "HIP 43064"},
        {"Smithsonian Astrophysical Observation", "SAO 199598"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.59024476),
        dec: Angle.Degrees(-33.90208159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96111"},
        {"Hipparcos Number", "HIP 54161"},
        {"Smithsonian Astrophysical Observation", "SAO 202064"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.19353266),
        dec: Angle.Degrees(-33.90105767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220025"},
        {"Hipparcos Number", "HIP 115265"},
        {"Smithsonian Astrophysical Observation", "SAO 214476"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.19515006),
        dec: Angle.Degrees(-33.90054956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135126"},
        {"Hipparcos Number", "HIP 74614"},
        {"Smithsonian Astrophysical Observation", "SAO 206446"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.67916817),
        dec: Angle.Degrees(-33.89990432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102456"},
        {"Hipparcos Number", "HIP 57533"},
        {"Smithsonian Astrophysical Observation", "SAO 202816"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.87391697),
        dec: Angle.Degrees(-33.89936863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150163"},
        {"Hipparcos Number", "HIP 81635"},
        {"Smithsonian Astrophysical Observation", "SAO 207910"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.14698494),
        dec: Angle.Degrees(-33.89928905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16714"},
        {"Hipparcos Number", "HIP 12411"},
        {"Cincinnati Publication", "Ci 20 177"},
        {"Geneva Identification System", "GEN# +1.00016714"},
        {"Smithsonian Astrophysical Observation", "SAO 193843"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.94819506),
        dec: Angle.Degrees(-33.89908714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -396.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28913"},
        {"Hipparcos Number", "HIP 21146"},
        {"Smithsonian Astrophysical Observation", "SAO 195108"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.99911870),
        dec: Angle.Degrees(-33.89860760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81755"},
        {"Hipparcos Number", "HIP 46305"},
        {"Geneva Identification System", "GEN# +1.00081755"},
        {"Smithsonian Astrophysical Observation", "SAO 200374"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.64699927),
        dec: Angle.Degrees(-33.89731347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15394"},
        {"Hipparcos Number", "HIP 11448"},
        {"Geneva Identification System", "GEN# +1.00015394"},
        {"Smithsonian Astrophysical Observation", "SAO 193720"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.92639250),
        dec: Angle.Degrees(-33.89657236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3356"},
        {"Hipparcos Number", "HIP 2858"},
        {"Smithsonian Astrophysical Observation", "SAO 192630"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.05488471),
        dec: Angle.Degrees(-33.89640082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120608"},
        {"Hipparcos Number", "HIP 67613"},
        {"Smithsonian Astrophysical Observation", "SAO 204906"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.81332182),
        dec: Angle.Degrees(-33.89320178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110279",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110279"},
        {"Smithsonian Astrophysical Observation", "SAO 213745"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.06982511),
        dec: Angle.Degrees(-33.89274159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204705"},
        {"Hipparcos Number", "HIP 106261"},
        {"Smithsonian Astrophysical Observation", "SAO 213063"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.84404251),
        dec: Angle.Degrees(-33.89026871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164455"},
        {"Hipparcos Number", "HIP 88369"},
        {"Geneva Identification System", "GEN# +1.00164455"},
        {"Smithsonian Astrophysical Observation", "SAO 209631"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.67883236),
        dec: Angle.Degrees(-33.88916928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14657"},
        {"Hipparcos Number", "HIP 10949"},
        {"Smithsonian Astrophysical Observation", "SAO 193654"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.25551482),
        dec: Angle.Degrees(-33.88693592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87605"},
        {"Hipparcos Number", "HIP 49420"},
        {"Smithsonian Astrophysical Observation", "SAO 201036"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.31906835),
        dec: Angle.Degrees(-33.88599139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50096"},
        {"Hipparcos Number", "HIP 32788"},
        {"Celescope Catalog", "CEL 1404"},
        {"Geneva Identification System", "GEN# +1.00050096"},
        {"Smithsonian Astrophysical Observation", "SAO 197262"},
    },
    visualMagnitude: 7.41,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.54508381),
        dec: Angle.Degrees(-33.88575612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101881"},
        {"Hipparcos Number", "HIP 57170"},
        {"Smithsonian Astrophysical Observation", "SAO 202746"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.87388246),
        dec: Angle.Degrees(-33.88571480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215937"},
        {"Hipparcos Number", "HIP 112686"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.29580911),
        dec: Angle.Degrees(-33.88526751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2366"},
        {"Hipparcos Number", "HIP 2164"},
        {"Smithsonian Astrophysical Observation", "SAO 192533"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.82473474),
        dec: Angle.Degrees(-33.88193328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198543"},
        {"Hipparcos Number", "HIP 103002"},
        {"Smithsonian Astrophysical Observation", "SAO 212500"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.02139417),
        dec: Angle.Degrees(-33.88182152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52295"},
        {"Hipparcos Number", "HIP 33630"},
        {"Geneva Identification System", "GEN# +1.00052295"},
        {"Smithsonian Astrophysical Observation", "SAO 197439"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.79731677),
        dec: Angle.Degrees(-33.88085266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33822"},
        {"Hipparcos Number", "HIP 24176"},
        {"Geneva Identification System", "GEN# +1.00033822"},
        {"Smithsonian Astrophysical Observation", "SAO 195634"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.87307112),
        dec: Angle.Degrees(-33.88057826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216792"},
        {"Hipparcos Number", "HIP 113274"},
        {"Smithsonian Astrophysical Observation", "SAO 214194"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.05698523),
        dec: Angle.Degrees(-33.88044571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37698"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.01208662),
        dec: Angle.Degrees(-33.87871500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213666"},
        {"Hipparcos Number", "HIP 111371"},
        {"Geneva Identification System", "GEN# +1.00213666"},
        {"Smithsonian Astrophysical Observation", "SAO 213909"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.44061503),
        dec: Angle.Degrees(-33.87624999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121451"},
        {"Hipparcos Number", "HIP 68070"},
        {"Smithsonian Astrophysical Observation", "SAO 205009"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.04894669),
        dec: Angle.Degrees(-33.87606795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17300"},
        {"Hipparcos Number", "HIP 12887"},
        {"Smithsonian Astrophysical Observation", "SAO 193894"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.41865592),
        dec: Angle.Degrees(-33.87446626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191091"},
        {"Hipparcos Number", "HIP 99302"},
        {"Smithsonian Astrophysical Observation", "SAO 211863"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.35389712),
        dec: Angle.Degrees(-33.87426970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113028"},
        {"Hipparcos Number", "HIP 63537"},
        {"Smithsonian Astrophysical Observation", "SAO 204043"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.30286204),
        dec: Angle.Degrees(-33.87410894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112522"},
        {"Hipparcos Number", "HIP 63246"},
        {"Geneva Identification System", "GEN# +1.00112522"},
        {"Smithsonian Astrophysical Observation", "SAO 203971"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.39658275),
        dec: Angle.Degrees(-33.87227296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4210"},
        {"Hipparcos Number", "HIP 3464"},
        {"Geneva Identification System", "GEN# +1.00004210"},
        {"Smithsonian Astrophysical Observation", "SAO 192704"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.08047041),
        dec: Angle.Degrees(-33.87156024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73754"},
        {"Hipparcos Number", "HIP 42406"},
        {"Smithsonian Astrophysical Observation", "SAO 199463"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.69858611),
        dec: Angle.Degrees(-33.87097671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42801"},
        {"Hipparcos Number", "HIP 29356"},
        {"Smithsonian Astrophysical Observation", "SAO 196568"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.81479264),
        dec: Angle.Degrees(-33.87084860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5568"},
        {"Hipparcos Number", "HIP 4455"},
        {"Smithsonian Astrophysical Observation", "SAO 192833"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.27456281),
        dec: Angle.Degrees(-33.86985015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170843"},
        {"Hipparcos Number", "HIP 90931"},
        {"Smithsonian Astrophysical Observation", "SAO 210288"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.23089938),
        dec: Angle.Degrees(-33.86859434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66128"},
        {"Hipparcos Number", "HIP 39174"},
        {"Geneva Identification System", "GEN# +1.00066128"},
        {"Smithsonian Astrophysical Observation", "SAO 198696"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.18645956),
        dec: Angle.Degrees(-33.86603345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32575",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32575"},
        {"Smithsonian Astrophysical Observation", "SAO 197220"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.95825649),
        dec: Angle.Degrees(-33.86562346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154664"},
        {"Hipparcos Number", "HIP 83861"},
        {"Geneva Identification System", "GEN# +1.00154664"},
        {"Smithsonian Astrophysical Observation", "SAO 208454"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.08751578),
        dec: Angle.Degrees(-33.86537560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23868"},
    },
    visualMagnitude: 12.66,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.94600827),
        dec: Angle.Degrees(-33.86510171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17286"},
        {"Hipparcos Number", "HIP 12883"},
        {"Geneva Identification System", "GEN# +1.00017286"},
        {"Smithsonian Astrophysical Observation", "SAO 193893"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.40243522),
        dec: Angle.Degrees(-33.86304090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161774"},
        {"Hipparcos Number", "HIP 87196"},
        {"Geneva Identification System", "GEN# +1.00161774"},
        {"Smithsonian Astrophysical Observation", "SAO 209293"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.21393087),
        dec: Angle.Degrees(-33.86251411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20300"},
        {"Hipparcos Number", "HIP 15096"},
        {"Fundamental Katalog 5th Edition", "FK5 4297"},
        {"Smithsonian Astrophysical Observation", "SAO 194177"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.69107646),
        dec: Angle.Degrees(-33.86126433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22646"},
        {"Hipparcos Number", "HIP 16886"},
        {"Smithsonian Astrophysical Observation", "SAO 194408"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.32680997),
        dec: Angle.Degrees(-33.86016732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107680"},
        {"Smithsonian Astrophysical Observation", "SAO 213307"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.18658675),
        dec: Angle.Degrees(-33.85797966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 204.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172238"},
        {"Hipparcos Number", "HIP 91584"},
        {"Smithsonian Astrophysical Observation", "SAO 210436"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.14940890),
        dec: Angle.Degrees(-33.85687010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131625"},
        {"Hipparcos Number", "HIP 73049"},
        {"Fundamental Katalog 5th Edition", "FK5 1389"},
        {"Geneva Identification System", "GEN# +1.00131625"},
        {"Smithsonian Astrophysical Observation", "SAO 206099"},
        {"Wilson Evans Batten Catalogue", "WEB 12526"},
    },
    visualMagnitude: 5.32,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.93622772),
        dec: Angle.Degrees(-33.85578004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213076"},
        {"Hipparcos Number", "HIP 111023"},
        {"Smithsonian Astrophysical Observation", "SAO 213862"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.38502261),
        dec: Angle.Degrees(-33.85120496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150926"},
        {"Hipparcos Number", "HIP 82046"},
        {"Geneva Identification System", "GEN# +1.00150926"},
        {"Smithsonian Astrophysical Observation", "SAO 207999"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.39819516),
        dec: Angle.Degrees(-33.85024851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159379"},
        {"Hipparcos Number", "HIP 86115"},
        {"Renson", "Renson 44860"},
        {"Smithsonian Astrophysical Observation", "SAO 209006"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.97746469),
        dec: Angle.Degrees(-33.84901969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84432"},
        {"Hipparcos Number", "HIP 47766"},
        {"Geneva Identification System", "GEN# +1.00084432"},
        {"Smithsonian Astrophysical Observation", "SAO 200677"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.07420336),
        dec: Angle.Degrees(-33.84870673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213381"},
        {"Hipparcos Number", "HIP 111193"},
        {"Smithsonian Astrophysical Observation", "SAO 213886"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.89648854),
        dec: Angle.Degrees(-33.84777090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18468"},
        {"Hipparcos Number", "HIP 13761"},
        {"Smithsonian Astrophysical Observation", "SAO 194001"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.28408338),
        dec: Angle.Degrees(-33.84773234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16120"},
        {"Hipparcos Number", "HIP 11973"},
        {"Smithsonian Astrophysical Observation", "SAO 193780"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.61032647),
        dec: Angle.Degrees(-33.84732404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145558"},
        {"Hipparcos Number", "HIP 79459"},
        {"Smithsonian Astrophysical Observation", "SAO 207457"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.22842371),
        dec: Angle.Degrees(-33.84715246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124614"},
        {"Hipparcos Number", "HIP 69659"},
        {"Geneva Identification System", "GEN# +1.00124614"},
        {"Smithsonian Astrophysical Observation", "SAO 205359"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.85335354),
        dec: Angle.Degrees(-33.84705086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155451"},
        {"Hipparcos Number", "HIP 84240"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.29173992),
        dec: Angle.Degrees(-33.84662218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179117"},
        {"Hipparcos Number", "HIP 94393"},
        {"Smithsonian Astrophysical Observation", "SAO 211046"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.18386083),
        dec: Angle.Degrees(-33.84616820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10753"},
        {"Hipparcos Number", "HIP 8128"},
        {"Geneva Identification System", "GEN# +1.00010753"},
        {"Smithsonian Astrophysical Observation", "SAO 193279"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.12028211),
        dec: Angle.Degrees(-33.84248655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37414"},
        {"Hipparcos Number", "HIP 26370"},
        {"Smithsonian Astrophysical Observation", "SAO 196016"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.22927903),
        dec: Angle.Degrees(-33.83960033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93983"},
        {"Hipparcos Number", "HIP 52992"},
        {"Smithsonian Astrophysical Observation", "SAO 201813"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.61003890),
        dec: Angle.Degrees(-33.83947234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132602"},
        {"Hipparcos Number", "HIP 73485"},
        {"Geneva Identification System", "GEN# +1.00132602"},
        {"Smithsonian Astrophysical Observation", "SAO 206206"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.26082266),
        dec: Angle.Degrees(-33.83939870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27737"},
        {"Hipparcos Number", "HIP 20329"},
        {"Smithsonian Astrophysical Observation", "SAO 194949"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.32802957),
        dec: Angle.Degrees(-33.83652810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209082"},
        {"Hipparcos Number", "HIP 108723"},
        {"Smithsonian Astrophysical Observation", "SAO 213478"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.36407002),
        dec: Angle.Degrees(-33.83558820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54144",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 10.08,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)04, 35.1900),
        dec: Angle.DegreesMinutesSeconds((int)-33, (int)50, 04.900)
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
    primaryId: "HIP 25660",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25660"},
        {"Smithsonian Astrophysical Observation", "SAO 195896"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.21113198),
        dec: Angle.Degrees(-33.83195532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210349"},
        {"Hipparcos Number", "HIP 109462"},
        {"Smithsonian Astrophysical Observation", "SAO 213608"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.63480794),
        dec: Angle.Degrees(-33.82724550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4733"},
        {"Hipparcos Number", "HIP 3826"},
        {"Smithsonian Astrophysical Observation", "SAO 192762"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.27734523),
        dec: Angle.Degrees(-33.82632838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30658",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30658"},
        {"Smithsonian Astrophysical Observation", "SAO 196822"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.64006748),
        dec: Angle.Degrees(-33.82512575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132263"},
        {"Hipparcos Number", "HIP 73335"},
        {"Smithsonian Astrophysical Observation", "SAO 206168"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.79118987),
        dec: Angle.Degrees(-33.82473209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161119"},
        {"Hipparcos Number", "HIP 86887"},
        {"Smithsonian Astrophysical Observation", "SAO 209216"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.28900430),
        dec: Angle.Degrees(-33.82392719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120322"},
        {"Hipparcos Number", "HIP 67448"},
        {"Smithsonian Astrophysical Observation", "SAO 204873"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.34484025),
        dec: Angle.Degrees(-33.82320618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37431"},
        {"Hipparcos Number", "HIP 26388"},
        {"Smithsonian Astrophysical Observation", "SAO 196018"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.26934880),
        dec: Angle.Degrees(-33.81981006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157191"},
        {"Hipparcos Number", "HIP 85082"},
        {"Smithsonian Astrophysical Observation", "SAO 208757"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.82430937),
        dec: Angle.Degrees(-33.81978429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138138"},
        {"Hipparcos Number", "HIP 76001"},
        {"Smithsonian Astrophysical Observation", "SAO 206720"},
    },
    visualMagnitude: 6.87,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.82176414),
        dec: Angle.Degrees(-33.81976849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39637"},
        {"Hipparcos Number", "HIP 27740"},
        {"Smithsonian Astrophysical Observation", "SAO 196260"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.08790713),
        dec: Angle.Degrees(-33.81947778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40719"},
        {"Hipparcos Number", "HIP 28329"},
        {"Smithsonian Astrophysical Observation", "SAO 196378"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.79409798),
        dec: Angle.Degrees(-33.81865091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157125"},
        {"Hipparcos Number", "HIP 85046"},
        {"Smithsonian Astrophysical Observation", "SAO 208748"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.72208120),
        dec: Angle.Degrees(-33.81736269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116604",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116604"},
        {"Smithsonian Astrophysical Observation", "SAO 214670"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.46425509),
        dec: Angle.Degrees(-33.81702061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110002"},
        {"Hipparcos Number", "HIP 61757"},
        {"Smithsonian Astrophysical Observation", "SAO 203671"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.85637522),
        dec: Angle.Degrees(-33.81428151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157763"},
        {"Hipparcos Number", "HIP 85375"},
        {"Smithsonian Astrophysical Observation", "SAO 208823"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.67600886),
        dec: Angle.Degrees(-33.81390252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32969"},
        {"Hipparcos Number", "HIP 23686"},
        {"Geneva Identification System", "GEN# +1.00032969"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.36601930),
        dec: Angle.Degrees(-33.81242864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215482"},
        {"Hipparcos Number", "HIP 112397"},
        {"Smithsonian Astrophysical Observation", "SAO 214063"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.48949503),
        dec: Angle.Degrees(-33.81155122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15427"},
        {"Hipparcos Number", "HIP 11477"},
        {"Fundamental Katalog 5th Edition", "FK5 2168"},
        {"Geneva Identification System", "GEN# +1.00015427"},
        {"Smithsonian Astrophysical Observation", "SAO 193723"},
        {"Wilson Evans Batten Catalogue", "WEB 2397"},
    },
    visualMagnitude: 5.13,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.00704179),
        dec: Angle.Degrees(-33.81105246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153787"},
        {"Hipparcos Number", "HIP 83409"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.72372270),
        dec: Angle.Degrees(-33.81025744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51367"},
        {"Hipparcos Number", "HIP 33298"},
        {"Smithsonian Astrophysical Observation", "SAO 197366"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.90194807),
        dec: Angle.Degrees(-33.80686979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62577"},
        {"Hipparcos Number", "HIP 37628"},
        {"Smithsonian Astrophysical Observation", "SAO 198345"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.81997380),
        dec: Angle.Degrees(-33.80301488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217886"},
        {"Hipparcos Number", "HIP 113923"},
        {"Smithsonian Astrophysical Observation", "SAO 214285"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.05120658),
        dec: Angle.Degrees(-33.80174986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39764"},
        {"Hipparcos Number", "HIP 27810"},
        {"Geneva Identification System", "GEN# +1.00039764"},
        {"Smithsonian Astrophysical Observation", "SAO 196276"},
        {"Wilson Evans Batten Catalogue", "WEB 5450"},
    },
    visualMagnitude: 4.88,
    bvColour: -0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.27868480),
        dec: Angle.Degrees(-33.80143950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166197"},
        {"Hipparcos Number", "HIP 89086"},
        {"Geneva Identification System", "GEN# +1.00166197"},
        {"Smithsonian Astrophysical Observation", "SAO 209817"},
        {"Wilson Evans Batten Catalogue", "WEB 15124"},
    },
    visualMagnitude: 6.13,
    bvColour: -0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.73060993),
        dec: Angle.Degrees(-33.80006816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54131"},
        {"Geneva Identification System", "GEN# -0.03307473"},
    },
    visualMagnitude: 11.33,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.12208632),
        dec: Angle.Degrees(-33.79892791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27376"},
        {"Hipparcos Number", "HIP 20042"},
        {"Geneva Identification System", "GEN# +1.00027376"},
        {"Renson", "Renson 7020"},
        {"Smithsonian Astrophysical Observation", "SAO 194902"},
        {"Wilson Evans Batten Catalogue", "WEB 3825"},
    },
    visualMagnitude: 3.55,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.47341068),
        dec: Angle.Degrees(-33.79833145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121114"},
        {"Hipparcos Number", "HIP 67887"},
        {"Smithsonian Astrophysical Observation", "SAO 204970"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.56658916),
        dec: Angle.Degrees(-33.79831162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84581"},
        {"Hipparcos Number", "HIP 47872"},
        {"Smithsonian Astrophysical Observation", "SAO 200700"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.35096743),
        dec: Angle.Degrees(-33.79737633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178079"},
        {"Hipparcos Number", "HIP 94042"},
        {"Smithsonian Astrophysical Observation", "SAO 210980"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.18671231),
        dec: Angle.Degrees(-33.79404523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106257"},
        {"Hipparcos Number", "HIP 59622"},
        {"Geneva Identification System", "GEN# +1.00106257J"},
        {"Smithsonian Astrophysical Observation", "SAO 203252"},
        {"Wilson Evans Batten Catalogue", "WEB 10595"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.40332369),
        dec: Angle.Degrees(-33.79288126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224886"},
        {"Hipparcos Number", "HIP 116"},
        {"Smithsonian Astrophysical Observation", "SAO 214926"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.37539303),
        dec: Angle.Degrees(-33.79270439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81841"},
        {"Hipparcos Number", "HIP 46363"},
        {"Smithsonian Astrophysical Observation", "SAO 200382"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.80913338),
        dec: Angle.Degrees(-33.79124962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 546"},
        {"Hipparcos Number", "HIP 794"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.45885362),
        dec: Angle.Degrees(-33.78868219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120590"},
        {"Hipparcos Number", "HIP 67602"},
        {"Smithsonian Astrophysical Observation", "SAO 204904"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.77636389),
        dec: Angle.Degrees(-33.78454405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177319"},
        {"Hipparcos Number", "HIP 93761"},
        {"Smithsonian Astrophysical Observation", "SAO 210915"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.41309394),
        dec: Angle.Degrees(-33.78355820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17610"},
        {"Hipparcos Number", "HIP 13106"},
        {"Geneva Identification System", "GEN# +1.00017610"},
        {"Smithsonian Astrophysical Observation", "SAO 193924"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.12898368),
        dec: Angle.Degrees(-33.78297278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21433"},
        {"Hipparcos Number", "HIP 16014"},
        {"Smithsonian Astrophysical Observation", "SAO 194294"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.54831906),
        dec: Angle.Degrees(-33.78262034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62431"},
        {"Hipparcos Number", "HIP 37567"},
        {"Smithsonian Astrophysical Observation", "SAO 198330"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.65759620),
        dec: Angle.Degrees(-33.78085697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22594"},
        {"Hipparcos Number", "HIP 16851"},
        {"Geneva Identification System", "GEN# +1.00022594"},
        {"Smithsonian Astrophysical Observation", "SAO 194399"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.21412023),
        dec: Angle.Degrees(-33.78071194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198232"},
        {"Hipparcos Number", "HIP 102831"},
        {"Geneva Identification System", "GEN# +1.00198232"},
        {"Smithsonian Astrophysical Observation", "SAO 212472"},
        {"Wilson Evans Batten Catalogue", "WEB 18651"},
    },
    visualMagnitude: 4.89,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.49199793),
        dec: Angle.Degrees(-33.77967320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106374"},
        {"Hipparcos Number", "HIP 59681"},
        {"Renson", "Renson 30790"},
        {"Smithsonian Astrophysical Observation", "SAO 203263"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.57550127),
        dec: Angle.Degrees(-33.77912144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61738"},
        {"Hipparcos Number", "HIP 37290"},
        {"Smithsonian Astrophysical Observation", "SAO 198249"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.85353178),
        dec: Angle.Degrees(-33.77911424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208828"},
        {"Hipparcos Number", "HIP 108573"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.90764687),
        dec: Angle.Degrees(-33.77705757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40871",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40871"},
        {"Smithsonian Astrophysical Observation", "SAO 199100"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.09775946),
        dec: Angle.Degrees(-33.77596923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108025",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108025"},
        {"Smithsonian Astrophysical Observation", "SAO 213362"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.26924400),
        dec: Angle.Degrees(-33.77522392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128223"},
        {"Hipparcos Number", "HIP 71444"},
        {"Smithsonian Astrophysical Observation", "SAO 205752"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.16607653),
        dec: Angle.Degrees(-33.77496496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119871"},
        {"Hipparcos Number", "HIP 67222"},
        {"Geneva Identification System", "GEN# +1.00119871"},
        {"Smithsonian Astrophysical Observation", "SAO 204826"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.61996073),
        dec: Angle.Degrees(-33.77419497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161329"},
        {"Hipparcos Number", "HIP 86967"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.59052874),
        dec: Angle.Degrees(-33.77164539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212963"},
        {"Hipparcos Number", "HIP 110945"},
        {"Geneva Identification System", "GEN# +1.00212963"},
        {"Smithsonian Astrophysical Observation", "SAO 213851"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.17632028),
        dec: Angle.Degrees(-33.77074721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175072"},
        {"Hipparcos Number", "HIP 92846"},
        {"Smithsonian Astrophysical Observation", "SAO 210712"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.78133347),
        dec: Angle.Degrees(-33.77040209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154195"},
        {"Hipparcos Number", "HIP 83612"},
        {"Smithsonian Astrophysical Observation", "SAO 208386"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.34319074),
        dec: Angle.Degrees(-33.77001290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209984"},
        {"Hipparcos Number", "HIP 109246"},
        {"Smithsonian Astrophysical Observation", "SAO 213568"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.97228361),
        dec: Angle.Degrees(-33.76743210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83609",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83609"},
        {"Smithsonian Astrophysical Observation", "SAO 208385"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.33618940),
        dec: Angle.Degrees(-33.76701485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195283"},
        {"Hipparcos Number", "HIP 101261"},
        {"Smithsonian Astrophysical Observation", "SAO 212199"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.88330179),
        dec: Angle.Degrees(-33.76662212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129946"},
        {"Hipparcos Number", "HIP 72235"},
        {"Geneva Identification System", "GEN# +1.00129946"},
        {"Smithsonian Astrophysical Observation", "SAO 205923"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.59341748),
        dec: Angle.Degrees(-33.76612679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119091"},
        {"Hipparcos Number", "HIP 66824"},
        {"Geneva Identification System", "GEN# +1.00119091"},
        {"Smithsonian Astrophysical Observation", "SAO 204738"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.43811304),
        dec: Angle.Degrees(-33.76574315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91690"},
        {"Hipparcos Number", "HIP 51767"},
        {"Fundamental Katalog 5th Edition", "FK5 4939"},
        {"Smithsonian Astrophysical Observation", "SAO 201526"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.66794567),
        dec: Angle.Degrees(-33.76496907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14036"},
        {"Hipparcos Number", "HIP 10517"},
        {"Geneva Identification System", "GEN# +1.00014036"},
        {"Smithsonian Astrophysical Observation", "SAO 193607"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.87822405),
        dec: Angle.Degrees(-33.76450607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9065"},
        {"Hipparcos Number", "HIP 6888"},
        {"Geneva Identification System", "GEN# +1.00009065"},
        {"Smithsonian Astrophysical Observation", "SAO 193136"},
        {"Wilson Evans Batten Catalogue", "WEB 1502"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.18131331),
        dec: Angle.Degrees(-33.76389007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158198"},
        {"Hipparcos Number", "HIP 85588"},
        {"Geneva Identification System", "GEN# +1.00158198"},
        {"Smithsonian Astrophysical Observation", "SAO 208872"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.35656571),
        dec: Angle.Degrees(-33.76040355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96785"},
        {"Hipparcos Number", "HIP 54453"},
        {"Smithsonian Astrophysical Observation", "SAO 202122"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.11314538),
        dec: Angle.Degrees(-33.75923102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184373"},
        {"Hipparcos Number", "HIP 96355"},
        {"Smithsonian Astrophysical Observation", "SAO 211388"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.86894683),
        dec: Angle.Degrees(-33.75640836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183390"},
        {"Hipparcos Number", "HIP 95948"},
        {"Smithsonian Astrophysical Observation", "SAO 211322"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.68174728),
        dec: Angle.Degrees(-33.75487122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98367"},
        {"Hipparcos Number", "HIP 55230"},
        {"Smithsonian Astrophysical Observation", "SAO 202310"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.65614939),
        dec: Angle.Degrees(-33.75346871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5426"},
        {"Hipparcos Number", "HIP 4343"},
        {"Geneva Identification System", "GEN# +1.00005426"},
        {"Smithsonian Astrophysical Observation", "SAO 192821"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.92096785),
        dec: Angle.Degrees(-33.75304821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190180"},
        {"Hipparcos Number", "HIP 98898"},
        {"Geneva Identification System", "GEN# +1.00190180"},
        {"Smithsonian Astrophysical Observation", "SAO 211790"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.24994904),
        dec: Angle.Degrees(-33.75205089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38347",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38347"},
        {"Smithsonian Astrophysical Observation", "SAO 198522"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.80953159),
        dec: Angle.Degrees(-33.75033047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24374"},
        {"Hipparcos Number", "HIP 18036"},
        {"Geneva Identification System", "GEN# +1.00024374"},
        {"Smithsonian Astrophysical Observation", "SAO 194580"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.82492801),
        dec: Angle.Degrees(-33.74988287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33221"},
        {"Geneva Identification System", "GEN# -0.03303337"},
        {"Smithsonian Astrophysical Observation", "SAO 197347"},
        {"Wilson Evans Batten Catalogue", "WEB 6680"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.69973224),
        dec: Angle.Degrees(-33.74659100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -178.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109604"},
        {"Hipparcos Number", "HIP 61507"},
        {"Smithsonian Astrophysical Observation", "SAO 203624"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.03408047),
        dec: Angle.Degrees(-33.74612512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73476"},
        {"Hipparcos Number", "HIP 42302"},
        {"Geneva Identification System", "GEN# +1.00073476A"},
        {"Smithsonian Astrophysical Observation", "SAO 199436"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.37356569),
        dec: Angle.Degrees(-33.74558225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107122"},
        {"Hipparcos Number", "HIP 60072"},
        {"Geneva Identification System", "GEN# +1.00107122"},
        {"Smithsonian Astrophysical Observation", "SAO 203344"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.77350897),
        dec: Angle.Degrees(-33.74526936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217344"},
        {"Hipparcos Number", "HIP 113598"},
        {"Smithsonian Astrophysical Observation", "SAO 214237"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.11715894),
        dec: Angle.Degrees(-33.74469011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201849"},
        {"Hipparcos Number", "HIP 104753"},
        {"Smithsonian Astrophysical Observation", "SAO 212801"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.33142544),
        dec: Angle.Degrees(-33.74404049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150090"},
        {"Hipparcos Number", "HIP 81620"},
        {"Geneva Identification System", "GEN# +1.00150090"},
        {"Smithsonian Astrophysical Observation", "SAO 207903"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.05383712),
        dec: Angle.Degrees(-33.74355266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25254",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25254"},
        {"Smithsonian Astrophysical Observation", "SAO 195814"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.00841862),
        dec: Angle.Degrees(-33.74343217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62225"},
        {"Hipparcos Number", "HIP 37477"},
        {"Smithsonian Astrophysical Observation", "SAO 198302"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.39577761),
        dec: Angle.Degrees(-33.74045558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95221"},
        {"Hipparcos Number", "HIP 53699"},
        {"Geneva Identification System", "GEN# +1.00095221"},
        {"Smithsonian Astrophysical Observation", "SAO 201976"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.80726626),
        dec: Angle.Degrees(-33.73745399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155889"},
        {"Hipparcos Number", "HIP 84444"},
        {"Geneva Identification System", "GEN# +1.00155889J"},
        {"Smithsonian Astrophysical Observation", "SAO 208604"},
        {"Wilson Evans Batten Catalogue", "WEB 14254"},
    },
    visualMagnitude: 6.54,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.96145716),
        dec: Angle.Degrees(-33.73700101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6921"},
    },
    visualMagnitude: 11.71,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.28158678),
        dec: Angle.Degrees(-33.73548195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 207.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3918"},
        {"Hipparcos Number", "HIP 3257"},
        {"Smithsonian Astrophysical Observation", "SAO 192680"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.37137471),
        dec: Angle.Degrees(-33.73461478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62911"},
        {"Hipparcos Number", "HIP 37781"},
        {"Smithsonian Astrophysical Observation", "SAO 198384"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.19645138),
        dec: Angle.Degrees(-33.73201020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11934"},
        {"Hipparcos Number", "HIP 9034"},
        {"Smithsonian Astrophysical Observation", "SAO 193393"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.09238828),
        dec: Angle.Degrees(-33.73122713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15578",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Intan"},
        {"Henry Draper", "HD 20868"},
        {"Hipparcos Number", "HIP 15578"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.17703444),
        dec: Angle.Degrees(-33.73033714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 293.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7413"},
        {"Hipparcos Number", "HIP 5730"},
        {"Geneva Identification System", "GEN# +1.00007413"},
        {"Smithsonian Astrophysical Observation", "SAO 192992"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.42115746),
        dec: Angle.Degrees(-33.72993137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151470"},
        {"Hipparcos Number", "HIP 82299"},
        {"Smithsonian Astrophysical Observation", "SAO 208061"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.24036661),
        dec: Angle.Degrees(-33.72885705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57299"},
        {"Hipparcos Number", "HIP 35463"},
        {"Fundamental Katalog 5th Edition", "FK5 2566"},
        {"Geneva Identification System", "GEN# +1.00057299"},
        {"Smithsonian Astrophysical Observation", "SAO 197842"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.80706646),
        dec: Angle.Degrees(-33.72714600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40496"},
        {"Geneva Identification System", "GEN# -0.03304756"},
    },
    visualMagnitude: 11.08,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.02446106),
        dec: Angle.Degrees(-33.72421935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212325"},
        {"Hipparcos Number", "HIP 110579"},
        {"Smithsonian Astrophysical Observation", "SAO 213789"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.03043896),
        dec: Angle.Degrees(-33.72320146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100157"},
        {"Hipparcos Number", "HIP 56208"},
        {"Smithsonian Astrophysical Observation", "SAO 202527"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.84206613),
        dec: Angle.Degrees(-33.71812768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158320"},
        {"Hipparcos Number", "HIP 85641"},
        {"Geneva Identification System", "GEN# +1.00158320"},
        {"Smithsonian Astrophysical Observation", "SAO 208881"},
        {"Wilson Evans Batten Catalogue", "WEB 14452"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.52349119),
        dec: Angle.Degrees(-33.71636014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136548"},
        {"Hipparcos Number", "HIP 75239"},
        {"Smithsonian Astrophysical Observation", "SAO 206569"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.61276832),
        dec: Angle.Degrees(-33.71622732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4769",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4769"},
        {"Geneva Identification System", "GEN# +6.20035043"},
        {"Geneva Identification System 2", "GEN# +6.20021410"},
    },
    visualMagnitude: 12.63,
    bvColour: -0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.32323552),
        dec: Angle.Degrees(-33.71258608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64256"},
    },
    visualMagnitude: 10.94,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.55439941),
        dec: Angle.Degrees(-33.71024178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57009"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.31943075),
        dec: Angle.Degrees(-33.70921693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144455"},
        {"Hipparcos Number", "HIP 78973"},
        {"Smithsonian Astrophysical Observation", "SAO 207342"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.82219440),
        dec: Angle.Degrees(-33.70886864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94303",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94303"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.92392390),
        dec: Angle.Degrees(-33.70867265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34897"},
        {"Hipparcos Number", "HIP 24824"},
        {"Geneva Identification System", "GEN# +1.00034897"},
        {"Smithsonian Astrophysical Observation", "SAO 195748"},
        {"Wilson Evans Batten Catalogue", "WEB 4806"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.82214757),
        dec: Angle.Degrees(-33.70810532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219912"},
        {"Hipparcos Number", "HIP 115178"},
        {"Geneva Identification System", "GEN# +1.00219912"},
        {"Smithsonian Astrophysical Observation", "SAO 214459"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.92965523),
        dec: Angle.Degrees(-33.70796023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87343",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87343"},
        {"Geneva Identification System", "GEN# +1.00162102C"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)50, 51.8200),
        dec: Angle.DegreesMinutesSeconds((int)-33, (int)42, 27.700)
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
    primaryId: "HIP 106663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205446"},
        {"Hipparcos Number", "HIP 106663"},
        {"Smithsonian Astrophysical Observation", "SAO 213126"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.06113613),
        dec: Angle.Degrees(-33.70757645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171474"},
        {"Hipparcos Number", "HIP 91218"},
        {"Smithsonian Astrophysical Observation", "SAO 210364"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.11667169),
        dec: Angle.Degrees(-33.70709456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117052"},
        {"Hipparcos Number", "HIP 65701"},
        {"Geneva Identification System", "GEN# +1.00117052"},
        {"Smithsonian Astrophysical Observation", "SAO 204501"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.06209568),
        dec: Angle.Degrees(-33.70616551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162102"},
        {"Hipparcos Number", "HIP 87345"},
        {"Geneva Identification System", "GEN# +1.00162102A"},
        {"Smithsonian Astrophysical Observation", "SAO 209340"},
        {"Wilson Evans Batten Catalogue", "WEB 14738"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.71809592),
        dec: Angle.Degrees(-33.70566613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97529"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.33288188),
        dec: Angle.Degrees(-33.70417866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158619"},
        {"Hipparcos Number", "HIP 85786"},
        {"Geneva Identification System", "GEN# +1.00158619"},
        {"Smithsonian Astrophysical Observation", "SAO 208921"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.94735241),
        dec: Angle.Degrees(-33.70308126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189245"},
        {"Hipparcos Number", "HIP 98470"},
        {"Geneva Identification System", "GEN# +1.00189245"},
        {"Smithsonian Astrophysical Observation", "SAO 211724"},
        {"Wilson Evans Batten Catalogue", "WEB 17382"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.08399517),
        dec: Angle.Degrees(-33.70274870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -289.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151240"},
        {"Hipparcos Number", "HIP 82201"},
        {"Geneva Identification System", "GEN# +1.00151240"},
        {"Smithsonian Astrophysical Observation", "SAO 208034"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.90112029),
        dec: Angle.Degrees(-33.69953849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122999"},
        {"Hipparcos Number", "HIP 68844"},
        {"Geneva Identification System", "GEN# +1.00122999"},
        {"Smithsonian Astrophysical Observation", "SAO 205170"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.44883557),
        dec: Angle.Degrees(-33.69756583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209081"},
        {"Hipparcos Number", "HIP 108726"},
        {"Smithsonian Astrophysical Observation", "SAO 213480"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.36976156),
        dec: Angle.Degrees(-33.69519552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77788"},
        {"Hipparcos Number", "HIP 44472"},
        {"Smithsonian Astrophysical Observation", "SAO 199933"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.91030017),
        dec: Angle.Degrees(-33.69440820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83827"},
        {"Hipparcos Number", "HIP 47441"},
        {"Smithsonian Astrophysical Observation", "SAO 200611"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.02840137),
        dec: Angle.Degrees(-33.69384443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113370"},
        {"Hipparcos Number", "HIP 63727"},
        {"Smithsonian Astrophysical Observation", "SAO 204081"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.89501742),
        dec: Angle.Degrees(-33.69163624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193766"},
        {"Hipparcos Number", "HIP 100546"},
        {"Geneva Identification System", "GEN# +1.00193766"},
        {"Smithsonian Astrophysical Observation", "SAO 212066"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.81466299),
        dec: Angle.Degrees(-33.69088752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86049"},
        {"Hipparcos Number", "HIP 48646"},
        {"Geneva Identification System", "GEN# +1.00086049"},
        {"Smithsonian Astrophysical Observation", "SAO 200866"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.79492081),
        dec: Angle.Degrees(-33.69067150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 318179"},
        {"Hipparcos Number", "HIP 86558"},
        {"Smithsonian Astrophysical Observation", "SAO 209141"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.33101806),
        dec: Angle.Degrees(-33.69066398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104004"},
        {"Hipparcos Number", "HIP 58404"},
        {"Geneva Identification System", "GEN# +1.00104004"},
        {"Smithsonian Astrophysical Observation", "SAO 202998"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.62642393),
        dec: Angle.Degrees(-33.69007277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -231.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211766"},
        {"Hipparcos Number", "HIP 110262"},
        {"Geneva Identification System", "GEN# +1.00211766"},
        {"Smithsonian Astrophysical Observation", "SAO 213743"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.01738941),
        dec: Angle.Degrees(-33.68775188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78679"},
        {"Hipparcos Number", "HIP 44867"},
        {"Smithsonian Astrophysical Observation", "SAO 200017"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.12658588),
        dec: Angle.Degrees(-33.68757500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87080"},
        {"Hipparcos Number", "HIP 49166"},
        {"Geneva Identification System", "GEN# +1.00087080"},
        {"Smithsonian Astrophysical Observation", "SAO 200983"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.50376850),
        dec: Angle.Degrees(-33.68531078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105314",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105314"},
        {"Smithsonian Astrophysical Observation", "SAO 212907"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.94677389),
        dec: Angle.Degrees(-33.68414818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112262"},
        {"Hipparcos Number", "HIP 63102"},
        {"Smithsonian Astrophysical Observation", "SAO 203942"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.92537622),
        dec: Angle.Degrees(-33.68349615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90546"},
        {"Hipparcos Number", "HIP 51123"},
        {"Smithsonian Astrophysical Observation", "SAO 201395"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.66641411),
        dec: Angle.Degrees(-33.68316806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79732"},
        {"Hipparcos Number", "HIP 45373"},
        {"Smithsonian Astrophysical Observation", "SAO 200146"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.69852641),
        dec: Angle.Degrees(-33.68235640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207142"},
        {"Hipparcos Number", "HIP 107609"},
        {"Geneva Identification System", "GEN# +1.00207142"},
        {"Smithsonian Astrophysical Observation", "SAO 213291"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.93635965),
        dec: Angle.Degrees(-33.68181162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132116"},
        {"Hipparcos Number", "HIP 73267"},
        {"Geneva Identification System", "GEN# +1.00132116"},
        {"Smithsonian Astrophysical Observation", "SAO 206151"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.60883866),
        dec: Angle.Degrees(-33.68078914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106410"},
        {"Hipparcos Number", "HIP 59695"},
        {"Smithsonian Astrophysical Observation", "SAO 203266"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.62381426),
        dec: Angle.Degrees(-33.68012633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208432"},
        {"Hipparcos Number", "HIP 108335"},
        {"Smithsonian Astrophysical Observation", "SAO 213425"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.22912905),
        dec: Angle.Degrees(-33.67974435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205872"},
        {"Hipparcos Number", "HIP 106907"},
        {"Geneva Identification System", "GEN# +1.00205872"},
        {"Smithsonian Astrophysical Observation", "SAO 213168"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.77527499),
        dec: Angle.Degrees(-33.67875173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48959",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48959"},
        {"Smithsonian Astrophysical Observation", "SAO 200934"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.81224334),
        dec: Angle.Degrees(-33.67772856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38077"},
        {"Hipparcos Number", "HIP 26810"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.39786115),
        dec: Angle.Degrees(-33.67738579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16503"},
        {"Hipparcos Number", "HIP 12263"},
        {"Smithsonian Astrophysical Observation", "SAO 193826"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.47195031),
        dec: Angle.Degrees(-33.67727756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221431"},
        {"Hipparcos Number", "HIP 116170"},
        {"Geneva Identification System", "GEN# +1.00221431"},
        {"Renson", "Renson 60690"},
        {"Smithsonian Astrophysical Observation", "SAO 214608"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.07698207),
        dec: Angle.Degrees(-33.67584099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147314"},
        {"Hipparcos Number", "HIP 80220"},
        {"Smithsonian Astrophysical Observation", "SAO 207603"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.64192374),
        dec: Angle.Degrees(-33.67532671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155888"},
        {"Hipparcos Number", "HIP 84435"},
        {"Geneva Identification System", "GEN# +1.00155888"},
        {"Smithsonian Astrophysical Observation", "SAO 208601"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.94045497),
        dec: Angle.Degrees(-33.67363824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78454"},
        {"Hipparcos Number", "HIP 44760"},
        {"Smithsonian Astrophysical Observation", "SAO 199997"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.83543079),
        dec: Angle.Degrees(-33.67311975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219493"},
        {"Hipparcos Number", "HIP 114896"},
        {"Smithsonian Astrophysical Observation", "SAO 214422"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.09319374),
        dec: Angle.Degrees(-33.67275259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82148"},
        {"Hipparcos Number", "HIP 46521"},
        {"Smithsonian Astrophysical Observation", "SAO 200417"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.32541728),
        dec: Angle.Degrees(-33.67252544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90814"},
        {"Hipparcos Number", "HIP 51288"},
        {"Smithsonian Astrophysical Observation", "SAO 201426"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.14546232),
        dec: Angle.Degrees(-33.67225092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178054"},
        {"Hipparcos Number", "HIP 94028"},
        {"Smithsonian Astrophysical Observation", "SAO 210974"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.14865951),
        dec: Angle.Degrees(-33.67171712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203489"},
        {"Hipparcos Number", "HIP 105620"},
        {"Geneva Identification System", "GEN# +1.00203489"},
        {"Smithsonian Astrophysical Observation", "SAO 212967"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.88532627),
        dec: Angle.Degrees(-33.67105528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108992"},
        {"Hipparcos Number", "HIP 61122"},
        {"Smithsonian Astrophysical Observation", "SAO 203556"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.89651117),
        dec: Angle.Degrees(-33.67032765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98404"},
        {"Hipparcos Number", "HIP 55253"},
        {"Smithsonian Astrophysical Observation", "SAO 202314"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.74014452),
        dec: Angle.Degrees(-33.66932085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49375"},
        {"Hipparcos Number", "HIP 32479"},
        {"Smithsonian Astrophysical Observation", "SAO 197198"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.68113424),
        dec: Angle.Degrees(-33.66889466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203393"},
        {"Hipparcos Number", "HIP 105566"},
        {"Geneva Identification System", "GEN# +1.00203393"},
        {"Smithsonian Astrophysical Observation", "SAO 212956"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.71316532),
        dec: Angle.Degrees(-33.66819859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86598"},
        {"Hipparcos Number", "HIP 48915"},
        {"Geneva Identification System", "GEN# +1.00086598"},
        {"Smithsonian Astrophysical Observation", "SAO 200923"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.68054137),
        dec: Angle.Degrees(-33.66710155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40051"},
        {"Hipparcos Number", "HIP 27967"},
        {"Smithsonian Astrophysical Observation", "SAO 196306"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.73810408),
        dec: Angle.Degrees(-33.66576726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159162"},
        {"Hipparcos Number", "HIP 86001"},
        {"Smithsonian Astrophysical Observation", "SAO 208973"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.65919474),
        dec: Angle.Degrees(-33.66366253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221633"},
        {"Hipparcos Number", "HIP 116306"},
        {"Smithsonian Astrophysical Observation", "SAO 214627"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.47619334),
        dec: Angle.Degrees(-33.66330529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62496"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.10041538),
        dec: Angle.Degrees(-33.65805065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115873"},
        {"Hipparcos Number", "HIP 65097"},
        {"Smithsonian Astrophysical Observation", "SAO 204369"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.12504069),
        dec: Angle.Degrees(-33.65776860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92804"},
        {"Hipparcos Number", "HIP 52384"},
        {"Celescope Catalog", "CEL 3651"},
        {"Geneva Identification System", "GEN# +1.00092804"},
        {"Smithsonian Astrophysical Observation", "SAO 201660"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.61101987),
        dec: Angle.Degrees(-33.65567927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188915"},
        {"Hipparcos Number", "HIP 98220"},
        {"Wilson Evans Batten Catalogue", "WEB 17325"},
    },
    visualMagnitude: 10.82,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.40030967),
        dec: Angle.Degrees(-01.88636350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118987"},
        {"Hipparcos Number", "HIP 66771"},
        {"Geneva Identification System", "GEN# +1.00118987"},
        {"Smithsonian Astrophysical Observation", "SAO 204726"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.28987954),
        dec: Angle.Degrees(-33.65528326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21704"},
        {"Hipparcos Number", "HIP 16215"},
        {"Smithsonian Astrophysical Observation", "SAO 194326"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.22770744),
        dec: Angle.Degrees(-33.65528088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172195"},
        {"Hipparcos Number", "HIP 91556"},
        {"Smithsonian Astrophysical Observation", "SAO 210433"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.07416262),
        dec: Angle.Degrees(-33.65459358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158393"},
        {"Hipparcos Number", "HIP 85680"},
        {"Geneva Identification System", "GEN# +1.00158393"},
        {"Smithsonian Astrophysical Observation", "SAO 208895"},
        {"Wilson Evans Batten Catalogue", "WEB 14457"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.63900179),
        dec: Angle.Degrees(-33.65440170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80802"},
        {"Hipparcos Number", "HIP 45857"},
        {"Smithsonian Astrophysical Observation", "SAO 200264"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.23821665),
        dec: Angle.Degrees(-33.65278855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128908"},
        {"Hipparcos Number", "HIP 71750"},
        {"Geneva Identification System", "GEN# +1.00128908"},
        {"Smithsonian Astrophysical Observation", "SAO 205819"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.14354734),
        dec: Angle.Degrees(-33.65261158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216087"},
        {"Hipparcos Number", "HIP 112786"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.60616784),
        dec: Angle.Degrees(-33.65211618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89315"},
        {"Hipparcos Number", "HIP 50409"},
        {"Smithsonian Astrophysical Observation", "SAO 201252"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.39316061),
        dec: Angle.Degrees(-33.65110518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149272"},
        {"Hipparcos Number", "HIP 81194"},
        {"Smithsonian Astrophysical Observation", "SAO 207790"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.76848798),
        dec: Angle.Degrees(-33.65014934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16437"},
        {"Hipparcos Number", "HIP 12219"},
        {"Smithsonian Astrophysical Observation", "SAO 193818"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.33723032),
        dec: Angle.Degrees(-33.64923698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199410"},
        {"Hipparcos Number", "HIP 103481"},
        {"Smithsonian Astrophysical Observation", "SAO 212580"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.48601963),
        dec: Angle.Degrees(-33.64894001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7386"},
        {"Geneva Identification System", "GEN# -0.03400614"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.79239180),
        dec: Angle.Degrees(-33.64725206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 391.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30423"},
        {"Hipparcos Number", "HIP 22164"},
        {"Smithsonian Astrophysical Observation", "SAO 195279"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.52763960),
        dec: Angle.Degrees(-33.64659635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29211"},
        {"Hipparcos Number", "HIP 21322"},
        {"Fundamental Katalog 5th Edition", "FK5 4411"},
        {"Geneva Identification System", "GEN# +1.00029211"},
        {"Smithsonian Astrophysical Observation", "SAO 195133"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.65356583),
        dec: Angle.Degrees(-33.64620575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72300"},
        {"Hipparcos Number", "HIP 41754"},
        {"Geneva Identification System", "GEN# +1.00072300"},
        {"Smithsonian Astrophysical Observation", "SAO 199315"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.71142471),
        dec: Angle.Degrees(-33.64475420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224045"},
        {"Hipparcos Number", "HIP 117885"},
        {"Smithsonian Astrophysical Observation", "SAO 214856"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.68071834),
        dec: Angle.Degrees(-33.64287648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134574"},
        {"Hipparcos Number", "HIP 74357"},
        {"Geneva Identification System", "GEN# +1.00134574"},
        {"Smithsonian Astrophysical Observation", "SAO 206385"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.94100798),
        dec: Angle.Degrees(-33.63884859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205912"},
        {"Hipparcos Number", "HIP 106936"},
        {"Smithsonian Astrophysical Observation", "SAO 213176"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.86297289),
        dec: Angle.Degrees(-33.63804441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209668"},
        {"Hipparcos Number", "HIP 109075"},
        {"Smithsonian Astrophysical Observation", "SAO 213539"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.44671992),
        dec: Angle.Degrees(-33.63729314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194272"},
        {"Hipparcos Number", "HIP 100773"},
        {"Smithsonian Astrophysical Observation", "SAO 212115"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.48534286),
        dec: Angle.Degrees(-33.63593680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72316"},
        {"Hipparcos Number", "HIP 41763"},
        {"Renson", "Renson 20000"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.74384328),
        dec: Angle.Degrees(-33.63441682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129217"},
        {"Hipparcos Number", "HIP 71893"},
        {"Smithsonian Astrophysical Observation", "SAO 205847"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.56826890),
        dec: Angle.Degrees(-33.63374422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22771",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22771"},
    },
    visualMagnitude: 11.02,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.47762360),
        dec: Angle.Degrees(-33.63345883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 197.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32130"},
        {"Geneva Identification System", "GEN# -0.03303165"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.65160271),
        dec: Angle.Degrees(-33.63200837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89751"},
        {"Hipparcos Number", "HIP 50669"},
        {"Smithsonian Astrophysical Observation", "SAO 201299"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.20411630),
        dec: Angle.Degrees(-33.63063041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163121"},
        {"Hipparcos Number", "HIP 87791"},
        {"Geneva Identification System", "GEN# +1.00163121"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.00529890),
        dec: Angle.Degrees(-33.62802366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220894"},
        {"Hipparcos Number", "HIP 115803"},
        {"Geneva Identification System", "GEN# +1.00220894"},
        {"Smithsonian Astrophysical Observation", "SAO 214557"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.90685296),
        dec: Angle.Degrees(-33.62776332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -219.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131140"},
        {"Hipparcos Number", "HIP 72802"},
        {"Geneva Identification System", "GEN# +1.00131140"},
        {"Smithsonian Astrophysical Observation", "SAO 206041"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.21378164),
        dec: Angle.Degrees(-33.62728603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141556"},
        {"Hipparcos Number", "HIP 77634"},
        {"Fundamental Katalog 5th Edition", "FK5 586"},
        {"Geneva Identification System", "GEN# +1.00141556"},
        {"Renson", "Renson 40190"},
        {"Smithsonian Astrophysical Observation", "SAO 207040"},
        {"Wilson Evans Batten Catalogue", "WEB 13135"},
    },
    visualMagnitude: 3.97,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.73975730),
        dec: Angle.Degrees(-33.62710488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3261"},
        {"Geneva Identification System", "GEN# -0.03400239"},
    },
    visualMagnitude: 10.58,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.37798776),
        dec: Angle.Degrees(-33.62495401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -348.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -249.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218775"},
        {"Hipparcos Number", "HIP 114466"},
        {"Smithsonian Astrophysical Observation", "SAO 214366"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.73084328),
        dec: Angle.Degrees(-33.62413938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56602"},
        {"Hipparcos Number", "HIP 35176"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.05325149),
        dec: Angle.Degrees(-33.62412645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170959"},
        {"Hipparcos Number", "HIP 90989"},
        {"Geneva Identification System", "GEN# +1.00170959"},
        {"Smithsonian Astrophysical Observation", "SAO 210303"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.39088117),
        dec: Angle.Degrees(-33.62216599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211118"},
        {"Hipparcos Number", "HIP 109906"},
        {"Smithsonian Astrophysical Observation", "SAO 213674"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.90052677),
        dec: Angle.Degrees(-33.62172772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29626"},
        {"Geneva Identification System", "GEN# -0.03302824"},
        {"Smithsonian Astrophysical Observation", "SAO 196619"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.64647012),
        dec: Angle.Degrees(-33.62047113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 156.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105918"},
        {"Hipparcos Number", "HIP 59435"},
        {"Smithsonian Astrophysical Observation", "SAO 203215"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.87348476),
        dec: Angle.Degrees(-33.62001475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14508"},
        {"Hipparcos Number", "HIP 10851"},
        {"Smithsonian Astrophysical Observation", "SAO 193642"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.91743287),
        dec: Angle.Degrees(-33.61959656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127097"},
        {"Hipparcos Number", "HIP 70926"},
        {"Smithsonian Astrophysical Observation", "SAO 205621"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.56393997),
        dec: Angle.Degrees(-33.61899801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162816"},
        {"Hipparcos Number", "HIP 87664"},
        {"Geneva Identification System", "GEN# +1.00162816"},
        {"Smithsonian Astrophysical Observation", "SAO 209445"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.60067453),
        dec: Angle.Degrees(-33.61838353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199620"},
        {"Hipparcos Number", "HIP 103605"},
        {"Geneva Identification System", "GEN# +1.00199620"},
        {"Smithsonian Astrophysical Observation", "SAO 212597"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.87115097),
        dec: Angle.Degrees(-33.61624230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28387",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28387"},
        {"Smithsonian Astrophysical Observation", "SAO 196390"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.94519311),
        dec: Angle.Degrees(-33.61574392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80417"},
        {"Hipparcos Number", "HIP 45673"},
        {"Smithsonian Astrophysical Observation", "SAO 200220"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.66581757),
        dec: Angle.Degrees(-33.61572328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11125"},
        {"Hipparcos Number", "HIP 8436"},
        {"Smithsonian Astrophysical Observation", "SAO 193311"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.18646100),
        dec: Angle.Degrees(-33.61536560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131119"},
        {"Hipparcos Number", "HIP 72797"},
        {"Geneva Identification System", "GEN# +1.00131119"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.19654580),
        dec: Angle.Degrees(-33.61465111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44896"},
        {"Hipparcos Number", "HIP 30338"},
        {"Geneva Identification System", "GEN# +1.00044896"},
        {"Smithsonian Astrophysical Observation", "SAO 196752"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.72403307),
        dec: Angle.Degrees(-33.61458125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194026"},
        {"Hipparcos Number", "HIP 100647"},
        {"Smithsonian Astrophysical Observation", "SAO 212089"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.12463944),
        dec: Angle.Degrees(-33.61401537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30549"},
        {"Hipparcos Number", "HIP 22244"},
        {"Geneva Identification System", "GEN# +1.00030549"},
        {"Smithsonian Astrophysical Observation", "SAO 195292"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.82121170),
        dec: Angle.Degrees(-33.61394039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81020",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81020"},
        {"Geneva Identification System", "GEN# -0.00103209"},
    },
    visualMagnitude: 10.28,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.20159159),
        dec: Angle.Degrees(-01.74791898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92430"},
        {"Hipparcos Number", "HIP 52199"},
        {"Smithsonian Astrophysical Observation", "SAO 201615"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.96937388),
        dec: Angle.Degrees(-33.61279776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133274"},
        {"Hipparcos Number", "HIP 73763"},
        {"Smithsonian Astrophysical Observation", "SAO 206265"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.17759076),
        dec: Angle.Degrees(-33.61203555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111548"},
        {"Hipparcos Number", "HIP 62656"},
        {"Smithsonian Astrophysical Observation", "SAO 203855"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.58196274),
        dec: Angle.Degrees(-33.61010129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155273"},
        {"Hipparcos Number", "HIP 84134"},
        {"Smithsonian Astrophysical Observation", "SAO 208519"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.99880610),
        dec: Angle.Degrees(-33.61000257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158443"},
        {"Hipparcos Number", "HIP 85701"},
        {"Geneva Identification System", "GEN# +1.00158443"},
        {"Smithsonian Astrophysical Observation", "SAO 208899"},
        {"Wilson Evans Batten Catalogue", "WEB 14464"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.70158461),
        dec: Angle.Degrees(-33.60989818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153004"},
        {"Hipparcos Number", "HIP 83059"},
        {"Geneva Identification System", "GEN# +1.00153004"},
        {"Smithsonian Astrophysical Observation", "SAO 208246"},
        {"Wilson Evans Batten Catalogue", "WEB 14042"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.58227833),
        dec: Angle.Degrees(-33.60909191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6895"},
        {"Hipparcos Number", "HIP 5399"},
        {"Geneva Identification System", "GEN# +1.00006895"},
        {"Smithsonian Astrophysical Observation", "SAO 192953"},
        {"Wilson Evans Batten Catalogue", "WEB 1176"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.27394017),
        dec: Angle.Degrees(-33.60836341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127438"},
        {"Hipparcos Number", "HIP 71091"},
        {"Geneva Identification System", "GEN# +1.00127438"},
        {"Smithsonian Astrophysical Observation", "SAO 205664"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.07334354),
        dec: Angle.Degrees(-33.60665427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101169"},
        {"Hipparcos Number", "HIP 56772"},
        {"Smithsonian Astrophysical Observation", "SAO 202656"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.58721188),
        dec: Angle.Degrees(-33.60566461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197730"},
        {"Hipparcos Number", "HIP 102533"},
        {"Geneva Identification System", "GEN# +1.00197730"},
        {"Smithsonian Astrophysical Observation", "SAO 212423"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.66577243),
        dec: Angle.Degrees(-33.60408110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44443"},
        {"Smithsonian Astrophysical Observation", "SAO 199925"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.81927138),
        dec: Angle.Degrees(-33.60405394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143197"},
        {"Hipparcos Number", "HIP 78398"},
        {"Smithsonian Astrophysical Observation", "SAO 207217"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.07721690),
        dec: Angle.Degrees(-33.60239131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83292"},
        {"Hipparcos Number", "HIP 47144"},
        {"Smithsonian Astrophysical Observation", "SAO 200542"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.10163973),
        dec: Angle.Degrees(-33.60141903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70263"},
        {"Hipparcos Number", "HIP 40812"},
        {"Smithsonian Astrophysical Observation", "SAO 199088"},
    },
    visualMagnitude: 9.03,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.94026823),
        dec: Angle.Degrees(-33.60110848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77737"},
        {"Hipparcos Number", "HIP 44442"},
        {"Smithsonian Astrophysical Observation", "SAO 199924"},
    },
    visualMagnitude: 7.15,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.81719658),
        dec: Angle.Degrees(-33.60066242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174058"},
        {"Hipparcos Number", "HIP 92427"},
        {"Geneva Identification System", "GEN# +1.00174058"},
        {"Smithsonian Astrophysical Observation", "SAO 210614"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.53921870),
        dec: Angle.Degrees(-33.59800184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173968"},
        {"Hipparcos Number", "HIP 92392"},
        {"Smithsonian Astrophysical Observation", "SAO 210606"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.42124910),
        dec: Angle.Degrees(-33.59782023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167071"},
        {"Hipparcos Number", "HIP 89423"},
        {"Geneva Identification System", "GEN# +1.00167071"},
        {"Smithsonian Astrophysical Observation", "SAO 209907"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.75249427),
        dec: Angle.Degrees(-33.59751809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119090"},
        {"Hipparcos Number", "HIP 66825"},
        {"Geneva Identification System", "GEN# +1.00119090"},
        {"Smithsonian Astrophysical Observation", "SAO 204739"},
        {"Wilson Evans Batten Catalogue", "WEB 11781"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.43992948),
        dec: Angle.Degrees(-33.59738643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23969"},
        {"Hipparcos Number", "HIP 17742"},
        {"Geneva Identification System", "GEN# +1.00023969"},
        {"Smithsonian Astrophysical Observation", "SAO 194539"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.99294488),
        dec: Angle.Degrees(-33.59596825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57482"},
        {"Hipparcos Number", "HIP 35540"},
        {"Smithsonian Astrophysical Observation", "SAO 197861"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.01271995),
        dec: Angle.Degrees(-33.59482193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44136"},
        {"Hipparcos Number", "HIP 29980"},
        {"Smithsonian Astrophysical Observation", "SAO 196674"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.66532907),
        dec: Angle.Degrees(-33.59442763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102412"},
        {"Hipparcos Number", "HIP 57496"},
        {"Smithsonian Astrophysical Observation", "SAO 202803"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.77426468),
        dec: Angle.Degrees(-33.59291579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32154",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32154"},
        {"Geneva Identification System", "GEN# -0.03303169"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.71920224),
        dec: Angle.Degrees(-33.59170857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67078"},
        {"Hipparcos Number", "HIP 39565"},
        {"Geneva Identification System", "GEN# +1.00067078"},
        {"Smithsonian Astrophysical Observation", "SAO 198776"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.26384242),
        dec: Angle.Degrees(-33.59137063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68684"},
    },
    visualMagnitude: 11.53,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.89773283),
        dec: Angle.Degrees(-33.59031904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145659"},
        {"Hipparcos Number", "HIP 79508"},
        {"Smithsonian Astrophysical Observation", "SAO 207467"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.36791994),
        dec: Angle.Degrees(-33.58852982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146313"},
        {"Hipparcos Number", "HIP 79793"},
        {"Smithsonian Astrophysical Observation", "SAO 207512"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.26211461),
        dec: Angle.Degrees(-33.58705021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32136"},
        {"Hipparcos Number", "HIP 23193"},
        {"Smithsonian Astrophysical Observation", "SAO 195460"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.87136314),
        dec: Angle.Degrees(-33.58681647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6403",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6403"},
        {"Smithsonian Astrophysical Observation", "SAO 193073"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.56033929),
        dec: Angle.Degrees(-33.58590185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209825"},
        {"Hipparcos Number", "HIP 109168"},
        {"Smithsonian Astrophysical Observation", "SAO 213550"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.70025081),
        dec: Angle.Degrees(-33.58471998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1088"},
        {"Hipparcos Number", "HIP 1203"},
        {"Geneva Identification System", "GEN# +1.00001088"},
        {"Smithsonian Astrophysical Observation", "SAO 192421"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.76469396),
        dec: Angle.Degrees(-33.58395324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44526"},
        {"Hipparcos Number", "HIP 30160"},
        {"Smithsonian Astrophysical Observation", "SAO 196715"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.19815548),
        dec: Angle.Degrees(-33.58325287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138046"},
        {"Hipparcos Number", "HIP 75941"},
        {"Smithsonian Astrophysical Observation", "SAO 206713"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.65941721),
        dec: Angle.Degrees(-33.58079470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94104"},
        {"Hipparcos Number", "HIP 53052"},
        {"Geneva Identification System", "GEN# +1.00094104"},
        {"Smithsonian Astrophysical Observation", "SAO 201828"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.81342473),
        dec: Angle.Degrees(-33.57987805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102849",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102849"},
        {"Smithsonian Astrophysical Observation", "SAO 212477"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.53722741),
        dec: Angle.Degrees(-33.57719410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2031",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2031"},
    },
    visualMagnitude: 10.68,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.43484441),
        dec: Angle.Degrees(-33.57676211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52521",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Macondo"},
        {"Henry Draper", "HD 93083"},
        {"Hipparcos Number", "HIP 52521"},
        {"Geneva Identification System", "GEN# +1.00093083"},
        {"Smithsonian Astrophysical Observation", "SAO 201693"},
        {"Wilson Evans Batten Catalogue", "WEB 9568"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.08741640),
        dec: Angle.Degrees(-33.57665467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20943"},
        {"Smithsonian Astrophysical Observation", "SAO 195061"},
    },
    visualMagnitude: 10.07,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.35328720),
        dec: Angle.Degrees(-33.57620387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25964"},
        {"Hipparcos Number", "HIP 19079"},
        {"Smithsonian Astrophysical Observation", "SAO 194752"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.35201245),
        dec: Angle.Degrees(-33.57569903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214912"},
        {"Hipparcos Number", "HIP 112077"},
        {"Smithsonian Astrophysical Observation", "SAO 214020"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.52121781),
        dec: Angle.Degrees(-33.57452827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56141"},
        {"Hipparcos Number", "HIP 34996"},
        {"Smithsonian Astrophysical Observation", "SAO 197735"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.61130619),
        dec: Angle.Degrees(-33.57060083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100893"},
        {"Hipparcos Number", "HIP 56620"},
        {"Geneva Identification System", "GEN# +1.00100893"},
        {"Smithsonian Astrophysical Observation", "SAO 202622"},
    },
    visualMagnitude: 5.71,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.14551817),
        dec: Angle.Degrees(-33.56997476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69002"},
        {"Hipparcos Number", "HIP 40291"},
        {"Geneva Identification System", "GEN# +1.00069002"},
        {"Smithsonian Astrophysical Observation", "SAO 198960"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.42104390),
        dec: Angle.Degrees(-33.56955241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67243"},
        {"Hipparcos Number", "HIP 39617"},
        {"Celescope Catalog", "CEL 2158"},
        {"Geneva Identification System", "GEN# +1.00067243A"},
        {"Smithsonian Astrophysical Observation", "SAO 198791"},
    },
    visualMagnitude: 6.15,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.43704092),
        dec: Angle.Degrees(-33.56944572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67264"},
        {"Hipparcos Number", "HIP 39620"},
        {"Geneva Identification System", "GEN# +1.00067264"},
        {"Renson", "Renson 18546"},
    },
    visualMagnitude: 8.66,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.44439450),
        dec: Angle.Degrees(-33.56924411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7303",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7303"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.50844783),
        dec: Angle.Degrees(-01.68574858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 174.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124264"},
        {"Hipparcos Number", "HIP 69459"},
        {"Geneva Identification System", "GEN# +1.00124264"},
        {"Smithsonian Astrophysical Observation", "SAO 205315"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.30741190),
        dec: Angle.Degrees(-33.56895724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78351"},
        {"Hipparcos Number", "HIP 44719"},
        {"Geneva Identification System", "GEN# +1.00078351"},
        {"Smithsonian Astrophysical Observation", "SAO 199983"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.68240777),
        dec: Angle.Degrees(-33.56840097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147873"},
        {"Hipparcos Number", "HIP 80486"},
        {"Geneva Identification System", "GEN# +1.00147873"},
        {"Smithsonian Astrophysical Observation", "SAO 207656"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.43819880),
        dec: Angle.Degrees(-33.56706750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10216"},
        {"Hipparcos Number", "HIP 7721"},
        {"Geneva Identification System", "GEN# +1.00010216"},
        {"Smithsonian Astrophysical Observation", "SAO 193229"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.83973192),
        dec: Angle.Degrees(-33.56477443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11629"},
        {"Hipparcos Number", "HIP 8824"},
        {"Smithsonian Astrophysical Observation", "SAO 193369"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.36242972),
        dec: Angle.Degrees(-33.56464387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41324",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41324"},
        {"Smithsonian Astrophysical Observation", "SAO 199214"},
    },
    visualMagnitude: 8.60,
    bvColour: 2.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.47170975),
        dec: Angle.Degrees(-33.56413850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165791"},
        {"Hipparcos Number", "HIP 88925"},
        {"Smithsonian Astrophysical Observation", "SAO 209772"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.28179196),
        dec: Angle.Degrees(-33.56382472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223598"},
        {"Hipparcos Number", "HIP 117598"},
        {"Smithsonian Astrophysical Observation", "SAO 214811"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.73468719),
        dec: Angle.Degrees(-33.56248376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107691"},
        {"Hipparcos Number", "HIP 60362"},
        {"Smithsonian Astrophysical Observation", "SAO 203407"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.65607257),
        dec: Angle.Degrees(-33.56079604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72628"},
        {"Hipparcos Number", "HIP 41918"},
        {"Smithsonian Astrophysical Observation", "SAO 199349"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.19499631),
        dec: Angle.Degrees(-33.55900899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211741"},
        {"Hipparcos Number", "HIP 110233"},
        {"Smithsonian Astrophysical Observation", "SAO 213736"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.94259449),
        dec: Angle.Degrees(-33.55744137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20895"},
        {"Hipparcos Number", "HIP 15606"},
        {"Smithsonian Astrophysical Observation", "SAO 194242"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.24239983),
        dec: Angle.Degrees(-33.55626067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96580"},
        {"Hipparcos Number", "HIP 54354"},
        {"Smithsonian Astrophysical Observation", "SAO 202102"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.80300189),
        dec: Angle.Degrees(-33.55497494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30424",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30424"},
        {"Smithsonian Astrophysical Observation", "SAO 196766"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.94832614),
        dec: Angle.Degrees(-33.55320883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155806"},
        {"Hipparcos Number", "HIP 84401"},
        {"Geneva Identification System", "GEN# +1.00155806"},
        {"Smithsonian Astrophysical Observation", "SAO 208585"},
        {"Wilson Evans Batten Catalogue", "WEB 14246"},
    },
    visualMagnitude: 5.60,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.83019699),
        dec: Angle.Degrees(-33.54841317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8474"},
        {"Hipparcos Number", "HIP 6477"},
        {"Smithsonian Astrophysical Observation", "SAO 193087"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.82145290),
        dec: Angle.Degrees(-33.54801250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170281"},
        {"Hipparcos Number", "HIP 90670"},
        {"Geneva Identification System", "GEN# +1.00170281"},
        {"Smithsonian Astrophysical Observation", "SAO 210233"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.50089824),
        dec: Angle.Degrees(-33.54774985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98220"},
        {"Hipparcos Number", "HIP 55165"},
        {"Geneva Identification System", "GEN# +1.00098220"},
        {"Smithsonian Astrophysical Observation", "SAO 202288"},
        {"Wilson Evans Batten Catalogue", "WEB 9944"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.41315066),
        dec: Angle.Degrees(-33.54633194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -332.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191304"},
        {"Hipparcos Number", "HIP 99399"},
        {"Smithsonian Astrophysical Observation", "SAO 211876"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.63216402),
        dec: Angle.Degrees(-33.54572098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144987"},
        {"Hipparcos Number", "HIP 79199"},
        {"Fundamental Katalog 5th Edition", "FK5 3277"},
        {"Geneva Identification System", "GEN# +1.00144987"},
        {"Smithsonian Astrophysical Observation", "SAO 207403"},
        {"Wilson Evans Batten Catalogue", "WEB 13392"},
    },
    visualMagnitude: 5.50,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.46919686),
        dec: Angle.Degrees(-33.54569572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21988"},
        {"Hipparcos Number", "HIP 16418"},
        {"Geneva Identification System", "GEN# +1.00021988"},
        {"Smithsonian Astrophysical Observation", "SAO 194353"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.85220235),
        dec: Angle.Degrees(-33.54565043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28686"},
        {"Hipparcos Number", "HIP 20977"},
        {"Smithsonian Astrophysical Observation", "SAO 195068"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.49007432),
        dec: Angle.Degrees(-33.54541689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137595"},
        {"Hipparcos Number", "HIP 75711"},
        {"Geneva Identification System", "GEN# +1.00137595"},
        {"Smithsonian Astrophysical Observation", "SAO 206669"},
        {"Wilson Evans Batten Catalogue", "WEB 12890"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.00955997),
        dec: Angle.Degrees(-33.54514687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199953"},
        {"Hipparcos Number", "HIP 103740"},
        {"Smithsonian Astrophysical Observation", "SAO 212637"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.33391705),
        dec: Angle.Degrees(-33.54415733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181998"},
        {"Hipparcos Number", "HIP 95358"},
        {"Geneva Identification System", "GEN# +1.00181998"},
        {"Smithsonian Astrophysical Observation", "SAO 211234"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.00681888),
        dec: Angle.Degrees(-33.54228913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207441"},
        {"Hipparcos Number", "HIP 107752"},
        {"Smithsonian Astrophysical Observation", "SAO 213323"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.42965382),
        dec: Angle.Degrees(-33.54156389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121983"},
        {"Hipparcos Number", "HIP 68372"},
        {"Geneva Identification System", "GEN# +1.00121983"},
        {"Smithsonian Astrophysical Observation", "SAO 205070"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.93062299),
        dec: Angle.Degrees(-33.53905878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41552"},
        {"Hipparcos Number", "HIP 28761"},
        {"Smithsonian Astrophysical Observation", "SAO 196461"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.08967750),
        dec: Angle.Degrees(-33.53868566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95556"},
        {"Hipparcos Number", "HIP 53870"},
        {"Smithsonian Astrophysical Observation", "SAO 202008"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.31997281),
        dec: Angle.Degrees(-33.53822820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34496"},
        {"Hipparcos Number", "HIP 24577"},
        {"Geneva Identification System", "GEN# +1.00034496"},
        {"Smithsonian Astrophysical Observation", "SAO 195705"},
        {"Wilson Evans Batten Catalogue", "WEB 4760"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.09938325),
        dec: Angle.Degrees(-33.53778852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82529"},
        {"Hipparcos Number", "HIP 46738"},
        {"Smithsonian Astrophysical Observation", "SAO 200460"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.89035179),
        dec: Angle.Degrees(-33.53767939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137095"},
        {"Hipparcos Number", "HIP 75486"},
        {"Smithsonian Astrophysical Observation", "SAO 206615"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.30517881),
        dec: Angle.Degrees(-33.53428318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6403"},
        {"Hipparcos Number", "HIP 5042"},
        {"Geneva Identification System", "GEN# +1.00006403J"},
        {"Smithsonian Astrophysical Observation", "SAO 192907"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.13586737),
        dec: Angle.Degrees(-33.53278805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201084"},
        {"Hipparcos Number", "HIP 104363"},
        {"Fundamental Katalog 5th Edition", "FK5 5861"},
        {"Smithsonian Astrophysical Observation", "SAO 212741"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.13411004),
        dec: Angle.Degrees(-33.53252018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36717"},
        {"Hipparcos Number", "HIP 25958"},
        {"Smithsonian Astrophysical Observation", "SAO 195937"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.07306983),
        dec: Angle.Degrees(-33.53076646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179904"},
        {"Hipparcos Number", "HIP 94663"},
        {"Geneva Identification System", "GEN# +1.00179904"},
        {"Smithsonian Astrophysical Observation", "SAO 211100"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.94469170),
        dec: Angle.Degrees(-33.53046188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168509"},
        {"Hipparcos Number", "HIP 89984"},
        {"Smithsonian Astrophysical Observation", "SAO 210033"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.39338283),
        dec: Angle.Degrees(-33.53025182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21898"},
        {"Hipparcos Number", "HIP 16344"},
        {"Smithsonian Astrophysical Observation", "SAO 194342"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.65941161),
        dec: Angle.Degrees(-33.53024489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344"},
        {"Hipparcos Number", "HIP 655"},
        {"Geneva Identification System", "GEN# +1.00000344"},
        {"Smithsonian Astrophysical Observation", "SAO 192367"},
    },
    visualMagnitude: 5.67,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.01465535),
        dec: Angle.Degrees(-33.52933371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114741",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114741"},
        {"Smithsonian Astrophysical Observation", "SAO 214400"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.65086400),
        dec: Angle.Degrees(-33.52771178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18252"},
        {"Hipparcos Number", "HIP 13569"},
        {"Renson", "Renson 4530"},
        {"Smithsonian Astrophysical Observation", "SAO 193981"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.70643981),
        dec: Angle.Degrees(-33.52489584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174074"},
        {"Hipparcos Number", "HIP 92430"},
        {"Smithsonian Astrophysical Observation", "SAO 210615"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.55017176),
        dec: Angle.Degrees(-33.52373195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180093"},
        {"Hipparcos Number", "HIP 94730"},
        {"Geneva Identification System", "GEN# +1.00180093"},
        {"Smithsonian Astrophysical Observation", "SAO 211117"},
        {"Wilson Evans Batten Catalogue", "WEB 16521"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.13650145),
        dec: Angle.Degrees(-33.52231593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188475"},
        {"Hipparcos Number", "HIP 98129"},
        {"Smithsonian Astrophysical Observation", "SAO 211672"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.15230004),
        dec: Angle.Degrees(-33.52155112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33561"},
        {"Hipparcos Number", "HIP 24018"},
        {"Smithsonian Astrophysical Observation", "SAO 195610"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.43704889),
        dec: Angle.Degrees(-33.52091457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124283"},
        {"Hipparcos Number", "HIP 69475"},
        {"Geneva Identification System", "GEN# +1.00124283"},
        {"Smithsonian Astrophysical Observation", "SAO 205320"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.34983145),
        dec: Angle.Degrees(-33.51820903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66643",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66643"},
    },
    visualMagnitude: 11.70,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.90744018),
        dec: Angle.Degrees(-01.59473828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -327.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134970"},
        {"Hipparcos Number", "HIP 74535"},
        {"Smithsonian Astrophysical Observation", "SAO 206432"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.45957461),
        dec: Angle.Degrees(-33.51790857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86652"},
        {"Hipparcos Number", "HIP 48946"},
        {"Geneva Identification System", "GEN# +1.00086652"},
        {"Smithsonian Astrophysical Observation", "SAO 200931"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.78378426),
        dec: Angle.Degrees(-33.51715100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -163.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153691"},
        {"Hipparcos Number", "HIP 83374"},
        {"Smithsonian Astrophysical Observation", "SAO 208331"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.59837565),
        dec: Angle.Degrees(-33.51613941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40078",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40078"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.79505353),
        dec: Angle.Degrees(-33.51589061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79614"},
        {"Hipparcos Number", "HIP 45326"},
        {"Geneva Identification System", "GEN# +1.00079614"},
        {"Smithsonian Astrophysical Observation", "SAO 200134"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.56378948),
        dec: Angle.Degrees(-33.51584252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117867"},
        {"Hipparcos Number", "HIP 66160"},
        {"Geneva Identification System", "GEN# +1.00117867"},
        {"Smithsonian Astrophysical Observation", "SAO 204595"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.42227964),
        dec: Angle.Degrees(-33.51306501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49555"},
        {"Hipparcos Number", "HIP 32550"},
        {"Smithsonian Astrophysical Observation", "SAO 197214"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.87088044),
        dec: Angle.Degrees(-33.51294259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208982"},
        {"Hipparcos Number", "HIP 108658"},
        {"Smithsonian Astrophysical Observation", "SAO 213469"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.17977702),
        dec: Angle.Degrees(-33.50831046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84727"},
        {"Hipparcos Number", "HIP 47950"},
        {"Smithsonian Astrophysical Observation", "SAO 200714"},
    },
    visualMagnitude: 6.94,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.56724285),
        dec: Angle.Degrees(-33.50825066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129854"},
        {"Hipparcos Number", "HIP 72185"},
        {"Geneva Identification System", "GEN# +1.00129854"},
        {"Smithsonian Astrophysical Observation", "SAO 205914"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.46993224),
        dec: Angle.Degrees(-33.50798767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61328"},
        {"Henry Draper 2", "HD 61329"},
        {"Hipparcos Number", "HIP 37099"},
        {"Smithsonian Astrophysical Observation", "SAO 198196"},
    },
    visualMagnitude: 9.55,
    bvColour: -0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.35514816),
        dec: Angle.Degrees(-33.50745632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152636"},
        {"Hipparcos Number", "HIP 82855"},
        {"Geneva Identification System", "GEN# +1.00152636"},
        {"Smithsonian Astrophysical Observation", "SAO 208205"},
        {"Wilson Evans Batten Catalogue", "WEB 14003"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.99059176),
        dec: Angle.Degrees(-33.50688932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112935"},
        {"Hipparcos Number", "HIP 63490"},
        {"Fundamental Katalog 5th Edition", "FK5 3038"},
        {"Geneva Identification System", "GEN# +1.00112935"},
        {"Smithsonian Astrophysical Observation", "SAO 204029"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.13628763),
        dec: Angle.Degrees(-33.50509249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160529"},
        {"Hipparcos Number", "HIP 86624"},
        {"Geneva Identification System", "GEN# +1.00160529"},
        {"Smithsonian Astrophysical Observation", "SAO 209151"},
        {"Wilson Evans Batten Catalogue", "WEB 14606"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.49594326),
        dec: Angle.Degrees(-33.50380442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53325",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53325"},
        {"Smithsonian Astrophysical Observation", "SAO 201881"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.60879550),
        dec: Angle.Degrees(-33.50252772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23380"},
        {"Hipparcos Number", "HIP 17391"},
        {"Geneva Identification System", "GEN# +1.00023380"},
        {"Smithsonian Astrophysical Observation", "SAO 194480"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.86607886),
        dec: Angle.Degrees(-33.50225816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41741"},
        {"Hipparcos Number", "HIP 28856"},
        {"Smithsonian Astrophysical Observation", "SAO 196482"},
    },
    visualMagnitude: 7.44,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.36838674),
        dec: Angle.Degrees(-33.50187500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12237"},
        {"Hipparcos Number", "HIP 9289"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.84233773),
        dec: Angle.Degrees(-33.50177505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114133"},
        {"Hipparcos Number", "HIP 64162"},
        {"Fundamental Katalog 5th Edition", "FK5 5163"},
        {"Smithsonian Astrophysical Observation", "SAO 204168"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.25333590),
        dec: Angle.Degrees(-33.50153153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22083"},
        {"Hipparcos Number", "HIP 16492"},
        {"Geneva Identification System", "GEN# +1.00022083"},
        {"Smithsonian Astrophysical Observation", "SAO 194363"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.09347773),
        dec: Angle.Degrees(-33.50099770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217737"},
        {"Hipparcos Number", "HIP 113831"},
        {"Geneva Identification System", "GEN# +1.00217737"},
        {"Smithsonian Astrophysical Observation", "SAO 214269"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.77874554),
        dec: Angle.Degrees(-33.50034375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154853"},
        {"Hipparcos Number", "HIP 83932"},
        {"Smithsonian Astrophysical Observation", "SAO 208477"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.33956466),
        dec: Angle.Degrees(-33.49954156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52"},
        {"Hipparcos Number", "HIP 449"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.34473977),
        dec: Angle.Degrees(-33.49941419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166745"},
        {"Hipparcos Number", "HIP 89321"},
        {"Geneva Identification System", "GEN# +1.00166745"},
        {"Smithsonian Astrophysical Observation", "SAO 209870"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.38885821),
        dec: Angle.Degrees(-33.49849100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -234.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53782"},
        {"Hipparcos Number", "HIP 34155"},
        {"Smithsonian Astrophysical Observation", "SAO 197546"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.24234009),
        dec: Angle.Degrees(-33.49653768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170280"},
        {"Hipparcos Number", "HIP 90671"},
        {"Geneva Identification System", "GEN# +1.00170280"},
        {"Smithsonian Astrophysical Observation", "SAO 210234"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.50861043),
        dec: Angle.Degrees(-33.49535673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212822"},
        {"Hipparcos Number", "HIP 110862"},
        {"Geneva Identification System", "GEN# +1.00212822"},
        {"Smithsonian Astrophysical Observation", "SAO 213833"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.91509484),
        dec: Angle.Degrees(-33.49432802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222284"},
        {"Hipparcos Number", "HIP 116733"},
        {"Smithsonian Astrophysical Observation", "SAO 214690"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.84945143),
        dec: Angle.Degrees(-33.49333626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 318015"},
        {"Hipparcos Number", "HIP 86163"},
        {"Geneva Identification System", "GEN# +4.35270023"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.11414460),
        dec: Angle.Degrees(-33.49328496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15062"},
        {"Hipparcos Number", "HIP 11245"},
        {"Smithsonian Astrophysical Observation", "SAO 193693"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.19443619),
        dec: Angle.Degrees(-33.49074144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72831"},
        {"Hipparcos Number", "HIP 42016"},
        {"Smithsonian Astrophysical Observation", "SAO 199371"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.47176788),
        dec: Angle.Degrees(-33.49023776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23358",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23358"},
    },
    visualMagnitude: 12.22,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.34355228),
        dec: Angle.Degrees(-33.49007708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85131"},
        {"Hipparcos Number", "HIP 48157"},
        {"Smithsonian Astrophysical Observation", "SAO 200766"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.24224300),
        dec: Angle.Degrees(-33.48951625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144945"},
        {"Hipparcos Number", "HIP 79189"},
        {"Smithsonian Astrophysical Observation", "SAO 207401"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.42644231),
        dec: Angle.Degrees(-33.48914660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90270"},
        {"Hipparcos Number", "HIP 50969"},
        {"Smithsonian Astrophysical Observation", "SAO 201363"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.16248233),
        dec: Angle.Degrees(-33.48850369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105643"},
        {"Hipparcos Number", "HIP 59293"},
        {"Smithsonian Astrophysical Observation", "SAO 203180"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.44906174),
        dec: Angle.Degrees(-33.48751971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197384"},
        {"Hipparcos Number", "HIP 102365"},
        {"Smithsonian Astrophysical Observation", "SAO 212394"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.11291079),
        dec: Angle.Degrees(-33.48748628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58326"},
        {"Hipparcos Number", "HIP 35877"},
        {"Smithsonian Astrophysical Observation", "SAO 197943"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.95267461),
        dec: Angle.Degrees(-33.48534268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53559"},
        {"Geneva Identification System", "GEN# -0.03207774"},
        {"Smithsonian Astrophysical Observation", "SAO 201940"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.34695720),
        dec: Angle.Degrees(-33.48443493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 216.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6478"},
        {"Smithsonian Astrophysical Observation", "SAO 193088"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.82289812),
        dec: Angle.Degrees(-33.48283863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113027"},
        {"Hipparcos Number", "HIP 63530"},
        {"Smithsonian Astrophysical Observation", "SAO 204041"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.27796498),
        dec: Angle.Degrees(-33.48002915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118238"},
        {"Hipparcos Number", "HIP 66358"},
        {"Geneva Identification System", "GEN# +1.00118238"},
        {"Smithsonian Astrophysical Observation", "SAO 204640"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.03467459),
        dec: Angle.Degrees(-33.47910314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59414"},
        {"Hipparcos Number", "HIP 36316"},
        {"Smithsonian Astrophysical Observation", "SAO 198033"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.13289803),
        dec: Angle.Degrees(-33.47824034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52414"},
        {"Hipparcos Number", "HIP 33669"},
        {"Smithsonian Astrophysical Observation", "SAO 197446"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.92306572),
        dec: Angle.Degrees(-33.47575413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152384"},
        {"Hipparcos Number", "HIP 82714"},
        {"Geneva Identification System", "GEN# +1.00152384"},
        {"Smithsonian Astrophysical Observation", "SAO 208169"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.61000347),
        dec: Angle.Degrees(-33.47528556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27894"},
    },
    visualMagnitude: 11.79,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.53694445),
        dec: Angle.Degrees(-33.47497676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25177"},
        {"Hipparcos Number", "HIP 18587"},
        {"Smithsonian Astrophysical Observation", "SAO 194669"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.66627433),
        dec: Angle.Degrees(-33.47482161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218652"},
        {"Hipparcos Number", "HIP 114392"},
        {"Smithsonian Astrophysical Observation", "SAO 214351"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.51765380),
        dec: Angle.Degrees(-33.47413621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30757"},
        {"Hipparcos Number", "HIP 22368"},
        {"Geneva Identification System", "GEN# +1.00030757"},
        {"Smithsonian Astrophysical Observation", "SAO 195316"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.23636988),
        dec: Angle.Degrees(-33.47239238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214341"},
        {"Hipparcos Number", "HIP 111733"},
        {"Renson", "Renson 59380"},
        {"Smithsonian Astrophysical Observation", "SAO 213969"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.50899437),
        dec: Angle.Degrees(-33.47016202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48381"},
        {"Hipparcos Number", "HIP 32045"},
        {"Geneva Identification System", "GEN# +1.00048381"},
        {"Smithsonian Astrophysical Observation", "SAO 197096"},
        {"Wilson Evans Batten Catalogue", "WEB 6469"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.42896041),
        dec: Angle.Degrees(-33.46974413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1207"},
        {"Hipparcos Number", "HIP 1299"},
        {"Geneva Identification System", "GEN# +1.00001207"},
        {"Smithsonian Astrophysical Observation", "SAO 192432"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.08276576),
        dec: Angle.Degrees(-33.46932824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105815"},
        {"Hipparcos Number", "HIP 59374"},
        {"Smithsonian Astrophysical Observation", "SAO 203202"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.71865316),
        dec: Angle.Degrees(-33.46806351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10188"},
        {"Hipparcos Number", "HIP 7693"},
        {"Geneva Identification System", "GEN# +1.00010188"},
        {"Smithsonian Astrophysical Observation", "SAO 193227"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.75809520),
        dec: Angle.Degrees(-33.46788316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119810"},
        {"Hipparcos Number", "HIP 67179"},
        {"Smithsonian Astrophysical Observation", "SAO 204820"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.51192103),
        dec: Angle.Degrees(-33.46751684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140940"},
        {"Hipparcos Number", "HIP 77357"},
        {"Smithsonian Astrophysical Observation", "SAO 206978"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.87281806),
        dec: Angle.Degrees(-33.46717854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185690"},
        {"Hipparcos Number", "HIP 96889"},
        {"Smithsonian Astrophysical Observation", "SAO 211481"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.42434732),
        dec: Angle.Degrees(-33.46611145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172950"},
        {"Hipparcos Number", "HIP 91931"},
        {"Smithsonian Astrophysical Observation", "SAO 210512"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.11273946),
        dec: Angle.Degrees(-33.46584972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52703"},
        {"Hipparcos Number", "HIP 33774"},
        {"Geneva Identification System", "GEN# +1.00052703"},
        {"Smithsonian Astrophysical Observation", "SAO 197475"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.20724583),
        dec: Angle.Degrees(-33.46572030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57062"},
        {"Hipparcos Number", "HIP 35361"},
        {"Geneva Identification System", "GEN# +1.00057062"},
        {"Smithsonian Astrophysical Observation", "SAO 197820"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.55417078),
        dec: Angle.Degrees(-33.46480085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31745"},
        {"Hipparcos Number", "HIP 23007"},
        {"Smithsonian Astrophysical Observation", "SAO 195422"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.23047569),
        dec: Angle.Degrees(-33.46366523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4633"},
        {"Hipparcos Number", "HIP 3731"},
        {"Smithsonian Astrophysical Observation", "SAO 192748"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.97855203),
        dec: Angle.Degrees(-33.46360111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60646"},
        {"Hipparcos Number", "HIP 36807"},
        {"Geneva Identification System", "GEN# +1.00060646"},
        {"Smithsonian Astrophysical Observation", "SAO 198138"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.55360344),
        dec: Angle.Degrees(-33.46358395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15581"},
    },
    visualMagnitude: 11.49,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.18149432),
        dec: Angle.Degrees(-33.46357357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -539.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215203"},
        {"Hipparcos Number", "HIP 112237"},
        {"Smithsonian Astrophysical Observation", "SAO 214049"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.00376599),
        dec: Angle.Degrees(-33.46184393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49960",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49960"},
        {"Smithsonian Astrophysical Observation", "SAO 201157"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.00395885),
        dec: Angle.Degrees(-33.45702865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71623"},
        {"Hipparcos Number", "HIP 41445"},
        {"Geneva Identification System", "GEN# +1.00071623"},
        {"Smithsonian Astrophysical Observation", "SAO 199244"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.80686479),
        dec: Angle.Degrees(-33.45685336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13132"},
        {"Hipparcos Number", "HIP 9919"},
        {"Fundamental Katalog 5th Edition", "FK5 4193"},
        {"Smithsonian Astrophysical Observation", "SAO 193521"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.91905893),
        dec: Angle.Degrees(-33.45419087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74615"},
        {"Hipparcos Number", "HIP 42843"},
        {"Smithsonian Astrophysical Observation", "SAO 199551"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.94758947),
        dec: Angle.Degrees(-33.45409325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74647"},
        {"Hipparcos Number", "HIP 42859"},
        {"Smithsonian Astrophysical Observation", "SAO 199559"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.00433192),
        dec: Angle.Degrees(-33.45280677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223691"},
        {"Hipparcos Number", "HIP 117668"},
        {"Geneva Identification System", "GEN# +1.00223691"},
        {"Smithsonian Astrophysical Observation", "SAO 214827"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.95288364),
        dec: Angle.Degrees(-33.45264740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206641"},
        {"Hipparcos Number", "HIP 107318"},
        {"Smithsonian Astrophysical Observation", "SAO 213245"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.05851716),
        dec: Angle.Degrees(-33.45201550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23589"},
        {"Hipparcos Number", "HIP 17518"},
        {"Smithsonian Astrophysical Observation", "SAO 194503"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.26034547),
        dec: Angle.Degrees(-33.45179151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220480"},
        {"Hipparcos Number", "HIP 115536"},
        {"Smithsonian Astrophysical Observation", "SAO 214522"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.05525456),
        dec: Angle.Degrees(-33.45178761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103563"},
        {"Hipparcos Number", "HIP 58142"},
        {"Smithsonian Astrophysical Observation", "SAO 202946"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.86742244),
        dec: Angle.Degrees(-33.45154401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17970"},
        {"Hipparcos Number", "HIP 13388"},
        {"Cincinnati Publication", "Ci 20 191"},
        {"Geneva Identification System", "GEN# +1.00017970"},
        {"Smithsonian Astrophysical Observation", "SAO 193955"},
        {"Wilson Evans Batten Catalogue", "WEB 2680"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.08077811),
        dec: Angle.Degrees(-33.45065753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 431.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101387"},
        {"Hipparcos Number", "HIP 56908"},
        {"Smithsonian Astrophysical Observation", "SAO 202686"},
    },
    visualMagnitude: 6.84,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.98776759),
        dec: Angle.Degrees(-33.44984133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116548"},
        {"Hipparcos Number", "HIP 65450"},
        {"Smithsonian Astrophysical Observation", "SAO 204441"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.20636373),
        dec: Angle.Degrees(-33.44891965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175391"},
        {"Hipparcos Number", "HIP 92988"},
        {"Smithsonian Astrophysical Observation", "SAO 210738"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.16155096),
        dec: Angle.Degrees(-33.44844825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56974"},
        {"Hipparcos Number", "HIP 35330"},
        {"Smithsonian Astrophysical Observation", "SAO 197813"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.46810831),
        dec: Angle.Degrees(-33.44447817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95963"},
        {"Hipparcos Number", "HIP 54074"},
        {"Smithsonian Astrophysical Observation", "SAO 202048"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.97165259),
        dec: Angle.Degrees(-33.44446460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110285"},
        {"Hipparcos Number", "HIP 61912"},
        {"Geneva Identification System", "GEN# +1.00110285"},
        {"Smithsonian Astrophysical Observation", "SAO 203711"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.32502252),
        dec: Angle.Degrees(-33.44434600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46714"},
    },
    visualMagnitude: 11.21,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.83901967),
        dec: Angle.Degrees(-33.44316109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156382"},
        {"Hipparcos Number", "HIP 84685"},
        {"Geneva Identification System", "GEN# +1.00156382"},
        {"Smithsonian Astrophysical Observation", "SAO 208666"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.68294705),
        dec: Angle.Degrees(-33.44158690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220535"},
        {"Hipparcos Number", "HIP 115571"},
        {"Smithsonian Astrophysical Observation", "SAO 214527"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.16082115),
        dec: Angle.Degrees(-33.44045218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22277"},
        {"Hipparcos Number", "HIP 16622"},
        {"Smithsonian Astrophysical Observation", "SAO 194374"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.47380128),
        dec: Angle.Degrees(-33.43723237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44762"},
        {"Hipparcos Number", "HIP 30277"},
        {"Geneva Identification System", "GEN# +1.00044762"},
        {"Smithsonian Astrophysical Observation", "SAO 196735"},
        {"Wilson Evans Batten Catalogue", "WEB 6021"},
    },
    visualMagnitude: 3.85,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.52852147),
        dec: Angle.Degrees(-33.43627251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40319"},
        {"Hipparcos Number", "HIP 28112"},
        {"Smithsonian Astrophysical Observation", "SAO 196332"},
    },
    visualMagnitude: 7.30,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.13312835),
        dec: Angle.Degrees(-33.43453971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82611"},
        {"Hipparcos Number", "HIP 46792"},
        {"Smithsonian Astrophysical Observation", "SAO 200471"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.02059808),
        dec: Angle.Degrees(-33.43353348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11564"},
        {"Hipparcos Number", "HIP 8773"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.21260166),
        dec: Angle.Degrees(-33.43309999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30070"},
        {"Hipparcos Number", "HIP 21939"},
        {"Geneva Identification System", "GEN# +1.00030070"},
        {"Smithsonian Astrophysical Observation", "SAO 195249"},
        {"Wilson Evans Batten Catalogue", "WEB 4216"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.74416350),
        dec: Angle.Degrees(-33.43268462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196737"},
        {"Hipparcos Number", "HIP 102014"},
        {"Fundamental Katalog 5th Edition", "FK5 1540"},
        {"Geneva Identification System", "GEN# +1.00196737"},
        {"Smithsonian Astrophysical Observation", "SAO 212333"},
        {"Wilson Evans Batten Catalogue", "WEB 18441"},
    },
    visualMagnitude: 5.47,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.08255226),
        dec: Angle.Degrees(-33.43193038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99360",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99360"},
        {"Smithsonian Astrophysical Observation", "SAO 211872"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.50959382),
        dec: Angle.Degrees(-33.43178821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39027"},
        {"Hipparcos Number", "HIP 27415"},
        {"Geneva Identification System", "GEN# +1.00039027"},
        {"Smithsonian Astrophysical Observation", "SAO 196189"},
        {"Wilson Evans Batten Catalogue", "WEB 5384"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.08203349),
        dec: Angle.Degrees(-33.43173611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145133"},
        {"Hipparcos Number", "HIP 79257"},
        {"Geneva Identification System", "GEN# +1.00145133"},
        {"Smithsonian Astrophysical Observation", "SAO 207418"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.64719566),
        dec: Angle.Degrees(-33.43153354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29711"},
        {"Hipparcos Number", "HIP 21686"},
        {"Geneva Identification System", "GEN# +1.00029711"},
        {"Smithsonian Astrophysical Observation", "SAO 195205"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.83218857),
        dec: Angle.Degrees(-33.43023621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20299"},
        {"Hipparcos Number", "HIP 15103"},
        {"Geneva Identification System", "GEN# +1.00020299"},
        {"Smithsonian Astrophysical Observation", "SAO 194180"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.70670170),
        dec: Angle.Degrees(-33.42925857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222801"},
        {"Hipparcos Number", "HIP 117057"},
        {"Geneva Identification System", "GEN# +1.00222801"},
        {"Smithsonian Astrophysical Observation", "SAO 214741"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.96579446),
        dec: Angle.Degrees(-33.42774418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61989"},
        {"Hipparcos Number", "HIP 37390"},
        {"Geneva Identification System", "GEN# +1.00061989"},
        {"Smithsonian Astrophysical Observation", "SAO 198283"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.12729278),
        dec: Angle.Degrees(-33.42651709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 139.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63214"},
        {"Hipparcos Number", "HIP 37928"},
        {"Smithsonian Astrophysical Observation", "SAO 198418"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.59208015),
        dec: Angle.Degrees(-33.42534037)
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
    primaryId: "HIP 26959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38297"},
        {"Hipparcos Number", "HIP 26959"},
        {"Fundamental Katalog 5th Edition", "FK5 4525"},
        {"Smithsonian Astrophysical Observation", "SAO 196114"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.81048500),
        dec: Angle.Degrees(-33.42498514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76436"},
        {"Hipparcos Number", "HIP 43785"},
        {"Smithsonian Astrophysical Observation", "SAO 199781"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.77055900),
        dec: Angle.Degrees(-33.42466372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79664"},
        {"Hipparcos Number", "HIP 45350"},
        {"Renson", "Renson 22640"},
        {"Smithsonian Astrophysical Observation", "SAO 200140"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.61889891),
        dec: Angle.Degrees(-33.42361432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12146"},
        {"Hipparcos Number", "HIP 9214"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.62273681),
        dec: Angle.Degrees(-33.41936339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86267"},
        {"Hipparcos Number", "HIP 48748"},
        {"Fundamental Katalog 5th Edition", "FK5 2796"},
        {"Geneva Identification System", "GEN# +1.00086267"},
        {"Smithsonian Astrophysical Observation", "SAO 200889"},
    },
    visualMagnitude: 5.83,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.14779191),
        dec: Angle.Degrees(-33.41854978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2644"},
        {"Hipparcos Number", "HIP 2334"},
        {"Smithsonian Astrophysical Observation", "SAO 192568"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.46439646),
        dec: Angle.Degrees(-33.41787057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45553"},
        {"Hipparcos Number", "HIP 30664"},
        {"Geneva Identification System", "GEN# +1.00045553"},
        {"Smithsonian Astrophysical Observation", "SAO 196825"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.66079080),
        dec: Angle.Degrees(-33.41555680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93465"},
        {"Hipparcos Number", "HIP 52741"},
        {"Smithsonian Astrophysical Observation", "SAO 201739"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.73781851),
        dec: Angle.Degrees(-33.41460493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156976"},
        {"Hipparcos Number", "HIP 84966"},
        {"Smithsonian Astrophysical Observation", "SAO 208726"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.49234874),
        dec: Angle.Degrees(-33.41455381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37960",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37960"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.71607546),
        dec: Angle.Degrees(-01.15717231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32709",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32709"},
        {"Smithsonian Astrophysical Observation", "SAO 197251"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.36176947),
        dec: Angle.Degrees(-33.41334237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188922"},
        {"Hipparcos Number", "HIP 98341"},
        {"Smithsonian Astrophysical Observation", "SAO 211706"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.71232970),
        dec: Angle.Degrees(-33.41283921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3084"},
        {"Hipparcos Number", "HIP 2674"},
        {"Smithsonian Astrophysical Observation", "SAO 192611"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.47077979),
        dec: Angle.Degrees(-33.41165011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114434",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114434"},
        {"Smithsonian Astrophysical Observation", "SAO 214359"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.63310943),
        dec: Angle.Degrees(-33.41075632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12085"},
        {"Hipparcos Number", "HIP 9146"},
        {"Geneva Identification System", "GEN# +1.00012085"},
        {"Smithsonian Astrophysical Observation", "SAO 193410"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.46769889),
        dec: Angle.Degrees(-33.41003634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34311"},
        {"Hipparcos Number", "HIP 24469"},
        {"Smithsonian Astrophysical Observation", "SAO 195685"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.77508823),
        dec: Angle.Degrees(-33.40950947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90958"},
        {"Hipparcos Number", "HIP 51366"},
        {"Smithsonian Astrophysical Observation", "SAO 201440"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.37143961),
        dec: Angle.Degrees(-33.40882904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163868"},
        {"Hipparcos Number", "HIP 88123"},
        {"Geneva Identification System", "GEN# +1.00163868"},
        {"Smithsonian Astrophysical Observation", "SAO 209569"},
    },
    visualMagnitude: 7.35,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.98511572),
        dec: Angle.Degrees(-33.40832056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10385"},
    },
    visualMagnitude: 10.87,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.43930313),
        dec: Angle.Degrees(-33.40593805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 174.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13739",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13739"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.22741573),
        dec: Angle.Degrees(-33.40581514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 168.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106098"},
        {"Hipparcos Number", "HIP 59531"},
        {"Smithsonian Astrophysical Observation", "SAO 203233"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.12015242),
        dec: Angle.Degrees(-33.40501581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82315"},
        {"Hipparcos Number", "HIP 46616"},
        {"Smithsonian Astrophysical Observation", "SAO 200435"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.58224979),
        dec: Angle.Degrees(-33.40386685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2673"},
        {"Hipparcos Number", "HIP 2361"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.54124371),
        dec: Angle.Degrees(-33.40340389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204648"},
        {"Hipparcos Number", "HIP 106225"},
        {"Smithsonian Astrophysical Observation", "SAO 213059"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.74619959),
        dec: Angle.Degrees(-33.40275651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185539"},
        {"Hipparcos Number", "HIP 96829"},
        {"Smithsonian Astrophysical Observation", "SAO 211472"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.21463201),
        dec: Angle.Degrees(-33.40210729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84234"},
        {"Hipparcos Number", "HIP 47647"},
        {"Smithsonian Astrophysical Observation", "SAO 200654"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.71609532),
        dec: Angle.Degrees(-33.40202072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76484"},
        {"Hipparcos Number", "HIP 43815"},
        {"Geneva Identification System", "GEN# +1.00076484"},
        {"Smithsonian Astrophysical Observation", "SAO 199790"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.85559572),
        dec: Angle.Degrees(-33.40177658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142383"},
        {"Hipparcos Number", "HIP 77981"},
        {"Smithsonian Astrophysical Observation", "SAO 207118"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.87089703),
        dec: Angle.Degrees(-33.40122787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38056"},
        {"Hipparcos Number", "HIP 26796"},
        {"Geneva Identification System", "GEN# +1.00038056"},
        {"Smithsonian Astrophysical Observation", "SAO 196088"},
    },
    visualMagnitude: 6.35,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.36217359),
        dec: Angle.Degrees(-33.40071160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60498"},
        {"Hipparcos Number", "HIP 36741"},
        {"Celescope Catalog", "CEL 1929"},
        {"Geneva Identification System", "GEN# +1.00060498"},
        {"Smithsonian Astrophysical Observation", "SAO 198121"},
        {"Wilson Evans Batten Catalogue", "WEB 7304"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.35498024),
        dec: Angle.Degrees(-33.39991003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88963"},
        {"Hipparcos Number", "HIP 50215"},
        {"Smithsonian Astrophysical Observation", "SAO 201207"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.76690676),
        dec: Angle.Degrees(-33.39893674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35044"},
        {"Hipparcos Number", "HIP 24917"},
        {"Smithsonian Astrophysical Observation", "SAO 195764"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.09698230),
        dec: Angle.Degrees(-33.39875067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75254"},
        {"Hipparcos Number", "HIP 43186"},
        {"Smithsonian Astrophysical Observation", "SAO 199629"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.96468903),
        dec: Angle.Degrees(-33.39837297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10447"},
        {"Hipparcos Number", "HIP 7866"},
        {"Geneva Identification System", "GEN# +1.00010447"},
        {"Smithsonian Astrophysical Observation", "SAO 193253"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.30053527),
        dec: Angle.Degrees(-33.39824155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31719"},
        {"Hipparcos Number", "HIP 22988"},
        {"Smithsonian Astrophysical Observation", "SAO 195420"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.19262384),
        dec: Angle.Degrees(-33.39797761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119789"},
        {"Hipparcos Number", "HIP 67176"},
        {"Smithsonian Astrophysical Observation", "SAO 204818"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.49984324),
        dec: Angle.Degrees(-33.39648822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84042"},
        {"Hipparcos Number", "HIP 47530"},
        {"Smithsonian Astrophysical Observation", "SAO 200635"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.35345925),
        dec: Angle.Degrees(-33.39631574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51880"},
        {"Hipparcos Number", "HIP 33488"},
        {"Smithsonian Astrophysical Observation", "SAO 197408"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.41332754),
        dec: Angle.Degrees(-33.39631440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167686"},
        {"Hipparcos Number", "HIP 89660"},
        {"Geneva Identification System", "GEN# +1.00167686"},
        {"Renson", "Renson 47060"},
        {"Smithsonian Astrophysical Observation", "SAO 209966"},
    },
    visualMagnitude: 7.01,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.46272398),
        dec: Angle.Degrees(-33.39614939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24913",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24913"},
        {"Smithsonian Astrophysical Observation", "SAO 195762"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.09283563),
        dec: Angle.Degrees(-33.39430675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61006"},
        {"Hipparcos Number", "HIP 36955"},
        {"Geneva Identification System", "GEN# +1.00061006"},
        {"Smithsonian Astrophysical Observation", "SAO 198168"},
        {"Wilson Evans Batten Catalogue", "WEB 7333"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.96092239),
        dec: Angle.Degrees(-33.39254466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4984",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4984"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.97244080),
        dec: Angle.Degrees(-01.05007534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123429"},
        {"Hipparcos Number", "HIP 69076"},
        {"Smithsonian Astrophysical Observation", "SAO 205221"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.09030234),
        dec: Angle.Degrees(-33.39224776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23165"},
        {"Hipparcos Number", "HIP 17252"},
        {"Smithsonian Astrophysical Observation", "SAO 194457"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.41569327),
        dec: Angle.Degrees(-33.39218173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87638"},
        {"Hipparcos Number", "HIP 49434"},
        {"Geneva Identification System", "GEN# +1.00087638"},
        {"Smithsonian Astrophysical Observation", "SAO 201040"},
        {"Wilson Evans Batten Catalogue", "WEB 9131"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.38675655),
        dec: Angle.Degrees(-33.39215244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143149"},
        {"Hipparcos Number", "HIP 78359"},
        {"Smithsonian Astrophysical Observation", "SAO 207205"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.97941291),
        dec: Angle.Degrees(-33.38528447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61666",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61666"},
    },
    visualMagnitude: 10.28,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.62098526),
        dec: Angle.Degrees(-33.38500922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173044"},
        {"Hipparcos Number", "HIP 91978"},
        {"Smithsonian Astrophysical Observation", "SAO 210522"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.21165335),
        dec: Angle.Degrees(-33.38376970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9923"},
        {"Hipparcos Number", "HIP 7481"},
        {"Geneva Identification System", "GEN# +1.00009923"},
        {"Smithsonian Astrophysical Observation", "SAO 193204"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.08523612),
        dec: Angle.Degrees(-33.38304559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71740"},
        {"Hipparcos Number", "HIP 41491"},
        {"Smithsonian Astrophysical Observation", "SAO 199258"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.92704438),
        dec: Angle.Degrees(-33.38301443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116506"},
        {"Smithsonian Astrophysical Observation", "SAO 214648"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.12829172),
        dec: Angle.Degrees(-33.38290116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152159"},
        {"Hipparcos Number", "HIP 82597"},
        {"Smithsonian Astrophysical Observation", "SAO 208134"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.27864490),
        dec: Angle.Degrees(-33.38273688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26142"},
        {"Hipparcos Number", "HIP 19198"},
        {"Geneva Identification System", "GEN# +1.00026142"},
        {"Smithsonian Astrophysical Observation", "SAO 194769"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.71841638),
        dec: Angle.Degrees(-33.38074701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101973"},
        {"Hipparcos Number", "HIP 57227"},
        {"Geneva Identification System", "GEN# +1.00101973"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.01357937),
        dec: Angle.Degrees(-33.37974620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -182.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220426"},
        {"Hipparcos Number", "HIP 115501"},
        {"Geneva Identification System", "GEN# +1.00220426"},
        {"Smithsonian Astrophysical Observation", "SAO 214515"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.94963423),
        dec: Angle.Degrees(-33.37870291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128691"},
        {"Hipparcos Number", "HIP 71647"},
        {"Geneva Identification System", "GEN# +1.00128691"},
        {"Smithsonian Astrophysical Observation", "SAO 205806"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.81830832),
        dec: Angle.Degrees(-33.37848375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138529"},
        {"Hipparcos Number", "HIP 76195"},
        {"Smithsonian Astrophysical Observation", "SAO 206762"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.46227896),
        dec: Angle.Degrees(-33.37644906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54643"},
        {"Hipparcos Number", "HIP 34432"},
        {"Geneva Identification System", "GEN# +1.00054643"},
        {"Smithsonian Astrophysical Observation", "SAO 197619"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.06886651),
        dec: Angle.Degrees(-33.37360217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212553"},
        {"Hipparcos Number", "HIP 110708"},
        {"Smithsonian Astrophysical Observation", "SAO 213811"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.45230791),
        dec: Angle.Degrees(-33.37194922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61872"},
        {"Smithsonian Astrophysical Observation", "SAO 203701"},
    },
    visualMagnitude: 10.41,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.19114812),
        dec: Angle.Degrees(-33.37154480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -185.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91417"},
        {"Hipparcos Number", "HIP 51629"},
        {"Smithsonian Astrophysical Observation", "SAO 201502"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.21049108),
        dec: Angle.Degrees(-33.36962646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53936"},
        {"Hipparcos Number", "HIP 34205"},
        {"Smithsonian Astrophysical Observation", "SAO 197555"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.39008010),
        dec: Angle.Degrees(-33.36750429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191073"},
        {"Hipparcos Number", "HIP 99286"},
        {"Geneva Identification System", "GEN# +1.00191073"},
        {"Smithsonian Astrophysical Observation", "SAO 211858"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.31391270),
        dec: Angle.Degrees(-33.36639504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194171"},
        {"Hipparcos Number", "HIP 100728"},
        {"Smithsonian Astrophysical Observation", "SAO 212101"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.32259965),
        dec: Angle.Degrees(-33.36465104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86048"},
        {"Hipparcos Number", "HIP 48647"},
        {"Fundamental Katalog 5th Edition", "FK5 4884"},
        {"Geneva Identification System", "GEN# +1.00086048"},
        {"Smithsonian Astrophysical Observation", "SAO 200868"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.79978994),
        dec: Angle.Degrees(-33.36332744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75120"},
        {"Smithsonian Astrophysical Observation", "SAO 206538"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.26419796),
        dec: Angle.Degrees(-33.36207449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6041"},
        {"Hipparcos Number", "HIP 4776"},
        {"Smithsonian Astrophysical Observation", "SAO 192871"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.34210216),
        dec: Angle.Degrees(-33.35992239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52931"},
        {"Hipparcos Number", "HIP 33849"},
        {"Smithsonian Astrophysical Observation", "SAO 197489"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.40048073),
        dec: Angle.Degrees(-33.35881754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141869"},
        {"Hipparcos Number", "HIP 77750"},
        {"Smithsonian Astrophysical Observation", "SAO 207074"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.14251332),
        dec: Angle.Degrees(-33.35641255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73521"},
        {"Hipparcos Number", "HIP 42322"},
        {"Celescope Catalog", "CEL 2719"},
        {"Smithsonian Astrophysical Observation", "SAO 199440"},
    },
    visualMagnitude: 8.89,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.42393480),
        dec: Angle.Degrees(-33.35637826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175418"},
        {"Hipparcos Number", "HIP 92998"},
        {"Smithsonian Astrophysical Observation", "SAO 210742"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.18823586),
        dec: Angle.Degrees(-33.35399779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178111"},
        {"Hipparcos Number", "HIP 94046"},
        {"Smithsonian Astrophysical Observation", "SAO 210981"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.20491935),
        dec: Angle.Degrees(-33.35352203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140126"},
        {"Hipparcos Number", "HIP 76989"},
        {"Smithsonian Astrophysical Observation", "SAO 206899"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.79934729),
        dec: Angle.Degrees(-33.35146320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181974"},
        {"Hipparcos Number", "HIP 95348"},
    },
    visualMagnitude: 9.62,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.97726735),
        dec: Angle.Degrees(-33.35136182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149071"},
        {"Hipparcos Number", "HIP 81088"},
        {"Smithsonian Astrophysical Observation", "SAO 207770"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.43743967),
        dec: Angle.Degrees(-33.34971430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123124"},
        {"Hipparcos Number", "HIP 68916"},
        {"Smithsonian Astrophysical Observation", "SAO 205186"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.62832346),
        dec: Angle.Degrees(-33.34931203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -292.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34216"},
        {"Hipparcos Number", "HIP 24418"},
        {"Geneva Identification System", "GEN# +1.00034216"},
        {"Smithsonian Astrophysical Observation", "SAO 195679"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.58305719),
        dec: Angle.Degrees(-33.34862506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19815"},
        {"Hipparcos Number", "HIP 14725"},
        {"Smithsonian Astrophysical Observation", "SAO 194126"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.54830867),
        dec: Angle.Degrees(-33.34821024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111750"},
        {"Hipparcos Number", "HIP 62766"},
        {"Smithsonian Astrophysical Observation", "SAO 203876"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.93502949),
        dec: Angle.Degrees(-33.34583880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29240"},
        {"Hipparcos Number", "HIP 21357"},
        {"Geneva Identification System", "GEN# +1.00029240"},
        {"Smithsonian Astrophysical Observation", "SAO 195140"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.73768179),
        dec: Angle.Degrees(-33.34558646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67778"},
        {"Hipparcos Number", "HIP 39828"},
        {"Celescope Catalog", "CEL 2171"},
        {"Geneva Identification System", "GEN# +1.00067778"},
        {"Smithsonian Astrophysical Observation", "SAO 198839"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.06028999),
        dec: Angle.Degrees(-33.34005765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54978"},
        {"Hipparcos Number", "HIP 34578"},
        {"Smithsonian Astrophysical Observation", "SAO 197646"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.42436980),
        dec: Angle.Degrees(-33.33913925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46281",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46281"},
        {"Smithsonian Astrophysical Observation", "SAO 200369"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.57177100),
        dec: Angle.Degrees(-33.33717647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123387"},
        {"Hipparcos Number", "HIP 69051"},
        {"Smithsonian Astrophysical Observation", "SAO 205212"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.00744525),
        dec: Angle.Degrees(-33.33618814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148634"},
        {"Hipparcos Number", "HIP 80875"},
        {"Smithsonian Astrophysical Observation", "SAO 207726"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.70681248),
        dec: Angle.Degrees(-33.33552494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83334"},
        {"Hipparcos Number", "HIP 47167"},
        {"Smithsonian Astrophysical Observation", "SAO 200549"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.17840721),
        dec: Angle.Degrees(-33.33543017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13794"},
        {"Hipparcos Number", "HIP 10357"},
        {"Smithsonian Astrophysical Observation", "SAO 193583"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.37689487),
        dec: Angle.Degrees(-33.33532818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168400"},
        {"Hipparcos Number", "HIP 89922"},
        {"Smithsonian Astrophysical Observation", "SAO 210019"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.23222562),
        dec: Angle.Degrees(-33.33353121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71208"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.44106477),
        dec: Angle.Degrees(-00.94728568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86409"},
        {"Hipparcos Number", "HIP 48824"},
        {"Geneva Identification System", "GEN# +1.00086409"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.39247076),
        dec: Angle.Degrees(-33.33344334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67242"},
        {"Hipparcos Number", "HIP 39619"},
        {"Smithsonian Astrophysical Observation", "SAO 198792"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.44360618),
        dec: Angle.Degrees(-33.33310575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36786"},
        {"Hipparcos Number", "HIP 25978"},
        {"Smithsonian Astrophysical Observation", "SAO 195943"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.16337617),
        dec: Angle.Degrees(-33.33141921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126652"},
        {"Hipparcos Number", "HIP 70708"},
        {"Smithsonian Astrophysical Observation", "SAO 205577"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.92656751),
        dec: Angle.Degrees(-33.33052843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63804"},
        {"Hipparcos Number", "HIP 38173"},
        {"Geneva Identification System", "GEN# +1.00063804"},
        {"Smithsonian Astrophysical Observation", "SAO 198482"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.33164376),
        dec: Angle.Degrees(-33.32981186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175478"},
        {"Hipparcos Number", "HIP 93014"},
        {"Smithsonian Astrophysical Observation", "SAO 210749"},
    },
    visualMagnitude: 7.16,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.23554155),
        dec: Angle.Degrees(-33.32942646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197083"},
        {"Hipparcos Number", "HIP 102200"},
        {"Geneva Identification System", "GEN# +1.00197083"},
        {"Smithsonian Astrophysical Observation", "SAO 212366"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.61460775),
        dec: Angle.Degrees(-33.32858858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108782"},
        {"Hipparcos Number", "HIP 60997"},
        {"Smithsonian Astrophysical Observation", "SAO 203537"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.52649431),
        dec: Angle.Degrees(-33.32834911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47769",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47769"},
        {"Smithsonian Astrophysical Observation", "SAO 200680"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.08930417),
        dec: Angle.Degrees(-33.32744253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166297"},
        {"Hipparcos Number", "HIP 89127"},
        {"Geneva Identification System", "GEN# +1.00166297"},
        {"Smithsonian Astrophysical Observation", "SAO 209827"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.84889197),
        dec: Angle.Degrees(-33.32689306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163649"},
        {"Hipparcos Number", "HIP 88022"},
        {"Smithsonian Astrophysical Observation", "SAO 209541"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.67997356),
        dec: Angle.Degrees(-33.32592204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134836"},
        {"Hipparcos Number", "HIP 74482"},
        {"Smithsonian Astrophysical Observation", "SAO 206420"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.29144599),
        dec: Angle.Degrees(-33.32512232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169831"},
        {"Hipparcos Number", "HIP 90493"},
        {"Wilson Evans Batten Catalogue", "WEB 15498"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.98366527),
        dec: Angle.Degrees(-33.32477443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1492"},
        {"Hipparcos Number", "HIP 1514"},
        {"Geneva Identification System", "GEN# +1.00001492"},
        {"Smithsonian Astrophysical Observation", "SAO 192459"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.72703362),
        dec: Angle.Degrees(-33.32433635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79857"},
        {"Hipparcos Number", "HIP 45436"},
        {"Smithsonian Astrophysical Observation", "SAO 200157"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.89410375),
        dec: Angle.Degrees(-33.32389871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148441"},
        {"Hipparcos Number", "HIP 80770"},
        {"Geneva Identification System", "GEN# +1.00148441"},
        {"Smithsonian Astrophysical Observation", "SAO 207708"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.36506592),
        dec: Angle.Degrees(-33.32062997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9133"},
        {"Hipparcos Number", "HIP 6942"},
        {"Geneva Identification System", "GEN# +1.00009133"},
        {"Smithsonian Astrophysical Observation", "SAO 193142"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.35886824),
        dec: Angle.Degrees(-33.32048002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45033"},
        {"Hipparcos Number", "HIP 30410"},
        {"Geneva Identification System", "GEN# +1.00045033"},
        {"Smithsonian Astrophysical Observation", "SAO 196763"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.91512923),
        dec: Angle.Degrees(-33.31959597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97840"},
        {"Hipparcos Number", "HIP 54938"},
        {"Geneva Identification System", "GEN# +1.00097840"},
        {"Smithsonian Astrophysical Observation", "SAO 202240"},
        {"Wilson Evans Batten Catalogue", "WEB 9914"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.76042019),
        dec: Angle.Degrees(-33.31787883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -143.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75221"},
        {"Hipparcos Number", "HIP 43174"},
        {"Smithsonian Astrophysical Observation", "SAO 199625"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.91082989),
        dec: Angle.Degrees(-33.31715126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165771"},
        {"Hipparcos Number", "HIP 88926"},
        {"Smithsonian Astrophysical Observation", "SAO 209774"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.28434344),
        dec: Angle.Degrees(-33.31680658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127672"},
        {"Hipparcos Number", "HIP 71179"},
        {"Smithsonian Astrophysical Observation", "SAO 205690"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.36439756),
        dec: Angle.Degrees(-33.31607419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103789"},
        {"Hipparcos Number", "HIP 58272"},
        {"Geneva Identification System", "GEN# +1.00103789"},
        {"Renson", "Renson 29976"},
        {"Smithsonian Astrophysical Observation", "SAO 202971"},
    },
    visualMagnitude: 6.20,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.26575492),
        dec: Angle.Degrees(-33.31544880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111032"},
        {"Hipparcos Number", "HIP 62360"},
        {"Geneva Identification System", "GEN# +1.00111032"},
        {"Smithsonian Astrophysical Observation", "SAO 203797"},
    },
    visualMagnitude: 5.87,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.69258582),
        dec: Angle.Degrees(-33.31541396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140374"},
        {"Hipparcos Number", "HIP 77081"},
        {"Geneva Identification System", "GEN# +1.00140374"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.08777293),
        dec: Angle.Degrees(-33.31519514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100299",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100299"},
        {"Smithsonian Astrophysical Observation", "SAO 212017"},
    },
    visualMagnitude: 10.32,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.13342613),
        dec: Angle.Degrees(-33.31350579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11581"},
        {"Hipparcos Number", "HIP 8792"},
        {"Geneva Identification System", "GEN# +1.00011581"},
        {"Smithsonian Astrophysical Observation", "SAO 193363"},
        {"Wilson Evans Batten Catalogue", "WEB 1851"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.26218450),
        dec: Angle.Degrees(-33.31315124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77163"},
        {"Hipparcos Number", "HIP 44167"},
        {"Smithsonian Astrophysical Observation", "SAO 199864"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.93954789),
        dec: Angle.Degrees(-33.31313363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62539"},
        {"Hipparcos Number", "HIP 37612"},
        {"Geneva Identification System", "GEN# +1.00062539"},
        {"Smithsonian Astrophysical Observation", "SAO 198339"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.76310331),
        dec: Angle.Degrees(-33.31257757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161139"},
        {"Hipparcos Number", "HIP 86892"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.31775849),
        dec: Angle.Degrees(-33.31186315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165059"},
        {"Hipparcos Number", "HIP 88618"},
        {"Smithsonian Astrophysical Observation", "SAO 209687"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.40140092),
        dec: Angle.Degrees(-33.31135494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167292"},
        {"Hipparcos Number", "HIP 89525"},
        {"Smithsonian Astrophysical Observation", "SAO 209929"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.02147186),
        dec: Angle.Degrees(-33.31090535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118010"},
        {"Hipparcos Number", "HIP 66254"},
        {"Fundamental Katalog 5th Edition", "FK5 3082"},
        {"Geneva Identification System", "GEN# +1.00118010"},
        {"Smithsonian Astrophysical Observation", "SAO 204612"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.68172050),
        dec: Angle.Degrees(-33.31082494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82221"},
        {"Hipparcos Number", "HIP 46562"},
        {"Geneva Identification System", "GEN# +1.00082221"},
        {"Smithsonian Astrophysical Observation", "SAO 200425"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.43080345),
        dec: Angle.Degrees(-33.31046349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44057"},
        {"Hipparcos Number", "HIP 29938"},
        {"Smithsonian Astrophysical Observation", "SAO 196671"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.53940912),
        dec: Angle.Degrees(-33.30864158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159455"},
        {"Hipparcos Number", "HIP 86146"},
        {"Geneva Identification System", "GEN# +1.00159455"},
        {"Smithsonian Astrophysical Observation", "SAO 209015"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.06796598),
        dec: Angle.Degrees(-33.30635501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194365"},
        {"Hipparcos Number", "HIP 100814"},
        {"Smithsonian Astrophysical Observation", "SAO 212119"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.60933513),
        dec: Angle.Degrees(-33.30619411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21539"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.36321998),
        dec: Angle.Degrees(-33.30426729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98791"},
        {"Hipparcos Number", "HIP 55492"},
        {"Smithsonian Astrophysical Observation", "SAO 202362"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.46486734),
        dec: Angle.Degrees(-33.30123713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127175"},
        {"Hipparcos Number", "HIP 70955"},
        {"Geneva Identification System", "GEN# +1.00127175"},
        {"Smithsonian Astrophysical Observation", "SAO 205630"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.70124361),
        dec: Angle.Degrees(-33.30121561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147149"},
        {"Hipparcos Number", "HIP 80140"},
        {"Geneva Identification System", "GEN# +1.00147149"},
        {"Smithsonian Astrophysical Observation", "SAO 207586"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.35834041),
        dec: Angle.Degrees(-33.30121261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19516"},
        {"Hipparcos Number", "HIP 14492"},
        {"Smithsonian Astrophysical Observation", "SAO 194096"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.79186068),
        dec: Angle.Degrees(-33.30085005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173146"},
        {"Hipparcos Number", "HIP 92012"},
        {"Smithsonian Astrophysical Observation", "SAO 210535"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.31662369),
        dec: Angle.Degrees(-33.30065194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131432"},
        {"Hipparcos Number", "HIP 72959"},
        {"Geneva Identification System", "GEN# +1.00131432J"},
        {"Smithsonian Astrophysical Observation", "SAO 206079"},
    },
    visualMagnitude: 5.85,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.65800270),
        dec: Angle.Degrees(-33.30056091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66383"},
        {"Hipparcos Number", "HIP 39278"},
        {"Celescope Catalog", "CEL 2141"},
        {"Geneva Identification System", "GEN# +1.00066383"},
        {"Smithsonian Astrophysical Observation", "SAO 198718"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.47636753),
        dec: Angle.Degrees(-33.29980829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68979"},
        {"Hipparcos Number", "HIP 40279"},
        {"Smithsonian Astrophysical Observation", "SAO 198956"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.38624568),
        dec: Angle.Degrees(-33.29977656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100960",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100960"},
        {"Smithsonian Astrophysical Observation", "SAO 212148"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.04264597),
        dec: Angle.Degrees(-33.29842390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64520"},
        {"Hipparcos Number", "HIP 38494"},
        {"Smithsonian Astrophysical Observation", "SAO 198551"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.25166082),
        dec: Angle.Degrees(-33.29703955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149171"},
        {"Hipparcos Number", "HIP 81143"},
        {"Smithsonian Astrophysical Observation", "SAO 207782"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.58935788),
        dec: Angle.Degrees(-33.29473218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107106"},
        {"Hipparcos Number", "HIP 60057"},
        {"Smithsonian Astrophysical Observation", "SAO 203338"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.74824448),
        dec: Angle.Degrees(-33.29222826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63852"},
        {"Hipparcos Number", "HIP 38200"},
        {"Fundamental Katalog 5th Edition", "FK5 2608"},
        {"Geneva Identification System", "GEN# +1.00063852"},
        {"Smithsonian Astrophysical Observation", "SAO 198487"},
    },
    visualMagnitude: 5.61,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.39761883),
        dec: Angle.Degrees(-33.28895425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134000"},
        {"Hipparcos Number", "HIP 74098"},
        {"Smithsonian Astrophysical Observation", "SAO 206331"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.15256982),
        dec: Angle.Degrees(-33.28861279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221283"},
        {"Hipparcos Number", "HIP 116068"},
        {"Smithsonian Astrophysical Observation", "SAO 214597"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.77498851),
        dec: Angle.Degrees(-33.28839868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116064",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116064"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.77197836),
        dec: Angle.Degrees(-33.28711082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188091"},
        {"Hipparcos Number", "HIP 97977"},
        {"Smithsonian Astrophysical Observation", "SAO 211649"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.68016876),
        dec: Angle.Degrees(-33.28708675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140876"},
        {"Hipparcos Number", "HIP 77322"},
        {"Geneva Identification System", "GEN# +1.00140876"},
        {"Smithsonian Astrophysical Observation", "SAO 206971"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.79055141),
        dec: Angle.Degrees(-33.28646423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4417"},
        {"Henry Draper 2", "HD 4417A"},
        {"Hipparcos Number", "HIP 3602"},
        {"Smithsonian Astrophysical Observation", "SAO 192724"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.53369448),
        dec: Angle.Degrees(-33.28428944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33907"},
        {"Hipparcos Number", "HIP 24228"},
        {"Smithsonian Astrophysical Observation", "SAO 195646"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.02937476),
        dec: Angle.Degrees(-33.28336496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200343"},
        {"Hipparcos Number", "HIP 103975"},
        {"Smithsonian Astrophysical Observation", "SAO 212679"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.00006254),
        dec: Angle.Degrees(-33.28266874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 576"},
        {"Hipparcos Number", "HIP 832"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.54226103),
        dec: Angle.Degrees(-33.28094424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102767"},
        {"Hipparcos Number", "HIP 57678"},
        {"Smithsonian Astrophysical Observation", "SAO 202845"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.43782553),
        dec: Angle.Degrees(-33.28031871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119176"},
        {"Hipparcos Number", "HIP 66866"},
        {"Smithsonian Astrophysical Observation", "SAO 204747"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.56790572),
        dec: Angle.Degrees(-33.27851260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180702"},
        {"Hipparcos Number", "HIP 94926"},
        {"Geneva Identification System", "GEN# +1.00180702"},
        {"Smithsonian Astrophysical Observation", "SAO 211161"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.74616731),
        dec: Angle.Degrees(-33.27801210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156099"},
        {"Hipparcos Number", "HIP 84554"},
        {"Geneva Identification System", "GEN# +1.00156099"},
        {"Smithsonian Astrophysical Observation", "SAO 208625"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.26926986),
        dec: Angle.Degrees(-33.27681576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97545"},
        {"Hipparcos Number", "HIP 54805"},
        {"Geneva Identification System", "GEN# +1.00097545"},
        {"Smithsonian Astrophysical Observation", "SAO 202212"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.29504258),
        dec: Angle.Degrees(-33.27626739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117014"},
        {"Hipparcos Number", "HIP 65688"},
        {"Smithsonian Astrophysical Observation", "SAO 204498"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.02034178),
        dec: Angle.Degrees(-33.27599494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52973",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52973"},
        {"Smithsonian Astrophysical Observation", "SAO 201806"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.51394051),
        dec: Angle.Degrees(-33.27424075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131993"},
        {"Hipparcos Number", "HIP 73221"},
        {"Smithsonian Astrophysical Observation", "SAO 206136"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.46527083),
        dec: Angle.Degrees(-33.27402608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91965"},
        {"Hipparcos Number", "HIP 51937"},
        {"Celescope Catalog", "CEL 3590"},
        {"Geneva Identification System", "GEN# +1.00091965"},
        {"Smithsonian Astrophysical Observation", "SAO 201556"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.14960991),
        dec: Angle.Degrees(-33.27254959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175322"},
        {"Hipparcos Number", "HIP 92959"},
        {"Geneva Identification System", "GEN# +1.00175322"},
        {"Smithsonian Astrophysical Observation", "SAO 210732"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.08274159),
        dec: Angle.Degrees(-33.27059921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212408"},
        {"Hipparcos Number", "HIP 110628"},
        {"Geneva Identification System", "GEN# +1.00212408"},
        {"Smithsonian Astrophysical Observation", "SAO 213798"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.16178627),
        dec: Angle.Degrees(-33.26953105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37224"},
        {"Hipparcos Number", "HIP 26245"},
        {"Smithsonian Astrophysical Observation", "SAO 195992"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.86158723),
        dec: Angle.Degrees(-33.26948575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31129"},
        {"Hipparcos Number", "HIP 22606"},
        {"Smithsonian Astrophysical Observation", "SAO 195360"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.95188842),
        dec: Angle.Degrees(-33.26903051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217068"},
        {"Hipparcos Number", "HIP 113424"},
        {"Smithsonian Astrophysical Observation", "SAO 214212"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.57690333),
        dec: Angle.Degrees(-33.26848408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131075"},
        {"Hipparcos Number", "HIP 72761"},
        {"Smithsonian Astrophysical Observation", "SAO 206030"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.12126255),
        dec: Angle.Degrees(-33.26721245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179251"},
        {"Hipparcos Number", "HIP 94441"},
        {"Smithsonian Astrophysical Observation", "SAO 211055"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.31866822),
        dec: Angle.Degrees(-33.26641140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3391"},
        {"Hipparcos Number", "HIP 2891"},
        {"Geneva Identification System", "GEN# +1.00003391"},
        {"Smithsonian Astrophysical Observation", "SAO 192636"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.16604724),
        dec: Angle.Degrees(-33.26593957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22645"},
        {"Hipparcos Number", "HIP 16884"},
        {"Smithsonian Astrophysical Observation", "SAO 194406"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.32232552),
        dec: Angle.Degrees(-33.26487833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39851",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39851"},
        {"Smithsonian Astrophysical Observation", "SAO 198843"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.12338152),
        dec: Angle.Degrees(-33.25950854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152820"},
        {"Hipparcos Number", "HIP 82960"},
        {"Geneva Identification System", "GEN# +1.00152820"},
        {"Smithsonian Astrophysical Observation", "SAO 208232"},
    },
    visualMagnitude: 5.48,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.29655015),
        dec: Angle.Degrees(-33.25946890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206455"},
        {"Hipparcos Number", "HIP 107224"},
        {"Smithsonian Astrophysical Observation", "SAO 213227"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.75624847),
        dec: Angle.Degrees(-33.25904730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97648"},
        {"Hipparcos Number", "HIP 54856"},
        {"Smithsonian Astrophysical Observation", "SAO 202220"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.46473112),
        dec: Angle.Degrees(-33.25882697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145920"},
        {"Hipparcos Number", "HIP 79616"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.69415341),
        dec: Angle.Degrees(-33.25838104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26302"},
        {"Hipparcos Number", "HIP 19303"},
        {"Smithsonian Astrophysical Observation", "SAO 194789"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.06777435),
        dec: Angle.Degrees(-33.25817386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192435"},
        {"Hipparcos Number", "HIP 99891"},
        {"Geneva Identification System", "GEN# +1.00192435"},
        {"Smithsonian Astrophysical Observation", "SAO 211942"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.00945174),
        dec: Angle.Degrees(-33.25630735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186320"},
        {"Hipparcos Number", "HIP 97161"},
        {"Smithsonian Astrophysical Observation", "SAO 211529"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.23535092),
        dec: Angle.Degrees(-33.25455880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208385"},
        {"Hipparcos Number", "HIP 108324"},
        {"Smithsonian Astrophysical Observation", "SAO 213422"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.17866853),
        dec: Angle.Degrees(-33.25408070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 318463"},
        {"Hipparcos Number", "HIP 87221"},
        {"Geneva Identification System", "GEN# +1.00318463"},
        {"Smithsonian Astrophysical Observation", "SAO 209301"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.29589233),
        dec: Angle.Degrees(-33.25022961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126459"},
        {"Hipparcos Number", "HIP 70603"},
        {"Geneva Identification System", "GEN# +1.00126459"},
        {"Smithsonian Astrophysical Observation", "SAO 205557"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.61416086),
        dec: Angle.Degrees(-33.25020632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112312"},
    },
    visualMagnitude: 11.70,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.24098947),
        dec: Angle.Degrees(-33.25018399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65378"},
        {"Hipparcos Number", "HIP 38858"},
        {"Celescope Catalog", "CEL 2107"},
        {"Geneva Identification System", "GEN# +1.00065378"},
        {"Smithsonian Astrophysical Observation", "SAO 198625"},
    },
    visualMagnitude: 7.31,
    bvColour: -0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.28605917),
        dec: Angle.Degrees(-33.24992275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168977"},
        {"Hipparcos Number", "HIP 90166"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.99150173),
        dec: Angle.Degrees(-33.24799426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126521"},
        {"Hipparcos Number", "HIP 70628"},
        {"Smithsonian Astrophysical Observation", "SAO 205564"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.70946106),
        dec: Angle.Degrees(-33.24696491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67924"},
        {"Hipparcos Number", "HIP 39894"},
        {"Celescope Catalog", "CEL 2183"},
        {"Geneva Identification System", "GEN# +1.00067924"},
        {"Smithsonian Astrophysical Observation", "SAO 198853"},
    },
    visualMagnitude: 7.73,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.23258370),
        dec: Angle.Degrees(-33.24638101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20585"},
        {"Hipparcos Number", "HIP 15318"},
        {"Smithsonian Astrophysical Observation", "SAO 194214"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.40854472),
        dec: Angle.Degrees(-33.24580576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75057"},
        {"Hipparcos Number", "HIP 43095"},
        {"Geneva Identification System", "GEN# +1.00075057"},
        {"Smithsonian Astrophysical Observation", "SAO 199605"},
        {"Wilson Evans Batten Catalogue", "WEB 8317"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.65394991),
        dec: Angle.Degrees(-33.24535976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188902"},
        {"Hipparcos Number", "HIP 98331"},
        {"Geneva Identification System", "GEN# +1.00188902"},
        {"Smithsonian Astrophysical Observation", "SAO 211703"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.66866169),
        dec: Angle.Degrees(-33.24475229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84900"},
        {"Hipparcos Number", "HIP 48042"},
        {"Geneva Identification System", "GEN# +1.00084900"},
        {"Smithsonian Astrophysical Observation", "SAO 200736"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.90197927),
        dec: Angle.Degrees(-33.24356838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124780"},
        {"Hipparcos Number", "HIP 69722"},
        {"Fundamental Katalog 5th Edition", "FK5 3132"},
        {"Geneva Identification System", "GEN# +1.00124780"},
        {"Smithsonian Astrophysical Observation", "SAO 205371"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.07633639),
        dec: Angle.Degrees(-33.24133031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11550"},
        {"Hipparcos Number", "HIP 8761"},
        {"Smithsonian Astrophysical Observation", "SAO 193356"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.17979184),
        dec: Angle.Degrees(-33.24021409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91583",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91583"},
    },
    visualMagnitude: 11.73,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.14453504),
        dec: Angle.Degrees(-33.23926636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81827"},
    },
    visualMagnitude: 11.50,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.71559045),
        dec: Angle.Degrees(-33.23918390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -276.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124613"},
        {"Hipparcos Number", "HIP 69656"},
        {"Smithsonian Astrophysical Observation", "SAO 205358"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.84411233),
        dec: Angle.Degrees(-33.23865722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74175"},
        {"Hipparcos Number", "HIP 42633"},
        {"Smithsonian Astrophysical Observation", "SAO 199506"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.32551769),
        dec: Angle.Degrees(-33.23834742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87303"},
        {"Hipparcos Number", "HIP 49264"},
        {"Smithsonian Astrophysical Observation", "SAO 201005"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.84818098),
        dec: Angle.Degrees(-33.23828364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106900"},
        {"Hipparcos Number", "HIP 59938"},
        {"Smithsonian Astrophysical Observation", "SAO 203315"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.41394999),
        dec: Angle.Degrees(-33.23760563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85861"},
        {"Hipparcos Number", "HIP 48532"},
        {"Geneva Identification System", "GEN# +1.00085861"},
        {"Smithsonian Astrophysical Observation", "SAO 200846"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.48005445),
        dec: Angle.Degrees(-33.23505759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195911"},
        {"Hipparcos Number", "HIP 101584"},
        {"Smithsonian Astrophysical Observation", "SAO 212256"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.81242256),
        dec: Angle.Degrees(-33.23490458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147167"},
        {"Hipparcos Number", "HIP 80148"},
        {"Smithsonian Astrophysical Observation", "SAO 207587"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.39299476),
        dec: Angle.Degrees(-33.23453031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 758"},
        {"Hipparcos Number", "HIP 953"},
        {"Smithsonian Astrophysical Observation", "SAO 192389"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.94645767),
        dec: Angle.Degrees(-33.23382365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8294"},
        {"Hipparcos Number", "HIP 6358"},
        {"Geneva Identification System", "GEN# +1.00008294"},
        {"Smithsonian Astrophysical Observation", "SAO 193070"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.41261749),
        dec: Angle.Degrees(-33.23246533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176293"},
        {"Hipparcos Number", "HIP 93361"},
        {"Geneva Identification System", "GEN# +1.00176293"},
        {"Smithsonian Astrophysical Observation", "SAO 210817"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.25019245),
        dec: Angle.Degrees(-33.23166833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27407",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27407"},
        {"Smithsonian Astrophysical Observation", "SAO 196187"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.05326034),
        dec: Angle.Degrees(-33.23154478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106654"},
        {"Hipparcos Number", "HIP 59821"},
        {"Smithsonian Astrophysical Observation", "SAO 203293"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.00647258),
        dec: Angle.Degrees(-33.22428212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219898"},
        {"Hipparcos Number", "HIP 115168"},
        {"Smithsonian Astrophysical Observation", "SAO 214458"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.91812131),
        dec: Angle.Degrees(-33.22405677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101459",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101459"},
        {"Smithsonian Astrophysical Observation", "SAO 212233"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.43874096),
        dec: Angle.Degrees(-33.22366190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125150"},
        {"Hipparcos Number", "HIP 69904"},
        {"Geneva Identification System", "GEN# +1.00125150"},
        {"Smithsonian Astrophysical Observation", "SAO 205412"},
        {"Wilson Evans Batten Catalogue", "WEB 12161"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.59919155),
        dec: Angle.Degrees(-33.22045359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41863"},
        {"Hipparcos Number", "HIP 28900"},
        {"Geneva Identification System", "GEN# +1.00041863"},
        {"Smithsonian Astrophysical Observation", "SAO 196490"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.52323483),
        dec: Angle.Degrees(-33.21928333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24953"},
        {"Hipparcos Number", "HIP 18457"},
        {"Smithsonian Astrophysical Observation", "SAO 194640"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.16112343),
        dec: Angle.Degrees(-33.21880532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62477"},
        {"Hipparcos Number", "HIP 37586"},
        {"Smithsonian Astrophysical Observation", "SAO 198333"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.69394807),
        dec: Angle.Degrees(-33.21671415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47016"},
        {"Hipparcos Number", "HIP 31413"},
        {"Smithsonian Astrophysical Observation", "SAO 196968"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.75621167),
        dec: Angle.Degrees(-33.21623380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24823"},
        {"Hipparcos Number", "HIP 18361"},
        {"Smithsonian Astrophysical Observation", "SAO 194629"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.89250171),
        dec: Angle.Degrees(-33.21489303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6907"},
        {"Hipparcos Number", "HIP 5415"},
        {"Geneva Identification System", "GEN# +1.00006907"},
        {"Smithsonian Astrophysical Observation", "SAO 192956"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.30528174),
        dec: Angle.Degrees(-33.21392393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143902"},
        {"Hipparcos Number", "HIP 78726"},
        {"Geneva Identification System", "GEN# +1.00143902"},
        {"Smithsonian Astrophysical Observation", "SAO 207292"},
        {"Wilson Evans Batten Catalogue", "WEB 13310"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.07432893),
        dec: Angle.Degrees(-33.21363541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6414"},
        {"Geneva Identification System", "GEN# -0.03300501"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.59508300),
        dec: Angle.Degrees(-33.21350931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 355.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -296.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116492"},
        {"Geneva Identification System", "GEN# -0.03316613A"},
        {"Smithsonian Astrophysical Observation", "SAO 214647"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.08702484),
        dec: Angle.Degrees(-33.21327821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 221.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141275"},
        {"Hipparcos Number", "HIP 77493"},
        {"Smithsonian Astrophysical Observation", "SAO 207012"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.34242849),
        dec: Angle.Degrees(-33.21311641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123663"},
        {"Hipparcos Number", "HIP 69188"},
        {"Smithsonian Astrophysical Observation", "SAO 205249"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.44938534),
        dec: Angle.Degrees(-33.20867962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117385"},
        {"Smithsonian Astrophysical Observation", "SAO 214781"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.01385864),
        dec: Angle.Degrees(-33.20867014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157142"},
        {"Hipparcos Number", "HIP 85056"},
        {"Smithsonian Astrophysical Observation", "SAO 208752"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.74047253),
        dec: Angle.Degrees(-33.20861525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21680"},
        {"Hipparcos Number", "HIP 16202"},
        {"Smithsonian Astrophysical Observation", "SAO 194324"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.18062763),
        dec: Angle.Degrees(-33.20742249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110655"},
    },
    visualMagnitude: 10.59,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.26150214),
        dec: Angle.Degrees(-33.20484572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7849"},
        {"Hipparcos Number", "HIP 6042"},
        {"Smithsonian Astrophysical Observation", "SAO 193031"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.39975332),
        dec: Angle.Degrees(-33.20386965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133897"},
        {"Hipparcos Number", "HIP 74054"},
        {"Smithsonian Astrophysical Observation", "SAO 206322"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.00641274),
        dec: Angle.Degrees(-33.20313310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216970"},
        {"Hipparcos Number", "HIP 113374"},
        {"Geneva Identification System", "GEN# +1.00216970"},
        {"Smithsonian Astrophysical Observation", "SAO 214204"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.42256736),
        dec: Angle.Degrees(-33.20310484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119507"},
        {"Hipparcos Number", "HIP 67035"},
        {"Smithsonian Astrophysical Observation", "SAO 204789"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.06590809),
        dec: Angle.Degrees(-33.20066032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81254"},
        {"Hipparcos Number", "HIP 46065"},
        {"Smithsonian Astrophysical Observation", "SAO 200314"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.91477315),
        dec: Angle.Degrees(-33.20049985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147553"},
        {"Hipparcos Number", "HIP 80324"},
        {"Geneva Identification System", "GEN# +1.00147553"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.98635397),
        dec: Angle.Degrees(-33.19932914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208286"},
        {"Hipparcos Number", "HIP 108262"},
        {"Smithsonian Astrophysical Observation", "SAO 213407"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.99504446),
        dec: Angle.Degrees(-33.19802745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216986"},
        {"Hipparcos Number", "HIP 113381"},
        {"Geneva Identification System", "GEN# +1.00216986"},
        {"Smithsonian Astrophysical Observation", "SAO 214205"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.44061682),
        dec: Angle.Degrees(-33.19650650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38242",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38242"},
        {"Wilson Evans Batten Catalogue", "WEB 7532"},
    },
    visualMagnitude: 9.53,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.51688628),
        dec: Angle.Degrees(-00.88202690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43310"},
        {"Hipparcos Number", "HIP 29586"},
        {"Renson", "Renson 11490"},
        {"Smithsonian Astrophysical Observation", "SAO 196612"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.51598370),
        dec: Angle.Degrees(-33.19395381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155805"},
        {"Hipparcos Number", "HIP 84395"},
        {"Geneva Identification System", "GEN# +1.00155805"},
        {"Smithsonian Astrophysical Observation", "SAO 208583"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.81605088),
        dec: Angle.Degrees(-33.19170842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116278"},
        {"Hipparcos Number", "HIP 65311"},
        {"Geneva Identification System", "GEN# +1.00116278"},
        {"Smithsonian Astrophysical Observation", "SAO 204420"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.78601574),
        dec: Angle.Degrees(-33.18988737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224410"},
        {"Hipparcos Number", "HIP 118127"},
        {"Geneva Identification System", "GEN# +1.00224410"},
        {"Smithsonian Astrophysical Observation", "SAO 214878"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.40956621),
        dec: Angle.Degrees(-33.18915202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7970"},
        {"Hipparcos Number", "HIP 6126"},
        {"Smithsonian Astrophysical Observation", "SAO 193045"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.66153194),
        dec: Angle.Degrees(-33.18900836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127796"},
        {"Hipparcos Number", "HIP 71244"},
        {"Smithsonian Astrophysical Observation", "SAO 205707"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.54764929),
        dec: Angle.Degrees(-33.18873893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151273"},
        {"Hipparcos Number", "HIP 82220"},
        {"Smithsonian Astrophysical Observation", "SAO 208037"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.95175569),
        dec: Angle.Degrees(-33.18794229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212802"},
        {"Hipparcos Number", "HIP 110859"},
        {"Smithsonian Astrophysical Observation", "SAO 213832"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.90518739),
        dec: Angle.Degrees(-33.18697827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202207"},
        {"Hipparcos Number", "HIP 104927"},
        {"Geneva Identification System", "GEN# +1.00202207"},
        {"Smithsonian Astrophysical Observation", "SAO 212832"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.82105519),
        dec: Angle.Degrees(-33.18671202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74575"},
        {"Hipparcos Number", "HIP 42828"},
        {"Celescope Catalog", "CEL 2817"},
        {"Fundamental Katalog 5th Edition", "FK5 327"},
        {"Geneva Identification System", "GEN# +1.00074575"},
        {"Smithsonian Astrophysical Observation", "SAO 199546"},
        {"Wilson Evans Batten Catalogue", "WEB 8272"},
    },
    visualMagnitude: 3.68,
    bvColour: -0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.89811451),
        dec: Angle.Degrees(-33.18641133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169461"},
        {"Hipparcos Number", "HIP 90356"},
        {"Geneva Identification System", "GEN# +1.00169461"},
        {"Smithsonian Astrophysical Observation", "SAO 210142"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.55574032),
        dec: Angle.Degrees(-33.18594509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18889"},
        {"Hipparcos Number", "HIP 14061"},
        {"Geneva Identification System", "GEN# +1.00018889"},
        {"Smithsonian Astrophysical Observation", "SAO 194036"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.29498886),
        dec: Angle.Degrees(-33.18300566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215616"},
        {"Hipparcos Number", "HIP 112472"},
        {"Geneva Identification System", "GEN# +1.00215616"},
        {"Smithsonian Astrophysical Observation", "SAO 214074"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.72655728),
        dec: Angle.Degrees(-33.18248239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27510"},
        {"Hipparcos Number", "HIP 20152"},
        {"Smithsonian Astrophysical Observation", "SAO 194924"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.79657141),
        dec: Angle.Degrees(-33.18147386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104446",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104446"},
        {"Smithsonian Astrophysical Observation", "SAO 212757"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.36888188),
        dec: Angle.Degrees(-33.18105961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128299"},
        {"Hipparcos Number", "HIP 71477"},
        {"Geneva Identification System", "GEN# +1.00128299"},
        {"Smithsonian Astrophysical Observation", "SAO 205764"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.26450371),
        dec: Angle.Degrees(-33.17958857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198529"},
        {"Hipparcos Number", "HIP 102989"},
        {"Geneva Identification System", "GEN# +1.00198529"},
        {"Smithsonian Astrophysical Observation", "SAO 212499"},
        {"Wilson Evans Batten Catalogue", "WEB 18690"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.99481827),
        dec: Angle.Degrees(-33.17796029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15173"},
        {"Hipparcos Number", "HIP 11310"},
        {"Smithsonian Astrophysical Observation", "SAO 193703"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.40437147),
        dec: Angle.Degrees(-33.17794604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69669"},
        {"Hipparcos Number", "HIP 40539"},
        {"Smithsonian Astrophysical Observation", "SAO 199025"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.16140715),
        dec: Angle.Degrees(-33.17732390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196532"},
        {"Hipparcos Number", "HIP 101918"},
        {"Smithsonian Astrophysical Observation", "SAO 212316"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.78962518),
        dec: Angle.Degrees(-33.17727746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208852"},
        {"Hipparcos Number", "HIP 108581"},
        {"Smithsonian Astrophysical Observation", "SAO 213459"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.93935806),
        dec: Angle.Degrees(-33.17699609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99907"},
        {"Hipparcos Number", "HIP 56067"},
        {"Smithsonian Astrophysical Observation", "SAO 202501"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.36142988),
        dec: Angle.Degrees(-33.17690185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171353"},
        {"Hipparcos Number", "HIP 91158"},
        {"Geneva Identification System", "GEN# +1.00171353"},
        {"Smithsonian Astrophysical Observation", "SAO 210351"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.97136283),
        dec: Angle.Degrees(-33.17511577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20377"},
        {"Hipparcos Number", "HIP 15175"},
        {"Smithsonian Astrophysical Observation", "SAO 194189"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.88282552),
        dec: Angle.Degrees(-33.17398730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116698"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.72919077),
        dec: Angle.Degrees(-33.17342694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17135"},
        {"Hipparcos Number", "HIP 12762"},
        {"Geneva Identification System", "GEN# +1.00017135"},
        {"Smithsonian Astrophysical Observation", "SAO 193884"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.00161246),
        dec: Angle.Degrees(-33.17175312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138575"},
        {"Hipparcos Number", "HIP 76217"},
        {"Geneva Identification System", "GEN# +1.00138575"},
        {"Smithsonian Astrophysical Observation", "SAO 206768"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.54217772),
        dec: Angle.Degrees(-33.17127196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112053"},
        {"Hipparcos Number", "HIP 62934"},
        {"Smithsonian Astrophysical Observation", "SAO 203916"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.46429685),
        dec: Angle.Degrees(-33.17011518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117965"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.91474730),
        dec: Angle.Degrees(-33.16969557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 293.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1910"},
        {"Hipparcos Number", "HIP 1837"},
        {"Geneva Identification System", "GEN# +1.00001910"},
        {"Smithsonian Astrophysical Observation", "SAO 192496"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.81659898),
        dec: Angle.Degrees(-33.16783230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 126.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28418"},
        {"Hipparcos Number", "HIP 20818"},
        {"Smithsonian Astrophysical Observation", "SAO 195033"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.91302235),
        dec: Angle.Degrees(-33.16144019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180748"},
        {"Hipparcos Number", "HIP 94938"},
        {"Geneva Identification System", "GEN# +1.00180748"},
        {"Smithsonian Astrophysical Observation", "SAO 211164"},
        {"Wilson Evans Batten Catalogue", "WEB 16575"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.77954962),
        dec: Angle.Degrees(-33.15841108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12758"},
        {"Hipparcos Number", "HIP 9662"},
        {"Smithsonian Astrophysical Observation", "SAO 193488"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.07444494),
        dec: Angle.Degrees(-33.15669860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195109"},
        {"Hipparcos Number", "HIP 101177"},
        {"Smithsonian Astrophysical Observation", "SAO 212187"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.62036985),
        dec: Angle.Degrees(-33.15549881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137782"},
        {"Hipparcos Number", "HIP 75794"},
        {"Smithsonian Astrophysical Observation", "SAO 206692"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.26500271),
        dec: Angle.Degrees(-33.15439836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66582"},
        {"Hipparcos Number", "HIP 39367"},
        {"Celescope Catalog", "CEL 2149"},
        {"Geneva Identification System", "GEN# +1.00066582"},
        {"Smithsonian Astrophysical Observation", "SAO 198739"},
    },
    visualMagnitude: 7.35,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.72325990),
        dec: Angle.Degrees(-33.15357253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26479"},
        {"Hipparcos Number", "HIP 19455"},
        {"Smithsonian Astrophysical Observation", "SAO 194805"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.50257286),
        dec: Angle.Degrees(-33.15318940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63600",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63600"},
    },
    visualMagnitude: 10.42,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.50228685),
        dec: Angle.Degrees(-33.15307685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18588"},
        {"Hipparcos Number", "HIP 13852"},
        {"Smithsonian Astrophysical Observation", "SAO 194012"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.57982978),
        dec: Angle.Degrees(-33.15124422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113965"},
        {"Hipparcos Number", "HIP 64052"},
        {"Smithsonian Astrophysical Observation", "SAO 204144"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.90595106),
        dec: Angle.Degrees(-33.14965079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111244"},
        {"Hipparcos Number", "HIP 62481"},
        {"Smithsonian Astrophysical Observation", "SAO 203821"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.06562057),
        dec: Angle.Degrees(-33.14931760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219435"},
        {"Hipparcos Number", "HIP 114867"},
        {"Fundamental Katalog 5th Edition", "FK5 6055"},
        {"Renson", "Renson 60270"},
        {"Smithsonian Astrophysical Observation", "SAO 214416"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.99979941),
        dec: Angle.Degrees(-33.14790027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149621"},
        {"Hipparcos Number", "HIP 81385"},
        {"Smithsonian Astrophysical Observation", "SAO 207844"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.31751350),
        dec: Angle.Degrees(-33.14750142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134888"},
        {"Hipparcos Number", "HIP 74499"},
        {"Smithsonian Astrophysical Observation", "SAO 206426"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.36657999),
        dec: Angle.Degrees(-33.14721087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139733"},
        {"Hipparcos Number", "HIP 76803"},
        {"Smithsonian Astrophysical Observation", "SAO 206866"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.23000424),
        dec: Angle.Degrees(-33.14584253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150331"},
        {"Hipparcos Number", "HIP 81741"},
        {"Geneva Identification System", "GEN# +1.00150331"},
        {"Smithsonian Astrophysical Observation", "SAO 207930"},
        {"Wilson Evans Batten Catalogue", "WEB 13814"},
    },
    visualMagnitude: 5.84,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.43956303),
        dec: Angle.Degrees(-33.14562113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4455"},
        {"Hipparcos Number", "HIP 3628"},
        {"Geneva Identification System", "GEN# +1.00004455"},
        {"Smithsonian Astrophysical Observation", "SAO 192730"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.62810087),
        dec: Angle.Degrees(-33.14391630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103993"},
        {"Hipparcos Number", "HIP 58395"},
        {"Smithsonian Astrophysical Observation", "SAO 202996"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.60900278),
        dec: Angle.Degrees(-33.14341181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210996"},
        {"Hipparcos Number", "HIP 109844"},
        {"Smithsonian Astrophysical Observation", "SAO 213667"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.70301655),
        dec: Angle.Degrees(-33.14334955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121083"},
        {"Hipparcos Number", "HIP 67877"},
        {"Geneva Identification System", "GEN# +1.00121083"},
        {"Smithsonian Astrophysical Observation", "SAO 204969"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.53299149),
        dec: Angle.Degrees(-33.14310748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107875",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107875"},
        {"Smithsonian Astrophysical Observation", "SAO 213338"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.84822596),
        dec: Angle.Degrees(-33.14136678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102902"},
        {"Hipparcos Number", "HIP 57759"},
        {"Geneva Identification System", "GEN# +1.00102902"},
        {"Smithsonian Astrophysical Observation", "SAO 202865"},
        {"Wilson Evans Batten Catalogue", "WEB 10366"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.67548352),
        dec: Angle.Degrees(-33.14124515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167003"},
        {"Hipparcos Number", "HIP 89404"},
        {"Geneva Identification System", "GEN# +1.00167003"},
        {"Smithsonian Astrophysical Observation", "SAO 209900"},
    },
    visualMagnitude: 8.44,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.67557299),
        dec: Angle.Degrees(-33.14088922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26785"},
        {"Hipparcos Number", "HIP 19675"},
        {"Smithsonian Astrophysical Observation", "SAO 194835"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.22066506),
        dec: Angle.Degrees(-33.14051493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7909"},
        {"Hipparcos Number", "HIP 6095"},
        {"Geneva Identification System", "GEN# +1.00007909"},
        {"Smithsonian Astrophysical Observation", "SAO 193040"},
        {"Wilson Evans Batten Catalogue", "WEB 1372"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.56287436),
        dec: Angle.Degrees(-33.13749141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91281"},
        {"Hipparcos Number", "HIP 51553"},
        {"Smithsonian Astrophysical Observation", "SAO 201477"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.95981689),
        dec: Angle.Degrees(-33.13742948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113547"},
        {"Hipparcos Number", "HIP 63824"},
        {"Renson", "Renson 32920"},
        {"Smithsonian Astrophysical Observation", "SAO 204105"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.21202601),
        dec: Angle.Degrees(-33.13737780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121889"},
        {"Hipparcos Number", "HIP 68305"},
        {"Smithsonian Astrophysical Observation", "SAO 205060"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.73272242),
        dec: Angle.Degrees(-33.13689405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117876",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117876"},
        {"Smithsonian Astrophysical Observation", "SAO 214852"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.64959448),
        dec: Angle.Degrees(-33.13551553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75753"},
    },
    visualMagnitude: 10.88,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.13123548),
        dec: Angle.Degrees(-33.13479841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224463"},
        {"Hipparcos Number", "HIP 118165"},
        {"Smithsonian Astrophysical Observation", "SAO 214885"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.53549515),
        dec: Angle.Degrees(-33.13220784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89672"},
        {"Hipparcos Number", "HIP 50602"},
        {"Smithsonian Astrophysical Observation", "SAO 201293"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.05701686),
        dec: Angle.Degrees(-33.12873334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210111"},
        {"Hipparcos Number", "HIP 109306"},
        {"Geneva Identification System", "GEN# +1.00210111"},
        {"Smithsonian Astrophysical Observation", "SAO 213583"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.17764444),
        dec: Angle.Degrees(-33.12575126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129945"},
        {"Hipparcos Number", "HIP 72240"},
        {"Smithsonian Astrophysical Observation", "SAO 205925"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.60407213),
        dec: Angle.Degrees(-33.12529283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154448"},
        {"Hipparcos Number", "HIP 83742"},
        {"Smithsonian Astrophysical Observation", "SAO 208424"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.72662726),
        dec: Angle.Degrees(-33.12453005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38806",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38806"},
        {"Smithsonian Astrophysical Observation", "SAO 198613"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.13072588),
        dec: Angle.Degrees(-33.12399335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20444"},
        {"Smithsonian Astrophysical Observation", "SAO 194963"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.69486195),
        dec: Angle.Degrees(-33.12244863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -335.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223700"},
        {"Hipparcos Number", "HIP 117678"},
        {"Fundamental Katalog 5th Edition", "FK5 6114"},
        {"Smithsonian Astrophysical Observation", "SAO 214829"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.97944317),
        dec: Angle.Degrees(-33.12202623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16095"},
        {"Hipparcos Number", "HIP 11954"},
        {"Geneva Identification System", "GEN# +1.00016095"},
        {"Smithsonian Astrophysical Observation", "SAO 193775"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.54815243),
        dec: Angle.Degrees(-33.11721293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 274.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219973"},
        {"Hipparcos Number", "HIP 115231"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.08839478),
        dec: Angle.Degrees(-33.11527108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24232"},
        {"Hipparcos Number", "HIP 17939"},
        {"Smithsonian Astrophysical Observation", "SAO 194563"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.54504205),
        dec: Angle.Degrees(-33.11392655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45665"},
        {"Hipparcos Number", "HIP 30729"},
        {"Geneva Identification System", "GEN# +1.00045665"},
        {"Smithsonian Astrophysical Observation", "SAO 196845"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.83614206),
        dec: Angle.Degrees(-33.11384727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23720",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23720"},
        {"Smithsonian Astrophysical Observation", "SAO 195555"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.48939378),
        dec: Angle.Degrees(-33.11280152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118648"},
        {"Hipparcos Number", "HIP 66577"},
        {"Geneva Identification System", "GEN# +1.00118648"},
        {"Smithsonian Astrophysical Observation", "SAO 204692"},
    },
    visualMagnitude: 7.00,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.70987305),
        dec: Angle.Degrees(-33.11125900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18864"},
        {"Hipparcos Number", "HIP 14056"},
        {"Geneva Identification System", "GEN# +1.00018864"},
        {"Smithsonian Astrophysical Observation", "SAO 194035"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.26766552),
        dec: Angle.Degrees(-33.10994187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147015"},
        {"Hipparcos Number", "HIP 80080"},
        {"Smithsonian Astrophysical Observation", "SAO 207577"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.15942506),
        dec: Angle.Degrees(-33.10834857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15679"},
        {"Hipparcos Number", "HIP 11647"},
        {"Smithsonian Astrophysical Observation", "SAO 193742"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.56236665),
        dec: Angle.Degrees(-33.10822779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184418"},
        {"Hipparcos Number", "HIP 96375"},
        {"Geneva Identification System", "GEN# +1.00184418"},
        {"Smithsonian Astrophysical Observation", "SAO 211389"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.91100586),
        dec: Angle.Degrees(-33.10752895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122721"},
        {"Hipparcos Number", "HIP 68740"},
        {"Smithsonian Astrophysical Observation", "SAO 205140"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.06078424),
        dec: Angle.Degrees(-33.10552308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16889"},
        {"Hipparcos Number", "HIP 12563"},
        {"Smithsonian Astrophysical Observation", "SAO 193860"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.39298527),
        dec: Angle.Degrees(-33.10345481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153366"},
        {"Hipparcos Number", "HIP 83227"},
        {"Smithsonian Astrophysical Observation", "SAO 208291"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.12959486),
        dec: Angle.Degrees(-33.10278120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42697"},
        {"Hipparcos Number", "HIP 29305"},
        {"Smithsonian Astrophysical Observation", "SAO 196560"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.66782655),
        dec: Angle.Degrees(-33.10212388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77920"},
        {"Hipparcos Number", "HIP 44527"},
        {"Smithsonian Astrophysical Observation", "SAO 199951"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.08862520),
        dec: Angle.Degrees(-33.10184985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29028"},
        {"Hipparcos Number", "HIP 21207"},
        {"Smithsonian Astrophysical Observation", "SAO 195114"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.23814036),
        dec: Angle.Degrees(-33.09706318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205506"},
        {"Hipparcos Number", "HIP 106695"},
        {"Smithsonian Astrophysical Observation", "SAO 213133"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.15751610),
        dec: Angle.Degrees(-33.09608842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12267"},
        {"Hipparcos Number", "HIP 9303"},
        {"Smithsonian Astrophysical Observation", "SAO 193432"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.88827927),
        dec: Angle.Degrees(-33.09569417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3156"},
        {"Hipparcos Number", "HIP 2720"},
        {"Smithsonian Astrophysical Observation", "SAO 192620"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.66009139),
        dec: Angle.Degrees(-33.09400327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30829"},
        {"Hipparcos Number", "HIP 22425"},
        {"Smithsonian Astrophysical Observation", "SAO 195327"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.38713264),
        dec: Angle.Degrees(-33.09377677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138923"},
        {"Hipparcos Number", "HIP 76395"},
        {"Geneva Identification System", "GEN# +1.00138923J"},
        {"Smithsonian Astrophysical Observation", "SAO 206795"},
        {"Wilson Evans Batten Catalogue", "WEB 12971"},
    },
    visualMagnitude: 6.26,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.04740479),
        dec: Angle.Degrees(-33.09274641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108083"},
        {"Hipparcos Number", "HIP 60594"},
        {"Smithsonian Astrophysical Observation", "SAO 203448"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.29783316),
        dec: Angle.Degrees(-33.09249211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167230"},
        {"Hipparcos Number", "HIP 89486"},
        {"Smithsonian Astrophysical Observation", "SAO 209919"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.91743437),
        dec: Angle.Degrees(-33.09152798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115592"},
        {"Hipparcos Number", "HIP 64937"},
        {"Geneva Identification System", "GEN# +1.00115592"},
        {"Smithsonian Astrophysical Observation", "SAO 204345"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.65774326),
        dec: Angle.Degrees(-33.09077711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126089"},
        {"Hipparcos Number", "HIP 70405"},
        {"Smithsonian Astrophysical Observation", "SAO 205523"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.06093718),
        dec: Angle.Degrees(-33.08686759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52620"},
        {"Smithsonian Astrophysical Observation", "SAO 201718"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.41434837),
        dec: Angle.Degrees(-33.08570504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24099"},
        {"Hipparcos Number", "HIP 17842"},
        {"Smithsonian Astrophysical Observation", "SAO 194553"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.26429985),
        dec: Angle.Degrees(-33.08512214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12796"},
        {"Hipparcos Number", "HIP 9694"},
        {"Smithsonian Astrophysical Observation", "SAO 193492"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.17372582),
        dec: Angle.Degrees(-33.08379247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222739"},
        {"Hipparcos Number", "HIP 117022"},
        {"Smithsonian Astrophysical Observation", "SAO 214735"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.84397858),
        dec: Angle.Degrees(-33.08268096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214484"},
        {"Hipparcos Number", "HIP 111809"},
        {"Fundamental Katalog 5th Edition", "FK5 3814"},
        {"Geneva Identification System", "GEN# +1.00214484"},
        {"Renson", "Renson 59400"},
        {"Smithsonian Astrophysical Observation", "SAO 213981"},
        {"Wilson Evans Batten Catalogue", "WEB 19973"},
    },
    visualMagnitude: 5.66,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.71443125),
        dec: Angle.Degrees(-33.08138295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62845"},
        {"Hipparcos Number", "HIP 37756"},
    },
    visualMagnitude: 12.16,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.15009727),
        dec: Angle.Degrees(-33.08129778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58617"},
        {"Hipparcos Number", "HIP 35990"},
        {"Smithsonian Astrophysical Observation", "SAO 197978"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.25193184),
        dec: Angle.Degrees(-33.08125840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37760",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37760"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.15786168),
        dec: Angle.Degrees(-33.08081240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37192"},
        {"Hipparcos Number", "HIP 26219"},
        {"Geneva Identification System", "GEN# +1.00037192"},
        {"Smithsonian Astrophysical Observation", "SAO 195986"},
        {"Wilson Evans Batten Catalogue", "WEB 5128"},
    },
    visualMagnitude: 5.76,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.81439488),
        dec: Angle.Degrees(-33.08000909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 117.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56431"},
        {"Hipparcos Number", "HIP 35112"},
        {"Smithsonian Astrophysical Observation", "SAO 197764"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.90441718),
        dec: Angle.Degrees(-33.07846064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221313"},
        {"Hipparcos Number", "HIP 116077"},
        {"Smithsonian Astrophysical Observation", "SAO 214599"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.82151825),
        dec: Angle.Degrees(-33.07592884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16455"},
        {"Hipparcos Number", "HIP 12224"},
        {"Smithsonian Astrophysical Observation", "SAO 193819"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.34972900),
        dec: Angle.Degrees(-33.07547505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
