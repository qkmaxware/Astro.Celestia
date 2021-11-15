using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_105() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71828",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9350 AB"},
        {"Henry Draper", "HD 129600"},
        {"Hipparcos Number", "HIP 71828"},
        {"Smithsonian Astrophysical Observation", "SAO 29246"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.39831433),
        dec: Angle.Degrees(+51.39750893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223615"},
        {"Hipparcos Number", "HIP 117603"},
        {"Smithsonian Astrophysical Observation", "SAO 35835"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.74722476),
        dec: Angle.Degrees(+51.39823647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55878"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.80110326),
        dec: Angle.Degrees(+51.39908661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90876"},
        {"Hipparcos Number", "HIP 51463"},
        {"Smithsonian Astrophysical Observation", "SAO 27672"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.67359556),
        dec: Angle.Degrees(+51.40121371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89251"},
        {"Hipparcos Number", "HIP 50513"},
        {"Geneva Identification System", "GEN# +1.00089251"},
        {"Smithsonian Astrophysical Observation", "SAO 27600"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.74904872),
        dec: Angle.Degrees(+51.40548964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234027"},
        {"Hipparcos Number", "HIP 64847"},
        {"Smithsonian Astrophysical Observation", "SAO 28705"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.39123302),
        dec: Angle.Degrees(+51.40608337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49008"},
        {"Hipparcos Number", "HIP 32684"},
        {"Smithsonian Astrophysical Observation", "SAO 25970"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.27669926),
        dec: Angle.Degrees(+51.40654003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234002"},
        {"Hipparcos Number", "HIP 63498"},
        {"Smithsonian Astrophysical Observation", "SAO 28599"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.16686688),
        dec: Angle.Degrees(+51.40750900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80710",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10079 A"},
        {"Henry Draper", "HD 148880"},
        {"Hipparcos Number", "HIP 80710"},
        {"Fundamental Katalog 5th Edition", "FK5 3304"},
        {"Geneva Identification System", "GEN# +1.00148880"},
        {"Smithsonian Astrophysical Observation", "SAO 29956"},
        {"Wilson Evans Batten Catalogue", "WEB 13651"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.18088709),
        dec: Angle.Degrees(+51.40772092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234850"},
        {"Hipparcos Number", "HIP 94721"},
        {"Smithsonian Astrophysical Observation", "SAO 31526"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.11242713),
        dec: Angle.Degrees(+51.40952315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84912"},
        {"Hipparcos Number", "HIP 48242"},
        {"Smithsonian Astrophysical Observation", "SAO 27395"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.52298625),
        dec: Angle.Degrees(+51.41091808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151463"},
        {"Hipparcos Number", "HIP 81989"},
        {"Smithsonian Astrophysical Observation", "SAO 30074"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.24598334),
        dec: Angle.Degrees(+51.41183498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233594"},
        {"Hipparcos Number", "HIP 44444"},
        {"Smithsonian Astrophysical Observation", "SAO 27099"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.82442228),
        dec: Angle.Degrees(+51.41242084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102882"},
        {"Hipparcos Number", "HIP 57774"},
        {"Smithsonian Astrophysical Observation", "SAO 28160"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.71068623),
        dec: Angle.Degrees(+51.41273718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102921",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14370 AB"},
        {"Henry Draper", "HD 198834"},
        {"Hipparcos Number", "HIP 102921"},
        {"Smithsonian Astrophysical Observation", "SAO 32933"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.77254624),
        dec: Angle.Degrees(+51.41714383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140768"},
        {"Hipparcos Number", "HIP 76981"},
        {"Smithsonian Astrophysical Observation", "SAO 29629"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.78505005),
        dec: Angle.Degrees(+51.41989676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82622"},
        {"Hipparcos Number", "HIP 47009"},
        {"Smithsonian Astrophysical Observation", "SAO 27299"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.71295636),
        dec: Angle.Degrees(+51.42023756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234207"},
        {"Hipparcos Number", "HIP 73894"},
        {"Smithsonian Astrophysical Observation", "SAO 29405"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.54219983),
        dec: Angle.Degrees(+51.42048669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234043"},
        {"Hipparcos Number", "HIP 65716"},
        {"Smithsonian Astrophysical Observation", "SAO 28768"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.09304349),
        dec: Angle.Degrees(+51.42178540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 516"},
        {"Hipparcos Number", "HIP 800"},
        {"Smithsonian Astrophysical Observation", "SAO 21150"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.46840823),
        dec: Angle.Degrees(+51.42303822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89685"},
        {"Hipparcos Number", "HIP 50783"},
        {"Smithsonian Astrophysical Observation", "SAO 27623"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.54033659),
        dec: Angle.Degrees(+51.42373047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201280"},
        {"Hipparcos Number", "HIP 104203"},
        {"Smithsonian Astrophysical Observation", "SAO 33136"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.66971881),
        dec: Angle.Degrees(+51.42600352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222694"},
        {"Hipparcos Number", "HIP 116968"},
        {"Smithsonian Astrophysical Observation", "SAO 35691"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.66961218),
        dec: Angle.Degrees(+51.42769065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54895"},
        {"Hipparcos Number", "HIP 34912"},
        {"Fundamental Katalog 5th Edition", "FK5 2555"},
        {"Geneva Identification System", "GEN# +1.00054895"},
        {"Smithsonian Astrophysical Observation", "SAO 26223"},
        {"Wilson Evans Batten Catalogue", "WEB 6977"},
    },
    visualMagnitude: 5.46,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.34747243),
        dec: Angle.Degrees(+51.42871249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76396"},
        {"Hipparcos Number", "HIP 44032"},
        {"Geneva Identification System", "GEN# +1.00076396"},
        {"Smithsonian Astrophysical Observation", "SAO 27062"},
        {"Wilson Evans Batten Catalogue", "WEB 8462"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.49522350),
        dec: Angle.Degrees(+51.43020505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73447"},
        {"Hipparcos Number", "HIP 42576"},
        {"Geneva Identification System", "GEN# +1.00073447"},
        {"Smithsonian Astrophysical Observation", "SAO 26959"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.17912927),
        dec: Angle.Degrees(+51.43063883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24397",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3780 AB"},
        {"Henry Draper", "HD 33580"},
        {"Hipparcos Number", "HIP 24397"},
        {"Smithsonian Astrophysical Observation", "SAO 25083"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.50700760),
        dec: Angle.Degrees(+51.43104183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208053"},
        {"Hipparcos Number", "HIP 107945"},
        {"Geneva Identification System", "GEN# +1.00208053"},
        {"Smithsonian Astrophysical Observation", "SAO 33818"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.03418117),
        dec: Angle.Degrees(+51.43159749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1337"},
        {"Hipparcos Number", "HIP 1415"},
        {"Geneva Identification System", "GEN# +1.00001337"},
        {"Smithsonian Astrophysical Observation", "SAO 21273"},
        {"Wilson Evans Batten Catalogue", "WEB 257"},
    },
    visualMagnitude: 6.11,
    bvColour: -0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.42944015),
        dec: Angle.Degrees(+51.43309422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236043"},
        {"Hipparcos Number", "HIP 114103"},
        {"Smithsonian Astrophysical Observation", "SAO 35144"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.64222350),
        dec: Angle.Degrees(+51.43535911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233190"},
        {"Hipparcos Number", "HIP 28415"},
        {"Fundamental Katalog 5th Edition", "FK5 4547"},
        {"Smithsonian Astrophysical Observation", "SAO 25511"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.01933641),
        dec: Angle.Degrees(+51.43922132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18663"},
        {"Hipparcos Number", "HIP 14125"},
        {"Geneva Identification System", "GEN# +1.00018663"},
        {"Smithsonian Astrophysical Observation", "SAO 23774"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.54310554),
        dec: Angle.Degrees(+51.44006247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16819",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16819"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.10872548),
        dec: Angle.Degrees(+51.44020765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114084",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114084"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.58884326),
        dec: Angle.Degrees(+51.44083747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3736",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 659 AB"},
        {"Henry Draper", "HD 4536"},
        {"Hipparcos Number", "HIP 3736"},
        {"Smithsonian Astrophysical Observation", "SAO 21716"},
        {"Wilson Evans Batten Catalogue", "WEB 666"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.99596032),
        dec: Angle.Degrees(+51.44478211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77827",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9833 AB"},
        {"Henry Draper", "HD 142654"},
        {"Hipparcos Number", "HIP 77827"},
        {"Smithsonian Astrophysical Observation", "SAO 29702"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.37412757),
        dec: Angle.Degrees(+51.44539744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37008"},
        {"Hipparcos Number", "HIP 26505"},
        {"Cincinnati Publication", "Ci 20 338"},
        {"Geneva Identification System", "GEN# +1.00037008"},
        {"Smithsonian Astrophysical Observation", "SAO 25290"},
        {"Wilson Evans Batten Catalogue", "WEB 5224"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.55156564),
        dec: Angle.Degrees(+51.44548289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -549.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61972"},
    },
    visualMagnitude: 10.89,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.50154597),
        dec: Angle.Degrees(+52.71634269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55405"},
        {"Hipparcos Number", "HIP 35104"},
        {"Smithsonian Astrophysical Observation", "SAO 26249"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.88197550),
        dec: Angle.Degrees(+51.44911291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215442"},
        {"Hipparcos Number", "HIP 112263"},
        {"Fundamental Katalog 5th Edition", "FK5 6003"},
        {"Geneva Identification System", "GEN# +1.00215442"},
        {"Smithsonian Astrophysical Observation", "SAO 34743"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.08079256),
        dec: Angle.Degrees(+51.44941688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25787"},
        {"Hipparcos Number", "HIP 19264"},
        {"Geneva Identification System", "GEN# +1.00025787"},
        {"Smithsonian Astrophysical Observation", "SAO 24424"},
        {"Wilson Evans Batten Catalogue", "WEB 3702"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.93805130),
        dec: Angle.Degrees(+51.45281144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48004"},
        {"Hipparcos Number", "HIP 32250"},
        {"Smithsonian Astrophysical Observation", "SAO 25914"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.00256141),
        dec: Angle.Degrees(+51.45298813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234102"},
        {"Hipparcos Number", "HIP 68744"},
        {"Smithsonian Astrophysical Observation", "SAO 28995"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.07268227),
        dec: Angle.Degrees(+51.45511797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61336"},
        {"Hipparcos Number", "HIP 37457"},
        {"Geneva Identification System", "GEN# +1.00061336"},
        {"Smithsonian Astrophysical Observation", "SAO 26464"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.32971563),
        dec: Angle.Degrees(+51.45582711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94882"},
        {"Hipparcos Number", "HIP 53604"},
        {"Smithsonian Astrophysical Observation", "SAO 27850"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.49486129),
        dec: Angle.Degrees(+51.45795906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234542"},
        {"Hipparcos Number", "HIP 88322"},
        {"Smithsonian Astrophysical Observation", "SAO 30708"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.56956025),
        dec: Angle.Degrees(+51.45838976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99579",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13535 AB"},
        {"Henry Draper", "HD 192439"},
        {"Hipparcos Number", "HIP 99579"},
        {"Geneva Identification System", "GEN# +1.00192439J"},
        {"Smithsonian Astrophysical Observation", "SAO 32354"},
        {"Wilson Evans Batten Catalogue", "WEB 17820"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.13221351),
        dec: Angle.Degrees(+51.46360234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144656"},
        {"Hipparcos Number", "HIP 78745"},
        {"Smithsonian Astrophysical Observation", "SAO 29783"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.14725699),
        dec: Angle.Degrees(+51.46413993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232190"},
        {"Hipparcos Number", "HIP 2192"},
        {"Smithsonian Astrophysical Observation", "SAO 21416"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.92272026),
        dec: Angle.Degrees(+51.46436655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235298"},
        {"Hipparcos Number", "HIP 101792"},
        {"Smithsonian Astrophysical Observation", "SAO 32741"},
        {"Wilson Evans Batten Catalogue", "WEB 18393"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.44374003),
        dec: Angle.Degrees(+51.46546507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135677"},
        {"Hipparcos Number", "HIP 74576"},
        {"Smithsonian Astrophysical Observation", "SAO 29455"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.56827549),
        dec: Angle.Degrees(+51.46868688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234066"},
        {"Hipparcos Number", "HIP 66995"},
        {"Smithsonian Astrophysical Observation", "SAO 28865"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.94950895),
        dec: Angle.Degrees(+51.46896209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36242"},
        {"Hipparcos Number", "HIP 26031"},
        {"Celescope Catalog", "CEL 761"},
        {"Geneva Identification System", "GEN# +1.00036242"},
        {"Smithsonian Astrophysical Observation", "SAO 25247"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.30692756),
        dec: Angle.Degrees(+51.47042748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110213"},
    },
    visualMagnitude: 11.28,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.87805608),
        dec: Angle.Degrees(+51.47078754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161179"},
        {"Hipparcos Number", "HIP 86563"},
        {"Smithsonian Astrophysical Observation", "SAO 30521"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.34381079),
        dec: Angle.Degrees(+51.47134560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225021"},
        {"Hipparcos Number", "HIP 213"},
        {"Geneva Identification System", "GEN# +1.00225021"},
        {"Smithsonian Astrophysical Observation", "SAO 21026"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.66686344),
        dec: Angle.Degrees(+51.47241278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19538"},
        {"Hipparcos Number", "HIP 14768"},
        {"Smithsonian Astrophysical Observation", "SAO 23853"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.66729830),
        dec: Angle.Degrees(+51.47255703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11335"},
        {"Hipparcos Number", "HIP 8771"},
        {"Celescope Catalog", "CEL 177"},
        {"Geneva Identification System", "GEN# +1.00011335"},
        {"Smithsonian Astrophysical Observation", "SAO 22705"},
        {"Wilson Evans Batten Catalogue", "WEB 1846"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.21140471),
        dec: Angle.Degrees(+51.47485303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88402"},
        {"Hipparcos Number", "HIP 50035"},
        {"Geneva Identification System", "GEN# +1.00088402"},
        {"Smithsonian Astrophysical Observation", "SAO 27558"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.23337957),
        dec: Angle.Degrees(+51.47606436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233923"},
        {"Hipparcos Number", "HIP 60116"},
        {"Smithsonian Astrophysical Observation", "SAO 28341"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.92738642),
        dec: Angle.Degrees(+51.47661170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206349"},
        {"Hipparcos Number", "HIP 106973"},
        {"Geneva Identification System", "GEN# +1.00206349"},
        {"Smithsonian Astrophysical Observation", "SAO 33642"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.97963121),
        dec: Angle.Degrees(+51.47687864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73158"},
        {"Hipparcos Number", "HIP 42429"},
        {"Geneva Identification System", "GEN# +1.00073158"},
        {"Smithsonian Astrophysical Observation", "SAO 26945"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.78289883),
        dec: Angle.Degrees(+51.47805486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218867"},
        {"Hipparcos Number", "HIP 114454"},
        {"Smithsonian Astrophysical Observation", "SAO 35196"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.69952724),
        dec: Angle.Degrees(+51.48068474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110277"},
        {"Hipparcos Number", "HIP 61846"},
        {"Geneva Identification System", "GEN# +1.00110277"},
        {"Smithsonian Astrophysical Observation", "SAO 28474"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.13165323),
        dec: Angle.Degrees(+51.48188712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234074"},
        {"Hipparcos Number", "HIP 67429"},
        {"Smithsonian Astrophysical Observation", "SAO 28896"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.29147280),
        dec: Angle.Degrees(+51.48335781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211301"},
        {"Hipparcos Number", "HIP 109861"},
        {"Smithsonian Astrophysical Observation", "SAO 34225"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.76379532),
        dec: Angle.Degrees(+51.48483357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98945"},
        {"Hipparcos Number", "HIP 55610"},
        {"Smithsonian Astrophysical Observation", "SAO 28006"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.89651656),
        dec: Angle.Degrees(+51.48674796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34634"},
        {"Hipparcos Number", "HIP 25052"},
        {"Cincinnati Publication", "Ci 18 680"},
        {"Geneva Identification System", "GEN# +1.00034634"},
        {"Smithsonian Astrophysical Observation", "SAO 25143"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.45455296),
        dec: Angle.Degrees(+51.48680715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 238.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -230.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43339"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.43811633),
        dec: Angle.Degrees(+51.48733144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112348",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16249 AB"},
        {"Henry Draper", "HD 215590"},
        {"Hipparcos Number", "HIP 112348"},
        {"Smithsonian Astrophysical Observation", "SAO 34766"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.34263873),
        dec: Angle.Degrees(+51.48855497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147748"},
        {"Hipparcos Number", "HIP 80110"},
        {"Geneva Identification System", "GEN# +1.00147748"},
        {"Smithsonian Astrophysical Observation", "SAO 29907"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.28536988),
        dec: Angle.Degrees(+51.48856963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87833",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Eltanin"},
        {"Aitken", "ADS 10923 A"},
        {"Henry Draper", "HD 164058"},
        {"Hipparcos Number", "HIP 87833"},
        {"Fundamental Katalog 5th Edition", "FK5 676"},
        {"Geneva Identification System", "GEN# +1.00164058"},
        {"Smithsonian Astrophysical Observation", "SAO 30653"},
        {"Wilson Evans Batten Catalogue", "WEB 14827"},
    },
    visualMagnitude: 2.24,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.15157439),
        dec: Angle.Degrees(+51.48895101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232804"},
        {"Hipparcos Number", "HIP 16506"},
        {"Geneva Identification System", "GEN# +5.20200972"},
        {"Smithsonian Astrophysical Observation", "SAO 24087"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.13279104),
        dec: Angle.Degrees(+51.48965010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224275"},
        {"Hipparcos Number", "HIP 118044"},
        {"Smithsonian Astrophysical Observation", "SAO 35912"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.15480991),
        dec: Angle.Degrees(+51.49260380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213050"},
        {"Hipparcos Number", "HIP 110871"},
        {"Smithsonian Astrophysical Observation", "SAO 34471"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.93163457),
        dec: Angle.Degrees(+51.49284899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85277",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10552 AB"},
        {"Henry Draper", "HD 158260"},
        {"Hipparcos Number", "HIP 85277"},
        {"Smithsonian Astrophysical Observation", "SAO 30381"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.37267567),
        dec: Angle.Degrees(+51.49314272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56354"},
        {"Hipparcos Number", "HIP 35472"},
        {"Geneva Identification System", "GEN# +1.00056354"},
        {"Smithsonian Astrophysical Observation", "SAO 26272"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.83666663),
        dec: Angle.Degrees(+51.49364049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99389",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99389"},
    },
    visualMagnitude: 12.48,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.60092364),
        dec: Angle.Degrees(+51.49565995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18603",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2896 B"},
        {"Henry Draper", "HD 24775B"},
        {"Hipparcos Number", "HIP 18603"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.70979590),
        dec: Angle.Degrees(+51.49666016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158896"},
        {"Hipparcos Number", "HIP 85554"},
        {"Smithsonian Astrophysical Observation", "SAO 30414"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.25898752),
        dec: Angle.Degrees(+51.49764128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115734"},
        {"Hipparcos Number", "HIP 64898"},
        {"Smithsonian Astrophysical Observation", "SAO 28713"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.53513969),
        dec: Angle.Degrees(+51.49786704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18604",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2896 A"},
        {"Henry Draper", "HD 24775"},
        {"Hipparcos Number", "HIP 18604"},
        {"Geneva Identification System", "GEN# +1.00024775J"},
        {"Smithsonian Astrophysical Observation", "SAO 24326"},
        {"Wilson Evans Batten Catalogue", "WEB 3585"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.71373444),
        dec: Angle.Degrees(+51.49902868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103258",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103258"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.78028350),
        dec: Angle.Degrees(+51.50113057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95233"},
        {"Hipparcos Number", "HIP 53798"},
        {"Smithsonian Astrophysical Observation", "SAO 27868"},
        {"Wilson Evans Batten Catalogue", "WEB 9746"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.10659506),
        dec: Angle.Degrees(+51.50214021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235648"},
        {"Hipparcos Number", "HIP 108054"},
        {"Celescope Catalog", "CEL 5401"},
        {"Geneva Identification System", "GEN# +1.00235648"},
        {"Smithsonian Astrophysical Observation", "SAO 33838"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.36299218),
        dec: Angle.Degrees(+51.50297697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176316"},
        {"Hipparcos Number", "HIP 93019"},
        {"Celescope Catalog", "CEL 4672"},
        {"Geneva Identification System", "GEN# +1.00176316"},
        {"Smithsonian Astrophysical Observation", "SAO 31280"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.25777531),
        dec: Angle.Degrees(+51.50425111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235397"},
        {"Hipparcos Number", "HIP 103204"},
        {"Smithsonian Astrophysical Observation", "SAO 32986"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.64552560),
        dec: Angle.Degrees(+51.50624546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 291.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39847",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6600 A"},
        {"Henry Draper", "HD 67006"},
        {"Hipparcos Number", "HIP 39847"},
        {"Fundamental Katalog 5th Edition", "FK5 307"},
        {"Geneva Identification System", "GEN# +1.00067006"},
        {"Smithsonian Astrophysical Observation", "SAO 26687"},
        {"Wilson Evans Batten Catalogue", "WEB 7769"},
    },
    visualMagnitude: 4.78,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.11459795),
        dec: Angle.Degrees(+51.50667575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4818"},
        {"Hipparcos Number", "HIP 3965"},
        {"Geneva Identification System", "GEN# +1.00004818"},
        {"Smithsonian Astrophysical Observation", "SAO 21767"},
        {"Wilson Evans Batten Catalogue", "WEB 709"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.73860936),
        dec: Angle.Degrees(+51.50803371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213243"},
        {"Hipparcos Number", "HIP 110977"},
        {"Smithsonian Astrophysical Observation", "SAO 34500"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.26680419),
        dec: Angle.Degrees(+51.50818278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16294",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16294"},
        {"Geneva Identification System", "GEN# +5.20200859"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.51541831),
        dec: Angle.Degrees(+51.51215765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234787"},
        {"Hipparcos Number", "HIP 93555"},
        {"Smithsonian Astrophysical Observation", "SAO 31349"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.82960023),
        dec: Angle.Degrees(+51.51405500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109703"},
        {"Hipparcos Number", "HIP 61520"},
        {"Geneva Identification System", "GEN# +1.00109703"},
        {"Smithsonian Astrophysical Observation", "SAO 28442"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.07082263),
        dec: Angle.Degrees(+51.51460118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38765"},
        {"Hipparcos Number", "HIP 27625"},
        {"Fundamental Katalog 5th Edition", "FK5 2437"},
        {"Geneva Identification System", "GEN# +1.00038765"},
        {"Smithsonian Astrophysical Observation", "SAO 25411"},
        {"Wilson Evans Batten Catalogue", "WEB 5422"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.73423322),
        dec: Angle.Degrees(+51.51469887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10498"},
        {"Hipparcos Number", "HIP 8063"},
        {"Smithsonian Astrophysical Observation", "SAO 22551"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.90092910),
        dec: Angle.Degrees(+51.51582552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236034"},
        {"Hipparcos Number", "HIP 113934"},
        {"Smithsonian Astrophysical Observation", "SAO 35117"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.08249733),
        dec: Angle.Degrees(+51.51617935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59492"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.00911991),
        dec: Angle.Degrees(+51.51640147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232768"},
        {"Henry Draper 2", "HD 232767"},
        {"Hipparcos Number", "HIP 15167"},
        {"Renson", "Renson 4957"},
        {"Smithsonian Astrophysical Observation", "SAO 23900"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.87674507),
        dec: Angle.Degrees(+51.51782888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33085",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5531 A"},
        {"Henry Draper", "HD 49902"},
        {"Hipparcos Number", "HIP 33085"},
        {"Geneva Identification System", "GEN# +1.00049902"},
        {"Smithsonian Astrophysical Observation", "SAO 26023"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.35909023),
        dec: Angle.Degrees(+51.51809174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209192"},
        {"Hipparcos Number", "HIP 108609"},
        {"Geneva Identification System", "GEN# +1.00209192"},
        {"Smithsonian Astrophysical Observation", "SAO 33956"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.03015711),
        dec: Angle.Degrees(+51.51822959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233702"},
        {"Hipparcos Number", "HIP 49383"},
        {"Smithsonian Astrophysical Observation", "SAO 27509"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.23052084),
        dec: Angle.Degrees(+51.51905027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38229"},
        {"Hipparcos Number", "HIP 27293"},
        {"Geneva Identification System", "GEN# +1.00038229"},
        {"Smithsonian Astrophysical Observation", "SAO 25371"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.75023153),
        dec: Angle.Degrees(+51.52096739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139223"},
        {"Hipparcos Number", "HIP 76273"},
        {"Smithsonian Astrophysical Observation", "SAO 29577"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.69552299),
        dec: Angle.Degrees(+51.52098060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223916"},
        {"Hipparcos Number", "HIP 117807"},
        {"Smithsonian Astrophysical Observation", "SAO 35869"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.39272169),
        dec: Angle.Degrees(+51.52256754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7114"},
        {"Hipparcos Number", "HIP 5630"},
    },
    visualMagnitude: 8.14,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.07902731),
        dec: Angle.Degrees(+51.52504589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41672"},
        {"Hipparcos Number", "HIP 29183"},
        {"Smithsonian Astrophysical Observation", "SAO 25595"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.34654409),
        dec: Angle.Degrees(+51.52533293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113166",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16368 AB"},
        {"Henry Draper", "HD 235994"},
        {"Hipparcos Number", "HIP 113166"},
        {"Geneva Identification System", "GEN# +1.00235994J"},
        {"Smithsonian Astrophysical Observation", "SAO 34947"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.74797763),
        dec: Angle.Degrees(+51.52553712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59172"},
        {"Hipparcos Number", "HIP 36580"},
        {"Smithsonian Astrophysical Observation", "SAO 26388"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.85592249),
        dec: Angle.Degrees(+51.52694749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131288"},
        {"Hipparcos Number", "HIP 72612"},
        {"Smithsonian Astrophysical Observation", "SAO 29307"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.69443816),
        dec: Angle.Degrees(+51.52880042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23452"},
        {"Hipparcos Number", "HIP 17718"},
        {"Geneva Identification System", "GEN# +1.00023452"},
        {"Smithsonian Astrophysical Observation", "SAO 24219"},
        {"Wilson Evans Batten Catalogue", "WEB 3386"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.91694022),
        dec: Angle.Degrees(+51.52889435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13882"},
        {"Hipparcos Number", "HIP 10628"},
        {"Geneva Identification System", "GEN# +1.00013882"},
        {"Smithsonian Astrophysical Observation", "SAO 23118"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.20525827),
        dec: Angle.Degrees(+51.52895791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54528",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54528"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.36531539),
        dec: Angle.Degrees(+51.53089407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225237"},
        {"Hipparcos Number", "HIP 381"},
        {"Geneva Identification System", "GEN# +1.00225237"},
        {"Smithsonian Astrophysical Observation", "SAO 21058"},
    },
    visualMagnitude: 8.72,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.18518654),
        dec: Angle.Degrees(+51.53385066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232702"},
        {"Hipparcos Number", "HIP 12724"},
        {"Smithsonian Astrophysical Observation", "SAO 23566"},
        {"Wilson Evans Batten Catalogue", "WEB 2590"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.89472109),
        dec: Angle.Degrees(+51.53432713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108845"},
        {"Hipparcos Number", "HIP 60988"},
        {"Geneva Identification System", "GEN# +1.00108845"},
        {"Smithsonian Astrophysical Observation", "SAO 28407"},
        {"Wilson Evans Batten Catalogue", "WEB 10858"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.51293210),
        dec: Angle.Degrees(+51.53556985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -293.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106557",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106557"},
        {"Cincinnati Publication", "Ci 20 1297"},
    },
    visualMagnitude: 12.01,
    bvColour: 1.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.70795231),
        dec: Angle.Degrees(+51.53634769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 456.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 310.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233984"},
        {"Hipparcos Number", "HIP 62604"},
        {"Smithsonian Astrophysical Observation", "SAO 28530"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.42730860),
        dec: Angle.Degrees(+51.53688234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66448"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.32687384),
        dec: Angle.Degrees(+51.53801970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -222.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232711"},
        {"Hipparcos Number", "HIP 13093"},
        {"Smithsonian Astrophysical Observation", "SAO 23623"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.08227209),
        dec: Angle.Degrees(+51.53966606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236000"},
        {"Hipparcos Number", "HIP 113309"},
        {"Smithsonian Astrophysical Observation", "SAO 34982"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.20263059),
        dec: Angle.Degrees(+51.54142485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169487"},
        {"Hipparcos Number", "HIP 90031"},
        {"Smithsonian Astrophysical Observation", "SAO 30932"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.54910559),
        dec: Angle.Degrees(+51.54193453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81901",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10189 AB"},
        {"Henry Draper", "HD 151267"},
        {"Hipparcos Number", "HIP 81901"},
        {"Smithsonian Astrophysical Observation", "SAO 30067"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.93887599),
        dec: Angle.Degrees(+51.54240463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30723"},
        {"Hipparcos Number", "HIP 22695"},
        {"Geneva Identification System", "GEN# +1.00030723"},
        {"Smithsonian Astrophysical Observation", "SAO 24891"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.19443379),
        dec: Angle.Degrees(+51.54292094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232712"},
        {"Hipparcos Number", "HIP 13097"},
        {"Smithsonian Astrophysical Observation", "SAO 23624"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.10098731),
        dec: Angle.Degrees(+51.54322871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7044"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.70520236),
        dec: Angle.Degrees(+51.54353617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214454"},
        {"Hipparcos Number", "HIP 111674"},
        {"Celescope Catalog", "CEL 5500"},
        {"Geneva Identification System", "GEN# +1.00214454"},
        {"Smithsonian Astrophysical Observation", "SAO 34628"},
        {"Wilson Evans Batten Catalogue", "WEB 19959"},
    },
    visualMagnitude: 4.64,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.34360749),
        dec: Angle.Degrees(+51.54537399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59875"},
        {"Hipparcos Number", "HIP 36855"},
        {"Geneva Identification System", "GEN# +1.00059875"},
        {"Smithsonian Astrophysical Observation", "SAO 26413"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.66346626),
        dec: Angle.Degrees(+51.54593806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214879"},
        {"Hipparcos Number", "HIP 111924"},
        {"Geneva Identification System", "GEN# +1.00214879"},
        {"Smithsonian Astrophysical Observation", "SAO 34681"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.07367714),
        dec: Angle.Degrees(+51.54774769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234700"},
        {"Hipparcos Number", "HIP 91942"},
        {"Smithsonian Astrophysical Observation", "SAO 31141"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.12956616),
        dec: Angle.Degrees(+51.54873717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81773"},
        {"Hipparcos Number", "HIP 46540"},
        {"Smithsonian Astrophysical Observation", "SAO 27269"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.37941036),
        dec: Angle.Degrees(+51.54903109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79030"},
        {"Hipparcos Number", "HIP 45253"},
        {"Smithsonian Astrophysical Observation", "SAO 27173"},
    },
    visualMagnitude: 9.33,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.34661855),
        dec: Angle.Degrees(+51.54919743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17257"},
        {"Hipparcos Number", "HIP 13076"},
        {"Smithsonian Astrophysical Observation", "SAO 23618"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.01278333),
        dec: Angle.Degrees(+51.55167189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157893"},
        {"Hipparcos Number", "HIP 85074"},
        {"Geneva Identification System", "GEN# +1.00157893"},
        {"Smithsonian Astrophysical Observation", "SAO 30364"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.80141862),
        dec: Angle.Degrees(+51.55521361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223166"},
        {"Hipparcos Number", "HIP 117302"},
        {"Smithsonian Astrophysical Observation", "SAO 35762"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.76861080),
        dec: Angle.Degrees(+51.55688112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236195"},
        {"Hipparcos Number", "HIP 116784"},
        {"Smithsonian Astrophysical Observation", "SAO 35653"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.01698137),
        dec: Angle.Degrees(+51.55735945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234392"},
        {"Hipparcos Number", "HIP 83715"},
        {"Smithsonian Astrophysical Observation", "SAO 30252"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.64788788),
        dec: Angle.Degrees(+51.55769472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107950"},
        {"Hipparcos Number", "HIP 60485"},
        {"Fundamental Katalog 5th Edition", "FK5 2994"},
        {"Geneva Identification System", "GEN# +1.00107950"},
        {"Smithsonian Astrophysical Observation", "SAO 28366"},
        {"Wilson Evans Batten Catalogue", "WEB 10757"},
    },
    visualMagnitude: 4.76,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.00617625),
        dec: Angle.Degrees(+51.56222925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234047"},
        {"Hipparcos Number", "HIP 65883"},
        {"Smithsonian Astrophysical Observation", "SAO 28778"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.57571325),
        dec: Angle.Degrees(+51.56290193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19090"},
        {"Hipparcos Number", "HIP 14425"},
        {"Smithsonian Astrophysical Observation", "SAO 23805"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.55931845),
        dec: Angle.Degrees(+51.56422103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 499"},
        {"Hipparcos Number", "HIP 781"},
        {"Wilson Evans Batten Catalogue", "WEB 133"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.40219061),
        dec: Angle.Degrees(+51.56692488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20112"},
        {"Hipparcos Number", "HIP 15215"},
        {"Geneva Identification System", "GEN# +5.20200311"},
        {"Smithsonian Astrophysical Observation", "SAO 23911"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.03226981),
        dec: Angle.Degrees(+51.56697589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51970"},
        {"Hipparcos Number", "HIP 33913"},
        {"Fundamental Katalog 5th Edition", "FK5 4634"},
        {"Geneva Identification System", "GEN# +1.00051970"},
        {"Smithsonian Astrophysical Observation", "SAO 26107"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.57115648),
        dec: Angle.Degrees(+51.56819934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86165"},
        {"Hipparcos Number", "HIP 48887"},
        {"Geneva Identification System", "GEN# +1.00086165"},
        {"Smithsonian Astrophysical Observation", "SAO 27444"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.56607646),
        dec: Angle.Degrees(+51.56906401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139970"},
        {"Hipparcos Number", "HIP 76624"},
        {"Smithsonian Astrophysical Observation", "SAO 29604"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.72055589),
        dec: Angle.Degrees(+51.57015155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4881"},
        {"Hipparcos Number", "HIP 4023"},
        {"Geneva Identification System", "GEN# +1.00004881"},
        {"Smithsonian Astrophysical Observation", "SAO 21775"},
        {"Wilson Evans Batten Catalogue", "WEB 721"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.89079551),
        dec: Angle.Degrees(+51.57145327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70938"},
    },
    visualMagnitude: 10.76,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.64646267),
        dec: Angle.Degrees(+51.57267878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28765",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4633 A"},
        {"Henry Draper", "HD 40873"},
        {"Hipparcos Number", "HIP 28765"},
        {"Fundamental Katalog 5th Edition", "FK5 2463"},
        {"Geneva Identification System", "GEN# +1.00040873A"},
        {"Renson", "Renson 10923"},
        {"Smithsonian Astrophysical Observation", "SAO 25548"},
        {"Wilson Evans Batten Catalogue", "WEB 5626"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.12127446),
        dec: Angle.Degrees(+51.57349870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46168",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7348 AB"},
        {"Henry Draper", "HD 81025"},
        {"Hipparcos Number", "HIP 46168"},
        {"Geneva Identification System", "GEN# +1.00081025J"},
        {"Smithsonian Astrophysical Observation", "SAO 27246"},
        {"Wilson Evans Batten Catalogue", "WEB 8742"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.23183965),
        dec: Angle.Degrees(+51.57391520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213089"},
        {"Hipparcos Number", "HIP 110888"},
        {"Celescope Catalog", "CEL 5478"},
        {"Geneva Identification System", "GEN# +1.00213089"},
        {"Smithsonian Astrophysical Observation", "SAO 34475"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.97560968),
        dec: Angle.Degrees(+51.57569254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235668"},
        {"Hipparcos Number", "HIP 108326"},
        {"Geneva Identification System", "GEN# +1.00235668"},
        {"Smithsonian Astrophysical Observation", "SAO 33895"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.18763567),
        dec: Angle.Degrees(+51.57604248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20615"},
        {"Hipparcos Number", "HIP 15632"},
        {"Smithsonian Astrophysical Observation", "SAO 23971"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.32427548),
        dec: Angle.Degrees(+51.57664836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232383"},
        {"Hipparcos Number", "HIP 5436"},
        {"Smithsonian Astrophysical Observation", "SAO 22041"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.38906790),
        dec: Angle.Degrees(+51.57715985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71548",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9329 AB"},
        {"Henry Draper", "HD 128941"},
        {"Hipparcos Number", "HIP 71548"},
        {"Smithsonian Astrophysical Observation", "SAO 29224"},
        {"Wilson Evans Batten Catalogue", "WEB 12340"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.50318819),
        dec: Angle.Degrees(+51.57833725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100255",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100255"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.99440974),
        dec: Angle.Degrees(+51.57908758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138134"},
        {"Hipparcos Number", "HIP 75703"},
        {"Smithsonian Astrophysical Observation", "SAO 29535"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.98608939),
        dec: Angle.Degrees(+51.58192088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233922"},
        {"Hipparcos Number", "HIP 60109"},
        {"Smithsonian Astrophysical Observation", "SAO 28340"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.91632504),
        dec: Angle.Degrees(+51.58252849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236166"},
        {"Hipparcos Number", "HIP 116313"},
        {"Smithsonian Astrophysical Observation", "SAO 35550"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.49540403),
        dec: Angle.Degrees(+51.58342507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201431"},
        {"Hipparcos Number", "HIP 104283"},
        {"Celescope Catalog", "CEL 5248"},
        {"Geneva Identification System", "GEN# +1.00201431"},
        {"Smithsonian Astrophysical Observation", "SAO 33153"},
    },
    visualMagnitude: 7.37,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.90122092),
        dec: Angle.Degrees(+51.58401972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236168"},
        {"Hipparcos Number", "HIP 116316"},
        {"Smithsonian Astrophysical Observation", "SAO 35552"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.51506743),
        dec: Angle.Degrees(+51.58440588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16997"},
        {"Hipparcos Number", "HIP 12873"},
        {"Smithsonian Astrophysical Observation", "SAO 23591"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.36989463),
        dec: Angle.Degrees(+51.58584977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142343"},
        {"Hipparcos Number", "HIP 77695"},
        {"Smithsonian Astrophysical Observation", "SAO 29696"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.94820091),
        dec: Angle.Degrees(+51.58713799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108814"},
        {"Hipparcos Number", "HIP 60966"},
        {"Smithsonian Astrophysical Observation", "SAO 28404"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.46746174),
        dec: Angle.Degrees(+51.58824778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93530",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11997 AB"},
        {"Henry Draper", "HD 234786"},
        {"Hipparcos Number", "HIP 93530"},
        {"Smithsonian Astrophysical Observation", "SAO 31345"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.74190935),
        dec: Angle.Degrees(+51.58935124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16965"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.56417673),
        dec: Angle.Degrees(+51.58960792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85214"},
        {"Hipparcos Number", "HIP 48397"},
        {"Smithsonian Astrophysical Observation", "SAO 27407"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.00145479),
        dec: Angle.Degrees(+51.58966517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19979"},
        {"Hipparcos Number", "HIP 15097"},
        {"Smithsonian Astrophysical Observation", "SAO 23894"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.69116957),
        dec: Angle.Degrees(+51.58982462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80656",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10076 AB"},
        {"Henry Draper", "HD 148801"},
        {"Hipparcos Number", "HIP 80656"},
        {"Geneva Identification System", "GEN# +1.00148801J"},
        {"Smithsonian Astrophysical Observation", "SAO 29953"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.00524707),
        dec: Angle.Degrees(+51.59205932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123821"},
        {"Hipparcos Number", "HIP 69089"},
        {"Geneva Identification System", "GEN# +1.00123821"},
        {"Smithsonian Astrophysical Observation", "SAO 29017"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.11435587),
        dec: Angle.Degrees(+51.59239577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234195"},
        {"Hipparcos Number", "HIP 73209"},
        {"Smithsonian Astrophysical Observation", "SAO 29356"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.43146897),
        dec: Angle.Degrees(+51.59318090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97168",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97168"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.24677330),
        dec: Angle.Degrees(+51.59475779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 136.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6287",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1083 AB"},
        {"Henry Draper", "HD 8027"},
        {"Hipparcos Number", "HIP 6287"},
        {"Celescope Catalog", "CEL 136"},
        {"Smithsonian Astrophysical Observation", "SAO 22201"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.16899498),
        dec: Angle.Degrees(+51.59479009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23783",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3675 A"},
        {"Henry Draper", "HD 32537"},
        {"Henry Draper 2", "HD 32537A"},
        {"Hipparcos Number", "HIP 23783"},
        {"Geneva Identification System", "GEN# +1.00032537A"},
        {"Smithsonian Astrophysical Observation", "SAO 25019"},
        {"Wilson Evans Batten Catalogue", "WEB 4640"},
    },
    visualMagnitude: 4.98,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.66940952),
        dec: Angle.Degrees(+51.59814314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7169"},
        {"Hipparcos Number", "HIP 5674"},
        {"Geneva Identification System", "GEN# +1.00007169"},
        {"Smithsonian Astrophysical Observation", "SAO 22094"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.22443868),
        dec: Angle.Degrees(+51.60251016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234023"},
        {"Hipparcos Number", "HIP 64606"},
        {"Smithsonian Astrophysical Observation", "SAO 28683"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.62531436),
        dec: Angle.Degrees(+51.60430176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31032"},
        {"Hipparcos Number", "HIP 22869"},
        {"Smithsonian Astrophysical Observation", "SAO 24910"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.79226704),
        dec: Angle.Degrees(+51.60464807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78209"},
        {"Hipparcos Number", "HIP 44901"},
        {"Fundamental Katalog 5th Edition", "FK5 2721"},
        {"Geneva Identification System", "GEN# +1.00078209"},
        {"Renson", "Renson 22160"},
        {"Smithsonian Astrophysical Observation", "SAO 27136"},
        {"Wilson Evans Batten Catalogue", "WEB 8576"},
    },
    visualMagnitude: 4.46,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.21827365),
        dec: Angle.Degrees(+51.60472728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217225"},
        {"Hipparcos Number", "HIP 113446"},
        {"Smithsonian Astrophysical Observation", "SAO 35011"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.64623475),
        dec: Angle.Degrees(+51.60787589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106175",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106175"},
        {"Geneva Identification System", "GEN# +2.70860131"},
        {"New General Catalogue", "NGC 7086 131"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.58948478),
        dec: Angle.Degrees(+51.61014872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13271"},
        {"Hipparcos Number", "HIP 10204"},
        {"Smithsonian Astrophysical Observation", "SAO 23009"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.80329713),
        dec: Angle.Degrees(+51.61152162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221727"},
        {"Hipparcos Number", "HIP 116333"},
        {"Smithsonian Astrophysical Observation", "SAO 35558"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.58407598),
        dec: Angle.Degrees(+51.61262348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67683",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9040 A"},
        {"Henry Draper", "HD 234079"},
        {"Hipparcos Number", "HIP 67683"},
        {"Smithsonian Astrophysical Observation", "SAO 28911"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.98280702),
        dec: Angle.Degrees(+51.61311365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32738",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5462 B"},
        {"Hipparcos Number", "HIP 32738"},
    },
    visualMagnitude: 10.74,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.42087345),
        dec: Angle.Degrees(+53.03315245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232966"},
        {"Hipparcos Number", "HIP 21011"},
        {"Smithsonian Astrophysical Observation", "SAO 24655"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.59068303),
        dec: Angle.Degrees(+51.61326838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48655"},
        {"Geneva Identification System", "GEN# +6.10060300"},
    },
    visualMagnitude: 12.80,
    bvColour: -0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.83140900),
        dec: Angle.Degrees(+51.61663034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233888"},
        {"Hipparcos Number", "HIP 58501"},
        {"Geneva Identification System", "GEN# +1.00233888A"},
        {"Smithsonian Astrophysical Observation", "SAO 28213"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.96146605),
        dec: Angle.Degrees(+51.61665257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1011"},
        {"Hipparcos Number", "HIP 1178"},
        {"Smithsonian Astrophysical Observation", "SAO 21237"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.67258112),
        dec: Angle.Degrees(+51.61690202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136342"},
        {"Hipparcos Number", "HIP 74873"},
        {"Fundamental Katalog 5th Edition", "FK5 5358"},
        {"Geneva Identification System", "GEN# +1.00136342"},
        {"Smithsonian Astrophysical Observation", "SAO 29474"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.53274448),
        dec: Angle.Degrees(+51.61708130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20537"},
        {"Hipparcos Number", "HIP 15556"},
        {"Geneva Identification System", "GEN# +5.20200450"},
        {"Smithsonian Astrophysical Observation", "SAO 23962"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.09851307),
        dec: Angle.Degrees(+51.61842317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133445"},
        {"Hipparcos Number", "HIP 73590"},
        {"Smithsonian Astrophysical Observation", "SAO 29388"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.63046073),
        dec: Angle.Degrees(+51.61968170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234217"},
        {"Hipparcos Number", "HIP 74349"},
        {"Smithsonian Astrophysical Observation", "SAO 29437"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.91955316),
        dec: Angle.Degrees(+51.61972247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117551",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17032 A"},
        {"Henry Draper", "HD 223552"},
        {"Hipparcos Number", "HIP 117551"},
        {"Geneva Identification System", "GEN# +1.00223552"},
        {"Smithsonian Astrophysical Observation", "SAO 35823"},
        {"Wilson Evans Batten Catalogue", "WEB 20699"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.59216579),
        dec: Angle.Degrees(+51.62170663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106172"},
        {"Geneva Identification System", "GEN# +2.70860066"},
        {"New General Catalogue", "NGC 7086 66"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.58754186),
        dec: Angle.Degrees(+51.62454107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232627"},
        {"Hipparcos Number", "HIP 10604"},
        {"Smithsonian Astrophysical Observation", "SAO 23111"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.13158138),
        dec: Angle.Degrees(+51.62628204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33306"},
        {"Hipparcos Number", "HIP 24231"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.03776876),
        dec: Angle.Degrees(+51.62628255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130370"},
        {"Hipparcos Number", "HIP 72193"},
        {"Smithsonian Astrophysical Observation", "SAO 29270"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.49064087),
        dec: Angle.Degrees(+51.62653855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207515"},
        {"Hipparcos Number", "HIP 107623"},
        {"Geneva Identification System", "GEN# +1.00207515"},
        {"Smithsonian Astrophysical Observation", "SAO 33764"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.99127574),
        dec: Angle.Degrees(+51.62690148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168152"},
        {"Hipparcos Number", "HIP 89485"},
        {"Smithsonian Astrophysical Observation", "SAO 30844"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.91690640),
        dec: Angle.Degrees(+51.62917431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 138.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25718"},
        {"Hipparcos Number", "HIP 19225"},
        {"Smithsonian Astrophysical Observation", "SAO 24418"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.80520522),
        dec: Angle.Degrees(+51.62978987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77890"},
        {"Hipparcos Number", "HIP 44752"},
        {"Smithsonian Astrophysical Observation", "SAO 27128"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.80644949),
        dec: Angle.Degrees(+51.62995032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82495"},
    },
    visualMagnitude: 11.16,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.89880589),
        dec: Angle.Degrees(+51.63291528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233759"},
        {"Hipparcos Number", "HIP 52346"},
        {"Smithsonian Astrophysical Observation", "SAO 27736"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.47173791),
        dec: Angle.Degrees(+51.63325195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44556"},
        {"Hipparcos Number", "HIP 30539"},
        {"Smithsonian Astrophysical Observation", "SAO 25716"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.29995546),
        dec: Angle.Degrees(+51.63329554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80022"},
        {"Hipparcos Number", "HIP 45719"},
        {"Geneva Identification System", "GEN# +1.00080022"},
        {"Smithsonian Astrophysical Observation", "SAO 27210"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.80297796),
        dec: Angle.Degrees(+51.63338242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111179"},
        {"Hipparcos Number", "HIP 62364"},
        {"Geneva Identification System", "GEN# +1.00111179"},
        {"Smithsonian Astrophysical Observation", "SAO 28513"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.70175511),
        dec: Angle.Degrees(+51.63672158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145455"},
        {"Hipparcos Number", "HIP 79082"},
        {"Smithsonian Astrophysical Observation", "SAO 29816"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.14456995),
        dec: Angle.Degrees(+51.63675462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233397"},
        {"Hipparcos Number", "HIP 36438"},
        {"Smithsonian Astrophysical Observation", "SAO 26371"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.47774129),
        dec: Angle.Degrees(+51.63831834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165240"},
        {"Hipparcos Number", "HIP 88323"},
        {"Geneva Identification System", "GEN# +1.00165240"},
        {"Smithsonian Astrophysical Observation", "SAO 30709"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.56972289),
        dec: Angle.Degrees(+51.63884196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30098"},
        {"Hipparcos Number", "HIP 22243"},
        {"Smithsonian Astrophysical Observation", "SAO 24823"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.81607614),
        dec: Angle.Degrees(+51.64494264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49926"},
        {"Hipparcos Number", "HIP 33090"},
        {"Geneva Identification System", "GEN# +1.00049926"},
        {"Smithsonian Astrophysical Observation", "SAO 26024"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.37885516),
        dec: Angle.Degrees(+51.64511925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46275"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.53208398),
        dec: Angle.Degrees(+51.64661771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -237.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90141",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11328 AB"},
        {"Henry Draper", "HD 169816"},
        {"Hipparcos Number", "HIP 90141"},
        {"Smithsonian Astrophysical Observation", "SAO 30942"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.93760724),
        dec: Angle.Degrees(+51.64881960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 131.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55916"},
        {"Hipparcos Number", "HIP 35321"},
        {"Smithsonian Astrophysical Observation", "SAO 26261"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.43868721),
        dec: Angle.Degrees(+51.65141785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12453"},
        {"Hipparcos Number", "HIP 9600"},
        {"Smithsonian Astrophysical Observation", "SAO 22880"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.86840891),
        dec: Angle.Degrees(+51.65166569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116493"},
        {"Hipparcos Number", "HIP 65296"},
        {"Smithsonian Astrophysical Observation", "SAO 28730"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.73879076),
        dec: Angle.Degrees(+51.65314065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205822"},
        {"Hipparcos Number", "HIP 106659"},
        {"Smithsonian Astrophysical Observation", "SAO 33569"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.05750511),
        dec: Angle.Degrees(+51.65513881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204001"},
        {"Hipparcos Number", "HIP 105650"},
        {"Celescope Catalog", "CEL 5303"},
        {"Geneva Identification System", "GEN# +1.00204001"},
        {"Smithsonian Astrophysical Observation", "SAO 33386"},
    },
    visualMagnitude: 7.10,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.99160534),
        dec: Angle.Degrees(+51.65717406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178739"},
        {"Hipparcos Number", "HIP 93875"},
        {"Geneva Identification System", "GEN# +1.00178739"},
        {"Smithsonian Astrophysical Observation", "SAO 31391"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.77600291),
        dec: Angle.Degrees(+51.65757610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233087"},
        {"Hipparcos Number", "HIP 24361"},
        {"Smithsonian Astrophysical Observation", "SAO 25079"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.40222122),
        dec: Angle.Degrees(+51.66095398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15717",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2487 A"},
        {"Henry Draper", "HD 20714"},
        {"Hipparcos Number", "HIP 15717"},
        {"Geneva Identification System", "GEN# +5.20200522"},
        {"Smithsonian Astrophysical Observation", "SAO 23987"},
        {"Wilson Evans Batten Catalogue", "WEB 3010"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.60944024),
        dec: Angle.Degrees(+51.66103156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232214"},
        {"Hipparcos Number", "HIP 2613"},
        {"Smithsonian Astrophysical Observation", "SAO 21514"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.29836864),
        dec: Angle.Degrees(+51.66861286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187179"},
        {"Hipparcos Number", "HIP 97268"},
        {"Smithsonian Astrophysical Observation", "SAO 31970"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.52612074),
        dec: Angle.Degrees(+51.67004323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99307",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13447 AB"},
        {"Henry Draper", "HD 191807"},
        {"Hipparcos Number", "HIP 99307"},
        {"Smithsonian Astrophysical Observation", "SAO 32319"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.36885111),
        dec: Angle.Degrees(+51.67436969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157372"},
        {"Hipparcos Number", "HIP 84820"},
        {"Smithsonian Astrophysical Observation", "SAO 30343"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.03965303),
        dec: Angle.Degrees(+51.67555934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46853",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7420 A"},
        {"Henry Draper", "HD 82328"},
        {"Hipparcos Number", "HIP 46853"},
        {"Cincinnati Publication", "Ci 20 534"},
        {"Fundamental Katalog 5th Edition", "FK5 358"},
        {"Geneva Identification System", "GEN# +1.00082328"},
        {"Smithsonian Astrophysical Observation", "SAO 27289"},
        {"Wilson Evans Batten Catalogue", "WEB 8835"},
    },
    visualMagnitude: 3.17,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.21802191),
        dec: Angle.Degrees(+51.67860208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -947.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -535.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134789"},
        {"Hipparcos Number", "HIP 74197"},
        {"Smithsonian Astrophysical Observation", "SAO 29429"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.42297900),
        dec: Angle.Degrees(+51.68193954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8526"},
        {"Hipparcos Number", "HIP 6650"},
        {"Smithsonian Astrophysical Observation", "SAO 22265"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.33137960),
        dec: Angle.Degrees(+51.68284704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234464"},
        {"Hipparcos Number", "HIP 86209"},
        {"Smithsonian Astrophysical Observation", "SAO 30484"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.25734480),
        dec: Angle.Degrees(+51.68322813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222544"},
        {"Hipparcos Number", "HIP 116860"},
        {"Geneva Identification System", "GEN# +1.00222544"},
        {"Smithsonian Astrophysical Observation", "SAO 35667"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.30649771),
        dec: Angle.Degrees(+51.68441966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219979"},
        {"Hipparcos Number", "HIP 115169"},
        {"Smithsonian Astrophysical Observation", "SAO 35326"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.91896502),
        dec: Angle.Degrees(+51.68477284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221187"},
        {"Hipparcos Number", "HIP 115952"},
        {"Smithsonian Astrophysical Observation", "SAO 35469"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.38025753),
        dec: Angle.Degrees(+51.68523039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233760"},
        {"Hipparcos Number", "HIP 52375"},
        {"Smithsonian Astrophysical Observation", "SAO 27737"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.58180133),
        dec: Angle.Degrees(+51.68602513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8929"},
        {"Hipparcos Number", "HIP 6911"},
        {"Geneva Identification System", "GEN# +1.00008929"},
        {"Smithsonian Astrophysical Observation", "SAO 22317"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.25318455),
        dec: Angle.Degrees(+51.68608973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42292"},
        {"Hipparcos Number", "HIP 29481"},
        {"Smithsonian Astrophysical Observation", "SAO 25617"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.17365910),
        dec: Angle.Degrees(+51.68640662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235246"},
        {"Hipparcos Number", "HIP 100973"},
        {"Renson", "Renson 54443"},
        {"Smithsonian Astrophysical Observation", "SAO 32610"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.09315015),
        dec: Angle.Degrees(+51.68814090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11658"},
        {"Hipparcos Number", "HIP 8984"},
        {"Smithsonian Astrophysical Observation", "SAO 22760"},
        {"Wilson Evans Batten Catalogue", "WEB 1884"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.94510178),
        dec: Angle.Degrees(+51.68821957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4370"},
        {"Hipparcos Number", "HIP 3647"},
        {"Smithsonian Astrophysical Observation", "SAO 21695"},
    },
    visualMagnitude: 9.20,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.67440443),
        dec: Angle.Degrees(+51.68948372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12531"},
        {"Hipparcos Number", "HIP 9668"},
        {"Smithsonian Astrophysical Observation", "SAO 22898"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.08636143),
        dec: Angle.Degrees(+51.69332197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233484"},
        {"Hipparcos Number", "HIP 39295"},
        {"Smithsonian Astrophysical Observation", "SAO 26632"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.51760558),
        dec: Angle.Degrees(+51.69567073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183773"},
        {"Hipparcos Number", "HIP 95752"},
        {"Celescope Catalog", "CEL 4774"},
        {"Smithsonian Astrophysical Observation", "SAO 31689"},
    },
    visualMagnitude: 8.32,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.12930725),
        dec: Angle.Degrees(+51.69710159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205551"},
        {"Hipparcos Number", "HIP 106518"},
        {"Celescope Catalog", "CEL 5343"},
        {"Geneva Identification System", "GEN# +1.00205551"},
        {"Smithsonian Astrophysical Observation", "SAO 33540"},
        {"Wilson Evans Batten Catalogue", "WEB 19275"},
    },
    visualMagnitude: 6.17,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.61441642),
        dec: Angle.Degrees(+51.69846953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209870"},
        {"Hipparcos Number", "HIP 109015"},
        {"Smithsonian Astrophysical Observation", "SAO 34033"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.28088800),
        dec: Angle.Degrees(+51.70037691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14967"},
        {"Hipparcos Number", "HIP 11377"},
        {"Smithsonian Astrophysical Observation", "SAO 23333"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.62800245),
        dec: Angle.Degrees(+51.70546383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18051"},
        {"Hipparcos Number", "HIP 13664"},
        {"Smithsonian Astrophysical Observation", "SAO 23709"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.98353466),
        dec: Angle.Degrees(+51.70596134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233077"},
        {"Hipparcos Number", "HIP 23811"},
        {"Fundamental Katalog 5th Edition", "FK5 4469"},
        {"Geneva Identification System", "GEN# +1.00233077"},
        {"Smithsonian Astrophysical Observation", "SAO 25024"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.75935089),
        dec: Angle.Degrees(+51.70626180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23384"},
        {"Hipparcos Number", "HIP 17675"},
        {"Geneva Identification System", "GEN# +1.00023384"},
        {"Smithsonian Astrophysical Observation", "SAO 24213"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.79409281),
        dec: Angle.Degrees(+51.70657022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234005"},
        {"Hipparcos Number", "HIP 63690"},
        {"Smithsonian Astrophysical Observation", "SAO 28617"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.78675782),
        dec: Angle.Degrees(+51.70770993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21107"},
        {"Hipparcos Number", "HIP 16052"},
        {"Geneva Identification System", "GEN# +5.20200704"},
        {"Smithsonian Astrophysical Observation", "SAO 24037"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.68350569),
        dec: Angle.Degrees(+51.71081594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160760"},
        {"Hipparcos Number", "HIP 86371"},
        {"Smithsonian Astrophysical Observation", "SAO 30498"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.73563739),
        dec: Angle.Degrees(+51.71376869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148364"},
        {"Hipparcos Number", "HIP 80427"},
        {"Smithsonian Astrophysical Observation", "SAO 29934"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.25109786),
        dec: Angle.Degrees(+51.71656383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235729"},
        {"Hipparcos Number", "HIP 109217"},
        {"Celescope Catalog", "CEL 5439"},
        {"Geneva Identification System", "GEN# +1.00235729"},
        {"Smithsonian Astrophysical Observation", "SAO 34078"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.87963577),
        dec: Angle.Degrees(+51.71861696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234677"},
        {"Hipparcos Number", "HIP 91009"},
        {"Cincinnati Publication", "Ci 18 2443"},
        {"Geneva Identification System", "GEN# +1.00234677"},
        {"Smithsonian Astrophysical Observation", "SAO 31048"},
        {"Wilson Evans Batten Catalogue", "WEB 15618"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.48165444),
        dec: Angle.Degrees(+51.71992995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -324.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176341"},
        {"Hipparcos Number", "HIP 93029"},
        {"Geneva Identification System", "GEN# +1.00176341"},
        {"Smithsonian Astrophysical Observation", "SAO 31282"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.27042728),
        dec: Angle.Degrees(+51.72097939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234656"},
        {"Hipparcos Number", "HIP 90457"},
        {"Smithsonian Astrophysical Observation", "SAO 30982"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.86940990),
        dec: Angle.Degrees(+51.72359513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110182"},
        {"Hipparcos Number", "HIP 61786"},
        {"Geneva Identification System", "GEN# +1.00110182"},
        {"Smithsonian Astrophysical Observation", "SAO 28467"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.96201890),
        dec: Angle.Degrees(+51.72501310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233232"},
        {"Hipparcos Number", "HIP 30198"},
        {"Smithsonian Astrophysical Observation", "SAO 25675"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.29526843),
        dec: Angle.Degrees(+51.72529268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233454"},
        {"Hipparcos Number", "HIP 38157"},
        {"Smithsonian Astrophysical Observation", "SAO 26521"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.29891931),
        dec: Angle.Degrees(+51.72530437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110948"},
        {"Hipparcos Number", "HIP 62221"},
        {"Smithsonian Astrophysical Observation", "SAO 28504"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.28053217),
        dec: Angle.Degrees(+51.72541041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65366"},
        {"Hipparcos Number", "HIP 39179"},
        {"Smithsonian Astrophysical Observation", "SAO 26616"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.19997743),
        dec: Angle.Degrees(+51.72580396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233074"},
        {"Hipparcos Number", "HIP 23787"},
        {"Smithsonian Astrophysical Observation", "SAO 25020"},
    },
    visualMagnitude: 9.40,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.67567502),
        dec: Angle.Degrees(+51.72812410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2873"},
        {"Hipparcos Number", "HIP 2557"},
        {"Smithsonian Astrophysical Observation", "SAO 21502"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.12505600),
        dec: Angle.Degrees(+51.72826200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184006"},
        {"Hipparcos Number", "HIP 95853"},
        {"Celescope Catalog", "CEL 4776"},
        {"Fundamental Katalog 5th Edition", "FK5 733"},
        {"Geneva Identification System", "GEN# +1.00184006"},
        {"Smithsonian Astrophysical Observation", "SAO 31702"},
        {"Wilson Evans Batten Catalogue", "WEB 16783"},
    },
    visualMagnitude: 3.76,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.42641389),
        dec: Angle.Degrees(+51.72946747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 128.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222449"},
        {"Hipparcos Number", "HIP 116804"},
        {"Smithsonian Astrophysical Observation", "SAO 35657"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.09852568),
        dec: Angle.Degrees(+51.73297973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233898"},
        {"Hipparcos Number", "HIP 59073"},
        {"Smithsonian Astrophysical Observation", "SAO 28251"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.72030530),
        dec: Angle.Degrees(+51.73526844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233844"},
        {"Hipparcos Number", "HIP 56464"},
        {"Smithsonian Astrophysical Observation", "SAO 28061"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.65613081),
        dec: Angle.Degrees(+51.73616983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190602"},
        {"Hipparcos Number", "HIP 98747"},
        {"Smithsonian Astrophysical Observation", "SAO 32240"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.85534227),
        dec: Angle.Degrees(+51.73835579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167104"},
        {"Hipparcos Number", "HIP 89093"},
        {"Smithsonian Astrophysical Observation", "SAO 30792"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.75560437),
        dec: Angle.Degrees(+51.73988317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7444"},
        {"Hipparcos Number", "HIP 5876"},
        {"Smithsonian Astrophysical Observation", "SAO 22130"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.86515481),
        dec: Angle.Degrees(+51.74113208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5476",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 956 B"},
        {"Henry Draper", "HD 6872B"},
        {"Hipparcos Number", "HIP 5476"},
        {"Smithsonian Astrophysical Observation", "SAO 22049"},
        {"Wilson Evans Batten Catalogue", "WEB 1206"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.53022195),
        dec: Angle.Degrees(+51.74273628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5480",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 956 A"},
        {"Henry Draper", "HD 6872"},
        {"Henry Draper 2", "HD 6872A"},
        {"Hipparcos Number", "HIP 5480"},
        {"Smithsonian Astrophysical Observation", "SAO 22050"},
        {"Wilson Evans Batten Catalogue", "WEB 1205"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.53149101),
        dec: Angle.Degrees(+51.74671290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9759"},
        {"Hipparcos Number", "HIP 7498"},
        {"Geneva Identification System", "GEN# +1.00009759"},
        {"Smithsonian Astrophysical Observation", "SAO 22430"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.15979664),
        dec: Angle.Degrees(+51.74863168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131970"},
        {"Hipparcos Number", "HIP 72971"},
        {"Geneva Identification System", "GEN# +1.00131970"},
        {"Smithsonian Astrophysical Observation", "SAO 29335"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.69082062),
        dec: Angle.Degrees(+51.74980284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148893"},
        {"Hipparcos Number", "HIP 80709"},
        {"Smithsonian Astrophysical Observation", "SAO 29958"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.17918148),
        dec: Angle.Degrees(+51.75104157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100300"},
        {"Hipparcos Number", "HIP 56334"},
        {"Smithsonian Astrophysical Observation", "SAO 28052"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.23002955),
        dec: Angle.Degrees(+51.75202505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42550",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6906 A"},
        {"Henry Draper", "HD 73394"},
        {"Hipparcos Number", "HIP 42550"},
        {"Geneva Identification System", "GEN# +1.00073394"},
        {"Smithsonian Astrophysical Observation", "SAO 26954"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.09378513),
        dec: Angle.Degrees(+51.75205334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155838"},
        {"Hipparcos Number", "HIP 84072"},
        {"Fundamental Katalog 5th Edition", "FK5 5516"},
        {"Geneva Identification System", "GEN# +1.00155838"},
        {"Smithsonian Astrophysical Observation", "SAO 30283"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.82351296),
        dec: Angle.Degrees(+51.75434362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51774"},
        {"Hipparcos Number", "HIP 33835"},
        {"Geneva Identification System", "GEN# +1.00051774"},
        {"Smithsonian Astrophysical Observation", "SAO 26099"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.36274171),
        dec: Angle.Degrees(+51.75493336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63000",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63000"},
        {"Geneva Identification System", "GEN# +0.05201661"},
        {"Renson", "Renson 32590"},
    },
    visualMagnitude: 11.25,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.64386414),
        dec: Angle.Degrees(+51.75572865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79941",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79941"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.77481717),
        dec: Angle.Degrees(+51.75722065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -185.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 225.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214976"},
        {"Hipparcos Number", "HIP 111988"},
        {"Smithsonian Astrophysical Observation", "SAO 34694"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.26149486),
        dec: Angle.Degrees(+51.75848301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233469"},
        {"Hipparcos Number", "HIP 38666"},
        {"Smithsonian Astrophysical Observation", "SAO 26568"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.75186032),
        dec: Angle.Degrees(+51.75883888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110833"},
        {"Hipparcos Number", "HIP 62145"},
        {"Cincinnati Publication", "Ci 20 735"},
        {"Geneva Identification System", "GEN# +1.00110833"},
        {"Smithsonian Astrophysical Observation", "SAO 28499"},
        {"Wilson Evans Batten Catalogue", "WEB 11045"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.06209348),
        dec: Angle.Degrees(+51.75974874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -378.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98572"},
        {"Hipparcos Number", "HIP 55418"},
        {"Fundamental Katalog 5th Edition", "FK5 2906"},
        {"Geneva Identification System", "GEN# +1.00098572"},
        {"Smithsonian Astrophysical Observation", "SAO 27995"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.23713618),
        dec: Angle.Degrees(+51.76144645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106754",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106754"},
    },
    visualMagnitude: 10.45,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.36721351),
        dec: Angle.Degrees(+51.76249261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146228"},
        {"Hipparcos Number", "HIP 79428"},
        {"Smithsonian Astrophysical Observation", "SAO 29841"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.14884908),
        dec: Angle.Degrees(+51.76354555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49708",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49708"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.21996983),
        dec: Angle.Degrees(+51.76492974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67741"},
        {"Hipparcos Number", "HIP 40135"},
        {"Smithsonian Astrophysical Observation", "SAO 26721"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.95642889),
        dec: Angle.Degrees(+51.76902165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20842"},
        {"Hipparcos Number", "HIP 15814"},
        {"Geneva Identification System", "GEN# +5.20200575"},
        {"Smithsonian Astrophysical Observation", "SAO 24004"},
        {"Wilson Evans Batten Catalogue", "WEB 3020"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.92974536),
        dec: Angle.Degrees(+51.77042418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142125"},
        {"Hipparcos Number", "HIP 77591"},
        {"Smithsonian Astrophysical Observation", "SAO 29687"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.62012875),
        dec: Angle.Degrees(+51.77142340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233891"},
        {"Hipparcos Number", "HIP 58514"},
        {"Geneva Identification System", "GEN# +1.00233891"},
        {"Smithsonian Astrophysical Observation", "SAO 28217"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.99616208),
        dec: Angle.Degrees(+51.77153691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31027",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5099 C"},
        {"Henry Draper", "HD 233252"},
        {"Hipparcos Number", "HIP 31027"},
        {"Smithsonian Astrophysical Observation", "SAO 25776"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.65701478),
        dec: Angle.Degrees(+51.77919697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14040"},
        {"Hipparcos Number", "HIP 10717"},
        {"Geneva Identification System", "GEN# +1.00014040"},
        {"Smithsonian Astrophysical Observation", "SAO 23151"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.49675341),
        dec: Angle.Degrees(+51.78193349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171911"},
        {"Hipparcos Number", "HIP 91061"},
        {"Geneva Identification System", "GEN# +1.00171911"},
        {"Smithsonian Astrophysical Observation", "SAO 31055"},
        {"Wilson Evans Batten Catalogue", "WEB 15630"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.62874504),
        dec: Angle.Degrees(+51.78232810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233769"},
        {"Hipparcos Number", "HIP 52724"},
        {"Smithsonian Astrophysical Observation", "SAO 27765"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.69062230),
        dec: Angle.Degrees(+51.78404239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19864"},
        {"Hipparcos Number", "HIP 15037"},
        {"Geneva Identification System", "GEN# +5.20200226"},
        {"Smithsonian Astrophysical Observation", "SAO 23887"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.45866648),
        dec: Angle.Degrees(+51.78484906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161694"},
        {"Hipparcos Number", "HIP 86806"},
        {"Geneva Identification System", "GEN# +1.00161694"},
        {"Renson", "Renson 45600"},
        {"Smithsonian Astrophysical Observation", "SAO 30541"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.06827388),
        dec: Angle.Degrees(+51.78695219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69481",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9173 B"},
        {"Henry Draper", "HD 124674"},
        {"Hipparcos Number", "HIP 69481"},
        {"Geneva Identification System", "GEN# +1.00124674"},
        {"Smithsonian Astrophysical Observation", "SAO 29045"},
        {"Wilson Evans Batten Catalogue", "WEB 12107"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.36561664),
        dec: Angle.Degrees(+51.78787676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69483",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9173 A"},
        {"Henry Draper", "HD 124675"},
        {"Hipparcos Number", "HIP 69483"},
        {"Celescope Catalog", "CEL 4308"},
        {"Geneva Identification System", "GEN# +1.00124675A"},
        {"Smithsonian Astrophysical Observation", "SAO 29046"},
        {"Wilson Evans Batten Catalogue", "WEB 12108"},
    },
    visualMagnitude: 4.53,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.37062458),
        dec: Angle.Degrees(+51.78999066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100882",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100882"},
    },
    visualMagnitude: 10.22,
    bvColour: -0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.83151687),
        dec: Angle.Degrees(+51.79007283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114130"},
        {"Hipparcos Number", "HIP 64065"},
        {"Smithsonian Astrophysical Observation", "SAO 28644"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.94583462),
        dec: Angle.Degrees(+51.79090046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102576",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14302 A"},
        {"Henry Draper", "HD 198285"},
        {"Hipparcos Number", "HIP 102576"},
        {"Geneva Identification System", "GEN# +1.00198285"},
        {"Smithsonian Astrophysical Observation", "SAO 32886"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.80782494),
        dec: Angle.Degrees(+51.79482830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105842"},
        {"Hipparcos Number", "HIP 59372"},
        {"Smithsonian Astrophysical Observation", "SAO 28279"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.71299097),
        dec: Angle.Degrees(+51.79626271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233234"},
        {"Hipparcos Number", "HIP 30283"},
        {"Smithsonian Astrophysical Observation", "SAO 25688"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.55095546),
        dec: Angle.Degrees(+51.79668973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4902",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 859 AB"},
        {"Henry Draper", "HD 6084"},
        {"Hipparcos Number", "HIP 4902"},
        {"Celescope Catalog", "CEL 110"},
        {"Geneva Identification System", "GEN# +1.00006084J"},
        {"Smithsonian Astrophysical Observation", "SAO 21949"},
        {"Wilson Evans Batten Catalogue", "WEB 961"},
    },
    visualMagnitude: 6.84,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.72408970),
        dec: Angle.Degrees(+51.79810649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233335"},
        {"Hipparcos Number", "HIP 34362"},
        {"Smithsonian Astrophysical Observation", "SAO 26161"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.84525704),
        dec: Angle.Degrees(+51.79868128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93811"},
        {"Hipparcos Number", "HIP 53008"},
        {"Geneva Identification System", "GEN# +1.00093811"},
        {"Smithsonian Astrophysical Observation", "SAO 27785"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.66872964),
        dec: Angle.Degrees(+51.79965075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8658",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1472 A"},
        {"Henry Draper", "HD 11222"},
        {"Hipparcos Number", "HIP 8658"},
        {"Celescope Catalog", "CEL 173"},
        {"Smithsonian Astrophysical Observation", "SAO 22685"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.89904000),
        dec: Angle.Degrees(+51.80013942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128999"},
        {"Hipparcos Number", "HIP 71583"},
        {"Smithsonian Astrophysical Observation", "SAO 29228"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.60019504),
        dec: Angle.Degrees(+51.80100408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39551"},
        {"Hipparcos Number", "HIP 28086"},
        {"Geneva Identification System", "GEN# +1.00039551"},
        {"Smithsonian Astrophysical Observation", "SAO 25467"},
        {"Wilson Evans Batten Catalogue", "WEB 5496"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.06025063),
        dec: Angle.Degrees(+51.80400653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118970"},
        {"Hipparcos Number", "HIP 66613"},
        {"Smithsonian Astrophysical Observation", "SAO 28831"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.81218137),
        dec: Angle.Degrees(+51.80419954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156629"},
        {"Hipparcos Number", "HIP 84453"},
        {"Smithsonian Astrophysical Observation", "SAO 30317"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.99002200),
        dec: Angle.Degrees(+51.80532632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210100"},
        {"Hipparcos Number", "HIP 109157"},
        {"Celescope Catalog", "CEL 5437"},
        {"Geneva Identification System", "GEN# +1.00210100"},
        {"Smithsonian Astrophysical Observation", "SAO 34060"},
    },
    visualMagnitude: 7.08,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.66611626),
        dec: Angle.Degrees(+51.80585673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89109"},
        {"Hipparcos Number", "HIP 50455"},
        {"Fundamental Katalog 5th Edition", "FK5 4915"},
        {"Smithsonian Astrophysical Observation", "SAO 27594"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.52974800),
        dec: Angle.Degrees(+51.80861416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8784"},
        {"Hipparcos Number", "HIP 6809"},
        {"Geneva Identification System", "GEN# +1.00008784"},
        {"Smithsonian Astrophysical Observation", "SAO 22292"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.90409756),
        dec: Angle.Degrees(+51.80886181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90928"},
        {"Hipparcos Number", "HIP 51503"},
        {"Smithsonian Astrophysical Observation", "SAO 27674"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.77453293),
        dec: Angle.Degrees(+51.80894052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234060"},
        {"Hipparcos Number", "HIP 66789"},
        {"Smithsonian Astrophysical Observation", "SAO 28848"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.32735128),
        dec: Angle.Degrees(+51.81376647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161193"},
        {"Hipparcos Number", "HIP 86561"},
        {"Geneva Identification System", "GEN# +1.00161193"},
        {"Smithsonian Astrophysical Observation", "SAO 30522"},
        {"Wilson Evans Batten Catalogue", "WEB 14599"},
    },
    visualMagnitude: 6.00,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.34085523),
        dec: Angle.Degrees(+51.81818247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232489"},
        {"Hipparcos Number", "HIP 7707"},
        {"Celescope Catalog", "CEL 151"},
        {"Geneva Identification System", "GEN# +1.00232489"},
        {"Smithsonian Astrophysical Observation", "SAO 22474"},
        {"Wilson Evans Batten Catalogue", "WEB 1650"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.80356426),
        dec: Angle.Degrees(+51.82198459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23565"},
        {"Hipparcos Number", "HIP 17800"},
        {"Geneva Identification System", "GEN# +1.00023565"},
        {"Smithsonian Astrophysical Observation", "SAO 24234"},
        {"Wilson Evans Batten Catalogue", "WEB 3411"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.15637762),
        dec: Angle.Degrees(+51.82336820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221809"},
        {"Hipparcos Number", "HIP 116379"},
        {"Smithsonian Astrophysical Observation", "SAO 35567"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.74046050),
        dec: Angle.Degrees(+51.82426106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23113",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23113"},
    },
    visualMagnitude: 11.80,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.59900767),
        dec: Angle.Degrees(+51.82628306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234934"},
        {"Hipparcos Number", "HIP 96244"},
        {"Smithsonian Astrophysical Observation", "SAO 31780"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.55648445),
        dec: Angle.Degrees(+51.82699679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86745"},
        {"Hipparcos Number", "HIP 49162"},
        {"Smithsonian Astrophysical Observation", "SAO 27480"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.49609183),
        dec: Angle.Degrees(+51.82780550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48449"},
        {"Hipparcos Number", "HIP 32441"},
        {"Geneva Identification System", "GEN# +1.00048449"},
        {"Smithsonian Astrophysical Observation", "SAO 25944"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.56349065),
        dec: Angle.Degrees(+51.82835452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236288"},
        {"Hipparcos Number", "HIP 354"},
        {"Smithsonian Astrophysical Observation", "SAO 21052"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.12334321),
        dec: Angle.Degrees(+51.82930460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236282"},
        {"Hipparcos Number", "HIP 196"},
        {"Smithsonian Astrophysical Observation", "SAO 36005"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.62700447),
        dec: Angle.Degrees(+51.82997958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8005"},
        {"Hipparcos Number", "HIP 6270"},
        {"Celescope Catalog", "CEL 135"},
        {"Smithsonian Astrophysical Observation", "SAO 22199"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.10265558),
        dec: Angle.Degrees(+51.83331694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96636",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12758 AB"},
        {"Henry Draper", "HD 185892"},
        {"Hipparcos Number", "HIP 96636"},
        {"Smithsonian Astrophysical Observation", "SAO 31852"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.71482514),
        dec: Angle.Degrees(+51.83433837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80068",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10018 A"},
        {"Henry Draper", "HD 147621"},
        {"Hipparcos Number", "HIP 80068"},
        {"Smithsonian Astrophysical Observation", "SAO 29898"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.13990794),
        dec: Angle.Degrees(+51.83478236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223267"},
        {"Hipparcos Number", "HIP 117379"},
        {"Geneva Identification System", "GEN# +1.00223267"},
        {"Smithsonian Astrophysical Observation", "SAO 35777"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.99499938),
        dec: Angle.Degrees(+51.83656889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3149"},
        {"Hipparcos Number", "HIP 2760"},
        {"Geneva Identification System", "GEN# +1.00003149"},
        {"Smithsonian Astrophysical Observation", "SAO 21537"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.80717832),
        dec: Angle.Degrees(+51.83850877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190964"},
        {"Hipparcos Number", "HIP 98915"},
        {"Geneva Identification System", "GEN# +1.00190964"},
        {"Smithsonian Astrophysical Observation", "SAO 32272"},
        {"Wilson Evans Batten Catalogue", "WEB 17560"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.27802072),
        dec: Angle.Degrees(+51.83932191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112887",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112887"},
    },
    visualMagnitude: 12.26,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.91216223),
        dec: Angle.Degrees(+51.84512571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91158"},
        {"Hipparcos Number", "HIP 51613"},
        {"Smithsonian Astrophysical Observation", "SAO 27676"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.14919185),
        dec: Angle.Degrees(+51.84536748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235523"},
        {"Hipparcos Number", "HIP 106135"},
        {"Geneva Identification System", "GEN# +1.00235523"},
        {"Smithsonian Astrophysical Observation", "SAO 33465"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.47426729),
        dec: Angle.Degrees(+51.85093695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126660"},
        {"Hipparcos Number", "HIP 70497"},
        {"Cincinnati Publication", "Ci 20 858"},
        {"Fundamental Katalog 5th Edition", "FK5 531"},
        {"Geneva Identification System", "GEN# +1.00126660"},
        {"Smithsonian Astrophysical Observation", "SAO 29137"},
        {"Wilson Evans Batten Catalogue", "WEB 12229"},
    },
    visualMagnitude: 4.04,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.30008064),
        dec: Angle.Degrees(+51.85171354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -236.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -399.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196379"},
        {"Hipparcos Number", "HIP 101556"},
        {"Fundamental Katalog 5th Edition", "FK5 3646"},
        {"Geneva Identification System", "GEN# +1.00196379"},
        {"Smithsonian Astrophysical Observation", "SAO 32709"},
        {"Wilson Evans Batten Catalogue", "WEB 18351"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.71002522),
        dec: Angle.Degrees(+51.85423447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233802"},
        {"Hipparcos Number", "HIP 54243"},
        {"Smithsonian Astrophysical Observation", "SAO 27898"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.46175126),
        dec: Angle.Degrees(+51.85494749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125435"},
        {"Hipparcos Number", "HIP 69856"},
        {"Smithsonian Astrophysical Observation", "SAO 29089"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.44273415),
        dec: Angle.Degrees(+51.85770514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212044"},
        {"Hipparcos Number", "HIP 110287"},
        {"Celescope Catalog", "CEL 5467"},
        {"Geneva Identification System", "GEN# +1.00212044"},
        {"Smithsonian Astrophysical Observation", "SAO 34327"},
        {"Wilson Evans Batten Catalogue", "WEB 19785"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.09461207),
        dec: Angle.Degrees(+51.86100145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38673",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38673"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.77152370),
        dec: Angle.Degrees(+51.86204162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -289.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193512"},
        {"Hipparcos Number", "HIP 100087"},
        {"Geneva Identification System", "GEN# +1.00193512"},
        {"Smithsonian Astrophysical Observation", "SAO 32451"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.57094601),
        dec: Angle.Degrees(+51.86697564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51046"},
        {"Hipparcos Number", "HIP 33580"},
        {"Geneva Identification System", "GEN# +1.00051046"},
        {"Smithsonian Astrophysical Observation", "SAO 26074"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.65787366),
        dec: Angle.Degrees(+51.86771829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -210.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235722"},
        {"Hipparcos Number", "HIP 109131"},
        {"Smithsonian Astrophysical Observation", "SAO 34056"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.58948819),
        dec: Angle.Degrees(+51.86900088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174982"},
        {"Hipparcos Number", "HIP 92460"},
        {"Smithsonian Astrophysical Observation", "SAO 31197"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.63908825),
        dec: Angle.Degrees(+51.87131007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233546"},
        {"Hipparcos Number", "HIP 42020"},
        {"Smithsonian Astrophysical Observation", "SAO 26910"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.48096596),
        dec: Angle.Degrees(+51.87338711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60693"},
        {"Hipparcos Number", "HIP 37193"},
        {"Geneva Identification System", "GEN# +1.00060693"},
        {"Smithsonian Astrophysical Observation", "SAO 26438"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.61236288),
        dec: Angle.Degrees(+51.87563284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117300"},
        {"Hipparcos Number", "HIP 65727"},
        {"Smithsonian Astrophysical Observation", "SAO 28769"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.11234621),
        dec: Angle.Degrees(+51.87736412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3682"},
        {"Hipparcos Number", "HIP 3153"},
        {"Smithsonian Astrophysical Observation", "SAO 21602"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.02166049),
        dec: Angle.Degrees(+51.87914215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5063"},
        {"Hipparcos Number", "HIP 4161"},
        {"Smithsonian Astrophysical Observation", "SAO 21801"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.28751566),
        dec: Angle.Degrees(+51.87955159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236014"},
        {"Hipparcos Number", "HIP 113620"},
        {"Smithsonian Astrophysical Observation", "SAO 35049"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.17508475),
        dec: Angle.Degrees(+51.88120707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157322"},
        {"Hipparcos Number", "HIP 84793"},
        {"Smithsonian Astrophysical Observation", "SAO 30341"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.97291943),
        dec: Angle.Degrees(+51.88126686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165739"},
        {"Hipparcos Number", "HIP 88536"},
        {"Smithsonian Astrophysical Observation", "SAO 30731"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.18646244),
        dec: Angle.Degrees(+51.88233221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95057"},
        {"Hipparcos Number", "HIP 53706"},
        {"Fundamental Katalog 5th Edition", "FK5 2876"},
        {"Geneva Identification System", "GEN# +1.00095057"},
        {"Smithsonian Astrophysical Observation", "SAO 27858"},
        {"Wilson Evans Batten Catalogue", "WEB 9729"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.82454851),
        dec: Angle.Degrees(+51.88236813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8892"},
        {"Hipparcos Number", "HIP 6889"},
        {"Renson", "Renson 2150"},
        {"Smithsonian Astrophysical Observation", "SAO 22313"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.18409168),
        dec: Angle.Degrees(+51.88412951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219091"},
        {"Hipparcos Number", "HIP 114578"},
        {"Smithsonian Astrophysical Observation", "SAO 35232"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.17006144),
        dec: Angle.Degrees(+51.88590583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8379",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1417 A"},
        {"Henry Draper", "HD 232533"},
        {"Hipparcos Number", "HIP 8379"},
        {"Smithsonian Astrophysical Observation", "SAO 22628"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.99430971),
        dec: Angle.Degrees(+51.88733904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57646"},
        {"Hipparcos Number", "HIP 35984"},
        {"Geneva Identification System", "GEN# +1.00057646"},
        {"Smithsonian Astrophysical Observation", "SAO 26333"},
        {"Wilson Evans Batten Catalogue", "WEB 7164"},
    },
    visualMagnitude: 5.80,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.23782838),
        dec: Angle.Degrees(+51.88734396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158519"},
        {"Hipparcos Number", "HIP 85401"},
        {"Smithsonian Astrophysical Observation", "SAO 30390"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.76721431),
        dec: Angle.Degrees(+51.88734700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232183"},
        {"Hipparcos Number", "HIP 1963"},
        {"Smithsonian Astrophysical Observation", "SAO 21377"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.20734487),
        dec: Angle.Degrees(+51.89132751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11924"},
        {"Hipparcos Number", "HIP 9203"},
        {"Smithsonian Astrophysical Observation", "SAO 22803"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.60468123),
        dec: Angle.Degrees(+51.89370156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223259"},
        {"Hipparcos Number", "HIP 117368"},
        {"Smithsonian Astrophysical Observation", "SAO 35775"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.96772434),
        dec: Angle.Degrees(+51.89691381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25305"},
        {"Hipparcos Number", "HIP 18962"},
        {"Geneva Identification System", "GEN# +1.00025305"},
        {"Renson", "Renson 6450"},
        {"Smithsonian Astrophysical Observation", "SAO 24382"},
        {"Wilson Evans Batten Catalogue", "WEB 3646"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.95070423),
        dec: Angle.Degrees(+51.89827389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166954"},
        {"Hipparcos Number", "HIP 89028"},
        {"Geneva Identification System", "GEN# +1.00166954"},
        {"Smithsonian Astrophysical Observation", "SAO 30782"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.55758730),
        dec: Angle.Degrees(+51.89873066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153496"},
        {"Hipparcos Number", "HIP 82958"},
        {"Smithsonian Astrophysical Observation", "SAO 30172"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.29242584),
        dec: Angle.Degrees(+51.89900126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114904"},
        {"Hipparcos Number", "HIP 64468"},
        {"Smithsonian Astrophysical Observation", "SAO 28674"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.20334380),
        dec: Angle.Degrees(+51.89983123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20276"},
        {"Hipparcos Number", "HIP 15337"},
        {"Smithsonian Astrophysical Observation", "SAO 23932"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.44169604),
        dec: Angle.Degrees(+51.90025149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41053"},
        {"Hipparcos Number", "HIP 28865"},
        {"Smithsonian Astrophysical Observation", "SAO 25561"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.42104650),
        dec: Angle.Degrees(+51.90124755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40170"},
    },
    visualMagnitude: 10.20,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.06061617),
        dec: Angle.Degrees(+51.90758949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221489"},
        {"Hipparcos Number", "HIP 116169"},
        {"Smithsonian Astrophysical Observation", "SAO 35522"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.06835803),
        dec: Angle.Degrees(+51.90864188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70841"},
        {"Hipparcos Number", "HIP 41380"},
        {"Smithsonian Astrophysical Observation", "SAO 26836"},
    },
    visualMagnitude: 9.34,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.63056351),
        dec: Angle.Degrees(+51.90915882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102712",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14336 AB"},
        {"Aitken 2", "ADS 14336"},
        {"Henry Draper", "HD 198513"},
        {"Hipparcos Number", "HIP 102712"},
        {"Celescope Catalog", "CEL 5175"},
        {"Geneva Identification System", "GEN# +1.00198513J"},
        {"Smithsonian Astrophysical Observation", "SAO 32908"},
        {"Wilson Evans Batten Catalogue", "WEB 18620"},
    },
    visualMagnitude: 6.26,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.17807122),
        dec: Angle.Degrees(+51.91032519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 596"},
        {"Hipparcos Number", "HIP 855"},
        {"Smithsonian Astrophysical Observation", "SAO 21163"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.62084078),
        dec: Angle.Degrees(+51.91238880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89943"},
        {"Hipparcos Number", "HIP 50925"},
        {"Smithsonian Astrophysical Observation", "SAO 27634"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.00864752),
        dec: Angle.Degrees(+51.91704169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129920"},
        {"Hipparcos Number", "HIP 71989"},
        {"Geneva Identification System", "GEN# +1.00129920"},
        {"Smithsonian Astrophysical Observation", "SAO 29254"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.84328561),
        dec: Angle.Degrees(+51.91781949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 118.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151327"},
        {"Hipparcos Number", "HIP 81922"},
        {"Smithsonian Astrophysical Observation", "SAO 30070"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.99859226),
        dec: Angle.Degrees(+51.92002097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36451"},
        {"Hipparcos Number", "HIP 26155"},
        {"Smithsonian Astrophysical Observation", "SAO 25265"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.64277869),
        dec: Angle.Degrees(+51.92045567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236147"},
        {"Hipparcos Number", "HIP 116046"},
        {"Smithsonian Astrophysical Observation", "SAO 35490"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.70657278),
        dec: Angle.Degrees(+51.92451226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235885"},
        {"Hipparcos Number", "HIP 111489"},
        {"Geneva Identification System", "GEN# +1.00235885"},
        {"Smithsonian Astrophysical Observation", "SAO 34591"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.82231336),
        dec: Angle.Degrees(+51.92499609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101768"},
        {"Hipparcos Number", "HIP 57140"},
        {"Smithsonian Astrophysical Observation", "SAO 28108"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.75941969),
        dec: Angle.Degrees(+51.92666165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86607"},
        {"Hipparcos Number", "HIP 49082"},
        {"Smithsonian Astrophysical Observation", "SAO 27474"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.25461553),
        dec: Angle.Degrees(+51.92676965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213703"},
        {"Hipparcos Number", "HIP 111249"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.08429787),
        dec: Angle.Degrees(+51.92708466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105031"},
        {"Hipparcos Number", "HIP 58980"},
        {"Smithsonian Astrophysical Observation", "SAO 28241"},
        {"Wilson Evans Batten Catalogue", "WEB 10503"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.39334843),
        dec: Angle.Degrees(+51.93119899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102262"},
        {"Hipparcos Number", "HIP 57431"},
        {"Geneva Identification System", "GEN# +1.00102262"},
        {"Smithsonian Astrophysical Observation", "SAO 28136"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.60453350),
        dec: Angle.Degrees(+51.93284707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11151"},
        {"Hipparcos Number", "HIP 8598"},
        {"Geneva Identification System", "GEN# +1.00011151"},
        {"Smithsonian Astrophysical Observation", "SAO 22678"},
        {"Wilson Evans Batten Catalogue", "WEB 1821"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.73786884),
        dec: Angle.Degrees(+51.93369809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132561"},
        {"Hipparcos Number", "HIP 73216"},
        {"Smithsonian Astrophysical Observation", "SAO 29357"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.45000127),
        dec: Angle.Degrees(+51.93538420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27636"},
        {"Hipparcos Number", "HIP 20556"},
        {"Smithsonian Astrophysical Observation", "SAO 24588"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.05814198),
        dec: Angle.Degrees(+51.93711731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223915"},
        {"Hipparcos Number", "HIP 117806"},
        {"Smithsonian Astrophysical Observation", "SAO 35868"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.38912839),
        dec: Angle.Degrees(+51.93783288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234514"},
        {"Hipparcos Number", "HIP 87591"},
        {"Smithsonian Astrophysical Observation", "SAO 30629"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.39715171),
        dec: Angle.Degrees(+51.93798958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222748"},
        {"Hipparcos Number", "HIP 116991"},
        {"Smithsonian Astrophysical Observation", "SAO 35698"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.77094888),
        dec: Angle.Degrees(+51.93934472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224756"},
        {"Hipparcos Number", "HIP 32"},
        {"Smithsonian Astrophysical Observation", "SAO 35980"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.09858375),
        dec: Angle.Degrees(+51.93949050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106150"},
        {"Hipparcos Number", "HIP 59548"},
        {"Geneva Identification System", "GEN# +1.00106150"},
        {"Smithsonian Astrophysical Observation", "SAO 28303"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.19019238),
        dec: Angle.Degrees(+51.94000205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27456"},
        {"Hipparcos Number", "HIP 20434"},
        {"Geneva Identification System", "GEN# +1.00027456"},
        {"Smithsonian Astrophysical Observation", "SAO 24579"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.65595393),
        dec: Angle.Degrees(+51.94181490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31487"},
        {"Hipparcos Number", "HIP 23168"},
        {"Geneva Identification System", "GEN# +1.00031487"},
        {"Smithsonian Astrophysical Observation", "SAO 24941"},
        {"Wilson Evans Batten Catalogue", "WEB 4495"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.76556679),
        dec: Angle.Degrees(+51.94225701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154344"},
        {"Hipparcos Number", "HIP 83354"},
        {"Geneva Identification System", "GEN# +1.00154344"},
        {"Smithsonian Astrophysical Observation", "SAO 30211"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.53445732),
        dec: Angle.Degrees(+51.94245574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235465"},
        {"Hipparcos Number", "HIP 104816"},
        {"Smithsonian Astrophysical Observation", "SAO 33247"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.53033732),
        dec: Angle.Degrees(+51.94388632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170826"},
        {"Hipparcos Number", "HIP 90557"},
        {"Smithsonian Astrophysical Observation", "SAO 30998"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.17844764),
        dec: Angle.Degrees(+51.94516356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172468"},
        {"Hipparcos Number", "HIP 91329"},
        {"Smithsonian Astrophysical Observation", "SAO 31077"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.42109697),
        dec: Angle.Degrees(+51.94595255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165907"},
        {"Hipparcos Number", "HIP 88606"},
        {"Smithsonian Astrophysical Observation", "SAO 30739"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.37808707),
        dec: Angle.Degrees(+51.94693791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234277"},
        {"Hipparcos Number", "HIP 78427"},
        {"Smithsonian Astrophysical Observation", "SAO 29751"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.15891146),
        dec: Angle.Degrees(+51.94743355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58557",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58557"},
    },
    visualMagnitude: 11.66,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.11111479),
        dec: Angle.Degrees(+51.95504937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -168.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236212"},
        {"Hipparcos Number", "HIP 117293"},
        {"Smithsonian Astrophysical Observation", "SAO 35758"},
    },
    visualMagnitude: 10.21,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.74306315),
        dec: Angle.Degrees(+51.95599725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103475"},
        {"Hipparcos Number", "HIP 58108"},
        {"Smithsonian Astrophysical Observation", "SAO 28186"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.75905120),
        dec: Angle.Degrees(+51.95601757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136729"},
        {"Hipparcos Number", "HIP 75043"},
        {"Fundamental Katalog 5th Edition", "FK5 3210"},
        {"Geneva Identification System", "GEN# +1.00136729"},
        {"Renson", "Renson 38860"},
        {"Smithsonian Astrophysical Observation", "SAO 29487"},
        {"Wilson Evans Batten Catalogue", "WEB 12801"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.02142169),
        dec: Angle.Degrees(+51.95848756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233207"},
        {"Hipparcos Number", "HIP 29035"},
        {"Smithsonian Astrophysical Observation", "SAO 25574"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.88381347),
        dec: Angle.Degrees(+51.95892936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16083"},
        {"Henry Draper 2", "HD 16082"},
        {"Hipparcos Number", "HIP 12169"},
        {"Fundamental Katalog 5th Edition", "FK5 4240"},
        {"Geneva Identification System", "GEN# +1.00016083"},
        {"Geneva Identification System 2", "GEN# +1.00016082"},
        {"Smithsonian Astrophysical Observation", "SAO 23470"},
        {"Wilson Evans Batten Catalogue", "WEB 2499"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.20088816),
        dec: Angle.Degrees(+51.96123948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118215"},
        {"Hipparcos Number", "HIP 66214"},
        {"Smithsonian Astrophysical Observation", "SAO 28804"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.56892877),
        dec: Angle.Degrees(+51.96236554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82766",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10264 AB"},
        {"Henry Draper", "HD 153144"},
        {"Hipparcos Number", "HIP 82766"},
        {"Smithsonian Astrophysical Observation", "SAO 30153"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.73004828),
        dec: Angle.Degrees(+51.96431887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56353"},
        {"Hipparcos Number", "HIP 35491"},
        {"Geneva Identification System", "GEN# +1.00056353"},
        {"Smithsonian Astrophysical Observation", "SAO 26276"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.87226771),
        dec: Angle.Degrees(+51.96754530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12518"},
        {"Hipparcos Number", "HIP 9656"},
        {"Celescope Catalog", "CEL 193"},
        {"Geneva Identification System", "GEN# +1.00012518"},
        {"Smithsonian Astrophysical Observation", "SAO 22897"},
    },
    visualMagnitude: 6.66,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.05474348),
        dec: Angle.Degrees(+51.96783144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100562"},
        {"Hipparcos Number", "HIP 56474"},
        {"Geneva Identification System", "GEN# +1.00100562"},
        {"Smithsonian Astrophysical Observation", "SAO 28062"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.68117944),
        dec: Angle.Degrees(+51.96820000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54888",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54888"},
        {"Geneva Identification System", "GEN# +6.20030605"},
    },
    visualMagnitude: 11.45,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.58160721),
        dec: Angle.Degrees(+51.96982362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216078"},
        {"Hipparcos Number", "HIP 112673"},
        {"Smithsonian Astrophysical Observation", "SAO 34847"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.25747176),
        dec: Angle.Degrees(+51.97159849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46275"},
        {"Hipparcos Number", "HIP 31452"},
        {"Geneva Identification System", "GEN# +1.00046275"},
        {"Smithsonian Astrophysical Observation", "SAO 25825"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.84099658),
        dec: Angle.Degrees(+51.97489056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213036"},
        {"Hipparcos Number", "HIP 110854"},
        {"Geneva Identification System", "GEN# +1.00213036"},
        {"Smithsonian Astrophysical Observation", "SAO 34469"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.88804098),
        dec: Angle.Degrees(+51.97663033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193646"},
        {"Hipparcos Number", "HIP 100162"},
        {"Renson", "Renson 54050"},
        {"Smithsonian Astrophysical Observation", "SAO 32465"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.75657393),
        dec: Angle.Degrees(+51.97707077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47309"},
        {"Hipparcos Number", "HIP 31965"},
        {"Geneva Identification System", "GEN# +1.00047309"},
        {"Smithsonian Astrophysical Observation", "SAO 25875"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.20433648),
        dec: Angle.Degrees(+51.97903460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -291.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215940"},
        {"Hipparcos Number", "HIP 112565"},
        {"Smithsonian Astrophysical Observation", "SAO 34835"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.97785554),
        dec: Angle.Degrees(+51.97940716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77303",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9789 AB"},
        {"Henry Draper", "HD 141473"},
        {"Hipparcos Number", "HIP 77303"},
        {"Smithsonian Astrophysical Observation", "SAO 29659"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.73861370),
        dec: Angle.Degrees(+51.97949208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106448"},
        {"Hipparcos Number", "HIP 59700"},
        {"Smithsonian Astrophysical Observation", "SAO 28308"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.63488228),
        dec: Angle.Degrees(+51.98124258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101572"},
        {"Hipparcos Number", "HIP 57025"},
        {"Smithsonian Astrophysical Observation", "SAO 28097"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.38211494),
        dec: Angle.Degrees(+51.98201489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236292"},
        {"Hipparcos Number", "HIP 393"},
        {"Smithsonian Astrophysical Observation", "SAO 21060"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.21827175),
        dec: Angle.Degrees(+51.98257157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8054"},
        {"Hipparcos Number", "HIP 6306"},
        {"Cincinnati Publication", "Ci 18 170"},
        {"Geneva Identification System", "GEN# +1.00008054"},
        {"Smithsonian Astrophysical Observation", "SAO 22205"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.26345223),
        dec: Angle.Degrees(+51.98392092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 288.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59874",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59874"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.18626131),
        dec: Angle.Degrees(+51.98754433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66681"},
        {"Hipparcos Number", "HIP 39727"},
        {"Smithsonian Astrophysical Observation", "SAO 26673"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.80126499),
        dec: Angle.Degrees(+51.98786306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49600"},
        {"Hipparcos Number", "HIP 32966"},
        {"Smithsonian Astrophysical Observation", "SAO 26003"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.99845260),
        dec: Angle.Degrees(+51.99072844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103011"},
        {"Hipparcos Number", "HIP 57846"},
        {"Smithsonian Astrophysical Observation", "SAO 28166"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.94064544),
        dec: Angle.Degrees(+51.99151997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68193",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9071 AB"},
        {"Henry Draper", "HD 121995"},
        {"Hipparcos Number", "HIP 68193"},
        {"Geneva Identification System", "GEN# +1.00121995"},
        {"Smithsonian Astrophysical Observation", "SAO 28945"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.41701951),
        dec: Angle.Degrees(+51.99359035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 239.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188323"},
        {"Hipparcos Number", "HIP 97773"},
        {"Smithsonian Astrophysical Observation", "SAO 32067"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.02517197),
        dec: Angle.Degrees(+51.99514303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120135"},
        {"Hipparcos Number", "HIP 67214"},
        {"Smithsonian Astrophysical Observation", "SAO 28882"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.61085651),
        dec: Angle.Degrees(+51.99539344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56974",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56974"},
        {"Wilson Evans Batten Catalogue", "WEB 10256"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.19323658),
        dec: Angle.Degrees(+51.99818257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59057"},
        {"Hipparcos Number", "HIP 36536"},
        {"Geneva Identification System", "GEN# +1.00059057"},
        {"Smithsonian Astrophysical Observation", "SAO 26382"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.73664718),
        dec: Angle.Degrees(+51.99876677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193089"},
        {"Hipparcos Number", "HIP 99909"},
        {"Smithsonian Astrophysical Observation", "SAO 32411"},
    },
    visualMagnitude: 7.47,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.06654511),
        dec: Angle.Degrees(+51.99877448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27920"},
        {"Hipparcos Number", "HIP 20770"},
        {"Smithsonian Astrophysical Observation", "SAO 24617"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.75266819),
        dec: Angle.Degrees(+52.00231765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76506"},
        {"Hipparcos Number", "HIP 44073"},
        {"Geneva Identification System", "GEN# +1.00076506"},
        {"Smithsonian Astrophysical Observation", "SAO 27066"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.67622674),
        dec: Angle.Degrees(+52.00328473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235443"},
        {"Hipparcos Number", "HIP 104211"},
        {"Smithsonian Astrophysical Observation", "SAO 33141"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.70675703),
        dec: Angle.Degrees(+52.00474298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129674"},
        {"Hipparcos Number", "HIP 71872"},
        {"Geneva Identification System", "GEN# +1.00129674"},
        {"Smithsonian Astrophysical Observation", "SAO 29248"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.50290436),
        dec: Angle.Degrees(+52.00530805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46838"},
        {"Hipparcos Number", "HIP 31748"},
        {"Smithsonian Astrophysical Observation", "SAO 25853"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.61647449),
        dec: Angle.Degrees(+52.00617244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211973"},
        {"Hipparcos Number", "HIP 110249"},
        {"Geneva Identification System", "GEN# +1.00211973"},
        {"Smithsonian Astrophysical Observation", "SAO 34319"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.97930243),
        dec: Angle.Degrees(+52.00712508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91969",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11659 AB"},
        {"Henry Draper", "HD 173845"},
        {"Hipparcos Number", "HIP 91969"},
        {"Smithsonian Astrophysical Observation", "SAO 31143"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.18865729),
        dec: Angle.Degrees(+52.00911483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42508"},
        {"Hipparcos Number", "HIP 29580"},
        {"Geneva Identification System", "GEN# +1.00042508"},
        {"Smithsonian Astrophysical Observation", "SAO 25631"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.49603786),
        dec: Angle.Degrees(+52.01154731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48773",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48773"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.21337008),
        dec: Angle.Degrees(+52.01163907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29223"},
        {"Hipparcos Number", "HIP 21631"},
        {"Smithsonian Astrophysical Observation", "SAO 24736"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.67594544),
        dec: Angle.Degrees(+52.01356000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1872"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.91542117),
        dec: Angle.Degrees(+52.01453370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85067"},
        {"Hipparcos Number", "HIP 48317"},
        {"Geneva Identification System", "GEN# +1.00085067"},
        {"Smithsonian Astrophysical Observation", "SAO 27402"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.74558400),
        dec: Angle.Degrees(+52.01957821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1921",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 328 AB"},
        {"Henry Draper", "HD 1976"},
        {"Hipparcos Number", "HIP 1921"},
        {"Geneva Identification System", "GEN# +1.00001976J"},
        {"Smithsonian Astrophysical Observation", "SAO 21366"},
        {"Wilson Evans Batten Catalogue", "WEB 355"},
    },
    visualMagnitude: 5.58,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.06518443),
        dec: Angle.Degrees(+52.01992467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235581"},
        {"Hipparcos Number", "HIP 106963"},
        {"Smithsonian Astrophysical Observation", "SAO 33640"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.95419387),
        dec: Angle.Degrees(+52.02253003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19748"},
        {"Hipparcos Number", "HIP 14957"},
        {"Smithsonian Astrophysical Observation", "SAO 23879"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.20642721),
        dec: Angle.Degrees(+52.02390436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179780"},
        {"Hipparcos Number", "HIP 94266"},
        {"Smithsonian Astrophysical Observation", "SAO 31457"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.80689028),
        dec: Angle.Degrees(+52.02451408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26972"},
        {"Hipparcos Number", "HIP 20100"},
        {"Geneva Identification System", "GEN# +1.00026972"},
        {"Smithsonian Astrophysical Observation", "SAO 24533"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.63479780),
        dec: Angle.Degrees(+52.02540930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166434"},
        {"Hipparcos Number", "HIP 88809"},
        {"Smithsonian Astrophysical Observation", "SAO 30762"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.93958740),
        dec: Angle.Degrees(+52.02763671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146736"},
        {"Hipparcos Number", "HIP 79656"},
        {"Smithsonian Astrophysical Observation", "SAO 29855"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.81625578),
        dec: Angle.Degrees(+52.02997930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15429",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15429"},
        {"Geneva Identification System", "GEN# +0.05100710"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.71846468),
        dec: Angle.Degrees(+52.03006814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72923"},
        {"Hipparcos Number", "HIP 42324"},
        {"Smithsonian Astrophysical Observation", "SAO 26933"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.43076816),
        dec: Angle.Degrees(+52.03107224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233950"},
        {"Hipparcos Number", "HIP 61002"},
        {"Smithsonian Astrophysical Observation", "SAO 28409"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.54189971),
        dec: Angle.Degrees(+52.03123824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234386"},
        {"Hipparcos Number", "HIP 83660"},
        {"Smithsonian Astrophysical Observation", "SAO 30245"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.48756551),
        dec: Angle.Degrees(+52.03258565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128901"},
        {"Hipparcos Number", "HIP 71529"},
        {"Geneva Identification System", "GEN# +1.00128901"},
        {"Smithsonian Astrophysical Observation", "SAO 29222"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.44277013),
        dec: Angle.Degrees(+52.03263543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5468",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 950 AP"},
        {"Aitken 2", "ADS 950 A"},
        {"Henry Draper", "HD 6843"},
        {"Hipparcos Number", "HIP 5468"},
        {"Geneva Identification System", "GEN# +1.00006843A"},
        {"Smithsonian Astrophysical Observation", "SAO 22048"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.50278431),
        dec: Angle.Degrees(+52.03327354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125557"},
        {"Hipparcos Number", "HIP 69917"},
        {"Geneva Identification System", "GEN# +1.00125557"},
        {"Smithsonian Astrophysical Observation", "SAO 29094"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.62984582),
        dec: Angle.Degrees(+52.03332805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84166"},
        {"Hipparcos Number", "HIP 47818"},
        {"Smithsonian Astrophysical Observation", "SAO 27373"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.21826464),
        dec: Angle.Degrees(+52.03474562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55668"},
        {"Hipparcos Number", "HIP 35206"},
        {"Geneva Identification System", "GEN# +1.00055668"},
        {"Smithsonian Astrophysical Observation", "SAO 26253"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.14855518),
        dec: Angle.Degrees(+52.03522991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232148"},
        {"Hipparcos Number", "HIP 1244"},
        {"Smithsonian Astrophysical Observation", "SAO 21254"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.87742680),
        dec: Angle.Degrees(+52.03613514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17782",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2768 AB"},
        {"Henry Draper", "HD 23524"},
        {"Hipparcos Number", "HIP 17782"},
        {"Geneva Identification System", "GEN# +1.00023524"},
        {"Smithsonian Astrophysical Observation", "SAO 24232"},
        {"Wilson Evans Batten Catalogue", "WEB 3406"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.09560146),
        dec: Angle.Degrees(+52.03802530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53871"},
        {"Hipparcos Number", "HIP 34548"},
        {"Smithsonian Astrophysical Observation", "SAO 26179"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.36239177),
        dec: Angle.Degrees(+52.03875565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147608"},
        {"Hipparcos Number", "HIP 80051"},
        {"Geneva Identification System", "GEN# +1.00147608"},
        {"Smithsonian Astrophysical Observation", "SAO 29897"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.10233986),
        dec: Angle.Degrees(+52.03904433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98967"},
        {"Hipparcos Number", "HIP 55630"},
        {"Geneva Identification System", "GEN# +1.00098967"},
        {"Smithsonian Astrophysical Observation", "SAO 28007"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.94959242),
        dec: Angle.Degrees(+52.04039968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117934"},
        {"Hipparcos Number", "HIP 66061"},
        {"Smithsonian Astrophysical Observation", "SAO 28793"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.14502403),
        dec: Angle.Degrees(+52.04141065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128366"},
        {"Hipparcos Number", "HIP 71286"},
        {"Smithsonian Astrophysical Observation", "SAO 29205"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.68112092),
        dec: Angle.Degrees(+52.04330796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13525"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.55001390),
        dec: Angle.Degrees(+52.04522158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235444"},
        {"Hipparcos Number", "HIP 104263"},
        {"Smithsonian Astrophysical Observation", "SAO 33149"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.83542519),
        dec: Angle.Degrees(+52.04946598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82621"},
        {"Hipparcos Number", "HIP 47006"},
        {"Geneva Identification System", "GEN# +1.00082621"},
        {"Smithsonian Astrophysical Observation", "SAO 27298"},
        {"Wilson Evans Batten Catalogue", "WEB 8858"},
    },
    visualMagnitude: 4.47,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.70622878),
        dec: Angle.Degrees(+52.05156754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137895"},
        {"Hipparcos Number", "HIP 75581"},
        {"Smithsonian Astrophysical Observation", "SAO 29526"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.61723457),
        dec: Angle.Degrees(+52.05252650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71427"},
        {"Hipparcos Number", "HIP 41651"},
        {"Smithsonian Astrophysical Observation", "SAO 26868"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.40172210),
        dec: Angle.Degrees(+52.05310596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5896"},
        {"Hipparcos Number", "HIP 4766"},
        {"Smithsonian Astrophysical Observation", "SAO 21924"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.30969686),
        dec: Angle.Degrees(+52.05533548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189775"},
        {"Hipparcos Number", "HIP 98379"},
        {"Celescope Catalog", "CEL 4899"},
        {"Geneva Identification System", "GEN# +1.00189775"},
        {"Renson", "Renson 52618"},
        {"Smithsonian Astrophysical Observation", "SAO 32170"},
        {"Wilson Evans Batten Catalogue", "WEB 17364"},
    },
    visualMagnitude: 6.14,
    bvColour: -0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.81390745),
        dec: Angle.Degrees(+52.05568515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161353"},
        {"Hipparcos Number", "HIP 86643"},
        {"Smithsonian Astrophysical Observation", "SAO 30526"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.55614663),
        dec: Angle.Degrees(+52.05631900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175369"},
        {"Hipparcos Number", "HIP 92623"},
        {"Smithsonian Astrophysical Observation", "SAO 31229"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.08840252),
        dec: Angle.Degrees(+52.06004491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216275"},
        {"Hipparcos Number", "HIP 112812"},
        {"Geneva Identification System", "GEN# +1.00216275"},
        {"Smithsonian Astrophysical Observation", "SAO 34870"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.69253727),
        dec: Angle.Degrees(+52.06102292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 170.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233562"},
        {"Hipparcos Number", "HIP 42659"},
        {"Smithsonian Astrophysical Observation", "SAO 26965"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.42168519),
        dec: Angle.Degrees(+52.06164234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234582"},
        {"Hipparcos Number", "HIP 89202"},
        {"Fundamental Katalog 5th Edition", "FK5 5605"},
        {"Geneva Identification System", "GEN# +1.00234582"},
        {"Smithsonian Astrophysical Observation", "SAO 30805"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.06036351),
        dec: Angle.Degrees(+52.06191117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220486"},
        {"Hipparcos Number", "HIP 115483"},
        {"Smithsonian Astrophysical Observation", "SAO 35376"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.90000131),
        dec: Angle.Degrees(+52.06198247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119765"},
        {"Hipparcos Number", "HIP 67005"},
        {"Geneva Identification System", "GEN# +1.00119765"},
        {"Renson", "Renson 34540"},
        {"Smithsonian Astrophysical Observation", "SAO 28866"},
        {"Wilson Evans Batten Catalogue", "WEB 11807"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.97831455),
        dec: Angle.Degrees(+52.06442748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21711"},
        {"Hipparcos Number", "HIP 16502"},
        {"Geneva Identification System", "GEN# +5.20200959"},
        {"Smithsonian Astrophysical Observation", "SAO 24083"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.11081038),
        dec: Angle.Degrees(+52.06591101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139478"},
        {"Hipparcos Number", "HIP 76384"},
        {"Geneva Identification System", "GEN# +1.00139478"},
        {"Renson", "Renson 39710"},
        {"Smithsonian Astrophysical Observation", "SAO 29589"},
        {"Wilson Evans Batten Catalogue", "WEB 12969"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.01746508),
        dec: Angle.Degrees(+52.06961147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94117"},
        {"Hipparcos Number", "HIP 53173"},
        {"Geneva Identification System", "GEN# +1.00094117"},
        {"Smithsonian Astrophysical Observation", "SAO 27811"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.16423974),
        dec: Angle.Degrees(+52.07123563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86259"},
        {"Hipparcos Number", "HIP 48924"},
        {"Smithsonian Astrophysical Observation", "SAO 27451"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.71142122),
        dec: Angle.Degrees(+52.07213660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65523"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.46100478),
        dec: Angle.Degrees(+52.07382790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235507"},
        {"Hipparcos Number", "HIP 105657"},
        {"Smithsonian Astrophysical Observation", "SAO 33388"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.01696877),
        dec: Angle.Degrees(+52.08034745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236274"},
        {"Hipparcos Number", "HIP 83"},
        {"Smithsonian Astrophysical Observation", "SAO 35991"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.24808100),
        dec: Angle.Degrees(+52.08056444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14619"},
        {"Hipparcos Number", "HIP 11138"},
        {"Smithsonian Astrophysical Observation", "SAO 23278"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.83388249),
        dec: Angle.Degrees(+52.08313425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34235"},
        {"Hipparcos Number", "HIP 24769"},
        {"Smithsonian Astrophysical Observation", "SAO 25122"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.66573428),
        dec: Angle.Degrees(+52.08700375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209341"},
        {"Hipparcos Number", "HIP 108704"},
        {"Smithsonian Astrophysical Observation", "SAO 33973"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.30150668),
        dec: Angle.Degrees(+52.08893123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223625"},
        {"Hipparcos Number", "HIP 117609"},
        {"Smithsonian Astrophysical Observation", "SAO 35837"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.78657858),
        dec: Angle.Degrees(+52.09222365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114561",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114561"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.09072123),
        dec: Angle.Degrees(+52.09276833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 342.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159542"},
        {"Hipparcos Number", "HIP 85844"},
        {"Smithsonian Astrophysical Observation", "SAO 30451"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.13617328),
        dec: Angle.Degrees(+52.09449259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234962"},
        {"Hipparcos Number", "HIP 96743"},
        {"Smithsonian Astrophysical Observation", "SAO 31873"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.98634096),
        dec: Angle.Degrees(+52.09474441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124137"},
        {"Hipparcos Number", "HIP 69210"},
        {"Smithsonian Astrophysical Observation", "SAO 29025"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.54999047),
        dec: Angle.Degrees(+52.09736267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97178"},
        {"Hipparcos Number", "HIP 54696"},
        {"Smithsonian Astrophysical Observation", "SAO 27943"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.96494606),
        dec: Angle.Degrees(+52.09782546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22951",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3520"},
        {"Henry Draper", "HD 31166"},
        {"Hipparcos Number", "HIP 22951"},
        {"Geneva Identification System", "GEN# +1.00031166J"},
        {"Smithsonian Astrophysical Observation", "SAO 24922"},
    },
    visualMagnitude: 7.92,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.07030702),
        dec: Angle.Degrees(+52.09782904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4615"},
        {"Henry Draper 2", "HD 4616"},
        {"Hipparcos Number", "HIP 3787"},
        {"Geneva Identification System", "GEN# +1.00004615"},
        {"Smithsonian Astrophysical Observation", "SAO 21727"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.17124200),
        dec: Angle.Degrees(+52.10084310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220444"},
        {"Hipparcos Number", "HIP 115460"},
        {"Smithsonian Astrophysical Observation", "SAO 35371"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.83124237),
        dec: Angle.Degrees(+52.10255730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112411",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16259 A"},
        {"Henry Draper", "HD 215684"},
        {"Hipparcos Number", "HIP 112411"},
        {"Geneva Identification System", "GEN# +1.00215684"},
        {"Smithsonian Astrophysical Observation", "SAO 34783"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.52701352),
        dec: Angle.Degrees(+52.10479413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91683"},
        {"Hipparcos Number", "HIP 51910"},
        {"Smithsonian Astrophysical Observation", "SAO 27703"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.07612913),
        dec: Angle.Degrees(+52.10948076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19380"},
        {"Hipparcos Number", "HIP 14634"},
        {"Smithsonian Astrophysical Observation", "SAO 23839"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.27233913),
        dec: Angle.Degrees(+52.10981144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121343"},
        {"Hipparcos Number", "HIP 67818"},
        {"Geneva Identification System", "GEN# +1.00121343"},
        {"Smithsonian Astrophysical Observation", "SAO 28924"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.38610346),
        dec: Angle.Degrees(+52.11106797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13881",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13881"},
        {"Geneva Identification System", "GEN# +0.05100659"},
        {"Wilson Evans Batten Catalogue", "WEB 2743"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.69646086),
        dec: Angle.Degrees(+52.11151719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83616"},
        {"Hipparcos Number", "HIP 47531"},
        {"Geneva Identification System", "GEN# +1.00083616"},
        {"Smithsonian Astrophysical Observation", "SAO 27343"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.36068003),
        dec: Angle.Degrees(+52.11337124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171461"},
        {"Hipparcos Number", "HIP 90865"},
        {"Fundamental Katalog 5th Edition", "FK5 3474"},
        {"Geneva Identification System", "GEN# +1.00171461"},
        {"Smithsonian Astrophysical Observation", "SAO 31032"},
        {"Wilson Evans Batten Catalogue", "WEB 15582"},
    },
    visualMagnitude: 6.58,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.04742968),
        dec: Angle.Degrees(+52.11553235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11400",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11400"},
        {"Wilson Evans Batten Catalogue", "WEB 2380"},
    },
    visualMagnitude: 9.42,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.71959660),
        dec: Angle.Degrees(+52.11741890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182512"},
        {"Hipparcos Number", "HIP 95218"},
        {"Smithsonian Astrophysical Observation", "SAO 31610"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.57988091),
        dec: Angle.Degrees(+52.11838038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144042"},
        {"Hipparcos Number", "HIP 78489"},
        {"Smithsonian Astrophysical Observation", "SAO 29757"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.34549906),
        dec: Angle.Degrees(+52.11960619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53384"},
        {"Smithsonian Astrophysical Observation", "SAO 27829"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.76868749),
        dec: Angle.Degrees(+52.12015622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235795"},
        {"Hipparcos Number", "HIP 110186"},
        {"Geneva Identification System", "GEN# +1.00235795"},
        {"Smithsonian Astrophysical Observation", "SAO 34306"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.78165470),
        dec: Angle.Degrees(+52.12032537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94435"},
        {"Hipparcos Number", "HIP 53380"},
        {"Smithsonian Astrophysical Observation", "SAO 27828"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.75478372),
        dec: Angle.Degrees(+52.12172659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184826"},
        {"Hipparcos Number", "HIP 96200"},
        {"Geneva Identification System", "GEN# +1.00184826"},
        {"Smithsonian Astrophysical Observation", "SAO 31773"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.42615223),
        dec: Angle.Degrees(+52.12293958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207329"},
        {"Hipparcos Number", "HIP 107521"},
        {"Celescope Catalog", "CEL 5386"},
        {"Geneva Identification System", "GEN# +1.00207329"},
        {"Smithsonian Astrophysical Observation", "SAO 33746"},
        {"Wilson Evans Batten Catalogue", "WEB 19407"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.64328338),
        dec: Angle.Degrees(+52.12415509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232880"},
        {"Hipparcos Number", "HIP 18948"},
        {"Geneva Identification System", "GEN# +1.00232880"},
        {"Smithsonian Astrophysical Observation", "SAO 24380"},
        {"Wilson Evans Batten Catalogue", "WEB 3643"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.91237821),
        dec: Angle.Degrees(+52.12505898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45191"},
        {"Hipparcos Number", "HIP 30878"},
        {"Geneva Identification System", "GEN# +1.00045191"},
        {"Smithsonian Astrophysical Observation", "SAO 25754"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.22894911),
        dec: Angle.Degrees(+52.12590325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233571"},
        {"Hipparcos Number", "HIP 43196"},
        {"Smithsonian Astrophysical Observation", "SAO 26998"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.00112657),
        dec: Angle.Degrees(+52.12601578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36195"},
        {"Hipparcos Number", "HIP 25996"},
        {"Smithsonian Astrophysical Observation", "SAO 25243"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.22861009),
        dec: Angle.Degrees(+52.12817575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12858"},
        {"Hipparcos Number", "HIP 9905"},
        {"Smithsonian Astrophysical Observation", "SAO 22941"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.87258879),
        dec: Angle.Degrees(+52.12908895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6917"},
        {"Hipparcos Number", "HIP 5508"},
        {"Smithsonian Astrophysical Observation", "SAO 22057"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.63529166),
        dec: Angle.Degrees(+52.12923848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234253"},
        {"Hipparcos Number", "HIP 76850"},
        {"Smithsonian Astrophysical Observation", "SAO 29623"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.37827363),
        dec: Angle.Degrees(+52.12971757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55866"},
        {"Hipparcos Number", "HIP 35304"},
        {"Geneva Identification System", "GEN# +1.00055866"},
        {"Smithsonian Astrophysical Observation", "SAO 26260"},
        {"Wilson Evans Batten Catalogue", "WEB 7048"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.39050118),
        dec: Angle.Degrees(+52.13111463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7978"},
        {"Hipparcos Number", "HIP 6250"},
        {"Smithsonian Astrophysical Observation", "SAO 22194"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.04900453),
        dec: Angle.Degrees(+52.13142803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55796",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8158 A"},
        {"Henry Draper", "HD 99266"},
        {"Hipparcos Number", "HIP 55796"},
        {"Fundamental Katalog 5th Edition", "FK5 5006"},
        {"Geneva Identification System", "GEN# +1.00099266"},
        {"Smithsonian Astrophysical Observation", "SAO 28016"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.47981909),
        dec: Angle.Degrees(+52.13208947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5554"},
        {"Hipparcos Number", "HIP 4523"},
        {"Smithsonian Astrophysical Observation", "SAO 21883"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.48235703),
        dec: Angle.Degrees(+52.13679080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200387"},
        {"Hipparcos Number", "HIP 103731"},
        {"Smithsonian Astrophysical Observation", "SAO 33069"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.28971025),
        dec: Angle.Degrees(+52.13697487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145871"},
        {"Hipparcos Number", "HIP 79272"},
        {"Smithsonian Astrophysical Observation", "SAO 29832"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.68910185),
        dec: Angle.Degrees(+52.13711286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47878"},
        {"Hipparcos Number", "HIP 32229"},
        {"Geneva Identification System", "GEN# +1.00047878"},
        {"Smithsonian Astrophysical Observation", "SAO 25911"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.92220698),
        dec: Angle.Degrees(+52.13729600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133562"},
        {"Hipparcos Number", "HIP 73644"},
        {"Smithsonian Astrophysical Observation", "SAO 29390"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.79354379),
        dec: Angle.Degrees(+52.14027049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67481"},
        {"Hipparcos Number", "HIP 40041"},
        {"Geneva Identification System", "GEN# +1.00067481"},
        {"Smithsonian Astrophysical Observation", "SAO 26712"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.68671789),
        dec: Angle.Degrees(+52.14292643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141372"},
        {"Hipparcos Number", "HIP 77253"},
        {"Geneva Identification System", "GEN# +1.00141372"},
        {"Smithsonian Astrophysical Observation", "SAO 29652"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.60214856),
        dec: Angle.Degrees(+52.14772232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43750"},
        {"Hipparcos Number", "HIP 30165"},
        {"Smithsonian Astrophysical Observation", "SAO 25674"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.20830195),
        dec: Angle.Degrees(+52.14833389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20834"},
        {"Hipparcos Number", "HIP 15790"},
        {"Smithsonian Astrophysical Observation", "SAO 24000"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.87545862),
        dec: Angle.Degrees(+52.14850092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17158"},
        {"Hipparcos Number", "HIP 12994"},
        {"Smithsonian Astrophysical Observation", "SAO 23606"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.77271993),
        dec: Angle.Degrees(+52.14868017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189859"},
        {"Hipparcos Number", "HIP 98424"},
        {"Smithsonian Astrophysical Observation", "SAO 32182"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.97409568),
        dec: Angle.Degrees(+52.14981565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16654"},
        {"Hipparcos Number", "HIP 12604"},
        {"Smithsonian Astrophysical Observation", "SAO 23541"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.51993783),
        dec: Angle.Degrees(+52.15155510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137256"},
        {"Hipparcos Number", "HIP 75280"},
        {"Smithsonian Astrophysical Observation", "SAO 29505"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.71061241),
        dec: Angle.Degrees(+52.15305290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218313"},
        {"Hipparcos Number", "HIP 114083"},
        {"Smithsonian Astrophysical Observation", "SAO 35140"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.58666185),
        dec: Angle.Degrees(+52.15365232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233932"},
        {"Hipparcos Number", "HIP 60427"},
        {"Smithsonian Astrophysical Observation", "SAO 28361"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.85284284),
        dec: Angle.Degrees(+52.15378777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233640"},
        {"Hipparcos Number", "HIP 46613"},
        {"Cincinnati Publication", "Ci 18 1123"},
        {"Geneva Identification System", "GEN# +1.00233640"},
        {"Smithsonian Astrophysical Observation", "SAO 27273"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.57829121),
        dec: Angle.Degrees(+52.15388144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -252.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87547"},
        {"Hipparcos Number", "HIP 49555"},
        {"Smithsonian Astrophysical Observation", "SAO 27522"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.77162596),
        dec: Angle.Degrees(+52.15520140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 208.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89432",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11215 A"},
        {"Henry Draper", "HD 168065"},
        {"Hipparcos Number", "HIP 89432"},
        {"Smithsonian Astrophysical Observation", "SAO 30837"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.78929357),
        dec: Angle.Degrees(+52.15688871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91453"},
        {"Hipparcos Number", "HIP 51771"},
        {"Smithsonian Astrophysical Observation", "SAO 27692"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.68692911),
        dec: Angle.Degrees(+52.15703463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122300"},
        {"Hipparcos Number", "HIP 68368"},
        {"Geneva Identification System", "GEN# +1.00122300"},
        {"Smithsonian Astrophysical Observation", "SAO 28962"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.92103257),
        dec: Angle.Degrees(+52.15827902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233490"},
        {"Hipparcos Number", "HIP 39549"},
        {"Smithsonian Astrophysical Observation", "SAO 26659"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.22507035),
        dec: Angle.Degrees(+52.15951347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38007"},
        {"Hipparcos Number", "HIP 27165"},
        {"Geneva Identification System", "GEN# +1.00038007"},
        {"Smithsonian Astrophysical Observation", "SAO 25356"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.37412381),
        dec: Angle.Degrees(+52.16150412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234382"},
        {"Hipparcos Number", "HIP 83546"},
        {"Smithsonian Astrophysical Observation", "SAO 30231"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.12678847),
        dec: Angle.Degrees(+52.16156591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224325"},
        {"Hipparcos Number", "HIP 118058"},
        {"Smithsonian Astrophysical Observation", "SAO 35914"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.24186470),
        dec: Angle.Degrees(+52.16302655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19624"},
        {"Hipparcos Number", "HIP 14845"},
        {"Geneva Identification System", "GEN# +5.20200145"},
        {"Smithsonian Astrophysical Observation", "SAO 23867"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.92866464),
        dec: Angle.Degrees(+52.16352076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9635"},
        {"Hipparcos Number", "HIP 7419"},
        {"Smithsonian Astrophysical Observation", "SAO 22417"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.90377263),
        dec: Angle.Degrees(+52.16384412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114398"},
        {"Hipparcos Number", "HIP 64206"},
        {"Geneva Identification System", "GEN# +1.00114398"},
        {"Smithsonian Astrophysical Observation", "SAO 28653"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.38085311),
        dec: Angle.Degrees(+52.16605917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106596",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15118 AB"},
        {"Henry Draper", "HD 235553"},
        {"Hipparcos Number", "HIP 106596"},
        {"Geneva Identification System", "GEN# +1.00235553J"},
        {"Smithsonian Astrophysical Observation", "SAO 33555"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.83362890),
        dec: Angle.Degrees(+52.16958003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90122"},
        {"Hipparcos Number", "HIP 51015"},
        {"Geneva Identification System", "GEN# +1.00090122"},
        {"Smithsonian Astrophysical Observation", "SAO 27637"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.33065546),
        dec: Angle.Degrees(+52.17155385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37395"},
        {"Hipparcos Number", "HIP 26769"},
        {"Geneva Identification System", "GEN# +1.00037395"},
        {"Smithsonian Astrophysical Observation", "SAO 25317"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.29775383),
        dec: Angle.Degrees(+52.17205124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1819",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 312 A"},
        {"Henry Draper", "HD 232172"},
        {"Hipparcos Number", "HIP 1819"},
        {"Smithsonian Astrophysical Observation", "SAO 21340"},
    },
    visualMagnitude: 9.51,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.76379110),
        dec: Angle.Degrees(+52.17220905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1458"},
        {"Hipparcos Number", "HIP 1519"},
        {"Smithsonian Astrophysical Observation", "SAO 21292"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.73492458),
        dec: Angle.Degrees(+52.17267274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125857"},
        {"Hipparcos Number", "HIP 70075"},
        {"Geneva Identification System", "GEN# +1.00125857"},
        {"Smithsonian Astrophysical Observation", "SAO 29107"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.09995065),
        dec: Angle.Degrees(+52.17268645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234356"},
        {"Hipparcos Number", "HIP 82420"},
        {"Smithsonian Astrophysical Observation", "SAO 30121"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.65341451),
        dec: Angle.Degrees(+52.17557096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38958"},
        {"Hipparcos Number", "HIP 27733"},
        {"Geneva Identification System", "GEN# +1.00038958"},
        {"Smithsonian Astrophysical Observation", "SAO 25423"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.07389330),
        dec: Angle.Degrees(+52.17948575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41405",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41405"},
        {"Geneva Identification System", "GEN# +0.05201308A"},
        {"Wilson Evans Batten Catalogue", "WEB 8012"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)26, 47.0200),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)10, 55.300)
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
    primaryId: "HIP 53510",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7983 A"},
        {"Henry Draper", "HD 94699"},
        {"Hipparcos Number", "HIP 53510"},
        {"Smithsonian Astrophysical Observation", "SAO 27835"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.19906109),
        dec: Angle.Degrees(+52.18358346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19231"},
        {"Hipparcos Number", "HIP 14541"},
        {"Smithsonian Astrophysical Observation", "SAO 23821"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.93867464),
        dec: Angle.Degrees(+52.18395827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56855",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8253 B"},
        {"Hipparcos Number", "HIP 56855"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.85084321),
        dec: Angle.Degrees(+52.18405120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132771"},
        {"Hipparcos Number", "HIP 73313"},
        {"Smithsonian Astrophysical Observation", "SAO 29365"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.72700536),
        dec: Angle.Degrees(+52.18481762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57679"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.43846889),
        dec: Angle.Degrees(+67.33804700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -162.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42869"},
        {"Hipparcos Number", "HIP 29764"},
        {"Smithsonian Astrophysical Observation", "SAO 25640"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.02018513),
        dec: Angle.Degrees(+52.18582317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41397"},
        {"Geneva Identification System", "GEN# +0.05201308B"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)26, 43.1400),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)11, 13.500)
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
    primaryId: "HIP 56854",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8253 A"},
        {"Henry Draper", "HD 101254"},
        {"Hipparcos Number", "HIP 56854"},
        {"Geneva Identification System", "GEN# +1.00101254"},
        {"Smithsonian Astrophysical Observation", "SAO 28088"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.84845569),
        dec: Angle.Degrees(+52.18756552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234383"},
        {"Hipparcos Number", "HIP 83610"},
        {"Smithsonian Astrophysical Observation", "SAO 30237"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.33791534),
        dec: Angle.Degrees(+52.19393471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205084"},
        {"Hipparcos Number", "HIP 106256"},
        {"Geneva Identification System", "GEN# +1.00205084"},
        {"Smithsonian Astrophysical Observation", "SAO 33496"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.82568300),
        dec: Angle.Degrees(+52.19540600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172883"},
        {"Hipparcos Number", "HIP 91525"},
        {"Geneva Identification System", "GEN# +1.00172883"},
        {"Renson", "Renson 48480"},
        {"Smithsonian Astrophysical Observation", "SAO 31093"},
        {"Wilson Evans Batten Catalogue", "WEB 15733"},
    },
    visualMagnitude: 6.00,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.97003869),
        dec: Angle.Degrees(+52.19602352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3802"},
        {"Hipparcos Number", "HIP 3240"},
        {"Smithsonian Astrophysical Observation", "SAO 21621"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.30310097),
        dec: Angle.Degrees(+52.19773368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236028"},
        {"Hipparcos Number", "HIP 113819"},
        {"Smithsonian Astrophysical Observation", "SAO 35097"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.73056765),
        dec: Angle.Degrees(+52.19824924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232361"},
        {"Hipparcos Number", "HIP 4976"},
        {"Smithsonian Astrophysical Observation", "SAO 21962"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.94215307),
        dec: Angle.Degrees(+52.19870330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17655"},
        {"Hipparcos Number", "HIP 13371"},
        {"Smithsonian Astrophysical Observation", "SAO 23666"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.00505588),
        dec: Angle.Degrees(+52.19992942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72458"},
        {"Hipparcos Number", "HIP 42125"},
        {"Geneva Identification System", "GEN# +1.00072458"},
        {"Smithsonian Astrophysical Observation", "SAO 26917"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.80640128),
        dec: Angle.Degrees(+52.20031010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47885"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.37954076),
        dec: Angle.Degrees(+52.20465268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -160.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60470"},
        {"Hipparcos Number", "HIP 37090"},
        {"Smithsonian Astrophysical Observation", "SAO 26431"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.32375979),
        dec: Angle.Degrees(+52.20605050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60077"},
        {"Hipparcos Number", "HIP 36935"},
        {"Geneva Identification System", "GEN# +1.00060077"},
        {"Smithsonian Astrophysical Observation", "SAO 26417"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.89035412),
        dec: Angle.Degrees(+52.20689561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64839",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64839"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.37635269),
        dec: Angle.Degrees(+52.20746998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25069",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3924 AB"},
        {"Henry Draper", "HD 34667"},
        {"Hipparcos Number", "HIP 25069"},
        {"Smithsonian Astrophysical Observation", "SAO 25147"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.50004719),
        dec: Angle.Degrees(+52.21211335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123572"},
        {"Hipparcos Number", "HIP 68962"},
        {"Smithsonian Astrophysical Observation", "SAO 29012"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.76222164),
        dec: Angle.Degrees(+52.21231099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19268"},
        {"Hipparcos Number", "HIP 14566"},
        {"Geneva Identification System", "GEN# +1.00019268"},
        {"Smithsonian Astrophysical Observation", "SAO 23825"},
        {"Wilson Evans Batten Catalogue", "WEB 2831"},
    },
    visualMagnitude: 6.33,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.01596021),
        dec: Angle.Degrees(+52.21356389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25635",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25635"},
    },
    visualMagnitude: 11.14,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.13050221),
        dec: Angle.Degrees(+52.21441702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232683"},
        {"Hipparcos Number", "HIP 12211"},
        {"Smithsonian Astrophysical Observation", "SAO 23477"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.30435160),
        dec: Angle.Degrees(+52.21614852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164394"},
        {"Hipparcos Number", "HIP 87960"},
        {"Smithsonian Astrophysical Observation", "SAO 30665"},
        {"Wilson Evans Batten Catalogue", "WEB 14853"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.52238685),
        dec: Angle.Degrees(+52.21833614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77158"},
        {"Hipparcos Number", "HIP 44412"},
        {"Geneva Identification System", "GEN# +1.00077158"},
        {"Smithsonian Astrophysical Observation", "SAO 27094"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.71061242),
        dec: Angle.Degrees(+52.22200682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36386"},
        {"Hipparcos Number", "HIP 26121"},
        {"Geneva Identification System", "GEN# +1.00036386"},
        {"Smithsonian Astrophysical Observation", "SAO 25261"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.56568651),
        dec: Angle.Degrees(+52.22373832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236232"},
        {"Hipparcos Number", "HIP 117599"},
        {"Smithsonian Astrophysical Observation", "SAO 35834"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.73836734),
        dec: Angle.Degrees(+52.22459152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24421"},
        {"Hipparcos Number", "HIP 18366"},
        {"Geneva Identification System", "GEN# +1.00024421"},
        {"Smithsonian Astrophysical Observation", "SAO 24301"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.90497355),
        dec: Angle.Degrees(+52.22655593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 108.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212496"},
        {"Hipparcos Number", "HIP 110538"},
        {"Fundamental Katalog 5th Edition", "FK5 844"},
        {"Geneva Identification System", "GEN# +1.00212496"},
        {"Smithsonian Astrophysical Observation", "SAO 34395"},
        {"Wilson Evans Batten Catalogue", "WEB 19813"},
    },
    visualMagnitude: 4.42,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.89015172),
        dec: Angle.Degrees(+52.22949951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219049"},
        {"Hipparcos Number", "HIP 114559"},
        {"Geneva Identification System", "GEN# +1.00219049"},
        {"Smithsonian Astrophysical Observation", "SAO 35227"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.08568876),
        dec: Angle.Degrees(+52.22960969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100271",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100271"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.07949342),
        dec: Angle.Degrees(+52.22993250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 260.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48362"},
        {"Hipparcos Number", "HIP 32412"},
        {"Geneva Identification System", "GEN# +1.00048362"},
        {"Smithsonian Astrophysical Observation", "SAO 25941"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.49844137),
        dec: Angle.Degrees(+52.23033302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35012"},
        {"Hipparcos Number", "HIP 25279"},
        {"Smithsonian Astrophysical Observation", "SAO 25177"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.11495260),
        dec: Angle.Degrees(+52.23035046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113957"},
        {"Hipparcos Number", "HIP 63957"},
        {"Smithsonian Astrophysical Observation", "SAO 28633"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.60500188),
        dec: Angle.Degrees(+52.23246844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129500"},
        {"Hipparcos Number", "HIP 71784"},
        {"Geneva Identification System", "GEN# +1.00129500"},
        {"Smithsonian Astrophysical Observation", "SAO 29243"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.25970843),
        dec: Angle.Degrees(+52.23597246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149718"},
        {"Hipparcos Number", "HIP 81113"},
        {"Smithsonian Astrophysical Observation", "SAO 29989"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.49658454),
        dec: Angle.Degrees(+52.23795289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4477",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 792 A"},
        {"Henry Draper", "HD 5492"},
        {"Hipparcos Number", "HIP 4477"},
        {"Smithsonian Astrophysical Observation", "SAO 21871"},
        {"Wilson Evans Batten Catalogue", "WEB 810"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.33416991),
        dec: Angle.Degrees(+52.23994300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144467"},
        {"Hipparcos Number", "HIP 78667"},
        {"Smithsonian Astrophysical Observation", "SAO 29778"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.89551829),
        dec: Angle.Degrees(+52.24135945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234004"},
        {"Hipparcos Number", "HIP 63637"},
        {"Geneva Identification System", "GEN# +1.00234004"},
        {"Smithsonian Astrophysical Observation", "SAO 28611"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.64334987),
        dec: Angle.Degrees(+52.24715656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181677"},
        {"Hipparcos Number", "HIP 94896"},
        {"Geneva Identification System", "GEN# +1.00181677"},
        {"Smithsonian Astrophysical Observation", "SAO 31562"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.67027693),
        dec: Angle.Degrees(+52.24738404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222770"},
        {"Hipparcos Number", "HIP 117010"},
        {"Geneva Identification System", "GEN# +1.00222770"},
        {"Renson", "Renson 61090"},
        {"Smithsonian Astrophysical Observation", "SAO 35702"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.80605543),
        dec: Angle.Degrees(+52.24815473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225275"},
        {"Hipparcos Number", "HIP 397"},
        {"Smithsonian Astrophysical Observation", "SAO 21061"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.22530082),
        dec: Angle.Degrees(+52.24894130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16605",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16605"},
        {"Smithsonian Astrophysical Observation", "SAO 24102"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.43470825),
        dec: Angle.Degrees(+52.24917185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232741"},
        {"Hipparcos Number", "HIP 14182"},
        {"Smithsonian Astrophysical Observation", "SAO 23778"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.71925435),
        dec: Angle.Degrees(+52.24988187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 143.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232916"},
        {"Hipparcos Number", "HIP 19734"},
        {"Smithsonian Astrophysical Observation", "SAO 24485"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.45174303),
        dec: Angle.Degrees(+52.25235019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124101"},
        {"Hipparcos Number", "HIP 69199"},
        {"Geneva Identification System", "GEN# +1.00124101"},
        {"Smithsonian Astrophysical Observation", "SAO 29024"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.50024744),
        dec: Angle.Degrees(+52.25291290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135943"},
        {"Hipparcos Number", "HIP 74683"},
        {"Smithsonian Astrophysical Observation", "SAO 29463"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.93983472),
        dec: Angle.Degrees(+52.25390318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134383"},
        {"Hipparcos Number", "HIP 74017"},
        {"Smithsonian Astrophysical Observation", "SAO 29413"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.88980584),
        dec: Angle.Degrees(+52.25425648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95124"},
        {"Hipparcos Number", "HIP 53748"},
        {"Geneva Identification System", "GEN# +1.00095124"},
        {"Smithsonian Astrophysical Observation", "SAO 27864"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.95494348),
        dec: Angle.Degrees(+52.25462087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24142"},
        {"Hipparcos Number", "HIP 18167"},
        {"Geneva Identification System", "GEN# +1.00024142"},
        {"Smithsonian Astrophysical Observation", "SAO 24275"},
        {"Wilson Evans Batten Catalogue", "WEB 3501"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.26081384),
        dec: Angle.Degrees(+52.25510241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 567"},
        {"Hipparcos Number", "HIP 838"},
        {"Smithsonian Astrophysical Observation", "SAO 21156"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.56856497),
        dec: Angle.Degrees(+52.25514295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150188"},
        {"Hipparcos Number", "HIP 81340"},
        {"Smithsonian Astrophysical Observation", "SAO 30017"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.18923529),
        dec: Angle.Degrees(+52.25624975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90789"},
        {"Hipparcos Number", "HIP 51417"},
        {"Geneva Identification System", "GEN# +1.00090789"},
        {"Smithsonian Astrophysical Observation", "SAO 27663"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.52320603),
        dec: Angle.Degrees(+52.25757539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234650"},
        {"Hipparcos Number", "HIP 90354"},
        {"Geneva Identification System", "GEN# +1.00234650"},
        {"Smithsonian Astrophysical Observation", "SAO 30968"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.53978162),
        dec: Angle.Degrees(+52.25927764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18372",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2852 AB"},
        {"Henry Draper", "HD 232858"},
        {"Hipparcos Number", "HIP 18372"},
        {"Smithsonian Astrophysical Observation", "SAO 24302"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.91148960),
        dec: Angle.Degrees(+52.26046751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93466",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11979 A"},
        {"Henry Draper", "HD 177483"},
        {"Hipparcos Number", "HIP 93466"},
        {"Geneva Identification System", "GEN# +1.00177483"},
        {"Smithsonian Astrophysical Observation", "SAO 31337"},
        {"Wilson Evans Batten Catalogue", "WEB 16222"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.52933604),
        dec: Angle.Degrees(+52.26113740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136693"},
        {"Hipparcos Number", "HIP 75033"},
        {"Smithsonian Astrophysical Observation", "SAO 29486"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.98009697),
        dec: Angle.Degrees(+52.26227350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222293"},
        {"Hipparcos Number", "HIP 116705"},
        {"Smithsonian Astrophysical Observation", "SAO 35640"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.75593182),
        dec: Angle.Degrees(+52.26246474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232933"},
        {"Hipparcos Number", "HIP 20035"},
        {"Smithsonian Astrophysical Observation", "SAO 24529"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.45828976),
        dec: Angle.Degrees(+52.26299496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10054"},
        {"Hipparcos Number", "HIP 7729"},
        {"Geneva Identification System", "GEN# +1.00010054"},
        {"Smithsonian Astrophysical Observation", "SAO 22479"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.87773287),
        dec: Angle.Degrees(+52.26680555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93763"},
        {"Hipparcos Number", "HIP 52989"},
        {"Geneva Identification System", "GEN# +1.00093763"},
        {"Smithsonian Astrophysical Observation", "SAO 27783"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.60214969),
        dec: Angle.Degrees(+52.26754878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207119"},
        {"Hipparcos Number", "HIP 107398"},
        {"Geneva Identification System", "GEN# +1.00207119"},
        {"Smithsonian Astrophysical Observation", "SAO 33722"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.30167040),
        dec: Angle.Degrees(+52.26757875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56711"},
        {"Hipparcos Number", "HIP 35612"},
        {"Geneva Identification System", "GEN# +1.00056711"},
        {"Smithsonian Astrophysical Observation", "SAO 26290"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.23034182),
        dec: Angle.Degrees(+52.26797628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216306"},
        {"Hipparcos Number", "HIP 112835"},
        {"Geneva Identification System", "GEN# +1.00216306"},
        {"Smithsonian Astrophysical Observation", "SAO 34875"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.76623323),
        dec: Angle.Degrees(+52.26832350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232936"},
        {"Hipparcos Number", "HIP 20220"},
        {"Smithsonian Astrophysical Observation", "SAO 24541"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.99378526),
        dec: Angle.Degrees(+52.26876898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85829"},
        {"Hipparcos Number", "HIP 48710"},
        {"Smithsonian Astrophysical Observation", "SAO 27432"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.02520981),
        dec: Angle.Degrees(+52.26906508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235548"},
        {"Hipparcos Number", "HIP 106517"},
        {"Geneva Identification System", "GEN# +1.00235548"},
        {"Smithsonian Astrophysical Observation", "SAO 33539"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.61000634),
        dec: Angle.Degrees(+52.26930096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50812"},
        {"Hipparcos Number", "HIP 33486"},
        {"Geneva Identification System", "GEN# +1.00050812"},
        {"Smithsonian Astrophysical Observation", "SAO 26065"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.40914179),
        dec: Angle.Degrees(+52.27008205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66773"},
        {"Hipparcos Number", "HIP 39760"},
        {"Geneva Identification System", "GEN# +1.00066773"},
        {"Smithsonian Astrophysical Observation", "SAO 26679"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.89286842),
        dec: Angle.Degrees(+52.27030275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89020"},
        {"Hipparcos Number", "HIP 50405"},
        {"Geneva Identification System", "GEN# +1.00089020"},
        {"Smithsonian Astrophysical Observation", "SAO 27592"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.38367406),
        dec: Angle.Degrees(+52.27041704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103738"},
        {"Hipparcos Number", "HIP 58258"},
        {"Geneva Identification System", "GEN# +1.00103738"},
        {"Smithsonian Astrophysical Observation", "SAO 28198"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.22120427),
        dec: Angle.Degrees(+52.27179457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234771"},
        {"Hipparcos Number", "HIP 93333"},
        {"Smithsonian Astrophysical Observation", "SAO 31317"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.14454294),
        dec: Angle.Degrees(+52.27248444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34796",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34796"},
    },
    visualMagnitude: 11.25,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.04794249),
        dec: Angle.Degrees(+52.27411738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -261.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4535"},
        {"Hipparcos Number", "HIP 3742"},
        {"Smithsonian Astrophysical Observation", "SAO 21718"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.00841193),
        dec: Angle.Degrees(+52.27529045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191806"},
        {"Hipparcos Number", "HIP 99306"},
        {"Smithsonian Astrophysical Observation", "SAO 32320"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.36750418),
        dec: Angle.Degrees(+52.27611210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115269"},
        {"Hipparcos Number", "HIP 64668"},
        {"Geneva Identification System", "GEN# +1.00115269"},
        {"Smithsonian Astrophysical Observation", "SAO 28691"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.82969671),
        dec: Angle.Degrees(+52.27811308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4996"},
        {"Hipparcos Number", "HIP 4112"},
        {"Smithsonian Astrophysical Observation", "SAO 21794"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.18175758),
        dec: Angle.Degrees(+52.27833526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57262"},
        {"Hipparcos Number", "HIP 35824"},
        {"Geneva Identification System", "GEN# +1.00057262"},
        {"Smithsonian Astrophysical Observation", "SAO 26317"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.81721801),
        dec: Angle.Degrees(+52.27913085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235924"},
        {"Hipparcos Number", "HIP 111929"},
        {"Smithsonian Astrophysical Observation", "SAO 34683"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.08336401),
        dec: Angle.Degrees(+52.28064214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95639"},
        {"Hipparcos Number", "HIP 54016"},
        {"Geneva Identification System", "GEN# +1.00095639"},
        {"Smithsonian Astrophysical Observation", "SAO 27883"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.75501123),
        dec: Angle.Degrees(+52.28122805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188342"},
        {"Hipparcos Number", "HIP 97777"},
        {"Smithsonian Astrophysical Observation", "SAO 32068"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.03360941),
        dec: Angle.Degrees(+52.28125193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232603"},
        {"Hipparcos Number", "HIP 9984"},
        {"Smithsonian Astrophysical Observation", "SAO 22960"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.14641773),
        dec: Angle.Degrees(+52.28193034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41302",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41302"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.40584956),
        dec: Angle.Degrees(+52.28226550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17521"},
        {"Hipparcos Number", "HIP 13250"},
        {"Smithsonian Astrophysical Observation", "SAO 23654"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.63816031),
        dec: Angle.Degrees(+52.28304160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222029"},
        {"Hipparcos Number", "HIP 116524"},
        {"Smithsonian Astrophysical Observation", "SAO 35597"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.23262147),
        dec: Angle.Degrees(+52.28497199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134224"},
        {"Hipparcos Number", "HIP 73944"},
        {"Geneva Identification System", "GEN# +1.00134224"},
        {"Smithsonian Astrophysical Observation", "SAO 29408"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.65425638),
        dec: Angle.Degrees(+52.28558325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236181"},
        {"Hipparcos Number", "HIP 116530"},
        {"Smithsonian Astrophysical Observation", "SAO 35598"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.24994503),
        dec: Angle.Degrees(+52.28589917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77172"},
        {"Hipparcos Number", "HIP 44416"},
        {"Smithsonian Astrophysical Observation", "SAO 27095"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.71612374),
        dec: Angle.Degrees(+52.28616196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136674"},
        {"Hipparcos Number", "HIP 75024"},
        {"Smithsonian Astrophysical Observation", "SAO 29484"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.95409632),
        dec: Angle.Degrees(+52.28732249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21863"},
        {"Hipparcos Number", "HIP 16612"},
        {"Geneva Identification System", "GEN# +1.00021863"},
        {"Smithsonian Astrophysical Observation", "SAO 24104"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.44824099),
        dec: Angle.Degrees(+52.28829451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190963"},
        {"Hipparcos Number", "HIP 98902"},
        {"Smithsonian Astrophysical Observation", "SAO 32271"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.25957408),
        dec: Angle.Degrees(+52.28912467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148281"},
        {"Hipparcos Number", "HIP 80379"},
        {"Geneva Identification System", "GEN# +1.00148281"},
        {"Smithsonian Astrophysical Observation", "SAO 29929"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.11002078),
        dec: Angle.Degrees(+52.28936618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221863"},
        {"Hipparcos Number", "HIP 116418"},
        {"Smithsonian Astrophysical Observation", "SAO 35571"},
        {"Wilson Evans Batten Catalogue", "WEB 20567"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.86287415),
        dec: Angle.Degrees(+52.29098450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206671"},
        {"Hipparcos Number", "HIP 107138"},
        {"Geneva Identification System", "GEN# +1.00206671"},
        {"Smithsonian Astrophysical Observation", "SAO 33667"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.52349080),
        dec: Angle.Degrees(+52.29206291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195664"},
        {"Hipparcos Number", "HIP 101174"},
        {"Smithsonian Astrophysical Observation", "SAO 32637"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.61167641),
        dec: Angle.Degrees(+52.29387022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31752",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5257 AB"},
        {"Henry Draper", "HD 46862"},
        {"Hipparcos Number", "HIP 31752"},
        {"Smithsonian Astrophysical Observation", "SAO 25854"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.63419970),
        dec: Angle.Degrees(+52.29468723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197666"},
        {"Hipparcos Number", "HIP 102240"},
        {"Geneva Identification System", "GEN# +1.00197666"},
        {"Smithsonian Astrophysical Observation", "SAO 32824"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.75845073),
        dec: Angle.Degrees(+52.29509667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 163.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72907",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9434 AB"},
        {"Henry Draper", "HD 131860"},
        {"Hipparcos Number", "HIP 72907"},
        {"Smithsonian Astrophysical Observation", "SAO 29329"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.52022462),
        dec: Angle.Degrees(+52.29616200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32988"},
        {"Hipparcos Number", "HIP 24028"},
        {"Smithsonian Astrophysical Observation", "SAO 25055"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.47611401),
        dec: Angle.Degrees(+52.29823118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203764"},
        {"Hipparcos Number", "HIP 105531"},
        {"Geneva Identification System", "GEN# +1.00203764"},
        {"Smithsonian Astrophysical Observation", "SAO 33363"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.60827973),
        dec: Angle.Degrees(+52.29831331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22845"},
        {"Hipparcos Number", "HIP 17334"},
        {"Smithsonian Astrophysical Observation", "SAO 24172"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.65259005),
        dec: Angle.Degrees(+52.29892957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234817"},
        {"Hipparcos Number", "HIP 94106"},
        {"Smithsonian Astrophysical Observation", "SAO 31427"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.34915733),
        dec: Angle.Degrees(+52.29918678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235060"},
        {"Hipparcos Number", "HIP 98358"},
        {"Smithsonian Astrophysical Observation", "SAO 32166"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.75157346),
        dec: Angle.Degrees(+52.29964390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185580"},
        {"Hipparcos Number", "HIP 96511"},
        {"Geneva Identification System", "GEN# +1.00185580"},
        {"Smithsonian Astrophysical Observation", "SAO 31827"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.30316485),
        dec: Angle.Degrees(+52.29973618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76429"},
        {"Hipparcos Number", "HIP 44054"},
        {"Smithsonian Astrophysical Observation", "SAO 27063"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.57570108),
        dec: Angle.Degrees(+52.30009351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85670",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Rastaban"},
        {"Aitken", "ADS 10611 A"},
        {"Henry Draper", "HD 159181"},
        {"Hipparcos Number", "HIP 85670"},
        {"Fundamental Katalog 5th Edition", "FK5 653"},
        {"Geneva Identification System", "GEN# +1.00159181J"},
        {"Smithsonian Astrophysical Observation", "SAO 30429"},
        {"Wilson Evans Batten Catalogue", "WEB 14455"},
    },
    visualMagnitude: 2.79,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.60823708),
        dec: Angle.Degrees(+52.30135901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72916",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9434 C"},
        {"Hipparcos Number", "HIP 72916"},
    },
    visualMagnitude: 11.54,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.53016190),
        dec: Angle.Degrees(+52.30208305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234308"},
        {"Hipparcos Number", "HIP 80508"},
        {"Smithsonian Astrophysical Observation", "SAO 29942"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.52309864),
        dec: Angle.Degrees(+52.30226823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156223"},
        {"Hipparcos Number", "HIP 84273"},
        {"Geneva Identification System", "GEN# +1.00156223"},
        {"Smithsonian Astrophysical Observation", "SAO 30301"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.41035064),
        dec: Angle.Degrees(+52.30251548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217315"},
        {"Hipparcos Number", "HIP 113505"},
        {"Smithsonian Astrophysical Observation", "SAO 35023"},
    },
    visualMagnitude: 6.98,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.80352574),
        dec: Angle.Degrees(+52.30300453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236085"},
        {"Hipparcos Number", "HIP 115007"},
        {"Smithsonian Astrophysical Observation", "SAO 35299"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.39476374),
        dec: Angle.Degrees(+52.30327307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232199"},
        {"Hipparcos Number", "HIP 2325"},
        {"Smithsonian Astrophysical Observation", "SAO 21439"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.41634919),
        dec: Angle.Degrees(+52.30463542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235502"},
        {"Hipparcos Number", "HIP 105535"},
        {"Geneva Identification System", "GEN# +1.00235502"},
        {"Smithsonian Astrophysical Observation", "SAO 33364"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.61699090),
        dec: Angle.Degrees(+52.30467071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234727"},
        {"Hipparcos Number", "HIP 92514"},
        {"Geneva Identification System", "GEN# +1.00234727"},
        {"Smithsonian Astrophysical Observation", "SAO 31205"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.80350994),
        dec: Angle.Degrees(+52.30557816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28336"},
        {"Hipparcos Number", "HIP 21044"},
        {"Smithsonian Astrophysical Observation", "SAO 24659"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.67164962),
        dec: Angle.Degrees(+52.30626141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232668"},
        {"Hipparcos Number", "HIP 11764"},
        {"Smithsonian Astrophysical Observation", "SAO 23404"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.95146857),
        dec: Angle.Degrees(+52.30679802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11889",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1938 AB"},
        {"Henry Draper", "HD 15703"},
        {"Hipparcos Number", "HIP 11889"},
        {"Smithsonian Astrophysical Observation", "SAO 23425"},
        {"Wilson Evans Batten Catalogue", "WEB 2458"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.32875682),
        dec: Angle.Degrees(+52.30897804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235012"},
        {"Hipparcos Number", "HIP 97490"},
        {"Smithsonian Astrophysical Observation", "SAO 32020"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.22911398),
        dec: Angle.Degrees(+52.30904823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195820"},
        {"Hipparcos Number", "HIP 101245"},
        {"Geneva Identification System", "GEN# +1.00195820"},
        {"Smithsonian Astrophysical Observation", "SAO 32649"},
        {"Wilson Evans Batten Catalogue", "WEB 18291"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.83796767),
        dec: Angle.Degrees(+52.30937218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233440"},
        {"Hipparcos Number", "HIP 37550"},
        {"Geneva Identification System", "GEN# +1.00233440"},
        {"Smithsonian Astrophysical Observation", "SAO 26472"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.60234582),
        dec: Angle.Degrees(+52.30947801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153818"},
        {"Hipparcos Number", "HIP 83106"},
        {"Smithsonian Astrophysical Observation", "SAO 30185"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.74054149),
        dec: Angle.Degrees(+52.30987328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210761"},
        {"Hipparcos Number", "HIP 109533"},
        {"Smithsonian Astrophysical Observation", "SAO 34145"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.81267908),
        dec: Angle.Degrees(+52.31232516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232864"},
        {"Hipparcos Number", "HIP 18653"},
        {"Geneva Identification System", "GEN# +1.00232864"},
        {"Smithsonian Astrophysical Observation", "SAO 24331"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.89352013),
        dec: Angle.Degrees(+52.31262127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167348"},
        {"Hipparcos Number", "HIP 89175"},
        {"Geneva Identification System", "GEN# +1.00167348"},
        {"Smithsonian Astrophysical Observation", "SAO 30803"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.98151520),
        dec: Angle.Degrees(+52.31632129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234242"},
        {"Hipparcos Number", "HIP 76110"},
        {"Geneva Identification System", "GEN# +1.00234242"},
        {"Smithsonian Astrophysical Observation", "SAO 29565"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.16676606),
        dec: Angle.Degrees(+52.31658131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 595"},
        {"Hipparcos Number", "HIP 859"},
        {"Geneva Identification System", "GEN# +1.00000595"},
        {"Smithsonian Astrophysical Observation", "SAO 21165"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.64265068),
        dec: Angle.Degrees(+52.31675606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13622"},
        {"Hipparcos Number", "HIP 10434"},
        {"Smithsonian Astrophysical Observation", "SAO 23064"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.61230477),
        dec: Angle.Degrees(+52.31733953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234395"},
        {"Hipparcos Number", "HIP 83829"},
        {"Smithsonian Astrophysical Observation", "SAO 30259"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.99612841),
        dec: Angle.Degrees(+52.31774658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145048"},
        {"Hipparcos Number", "HIP 78894"},
        {"Geneva Identification System", "GEN# +1.00145048"},
        {"Smithsonian Astrophysical Observation", "SAO 29798"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.58279981),
        dec: Angle.Degrees(+52.31836840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233762"},
        {"Hipparcos Number", "HIP 52439"},
        {"Smithsonian Astrophysical Observation", "SAO 27747"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.79496786),
        dec: Angle.Degrees(+52.31876158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120701"},
        {"Hipparcos Number", "HIP 67491"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.45386394),
        dec: Angle.Degrees(+52.32002047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183534"},
        {"Hipparcos Number", "HIP 95656"},
        {"Celescope Catalog", "CEL 4767"},
        {"Geneva Identification System", "GEN# +1.00183534"},
        {"Smithsonian Astrophysical Observation", "SAO 31673"},
        {"Wilson Evans Batten Catalogue", "WEB 16731"},
    },
    visualMagnitude: 5.73,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.85821062),
        dec: Angle.Degrees(+52.32050263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17227"},
        {"Hipparcos Number", "HIP 13058"},
        {"Smithsonian Astrophysical Observation", "SAO 23615"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.95412615),
        dec: Angle.Degrees(+52.32151794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121297"},
        {"Hipparcos Number", "HIP 67799"},
        {"Geneva Identification System", "GEN# +1.00121297"},
        {"Smithsonian Astrophysical Observation", "SAO 28922"},
        {"Wilson Evans Batten Catalogue", "WEB 11920"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.33419207),
        dec: Angle.Degrees(+52.32299113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59183",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59183"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.05746955),
        dec: Angle.Degrees(+52.32352471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105273",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14865 A"},
        {"Henry Draper", "HD 203283"},
        {"Hipparcos Number", "HIP 105273"},
        {"Geneva Identification System", "GEN# +1.00203283"},
        {"Smithsonian Astrophysical Observation", "SAO 33315"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.85196842),
        dec: Angle.Degrees(+52.32440008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105280",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14865 C"},
        {"Hipparcos Number", "HIP 105280"},
    },
    visualMagnitude: 10.27,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.86551466),
        dec: Angle.Degrees(+52.32477969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83300"},
        {"Hipparcos Number", "HIP 47376"},
        {"Geneva Identification System", "GEN# +1.00083300"},
        {"Smithsonian Astrophysical Observation", "SAO 27327"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.78725912),
        dec: Angle.Degrees(+52.32619428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96126"},
        {"Hipparcos Number", "HIP 54250"},
        {"Geneva Identification System", "GEN# +1.00096126"},
        {"Smithsonian Astrophysical Observation", "SAO 27901"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.47107245),
        dec: Angle.Degrees(+52.32672858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120434"},
        {"Hipparcos Number", "HIP 67343"},
        {"Smithsonian Astrophysical Observation", "SAO 28892"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.04158501),
        dec: Angle.Degrees(+52.32729541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11746"},
        {"Hipparcos Number", "HIP 9055"},
        {"Smithsonian Astrophysical Observation", "SAO 22773"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.15677951),
        dec: Angle.Degrees(+52.33124342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208326"},
        {"Hipparcos Number", "HIP 108104"},
        {"Smithsonian Astrophysical Observation", "SAO 33850"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.54681376),
        dec: Angle.Degrees(+52.33213163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232781"},
        {"Hipparcos Number", "HIP 15673"},
        {"Cincinnati Publication", "Ci 18 445"},
        {"Cincinnati Publication 2", "Ci 20 225"},
        {"Smithsonian Astrophysical Observation", "SAO 23980"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.47938525),
        dec: Angle.Degrees(+52.33216557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -310.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -267.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3008"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.56400804),
        dec: Angle.Degrees(+52.33242473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19205"},
        {"Hipparcos Number", "HIP 14516"},
        {"Geneva Identification System", "GEN# +1.00019205"},
        {"Smithsonian Astrophysical Observation", "SAO 23819"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.87132810),
        dec: Angle.Degrees(+52.33276359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22602"},
        {"Hipparcos Number", "HIP 17162"},
        {"Smithsonian Astrophysical Observation", "SAO 24152"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.13825383),
        dec: Angle.Degrees(+52.33413518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 373"},
        {"Hipparcos Number", "HIP 691"},
        {"Geneva Identification System", "GEN# +1.00000373"},
        {"Smithsonian Astrophysical Observation", "SAO 21125"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.12551099),
        dec: Angle.Degrees(+52.33640337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3950"},
        {"Hipparcos Number", "HIP 3346"},
        {"Geneva Identification System", "GEN# +1.00003950"},
        {"Smithsonian Astrophysical Observation", "SAO 21646"},
        {"Wilson Evans Batten Catalogue", "WEB 592"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.65830916),
        dec: Angle.Degrees(+52.33716162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157009"},
        {"Hipparcos Number", "HIP 84629"},
        {"Smithsonian Astrophysical Observation", "SAO 30330"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.50771605),
        dec: Angle.Degrees(+52.33728567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56658",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56658"},
    },
    visualMagnitude: 10.37,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.25659990),
        dec: Angle.Degrees(+52.33772385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -205.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29846"},
        {"Hipparcos Number", "HIP 22075"},
        {"Smithsonian Astrophysical Observation", "SAO 24798"},
        {"Wilson Evans Batten Catalogue", "WEB 4245"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.22947413),
        dec: Angle.Degrees(+52.33968357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39411"},
        {"Hipparcos Number", "HIP 28003"},
        {"Geneva Identification System", "GEN# +1.00039411"},
        {"Smithsonian Astrophysical Observation", "SAO 25451"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.85783530),
        dec: Angle.Degrees(+52.34002200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68745"},
        {"Hipparcos Number", "HIP 40508"},
        {"Smithsonian Astrophysical Observation", "SAO 26747"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.06050150),
        dec: Angle.Degrees(+52.34229495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40142"},
        {"Hipparcos Number", "HIP 28406"},
        {"Geneva Identification System", "GEN# +1.00040142"},
        {"Renson", "Renson 10700"},
        {"Smithsonian Astrophysical Observation", "SAO 25510"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.99332491),
        dec: Angle.Degrees(+52.34343060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91436",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11558 AB"},
        {"Hipparcos Number", "HIP 91436"},
        {"Smithsonian Astrophysical Observation", "SAO 31086"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.71362345),
        dec: Angle.Degrees(+52.34394691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232413"},
        {"Hipparcos Number", "HIP 6035"},
        {"Smithsonian Astrophysical Observation", "SAO 22157"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.38044651),
        dec: Angle.Degrees(+52.34436748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137000"},
        {"Hipparcos Number", "HIP 75147"},
        {"Geneva Identification System", "GEN# +1.00137000"},
        {"Smithsonian Astrophysical Observation", "SAO 29494"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.36227776),
        dec: Angle.Degrees(+52.34444128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10637"},
        {"Hipparcos Number", "HIP 8170"},
        {"Smithsonian Astrophysical Observation", "SAO 22588"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.26198766),
        dec: Angle.Degrees(+52.34710280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232278"},
        {"Hipparcos Number", "HIP 3748"},
        {"Smithsonian Astrophysical Observation", "SAO 21720"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.02670321),
        dec: Angle.Degrees(+52.34811823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233865"},
        {"Hipparcos Number", "HIP 57413"},
        {"Smithsonian Astrophysical Observation", "SAO 28132"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.55983834),
        dec: Angle.Degrees(+52.34887601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61605",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61605"},
    },
    visualMagnitude: 10.39,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.36227558),
        dec: Angle.Degrees(+52.34919319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15087",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15087"},
        {"Cincinnati Publication", "Ci 20 213"},
        {"Wilson Evans Batten Catalogue", "WEB 2908"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.64259230),
        dec: Angle.Degrees(+52.34925423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -265.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -405.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232789"},
        {"Hipparcos Number", "HIP 15982"},
        {"Smithsonian Astrophysical Observation", "SAO 24025"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.45046941),
        dec: Angle.Degrees(+52.34931034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14043",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2270 A"},
        {"Henry Draper", "HD 18537"},
        {"Hipparcos Number", "HIP 14043"},
        {"Celescope Catalog", "CEL 299"},
        {"Geneva Identification System", "GEN# +1.00018537"},
        {"Smithsonian Astrophysical Observation", "SAO 23763"},
        {"Wilson Evans Batten Catalogue", "WEB 2768"},
    },
    visualMagnitude: 5.24,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.21743352),
        dec: Angle.Degrees(+52.35179769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219428"},
        {"Hipparcos Number", "HIP 114796"},
        {"Geneva Identification System", "GEN# +1.00219428"},
        {"Smithsonian Astrophysical Observation", "SAO 35265"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.80502784),
        dec: Angle.Degrees(+52.35189199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14047",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2270 B"},
        {"Henry Draper", "HD 18538"},
        {"Hipparcos Number", "HIP 14047"},
        {"Geneva Identification System", "GEN# +1.00018538"},
        {"Smithsonian Astrophysical Observation", "SAO 23765"},
        {"Wilson Evans Batten Catalogue", "WEB 2769"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.22288026),
        dec: Angle.Degrees(+52.35208662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61287",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61287"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.38272707),
        dec: Angle.Degrees(+52.35218999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234384"},
        {"Hipparcos Number", "HIP 83616"},
        {"Smithsonian Astrophysical Observation", "SAO 30238"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.34637705),
        dec: Angle.Degrees(+52.35334446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91013",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11468 AB"},
        {"Henry Draper", "HD 171779"},
        {"Hipparcos Number", "HIP 91013"},
        {"Geneva Identification System", "GEN# +1.00171779J"},
        {"Smithsonian Astrophysical Observation", "SAO 31051"},
        {"Wilson Evans Batten Catalogue", "WEB 15617"},
    },
    visualMagnitude: 5.38,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.48624439),
        dec: Angle.Degrees(+52.35350951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8705",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1478 AB"},
        {"Henry Draper", "HD 11267"},
        {"Hipparcos Number", "HIP 8705"},
        {"Celescope Catalog", "CEL 175"},
        {"Smithsonian Astrophysical Observation", "SAO 22693"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.99891488),
        dec: Angle.Degrees(+52.35895130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235333"},
        {"Hipparcos Number", "HIP 102248"},
        {"Geneva Identification System", "GEN# +1.00235333"},
        {"Smithsonian Astrophysical Observation", "SAO 32825"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.77396464),
        dec: Angle.Degrees(+52.36079121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140728"},
        {"Hipparcos Number", "HIP 76957"},
        {"Fundamental Katalog 5th Edition", "FK5 3247"},
        {"Geneva Identification System", "GEN# +1.00140728"},
        {"Renson", "Renson 39990"},
        {"Smithsonian Astrophysical Observation", "SAO 29628"},
        {"Wilson Evans Batten Catalogue", "WEB 13054"},
    },
    visualMagnitude: 5.48,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.71176316),
        dec: Angle.Degrees(+52.36083046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206259"},
        {"Hipparcos Number", "HIP 106926"},
        {"Celescope Catalog", "CEL 5360"},
        {"Geneva Identification System", "GEN# +1.00206259"},
        {"Smithsonian Astrophysical Observation", "SAO 33631"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.82304043),
        dec: Angle.Degrees(+52.36248531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234244"},
        {"Hipparcos Number", "HIP 76125"},
        {"Smithsonian Astrophysical Observation", "SAO 29566"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.22607380),
        dec: Angle.Degrees(+52.36298838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -179.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 234.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58313"},
        {"Hipparcos Number", "HIP 36248"},
        {"Geneva Identification System", "GEN# +1.00058313"},
        {"Smithsonian Astrophysical Observation", "SAO 26351"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.95951950),
        dec: Angle.Degrees(+52.36721102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233081"},
        {"Hipparcos Number", "HIP 23913"},
        {"Geneva Identification System", "GEN# +1.00233081"},
        {"Smithsonian Astrophysical Observation", "SAO 25039"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.06759795),
        dec: Angle.Degrees(+52.36758477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111762",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16135 BC"},
        {"Hipparcos Number", "HIP 111762"},
        {"Smithsonian Astrophysical Observation", "SAO 34645"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.59242274),
        dec: Angle.Degrees(+52.36827569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235626"},
        {"Hipparcos Number", "HIP 107633"},
        {"Smithsonian Astrophysical Observation", "SAO 33766"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.01831536),
        dec: Angle.Degrees(+52.36870803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110929"},
        {"Hipparcos Number", "HIP 62214"},
        {"Smithsonian Astrophysical Observation", "SAO 28503"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.26519532),
        dec: Angle.Degrees(+52.36931053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87243"},
        {"Hipparcos Number", "HIP 49408"},
        {"Geneva Identification System", "GEN# +1.00087243"},
        {"Smithsonian Astrophysical Observation", "SAO 27512"},
        {"Wilson Evans Batten Catalogue", "WEB 9129"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.29331383),
        dec: Angle.Degrees(+52.37131399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232931"},
        {"Hipparcos Number", "HIP 20028"},
        {"Geneva Identification System", "GEN# +1.00232931"},
        {"Smithsonian Astrophysical Observation", "SAO 24525"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.43702719),
        dec: Angle.Degrees(+52.37269845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147094"},
        {"Hipparcos Number", "HIP 79807"},
        {"Geneva Identification System", "GEN# +1.00147094"},
        {"Smithsonian Astrophysical Observation", "SAO 29868"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.31672375),
        dec: Angle.Degrees(+52.37488189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14674"},
        {"Hipparcos Number", "HIP 11169"},
        {"Smithsonian Astrophysical Observation", "SAO 23284"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.94130023),
        dec: Angle.Degrees(+52.37606432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111756",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16135 A"},
        {"Henry Draper", "HD 214586"},
        {"Hipparcos Number", "HIP 111756"},
        {"Celescope Catalog", "CEL 5503"},
        {"Geneva Identification System", "GEN# +1.00214586"},
        {"Smithsonian Astrophysical Observation", "SAO 34644"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.58917919),
        dec: Angle.Degrees(+52.37609039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95156",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12366 AB"},
        {"Henry Draper", "HD 182353"},
        {"Hipparcos Number", "HIP 95156"},
        {"Smithsonian Astrophysical Observation", "SAO 31603"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.40038644),
        dec: Angle.Degrees(+52.37634788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94398"},
        {"Hipparcos Number", "HIP 53351"},
        {"Geneva Identification System", "GEN# +1.00094398"},
        {"Smithsonian Astrophysical Observation", "SAO 27824"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.66882431),
        dec: Angle.Degrees(+52.37689882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196939"},
        {"Hipparcos Number", "HIP 101851"},
        {"Geneva Identification System", "GEN# +1.00196939"},
        {"Smithsonian Astrophysical Observation", "SAO 32754"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.58741376),
        dec: Angle.Degrees(+52.37849076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112014"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.34109816),
        dec: Angle.Degrees(+52.37893873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112663"},
        {"Hipparcos Number", "HIP 63255"},
        {"Geneva Identification System", "GEN# +1.00112663"},
        {"Smithsonian Astrophysical Observation", "SAO 28579"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.42869453),
        dec: Angle.Degrees(+52.38065213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86760"},
        {"Hipparcos Number", "HIP 49167"},
        {"Geneva Identification System", "GEN# +1.00086760"},
        {"Smithsonian Astrophysical Observation", "SAO 27481"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.50679385),
        dec: Angle.Degrees(+52.38159538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45029",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7212 A"},
        {"Henry Draper", "HD 78449"},
        {"Henry Draper 2", "HD 78449A"},
        {"Hipparcos Number", "HIP 45029"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.57585577),
        dec: Angle.Degrees(+52.38492505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192034"},
        {"Hipparcos Number", "HIP 99403"},
        {"Geneva Identification System", "GEN# +1.00192034"},
        {"Smithsonian Astrophysical Observation", "SAO 32334"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.63686224),
        dec: Angle.Degrees(+52.38501266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163467"},
        {"Hipparcos Number", "HIP 87576"},
        {"Fundamental Katalog 5th Edition", "FK5 5571"},
        {"Geneva Identification System", "GEN# +1.00163467"},
        {"Smithsonian Astrophysical Observation", "SAO 30627"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.36457013),
        dec: Angle.Degrees(+52.38546219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43522"},
        {"Hipparcos Number", "HIP 30061"},
        {"Geneva Identification System", "GEN# +1.00043522"},
        {"Smithsonian Astrophysical Observation", "SAO 25669"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.90720561),
        dec: Angle.Degrees(+52.38795292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232435"},
        {"Hipparcos Number", "HIP 6697"},
        {"Smithsonian Astrophysical Observation", "SAO 22273"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.50854264),
        dec: Angle.Degrees(+52.38876414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232506"},
        {"Hipparcos Number", "HIP 7970"},
        {"Celescope Catalog", "CEL 157"},
        {"Geneva Identification System", "GEN# +1.00232506"},
        {"Smithsonian Astrophysical Observation", "SAO 22530"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.60192288),
        dec: Angle.Degrees(+52.38900952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28134"},
        {"Hipparcos Number", "HIP 20908"},
        {"Smithsonian Astrophysical Observation", "SAO 24641"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.21951193),
        dec: Angle.Degrees(+52.38941264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234963"},
        {"Hipparcos Number", "HIP 96776"},
        {"Geneva Identification System", "GEN# +1.00234963"},
        {"Smithsonian Astrophysical Observation", "SAO 31879"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.06661149),
        dec: Angle.Degrees(+52.38958854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213338"},
        {"Hipparcos Number", "HIP 111029"},
        {"Smithsonian Astrophysical Observation", "SAO 34517"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.39408497),
        dec: Angle.Degrees(+52.39013845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 166.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75616"},
        {"Hipparcos Number", "HIP 43625"},
        {"Fundamental Katalog 5th Edition", "FK5 2702"},
        {"Geneva Identification System", "GEN# +1.00075616"},
        {"Smithsonian Astrophysical Observation", "SAO 27028"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.27553896),
        dec: Angle.Degrees(+52.39014622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34159"},
        {"Hipparcos Number", "HIP 24719"},
        {"Geneva Identification System", "GEN# +1.00034159"},
        {"Smithsonian Astrophysical Observation", "SAO 25119"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.52440372),
        dec: Angle.Degrees(+52.39131024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44891"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.19679117),
        dec: Angle.Degrees(+52.39469589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236172"},
        {"Hipparcos Number", "HIP 116405"},
        {"Smithsonian Astrophysical Observation", "SAO 35569"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.82655189),
        dec: Angle.Degrees(+52.39495376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101871"},
        {"Hipparcos Number", "HIP 57203"},
        {"Geneva Identification System", "GEN# +1.00101871"},
        {"Smithsonian Astrophysical Observation", "SAO 28113"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.94863090),
        dec: Angle.Degrees(+52.39510605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198833"},
        {"Hipparcos Number", "HIP 102920"},
        {"Geneva Identification System", "GEN# +1.00198833"},
        {"Smithsonian Astrophysical Observation", "SAO 32934"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.76717220),
        dec: Angle.Degrees(+52.39571379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193181"},
        {"Hipparcos Number", "HIP 99934"},
        {"Smithsonian Astrophysical Observation", "SAO 32423"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.14634116),
        dec: Angle.Degrees(+52.39731711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55142"},
    },
    visualMagnitude: 10.49,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.33008032),
        dec: Angle.Degrees(+52.39815743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30503"},
        {"Hipparcos Number", "HIP 22544"},
        {"Geneva Identification System", "GEN# +1.00030503"},
        {"Smithsonian Astrophysical Observation", "SAO 24869"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.78259245),
        dec: Angle.Degrees(+52.39859678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104032",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14615 AB"},
        {"Henry Draper", "HD 200943"},
        {"Hipparcos Number", "HIP 104032"},
        {"Celescope Catalog", "CEL 5242"},
        {"Geneva Identification System", "GEN# +1.00200943J"},
        {"Smithsonian Astrophysical Observation", "SAO 33110"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.14471992),
        dec: Angle.Degrees(+52.39977657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57645"},
        {"Hipparcos Number", "HIP 35977"},
        {"Smithsonian Astrophysical Observation", "SAO 26332"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.21432721),
        dec: Angle.Degrees(+52.39990413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234126"},
        {"Hipparcos Number", "HIP 70009"},
        {"Smithsonian Astrophysical Observation", "SAO 29102"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.87440349),
        dec: Angle.Degrees(+52.40167131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234200"},
        {"Hipparcos Number", "HIP 73463"},
        {"Geneva Identification System", "GEN# +1.00234200"},
        {"Smithsonian Astrophysical Observation", "SAO 29381"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.21432487),
        dec: Angle.Degrees(+52.40184792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234892"},
        {"Hipparcos Number", "HIP 95506"},
        {"Geneva Identification System", "GEN# +1.00234892"},
        {"Smithsonian Astrophysical Observation", "SAO 31647"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.38013203),
        dec: Angle.Degrees(+52.40242361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234267"},
        {"Hipparcos Number", "HIP 77936"},
        {"Smithsonian Astrophysical Observation", "SAO 29712"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.74489156),
        dec: Angle.Degrees(+52.40364412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102642",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14322 A"},
        {"Henry Draper", "HD 198387"},
        {"Hipparcos Number", "HIP 102642"},
        {"Geneva Identification System", "GEN# +1.00198387J"},
        {"Smithsonian Astrophysical Observation", "SAO 32897"},
        {"Wilson Evans Batten Catalogue", "WEB 18604"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.97038810),
        dec: Angle.Degrees(+52.40757941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65180"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.36884084),
        dec: Angle.Degrees(+52.40803943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206857"},
        {"Hipparcos Number", "HIP 107244"},
        {"Geneva Identification System", "GEN# +1.00206857"},
        {"Smithsonian Astrophysical Observation", "SAO 33688"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.82535379),
        dec: Angle.Degrees(+52.40839970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155711"},
        {"Hipparcos Number", "HIP 84021"},
        {"Fundamental Katalog 5th Edition", "FK5 3367"},
        {"Geneva Identification System", "GEN# +1.00155711"},
        {"Smithsonian Astrophysical Observation", "SAO 30277"},
        {"Wilson Evans Batten Catalogue", "WEB 14195"},
    },
    visualMagnitude: 6.30,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.62768928),
        dec: Angle.Degrees(+52.40879075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92866"},
        {"Hipparcos Number", "HIP 52529"},
        {"Smithsonian Astrophysical Observation", "SAO 27752"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.10411630),
        dec: Angle.Degrees(+52.40901430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210714"},
        {"Hipparcos Number", "HIP 109506"},
        {"Renson", "Renson 58568"},
        {"Smithsonian Astrophysical Observation", "SAO 34136"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.75263778),
        dec: Angle.Degrees(+52.41008954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194056"},
        {"Hipparcos Number", "HIP 100361"},
        {"Smithsonian Astrophysical Observation", "SAO 32499"},
        {"Wilson Evans Batten Catalogue", "WEB 18108"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.30884259),
        dec: Angle.Degrees(+52.41056660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116082",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16810 A"},
        {"Henry Draper", "HD 221377"},
        {"Hipparcos Number", "HIP 116082"},
        {"Geneva Identification System", "GEN# +1.00221377"},
        {"Smithsonian Astrophysical Observation", "SAO 35501"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.83178749),
        dec: Angle.Degrees(+52.41076718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134809"},
        {"Hipparcos Number", "HIP 74205"},
        {"Geneva Identification System", "GEN# +1.00134809"},
        {"Smithsonian Astrophysical Observation", "SAO 29431"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.46177316),
        dec: Angle.Degrees(+52.41091643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1384"},
        {"Hipparcos Number", "HIP 1460"},
        {"Geneva Identification System", "GEN# +1.00001384"},
        {"Smithsonian Astrophysical Observation", "SAO 21283"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.55064013),
        dec: Angle.Degrees(+52.41268626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31157"},
        {"Geneva Identification System", "GEN# +0.05201088"},
        {"Wilson Evans Batten Catalogue", "WEB 6223"},
    },
    visualMagnitude: 10.83,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)32, 18.3800),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)24, 50.200)
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
    primaryId: "HIP 72563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131194"},
        {"Hipparcos Number", "HIP 72563"},
        {"Geneva Identification System", "GEN# +1.00131194"},
        {"Smithsonian Astrophysical Observation", "SAO 29303"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.55686248),
        dec: Angle.Degrees(+52.41415946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 91.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123133"},
        {"Hipparcos Number", "HIP 68766"},
        {"Geneva Identification System", "GEN# +1.00123133"},
        {"Smithsonian Astrophysical Observation", "SAO 28997"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.11803557),
        dec: Angle.Degrees(+52.41572448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73895"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.54411541),
        dec: Angle.Degrees(+52.41583520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111058",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15993 A"},
        {"Henry Draper", "HD 213388"},
        {"Hipparcos Number", "HIP 111058"},
        {"Geneva Identification System", "GEN# +1.00213388"},
        {"Smithsonian Astrophysical Observation", "SAO 34519"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.47278057),
        dec: Angle.Degrees(+52.41655771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40036"},
        {"Hipparcos Number", "HIP 28342"},
        {"Geneva Identification System", "GEN# +1.00040036"},
        {"Smithsonian Astrophysical Observation", "SAO 25501"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.83625522),
        dec: Angle.Degrees(+52.41894824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24341"},
        {"Hipparcos Number", "HIP 18309"},
        {"Geneva Identification System", "GEN# +1.00024341"},
        {"Smithsonian Astrophysical Observation", "SAO 24291"},
        {"Wilson Evans Batten Catalogue", "WEB 3533"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.71286751),
        dec: Angle.Degrees(+52.42022712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41590"},
        {"Hipparcos Number", "HIP 29160"},
        {"Geneva Identification System", "GEN# +1.00041590"},
        {"Smithsonian Astrophysical Observation", "SAO 25590"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.26788767),
        dec: Angle.Degrees(+52.42125148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17592"},
        {"Hipparcos Number", "HIP 13319"},
        {"Geneva Identification System", "GEN# +1.00017592"},
        {"Smithsonian Astrophysical Observation", "SAO 23658"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.84893704),
        dec: Angle.Degrees(+52.42150132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119409"},
        {"Hipparcos Number", "HIP 66846"},
        {"Smithsonian Astrophysical Observation", "SAO 28855"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.49196645),
        dec: Angle.Degrees(+52.42527388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179094"},
        {"Hipparcos Number", "HIP 94013"},
        {"Geneva Identification System", "GEN# +1.00179094"},
        {"Smithsonian Astrophysical Observation", "SAO 31413"},
        {"Wilson Evans Batten Catalogue", "WEB 16364"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.10785255),
        dec: Angle.Degrees(+52.42586424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210809"},
        {"Hipparcos Number", "HIP 109562"},
        {"Celescope Catalog", "CEL 5452"},
        {"Geneva Identification System", "GEN# +1.00210809"},
        {"Smithsonian Astrophysical Observation", "SAO 34147"},
        {"Wilson Evans Batten Catalogue", "WEB 19686"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.91085398),
        dec: Angle.Degrees(+52.42999088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201835"},
        {"Hipparcos Number", "HIP 104520"},
        {"Geneva Identification System", "GEN# +1.00201835"},
        {"Smithsonian Astrophysical Observation", "SAO 33186"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.57800793),
        dec: Angle.Degrees(+52.43057215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3983"},
        {"Hipparcos Number", "HIP 3370"},
        {"Geneva Identification System", "GEN# +1.00003983"},
        {"Smithsonian Astrophysical Observation", "SAO 21649"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.71836958),
        dec: Angle.Degrees(+52.43195026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222554"},
        {"Hipparcos Number", "HIP 116873"},
        {"Geneva Identification System", "GEN# +1.00222554"},
        {"Smithsonian Astrophysical Observation", "SAO 35671"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.34386181),
        dec: Angle.Degrees(+52.43400972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232485"},
        {"Hipparcos Number", "HIP 7660"},
        {"Geneva Identification System", "GEN# +1.00232485"},
        {"Smithsonian Astrophysical Observation", "SAO 22464"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.65718563),
        dec: Angle.Degrees(+52.43469706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94881"},
        {"Hipparcos Number", "HIP 53612"},
        {"Geneva Identification System", "GEN# +1.00094881"},
        {"Smithsonian Astrophysical Observation", "SAO 27851"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.52481587),
        dec: Angle.Degrees(+52.43476113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114536"},
        {"Hipparcos Number", "HIP 64278"},
        {"Smithsonian Astrophysical Observation", "SAO 28662"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.59962936),
        dec: Angle.Degrees(+52.43519455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212791"},
        {"Hipparcos Number", "HIP 110699"},
        {"Celescope Catalog", "CEL 5475"},
        {"Geneva Identification System", "GEN# +1.00212791"},
        {"Smithsonian Astrophysical Observation", "SAO 34433"},
        {"Wilson Evans Batten Catalogue", "WEB 19833"},
    },
    visualMagnitude: 8.02,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.42395875),
        dec: Angle.Degrees(+52.43845918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107157"},
        {"Hipparcos Number", "HIP 60076"},
        {"Smithsonian Astrophysical Observation", "SAO 28336"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.77920721),
        dec: Angle.Degrees(+52.43886481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98055",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13148 A"},
        {"Henry Draper", "HD 189037"},
        {"Henry Draper 2", "HD 189037A"},
        {"Hipparcos Number", "HIP 98055"},
        {"Celescope Catalog", "CEL 4879"},
        {"Geneva Identification System", "GEN# +1.00189037"},
        {"Smithsonian Astrophysical Observation", "SAO 32114"},
        {"Wilson Evans Batten Catalogue", "WEB 17273"},
    },
    visualMagnitude: 4.91,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.90759282),
        dec: Angle.Degrees(+52.43902327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232123"},
        {"Hipparcos Number", "HIP 894"},
        {"Geneva Identification System", "GEN# +1.00232123"},
        {"Smithsonian Astrophysical Observation", "SAO 21176"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.74225810),
        dec: Angle.Degrees(+52.44279023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234213"},
        {"Hipparcos Number", "HIP 74193"},
        {"Smithsonian Astrophysical Observation", "SAO 29428"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.40893817),
        dec: Angle.Degrees(+52.44343485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218094"},
        {"Hipparcos Number", "HIP 113951"},
        {"Geneva Identification System", "GEN# +1.00218094"},
        {"Smithsonian Astrophysical Observation", "SAO 35124"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.15046981),
        dec: Angle.Degrees(+52.44369132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82442"},
        {"Hipparcos Number", "HIP 46921"},
        {"Geneva Identification System", "GEN# +1.00082442"},
        {"Smithsonian Astrophysical Observation", "SAO 27291"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.45405687),
        dec: Angle.Degrees(+52.44399845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234026"},
        {"Hipparcos Number", "HIP 64816"},
        {"Smithsonian Astrophysical Observation", "SAO 28702"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.27789682),
        dec: Angle.Degrees(+52.44531986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171313"},
        {"Hipparcos Number", "HIP 90794"},
        {"Geneva Identification System", "GEN# +1.00171313"},
        {"Smithsonian Astrophysical Observation", "SAO 31023"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.83781966),
        dec: Angle.Degrees(+52.44533037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2230"},
        {"Hipparcos Number", "HIP 2097"},
        {"Smithsonian Astrophysical Observation", "SAO 21404"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.63882609),
        dec: Angle.Degrees(+52.44620276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74089"},
        {"Hipparcos Number", "HIP 42870"},
        {"Smithsonian Astrophysical Observation", "SAO 26977"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.04202769),
        dec: Angle.Degrees(+52.44644172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234659"},
        {"Hipparcos Number", "HIP 90544"},
        {"Smithsonian Astrophysical Observation", "SAO 30996"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.13231799),
        dec: Angle.Degrees(+52.44716707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156985"},
        {"Hipparcos Number", "HIP 84616"},
        {"Smithsonian Astrophysical Observation", "SAO 30328"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.46003026),
        dec: Angle.Degrees(+52.44758821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30869",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5078 AB"},
        {"Henry Draper", "HD 45175"},
        {"Hipparcos Number", "HIP 30869"},
        {"Smithsonian Astrophysical Observation", "SAO 25752"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.21058771),
        dec: Angle.Degrees(+52.44870760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117803"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.36278553),
        dec: Angle.Degrees(+52.44890809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204037"},
        {"Hipparcos Number", "HIP 105655"},
        {"Fundamental Katalog 5th Edition", "FK5 5887"},
        {"Geneva Identification System", "GEN# +1.00204037J"},
        {"Smithsonian Astrophysical Observation", "SAO 33387"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.01194247),
        dec: Angle.Degrees(+52.44914217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80233"},
        {"Hipparcos Number", "HIP 45813"},
        {"Fundamental Katalog 5th Edition", "FK5 4830"},
        {"Geneva Identification System", "GEN# +1.00080233"},
        {"Smithsonian Astrophysical Observation", "SAO 27214"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.12270101),
        dec: Angle.Degrees(+52.45096062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234007"},
        {"Hipparcos Number", "HIP 63773"},
        {"Smithsonian Astrophysical Observation", "SAO 28623"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.07534992),
        dec: Angle.Degrees(+52.45300292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111381"},
        {"Hipparcos Number", "HIP 62476"},
        {"Geneva Identification System", "GEN# +1.00111381"},
        {"Smithsonian Astrophysical Observation", "SAO 28521"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.05576932),
        dec: Angle.Degrees(+52.45318944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14017",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14017"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.11000272),
        dec: Angle.Degrees(+52.45467329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46048"},
        {"Hipparcos Number", "HIP 31309"},
        {"Smithsonian Astrophysical Observation", "SAO 25811"},
        {"Wilson Evans Batten Catalogue", "WEB 6263"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.49007451),
        dec: Angle.Degrees(+52.46160182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6259"},
        {"Hipparcos Number", "HIP 5025"},
        {"Geneva Identification System", "GEN# +1.00006259"},
        {"Smithsonian Astrophysical Observation", "SAO 21978"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.09788511),
        dec: Angle.Degrees(+52.46297813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233035"},
        {"Hipparcos Number", "HIP 22873"},
        {"Smithsonian Astrophysical Observation", "SAO 24909"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.79884781),
        dec: Angle.Degrees(+52.46363786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225064"},
        {"Hipparcos Number", "HIP 250"},
        {"Geneva Identification System", "GEN# +1.00225064"},
        {"Smithsonian Astrophysical Observation", "SAO 21032"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.77431725),
        dec: Angle.Degrees(+52.46516859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122344"},
        {"Hipparcos Number", "HIP 68389"},
        {"Smithsonian Astrophysical Observation", "SAO 28968"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.99739932),
        dec: Angle.Degrees(+52.46532854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28752",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28752"},
    },
    visualMagnitude: 9.64,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.07538156),
        dec: Angle.Degrees(+52.46542243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232838"},
        {"Hipparcos Number", "HIP 17736"},
        {"Smithsonian Astrophysical Observation", "SAO 24225"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.97630559),
        dec: Angle.Degrees(+52.46818659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -276.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17427",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2710 AB"},
        {"Henry Draper", "HD 23006"},
        {"Hipparcos Number", "HIP 17427"},
        {"Smithsonian Astrophysical Observation", "SAO 24184"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.00222936),
        dec: Angle.Degrees(+52.46882658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10674",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1745 AB"},
        {"Henry Draper", "HD 13954"},
        {"Hipparcos Number", "HIP 10674"},
        {"Smithsonian Astrophysical Observation", "SAO 23132"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.33435819),
        dec: Angle.Degrees(+52.46929687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9235"},
        {"Hipparcos Number", "HIP 7138"},
        {"Geneva Identification System", "GEN# +1.00009235"},
        {"Smithsonian Astrophysical Observation", "SAO 22362"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.99448208),
        dec: Angle.Degrees(+52.46981399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113863"},
        {"Hipparcos Number", "HIP 63909"},
        {"Smithsonian Astrophysical Observation", "SAO 28630"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.44858825),
        dec: Angle.Degrees(+52.47341214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105749",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14965 AB"},
        {"Henry Draper", "HD 204186"},
        {"Hipparcos Number", "HIP 105749"},
        {"Smithsonian Astrophysical Observation", "SAO 33413"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.27901163),
        dec: Angle.Degrees(+52.47516148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203046"},
        {"Hipparcos Number", "HIP 105130"},
        {"Smithsonian Astrophysical Observation", "SAO 33295"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.46247368),
        dec: Angle.Degrees(+52.47594909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60707"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.62981352),
        dec: Angle.Degrees(+52.47682271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232733"},
        {"Hipparcos Number", "HIP 13785"},
        {"Cincinnati Publication", "Ci 20 194"},
        {"Smithsonian Astrophysical Observation", "SAO 23731"},
        {"Wilson Evans Batten Catalogue", "WEB 2730"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.36792795),
        dec: Angle.Degrees(+52.47761573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 393.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235630"},
        {"Hipparcos Number", "HIP 107695"},
        {"Smithsonian Astrophysical Observation", "SAO 33776"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.23447682),
        dec: Angle.Degrees(+52.47903817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162035"},
        {"Hipparcos Number", "HIP 86955"},
        {"Smithsonian Astrophysical Observation", "SAO 30559"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.53474160),
        dec: Angle.Degrees(+52.47935495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48992"},
        {"Hipparcos Number", "HIP 32690"},
        {"Geneva Identification System", "GEN# +1.00048992"},
        {"Smithsonian Astrophysical Observation", "SAO 25971"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.29424734),
        dec: Angle.Degrees(+52.48135379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202796"},
        {"Hipparcos Number", "HIP 105024"},
        {"Geneva Identification System", "GEN# +1.00202796"},
        {"Smithsonian Astrophysical Observation", "SAO 33271"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.09191408),
        dec: Angle.Degrees(+52.48158886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23800"},
        {"Hipparcos Number", "HIP 17963"},
        {"Fundamental Katalog 5th Edition", "FK5 2274"},
        {"Geneva Identification System", "GEN# +2.14440002"},
        {"Smithsonian Astrophysical Observation", "SAO 24255"},
        {"Wilson Evans Batten Catalogue", "WEB 3459"},
        {"New General Catalogue", "NGC 1444 2"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.60447535),
        dec: Angle.Degrees(+52.48190794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160270"},
        {"Hipparcos Number", "HIP 86133"},
        {"Smithsonian Astrophysical Observation", "SAO 30475"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.03838488),
        dec: Angle.Degrees(+52.48325110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234138"},
        {"Hipparcos Number", "HIP 70646"},
        {"Smithsonian Astrophysical Observation", "SAO 29149"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.74583446),
        dec: Angle.Degrees(+52.48586002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29341"},
        {"Hipparcos Number", "HIP 21737"},
        {"Smithsonian Astrophysical Observation", "SAO 24746"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.01910573),
        dec: Angle.Degrees(+52.48621289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232681"},
        {"Hipparcos Number", "HIP 12123"},
        {"Smithsonian Astrophysical Observation", "SAO 23457"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.04016371),
        dec: Angle.Degrees(+52.48745917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37693"},
        {"Hipparcos Number", "HIP 26974"},
        {"Geneva Identification System", "GEN# +1.00037693"},
        {"Smithsonian Astrophysical Observation", "SAO 25339"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.86088457),
        dec: Angle.Degrees(+52.48872616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 244.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11773"},
        {"Hipparcos Number", "HIP 9077"},
        {"Smithsonian Astrophysical Observation", "SAO 22777"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.21707548),
        dec: Angle.Degrees(+52.48943157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5372"},
        {"Hipparcos Number", "HIP 4393"},
        {"Geneva Identification System", "GEN# +1.00005372"},
        {"Smithsonian Astrophysical Observation", "SAO 21850"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.07155640),
        dec: Angle.Degrees(+52.49123259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 202.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213337"},
        {"Hipparcos Number", "HIP 111028"},
        {"Geneva Identification System", "GEN# +1.00213337"},
        {"Smithsonian Astrophysical Observation", "SAO 34516"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.38946313),
        dec: Angle.Degrees(+52.49187998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49837"},
        {"Hipparcos Number", "HIP 33069"},
        {"Geneva Identification System", "GEN# +1.00049837"},
        {"Smithsonian Astrophysical Observation", "SAO 26019"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.31120773),
        dec: Angle.Degrees(+52.49219525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31510"},
        {"Hipparcos Number", "HIP 23181"},
        {"Smithsonian Astrophysical Observation", "SAO 24942"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.82341008),
        dec: Angle.Degrees(+52.49295423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39965"},
        {"Hipparcos Number", "HIP 28303"},
        {"Geneva Identification System", "GEN# +1.00039965"},
        {"Smithsonian Astrophysical Observation", "SAO 25498"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.72252673),
        dec: Angle.Degrees(+52.49419415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232902"},
        {"Hipparcos Number", "HIP 19465"},
        {"Geneva Identification System", "GEN# +1.00232902"},
        {"Smithsonian Astrophysical Observation", "SAO 24446"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.52533431),
        dec: Angle.Degrees(+52.49615764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99879",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13616a B"},
        {"Henry Draper", "HD 193054B"},
        {"Hipparcos Number", "HIP 99879"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.96743977),
        dec: Angle.Degrees(+52.49891691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71078",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71078"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.02363546),
        dec: Angle.Degrees(+52.50102482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18200"},
        {"Hipparcos Number", "HIP 13780"},
        {"Geneva Identification System", "GEN# +1.00018200"},
        {"Smithsonian Astrophysical Observation", "SAO 23729"},
        {"Wilson Evans Batten Catalogue", "WEB 2728"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.33962605),
        dec: Angle.Degrees(+52.50117552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185114"},
        {"Hipparcos Number", "HIP 96316"},
        {"Smithsonian Astrophysical Observation", "SAO 31792"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.75513896),
        dec: Angle.Degrees(+52.50210140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99875",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13616a A"},
        {"Henry Draper", "HD 193054"},
        {"Hipparcos Number", "HIP 99875"},
        {"Smithsonian Astrophysical Observation", "SAO 32404"},
        {"Wilson Evans Batten Catalogue", "WEB 17964"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.95556181),
        dec: Angle.Degrees(+52.50228025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6211"},
        {"Hipparcos Number", "HIP 4998"},
        {"Fundamental Katalog 5th Edition", "FK5 2066"},
        {"Geneva Identification System", "GEN# +1.00006211"},
        {"Smithsonian Astrophysical Observation", "SAO 21967"},
        {"Wilson Evans Batten Catalogue", "WEB 1007"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.00995036),
        dec: Angle.Degrees(+52.50230919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234342"},
        {"Hipparcos Number", "HIP 81886"},
        {"Geneva Identification System", "GEN# +1.00234342"},
        {"Smithsonian Astrophysical Observation", "SAO 30066"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.90640434),
        dec: Angle.Degrees(+52.50298684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94084"},
        {"Hipparcos Number", "HIP 53157"},
        {"Geneva Identification System", "GEN# +1.00094084"},
        {"Smithsonian Astrophysical Observation", "SAO 27810"},
        {"Wilson Evans Batten Catalogue", "WEB 9652"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.13380917),
        dec: Angle.Degrees(+52.50373112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21265",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21265"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.44227775),
        dec: Angle.Degrees(+52.50437351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27857"},
        {"Hipparcos Number", "HIP 20722"},
        {"Geneva Identification System", "GEN# +1.00027857"},
        {"Smithsonian Astrophysical Observation", "SAO 24610"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.60882502),
        dec: Angle.Degrees(+52.50499074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111841"},
        {"Hipparcos Number", "HIP 62754"},
        {"Smithsonian Astrophysical Observation", "SAO 28540"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.89256275),
        dec: Angle.Degrees(+52.50510958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28942"},
        {"Hipparcos Number", "HIP 21441"},
        {"Geneva Identification System", "GEN# +1.00028942"},
        {"Smithsonian Astrophysical Observation", "SAO 24712"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.07187988),
        dec: Angle.Degrees(+52.50605799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235613"},
        {"Hipparcos Number", "HIP 107520"},
        {"Geneva Identification System", "GEN# +1.00235613"},
        {"Smithsonian Astrophysical Observation", "SAO 33745"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.63478177),
        dec: Angle.Degrees(+52.50665066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232780"},
        {"Hipparcos Number", "HIP 15639"},
        {"Smithsonian Astrophysical Observation", "SAO 23973"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.34074225),
        dec: Angle.Degrees(+52.50791476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233719"},
        {"Hipparcos Number", "HIP 50125"},
        {"Cincinnati Publication", "Ci 18 1225"},
        {"Cincinnati Publication 2", "Ci 20 566"},
        {"Geneva Identification System", "GEN# +1.00233719"},
        {"Smithsonian Astrophysical Observation", "SAO 27569"},
        {"Wilson Evans Batten Catalogue", "WEB 9214"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.48874770),
        dec: Angle.Degrees(+52.50857488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -761.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206184"},
        {"Hipparcos Number", "HIP 106875"},
        {"Geneva Identification System", "GEN# +1.00206184"},
        {"Smithsonian Astrophysical Observation", "SAO 33620"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.70366880),
        dec: Angle.Degrees(+52.50871228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13738"},
        {"Hipparcos Number", "HIP 10514"},
        {"Fundamental Katalog 5th Edition", "FK5 4208"},
        {"Geneva Identification System", "GEN# +1.00013738"},
        {"Smithsonian Astrophysical Observation", "SAO 23093"},
        {"Wilson Evans Batten Catalogue", "WEB 2207"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.86955069),
        dec: Angle.Degrees(+52.51112483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14277",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 9.82,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)04, 02.9100),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)30, 40.500)
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
    primaryId: "HIP 109802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211227"},
        {"Hipparcos Number", "HIP 109802"},
        {"Geneva Identification System", "GEN# +1.00211227"},
        {"Smithsonian Astrophysical Observation", "SAO 34214"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.60033385),
        dec: Angle.Degrees(+52.51353429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4430"},
        {"Hipparcos Number", "HIP 3683"},
        {"Smithsonian Astrophysical Observation", "SAO 21700"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.78698708),
        dec: Angle.Degrees(+52.51441315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75371"},
        {"Hipparcos Number", "HIP 43515"},
        {"Smithsonian Astrophysical Observation", "SAO 27018"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.94310697),
        dec: Angle.Degrees(+52.51447516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62946"},
        {"Hipparcos Number", "HIP 38149"},
        {"Geneva Identification System", "GEN# +1.00062946"},
        {"Smithsonian Astrophysical Observation", "SAO 26520"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.27309097),
        dec: Angle.Degrees(+52.51521264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2620"},
        {"Hipparcos Number", "HIP 2367"},
        {"Geneva Identification System", "GEN# +1.00002620"},
        {"Smithsonian Astrophysical Observation", "SAO 21453"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.55085983),
        dec: Angle.Degrees(+52.51604151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14275",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 9.01,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)04, 01.7000),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)30, 58.200)
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
    primaryId: "HIP 112300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215518"},
        {"Hipparcos Number", "HIP 112300"},
        {"Smithsonian Astrophysical Observation", "SAO 34757"},
        {"Wilson Evans Batten Catalogue", "WEB 20036"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.20468265),
        dec: Angle.Degrees(+52.51719217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232486"},
        {"Hipparcos Number", "HIP 7666"},
        {"Geneva Identification System", "GEN# +1.00232486"},
        {"Smithsonian Astrophysical Observation", "SAO 22467"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.67352556),
        dec: Angle.Degrees(+52.51883102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5663"},
        {"Hipparcos Number", "HIP 4600"},
        {"Smithsonian Astrophysical Observation", "SAO 21894"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.73919452),
        dec: Angle.Degrees(+52.51950688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43870"},
        {"Hipparcos Number", "HIP 30227"},
        {"Smithsonian Astrophysical Observation", "SAO 25677"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.38883572),
        dec: Angle.Degrees(+52.52053067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108227",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15460 C"},
        {"Hipparcos Number", "HIP 108227"},
    },
    visualMagnitude: 10.96,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.88042024),
        dec: Angle.Degrees(+52.52104893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100310"},
        {"Hipparcos Number", "HIP 56337"},
        {"Smithsonian Astrophysical Observation", "SAO 28053"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.23748814),
        dec: Angle.Degrees(+52.52373707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26384"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.26630462),
        dec: Angle.Degrees(+52.52392898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46571"},
        {"Hipparcos Number", "HIP 31632"},
        {"Smithsonian Astrophysical Observation", "SAO 25838"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.28867414),
        dec: Angle.Degrees(+52.52630304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108230",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15460 AB"},
        {"Henry Draper", "HD 208546"},
        {"Hipparcos Number", "HIP 108230"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.88161815),
        dec: Angle.Degrees(+52.52797012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208685"},
        {"Hipparcos Number", "HIP 108314"},
        {"Celescope Catalog", "CEL 5407"},
        {"Geneva Identification System", "GEN# +1.00208685"},
        {"Smithsonian Astrophysical Observation", "SAO 33892"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.14610109),
        dec: Angle.Degrees(+52.52900596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108222",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15460 D"},
        {"Hipparcos Number", "HIP 108222"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.86963179),
        dec: Angle.Degrees(+52.53055698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100588",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13820 AB"},
        {"Henry Draper", "HD 194523"},
        {"Hipparcos Number", "HIP 100588"},
        {"Smithsonian Astrophysical Observation", "SAO 32525"},
    },
    visualMagnitude: 8.24,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.96541669),
        dec: Angle.Degrees(+52.53123102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236159"},
        {"Hipparcos Number", "HIP 116140"},
        {"Geneva Identification System", "GEN# +1.00236159"},
        {"Smithsonian Astrophysical Observation", "SAO 35519"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.98291276),
        dec: Angle.Degrees(+52.53263114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202830"},
        {"Hipparcos Number", "HIP 105036"},
        {"Geneva Identification System", "GEN# +1.00202830"},
        {"Smithsonian Astrophysical Observation", "SAO 33274"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.13132486),
        dec: Angle.Degrees(+52.53503735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107167"},
        {"Hipparcos Number", "HIP 60079"},
        {"Smithsonian Astrophysical Observation", "SAO 28337"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.79946810),
        dec: Angle.Degrees(+52.53577044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125019"},
        {"Hipparcos Number", "HIP 69650"},
        {"Geneva Identification System", "GEN# +1.00125019"},
        {"Smithsonian Astrophysical Observation", "SAO 29059"},
        {"Wilson Evans Batten Catalogue", "WEB 12128"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.82088684),
        dec: Angle.Degrees(+52.53593188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113167"},
        {"Hipparcos Number", "HIP 63522"},
        {"Geneva Identification System", "GEN# +1.00113167"},
        {"Smithsonian Astrophysical Observation", "SAO 28602"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.24876356),
        dec: Angle.Degrees(+52.53681891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19747"},
        {"Hipparcos Number", "HIP 14962"},
        {"Geneva Identification System", "GEN# +1.00019747"},
        {"Smithsonian Astrophysical Observation", "SAO 23880"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.21488407),
        dec: Angle.Degrees(+52.53707891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233165"},
        {"Hipparcos Number", "HIP 27429"},
        {"Smithsonian Astrophysical Observation", "SAO 25385"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.12380161),
        dec: Angle.Degrees(+52.54413960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35033",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5896 AB"},
        {"Henry Draper", "HD 55199"},
        {"Hipparcos Number", "HIP 35033"},
        {"Renson", "Renson 15030"},
        {"Smithsonian Astrophysical Observation", "SAO 26240"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.70022805),
        dec: Angle.Degrees(+52.54559321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209284"},
        {"Hipparcos Number", "HIP 108659"},
        {"Smithsonian Astrophysical Observation", "SAO 33967"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.18873808),
        dec: Angle.Degrees(+52.54751286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15137"},
        {"Hipparcos Number", "HIP 11473"},
        {"Celescope Catalog", "CEL 277"},
        {"Geneva Identification System", "GEN# +1.00015137"},
        {"Smithsonian Astrophysical Observation", "SAO 23354"},
        {"Wilson Evans Batten Catalogue", "WEB 2395"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.99921160),
        dec: Angle.Degrees(+52.54934217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234941"},
        {"Hipparcos Number", "HIP 96343"},
        {"Smithsonian Astrophysical Observation", "SAO 31797"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.81144485),
        dec: Angle.Degrees(+52.55298983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112732"},
        {"Hipparcos Number", "HIP 63285"},
        {"Smithsonian Astrophysical Observation", "SAO 28582"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.54028847),
        dec: Angle.Degrees(+52.55323694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167940"},
        {"Hipparcos Number", "HIP 89400"},
        {"Smithsonian Astrophysical Observation", "SAO 30833"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.66221422),
        dec: Angle.Degrees(+52.55752664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233826"},
        {"Hipparcos Number", "HIP 55489"},
        {"Smithsonian Astrophysical Observation", "SAO 28000"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.46068656),
        dec: Angle.Degrees(+52.55809255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13833"},
        {"Hipparcos Number", "HIP 10588"},
        {"Smithsonian Astrophysical Observation", "SAO 23107"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.08475227),
        dec: Angle.Degrees(+52.55926141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222490"},
        {"Hipparcos Number", "HIP 116830"},
        {"Geneva Identification System", "GEN# +1.00222490"},
        {"Smithsonian Astrophysical Observation", "SAO 35660"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.19252376),
        dec: Angle.Degrees(+52.56048504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186673"},
        {"Hipparcos Number", "HIP 97037"},
        {"Smithsonian Astrophysical Observation", "SAO 31922"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.82031659),
        dec: Angle.Degrees(+52.56117603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14220"},
        {"Hipparcos Number", "HIP 10849"},
        {"Celescope Catalog", "CEL 252"},
        {"Geneva Identification System", "GEN# +1.00014220"},
        {"Smithsonian Astrophysical Observation", "SAO 23199"},
        {"Wilson Evans Batten Catalogue", "WEB 2288"},
    },
    visualMagnitude: 7.19,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.90742376),
        dec: Angle.Degrees(+52.56137413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24189"},
        {"Hipparcos Number", "HIP 18207"},
        {"Geneva Identification System", "GEN# +1.00024189"},
        {"Smithsonian Astrophysical Observation", "SAO 24277"},
        {"Wilson Evans Batten Catalogue", "WEB 3509"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.40581639),
        dec: Angle.Degrees(+52.56300130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57725"},
        {"Geneva Identification System", "GEN# +6.20001050"},
        {"Renson", "Renson 29700"},
    },
    visualMagnitude: 11.98,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.57133917),
        dec: Angle.Degrees(+52.56307054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3625"},
        {"Hipparcos Number", "HIP 3106"},
        {"Geneva Identification System", "GEN# +1.00003625"},
        {"Smithsonian Astrophysical Observation", "SAO 21600"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.89096594),
        dec: Angle.Degrees(+52.56346032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236102"},
        {"Hipparcos Number", "HIP 115291"},
        {"Geneva Identification System", "GEN# +1.00236102"},
        {"Smithsonian Astrophysical Observation", "SAO 35343"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.24380896),
        dec: Angle.Degrees(+52.56452576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142417"},
        {"Hipparcos Number", "HIP 77714"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.00141369),
        dec: Angle.Degrees(+52.56514986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94083"},
        {"Hipparcos Number", "HIP 53155"},
        {"Smithsonian Astrophysical Observation", "SAO 27809"},
        {"Wilson Evans Batten Catalogue", "WEB 9651"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.12874290),
        dec: Angle.Degrees(+52.56541142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55935",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55935"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.95290243),
        dec: Angle.Degrees(+52.56650503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60845"},
        {"Hipparcos Number", "HIP 37273"},
        {"Geneva Identification System", "GEN# +1.00060845"},
        {"Smithsonian Astrophysical Observation", "SAO 26446"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.81228478),
        dec: Angle.Degrees(+52.56653414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132167"},
        {"Hipparcos Number", "HIP 73039"},
        {"Geneva Identification System", "GEN# +1.00132167"},
        {"Smithsonian Astrophysical Observation", "SAO 29340"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.90712435),
        dec: Angle.Degrees(+52.56730082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -255.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182716"},
        {"Hipparcos Number", "HIP 95300"},
        {"Smithsonian Astrophysical Observation", "SAO 31622"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.82090968),
        dec: Angle.Degrees(+52.56839650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37328"},
        {"Hipparcos Number", "HIP 26720"},
        {"Geneva Identification System", "GEN# +1.00037328"},
        {"Smithsonian Astrophysical Observation", "SAO 25315"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.17670739),
        dec: Angle.Degrees(+52.57012130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233901"},
        {"Hipparcos Number", "HIP 59261"},
        {"Smithsonian Astrophysical Observation", "SAO 28263"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.33847221),
        dec: Angle.Degrees(+52.57088786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51324"},
        {"Hipparcos Number", "HIP 33672"},
        {"Fundamental Katalog 5th Edition", "FK5 2539"},
        {"Geneva Identification System", "GEN# +1.00051324"},
        {"Smithsonian Astrophysical Observation", "SAO 26083"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.93519104),
        dec: Angle.Degrees(+52.57247337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235463"},
        {"Hipparcos Number", "HIP 104790"},
        {"Smithsonian Astrophysical Observation", "SAO 33244"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.44108301),
        dec: Angle.Degrees(+52.57463505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234462"},
        {"Hipparcos Number", "HIP 86183"},
        {"Geneva Identification System", "GEN# +1.00234462"},
        {"Smithsonian Astrophysical Observation", "SAO 30479"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.16277359),
        dec: Angle.Degrees(+52.57507395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190584"},
        {"Hipparcos Number", "HIP 98733"},
        {"Geneva Identification System", "GEN# +1.00190584"},
        {"Smithsonian Astrophysical Observation", "SAO 32239"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.80456613),
        dec: Angle.Degrees(+52.57533053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200594"},
        {"Hipparcos Number", "HIP 103827"},
        {"Celescope Catalog", "CEL 5235"},
        {"Geneva Identification System", "GEN# +1.00200594"},
        {"Smithsonian Astrophysical Observation", "SAO 33080"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.59960181),
        dec: Angle.Degrees(+52.57580315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184055"},
        {"Hipparcos Number", "HIP 95872"},
        {"Geneva Identification System", "GEN# +1.00184055"},
        {"Smithsonian Astrophysical Observation", "SAO 31705"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.48154087),
        dec: Angle.Degrees(+52.57867023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 236280"},
        {"Hipparcos Number", "HIP 182"},
        {"Smithsonian Astrophysical Observation", "SAO 36002"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.58116809),
        dec: Angle.Degrees(+52.58643746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233683"},
        {"Hipparcos Number", "HIP 48463"},
        {"Smithsonian Astrophysical Observation", "SAO 27414"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.22659730),
        dec: Angle.Degrees(+52.58650614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197406"},
        {"Hipparcos Number", "HIP 102088"},
        {"Geneva Identification System", "GEN# +1.00197406"},
        {"Wilson Evans Batten Catalogue", "WEB 18467"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.33980818),
        dec: Angle.Degrees(+52.58754776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74563",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9551 AB"},
        {"Henry Draper", "HD 234220"},
        {"Hipparcos Number", "HIP 74563"},
        {"Smithsonian Astrophysical Observation", "SAO 29454"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.52968696),
        dec: Angle.Degrees(+52.58849928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131525"},
        {"Hipparcos Number", "HIP 72722"},
        {"Geneva Identification System", "GEN# +1.00131525"},
        {"Smithsonian Astrophysical Observation", "SAO 29316"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.02389908),
        dec: Angle.Degrees(+52.58901500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109403",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109403"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.46869753),
        dec: Angle.Degrees(+52.58910180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -243.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179305"},
        {"Hipparcos Number", "HIP 94093"},
        {"Geneva Identification System", "GEN# +1.00179305"},
        {"Smithsonian Astrophysical Observation", "SAO 31426"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.31561545),
        dec: Angle.Degrees(+52.59093690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85825",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10627 A"},
        {"Henry Draper", "HD 159497"},
        {"Hipparcos Number", "HIP 85825"},
        {"Smithsonian Astrophysical Observation", "SAO 30446"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.06074354),
        dec: Angle.Degrees(+52.59245734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38420"},
        {"Hipparcos Number", "HIP 27439"},
        {"Geneva Identification System", "GEN# +1.00038420"},
        {"Smithsonian Astrophysical Observation", "SAO 25387"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.15084309),
        dec: Angle.Degrees(+52.59284175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118668"},
        {"Hipparcos Number", "HIP 66440"},
        {"Smithsonian Astrophysical Observation", "SAO 28818"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.30317489),
        dec: Angle.Degrees(+52.59308989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173238"},
        {"Hipparcos Number", "HIP 91660"},
        {"Smithsonian Astrophysical Observation", "SAO 31107"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.37653310),
        dec: Angle.Degrees(+52.59507602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232397"},
        {"Hipparcos Number", "HIP 5708"},
        {"Smithsonian Astrophysical Observation", "SAO 22104"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.35774933),
        dec: Angle.Degrees(+52.59646591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196281"},
        {"Hipparcos Number", "HIP 101488"},
        {"Geneva Identification System", "GEN# +1.00196281"},
        {"Smithsonian Astrophysical Observation", "SAO 32702"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.49793047),
        dec: Angle.Degrees(+52.59786591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234294"},
        {"Hipparcos Number", "HIP 79748"},
        {"Smithsonian Astrophysical Observation", "SAO 29863"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.14562292),
        dec: Angle.Degrees(+52.59868423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232816"},
        {"Hipparcos Number", "HIP 16973"},
        {"Geneva Identification System", "GEN# +1.00232816"},
        {"Smithsonian Astrophysical Observation", "SAO 24134"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.58075740),
        dec: Angle.Degrees(+52.59910840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6772"},
        {"Hipparcos Number", "HIP 5420"},
        {"Geneva Identification System", "GEN# +1.00006772"},
        {"Smithsonian Astrophysical Observation", "SAO 22038"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.31720389),
        dec: Angle.Degrees(+52.60292982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 234546"},
        {"Hipparcos Number", "HIP 88406"},
        {"Smithsonian Astrophysical Observation", "SAO 30714"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.77290309),
        dec: Angle.Degrees(+52.60329620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154199"},
        {"Hipparcos Number", "HIP 83285"},
        {"Geneva Identification System", "GEN# +1.00154199"},
        {"Smithsonian Astrophysical Observation", "SAO 30200"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.30918959),
        dec: Angle.Degrees(+52.60448109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233010"},
        {"Hipparcos Number", "HIP 22297"},
        {"Smithsonian Astrophysical Observation", "SAO 24838"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.02507592),
        dec: Angle.Degrees(+52.60634029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7665",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1281 AB"},
        {"Henry Draper", "HD 9976"},
        {"Hipparcos Number", "HIP 7665"},
        {"Smithsonian Astrophysical Observation", "SAO 22466"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.66883780),
        dec: Angle.Degrees(+52.60639511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127063"},
        {"Hipparcos Number", "HIP 70698"},
        {"Smithsonian Astrophysical Observation", "SAO 29156"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.89880945),
        dec: Angle.Degrees(+52.60759442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11127"},
        {"Hipparcos Number", "HIP 8594"},
        {"Smithsonian Astrophysical Observation", "SAO 22676"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.73307174),
        dec: Angle.Degrees(+52.60770717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198284"},
        {"Hipparcos Number", "HIP 102572"},
        {"Smithsonian Astrophysical Observation", "SAO 32885"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.79548344),
        dec: Angle.Degrees(+52.60918991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221781"},
        {"Hipparcos Number", "HIP 116364"},
        {"Smithsonian Astrophysical Observation", "SAO 35563"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.69407578),
        dec: Angle.Degrees(+52.61033682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186761"},
        {"Hipparcos Number", "HIP 97086"},
        {"Fundamental Katalog 5th Edition", "FK5 5742"},
        {"Geneva Identification System", "GEN# +1.00186761"},
        {"Renson", "Renson 51510"},
        {"Smithsonian Astrophysical Observation", "SAO 31931"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.95349465),
        dec: Angle.Degrees(+52.61078575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213632"},
        {"Hipparcos Number", "HIP 111214"},
        {"Smithsonian Astrophysical Observation", "SAO 34551"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.96331324),
        dec: Angle.Degrees(+52.61321778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232987"},
        {"Hipparcos Number", "HIP 21779"},
        {"Smithsonian Astrophysical Observation", "SAO 24756"},
        {"Wilson Evans Batten Catalogue", "WEB 4190"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.18498276),
        dec: Angle.Degrees(+52.61673912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90646"},
        {"Hipparcos Number", "HIP 51334"},
        {"Smithsonian Astrophysical Observation", "SAO 27657"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.28193965),
        dec: Angle.Degrees(+52.61863087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114317"},
        {"Renson", "Renson 60185"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.27267146),
        dec: Angle.Degrees(+52.61980902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205114"},
        {"Henry Draper 2", "HD 205115"},
        {"Hipparcos Number", "HIP 106267"},
        {"Geneva Identification System", "GEN# +1.00205114"},
        {"Smithsonian Astrophysical Observation", "SAO 33497"},
        {"Wilson Evans Batten Catalogue", "WEB 19251"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.86443046),
        dec: Angle.Degrees(+52.61985967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81538",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 12.01,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)39, 14.0300),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)37, 14.400)
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
    primaryId: "HIP 51062",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7762 AB"},
        {"Henry Draper", "HD 90204"},
        {"Hipparcos Number", "HIP 51062"},
        {"Smithsonian Astrophysical Observation", "SAO 27639"},
        {"Wilson Evans Batten Catalogue", "WEB 9334"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.49592801),
        dec: Angle.Degrees(+52.62183218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20670"},
        {"Hipparcos Number", "HIP 15675"},
        {"Geneva Identification System", "GEN# +1.00020670"},
        {"Smithsonian Astrophysical Observation", "SAO 23979"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.48598438),
        dec: Angle.Degrees(+52.62206277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216828"},
        {"Hipparcos Number", "HIP 113202"},
        {"Geneva Identification System", "GEN# +1.00216828"},
        {"Smithsonian Astrophysical Observation", "SAO 34954"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.86496691),
        dec: Angle.Degrees(+52.62206378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233838"},
        {"Hipparcos Number", "HIP 56141"},
        {"Smithsonian Astrophysical Observation", "SAO 28040"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.61056522),
        dec: Angle.Degrees(+52.62347808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85066"},
        {"Hipparcos Number", "HIP 48329"},
        {"Geneva Identification System", "GEN# +1.00085066"},
        {"Wilson Evans Batten Catalogue", "WEB 9016"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.77229907),
        dec: Angle.Degrees(+52.62376115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235944"},
        {"Hipparcos Number", "HIP 112287"},
        {"Smithsonian Astrophysical Observation", "SAO 34751"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.16095620),
        dec: Angle.Degrees(+52.62406367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126877"},
        {"Hipparcos Number", "HIP 70606"},
        {"Fundamental Katalog 5th Edition", "FK5 5275"},
        {"Geneva Identification System", "GEN# +1.00126877"},
        {"Smithsonian Astrophysical Observation", "SAO 29144"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.63579082),
        dec: Angle.Degrees(+52.62526156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130799"},
        {"Hipparcos Number", "HIP 72404"},
        {"Smithsonian Astrophysical Observation", "SAO 29287"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.06457351),
        dec: Angle.Degrees(+52.62577228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233519"},
        {"Hipparcos Number", "HIP 41069"},
        {"Smithsonian Astrophysical Observation", "SAO 26806"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.69802820),
        dec: Angle.Degrees(+52.62716120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96624"},
        {"Hipparcos Number", "HIP 54457"},
        {"Geneva Identification System", "GEN# +1.00096624"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.12699935),
        dec: Angle.Degrees(+52.62726743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -221.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18964"},
        {"Hipparcos Number", "HIP 14350"},
        {"Smithsonian Astrophysical Observation", "SAO 23790"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.26520958),
        dec: Angle.Degrees(+52.62829456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25235"},
        {"Hipparcos Number", "HIP 18900"},
        {"Geneva Identification System", "GEN# +1.00025235"},
        {"Smithsonian Astrophysical Observation", "SAO 24373"},
        {"Wilson Evans Batten Catalogue", "WEB 3637"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.76897020),
        dec: Angle.Degrees(+52.62907089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102220",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14204 AB"},
        {"Henry Draper", "HD 197619"},
        {"Hipparcos Number", "HIP 102220"},
        {"Smithsonian Astrophysical Observation", "SAO 32818"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.67606892),
        dec: Angle.Degrees(+52.63056864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233404"},
        {"Hipparcos Number", "HIP 36584"},
        {"Smithsonian Astrophysical Observation", "SAO 26389"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.86944158),
        dec: Angle.Degrees(+52.63568669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210180"},
        {"Hipparcos Number", "HIP 109193"},
        {"Geneva Identification System", "GEN# +1.00210180"},
        {"Smithsonian Astrophysical Observation", "SAO 34071"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.80173558),
        dec: Angle.Degrees(+52.63569847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63089"},
        {"Hipparcos Number", "HIP 38219"},
        {"Smithsonian Astrophysical Observation", "SAO 26526"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.44525470),
        dec: Angle.Degrees(+52.63632020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1045"},
        {"Hipparcos Number", "HIP 1204"},
        {"Smithsonian Astrophysical Observation", "SAO 21248"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.76667184),
        dec: Angle.Degrees(+52.63960287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39180"},
        {"Hipparcos Number", "HIP 27865"},
        {"Geneva Identification System", "GEN# +1.00039180"},
        {"Smithsonian Astrophysical Observation", "SAO 25436"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.43570537),
        dec: Angle.Degrees(+52.64012645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24431"},
        {"Hipparcos Number", "HIP 18370"},
        {"Fundamental Katalog 5th Edition", "FK5 4356"},
        {"Geneva Identification System", "GEN# +1.00024431"},
        {"Smithsonian Astrophysical Observation", "SAO 24300"},
        {"Wilson Evans Batten Catalogue", "WEB 3547"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.91008760),
        dec: Angle.Degrees(+52.64132705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6636"},
        {"Hipparcos Number", "HIP 5312"},
        {"Smithsonian Astrophysical Observation", "SAO 22026"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.99248339),
        dec: Angle.Degrees(+52.64250631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71810",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9348 AB"},
        {"Henry Draper", "HD 129562"},
        {"Hipparcos Number", "HIP 71810"},
        {"Geneva Identification System", "GEN# +1.00129562J"},
        {"Smithsonian Astrophysical Observation", "SAO 29245"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.33600157),
        dec: Angle.Degrees(+52.64705706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42083"},
        {"Hipparcos Number", "HIP 29404"},
        {"Geneva Identification System", "GEN# +1.00042083"},
        {"Renson", "Renson 11240"},
        {"Smithsonian Astrophysical Observation", "SAO 25613"},
        {"Wilson Evans Batten Catalogue", "WEB 5774"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.94129224),
        dec: Angle.Degrees(+52.64736426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61857"},
        {"Hipparcos Number", "HIP 37694"},
        {"Smithsonian Astrophysical Observation", "SAO 26486"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.99843927),
        dec: Angle.Degrees(+52.65016595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168912"},
        {"Hipparcos Number", "HIP 89779"},
        {"Geneva Identification System", "GEN# +1.00168912"},
        {"Smithsonian Astrophysical Observation", "SAO 30889"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.82572283),
        dec: Angle.Degrees(+52.65193393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223458"},
        {"Hipparcos Number", "HIP 117497"},
        {"Smithsonian Astrophysical Observation", "SAO 35807"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.38883258),
        dec: Angle.Degrees(+52.65251203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36278"},
        {"Hipparcos Number", "HIP 26059"},
        {"Smithsonian Astrophysical Observation", "SAO 25250"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.37599995),
        dec: Angle.Degrees(+52.65307772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217314"},
        {"Hipparcos Number", "HIP 113501"},
        {"Fundamental Katalog 5th Edition", "FK5 3838"},
        {"Geneva Identification System", "GEN# +1.00217314"},
        {"Smithsonian Astrophysical Observation", "SAO 35022"},
        {"Wilson Evans Batten Catalogue", "WEB 20180"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.79319251),
        dec: Angle.Degrees(+52.65445283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11495"},
        {"Hipparcos Number", "HIP 8877"},
        {"Geneva Identification System", "GEN# +1.00011495"},
        {"Smithsonian Astrophysical Observation", "SAO 22727"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.58295775),
        dec: Angle.Degrees(+52.65495786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12280"},
        {"Hipparcos Number", "HIP 9482"},
        {"Geneva Identification System", "GEN# +1.00012280"},
        {"Smithsonian Astrophysical Observation", "SAO 22856"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.49761770),
        dec: Angle.Degrees(+52.65518433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17877",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2783"},
        {"Aitken 2", "ADS 2783 A"},
        {"Henry Draper", "HD 23675"},
        {"Hipparcos Number", "HIP 17877"},
        {"Geneva Identification System", "GEN# +2.14440001"},
        {"Smithsonian Astrophysical Observation", "SAO 24248"},
        {"Wilson Evans Batten Catalogue", "WEB 3437"},
        {"New General Catalogue", "NGC 1444 1"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.36487911),
        dec: Angle.Degrees(+52.65540783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211822"},
        {"Hipparcos Number", "HIP 110142"},
        {"Smithsonian Astrophysical Observation", "SAO 34294"},
        {"Wilson Evans Batten Catalogue", "WEB 19769"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.65694719),
        dec: Angle.Degrees(+52.65604680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233756"},
        {"Hipparcos Number", "HIP 52057"},
        {"Smithsonian Astrophysical Observation", "SAO 27718"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.56728601),
        dec: Angle.Degrees(+52.65810791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 232137"},
        {"Hipparcos Number", "HIP 1100"},
        {"Geneva Identification System", "GEN# +1.00232137"},
        {"Smithsonian Astrophysical Observation", "SAO 21220"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.43520955),
        dec: Angle.Degrees(+52.65872983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235389"},
        {"Hipparcos Number", "HIP 103030"},
        {"Smithsonian Astrophysical Observation", "SAO 32954"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.10083293),
        dec: Angle.Degrees(+52.65944463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75502",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75502"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.33549084),
        dec: Angle.Degrees(+52.66131521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6238",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1076 AB"},
        {"Henry Draper", "HD 7959"},
        {"Hipparcos Number", "HIP 6238"},
        {"Smithsonian Astrophysical Observation", "SAO 22192"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.01311370),
        dec: Angle.Degrees(+52.66616117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202362"},
        {"Hipparcos Number", "HIP 104758"},
        {"Geneva Identification System", "GEN# +1.00202362"},
        {"Smithsonian Astrophysical Observation", "SAO 33236"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.34193980),
        dec: Angle.Degrees(+52.66719248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16593"},
        {"Hipparcos Number", "HIP 12551"},
        {"Geneva Identification System", "GEN# +1.00016593"},
        {"Smithsonian Astrophysical Observation", "SAO 23535"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.36630969),
        dec: Angle.Degrees(+52.66997138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200240"},
        {"Hipparcos Number", "HIP 103666"},
        {"Geneva Identification System", "GEN# +1.00200240"},
        {"Smithsonian Astrophysical Observation", "SAO 33053"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.06073513),
        dec: Angle.Degrees(+52.67409381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221178"},
        {"Hipparcos Number", "HIP 115939"},
        {"Smithsonian Astrophysical Observation", "SAO 35464"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.35609230),
        dec: Angle.Degrees(+52.67597361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
