using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_56() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173744"},
        {"Hipparcos Number", "HIP 92171"},
        {"Celescope Catalog", "CEL 4651"},
        {"Geneva Identification System", "GEN# +1.00173744"},
        {"Smithsonian Astrophysical Observation", "SAO 142616"},
        {"Wilson Evans Batten Catalogue", "WEB 15893"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.78448143),
        dec: Angle.Degrees(-05.89855807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39104"},
        {"Hipparcos Number", "HIP 27552"},
        {"Smithsonian Astrophysical Observation", "SAO 132577"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.51367175),
        dec: Angle.Degrees(-05.89807690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37546"},
        {"Hipparcos Number", "HIP 26588"},
        {"Smithsonian Astrophysical Observation", "SAO 132419"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.77301362),
        dec: Angle.Degrees(-05.89748426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57539"},
        {"Hipparcos Number", "HIP 35669"},
        {"Fundamental Katalog 5th Edition", "FK5 2569"},
        {"Geneva Identification System", "GEN# +1.00057539"},
        {"Smithsonian Astrophysical Observation", "SAO 134570"},
        {"Wilson Evans Batten Catalogue", "WEB 7105"},
    },
    visualMagnitude: 6.60,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.39430165),
        dec: Angle.Degrees(-05.89719400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98321"},
        {"Hipparcos Number", "HIP 55213"},
        {"Smithsonian Astrophysical Observation", "SAO 138121"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.60393878),
        dec: Angle.Degrees(-05.89619998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179716"},
        {"Hipparcos Number", "HIP 94488"},
        {"Smithsonian Astrophysical Observation", "SAO 143157"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.47332846),
        dec: Angle.Degrees(-05.89603926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187932"},
        {"Hipparcos Number", "HIP 97825"},
        {"Smithsonian Astrophysical Observation", "SAO 143874"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.18663865),
        dec: Angle.Degrees(-05.89511511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210555"},
        {"Hipparcos Number", "HIP 109526"},
        {"Smithsonian Astrophysical Observation", "SAO 145923"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.79884857),
        dec: Angle.Degrees(-05.89368536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11236",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1837 AB"},
        {"Henry Draper", "HD 14964"},
        {"Hipparcos Number", "HIP 11236"},
        {"Smithsonian Astrophysical Observation", "SAO 129883"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.16184644),
        dec: Angle.Degrees(-05.89335857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224661"},
        {"Hipparcos Number", "HIP 118298"},
        {"Geneva Identification System", "GEN# +1.00224661"},
        {"Smithsonian Astrophysical Observation", "SAO 147017"},
        {"Wilson Evans Batten Catalogue", "WEB 20793"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.91926768),
        dec: Angle.Degrees(-05.89291350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111198"},
        {"Hipparcos Number", "HIP 62419"},
        {"Smithsonian Astrophysical Observation", "SAO 138966"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.88316417),
        dec: Angle.Degrees(-05.89069948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118459"},
        {"Hipparcos Number", "HIP 66443"},
        {"Smithsonian Astrophysical Observation", "SAO 139445"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.31335689),
        dec: Angle.Degrees(-05.89041982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209445"},
        {"Hipparcos Number", "HIP 108898"},
        {"Geneva Identification System", "GEN# +1.00209445"},
        {"Smithsonian Astrophysical Observation", "SAO 145839"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.88048416),
        dec: Angle.Degrees(-05.89021780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211080"},
        {"Hipparcos Number", "HIP 109836"},
        {"Geneva Identification System", "GEN# +1.00211080"},
        {"Smithsonian Astrophysical Observation", "SAO 145965"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.69490579),
        dec: Angle.Degrees(-05.88628232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5720"},
        {"Hipparcos Number", "HIP 4592"},
        {"Fundamental Katalog 5th Edition", "FK5 1024"},
        {"Geneva Identification System", "GEN# +1.00005720"},
        {"Smithsonian Astrophysical Observation", "SAO 129056"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.69060186),
        dec: Angle.Degrees(-05.88261835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52143",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7866 AB"},
        {"Henry Draper", "HD 92283"},
        {"Hipparcos Number", "HIP 52143"},
        {"Smithsonian Astrophysical Observation", "SAO 137708"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.78786887),
        dec: Angle.Degrees(-05.88188633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214477"},
        {"Hipparcos Number", "HIP 111792"},
        {"Smithsonian Astrophysical Observation", "SAO 146217"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.64904166),
        dec: Angle.Degrees(-05.88118205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41608"},
        {"Hipparcos Number", "HIP 28897"},
        {"Smithsonian Astrophysical Observation", "SAO 132829"},
        {"Wilson Evans Batten Catalogue", "WEB 5652"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.50933411),
        dec: Angle.Degrees(-05.88017681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81464"},
        {"Hipparcos Number", "HIP 46235"},
        {"Geneva Identification System", "GEN# +1.00081464"},
        {"Smithsonian Astrophysical Observation", "SAO 136835"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.39965967),
        dec: Angle.Degrees(-05.87691213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121324"},
        {"Hipparcos Number", "HIP 67949"},
        {"Smithsonian Astrophysical Observation", "SAO 139617"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.73575307),
        dec: Angle.Degrees(-05.87612790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71782"},
        {"Hipparcos Number", "HIP 41619"},
        {"Smithsonian Astrophysical Observation", "SAO 135967"},
        {"Wilson Evans Batten Catalogue", "WEB 8030"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.27437657),
        dec: Angle.Degrees(-05.87605194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224840"},
        {"Hipparcos Number", "HIP 91"},
        {"Smithsonian Astrophysical Observation", "SAO 147033"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.28056847),
        dec: Angle.Degrees(-05.87433293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99253"},
        {"Hipparcos Number", "HIP 55739"},
        {"Smithsonian Astrophysical Observation", "SAO 138194"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.31228732),
        dec: Angle.Degrees(-05.86894853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58755"},
        {"Hipparcos Number", "HIP 36148"},
        {"Smithsonian Astrophysical Observation", "SAO 134674"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.69237294),
        dec: Angle.Degrees(-05.86893266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46304"},
        {"Hipparcos Number", "HIP 31167"},
        {"Geneva Identification System", "GEN# +1.00046304J"},
        {"Renson", "Renson 12390"},
        {"Smithsonian Astrophysical Observation", "SAO 133382"},
    },
    visualMagnitude: 5.60,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.09637360),
        dec: Angle.Degrees(-05.86871833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160329"},
        {"Hipparcos Number", "HIP 86426"},
        {"Smithsonian Astrophysical Observation", "SAO 141788"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.88584057),
        dec: Angle.Degrees(-05.85898478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124117"},
        {"Hipparcos Number", "HIP 69352"},
        {"Smithsonian Astrophysical Observation", "SAO 139778"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.92365458),
        dec: Angle.Degrees(-05.85747233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15211",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15211"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.02375251),
        dec: Angle.Degrees(-05.85427297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 340.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33154",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5557 AB"},
        {"Henry Draper", "HD 50700"},
        {"Hipparcos Number", "HIP 33154"},
        {"Geneva Identification System", "GEN# +1.00050700"},
        {"Smithsonian Astrophysical Observation", "SAO 133855"},
        {"Wilson Evans Batten Catalogue", "WEB 6666"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.53582454),
        dec: Angle.Degrees(-05.85220154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45068"},
        {"Hipparcos Number", "HIP 30535"},
        {"Smithsonian Astrophysical Observation", "SAO 133228"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.28138226),
        dec: Angle.Degrees(-05.85145543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24586"},
        {"Hipparcos Number", "HIP 18268"},
        {"Geneva Identification System", "GEN# +1.00024586"},
        {"Smithsonian Astrophysical Observation", "SAO 130809"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.61995154),
        dec: Angle.Degrees(-05.85124197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32580"},
        {"Hipparcos Number", "HIP 23566"},
        {"Smithsonian Astrophysical Observation", "SAO 131735"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.00281394),
        dec: Angle.Degrees(-05.85123746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107217"},
        {"Hipparcos Number", "HIP 60105"},
        {"Geneva Identification System", "GEN# +1.00107217"},
        {"Smithsonian Astrophysical Observation", "SAO 138720"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.90596377),
        dec: Angle.Degrees(-05.85107256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36043",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36043"},
    },
    visualMagnitude: 10.49,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.41922463),
        dec: Angle.Degrees(-05.85033741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175751"},
        {"Hipparcos Number", "HIP 93026"},
        {"Geneva Identification System", "GEN# +1.00175751"},
        {"Smithsonian Astrophysical Observation", "SAO 142838"},
        {"Wilson Evans Batten Catalogue", "WEB 16110"},
    },
    visualMagnitude: 4.83,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.26514217),
        dec: Angle.Degrees(-05.84621426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34835"},
        {"Hipparcos Number", "HIP 24891"},
        {"Celescope Catalog", "CEL 629"},
        {"Geneva Identification System", "GEN# +1.00034835"},
        {"Smithsonian Astrophysical Observation", "SAO 131995"},
    },
    visualMagnitude: 8.18,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.03239199),
        dec: Angle.Degrees(-05.84610993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105036"},
        {"Hipparcos Number", "HIP 58981"},
        {"Smithsonian Astrophysical Observation", "SAO 138579"},
        {"Wilson Evans Batten Catalogue", "WEB 10504"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.39607425),
        dec: Angle.Degrees(-05.84589396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106717"},
        {"Hipparcos Number", "HIP 59849"},
        {"Smithsonian Astrophysical Observation", "SAO 138688"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.09355462),
        dec: Angle.Degrees(-05.84570522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28261"},
        {"Hipparcos Number", "HIP 20793"},
        {"Smithsonian Astrophysical Observation", "SAO 131225"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.83615798),
        dec: Angle.Degrees(-05.84398286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195946"},
        {"Hipparcos Number", "HIP 101529"},
        {"Smithsonian Astrophysical Observation", "SAO 144578"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.63797250),
        dec: Angle.Degrees(-05.84358752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76927"},
        {"Hipparcos Number", "HIP 44119"},
        {"Smithsonian Astrophysical Observation", "SAO 136465"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.78438561),
        dec: Angle.Degrees(-05.84341641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 144.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135757"},
        {"Hipparcos Number", "HIP 74777"},
        {"Geneva Identification System", "GEN# +1.00135757"},
        {"Smithsonian Astrophysical Observation", "SAO 140429"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.23296050),
        dec: Angle.Degrees(-05.84336907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211594"},
        {"Hipparcos Number", "HIP 110108"},
        {"Geneva Identification System", "GEN# +1.00211594"},
        {"Smithsonian Astrophysical Observation", "SAO 146006"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.56224850),
        dec: Angle.Degrees(-05.84167004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139089"},
        {"Hipparcos Number", "HIP 76413"},
        {"Geneva Identification System", "GEN# +1.00139089"},
        {"Smithsonian Astrophysical Observation", "SAO 140638"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.10811751),
        dec: Angle.Degrees(-05.84030816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192008"},
        {"Hipparcos Number", "HIP 99608"},
        {"Smithsonian Astrophysical Observation", "SAO 144175"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.22118958),
        dec: Angle.Degrees(-05.83876929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50892"},
        {"Hipparcos Number", "HIP 33231"},
        {"Smithsonian Astrophysical Observation", "SAO 133888"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.72074346),
        dec: Angle.Degrees(-05.83840871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224829"},
        {"Hipparcos Number", "HIP 87"},
        {"Geneva Identification System", "GEN# +1.00224829"},
        {"Smithsonian Astrophysical Observation", "SAO 147032"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.26151556),
        dec: Angle.Degrees(-05.83497569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143857"},
        {"Hipparcos Number", "HIP 78624"},
        {"Smithsonian Astrophysical Observation", "SAO 140918"},
        {"Wilson Evans Batten Catalogue", "WEB 13289"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.76461694),
        dec: Angle.Degrees(-05.83448276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128143"},
        {"Hipparcos Number", "HIP 71347"},
        {"Geneva Identification System", "GEN# +1.00128143"},
        {"Smithsonian Astrophysical Observation", "SAO 140018"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.86327732),
        dec: Angle.Degrees(-05.83288634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109704"},
        {"Hipparcos Number", "HIP 61558"},
        {"Fundamental Katalog 5th Edition", "FK5 1324"},
        {"Geneva Identification System", "GEN# +1.00109704"},
        {"Renson", "Renson 31810"},
        {"Smithsonian Astrophysical Observation", "SAO 138873"},
        {"Wilson Evans Batten Catalogue", "WEB 10953"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.19737813),
        dec: Angle.Degrees(-05.83185110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125713"},
        {"Hipparcos Number", "HIP 70156"},
        {"Smithsonian Astrophysical Observation", "SAO 139881"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.32161748),
        dec: Angle.Degrees(-05.83159595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17338"},
        {"Hipparcos Number", "HIP 12966"},
        {"Geneva Identification System", "GEN# +1.00017338"},
        {"Smithsonian Astrophysical Observation", "SAO 130109"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.69637217),
        dec: Angle.Degrees(-05.82961665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38868"},
        {"Hipparcos Number", "HIP 27438"},
        {"Celescope Catalog", "CEL 985"},
        {"Geneva Identification System", "GEN# +1.00038868"},
        {"Smithsonian Astrophysical Observation", "SAO 132555"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.15009334),
        dec: Angle.Degrees(-05.82940024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208398"},
        {"Hipparcos Number", "HIP 108272"},
        {"Smithsonian Astrophysical Observation", "SAO 145752"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.02246570),
        dec: Angle.Degrees(-05.82921289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89057"},
        {"Hipparcos Number", "HIP 50307"},
        {"Geneva Identification System", "GEN# +1.00089057"},
        {"Smithsonian Astrophysical Observation", "SAO 137451"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.07056372),
        dec: Angle.Degrees(-05.82902441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210043"},
        {"Hipparcos Number", "HIP 109229"},
        {"Smithsonian Astrophysical Observation", "SAO 145882"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.92339139),
        dec: Angle.Degrees(-05.82874166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153392"},
        {"Hipparcos Number", "HIP 83145"},
        {"Geneva Identification System", "GEN# +1.00153392"},
        {"Smithsonian Astrophysical Observation", "SAO 141472"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.87742032),
        dec: Angle.Degrees(-05.82675436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52266"},
        {"Hipparcos Number", "HIP 33723"},
        {"Geneva Identification System", "GEN# +1.00052266"},
        {"Smithsonian Astrophysical Observation", "SAO 134034"},
        {"Wilson Evans Batten Catalogue", "WEB 6775"},
    },
    visualMagnitude: 7.21,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.08781991),
        dec: Angle.Degrees(-05.82665429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195312"},
        {"Hipparcos Number", "HIP 101189"},
        {"Geneva Identification System", "GEN# +1.00195312"},
        {"Smithsonian Astrophysical Observation", "SAO 144514"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.66414472),
        dec: Angle.Degrees(-05.82592777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223216"},
        {"Hipparcos Number", "HIP 117349"},
        {"Geneva Identification System", "GEN# +1.00223216"},
        {"Smithsonian Astrophysical Observation", "SAO 146908"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.91009685),
        dec: Angle.Degrees(-05.82544599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136479"},
        {"Hipparcos Number", "HIP 75127"},
        {"Fundamental Katalog 5th Edition", "FK5 3209"},
        {"Geneva Identification System", "GEN# +1.00136479"},
        {"Smithsonian Astrophysical Observation", "SAO 140474"},
        {"Wilson Evans Batten Catalogue", "WEB 12814"},
    },
    visualMagnitude: 5.54,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.28183604),
        dec: Angle.Degrees(-05.82482695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103981",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14592 AB"},
        {"Aitken 2", "ADS 14592"},
        {"Hipparcos Number", "HIP 103981"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.01963509),
        dec: Angle.Degrees(-05.82304908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56613"},
        {"Hipparcos Number", "HIP 35300"},
        {"Smithsonian Astrophysical Observation", "SAO 134473"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.38171276),
        dec: Angle.Degrees(-05.82262967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34909"},
        {"Hipparcos Number", "HIP 24944"},
        {"Geneva Identification System", "GEN# +1.00034909"},
        {"Smithsonian Astrophysical Observation", "SAO 132014"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.15617480),
        dec: Angle.Degrees(-05.82257005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172902"},
        {"Hipparcos Number", "HIP 91785"},
        {"Geneva Identification System", "GEN# +1.00172902"},
        {"Smithsonian Astrophysical Observation", "SAO 142532"},
        {"Wilson Evans Batten Catalogue", "WEB 15795"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.73864111),
        dec: Angle.Degrees(-05.82089801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79358"},
        {"Hipparcos Number", "HIP 45262"},
        {"Smithsonian Astrophysical Observation", "SAO 136674"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.37817844),
        dec: Angle.Degrees(-05.81941521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8483"},
        {"Hipparcos Number", "HIP 6528"},
        {"Geneva Identification System", "GEN# +1.00008483"},
        {"Smithsonian Astrophysical Observation", "SAO 129272"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.96183154),
        dec: Angle.Degrees(-05.81854672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220977"},
        {"Hipparcos Number", "HIP 115852"},
        {"Smithsonian Astrophysical Observation", "SAO 146719"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.07062956),
        dec: Angle.Degrees(-05.81784170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137610"},
        {"Hipparcos Number", "HIP 75629"},
        {"Smithsonian Astrophysical Observation", "SAO 140540"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.78521249),
        dec: Angle.Degrees(-05.81762865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114943"},
        {"Hipparcos Number", "HIP 64559"},
        {"Smithsonian Astrophysical Observation", "SAO 139235"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.49821693),
        dec: Angle.Degrees(-05.81501242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76816"},
        {"Hipparcos Number", "HIP 44063"},
        {"Smithsonian Astrophysical Observation", "SAO 136455"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.60934432),
        dec: Angle.Degrees(-05.81363432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104657",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14730 A"},
        {"Henry Draper", "HD 201780"},
        {"Hipparcos Number", "HIP 104657"},
        {"Smithsonian Astrophysical Observation", "SAO 145191"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.99405612),
        dec: Angle.Degrees(-05.81361639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92751"},
        {"Hipparcos Number", "HIP 52388"},
        {"Geneva Identification System", "GEN# +1.00092751"},
        {"Renson", "Renson 26767"},
        {"Smithsonian Astrophysical Observation", "SAO 137740"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.62219674),
        dec: Angle.Degrees(-05.81286610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34890"},
        {"Hipparcos Number", "HIP 24930"},
        {"Celescope Catalog", "CEL 634"},
        {"Geneva Identification System", "GEN# +1.00034890"},
        {"Smithsonian Astrophysical Observation", "SAO 132009"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.12038003),
        dec: Angle.Degrees(-05.81212719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96957"},
        {"Hipparcos Number", "HIP 54554"},
        {"Geneva Identification System", "GEN# +1.00096957"},
        {"Smithsonian Astrophysical Observation", "SAO 138020"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.44815285),
        dec: Angle.Degrees(-05.81178717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4948",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4948"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.86566354),
        dec: Angle.Degrees(-05.81091701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40775"},
        {"Hipparcos Number", "HIP 28487"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.21045600),
        dec: Angle.Degrees(-05.80768884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38109"},
        {"Hipparcos Number", "HIP 26949"},
        {"Geneva Identification System", "GEN# +1.00038109"},
        {"Smithsonian Astrophysical Observation", "SAO 132481"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.77180701),
        dec: Angle.Degrees(-05.80761069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100314"},
        {"Hipparcos Number", "HIP 56302"},
        {"Geneva Identification System", "GEN# +1.00100314"},
        {"Smithsonian Astrophysical Observation", "SAO 138260"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.13600002),
        dec: Angle.Degrees(-05.80721564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95312"},
        {"Hipparcos Number", "HIP 53780"},
        {"Smithsonian Astrophysical Observation", "SAO 137934"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.05997738),
        dec: Angle.Degrees(-05.80707070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138218"},
        {"Hipparcos Number", "HIP 75960"},
        {"Renson", "Renson 39370"},
        {"Smithsonian Astrophysical Observation", "SAO 140576"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.70689768),
        dec: Angle.Degrees(-05.80562842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63820"},
        {"Hipparcos Number", "HIP 38282"},
        {"Smithsonian Astrophysical Observation", "SAO 135164"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.65381285),
        dec: Angle.Degrees(-05.80292559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127352"},
        {"Hipparcos Number", "HIP 70973"},
        {"Geneva Identification System", "GEN# +1.00127352J"},
        {"Smithsonian Astrophysical Observation", "SAO 139981"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.75309023),
        dec: Angle.Degrees(-05.80229908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -203.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53482"},
        {"Hipparcos Number", "HIP 34156"},
        {"Smithsonian Astrophysical Observation", "SAO 134158"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.24259348),
        dec: Angle.Degrees(-05.79923372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177987"},
        {"Hipparcos Number", "HIP 93878"},
        {"Smithsonian Astrophysical Observation", "SAO 143034"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.77812060),
        dec: Angle.Degrees(-05.79717887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120725"},
        {"Hipparcos Number", "HIP 67622"},
        {"Smithsonian Astrophysical Observation", "SAO 139588"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.84151457),
        dec: Angle.Degrees(-05.79401485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130619"},
        {"Hipparcos Number", "HIP 72491"},
        {"Fundamental Katalog 5th Edition", "FK5 5315"},
        {"Smithsonian Astrophysical Observation", "SAO 140158"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.33925051),
        dec: Angle.Degrees(-05.79127779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36120"},
        {"Hipparcos Number", "HIP 25691"},
        {"Celescope Catalog", "CEL 732"},
        {"Geneva Identification System", "GEN# +1.00036120"},
        {"Smithsonian Astrophysical Observation", "SAO 132167"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.28717757),
        dec: Angle.Degrees(-05.79100347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170714"},
        {"Hipparcos Number", "HIP 90768"},
        {"Celescope Catalog", "CEL 4629"},
        {"Geneva Identification System", "GEN# +1.00170714"},
        {"Smithsonian Astrophysical Observation", "SAO 142359"},
        {"Wilson Evans Batten Catalogue", "WEB 15548"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.78603061),
        dec: Angle.Degrees(-05.78950764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115607"},
        {"Hipparcos Number", "HIP 64909"},
        {"Geneva Identification System", "GEN# +1.00115607"},
        {"Smithsonian Astrophysical Observation", "SAO 139271"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.57412299),
        dec: Angle.Degrees(-05.78923992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109072"},
        {"Hipparcos Number", "HIP 61161"},
        {"Smithsonian Astrophysical Observation", "SAO 138834"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.98865821),
        dec: Angle.Degrees(-05.78905333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152212"},
        {"Hipparcos Number", "HIP 82537"},
        {"Smithsonian Astrophysical Observation", "SAO 141413"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.06383053),
        dec: Angle.Degrees(-05.78875626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128783"},
        {"Hipparcos Number", "HIP 71630"},
        {"Smithsonian Astrophysical Observation", "SAO 140050"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.75035919),
        dec: Angle.Degrees(-05.78702864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86205"},
        {"Hipparcos Number", "HIP 48771"},
        {"Smithsonian Astrophysical Observation", "SAO 137245"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.20628265),
        dec: Angle.Degrees(-05.78446049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 897",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 897"},
        {"Geneva Identification System", "GEN# -0.00600015"},
    },
    visualMagnitude: 10.86,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.76858844),
        dec: Angle.Degrees(-05.78399441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 255.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190031"},
        {"Hipparcos Number", "HIP 98736"},
        {"Smithsonian Astrophysical Observation", "SAO 144030"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.81368381),
        dec: Angle.Degrees(-05.78260755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202686"},
        {"Hipparcos Number", "HIP 105120"},
        {"Geneva Identification System", "GEN# +1.00202686"},
        {"Smithsonian Astrophysical Observation", "SAO 145272"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.40873159),
        dec: Angle.Degrees(-05.78216935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60805"},
        {"Hipparcos Number", "HIP 36984"},
        {"Smithsonian Astrophysical Observation", "SAO 134880"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.02785179),
        dec: Angle.Degrees(-05.78023810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107754"},
        {"Hipparcos Number", "HIP 60389"},
        {"Smithsonian Astrophysical Observation", "SAO 138744"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.73424132),
        dec: Angle.Degrees(-05.78006162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12943"},
        {"Hipparcos Number", "HIP 9847"},
        {"Smithsonian Astrophysical Observation", "SAO 129697"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.67335681),
        dec: Angle.Degrees(-05.77771394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58526"},
        {"Hipparcos Number", "HIP 36055"},
        {"Geneva Identification System", "GEN# +1.00058526"},
        {"Smithsonian Astrophysical Observation", "SAO 134654"},
        {"Wilson Evans Batten Catalogue", "WEB 7184"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.46334907),
        dec: Angle.Degrees(-05.77495377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29552"},
        {"Hipparcos Number", "HIP 21658"},
        {"Smithsonian Astrophysical Observation", "SAO 131383"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.74920583),
        dec: Angle.Degrees(-05.77361875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217928"},
        {"Hipparcos Number", "HIP 113926"},
        {"Smithsonian Astrophysical Observation", "SAO 146486"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.05568477),
        dec: Angle.Degrees(-05.77353014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121201"},
        {"Hipparcos Number", "HIP 67881"},
        {"Smithsonian Astrophysical Observation", "SAO 139610"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.54227543),
        dec: Angle.Degrees(-05.77321503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180976"},
        {"Hipparcos Number", "HIP 94908"},
        {"Smithsonian Astrophysical Observation", "SAO 143250"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.69663738),
        dec: Angle.Degrees(-05.77240176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17385"},
        {"Hipparcos Number", "HIP 13011"},
        {"Geneva Identification System", "GEN# +1.00017385"},
        {"Smithsonian Astrophysical Observation", "SAO 130112"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.80483805),
        dec: Angle.Degrees(-05.76902573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113328"},
        {"Hipparcos Number", "HIP 63674"},
        {"Renson", "Renson 32880"},
        {"Smithsonian Astrophysical Observation", "SAO 139119"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.74521625),
        dec: Angle.Degrees(-05.76772908)
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
    primaryId: "HIP 112598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215862"},
        {"Hipparcos Number", "HIP 112598"},
        {"Smithsonian Astrophysical Observation", "SAO 146322"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.07401720),
        dec: Angle.Degrees(-05.76743381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19486"},
        {"Hipparcos Number", "HIP 14546"},
        {"Smithsonian Astrophysical Observation", "SAO 130300"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.95383372),
        dec: Angle.Degrees(-05.76682738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2638"},
        {"Hipparcos Number", "HIP 2350"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.49972822),
        dec: Angle.Degrees(-05.76345720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -224.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103036"},
        {"Hipparcos Number", "HIP 57850"},
        {"Geneva Identification System", "GEN# +1.00103036"},
        {"Smithsonian Astrophysical Observation", "SAO 138451"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.95888206),
        dec: Angle.Degrees(-05.76215771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52671",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7922 AB"},
        {"Henry Draper", "HD 93294"},
        {"Hipparcos Number", "HIP 52671"},
        {"Smithsonian Astrophysical Observation", "SAO 137774"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.55304467),
        dec: Angle.Degrees(-05.76023758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58371",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58371"},
        {"Smithsonian Astrophysical Observation", "SAO 138509"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.53311505),
        dec: Angle.Degrees(-05.75804045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99190"},
        {"Smithsonian Astrophysical Observation", "SAO 144097"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.04998151),
        dec: Angle.Degrees(-05.75801042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29926"},
        {"Hipparcos Number", "HIP 21909"},
        {"Smithsonian Astrophysical Observation", "SAO 131422"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.66817754),
        dec: Angle.Degrees(-05.75725733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80632"},
        {"Hipparcos Number", "HIP 45839"},
        {"Geneva Identification System", "GEN# +1.00080632"},
        {"Smithsonian Astrophysical Observation", "SAO 136772"},
        {"Wilson Evans Batten Catalogue", "WEB 8692"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.18554873),
        dec: Angle.Degrees(-05.75369029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -364.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130585"},
        {"Hipparcos Number", "HIP 72465"},
        {"Geneva Identification System", "GEN# +1.00130585"},
        {"Smithsonian Astrophysical Observation", "SAO 140153"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.27446119),
        dec: Angle.Degrees(-05.75146399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71251"},
        {"Hipparcos Number", "HIP 41351"},
        {"Smithsonian Astrophysical Observation", "SAO 135909"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.54963277),
        dec: Angle.Degrees(-05.75113187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32147"},
        {"Hipparcos Number", "HIP 23311"},
        {"Cincinnati Publication", "Ci 20 312"},
        {"Cincinnati Publication 2", "Ci 18 648"},
        {"Geneva Identification System", "GEN# +1.00032147"},
        {"Smithsonian Astrophysical Observation", "SAO 131688"},
        {"Wilson Evans Batten Catalogue", "WEB 4529"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.20282168),
        dec: Angle.Degrees(-05.75097923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 550.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1109.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58872"},
    },
    visualMagnitude: 10.85,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.10977914),
        dec: Angle.Degrees(-05.74959033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31682"},
        {"Hipparcos Number", "HIP 23052"},
        {"Smithsonian Astrophysical Observation", "SAO 131631"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.40935090),
        dec: Angle.Degrees(-05.74867605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23053"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.41735626),
        dec: Angle.Degrees(-05.74858140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210988"},
        {"Hipparcos Number", "HIP 109783"},
        {"Geneva Identification System", "GEN# +1.00210988"},
        {"Smithsonian Astrophysical Observation", "SAO 145957"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.55915353),
        dec: Angle.Degrees(-05.74627955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20923"},
        {"Hipparcos Number", "HIP 15699"},
        {"Geneva Identification System", "GEN# +1.00020923"},
        {"Smithsonian Astrophysical Observation", "SAO 130447"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.56310419),
        dec: Angle.Degrees(-05.74579748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159170"},
        {"Hipparcos Number", "HIP 85922"},
        {"Fundamental Katalog 5th Edition", "FK5 3392"},
        {"Geneva Identification System", "GEN# +1.00159170"},
        {"Smithsonian Astrophysical Observation", "SAO 141730"},
        {"Wilson Evans Batten Catalogue", "WEB 14499"},
    },
    visualMagnitude: 5.61,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.37445668),
        dec: Angle.Degrees(-05.74457168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175518"},
        {"Hipparcos Number", "HIP 92918"},
        {"Cincinnati Publication", "Ci 20 1118"},
        {"Cincinnati Publication 2", "Ci 18 2471"},
        {"Geneva Identification System", "GEN# +1.00175518"},
        {"Smithsonian Astrophysical Observation", "SAO 142809"},
        {"Wilson Evans Batten Catalogue", "WEB 16088"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.97119525),
        dec: Angle.Degrees(-05.74427155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -200.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -388.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3107"},
        {"Hipparcos Number", "HIP 2699"},
        {"Smithsonian Astrophysical Observation", "SAO 128829"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.56549821),
        dec: Angle.Degrees(-05.74277284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110557"},
        {"Hipparcos Number", "HIP 62057"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.78657502),
        dec: Angle.Degrees(-05.73977911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 212.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125043"},
        {"Hipparcos Number", "HIP 69798"},
        {"Smithsonian Astrophysical Observation", "SAO 139840"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.27329249),
        dec: Angle.Degrees(-05.73934828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176678"},
        {"Hipparcos Number", "HIP 93429"},
        {"Geneva Identification System", "GEN# +1.00176678"},
        {"Smithsonian Astrophysical Observation", "SAO 142931"},
        {"Wilson Evans Batten Catalogue", "WEB 16214"},
    },
    visualMagnitude: 4.02,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.42017236),
        dec: Angle.Degrees(-05.73901832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17524"},
        {"Hipparcos Number", "HIP 13103"},
        {"Smithsonian Astrophysical Observation", "SAO 130123"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.12190379),
        dec: Angle.Degrees(-05.73840678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34003"},
        {"Geneva Identification System", "GEN# -0.00501935"},
        {"Wilson Evans Batten Catalogue", "WEB 6820"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.82619424),
        dec: Angle.Degrees(-05.73766834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54761"},
        {"Hipparcos Number", "HIP 34590"},
        {"Smithsonian Astrophysical Observation", "SAO 134275"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.47125915),
        dec: Angle.Degrees(-05.73576552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10116"},
        {"Hipparcos Number", "HIP 7669"},
        {"Geneva Identification System", "GEN# +1.00010116"},
        {"Smithsonian Astrophysical Observation", "SAO 129423"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.68680807),
        dec: Angle.Degrees(-05.73525633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164634"},
        {"Hipparcos Number", "HIP 88329"},
        {"Geneva Identification System", "GEN# +1.00164634"},
        {"Smithsonian Astrophysical Observation", "SAO 142042"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.59517178),
        dec: Angle.Degrees(-05.73524306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139344"},
        {"Hipparcos Number", "HIP 76526"},
        {"Geneva Identification System", "GEN# +1.00139344"},
        {"Smithsonian Astrophysical Observation", "SAO 140662"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.43540976),
        dec: Angle.Degrees(-05.73518280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10824"},
        {"Hipparcos Number", "HIP 8230"},
        {"Fundamental Katalog 5th Edition", "FK5 2117"},
        {"Geneva Identification System", "GEN# +1.00010824"},
        {"Smithsonian Astrophysical Observation", "SAO 129490"},
        {"Wilson Evans Batten Catalogue", "WEB 1751"},
    },
    visualMagnitude: 5.37,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.49694074),
        dec: Angle.Degrees(-05.73322696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59109"},
        {"Geneva Identification System", "GEN# -0.00403208"},
        {"Wilson Evans Batten Catalogue", "WEB 10521"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.81348477),
        dec: Angle.Degrees(-05.73322651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -278.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -228.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214998"},
        {"Hipparcos Number", "HIP 112095"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.57147497),
        dec: Angle.Degrees(-05.73316341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 206.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142300"},
        {"Hipparcos Number", "HIP 77864"},
        {"Geneva Identification System", "GEN# +1.00142300"},
        {"Smithsonian Astrophysical Observation", "SAO 140827"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.48939224),
        dec: Angle.Degrees(-05.73187497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20356"},
        {"Hipparcos Number", "HIP 15230"},
        {"Smithsonian Astrophysical Observation", "SAO 130391"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.09046225),
        dec: Angle.Degrees(-05.73041469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217700"},
        {"Hipparcos Number", "HIP 113791"},
        {"Smithsonian Astrophysical Observation", "SAO 146466"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.65743986),
        dec: Angle.Degrees(-05.72905668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170547"},
        {"Hipparcos Number", "HIP 90692"},
        {"Fundamental Katalog 5th Edition", "FK5 3468"},
        {"Geneva Identification System", "GEN# +1.00170547"},
        {"Smithsonian Astrophysical Observation", "SAO 142353"},
        {"Wilson Evans Batten Catalogue", "WEB 15536"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.55957304),
        dec: Angle.Degrees(-05.72412820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52666"},
        {"Hipparcos Number", "HIP 33878"},
        {"Geneva Identification System", "GEN# +1.00052666"},
        {"Smithsonian Astrophysical Observation", "SAO 134076"},
        {"Wilson Evans Batten Catalogue", "WEB 6803"},
    },
    visualMagnitude: 5.22,
    bvColour: 1.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.48497076),
        dec: Angle.Degrees(-05.72208135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98750"},
        {"Hipparcos Number", "HIP 55482"},
        {"Geneva Identification System", "GEN# +1.00098750"},
        {"Smithsonian Astrophysical Observation", "SAO 138156"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.44543816),
        dec: Angle.Degrees(-05.71847442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34151"},
        {"Hipparcos Number", "HIP 24462"},
        {"Smithsonian Astrophysical Observation", "SAO 131913"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.73860253),
        dec: Angle.Degrees(-05.71764081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48475"},
        {"Hipparcos Number", "HIP 32210"},
        {"Smithsonian Astrophysical Observation", "SAO 133614"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.85084877),
        dec: Angle.Degrees(-05.71702637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59676",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8471 A"},
        {"Henry Draper", "HD 106384"},
        {"Hipparcos Number", "HIP 59676"},
        {"Geneva Identification System", "GEN# +1.00106384A"},
        {"Renson", "Renson 30800"},
        {"Smithsonian Astrophysical Observation", "SAO 138664"},
        {"Wilson Evans Batten Catalogue", "WEB 10605"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.56460983),
        dec: Angle.Degrees(-05.71687601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 114.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42278"},
        {"Hipparcos Number", "HIP 29210"},
        {"Geneva Identification System", "GEN# +1.00042278"},
        {"Smithsonian Astrophysical Observation", "SAO 132900"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.40089482),
        dec: Angle.Degrees(-05.71143334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12691"},
        {"Hipparcos Number", "HIP 9658"},
        {"Smithsonian Astrophysical Observation", "SAO 129675"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.06099623),
        dec: Angle.Degrees(-05.71098336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152630"},
        {"Hipparcos Number", "HIP 82744"},
        {"Smithsonian Astrophysical Observation", "SAO 141433"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.67881832),
        dec: Angle.Degrees(-05.71033282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28"},
        {"Hipparcos Number", "HIP 443"},
        {"Fundamental Katalog 5th Edition", "FK5 1002"},
        {"Geneva Identification System", "GEN# +1.00000028"},
        {"Smithsonian Astrophysical Observation", "SAO 128572"},
        {"Wilson Evans Batten Catalogue", "WEB 69"},
    },
    visualMagnitude: 4.61,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.33394073),
        dec: Angle.Degrees(-05.70783255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14876",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14876"},
        {"Smithsonian Astrophysical Observation", "SAO 130343"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.01060980),
        dec: Angle.Degrees(-05.70714909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78999",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78999"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.89259238),
        dec: Angle.Degrees(-05.70677937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32394"},
        {"Hipparcos Number", "HIP 23470"},
        {"Smithsonian Astrophysical Observation", "SAO 131716"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.68321897),
        dec: Angle.Degrees(-05.70610460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173819"},
        {"Hipparcos Number", "HIP 92202"},
        {"Geneva Identification System", "GEN# +1.00173819"},
        {"Smithsonian Astrophysical Observation", "SAO 142620"},
        {"Wilson Evans Batten Catalogue", "WEB 15903"},
    },
    visualMagnitude: 5.38,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.87073367),
        dec: Angle.Degrees(-05.70507074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39647"},
        {"Hipparcos Number", "HIP 27861"},
        {"Celescope Catalog", "CEL 1023"},
        {"Geneva Identification System", "GEN# +1.00039647"},
        {"Smithsonian Astrophysical Observation", "SAO 132622"},
    },
    visualMagnitude: 7.09,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.42360734),
        dec: Angle.Degrees(-05.70470841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40362",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40362"},
        {"Geneva Identification System", "GEN# +2.25481628"},
        {"New General Catalogue", "NGC 2548 1628"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.61719420),
        dec: Angle.Degrees(-05.70448868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36412"},
        {"Hipparcos Number", "HIP 25863"},
        {"Geneva Identification System", "GEN# +1.00036412"},
        {"Renson", "Renson 9410"},
        {"Smithsonian Astrophysical Observation", "SAO 132209"},
        {"Wilson Evans Batten Catalogue", "WEB 5022"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.82669225),
        dec: Angle.Degrees(-05.70375860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145054"},
        {"Hipparcos Number", "HIP 79129"},
        {"Smithsonian Astrophysical Observation", "SAO 140991"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.27384385),
        dec: Angle.Degrees(-05.70357310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9049"},
        {"Hipparcos Number", "HIP 6912"},
        {"Smithsonian Astrophysical Observation", "SAO 129319"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.25593759),
        dec: Angle.Degrees(-05.70089159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77030",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9759 AB"},
        {"Hipparcos Number", "HIP 77030"},
        {"Smithsonian Astrophysical Observation", "SAO 140720"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.91876859),
        dec: Angle.Degrees(-05.69936698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14255",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14255"},
        {"Smithsonian Astrophysical Observation", "SAO 130264"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.95359502),
        dec: Angle.Degrees(-05.69915418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218399"},
        {"Hipparcos Number", "HIP 114218"},
        {"Fundamental Katalog 5th Edition", "FK5 6044"},
        {"Smithsonian Astrophysical Observation", "SAO 146522"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.96120084),
        dec: Angle.Degrees(-05.69763653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138763"},
        {"Hipparcos Number", "HIP 76233"},
        {"Fundamental Katalog 5th Edition", "FK5 3227"},
        {"Geneva Identification System", "GEN# +1.00138763"},
        {"Smithsonian Astrophysical Observation", "SAO 140613"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.58692775),
        dec: Angle.Degrees(-05.69510689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75408"},
        {"Hipparcos Number", "HIP 43336"},
        {"Geneva Identification System", "GEN# +1.00075408"},
        {"Smithsonian Astrophysical Observation", "SAO 136315"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.42942661),
        dec: Angle.Degrees(-05.69443558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209444"},
        {"Hipparcos Number", "HIP 108895"},
        {"Smithsonian Astrophysical Observation", "SAO 145838"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.87517066),
        dec: Angle.Degrees(-05.69265859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179846"},
        {"Hipparcos Number", "HIP 94529"},
        {"Smithsonian Astrophysical Observation", "SAO 143167"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.58677040),
        dec: Angle.Degrees(-05.69235880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77768",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77768"},
        {"Smithsonian Astrophysical Observation", "SAO 140815"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.18871471),
        dec: Angle.Degrees(-05.69108269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95468"},
        {"Hipparcos Number", "HIP 53862"},
        {"Smithsonian Astrophysical Observation", "SAO 137938"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.28531662),
        dec: Angle.Degrees(-05.69050596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27974"},
        {"Hipparcos Number", "HIP 20602"},
        {"Geneva Identification System", "GEN# +1.00027974"},
        {"Smithsonian Astrophysical Observation", "SAO 131190"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.18502755),
        dec: Angle.Degrees(-05.69012507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216725"},
        {"Hipparcos Number", "HIP 113192"},
        {"Smithsonian Astrophysical Observation", "SAO 146389"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.83838556),
        dec: Angle.Degrees(-05.68966122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150936"},
        {"Hipparcos Number", "HIP 81952"},
        {"Geneva Identification System", "GEN# +1.00150936"},
        {"Smithsonian Astrophysical Observation", "SAO 141336"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.11121189),
        dec: Angle.Degrees(-05.68723623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217076"},
        {"Hipparcos Number", "HIP 113416"},
        {"Geneva Identification System", "GEN# +1.00217076"},
        {"Smithsonian Astrophysical Observation", "SAO 146411"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.53979803),
        dec: Angle.Degrees(-05.68555232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177336"},
        {"Hipparcos Number", "HIP 93666"},
        {"Geneva Identification System", "GEN# +1.00177336"},
        {"Smithsonian Astrophysical Observation", "SAO 142985"},
        {"Wilson Evans Batten Catalogue", "WEB 16274"},
    },
    visualMagnitude: 6.48,
    bvColour: 2.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.10063233),
        dec: Angle.Degrees(-05.68484308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83393",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83393"},
        {"Smithsonian Astrophysical Observation", "SAO 141498"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.65859050),
        dec: Angle.Degrees(-05.68419685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82961"},
        {"Smithsonian Astrophysical Observation", "SAO 141454"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.30133279),
        dec: Angle.Degrees(-05.68228123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22995"},
        {"Hipparcos Number", "HIP 17218"},
        {"Smithsonian Astrophysical Observation", "SAO 130664"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.31857592),
        dec: Angle.Degrees(-05.68093712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28491"},
        {"Hipparcos Number", "HIP 20932"},
        {"Smithsonian Astrophysical Observation", "SAO 131240"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.32984837),
        dec: Angle.Degrees(-05.68047460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223687"},
        {"Hipparcos Number", "HIP 117662"},
        {"Smithsonian Astrophysical Observation", "SAO 146940"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.93932017),
        dec: Angle.Degrees(-05.68044496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70859"},
        {"Hipparcos Number", "HIP 41179"},
        {"Smithsonian Astrophysical Observation", "SAO 135871"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.04885104),
        dec: Angle.Degrees(-05.67926151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147450"},
        {"Hipparcos Number", "HIP 80191"},
        {"Smithsonian Astrophysical Observation", "SAO 141123"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.57132304),
        dec: Angle.Degrees(-05.67865146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62834"},
        {"Hipparcos Number", "HIP 37864"},
        {"Smithsonian Astrophysical Observation", "SAO 135074"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.42838011),
        dec: Angle.Degrees(-05.67848866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193915"},
        {"Hipparcos Number", "HIP 100520"},
        {"Smithsonian Astrophysical Observation", "SAO 144363"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.74800135),
        dec: Angle.Degrees(-05.67554003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90527"},
        {"Hipparcos Number", "HIP 51156"},
        {"Smithsonian Astrophysical Observation", "SAO 137569"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.74546990),
        dec: Angle.Degrees(-05.67512494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217145"},
        {"Hipparcos Number", "HIP 113451"},
        {"Smithsonian Astrophysical Observation", "SAO 146419"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.64838956),
        dec: Angle.Degrees(-05.67389133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30562"},
        {"Hipparcos Number", "HIP 22336"},
        {"Geneva Identification System", "GEN# +1.00030562"},
        {"Smithsonian Astrophysical Observation", "SAO 131504"},
        {"Wilson Evans Batten Catalogue", "WEB 4304"},
    },
    visualMagnitude: 5.77,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.15084320),
        dec: Angle.Degrees(-05.67343877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 312.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -249.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61439"},
        {"Hipparcos Number", "HIP 37260"},
        {"Smithsonian Astrophysical Observation", "SAO 134941"},
    },
    visualMagnitude: 9.20,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.77777686),
        dec: Angle.Degrees(-05.66992112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115247"},
        {"Hipparcos Number", "HIP 64732"},
        {"Geneva Identification System", "GEN# +1.00115247"},
        {"Smithsonian Astrophysical Observation", "SAO 139251"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.01312072),
        dec: Angle.Degrees(-05.66862410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16151"},
        {"Hipparcos Number", "HIP 12063"},
        {"Smithsonian Astrophysical Observation", "SAO 129996"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.88824597),
        dec: Angle.Degrees(-05.66797482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116227"},
        {"Smithsonian Astrophysical Observation", "SAO 146766"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.23365502),
        dec: Angle.Degrees(-05.66759284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122388"},
        {"Hipparcos Number", "HIP 68524"},
        {"Smithsonian Astrophysical Observation", "SAO 139687"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.43208085),
        dec: Angle.Degrees(-05.66637201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175706"},
        {"Hipparcos Number", "HIP 93006"},
        {"Renson", "Renson 49065"},
        {"Smithsonian Astrophysical Observation", "SAO 142832"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.20103020),
        dec: Angle.Degrees(-05.66570084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19034"},
        {"Hipparcos Number", "HIP 14241"},
        {"Cincinnati Publication", "Ci 20 204"},
        {"Geneva Identification System", "GEN# +1.00019034"},
        {"Smithsonian Astrophysical Observation", "SAO 130263"},
        {"Wilson Evans Batten Catalogue", "WEB 2790"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.91151475),
        dec: Angle.Degrees(-05.66565632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 333.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -264.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116013"},
        {"Hipparcos Number", "HIP 65148"},
        {"Smithsonian Astrophysical Observation", "SAO 139292"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.25251254),
        dec: Angle.Degrees(-05.66554153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21602"},
        {"Hipparcos Number", "HIP 16229"},
        {"Smithsonian Astrophysical Observation", "SAO 130514"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.26976771),
        dec: Angle.Degrees(-05.66526598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82268"},
        {"Hipparcos Number", "HIP 46669"},
        {"Smithsonian Astrophysical Observation", "SAO 136913"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.72976928),
        dec: Angle.Degrees(-05.66159212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117904"},
        {"Hipparcos Number", "HIP 66143"},
        {"Geneva Identification System", "GEN# +1.00117904"},
        {"Smithsonian Astrophysical Observation", "SAO 139409"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.37578088),
        dec: Angle.Degrees(-05.66128635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34596"},
        {"Hipparcos Number", "HIP 24749"},
        {"Smithsonian Astrophysical Observation", "SAO 131967"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.60611714),
        dec: Angle.Degrees(-05.66070587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129502"},
        {"Hipparcos Number", "HIP 71957"},
        {"Fundamental Katalog 5th Edition", "FK5 545"},
        {"Geneva Identification System", "GEN# +1.00129502"},
        {"Smithsonian Astrophysical Observation", "SAO 140090"},
        {"Wilson Evans Batten Catalogue", "WEB 12388"},
    },
    visualMagnitude: 3.87,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.76484284),
        dec: Angle.Degrees(-05.65742910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -319.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75593",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9636 AB"},
        {"Henry Draper", "HD 137512"},
        {"Hipparcos Number", "HIP 75593"},
        {"Smithsonian Astrophysical Observation", "SAO 140532"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.65993664),
        dec: Angle.Degrees(-05.65562460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214887"},
        {"Hipparcos Number", "HIP 112019"},
        {"Smithsonian Astrophysical Observation", "SAO 146245"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.35212990),
        dec: Angle.Degrees(-05.65534053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29951",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4910 AB"},
        {"Henry Draper", "HD 43857"},
        {"Hipparcos Number", "HIP 29951"},
        {"Smithsonian Astrophysical Observation", "SAO 133078"},
    },
    visualMagnitude: 6.88,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.57258645),
        dec: Angle.Degrees(-05.65433077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194794"},
        {"Hipparcos Number", "HIP 100926"},
        {"Smithsonian Astrophysical Observation", "SAO 144454"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.94222318),
        dec: Angle.Degrees(-05.65421065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166160"},
        {"Hipparcos Number", "HIP 88969"},
        {"Geneva Identification System", "GEN# +1.00166160"},
        {"Smithsonian Astrophysical Observation", "SAO 142125"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.40257763),
        dec: Angle.Degrees(-05.65349804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28037"},
        {"Hipparcos Number", "HIP 20628"},
        {"Geneva Identification System", "GEN# +1.00028037"},
        {"Smithsonian Astrophysical Observation", "SAO 131197"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.32286082),
        dec: Angle.Degrees(-05.65213402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68592",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68592"},
        {"Geneva Identification System", "GEN# +9.80064037"},
        {"Renson", "Renson 35133"},
        {"Wilson Evans Batten Catalogue", "WEB 12013"},
    },
    visualMagnitude: 11.13,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.62550880),
        dec: Angle.Degrees(-05.65047694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -399.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37150"},
        {"Hipparcos Number", "HIP 26314"},
        {"Celescope Catalog", "CEL 855"},
        {"Geneva Identification System", "GEN# +9.00010980"},
        {"Geneva Identification System 2", "GEN# +2.19760980"},
        {"Smithsonian Astrophysical Observation", "SAO 132351"},
        {"Wilson Evans Batten Catalogue", "WEB 5175"},
    },
    visualMagnitude: 6.56,
    bvColour: -0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.06261308),
        dec: Angle.Degrees(-05.64792024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101453",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101453"},
    },
    visualMagnitude: 13.22,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.42573501),
        dec: Angle.Degrees(-05.64701379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186081"},
        {"Hipparcos Number", "HIP 96960"},
        {"Smithsonian Astrophysical Observation", "SAO 143716"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.64291864),
        dec: Angle.Degrees(-05.64584714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35718"},
        {"Hipparcos Number", "HIP 25442"},
        {"Geneva Identification System", "GEN# +1.00035718"},
        {"Smithsonian Astrophysical Observation", "SAO 132106"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.62026939),
        dec: Angle.Degrees(-05.64568209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50251"},
        {"Hipparcos Number", "HIP 32979"},
        {"Smithsonian Astrophysical Observation", "SAO 133799"},
    },
    visualMagnitude: 7.28,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.05061240),
        dec: Angle.Degrees(-05.64539322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124988"},
        {"Hipparcos Number", "HIP 69775"},
        {"Geneva Identification System", "GEN# +1.00124988"},
        {"Smithsonian Astrophysical Observation", "SAO 139835"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.20600506),
        dec: Angle.Degrees(-05.64400978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68646"},
        {"Hipparcos Number", "HIP 40238"},
        {"Geneva Identification System", "GEN# +2.25481005"},
        {"Smithsonian Astrophysical Observation", "SAO 135639"},
        {"New General Catalogue", "NGC 2548 1005"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.28563891),
        dec: Angle.Degrees(-05.64326298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4374"},
        {"Hipparcos Number", "HIP 3600"},
        {"Geneva Identification System", "GEN# +1.00004374"},
        {"Smithsonian Astrophysical Observation", "SAO 128943"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.53170538),
        dec: Angle.Degrees(-05.64273765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 234.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13441"},
        {"Hipparcos Number", "HIP 10208"},
        {"Smithsonian Astrophysical Observation", "SAO 129736"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.82883944),
        dec: Angle.Degrees(-05.64234516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68669"},
        {"Hipparcos Number", "HIP 40254"},
        {"Geneva Identification System", "GEN# +2.25481073"},
        {"Smithsonian Astrophysical Observation", "SAO 135644"},
        {"New General Catalogue", "NGC 2548 1073"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.32512148),
        dec: Angle.Degrees(-05.64067233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206447"},
        {"Hipparcos Number", "HIP 107158"},
        {"Smithsonian Astrophysical Observation", "SAO 145599"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.58647322),
        dec: Angle.Degrees(-05.63963295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158299"},
        {"Hipparcos Number", "HIP 85527"},
        {"Fundamental Katalog 5th Edition", "FK5 5539"},
        {"Smithsonian Astrophysical Observation", "SAO 141682"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.17791826),
        dec: Angle.Degrees(-05.63910987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11945",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1953 AB"},
        {"Henry Draper", "HD 15994"},
        {"Hipparcos Number", "HIP 11945"},
        {"Geneva Identification System", "GEN# +1.00015994J"},
        {"Smithsonian Astrophysical Observation", "SAO 129981"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.53116904),
        dec: Angle.Degrees(-05.63546659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176076"},
        {"Hipparcos Number", "HIP 93180"},
        {"Smithsonian Astrophysical Observation", "SAO 142865"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.69708824),
        dec: Angle.Degrees(-05.63484256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2566"},
        {"Hipparcos Number", "HIP 2298"},
        {"Smithsonian Astrophysical Observation", "SAO 128782"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.33007966),
        dec: Angle.Degrees(-05.63393904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203486"},
        {"Hipparcos Number", "HIP 105550"},
        {"Smithsonian Astrophysical Observation", "SAO 145344"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.65425313),
        dec: Angle.Degrees(-05.63325176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139897"},
        {"Hipparcos Number", "HIP 76798"},
        {"Smithsonian Astrophysical Observation", "SAO 140695"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.21041192),
        dec: Angle.Degrees(-05.63290600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7775"},
        {"Hipparcos Number", "HIP 6022"},
        {"Geneva Identification System", "GEN# +1.00007775"},
        {"Smithsonian Astrophysical Observation", "SAO 129211"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.34459814),
        dec: Angle.Degrees(-05.63250837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19814",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19814"},
        {"Geneva Identification System", "GEN# -0.00600855"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.74055357),
        dec: Angle.Degrees(-05.63069835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 592.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 197.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21838"},
        {"Hipparcos Number", "HIP 16379"},
        {"Geneva Identification System", "GEN# +1.00021838"},
        {"Smithsonian Astrophysical Observation", "SAO 130538"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.75496196),
        dec: Angle.Degrees(-05.63015225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165966"},
        {"Hipparcos Number", "HIP 88892"},
        {"Smithsonian Astrophysical Observation", "SAO 142116"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.19849528),
        dec: Angle.Degrees(-05.62892553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102945",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14360 AB"},
        {"Aitken 2", "ADS 14360"},
        {"Henry Draper", "HD 198571"},
        {"Hipparcos Number", "HIP 102945"},
        {"Geneva Identification System", "GEN# +1.00198571"},
        {"Smithsonian Astrophysical Observation", "SAO 144877"},
        {"Wilson Evans Batten Catalogue", "WEB 18675"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.85705076),
        dec: Angle.Degrees(-05.62663580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4206"},
        {"Hipparcos Number", "HIP 3486"},
        {"Smithsonian Astrophysical Observation", "SAO 128929"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.12758144),
        dec: Angle.Degrees(-05.62632142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22713"},
        {"Hipparcos Number", "HIP 17027"},
        {"Geneva Identification System", "GEN# +1.00022713"},
        {"Smithsonian Astrophysical Observation", "SAO 130634"},
        {"Wilson Evans Batten Catalogue", "WEB 3237"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.75469049),
        dec: Angle.Degrees(-05.62570656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134251"},
        {"Hipparcos Number", "HIP 74126"},
        {"Geneva Identification System", "GEN# +1.00134251"},
        {"Smithsonian Astrophysical Observation", "SAO 140345"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.23189398),
        dec: Angle.Degrees(-05.62509320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100285"},
        {"Hipparcos Number", "HIP 56295"},
        {"Smithsonian Astrophysical Observation", "SAO 138257"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.09960440),
        dec: Angle.Degrees(-05.62487932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166662"},
        {"Hipparcos Number", "HIP 89174"},
        {"Smithsonian Astrophysical Observation", "SAO 142146"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.98125225),
        dec: Angle.Degrees(-05.62399909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68778"},
        {"Hipparcos Number", "HIP 40302"},
        {"Geneva Identification System", "GEN# +2.25481320"},
        {"Smithsonian Astrophysical Observation", "SAO 135656"},
        {"New General Catalogue", "NGC 2548 1320"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.44881955),
        dec: Angle.Degrees(-05.62386427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72935",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72935"},
        {"Smithsonian Astrophysical Observation", "SAO 140211"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.59682833),
        dec: Angle.Degrees(-05.62188273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204343"},
        {"Hipparcos Number", "HIP 105994"},
        {"Geneva Identification System", "GEN# +1.00204343"},
        {"Smithsonian Astrophysical Observation", "SAO 145418"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.00863939),
        dec: Angle.Degrees(-05.61983172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5131"},
        {"Hipparcos Number", "HIP 4156"},
        {"Smithsonian Astrophysical Observation", "SAO 129011"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.27575290),
        dec: Angle.Degrees(-05.61981818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69965"},
        {"Hipparcos Number", "HIP 40765"},
        {"Geneva Identification System", "GEN# +1.00069965"},
        {"Smithsonian Astrophysical Observation", "SAO 135771"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.81290348),
        dec: Angle.Degrees(-05.61961414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87144"},
        {"Hipparcos Number", "HIP 49231"},
        {"Smithsonian Astrophysical Observation", "SAO 137315"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.73504689),
        dec: Angle.Degrees(-05.61788637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42228"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.15296769),
        dec: Angle.Degrees(-05.61449370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49226"},
        {"Hipparcos Number", "HIP 32524"},
        {"Smithsonian Astrophysical Observation", "SAO 133669"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.80597375),
        dec: Angle.Degrees(-05.61377253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165317"},
        {"Hipparcos Number", "HIP 88623"},
        {"Smithsonian Astrophysical Observation", "SAO 142078"},
    },
    visualMagnitude: 9.55,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.41789362),
        dec: Angle.Degrees(-05.61330413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74093"},
        {"Hipparcos Number", "HIP 42674"},
        {"Smithsonian Astrophysical Observation", "SAO 136187"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.45955494),
        dec: Angle.Degrees(-05.61073381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17953"},
        {"Hipparcos Number", "HIP 13435"},
        {"Smithsonian Astrophysical Observation", "SAO 130161"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.24317720),
        dec: Angle.Degrees(-05.61071199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136676"},
        {"Hipparcos Number", "HIP 75211"},
        {"Smithsonian Astrophysical Observation", "SAO 140489"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.54842051),
        dec: Angle.Degrees(-05.60513852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82803"},
        {"Hipparcos Number", "HIP 46951"},
        {"Smithsonian Astrophysical Observation", "SAO 136959"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.55378632),
        dec: Angle.Degrees(-05.60344372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169801"},
        {"Hipparcos Number", "HIP 90390"},
        {"Geneva Identification System", "GEN# +1.00169801"},
        {"Smithsonian Astrophysical Observation", "SAO 142318"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.65481055),
        dec: Angle.Degrees(-05.60185529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1153"},
        {"Hipparcos Number", "HIP 1265"},
        {"Smithsonian Astrophysical Observation", "SAO 128668"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.96507474),
        dec: Angle.Degrees(-05.60120129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120169"},
        {"Hipparcos Number", "HIP 67323"},
        {"Smithsonian Astrophysical Observation", "SAO 139553"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.98522098),
        dec: Angle.Degrees(-05.59793598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181638"},
        {"Hipparcos Number", "HIP 95141"},
        {"Smithsonian Astrophysical Observation", "SAO 143305"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.34968742),
        dec: Angle.Degrees(-05.59775692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184888"},
        {"Hipparcos Number", "HIP 96463"},
        {"Smithsonian Astrophysical Observation", "SAO 143595"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.17427196),
        dec: Angle.Degrees(-05.59650219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9139"},
        {"Hipparcos Number", "HIP 6984"},
        {"Geneva Identification System", "GEN# +1.00009139"},
        {"Smithsonian Astrophysical Observation", "SAO 129331"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.47358565),
        dec: Angle.Degrees(-05.59586087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215887"},
        {"Hipparcos Number", "HIP 112621"},
        {"Smithsonian Astrophysical Observation", "SAO 146326"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.13679223),
        dec: Angle.Degrees(-05.59349833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -186.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60727",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8551 AB"},
        {"Henry Draper", "HD 108320"},
        {"Hipparcos Number", "HIP 60727"},
        {"Smithsonian Astrophysical Observation", "SAO 138781"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.69882227),
        dec: Angle.Degrees(-05.59212340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13990",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13990"},
        {"Smithsonian Astrophysical Observation", "SAO 130234"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.03727869),
        dec: Angle.Degrees(-05.59071864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197451"},
        {"Hipparcos Number", "HIP 102329"},
        {"Geneva Identification System", "GEN# +1.00197451"},
        {"Renson", "Renson 55040"},
        {"Smithsonian Astrophysical Observation", "SAO 144743"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.98732850),
        dec: Angle.Degrees(-05.59021632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96461"},
        {"Hipparcos Number", "HIP 54340"},
        {"Smithsonian Astrophysical Observation", "SAO 137990"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.73509915),
        dec: Angle.Degrees(-05.58804626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22421"},
        {"Hipparcos Number", "HIP 16801"},
        {"Geneva Identification System", "GEN# +1.00022421"},
        {"Smithsonian Astrophysical Observation", "SAO 130602"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.06504188),
        dec: Angle.Degrees(-05.58735563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107766"},
        {"Hipparcos Number", "HIP 60399"},
        {"Smithsonian Astrophysical Observation", "SAO 138745"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.75578190),
        dec: Angle.Degrees(-05.58651876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109874",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15777 AB"},
        {"Henry Draper", "HD 211140"},
        {"Hipparcos Number", "HIP 109874"},
        {"Smithsonian Astrophysical Observation", "SAO 145973"},
        {"Wilson Evans Batten Catalogue", "WEB 19728"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.80146220),
        dec: Angle.Degrees(-05.58491002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59882"},
        {"Hipparcos Number", "HIP 36615"},
        {"Geneva Identification System", "GEN# +1.00059882"},
        {"Smithsonian Astrophysical Observation", "SAO 134791"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.94880416),
        dec: Angle.Degrees(-05.58319808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144389"},
        {"Hipparcos Number", "HIP 78865"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.47554748),
        dec: Angle.Degrees(-05.58200409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201322"},
        {"Hipparcos Number", "HIP 104395"},
        {"Smithsonian Astrophysical Observation", "SAO 145145"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.23938417),
        dec: Angle.Degrees(-05.58175134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203826"},
        {"Hipparcos Number", "HIP 105717"},
        {"Smithsonian Astrophysical Observation", "SAO 145375"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.17835227),
        dec: Angle.Degrees(-05.58121049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145499"},
        {"Hipparcos Number", "HIP 79342"},
        {"Smithsonian Astrophysical Observation", "SAO 141020"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.88729036),
        dec: Angle.Degrees(-05.58105886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19621"},
        {"Smithsonian Astrophysical Observation", "SAO 131024"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.06043667),
        dec: Angle.Degrees(-05.57661457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167244"},
        {"Hipparcos Number", "HIP 89391"},
        {"Smithsonian Astrophysical Observation", "SAO 142173"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.62443769),
        dec: Angle.Degrees(-05.57563538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115341"},
        {"Hipparcos Number", "HIP 64783"},
        {"Geneva Identification System", "GEN# +1.00115341"},
        {"Smithsonian Astrophysical Observation", "SAO 139256"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.16699438),
        dec: Angle.Degrees(-05.57338834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45762"},
        {"Hipparcos Number", "HIP 30891"},
        {"Smithsonian Astrophysical Observation", "SAO 133321"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.26941424),
        dec: Angle.Degrees(-05.57232654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131498"},
        {"Hipparcos Number", "HIP 72902"},
        {"Smithsonian Astrophysical Observation", "SAO 140210"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.50317506),
        dec: Angle.Degrees(-05.57146282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106278",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Sadalsuud"},
        {"Aitken", "ADS 15050 A"},
        {"Henry Draper", "HD 204867"},
        {"Hipparcos Number", "HIP 106278"},
        {"Fundamental Katalog 5th Edition", "FK5 808"},
        {"Geneva Identification System", "GEN# +1.00204867"},
        {"Smithsonian Astrophysical Observation", "SAO 145457"},
        {"Wilson Evans Batten Catalogue", "WEB 19252"},
    },
    visualMagnitude: 2.90,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.88966951),
        dec: Angle.Degrees(-05.57115593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57652"},
        {"Hipparcos Number", "HIP 35705"},
        {"Smithsonian Astrophysical Observation", "SAO 134577"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.50756290),
        dec: Angle.Degrees(-05.57065364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3296"},
        {"Hipparcos Number", "HIP 2843"},
        {"Geneva Identification System", "GEN# +1.00003296"},
        {"Smithsonian Astrophysical Observation", "SAO 128852"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.00717370),
        dec: Angle.Degrees(-05.57045671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 225.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201099"},
        {"Hipparcos Number", "HIP 104294"},
        {"Geneva Identification System", "GEN# +1.00201099"},
        {"Smithsonian Astrophysical Observation", "SAO 145122"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.93216234),
        dec: Angle.Degrees(-05.56643033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 205.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 224.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87764"},
        {"Hipparcos Number", "HIP 49557"},
        {"Smithsonian Astrophysical Observation", "SAO 137357"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.77440343),
        dec: Angle.Degrees(-05.56622579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78304"},
        {"Smithsonian Astrophysical Observation", "SAO 140879"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.83273711),
        dec: Angle.Degrees(-05.56048522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177067"},
        {"Hipparcos Number", "HIP 93551"},
        {"Geneva Identification System", "GEN# +1.00177067"},
        {"Smithsonian Astrophysical Observation", "SAO 142963"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.82342051),
        dec: Angle.Degrees(-05.55905555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211019"},
        {"Hipparcos Number", "HIP 109791"},
        {"Smithsonian Astrophysical Observation", "SAO 145959"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.58060895),
        dec: Angle.Degrees(-05.55869179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27581"},
        {"Hipparcos Number", "HIP 20307"},
        {"Smithsonian Astrophysical Observation", "SAO 131138"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.26502778),
        dec: Angle.Degrees(-05.55813506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21632"},
        {"Hipparcos Number", "HIP 16248"},
        {"Smithsonian Astrophysical Observation", "SAO 130518"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.35359274),
        dec: Angle.Degrees(-05.55471339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223439"},
        {"Hipparcos Number", "HIP 117495"},
        {"Geneva Identification System", "GEN# +1.00223439"},
        {"Smithsonian Astrophysical Observation", "SAO 146928"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.38580684),
        dec: Angle.Degrees(-05.55296980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202307"},
        {"Hipparcos Number", "HIP 104910"},
        {"Smithsonian Astrophysical Observation", "SAO 145235"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.76591585),
        dec: Angle.Degrees(-05.55178771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187903"},
        {"Hipparcos Number", "HIP 97820"},
        {"Smithsonian Astrophysical Observation", "SAO 143871"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.16430445),
        dec: Angle.Degrees(-05.55152748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94690"},
        {"Hipparcos Number", "HIP 53424"},
        {"Geneva Identification System", "GEN# +1.00094690"},
        {"Smithsonian Astrophysical Observation", "SAO 137891"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.93098324),
        dec: Angle.Degrees(-05.55142851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114960",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114960"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.26778178),
        dec: Angle.Degrees(-05.55049943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -281.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30223"},
        {"Hipparcos Number", "HIP 22111"},
        {"Smithsonian Astrophysical Observation", "SAO 131469"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.38470130),
        dec: Angle.Degrees(-05.55036973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200864"},
        {"Hipparcos Number", "HIP 104165"},
        {"Smithsonian Astrophysical Observation", "SAO 145096"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.57679535),
        dec: Angle.Degrees(-05.54994835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128594"},
        {"Hipparcos Number", "HIP 71535"},
        {"Smithsonian Astrophysical Observation", "SAO 140041"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.47061447),
        dec: Angle.Degrees(-05.54862575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222358"},
        {"Hipparcos Number", "HIP 116762"},
        {"Smithsonian Astrophysical Observation", "SAO 146834"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.96077990),
        dec: Angle.Degrees(-05.54674004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92726",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11791 AB"},
        {"Henry Draper", "HD 175039"},
        {"Hipparcos Number", "HIP 92726"},
        {"Geneva Identification System", "GEN# +1.00175039J"},
        {"Smithsonian Astrophysical Observation", "SAO 142763"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.42426538),
        dec: Angle.Degrees(-05.54381405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9271"},
        {"Hipparcos Number", "HIP 7070"},
        {"Smithsonian Astrophysical Observation", "SAO 129343"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.78469315),
        dec: Angle.Degrees(-05.54329744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40474"},
        {"Hipparcos Number", "HIP 28295"},
        {"Smithsonian Astrophysical Observation", "SAO 132710"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.70577373),
        dec: Angle.Degrees(-05.54256017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188007"},
        {"Hipparcos Number", "HIP 97866"},
        {"Geneva Identification System", "GEN# +1.00188007"},
        {"Smithsonian Astrophysical Observation", "SAO 143880"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.30727402),
        dec: Angle.Degrees(-05.54018318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64238",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8801 A"},
        {"Henry Draper", "HD 114330"},
        {"Hipparcos Number", "HIP 64238"},
        {"Celescope Catalog", "CEL 4208"},
        {"Fundamental Katalog 5th Edition", "FK5 490"},
        {"Geneva Identification System", "GEN# +1.00114330A"},
        {"Smithsonian Astrophysical Observation", "SAO 139189"},
        {"Wilson Evans Batten Catalogue", "WEB 11356"},
    },
    visualMagnitude: 4.38,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.48755015),
        dec: Angle.Degrees(-05.53892987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192483"},
        {"Hipparcos Number", "HIP 99838"},
        {"Smithsonian Astrophysical Observation", "SAO 144219"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.84775918),
        dec: Angle.Degrees(-05.53668907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43393",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 23"},
        {"Henry Draper", "HD 75530"},
        {"Hipparcos Number", "HIP 43393"},
        {"Geneva Identification System", "GEN# +1.00075530"},
        {"Smithsonian Astrophysical Observation", "SAO 136324"},
        {"Wilson Evans Batten Catalogue", "WEB 8361"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.58794814),
        dec: Angle.Degrees(-05.53478028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -181.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -513.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47340"},
        {"Hipparcos Number", "HIP 31705"},
        {"Smithsonian Astrophysical Observation", "SAO 133502"},
    },
    visualMagnitude: 9.14,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.48431749),
        dec: Angle.Degrees(-05.53348465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193492"},
        {"Hipparcos Number", "HIP 100312"},
        {"Smithsonian Astrophysical Observation", "SAO 144320"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.17439812),
        dec: Angle.Degrees(-05.53340584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71229"},
        {"Hipparcos Number", "HIP 41338"},
        {"Smithsonian Astrophysical Observation", "SAO 135907"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.51882321),
        dec: Angle.Degrees(-05.53076521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155307"},
        {"Hipparcos Number", "HIP 84046"},
        {"Smithsonian Astrophysical Observation", "SAO 141544"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.73618886),
        dec: Angle.Degrees(-05.52905132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196113"},
        {"Hipparcos Number", "HIP 101594"},
        {"Geneva Identification System", "GEN# +1.00196113"},
        {"Smithsonian Astrophysical Observation", "SAO 144603"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.84396659),
        dec: Angle.Degrees(-05.52828287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100565"},
        {"Hipparcos Number", "HIP 56444"},
        {"Geneva Identification System", "GEN# +1.00100565"},
        {"Renson", "Renson 28910"},
        {"Smithsonian Astrophysical Observation", "SAO 138275"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.58920572),
        dec: Angle.Degrees(-05.52713670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2307"},
        {"Hipparcos Number", "HIP 2117"},
        {"Smithsonian Astrophysical Observation", "SAO 128761"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.71759981),
        dec: Angle.Degrees(-05.52273578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50965"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.14927236),
        dec: Angle.Degrees(-05.51927111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -242.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35640"},
        {"Hipparcos Number", "HIP 25401"},
        {"Celescope Catalog", "CEL 693"},
        {"Geneva Identification System", "GEN# +1.00035640"},
        {"Smithsonian Astrophysical Observation", "SAO 132100"},
        {"Wilson Evans Batten Catalogue", "WEB 4922"},
    },
    visualMagnitude: 6.24,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.50983378),
        dec: Angle.Degrees(-05.51850419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123265"},
        {"Hipparcos Number", "HIP 68936"},
        {"Cincinnati Publication", "Ci 20 832"},
        {"Geneva Identification System", "GEN# +1.00123265"},
        {"Smithsonian Astrophysical Observation", "SAO 139737"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.67299713),
        dec: Angle.Degrees(-05.51811053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -409.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10659"},
        {"Hipparcos Number", "HIP 8091"},
        {"Smithsonian Astrophysical Observation", "SAO 129474"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.96658143),
        dec: Angle.Degrees(-05.51768588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2119"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.72085839),
        dec: Angle.Degrees(-05.51655391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33404"},
        {"Hipparcos Number", "HIP 24025"},
        {"Geneva Identification System", "GEN# +1.00033404"},
        {"Smithsonian Astrophysical Observation", "SAO 131832"},
        {"Wilson Evans Batten Catalogue", "WEB 4682"},
    },
    visualMagnitude: 8.35,
    bvColour: 2.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.45114081),
        dec: Angle.Degrees(-05.51530344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160235"},
        {"Hipparcos Number", "HIP 86377"},
        {"Smithsonian Astrophysical Observation", "SAO 141786"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.76426839),
        dec: Angle.Degrees(-05.51412914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49787"},
        {"Hipparcos Number", "HIP 32766"},
        {"Fundamental Katalog 5th Edition", "FK5 4622"},
        {"Geneva Identification System", "GEN# +1.00049787"},
        {"Smithsonian Astrophysical Observation", "SAO 133737"},
        {"Wilson Evans Batten Catalogue", "WEB 6596"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.48134319),
        dec: Angle.Degrees(-05.51320005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167880"},
        {"Hipparcos Number", "HIP 89627"},
        {"Smithsonian Astrophysical Observation", "SAO 142194"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.36461368),
        dec: Angle.Degrees(-05.51231038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70375"},
        {"Hipparcos Number", "HIP 40953"},
        {"Smithsonian Astrophysical Observation", "SAO 135807"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.37057641),
        dec: Angle.Degrees(-05.51054690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156894"},
        {"Hipparcos Number", "HIP 84831"},
        {"Smithsonian Astrophysical Observation", "SAO 141615"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.07596858),
        dec: Angle.Degrees(-05.51030765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198667"},
        {"Hipparcos Number", "HIP 103005"},
        {"Geneva Identification System", "GEN# +1.00198667"},
        {"Renson", "Renson 55300"},
        {"Smithsonian Astrophysical Observation", "SAO 144889"},
        {"Wilson Evans Batten Catalogue", "WEB 18696"},
    },
    visualMagnitude: 5.55,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.03622144),
        dec: Angle.Degrees(-05.50704421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130386"},
        {"Hipparcos Number", "HIP 72388"},
        {"Smithsonian Astrophysical Observation", "SAO 140145"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.00948429),
        dec: Angle.Degrees(-05.50657048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81402",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10128 AB"},
        {"Hipparcos Number", "HIP 81402"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)37, 32.4200),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)30, 15.600)
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
    primaryId: "HIP 91999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173372"},
        {"Hipparcos Number", "HIP 91999"},
        {"Geneva Identification System", "GEN# +1.00173372"},
        {"Smithsonian Astrophysical Observation", "SAO 142583"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.26603892),
        dec: Angle.Degrees(-05.50379029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45013"},
        {"Hipparcos Number", "HIP 30509"},
        {"Geneva Identification System", "GEN# +1.00045013"},
        {"Smithsonian Astrophysical Observation", "SAO 133220"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.19761808),
        dec: Angle.Degrees(-05.50356552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135367"},
        {"Hipparcos Number", "HIP 74623"},
        {"Geneva Identification System", "GEN# +1.00135367"},
        {"Smithsonian Astrophysical Observation", "SAO 140408"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.71088802),
        dec: Angle.Degrees(-05.50257175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206781"},
        {"Hipparcos Number", "HIP 107352"},
        {"Smithsonian Astrophysical Observation", "SAO 145628"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.13551892),
        dec: Angle.Degrees(-05.50115724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20429",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20429"},
        {"Wilson Evans Batten Catalogue", "WEB 3903"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.64513153),
        dec: Angle.Degrees(-05.50112514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32306"},
        {"Hipparcos Number", "HIP 23422"},
        {"Geneva Identification System", "GEN# +1.00032306"},
        {"Smithsonian Astrophysical Observation", "SAO 131711"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.50403150),
        dec: Angle.Degrees(-05.50097094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39402"},
        {"Hipparcos Number", "HIP 27718"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.04380207),
        dec: Angle.Degrees(-05.50084439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119537"},
        {"Hipparcos Number", "HIP 67004"},
        {"Fundamental Katalog 5th Edition", "FK5 5215"},
        {"Geneva Identification System", "GEN# +1.00119537"},
        {"Smithsonian Astrophysical Observation", "SAO 139516"},
        {"Wilson Evans Batten Catalogue", "WEB 11806"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.97611685),
        dec: Angle.Degrees(-05.49890001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89897",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89897"},
        {"Geneva Identification System", "GEN# -0.00504631"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.15865390),
        dec: Angle.Degrees(-05.49856617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 133.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210076"},
        {"Hipparcos Number", "HIP 109248"},
        {"Smithsonian Astrophysical Observation", "SAO 145884"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.97330662),
        dec: Angle.Degrees(-05.49708587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146490"},
        {"Hipparcos Number", "HIP 79768"},
        {"Geneva Identification System", "GEN# +1.00146490"},
        {"Smithsonian Astrophysical Observation", "SAO 141074"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.20116239),
        dec: Angle.Degrees(-05.49675759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79521"},
        {"Hipparcos Number", "HIP 45352"},
        {"Renson", "Renson 22580"},
        {"Smithsonian Astrophysical Observation", "SAO 136683"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.63204449),
        dec: Angle.Degrees(-05.49659798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102115"},
    },
    visualMagnitude: 10.53,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.41938139),
        dec: Angle.Degrees(-05.49300624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39646"},
        {"Hipparcos Number", "HIP 27864"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.43368233),
        dec: Angle.Degrees(-05.49240329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36324"},
        {"Hipparcos Number", "HIP 25804"},
        {"Geneva Identification System", "GEN# +1.00036324"},
        {"Smithsonian Astrophysical Observation", "SAO 132198"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.67909838),
        dec: Angle.Degrees(-05.49079228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38916"},
        {"Hipparcos Number", "HIP 27461"},
        {"Smithsonian Astrophysical Observation", "SAO 132562"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.22846007),
        dec: Angle.Degrees(-05.48926453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38697"},
        {"Hipparcos Number", "HIP 27333"},
        {"Smithsonian Astrophysical Observation", "SAO 132534"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.84495303),
        dec: Angle.Degrees(-05.48873177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168324"},
        {"Hipparcos Number", "HIP 89780"},
        {"Geneva Identification System", "GEN# +1.00168324"},
        {"Smithsonian Astrophysical Observation", "SAO 142221"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.82626163),
        dec: Angle.Degrees(-05.48732037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203000"},
        {"Hipparcos Number", "HIP 105301"},
        {"Geneva Identification System", "GEN# +1.00203000"},
        {"Smithsonian Astrophysical Observation", "SAO 145296"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.92014495),
        dec: Angle.Degrees(-05.48705000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 317"},
        {"Hipparcos Number", "HIP 637"},
        {"Smithsonian Astrophysical Observation", "SAO 128597"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.94918183),
        dec: Angle.Degrees(-05.48598739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30195"},
        {"Geneva Identification System", "GEN# -0.00501600"},
    },
    visualMagnitude: 11.01,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.29152801),
        dec: Angle.Degrees(-05.48549124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134755"},
        {"Hipparcos Number", "HIP 74356"},
        {"Smithsonian Astrophysical Observation", "SAO 140372"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.93605915),
        dec: Angle.Degrees(-05.48260683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121766"},
        {"Hipparcos Number", "HIP 68192"},
        {"Geneva Identification System", "GEN# +1.00121766"},
        {"Smithsonian Astrophysical Observation", "SAO 139648"},
        {"Wilson Evans Batten Catalogue", "WEB 11965"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.41481417),
        dec: Angle.Degrees(-05.48132463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104728"},
        {"Hipparcos Number", "HIP 58797"},
        {"Smithsonian Astrophysical Observation", "SAO 138556"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.89804172),
        dec: Angle.Degrees(-05.47954870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33406",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5618 AB"},
        {"Henry Draper", "HD 51359"},
        {"Hipparcos Number", "HIP 33406"},
        {"Smithsonian Astrophysical Observation", "SAO 133934"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.22039126),
        dec: Angle.Degrees(-05.47904874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71149",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71149"},
        {"Smithsonian Astrophysical Observation", "SAO 139992"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.28215946),
        dec: Angle.Degrees(-05.47890398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199944"},
        {"Hipparcos Number", "HIP 103681"},
        {"Smithsonian Astrophysical Observation", "SAO 145021"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.13603867),
        dec: Angle.Degrees(-05.47731250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208881"},
        {"Hipparcos Number", "HIP 108544"},
        {"Smithsonian Astrophysical Observation", "SAO 145789"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.82544278),
        dec: Angle.Degrees(-05.47635298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167450"},
        {"Hipparcos Number", "HIP 89477"},
        {"Geneva Identification System", "GEN# +1.00167450"},
        {"Smithsonian Astrophysical Observation", "SAO 142182"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.89302875),
        dec: Angle.Degrees(-05.47513801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134755B"},
        {"Hipparcos Number", "HIP 74353"},
        {"Smithsonian Astrophysical Observation", "SAO 140371"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.93235948),
        dec: Angle.Degrees(-05.47480848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53972"},
        {"Hipparcos Number", "HIP 34330"},
        {"Geneva Identification System", "GEN# +1.00053972"},
        {"Smithsonian Astrophysical Observation", "SAO 134207"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.74726436),
        dec: Angle.Degrees(-05.47164648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20238"},
        {"Hipparcos Number", "HIP 15128"},
        {"Smithsonian Astrophysical Observation", "SAO 130380"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.77484533),
        dec: Angle.Degrees(-05.47032358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88248"},
        {"Hipparcos Number", "HIP 49832"},
        {"Geneva Identification System", "GEN# +1.00088248"},
        {"Smithsonian Astrophysical Observation", "SAO 137391"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.60015454),
        dec: Angle.Degrees(-05.47025640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97198"},
        {"Hipparcos Number", "HIP 54654"},
        {"Smithsonian Astrophysical Observation", "SAO 138038"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.81744818),
        dec: Angle.Degrees(-05.47013727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11315"},
        {"Hipparcos Number", "HIP 8611"},
        {"Smithsonian Astrophysical Observation", "SAO 129533"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.76483013),
        dec: Angle.Degrees(-05.46971264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25069"},
        {"Hipparcos Number", "HIP 18606"},
        {"Geneva Identification System", "GEN# +1.00025069"},
        {"Smithsonian Astrophysical Observation", "SAO 130860"},
        {"Wilson Evans Batten Catalogue", "WEB 3586"},
    },
    visualMagnitude: 5.85,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.71842188),
        dec: Angle.Degrees(-05.46952376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110487"},
        {"Hipparcos Number", "HIP 62013"},
        {"Geneva Identification System", "GEN# +1.00110487"},
        {"Smithsonian Astrophysical Observation", "SAO 138924"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.64954636),
        dec: Angle.Degrees(-05.46808412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202666"},
        {"Hipparcos Number", "HIP 105115"},
        {"Smithsonian Astrophysical Observation", "SAO 145269"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.39568383),
        dec: Angle.Degrees(-05.46806638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21358"},
        {"Hipparcos Number", "HIP 16044"},
        {"Smithsonian Astrophysical Observation", "SAO 130491"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.64997551),
        dec: Angle.Degrees(-05.46683243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61383"},
        {"Hipparcos Number", "HIP 37233"},
        {"Geneva Identification System", "GEN# +1.00061383"},
        {"Smithsonian Astrophysical Observation", "SAO 134936"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.71333666),
        dec: Angle.Degrees(-05.46526800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 228.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202388"},
        {"Hipparcos Number", "HIP 104946"},
        {"Smithsonian Astrophysical Observation", "SAO 145241"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.87654003),
        dec: Angle.Degrees(-05.46471377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38273"},
        {"Hipparcos Number", "HIP 27069"},
        {"Geneva Identification System", "GEN# +1.00038273"},
        {"Smithsonian Astrophysical Observation", "SAO 132502"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.10604886),
        dec: Angle.Degrees(-05.46470032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5436"},
        {"Hipparcos Number", "HIP 4372"},
        {"Smithsonian Astrophysical Observation", "SAO 129034"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.00660911),
        dec: Angle.Degrees(-05.46251463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223105"},
        {"Hipparcos Number", "HIP 117267"},
        {"Smithsonian Astrophysical Observation", "SAO 146900"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.67481778),
        dec: Angle.Degrees(-05.45985927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224347"},
        {"Hipparcos Number", "HIP 118080"},
        {"Geneva Identification System", "GEN# +1.00224347"},
        {"Smithsonian Astrophysical Observation", "SAO 146994"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.29204597),
        dec: Angle.Degrees(-05.45973823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63054",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63054"},
        {"Wilson Evans Batten Catalogue", "WEB 11181"},
    },
    visualMagnitude: 11.66,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.79406858),
        dec: Angle.Degrees(-05.45892139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123918"},
        {"Hipparcos Number", "HIP 69242"},
        {"Smithsonian Astrophysical Observation", "SAO 139771"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.63083601),
        dec: Angle.Degrees(-05.45758446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224431"},
        {"Hipparcos Number", "HIP 118141"},
        {"Geneva Identification System", "GEN# +1.00224431"},
        {"Smithsonian Astrophysical Observation", "SAO 147000"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.45241540),
        dec: Angle.Degrees(-05.45648617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44517"},
        {"Hipparcos Number", "HIP 30269"},
        {"Geneva Identification System", "GEN# +1.00044517"},
        {"Smithsonian Astrophysical Observation", "SAO 133165"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.51039586),
        dec: Angle.Degrees(-05.45473201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77412"},
        {"Hipparcos Number", "HIP 44372"},
        {"Smithsonian Astrophysical Observation", "SAO 136520"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.55770685),
        dec: Angle.Degrees(-05.45469374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31109"},
        {"Hipparcos Number", "HIP 22701"},
        {"Fundamental Katalog 5th Edition", "FK5 2366"},
        {"Geneva Identification System", "GEN# +1.00031109"},
        {"Smithsonian Astrophysical Observation", "SAO 131568"},
        {"Wilson Evans Batten Catalogue", "WEB 4390"},
    },
    visualMagnitude: 4.36,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.22366820),
        dec: Angle.Degrees(-05.45275591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148573"},
        {"Hipparcos Number", "HIP 80745"},
        {"Smithsonian Astrophysical Observation", "SAO 141198"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.28991813),
        dec: Angle.Degrees(-05.45112700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1555"},
        {"Hipparcos Number", "HIP 1588"},
        {"Smithsonian Astrophysical Observation", "SAO 128699"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.96531577),
        dec: Angle.Degrees(-05.45053119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185639"},
        {"Hipparcos Number", "HIP 96783"},
        {"Smithsonian Astrophysical Observation", "SAO 143669"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.08873933),
        dec: Angle.Degrees(-05.44749401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97542"},
        {"Hipparcos Number", "HIP 54825"},
        {"Smithsonian Astrophysical Observation", "SAO 138070"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.35374002),
        dec: Angle.Degrees(-05.44682083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15437"},
        {"Hipparcos Number", "HIP 11568"},
        {"Smithsonian Astrophysical Observation", "SAO 129933"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.26562236),
        dec: Angle.Degrees(-05.44636172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217878"},
        {"Hipparcos Number", "HIP 113887"},
        {"Smithsonian Astrophysical Observation", "SAO 146480"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.96670251),
        dec: Angle.Degrees(-05.44557742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148514"},
        {"Hipparcos Number", "HIP 80717"},
        {"Smithsonian Astrophysical Observation", "SAO 141196"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.20237477),
        dec: Angle.Degrees(-05.44552370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111412"},
        {"Hipparcos Number", "HIP 62565"},
        {"Smithsonian Astrophysical Observation", "SAO 138979"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.28805957),
        dec: Angle.Degrees(-05.44492386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55290"},
        {"Hipparcos Number", "HIP 34793"},
        {"Smithsonian Astrophysical Observation", "SAO 134342"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.04245650),
        dec: Angle.Degrees(-05.44490542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36106"},
        {"Hipparcos Number", "HIP 25686"},
        {"Smithsonian Astrophysical Observation", "SAO 132164"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.27853020),
        dec: Angle.Degrees(-05.44485917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29108"},
        {"Hipparcos Number", "HIP 21343"},
        {"Smithsonian Astrophysical Observation", "SAO 131325"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.69399212),
        dec: Angle.Degrees(-05.44135591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101858"},
        {"Hipparcos Number", "HIP 57164"},
        {"Smithsonian Astrophysical Observation", "SAO 138368"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.85565757),
        dec: Angle.Degrees(-05.44038785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81765"},
        {"Hipparcos Number", "HIP 46380"},
        {"Renson", "Renson 23210"},
        {"Smithsonian Astrophysical Observation", "SAO 136866"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.85817859),
        dec: Angle.Degrees(-05.43831225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157432"},
        {"Hipparcos Number", "HIP 85085"},
        {"Smithsonian Astrophysical Observation", "SAO 141644"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.84390449),
        dec: Angle.Degrees(-05.43815439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5338"},
        {"Hipparcos Number", "HIP 4308"},
        {"Smithsonian Astrophysical Observation", "SAO 129025"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.79690185),
        dec: Angle.Degrees(-05.43522753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 179.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76151"},
        {"Hipparcos Number", "HIP 43726"},
        {"Cincinnati Publication", "Ci 20 497"},
        {"Geneva Identification System", "GEN# +1.00076151"},
        {"Smithsonian Astrophysical Observation", "SAO 136389"},
        {"Wilson Evans Batten Catalogue", "WEB 8417"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.57579010),
        dec: Angle.Degrees(-05.43453346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -413.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70395",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70395"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.03556872),
        dec: Angle.Degrees(-05.43311662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -222.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67370",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9029 AB"},
        {"Henry Draper", "HD 120267"},
        {"Hipparcos Number", "HIP 67370"},
        {"Smithsonian Astrophysical Observation", "SAO 139562"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.13184482),
        dec: Angle.Degrees(-05.43251197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64235"},
        {"Hipparcos Number", "HIP 38474"},
        {"Fundamental Katalog 5th Edition", "FK5 2611"},
        {"Geneva Identification System", "GEN# +1.00064235J"},
        {"Smithsonian Astrophysical Observation", "SAO 135205"},
        {"Wilson Evans Batten Catalogue", "WEB 7563"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.19946278),
        dec: Angle.Degrees(-05.42818693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163884"},
        {"Hipparcos Number", "HIP 88024"},
        {"Smithsonian Astrophysical Observation", "SAO 142000"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.69108546),
        dec: Angle.Degrees(-05.42480610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36880",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6192 AB"},
        {"Henry Draper", "HD 60549"},
        {"Hipparcos Number", "HIP 36880"},
        {"Smithsonian Astrophysical Observation", "SAO 134855"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.72364445),
        dec: Angle.Degrees(-05.42477924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208703"},
        {"Hipparcos Number", "HIP 108453"},
        {"Geneva Identification System", "GEN# +1.00208703"},
        {"Smithsonian Astrophysical Observation", "SAO 145778"},
        {"Wilson Evans Batten Catalogue", "WEB 19527"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.55534953),
        dec: Angle.Degrees(-05.42466689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94857",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12283 A"},
        {"Henry Draper", "HD 180785"},
        {"Hipparcos Number", "HIP 94857"},
        {"Smithsonian Astrophysical Observation", "SAO 143237"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.52961101),
        dec: Angle.Degrees(-05.42342169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122040"},
        {"Hipparcos Number", "HIP 68348"},
        {"Geneva Identification System", "GEN# +1.00122040"},
        {"Smithsonian Astrophysical Observation", "SAO 139663"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.86521390),
        dec: Angle.Degrees(-05.42337680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -199.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87602"},
        {"Hipparcos Number", "HIP 49465"},
        {"Smithsonian Astrophysical Observation", "SAO 137348"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.47932464),
        dec: Angle.Degrees(-05.42301530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74640",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74640"},
        {"Smithsonian Astrophysical Observation", "SAO 140411"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.75952736),
        dec: Angle.Degrees(-05.42188197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139378"},
        {"Hipparcos Number", "HIP 76542"},
        {"Smithsonian Astrophysical Observation", "SAO 140664"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.49456081),
        dec: Angle.Degrees(-05.42186255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9340",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9340"},
        {"Smithsonian Astrophysical Observation", "SAO 129616"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.98602144),
        dec: Angle.Degrees(-05.42093497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31308"},
        {"Hipparcos Number", "HIP 22810"},
        {"Smithsonian Astrophysical Observation", "SAO 131588"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.61353826),
        dec: Angle.Degrees(-05.42061593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51511"},
        {"Hipparcos Number", "HIP 33463"},
        {"Smithsonian Astrophysical Observation", "SAO 133951"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.34827643),
        dec: Angle.Degrees(-05.41928176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205178"},
        {"Hipparcos Number", "HIP 106464"},
        {"Renson", "Renson 57160"},
        {"Smithsonian Astrophysical Observation", "SAO 145488"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.44297142),
        dec: Angle.Degrees(-05.41849083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90764"},
        {"Hipparcos Number", "HIP 51298"},
        {"Smithsonian Astrophysical Observation", "SAO 137592"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.18054284),
        dec: Angle.Degrees(-05.41798916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182410"},
        {"Hipparcos Number", "HIP 95433"},
        {"Smithsonian Astrophysical Observation", "SAO 143368"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.18534526),
        dec: Angle.Degrees(-05.41792848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26235",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4188 A"},
        {"Henry Draper", "HD 37041"},
        {"Hipparcos Number", "HIP 26235"},
        {"Geneva Identification System", "GEN# +9.00010682"},
        {"Geneva Identification System 2", "GEN# +2.19760682"},
        {"Renson", "Renson 9830"},
        {"Smithsonian Astrophysical Observation", "SAO 132321"},
        {"Wilson Evans Batten Catalogue", "WEB 5134"},
        {"New General Catalogue", "NGC 1976 682"},
    },
    visualMagnitude: 4.98,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.84541591),
        dec: Angle.Degrees(-05.41606331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181391"},
        {"Hipparcos Number", "HIP 95066"},
        {"Fundamental Katalog 5th Edition", "FK5 3544"},
        {"Geneva Identification System", "GEN# +1.00181391"},
        {"Smithsonian Astrophysical Observation", "SAO 143286"},
        {"Wilson Evans Batten Catalogue", "WEB 16603"},
    },
    visualMagnitude: 4.98,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.13682588),
        dec: Angle.Degrees(-05.41587489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89720"},
        {"Hipparcos Number", "HIP 50692"},
        {"Smithsonian Astrophysical Observation", "SAO 137509"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.27992440),
        dec: Angle.Degrees(-05.41504121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94856",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12283 B"},
        {"Hipparcos Number", "HIP 94856"},
    },
    visualMagnitude: 9.92,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.52651040),
        dec: Angle.Degrees(-05.41501570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179346"},
        {"Hipparcos Number", "HIP 94370"},
        {"Geneva Identification System", "GEN# +1.00179346"},
        {"Smithsonian Astrophysical Observation", "SAO 143132"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.11424400),
        dec: Angle.Degrees(-05.41441446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66735"},
        {"Hipparcos Number", "HIP 39541"},
        {"Smithsonian Astrophysical Observation", "SAO 135461"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.20483815),
        dec: Angle.Degrees(-05.41178052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51977"},
        {"Hipparcos Number", "HIP 33640"},
        {"Smithsonian Astrophysical Observation", "SAO 133996"},
    },
    visualMagnitude: 8.19,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.83170115),
        dec: Angle.Degrees(-05.41002935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93719"},
        {"Hipparcos Number", "HIP 52899"},
        {"Smithsonian Astrophysical Observation", "SAO 137807"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.28832075),
        dec: Angle.Degrees(-05.40691930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9947"},
        {"Smithsonian Astrophysical Observation", "SAO 129712"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.00646823),
        dec: Angle.Degrees(-05.40550311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207435"},
        {"Hipparcos Number", "HIP 107702"},
        {"Geneva Identification System", "GEN# +1.00207435"},
        {"Smithsonian Astrophysical Observation", "SAO 145685"},
        {"Wilson Evans Batten Catalogue", "WEB 19425"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.25803666),
        dec: Angle.Degrees(-05.40364384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10353"},
        {"Hipparcos Number", "HIP 7852"},
        {"Smithsonian Astrophysical Observation", "SAO 129446"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.24504669),
        dec: Angle.Degrees(-05.40354860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41738"},
        {"Smithsonian Astrophysical Observation", "SAO 135990"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.66583950),
        dec: Angle.Degrees(-05.39905341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142882"},
        {"Hipparcos Number", "HIP 78125"},
        {"Geneva Identification System", "GEN# +1.00142882"},
        {"Smithsonian Astrophysical Observation", "SAO 140854"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.28873833),
        dec: Angle.Degrees(-05.39830712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26887"},
        {"Hipparcos Number", "HIP 19809"},
        {"Smithsonian Astrophysical Observation", "SAO 131052"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.71665934),
        dec: Angle.Degrees(-05.39656860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118219"},
        {"Hipparcos Number", "HIP 66320"},
        {"Fundamental Katalog 5th Edition", "FK5 1352"},
        {"Geneva Identification System", "GEN# +1.00118219"},
        {"Smithsonian Astrophysical Observation", "SAO 139428"},
        {"Wilson Evans Batten Catalogue", "WEB 11716"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.88036281),
        dec: Angle.Degrees(-05.39639184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134358"},
        {"Hipparcos Number", "HIP 74188"},
        {"Fundamental Katalog 5th Edition", "FK5 5347"},
        {"Smithsonian Astrophysical Observation", "SAO 140354"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.39465698),
        dec: Angle.Degrees(-05.39479285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19754"},
        {"Hipparcos Number", "HIP 14763"},
        {"Smithsonian Astrophysical Observation", "SAO 130323"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.66036726),
        dec: Angle.Degrees(-05.39391676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41874"},
        {"Hipparcos Number", "HIP 29026"},
        {"Smithsonian Astrophysical Observation", "SAO 132856"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.86280030),
        dec: Angle.Degrees(-05.39023691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96018"},
        {"Hipparcos Number", "HIP 54121"},
        {"Smithsonian Astrophysical Observation", "SAO 137975"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.10525150),
        dec: Angle.Degrees(-05.38988527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26221",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4186 C"},
        {"Henry Draper", "HD 37022"},
        {"Hipparcos Number", "HIP 26221"},
        {"Celescope Catalog", "CEL 832"},
        {"Geneva Identification System", "GEN# +9.00010598"},
        {"Geneva Identification System 2", "GEN# +2.19760598"},
        {"Smithsonian Astrophysical Observation", "SAO 132314"},
        {"Wilson Evans Batten Catalogue", "WEB 5125"},
    },
    visualMagnitude: 5.13,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.81860863),
        dec: Angle.Degrees(-05.38969624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195277"},
        {"Hipparcos Number", "HIP 101183"},
        {"Smithsonian Astrophysical Observation", "SAO 144512"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.64271893),
        dec: Angle.Degrees(-05.38956045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221044"},
        {"Hipparcos Number", "HIP 115892"},
        {"Smithsonian Astrophysical Observation", "SAO 146724"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.19458213),
        dec: Angle.Degrees(-05.38937696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26224",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4186 D"},
        {"Henry Draper", "HD 37023"},
        {"Hipparcos Number", "HIP 26224"},
        {"Geneva Identification System", "GEN# +9.00010612"},
        {"Geneva Identification System 2", "GEN# +9.00010612D"},
        {"Geneva Identification System 3", "GEN# +2.19760612"},
        {"Wilson Evans Batten Catalogue", "WEB 5126"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.82166016),
        dec: Angle.Degrees(-05.38768076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26220",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4186 A"},
        {"Henry Draper", "HD 37020"},
        {"Hipparcos Number", "HIP 26220"},
        {"Geneva Identification System", "GEN# +9.00010587"},
        {"Geneva Identification System 2", "GEN# +2.19760587"},
        {"Wilson Evans Batten Catalogue", "WEB 5123"},
    },
    visualMagnitude: 4.98,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.81592896),
        dec: Angle.Degrees(-05.38731536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211434"},
        {"Hipparcos Number", "HIP 110023"},
        {"Fundamental Katalog 5th Edition", "FK5 3782"},
        {"Geneva Identification System", "GEN# +1.00211434"},
        {"Smithsonian Astrophysical Observation", "SAO 145993"},
        {"Wilson Evans Batten Catalogue", "WEB 19754"},
    },
    visualMagnitude: 5.75,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.27709235),
        dec: Angle.Degrees(-05.38721152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19421"},
        {"Hipparcos Number", "HIP 14503"},
        {"Smithsonian Astrophysical Observation", "SAO 130295"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.83080191),
        dec: Angle.Degrees(-05.38516796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31867",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5307 AB"},
        {"Henry Draper", "HD 47685"},
        {"Hipparcos Number", "HIP 31867"},
        {"Smithsonian Astrophysical Observation", "SAO 133537"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.92487791),
        dec: Angle.Degrees(-05.38508777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89669"},
        {"Hipparcos Number", "HIP 50658"},
        {"Renson", "Renson 25744"},
        {"Smithsonian Astrophysical Observation", "SAO 137505"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.18460087),
        dec: Angle.Degrees(-05.38204977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93377"},
        {"Hipparcos Number", "HIP 52731"},
        {"Smithsonian Astrophysical Observation", "SAO 137779"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.70260388),
        dec: Angle.Degrees(-05.38150508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122815"},
        {"Hipparcos Number", "HIP 68739"},
        {"Geneva Identification System", "GEN# +1.00122815"},
        {"Smithsonian Astrophysical Observation", "SAO 139711"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.06070549),
        dec: Angle.Degrees(-05.38138548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96296"},
        {"Hipparcos Number", "HIP 54259"},
        {"Smithsonian Astrophysical Observation", "SAO 137986"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.50382076),
        dec: Angle.Degrees(-05.38108546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30948"},
        {"Hipparcos Number", "HIP 22593"},
        {"Smithsonian Astrophysical Observation", "SAO 131548"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.92310556),
        dec: Angle.Degrees(-05.37561358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200413"},
        {"Hipparcos Number", "HIP 103928"},
        {"Smithsonian Astrophysical Observation", "SAO 145054"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.85636637),
        dec: Angle.Degrees(-05.37467676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46549",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46549"},
        {"Geneva Identification System", "GEN# -0.00402639"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.39722361),
        dec: Angle.Degrees(-05.37276807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -479.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40592",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6719 AB"},
        {"Henry Draper", "HD 69526"},
        {"Hipparcos Number", "HIP 40592"},
        {"Geneva Identification System", "GEN# +1.00069526J"},
        {"Smithsonian Astrophysical Observation", "SAO 135730"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.31541109),
        dec: Angle.Degrees(-05.36917331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82958"},
        {"Hipparcos Number", "HIP 47031"},
        {"Smithsonian Astrophysical Observation", "SAO 136975"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.77929404),
        dec: Angle.Degrees(-05.36884040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46165"},
        {"Hipparcos Number", "HIP 31101"},
        {"Celescope Catalog", "CEL 1281"},
        {"Geneva Identification System", "GEN# +1.00046165"},
        {"Smithsonian Astrophysical Observation", "SAO 133365"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.90039615),
        dec: Angle.Degrees(-05.36873209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63523"},
        {"Smithsonian Astrophysical Observation", "SAO 139100"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.25064751),
        dec: Angle.Degrees(-05.36828810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24925",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3926 AB"},
        {"Henry Draper", "HD 34880"},
        {"Hipparcos Number", "HIP 24925"},
        {"Celescope Catalog", "CEL 632"},
        {"Geneva Identification System", "GEN# +1.00034880J"},
        {"Renson", "Renson 8910"},
        {"Smithsonian Astrophysical Observation", "SAO 132004"},
        {"Wilson Evans Batten Catalogue", "WEB 4827"},
    },
    visualMagnitude: 6.40,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.11003844),
        dec: Angle.Degrees(-05.36751687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33719",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Citala"},
        {"Henry Draper", "HD 52265"},
        {"Hipparcos Number", "HIP 33719"},
        {"Geneva Identification System", "GEN# +1.00052265"},
        {"Smithsonian Astrophysical Observation", "SAO 134031"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.07543371),
        dec: Angle.Degrees(-05.36735720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207911"},
        {"Hipparcos Number", "HIP 107986"},
        {"Smithsonian Astrophysical Observation", "SAO 145719"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.15261303),
        dec: Angle.Degrees(-05.36515017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202658"},
        {"Hipparcos Number", "HIP 105107"},
        {"Geneva Identification System", "GEN# +1.00202658"},
        {"Smithsonian Astrophysical Observation", "SAO 145266"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.35777140),
        dec: Angle.Degrees(-05.36511019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91412"},
        {"Hipparcos Number", "HIP 51659"},
        {"Smithsonian Astrophysical Observation", "SAO 137634"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.31094238),
        dec: Angle.Degrees(-05.36210677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21197"},
        {"Hipparcos Number", "HIP 15919"},
        {"Cincinnati Publication", "Ci 20 232"},
        {"Geneva Identification System", "GEN# +1.00021197"},
        {"Smithsonian Astrophysical Observation", "SAO 130471"},
        {"Wilson Evans Batten Catalogue", "WEB 3038"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.24944102),
        dec: Angle.Degrees(-05.36188736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -230.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -768.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91725"},
        {"Hipparcos Number", "HIP 51837"},
        {"Smithsonian Astrophysical Observation", "SAO 137660"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.85571112),
        dec: Angle.Degrees(-05.36184087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81166"},
        {"Hipparcos Number", "HIP 46090"},
        {"Smithsonian Astrophysical Observation", "SAO 136806"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.97856347),
        dec: Angle.Degrees(-05.36145733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18141",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2832 A"},
        {"Henry Draper", "HD 24388"},
        {"Hipparcos Number", "HIP 18141"},
        {"Geneva Identification System", "GEN# +1.00024388J"},
        {"Smithsonian Astrophysical Observation", "SAO 130789"},
        {"Wilson Evans Batten Catalogue", "WEB 3496"},
    },
    visualMagnitude: 5.48,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.17355849),
        dec: Angle.Degrees(-05.36124167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164716"},
        {"Hipparcos Number", "HIP 88374"},
        {"Geneva Identification System", "GEN# +1.00164716"},
        {"Smithsonian Astrophysical Observation", "SAO 142045"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.69278801),
        dec: Angle.Degrees(-05.35804644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209779"},
        {"Hipparcos Number", "HIP 109110"},
        {"Geneva Identification System", "GEN# +1.00209779"},
        {"Smithsonian Astrophysical Observation", "SAO 145866"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.52181508),
        dec: Angle.Degrees(-05.35791736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 171.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199974"},
        {"Hipparcos Number", "HIP 103688"},
        {"Geneva Identification System", "GEN# +1.00199974"},
        {"Smithsonian Astrophysical Observation", "SAO 145024"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.16958273),
        dec: Angle.Degrees(-05.35789827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19688"},
        {"Hipparcos Number", "HIP 14708"},
        {"Geneva Identification System", "GEN# +1.00019688"},
        {"Smithsonian Astrophysical Observation", "SAO 130315"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.51053612),
        dec: Angle.Degrees(-05.35605092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208125"},
        {"Hipparcos Number", "HIP 108106"},
        {"Geneva Identification System", "GEN# +1.00208125"},
        {"Smithsonian Astrophysical Observation", "SAO 145732"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.54980120),
        dec: Angle.Degrees(-05.35312439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13721",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13721"},
        {"Smithsonian Astrophysical Observation", "SAO 130201"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.17234268),
        dec: Angle.Degrees(-05.35197029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57422",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8299 A"},
        {"Henry Draper", "HD 102284"},
        {"Hipparcos Number", "HIP 57422"},
        {"Smithsonian Astrophysical Observation", "SAO 138396"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.58800613),
        dec: Angle.Degrees(-05.34890935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59750"},
        {"Hipparcos Number", "HIP 36563"},
        {"Geneva Identification System", "GEN# +1.00059750"},
        {"Smithsonian Astrophysical Observation", "SAO 134782"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.81444163),
        dec: Angle.Degrees(-05.34481639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43665"},
        {"Hipparcos Number", "HIP 29859"},
        {"Smithsonian Astrophysical Observation", "SAO 133062"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.31415418),
        dec: Angle.Degrees(-05.34368520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41434"},
        {"Hipparcos Number", "HIP 28809"},
        {"Smithsonian Astrophysical Observation", "SAO 132807"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.23431096),
        dec: Angle.Degrees(-05.34303352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218553"},
        {"Hipparcos Number", "HIP 114310"},
        {"Smithsonian Astrophysical Observation", "SAO 146530"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.25636980),
        dec: Angle.Degrees(-05.34183675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91738"},
    },
    visualMagnitude: 11.21,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.61175534),
        dec: Angle.Degrees(-05.34084231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31195",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5183 AB"},
        {"Henry Draper", "HD 46340"},
        {"Hipparcos Number", "HIP 31195"},
        {"Celescope Catalog", "CEL 1293"},
        {"Smithsonian Astrophysical Observation", "SAO 133387"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.16777459),
        dec: Angle.Degrees(-05.34061090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36655"},
        {"Hipparcos Number", "HIP 26021"},
        {"Geneva Identification System", "GEN# +9.00010050"},
        {"Smithsonian Astrophysical Observation", "SAO 132249"},
    },
    visualMagnitude: 8.60,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.28114699),
        dec: Angle.Degrees(-05.34058525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7133"},
        {"Hipparcos Number", "HIP 5581"},
        {"Geneva Identification System", "GEN# +1.00007133"},
        {"Renson", "Renson 1790"},
        {"Smithsonian Astrophysical Observation", "SAO 129168"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.89570990),
        dec: Angle.Degrees(-05.34018353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42050"},
        {"Hipparcos Number", "HIP 29120"},
        {"Celescope Catalog", "CEL 1088"},
        {"Geneva Identification System", "GEN# +1.00042050"},
        {"Smithsonian Astrophysical Observation", "SAO 132876"},
        {"Wilson Evans Batten Catalogue", "WEB 5701"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.10950590),
        dec: Angle.Degrees(-05.33957975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223858"},
        {"Hipparcos Number", "HIP 117780"},
        {"Smithsonian Astrophysical Observation", "SAO 146957"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.28308505),
        dec: Angle.Degrees(-05.33474700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216467"},
        {"Hipparcos Number", "HIP 113011"},
        {"Smithsonian Astrophysical Observation", "SAO 146368"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.29836966),
        dec: Angle.Degrees(-05.33404181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102928"},
        {"Hipparcos Number", "HIP 57791"},
        {"Fundamental Katalog 5th Edition", "FK5 1306"},
        {"Geneva Identification System", "GEN# +1.00102928"},
        {"Smithsonian Astrophysical Observation", "SAO 138445"},
        {"Wilson Evans Batten Catalogue", "WEB 10368"},
    },
    visualMagnitude: 5.62,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.75929508),
        dec: Angle.Degrees(-05.33333400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178286"},
        {"Hipparcos Number", "HIP 93991"},
        {"Smithsonian Astrophysical Observation", "SAO 143061"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.05994872),
        dec: Angle.Degrees(-05.33271763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18131"},
        {"Hipparcos Number", "HIP 13558"},
        {"Smithsonian Astrophysical Observation", "SAO 130180"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.66169031),
        dec: Angle.Degrees(-05.33077118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162324"},
        {"Hipparcos Number", "HIP 87338"},
        {"Smithsonian Astrophysical Observation", "SAO 141902"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.68945810),
        dec: Angle.Degrees(-05.33020356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70148"},
        {"Hipparcos Number", "HIP 40859"},
        {"Geneva Identification System", "GEN# +1.00070148"},
        {"Smithsonian Astrophysical Observation", "SAO 135787"},
    },
    visualMagnitude: 6.12,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.07088469),
        dec: Angle.Degrees(-05.32982448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46646"},
        {"Hipparcos Number", "HIP 31339"},
        {"Celescope Catalog", "CEL 1303"},
        {"Smithsonian Astrophysical Observation", "SAO 133423"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.57693488),
        dec: Angle.Degrees(-05.32805986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72528"},
        {"Hipparcos Number", "HIP 41968"},
        {"Geneva Identification System", "GEN# +1.00072528"},
        {"Smithsonian Astrophysical Observation", "SAO 136028"},
        {"Wilson Evans Batten Catalogue", "WEB 8076"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.32315900),
        dec: Angle.Degrees(-05.32781991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109930"},
        {"Hipparcos Number", "HIP 61687"},
        {"Cincinnati Publication", "Ci 18 1597"},
        {"Smithsonian Astrophysical Observation", "SAO 138884"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.68367687),
        dec: Angle.Degrees(-05.32740410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 312.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124572"},
        {"Hipparcos Number", "HIP 69586"},
        {"Smithsonian Astrophysical Observation", "SAO 139812"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.65392447),
        dec: Angle.Degrees(-05.32685671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157584"},
        {"Hipparcos Number", "HIP 85165"},
        {"Geneva Identification System", "GEN# +1.00157584"},
        {"Smithsonian Astrophysical Observation", "SAO 141651"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.06623659),
        dec: Angle.Degrees(-05.32542679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6211",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1077 AB"},
        {"Henry Draper", "HD 8032"},
        {"Hipparcos Number", "HIP 6211"},
        {"Geneva Identification System", "GEN# +1.00008032J"},
        {"Smithsonian Astrophysical Observation", "SAO 129233"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.90456621),
        dec: Angle.Degrees(-05.32535600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53208"},
        {"Hipparcos Number", "HIP 34086"},
        {"Geneva Identification System", "GEN# +1.00053208"},
        {"Smithsonian Astrophysical Observation", "SAO 134133"},
        {"Wilson Evans Batten Catalogue", "WEB 6835"},
    },
    visualMagnitude: 5.63,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.02187558),
        dec: Angle.Degrees(-05.32397100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31478"},
        {"Hipparcos Number", "HIP 22931"},
        {"Smithsonian Astrophysical Observation", "SAO 131611"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.02035733),
        dec: Angle.Degrees(-05.32283999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97180"},
        {"Hipparcos Number", "HIP 54650"},
        {"Smithsonian Astrophysical Observation", "SAO 138037"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.78645212),
        dec: Angle.Degrees(-05.32164048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6011"},
        {"Hipparcos Number", "HIP 4777"},
        {"Smithsonian Astrophysical Observation", "SAO 129084"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.34407819),
        dec: Angle.Degrees(-05.32028769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35222"},
        {"Hipparcos Number", "HIP 25170"},
        {"Smithsonian Astrophysical Observation", "SAO 132045"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.76680305),
        dec: Angle.Degrees(-05.31948935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107906",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107906"},
    },
    visualMagnitude: 11.17,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.93614295),
        dec: Angle.Degrees(-05.31780197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 205.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50282"},
        {"Hipparcos Number", "HIP 32990"},
        {"Geneva Identification System", "GEN# +1.00050282"},
        {"Smithsonian Astrophysical Observation", "SAO 133807"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.09530858),
        dec: Angle.Degrees(-05.31624393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4856"},
        {"Hipparcos Number", "HIP 3935"},
        {"Geneva Identification System", "GEN# +1.00004856"},
        {"Smithsonian Astrophysical Observation", "SAO 128979"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.63181631),
        dec: Angle.Degrees(-05.31415406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166715"},
        {"Hipparcos Number", "HIP 89192"},
        {"Smithsonian Astrophysical Observation", "SAO 142148"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.03270069),
        dec: Angle.Degrees(-05.31304094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112587"},
        {"Hipparcos Number", "HIP 63266"},
        {"Smithsonian Astrophysical Observation", "SAO 139066"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.46366018),
        dec: Angle.Degrees(-05.31009795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14698"},
        {"Smithsonian Astrophysical Observation", "SAO 130312"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.46849209),
        dec: Angle.Degrees(-05.30996668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28979"},
        {"Hipparcos Number", "HIP 21264"},
        {"Smithsonian Astrophysical Observation", "SAO 131303"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.43503631),
        dec: Angle.Degrees(-05.30951278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104610",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104610"},
    },
    visualMagnitude: 10.99,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.86854142),
        dec: Angle.Degrees(-05.30910191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43710"},
        {"Hipparcos Number", "HIP 29879"},
        {"Smithsonian Astrophysical Observation", "SAO 133069"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.37981643),
        dec: Angle.Degrees(-05.30872436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33609"},
        {"Hipparcos Number", "HIP 24154"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.80638510),
        dec: Angle.Degrees(-05.30833611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22617"},
        {"Smithsonian Astrophysical Observation", "SAO 131550"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.99609005),
        dec: Angle.Degrees(-05.30446859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197210"},
        {"Hipparcos Number", "HIP 102203"},
        {"Geneva Identification System", "GEN# +1.00197210"},
        {"Smithsonian Astrophysical Observation", "SAO 144725"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.62268393),
        dec: Angle.Degrees(-05.30082137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54081"},
        {"Hipparcos Number", "HIP 34354"},
        {"Wilson Evans Batten Catalogue", "WEB 6882"},
    },
    visualMagnitude: 9.63,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.82590275),
        dec: Angle.Degrees(-05.29789179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76194"},
        {"Hipparcos Number", "HIP 43741"},
        {"Geneva Identification System", "GEN# +1.00076194"},
        {"Smithsonian Astrophysical Observation", "SAO 136392"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.63090990),
        dec: Angle.Degrees(-05.29497478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75429",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75429"},
        {"Smithsonian Astrophysical Observation", "SAO 140513"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.15809430),
        dec: Angle.Degrees(-05.29189357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47780"},
        {"Hipparcos Number", "HIP 31911"},
        {"Smithsonian Astrophysical Observation", "SAO 133545"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.03359138),
        dec: Angle.Degrees(-05.28983301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34889"},
        {"Hipparcos Number", "HIP 24936"},
        {"Celescope Catalog", "CEL 636"},
        {"Geneva Identification System", "GEN# +1.00034889"},
        {"Renson", "Renson 8920"},
        {"Smithsonian Astrophysical Observation", "SAO 132011"},
    },
    visualMagnitude: 8.72,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.13692992),
        dec: Angle.Degrees(-05.28805452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22980"},
        {"Hipparcos Number", "HIP 17205"},
        {"Smithsonian Astrophysical Observation", "SAO 130662"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.29023068),
        dec: Angle.Degrees(-05.28797373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22692",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3497 AB"},
        {"Henry Draper", "HD 31088"},
        {"Hipparcos Number", "HIP 22692"},
        {"Smithsonian Astrophysical Observation", "SAO 131563"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.19225739),
        dec: Angle.Degrees(-05.28654120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143973"},
        {"Hipparcos Number", "HIP 78669"},
        {"Smithsonian Astrophysical Observation", "SAO 140924"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.90138536),
        dec: Angle.Degrees(-05.27866864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58074"},
        {"Hipparcos Number", "HIP 35881"},
        {"Geneva Identification System", "GEN# +1.00058074"},
        {"Smithsonian Astrophysical Observation", "SAO 134616"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.96564927),
        dec: Angle.Degrees(-05.27136523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14722",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14722"},
        {"Smithsonian Astrophysical Observation", "SAO 130318"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.54225631),
        dec: Angle.Degrees(-05.27101382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26473"},
        {"Hipparcos Number", "HIP 19536"},
        {"Smithsonian Astrophysical Observation", "SAO 131008"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.77075572),
        dec: Angle.Degrees(-05.27034966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13804"},
        {"Hipparcos Number", "HIP 10430"},
        {"Geneva Identification System", "GEN# +1.00013804"},
        {"Smithsonian Astrophysical Observation", "SAO 129770"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.59166213),
        dec: Angle.Degrees(-05.27005423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37061"},
        {"Hipparcos Number", "HIP 26258"},
        {"Celescope Catalog", "CEL 842"},
        {"Geneva Identification System", "GEN# +9.00010747"},
        {"Geneva Identification System 2", "GEN# +9.00010747V"},
        {"Geneva Identification System 3", "GEN# +2.19760747"},
        {"Smithsonian Astrophysical Observation", "SAO 132328"},
        {"Wilson Evans Batten Catalogue", "WEB 5144"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.88068317),
        dec: Angle.Degrees(-05.26738797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11618"},
        {"Hipparcos Number", "HIP 8852"},
        {"Smithsonian Astrophysical Observation", "SAO 129555"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.46325114),
        dec: Angle.Degrees(-05.26690275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194040"},
        {"Hipparcos Number", "HIP 100570"},
        {"Geneva Identification System", "GEN# +1.00194040"},
        {"Smithsonian Astrophysical Observation", "SAO 144372"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.90929741),
        dec: Angle.Degrees(-05.26617164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128200"},
        {"Hipparcos Number", "HIP 71367"},
        {"Smithsonian Astrophysical Observation", "SAO 140021"},
        {"Wilson Evans Batten Catalogue", "WEB 12322"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.93216955),
        dec: Angle.Degrees(-05.26610424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102444"},
        {"Hipparcos Number", "HIP 57536"},
        {"Smithsonian Astrophysical Observation", "SAO 138405"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.88115602),
        dec: Angle.Degrees(-05.26352562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162713"},
        {"Hipparcos Number", "HIP 87494"},
        {"Smithsonian Astrophysical Observation", "SAO 141925"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.15443631),
        dec: Angle.Degrees(-05.26202187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2857"},
        {"Hipparcos Number", "HIP 2515"},
        {"Geneva Identification System", "GEN# +1.00002857"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.97414916),
        dec: Angle.Degrees(-05.26174957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57364"},
        {"Hipparcos Number", "HIP 35600"},
        {"Geneva Identification System", "GEN# +1.00057364"},
        {"Smithsonian Astrophysical Observation", "SAO 134544"},
        {"Wilson Evans Batten Catalogue", "WEB 7094"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.20187594),
        dec: Angle.Degrees(-05.25992763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100130"},
        {"Hipparcos Number", "HIP 56206"},
        {"Smithsonian Astrophysical Observation", "SAO 138246"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.83504701),
        dec: Angle.Degrees(-05.25928050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89072"},
        {"Hipparcos Number", "HIP 50312"},
        {"Smithsonian Astrophysical Observation", "SAO 137452"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.09789891),
        dec: Angle.Degrees(-05.25849693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34164"},
        {"Hipparcos Number", "HIP 24466"},
        {"Celescope Catalog", "CEL 583"},
        {"Geneva Identification System", "GEN# +1.00034164"},
        {"Smithsonian Astrophysical Observation", "SAO 131915"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.77147122),
        dec: Angle.Degrees(-05.25256259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31748"},
        {"Hipparcos Number", "HIP 23098"},
        {"Smithsonian Astrophysical Observation", "SAO 131643"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.54917900),
        dec: Angle.Degrees(-05.25169978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17976"},
        {"Hipparcos Number", "HIP 13451"},
        {"Smithsonian Astrophysical Observation", "SAO 130164"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.30300226),
        dec: Angle.Degrees(-05.24915780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 587"},
        {"Hipparcos Number", "HIP 840"},
        {"Geneva Identification System", "GEN# +1.00000587"},
        {"Smithsonian Astrophysical Observation", "SAO 128621"},
        {"Wilson Evans Batten Catalogue", "WEB 141"},
    },
    visualMagnitude: 5.84,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.57853868),
        dec: Angle.Degrees(-05.24851713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118957"},
        {"Hipparcos Number", "HIP 66706"},
        {"Geneva Identification System", "GEN# +1.00118957"},
        {"Smithsonian Astrophysical Observation", "SAO 139480"},
        {"Wilson Evans Batten Catalogue", "WEB 11765"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.10515679),
        dec: Angle.Degrees(-05.24529823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223241"},
        {"Hipparcos Number", "HIP 117364"},
        {"Cincinnati Publication", "Ci 18 3122"},
        {"Geneva Identification System", "GEN# +1.00223241"},
        {"Smithsonian Astrophysical Observation", "SAO 146914"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.96255146),
        dec: Angle.Degrees(-05.24379560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19082"},
        {"Hipparcos Number", "HIP 14282"},
        {"Fundamental Katalog 5th Edition", "FK5 4279"},
        {"Smithsonian Astrophysical Observation", "SAO 130265"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.02580494),
        dec: Angle.Degrees(-05.24332560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135981"},
        {"Hipparcos Number", "HIP 74884"},
        {"Geneva Identification System", "GEN# +1.00135981"},
        {"Smithsonian Astrophysical Observation", "SAO 140440"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.56061137),
        dec: Angle.Degrees(-05.24296995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75156"},
        {"Smithsonian Astrophysical Observation", "SAO 140481"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.38567019),
        dec: Angle.Degrees(-05.24284024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69270"},
        {"Hipparcos Number", "HIP 40498"},
        {"Geneva Identification System", "GEN# +2.25482184"},
        {"Smithsonian Astrophysical Observation", "SAO 135700"},
        {"New General Catalogue", "NGC 2548 2184"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.02774956),
        dec: Angle.Degrees(-05.24253947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 128.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101308",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13956 AB"},
        {"Henry Draper", "HD 195535"},
        {"Hipparcos Number", "HIP 101308"},
        {"Smithsonian Astrophysical Observation", "SAO 144537"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.02132988),
        dec: Angle.Degrees(-05.24242312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109318"},
        {"Hipparcos Number", "HIP 61322"},
        {"Smithsonian Astrophysical Observation", "SAO 138846"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.45208697),
        dec: Angle.Degrees(-05.24226721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 888"},
        {"Hipparcos Number", "HIP 1062"},
        {"Smithsonian Astrophysical Observation", "SAO 128644"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.30062556),
        dec: Angle.Degrees(-05.24201804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75282"},
        {"Hipparcos Number", "HIP 43284"},
        {"Smithsonian Astrophysical Observation", "SAO 136301"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.26338151),
        dec: Angle.Degrees(-05.23975661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78555"},
        {"Hipparcos Number", "HIP 44893"},
        {"Smithsonian Astrophysical Observation", "SAO 136607"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.20097496),
        dec: Angle.Degrees(-05.23556991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187006"},
        {"Hipparcos Number", "HIP 97400"},
        {"Smithsonian Astrophysical Observation", "SAO 143804"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.94562505),
        dec: Angle.Degrees(-05.23358003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11997"},
        {"Hipparcos Number", "HIP 9127"},
        {"Geneva Identification System", "GEN# +1.00011997"},
        {"Smithsonian Astrophysical Observation", "SAO 129584"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.41631173),
        dec: Angle.Degrees(-05.23293301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 196.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -204.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205802"},
        {"Hipparcos Number", "HIP 106796"},
        {"Geneva Identification System", "GEN# +1.00205802"},
        {"Smithsonian Astrophysical Observation", "SAO 145540"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.46027622),
        dec: Angle.Degrees(-05.23258953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220785"},
        {"Hipparcos Number", "HIP 115720"},
        {"Fundamental Katalog 5th Edition", "FK5 6070"},
        {"Smithsonian Astrophysical Observation", "SAO 146708"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.66534071),
        dec: Angle.Degrees(-05.23216112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76360",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76360"},
        {"Smithsonian Astrophysical Observation", "SAO 140627"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.93268959),
        dec: Angle.Degrees(-05.22875489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89507"},
        {"Hipparcos Number", "HIP 50554"},
        {"Fundamental Katalog 5th Edition", "FK5 4918"},
        {"Geneva Identification System", "GEN# +1.00089507"},
        {"Smithsonian Astrophysical Observation", "SAO 137493"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.89867165),
        dec: Angle.Degrees(-05.22731344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59669"},
        {"Hipparcos Number", "HIP 36526"},
        {"Fundamental Katalog 5th Edition", "FK5 2582"},
        {"Geneva Identification System", "GEN# +1.00059669"},
        {"Smithsonian Astrophysical Observation", "SAO 134774"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.71307331),
        dec: Angle.Degrees(-05.22648597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105654"},
        {"Hipparcos Number", "HIP 59292"},
        {"Geneva Identification System", "GEN# +1.00105654"},
        {"Smithsonian Astrophysical Observation", "SAO 138617"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.44907727),
        dec: Angle.Degrees(-05.22577894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40712"},
        {"Hipparcos Number", "HIP 28446"},
        {"Smithsonian Astrophysical Observation", "SAO 132737"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.09247310),
        dec: Angle.Degrees(-05.22374752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72506"},
        {"Hipparcos Number", "HIP 41961"},
        {"Geneva Identification System", "GEN# +1.00072506"},
        {"Smithsonian Astrophysical Observation", "SAO 136026"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.29522239),
        dec: Angle.Degrees(-05.22261271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76182",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76182"},
        {"Smithsonian Astrophysical Observation", "SAO 140604"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.41061769),
        dec: Angle.Degrees(-05.22242183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77876",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77876"},
        {"Smithsonian Astrophysical Observation", "SAO 140828"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.54513977),
        dec: Angle.Degrees(-05.22175402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110417"},
        {"Hipparcos Number", "HIP 61971"},
        {"Geneva Identification System", "GEN# +1.00110417"},
        {"Smithsonian Astrophysical Observation", "SAO 138921"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.49833571),
        dec: Angle.Degrees(-05.22079689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88709"},
        {"Hipparcos Number", "HIP 50105"},
        {"Smithsonian Astrophysical Observation", "SAO 137425"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.44323071),
        dec: Angle.Degrees(-05.21978217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126962"},
        {"Hipparcos Number", "HIP 70802"},
        {"Smithsonian Astrophysical Observation", "SAO 139959"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.20068991),
        dec: Angle.Degrees(-05.21876395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50058"},
        {"Smithsonian Astrophysical Observation", "SAO 137416"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.30894341),
        dec: Angle.Degrees(-05.21772222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58732"},
        {"Hipparcos Number", "HIP 36150"},
        {"Smithsonian Astrophysical Observation", "SAO 134675"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.69830856),
        dec: Angle.Degrees(-05.21714625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125711"},
        {"Hipparcos Number", "HIP 70162"},
        {"Smithsonian Astrophysical Observation", "SAO 139883"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.33075020),
        dec: Angle.Degrees(-05.21548653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224947"},
        {"Hipparcos Number", "HIP 157"},
        {"Geneva Identification System", "GEN# +1.00224947"},
        {"Smithsonian Astrophysical Observation", "SAO 147044"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.50032768),
        dec: Angle.Degrees(-05.21399723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220586"},
        {"Hipparcos Number", "HIP 115599"},
        {"Smithsonian Astrophysical Observation", "SAO 146696"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.24860649),
        dec: Angle.Degrees(-05.21167780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30756"},
        {"Hipparcos Number", "HIP 22477"},
        {"Smithsonian Astrophysical Observation", "SAO 131531"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.54269467),
        dec: Angle.Degrees(-05.21152499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122241"},
        {"Hipparcos Number", "HIP 68452"},
        {"Smithsonian Astrophysical Observation", "SAO 139677"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.21257903),
        dec: Angle.Degrees(-05.21115967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47054"},
        {"Hipparcos Number", "HIP 31583"},
        {"Fundamental Katalog 5th Edition", "FK5 2509"},
        {"Geneva Identification System", "GEN# +1.00047054"},
        {"Smithsonian Astrophysical Observation", "SAO 133469"},
        {"Wilson Evans Batten Catalogue", "WEB 6323"},
    },
    visualMagnitude: 5.52,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.14720939),
        dec: Angle.Degrees(-05.21110831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22920"},
        {"Hipparcos Number", "HIP 17167"},
        {"Fundamental Katalog 5th Edition", "FK5 2260"},
        {"Geneva Identification System", "GEN# +1.00022920"},
        {"Renson", "Renson 5840"},
        {"Smithsonian Astrophysical Observation", "SAO 130652"},
        {"Wilson Evans Batten Catalogue", "WEB 3252"},
    },
    visualMagnitude: 5.53,
    bvColour: -0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.15972132),
        dec: Angle.Degrees(-05.21069726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34827"},
        {"Hipparcos Number", "HIP 24882"},
        {"Celescope Catalog", "CEL 627"},
        {"Geneva Identification System", "GEN# +1.00034827"},
        {"Smithsonian Astrophysical Observation", "SAO 131994"},
    },
    visualMagnitude: 7.18,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.01329817),
        dec: Angle.Degrees(-05.20834095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75992",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75992"},
        {"Smithsonian Astrophysical Observation", "SAO 140581"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.78685012),
        dec: Angle.Degrees(-05.20741613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89133",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11135 A"},
        {"Henry Draper", "HD 166563"},
        {"Hipparcos Number", "HIP 89133"},
        {"Smithsonian Astrophysical Observation", "SAO 142140"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.86223249),
        dec: Angle.Degrees(-05.20499574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208672"},
        {"Hipparcos Number", "HIP 108438"},
        {"Geneva Identification System", "GEN# +1.00208672"},
        {"Smithsonian Astrophysical Observation", "SAO 145774"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.50427628),
        dec: Angle.Degrees(-05.20390094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135872"},
        {"Hipparcos Number", "HIP 74842"},
        {"Smithsonian Astrophysical Observation", "SAO 140435"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.42191208),
        dec: Angle.Degrees(-05.20238131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36234"},
        {"Hipparcos Number", "HIP 25770"},
        {"Geneva Identification System", "GEN# +1.00036234"},
        {"Smithsonian Astrophysical Observation", "SAO 132187"},
    },
    visualMagnitude: 8.65,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.54313283),
        dec: Angle.Degrees(-05.20161588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211650"},
        {"Hipparcos Number", "HIP 110134"},
        {"Smithsonian Astrophysical Observation", "SAO 146011"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.63797268),
        dec: Angle.Degrees(-05.20149487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67856"},
        {"Hipparcos Number", "HIP 39975"},
        {"Smithsonian Astrophysical Observation", "SAO 135573"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.45098298),
        dec: Angle.Degrees(-05.19943335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101516"},
        {"Hipparcos Number", "HIP 56982"},
        {"Smithsonian Astrophysical Observation", "SAO 138344"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.21449681),
        dec: Angle.Degrees(-05.19860821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37526"},
        {"Hipparcos Number", "HIP 26581"},
        {"Celescope Catalog", "CEL 899"},
        {"Geneva Identification System", "GEN# +1.00037526"},
        {"Smithsonian Astrophysical Observation", "SAO 132414"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.76000239),
        dec: Angle.Degrees(-05.19445592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1788"},
        {"Hipparcos Number", "HIP 1755"},
        {"Smithsonian Astrophysical Observation", "SAO 128718"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.55937288),
        dec: Angle.Degrees(-05.19188884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154945"},
        {"Hipparcos Number", "HIP 83901"},
        {"Geneva Identification System", "GEN# +1.00154945"},
        {"Smithsonian Astrophysical Observation", "SAO 141534"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.20626658),
        dec: Angle.Degrees(-05.19171435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5095"},
        {"Geneva Identification System", "GEN# -0.00500184"},
    },
    visualMagnitude: 11.23,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.32607936),
        dec: Angle.Degrees(-05.19140136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -185.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -233.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225014"},
        {"Hipparcos Number", "HIP 205"},
        {"Smithsonian Astrophysical Observation", "SAO 128548"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.64571113),
        dec: Angle.Degrees(-05.18664439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188956"},
        {"Hipparcos Number", "HIP 98257"},
        {"Geneva Identification System", "GEN# +1.00188956"},
        {"Smithsonian Astrophysical Observation", "SAO 143954"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.48732474),
        dec: Angle.Degrees(-05.18561901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5834"},
        {"Hipparcos Number", "HIP 4661"},
        {"Geneva Identification System", "GEN# +1.00005834"},
        {"Smithsonian Astrophysical Observation", "SAO 129071"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.97289743),
        dec: Angle.Degrees(-05.18399690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4916"},
        {"Hipparcos Number", "HIP 3982"},
        {"Smithsonian Astrophysical Observation", "SAO 128987"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.80281043),
        dec: Angle.Degrees(-05.18336284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102391"},
        {"Hipparcos Number", "HIP 57500"},
        {"Smithsonian Astrophysical Observation", "SAO 138403"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.79086940),
        dec: Angle.Degrees(-05.18051621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2533",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 450 ABC"},
        {"Henry Draper", "HD 2880"},
        {"Hipparcos Number", "HIP 2533"},
        {"Cincinnati Publication", "Ci 18 60"},
        {"Geneva Identification System", "GEN# +1.00002880J"},
        {"Smithsonian Astrophysical Observation", "SAO 128813"},
        {"Wilson Evans Batten Catalogue", "WEB 464"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.03376796),
        dec: Angle.Degrees(-05.17864035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 297.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212672"},
        {"Hipparcos Number", "HIP 110739"},
        {"Geneva Identification System", "GEN# +1.00212672"},
        {"Smithsonian Astrophysical Observation", "SAO 146083"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.52833700),
        dec: Angle.Degrees(-05.17788010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126614"},
        {"Henry Draper 2", "HD 126614A"},
        {"Hipparcos Number", "HIP 70623"},
        {"Smithsonian Astrophysical Observation", "SAO 139932"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.70154033),
        dec: Angle.Degrees(-05.17742025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50281"},
        {"Hipparcos Number", "HIP 32984"},
        {"Cincinnati Publication", "Ci 20 399"},
        {"Geneva Identification System", "GEN# +1.00050281A"},
        {"Smithsonian Astrophysical Observation", "SAO 133805"},
        {"Wilson Evans Batten Catalogue", "WEB 6642"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.07653738),
        dec: Angle.Degrees(-05.17370508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -544.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213585"},
        {"Hipparcos Number", "HIP 111281"},
        {"Smithsonian Astrophysical Observation", "SAO 146144"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.15305543),
        dec: Angle.Degrees(-05.17306788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77640"},
        {"Hipparcos Number", "HIP 44476"},
        {"Fundamental Katalog 5th Edition", "FK5 1236"},
        {"Geneva Identification System", "GEN# +1.00077640"},
        {"Smithsonian Astrophysical Observation", "SAO 136542"},
    },
    visualMagnitude: 6.83,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.93095291),
        dec: Angle.Degrees(-05.17137085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31512"},
        {"Hipparcos Number", "HIP 22958"},
        {"Geneva Identification System", "GEN# +1.00031512"},
        {"Smithsonian Astrophysical Observation", "SAO 131614"},
        {"Wilson Evans Batten Catalogue", "WEB 4461"},
    },
    visualMagnitude: 5.50,
    bvColour: -0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.10078852),
        dec: Angle.Degrees(-05.17135066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195673"},
        {"Hipparcos Number", "HIP 101387"},
        {"Smithsonian Astrophysical Observation", "SAO 144551"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.21873199),
        dec: Angle.Degrees(-05.17117108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33547"},
        {"Hipparcos Number", "HIP 24117"},
        {"Celescope Catalog", "CEL 558"},
        {"Fundamental Katalog 5th Edition", "FK5 4473"},
        {"Geneva Identification System", "GEN# +1.00033547"},
        {"Smithsonian Astrophysical Observation", "SAO 131844"},
    },
    visualMagnitude: 8.43,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.69816544),
        dec: Angle.Degrees(-05.16974988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17556"},
        {"Hipparcos Number", "HIP 13135"},
        {"Geneva Identification System", "GEN# +1.00017556"},
        {"Smithsonian Astrophysical Observation", "SAO 130126"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.23241050),
        dec: Angle.Degrees(-05.16917252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83426"},
        {"Hipparcos Number", "HIP 47284"},
        {"Smithsonian Astrophysical Observation", "SAO 137015"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.55033549),
        dec: Angle.Degrees(-05.16653001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115195"},
        {"Geneva Identification System", "GEN# +6.10160464"},
    },
    visualMagnitude: 11.86,
    bvColour: -0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.99335153),
        dec: Angle.Degrees(-05.16560098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32994"},
        {"Hipparcos Number", "HIP 23802"},
        {"Geneva Identification System", "GEN# +1.00032994"},
        {"Smithsonian Astrophysical Observation", "SAO 131780"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.73071555),
        dec: Angle.Degrees(-05.16555869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116568"},
        {"Hipparcos Number", "HIP 65420"},
        {"Geneva Identification System", "GEN# +1.00116568"},
        {"Smithsonian Astrophysical Observation", "SAO 139324"},
        {"Wilson Evans Batten Catalogue", "WEB 11545"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.13806845),
        dec: Angle.Degrees(-05.16392212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218014"},
        {"Hipparcos Number", "HIP 113965"},
        {"Smithsonian Astrophysical Observation", "SAO 146494"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.19644716),
        dec: Angle.Degrees(-05.16316756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171109"},
        {"Hipparcos Number", "HIP 90946"},
        {"Geneva Identification System", "GEN# +1.00171109"},
        {"Smithsonian Astrophysical Observation", "SAO 142380"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.27959789),
        dec: Angle.Degrees(-05.16248764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113449"},
        {"Hipparcos Number", "HIP 63742"},
        {"Smithsonian Astrophysical Observation", "SAO 139129"},
        {"Wilson Evans Batten Catalogue", "WEB 11272"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.95736099),
        dec: Angle.Degrees(-05.16127868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81346",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10125 AB"},
        {"Hipparcos Number", "HIP 81346"},
        {"Smithsonian Astrophysical Observation", "SAO 141272"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.19912452),
        dec: Angle.Degrees(-05.16031874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35590"},
        {"Hipparcos Number", "HIP 25367"},
        {"Smithsonian Astrophysical Observation", "SAO 132089"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.39711204),
        dec: Angle.Degrees(-05.15697199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 294145"},
        {"Hipparcos Number", "HIP 25457"},
        {"Geneva Identification System", "GEN# +1.00294145"},
        {"Smithsonian Astrophysical Observation", "SAO 132110"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.67131482),
        dec: Angle.Degrees(-05.15673396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55684"},
        {"Henry Draper 2", "HD 55685"},
        {"Hipparcos Number", "HIP 34935"},
        {"Geneva Identification System", "GEN# +1.00055684"},
        {"Smithsonian Astrophysical Observation", "SAO 134377"},
        {"Wilson Evans Batten Catalogue", "WEB 6983"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.43565085),
        dec: Angle.Degrees(-05.15553356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45532"},
        {"Hipparcos Number", "HIP 30761"},
        {"Celescope Catalog", "CEL 1250"},
        {"Geneva Identification System", "GEN# +2.22320010"},
        {"Smithsonian Astrophysical Observation", "SAO 133287"},
        {"New General Catalogue", "NGC 2232 10"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.96183399),
        dec: Angle.Degrees(-05.15484927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109452"},
        {"Hipparcos Number", "HIP 61400"},
        {"Smithsonian Astrophysical Observation", "SAO 138857"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.72243575),
        dec: Angle.Degrees(-05.15471966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72783"},
        {"Hipparcos Number", "HIP 42077"},
        {"Smithsonian Astrophysical Observation", "SAO 136058"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.63971302),
        dec: Angle.Degrees(-05.15469127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214130"},
        {"Hipparcos Number", "HIP 111581"},
        {"Smithsonian Astrophysical Observation", "SAO 146190"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.07479708),
        dec: Angle.Degrees(-05.15466036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31983"},
        {"Hipparcos Number", "HIP 23223"},
        {"Smithsonian Astrophysical Observation", "SAO 131667"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.96206318),
        dec: Angle.Degrees(-05.15432312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49370"},
        {"Hipparcos Number", "HIP 32584"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.98693344),
        dec: Angle.Degrees(-05.15399411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28088"},
        {"Hipparcos Number", "HIP 20676"},
        {"Smithsonian Astrophysical Observation", "SAO 131204"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.43225158),
        dec: Angle.Degrees(-05.15306347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24780"},
        {"Hipparcos Number", "HIP 18419"},
        {"Smithsonian Astrophysical Observation", "SAO 130830"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.07023801),
        dec: Angle.Degrees(-05.15298093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40617"},
        {"Hipparcos Number", "HIP 28394"},
        {"Smithsonian Astrophysical Observation", "SAO 132729"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.96147758),
        dec: Angle.Degrees(-05.15173447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34388"},
        {"Hipparcos Number", "HIP 24616"},
        {"Smithsonian Astrophysical Observation", "SAO 131940"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.19957083),
        dec: Angle.Degrees(-05.15144824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125455"},
        {"Hipparcos Number", "HIP 70016"},
        {"Cincinnati Publication", "Ci 20 850"},
        {"Fundamental Katalog 5th Edition", "FK5 5266"},
        {"Geneva Identification System", "GEN# +1.00125455"},
        {"Smithsonian Astrophysical Observation", "SAO 139867"},
        {"Wilson Evans Batten Catalogue", "WEB 12176"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.89680883),
        dec: Angle.Degrees(-05.15089823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -631.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152255"},
        {"Hipparcos Number", "HIP 82558"},
        {"Smithsonian Astrophysical Observation", "SAO 141415"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.12585325),
        dec: Angle.Degrees(-05.14964424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90147",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90147"},
        {"Geneva Identification System", "GEN# +9.80021012"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.95029765),
        dec: Angle.Degrees(-05.14924146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 290.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -406.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116461"},
        {"Hipparcos Number", "HIP 65379"},
        {"Smithsonian Astrophysical Observation", "SAO 139314"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.98485759),
        dec: Angle.Degrees(-05.14863385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71479"},
        {"Hipparcos Number", "HIP 41479"},
        {"Fundamental Katalog 5th Edition", "FK5 4761"},
        {"Geneva Identification System", "GEN# +1.00071479"},
        {"Smithsonian Astrophysical Observation", "SAO 135935"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.89666428),
        dec: Angle.Degrees(-05.14844045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98826"},
        {"Hipparcos Number", "HIP 55527"},
        {"Smithsonian Astrophysical Observation", "SAO 138164"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.59272537),
        dec: Angle.Degrees(-05.14763454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27216"},
        {"Hipparcos Number", "HIP 20029"},
        {"Smithsonian Astrophysical Observation", "SAO 131097"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.43773805),
        dec: Angle.Degrees(-05.14672089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198373"},
        {"Hipparcos Number", "HIP 102829"},
        {"Geneva Identification System", "GEN# +1.00198373"},
        {"Smithsonian Astrophysical Observation", "SAO 144854"},
        {"Wilson Evans Batten Catalogue", "WEB 18649"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.48504100),
        dec: Angle.Degrees(-05.14664125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32528"},
        {"Hipparcos Number", "HIP 23535"},
        {"Smithsonian Astrophysical Observation", "SAO 131730"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.90949284),
        dec: Angle.Degrees(-05.14528311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140211"},
        {"Hipparcos Number", "HIP 76930"},
        {"Smithsonian Astrophysical Observation", "SAO 140711"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.63184277),
        dec: Angle.Degrees(-05.14216096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46034",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46034"},
        {"Geneva Identification System", "GEN# -0.00402606"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.83503502),
        dec: Angle.Degrees(-05.13944821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -250.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20174"},
        {"Hipparcos Number", "HIP 15078"},
        {"Smithsonian Astrophysical Observation", "SAO 130372"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.60260349),
        dec: Angle.Degrees(-05.13877554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20906"},
        {"Hipparcos Number", "HIP 15694"},
        {"Smithsonian Astrophysical Observation", "SAO 130446"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.54699470),
        dec: Angle.Degrees(-05.13767907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40985"},
        {"Hipparcos Number", "HIP 28595"},
        {"Smithsonian Astrophysical Observation", "SAO 132761"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.53693786),
        dec: Angle.Degrees(-05.13693037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113772"},
        {"Hipparcos Number", "HIP 63929"},
        {"Geneva Identification System", "GEN# +1.00113772"},
        {"Smithsonian Astrophysical Observation", "SAO 139151"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.51630294),
        dec: Angle.Degrees(-05.13522751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3757",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3757"},
    },
    visualMagnitude: 12.05,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.05511704),
        dec: Angle.Degrees(-05.13517778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103550"},
        {"Hipparcos Number", "HIP 58137"},
        {"Renson", "Renson 29840"},
        {"Smithsonian Astrophysical Observation", "SAO 138485"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.86009573),
        dec: Angle.Degrees(-05.13452072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221630"},
        {"Hipparcos Number", "HIP 116294"},
        {"Smithsonian Astrophysical Observation", "SAO 146777"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.44373848),
        dec: Angle.Degrees(-05.13245035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20007"},
        {"Hipparcos Number", "HIP 14959"},
        {"Geneva Identification System", "GEN# +1.00020007"},
        {"Smithsonian Astrophysical Observation", "SAO 130357"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.21003780),
        dec: Angle.Degrees(-05.13150363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156379"},
        {"Hipparcos Number", "HIP 84580"},
        {"Smithsonian Astrophysical Observation", "SAO 141592"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.33977763),
        dec: Angle.Degrees(-05.13059473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131955"},
        {"Hipparcos Number", "HIP 73130"},
        {"Smithsonian Astrophysical Observation", "SAO 140236"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.18354663),
        dec: Angle.Degrees(-05.13014363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77133",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77133"},
        {"Smithsonian Astrophysical Observation", "SAO 140730"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.23784915),
        dec: Angle.Degrees(-05.12992432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110900"},
        {"Hipparcos Number", "HIP 62250"},
        {"Smithsonian Astrophysical Observation", "SAO 138953"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.35988081),
        dec: Angle.Degrees(-05.12658837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22379"},
        {"Hipparcos Number", "HIP 16779"},
        {"Smithsonian Astrophysical Observation", "SAO 130598"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.98854090),
        dec: Angle.Degrees(-05.12494411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115142",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16676 A"},
        {"Henry Draper", "HD 219877"},
        {"Hipparcos Number", "HIP 115142"},
        {"Geneva Identification System", "GEN# +1.00219877J"},
        {"Geneva Identification System 2", "GEN# +1.00219877A"},
        {"Smithsonian Astrophysical Observation", "SAO 146639"},
        {"Wilson Evans Batten Catalogue", "WEB 20396"},
    },
    visualMagnitude: 5.56,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.84941462),
        dec: Angle.Degrees(-05.12430243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 200.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84212",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84212"},
        {"Geneva Identification System", "GEN# +9.80019016"},
    },
    visualMagnitude: 11.61,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.21317676),
        dec: Angle.Degrees(-05.12368193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 189.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -695.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65653",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65653"},
        {"Smithsonian Astrophysical Observation", "SAO 139347"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.91382253),
        dec: Angle.Degrees(-05.12120516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104293"},
        {"Hipparcos Number", "HIP 58569"},
        {"Geneva Identification System", "GEN# +1.00104293"},
        {"Smithsonian Astrophysical Observation", "SAO 138528"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.15933365),
        dec: Angle.Degrees(-05.12061775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136380"},
        {"Hipparcos Number", "HIP 75084"},
        {"Smithsonian Astrophysical Observation", "SAO 140471"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.15202133),
        dec: Angle.Degrees(-05.11974365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141085"},
        {"Hipparcos Number", "HIP 77344"},
        {"Geneva Identification System", "GEN# +1.00141085"},
        {"Smithsonian Astrophysical Observation", "SAO 140760"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.84341649),
        dec: Angle.Degrees(-05.11885666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8047",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8047"},
        {"Smithsonian Astrophysical Observation", "SAO 129469"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.83331714),
        dec: Angle.Degrees(-05.11849265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81420"},
        {"Hipparcos Number", "HIP 46221"},
        {"Fundamental Katalog 5th Edition", "FK5 1245"},
        {"Geneva Identification System", "GEN# +1.00081420"},
        {"Smithsonian Astrophysical Observation", "SAO 136832"},
        {"Wilson Evans Batten Catalogue", "WEB 8745"},
    },
    visualMagnitude: 5.60,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.35017628),
        dec: Angle.Degrees(-05.11737880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97443"},
        {"Hipparcos Number", "HIP 54769"},
        {"Smithsonian Astrophysical Observation", "SAO 138063"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.19343135),
        dec: Angle.Degrees(-05.11694034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211964"},
        {"Hipparcos Number", "HIP 110359"},
        {"Smithsonian Astrophysical Observation", "SAO 146037"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.27844244),
        dec: Angle.Degrees(-05.11677272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78538"},
        {"Hipparcos Number", "HIP 44890"},
        {"Geneva Identification System", "GEN# +1.00078538"},
        {"Smithsonian Astrophysical Observation", "SAO 136606"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.19581920),
        dec: Angle.Degrees(-05.11626577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38389"},
        {"Hipparcos Number", "HIP 27138"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.31271463),
        dec: Angle.Degrees(-05.11147263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72363"},
        {"Hipparcos Number", "HIP 41876"},
        {"Smithsonian Astrophysical Observation", "SAO 136012"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.07590995),
        dec: Angle.Degrees(-05.10814312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222090"},
        {"Hipparcos Number", "HIP 116587"},
        {"Smithsonian Astrophysical Observation", "SAO 146808"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.40433757),
        dec: Angle.Degrees(-05.10769697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89490"},
        {"Hipparcos Number", "HIP 50552"},
        {"Geneva Identification System", "GEN# +1.00089490"},
        {"Smithsonian Astrophysical Observation", "SAO 137490"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.88486981),
        dec: Angle.Degrees(-05.10597604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214983"},
        {"Hipparcos Number", "HIP 112078"},
        {"Smithsonian Astrophysical Observation", "SAO 146251"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.52494082),
        dec: Angle.Degrees(-05.10183894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191147"},
        {"Hipparcos Number", "HIP 99225"},
        {"Smithsonian Astrophysical Observation", "SAO 144107"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.14095877),
        dec: Angle.Degrees(-05.10047789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219818"},
        {"Hipparcos Number", "HIP 115105"},
        {"Smithsonian Astrophysical Observation", "SAO 146634"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.71171956),
        dec: Angle.Degrees(-05.09963119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218846"},
        {"Hipparcos Number", "HIP 114493"},
        {"Smithsonian Astrophysical Observation", "SAO 146550"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.82150395),
        dec: Angle.Degrees(-05.09876397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75396",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9620 AB"},
        {"Henry Draper", "HD 137113"},
        {"Hipparcos Number", "HIP 75396"},
        {"Smithsonian Astrophysical Observation", "SAO 140507"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.08754519),
        dec: Angle.Degrees(-05.09876303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54072"},
    },
    visualMagnitude: 11.52,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.96579544),
        dec: Angle.Degrees(-05.09845098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -296.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128334"},
        {"Hipparcos Number", "HIP 71424"},
        {"Smithsonian Astrophysical Observation", "SAO 140028"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.08854377),
        dec: Angle.Degrees(-05.09622960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63841"},
        {"Hipparcos Number", "HIP 38298"},
        {"Smithsonian Astrophysical Observation", "SAO 135168"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.69709432),
        dec: Angle.Degrees(-05.09600905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89012"},
        {"Hipparcos Number", "HIP 50285"},
        {"Smithsonian Astrophysical Observation", "SAO 137447"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.00520001),
        dec: Angle.Degrees(-05.09598057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74505"},
        {"Hipparcos Number", "HIP 42880"},
        {"Smithsonian Astrophysical Observation", "SAO 136229"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.08620729),
        dec: Angle.Degrees(-05.09475604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83599",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 42"},
        {"Henry Draper", "HD 154363B"},
        {"Hipparcos Number", "HIP 83599"},
        {"Cincinnati Publication", "Ci 20 1018"},
        {"Geneva Identification System", "GEN# +1.00154363B"},
        {"Geneva Identification System 2", "GEN# +9.80019014"},
        {"Geneva Identification System 3", "GEN# -0.00404226"},
        {"Wilson Evans Batten Catalogue", "WEB 14140"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.30965695),
        dec: Angle.Degrees(-05.09148544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -921.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1128.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28054"},
        {"Hipparcos Number", "HIP 20658"},
        {"Smithsonian Astrophysical Observation", "SAO 131201"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.40074727),
        dec: Angle.Degrees(-05.09132298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92277"},
        {"Geneva Identification System", "GEN# -0.00504767"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.09096249),
        dec: Angle.Degrees(-05.09084271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 198.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -229.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16378"},
        {"Hipparcos Number", "HIP 12234"},
        {"Smithsonian Astrophysical Observation", "SAO 130025"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.38117160),
        dec: Angle.Degrees(-05.08971176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88682"},
        {"Hipparcos Number", "HIP 50084"},
        {"Geneva Identification System", "GEN# +1.00088682"},
        {"Smithsonian Astrophysical Observation", "SAO 137421"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.38059136),
        dec: Angle.Degrees(-05.08726303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157950"},
        {"Hipparcos Number", "HIP 85365"},
        {"Fundamental Katalog 5th Edition", "FK5 647"},
        {"Geneva Identification System", "GEN# +1.00157950"},
        {"Smithsonian Astrophysical Observation", "SAO 141665"},
        {"Wilson Evans Batten Catalogue", "WEB 14415"},
    },
    visualMagnitude: 4.53,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.65806271),
        dec: Angle.Degrees(-05.08649188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23875",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Cursa"},
        {"Henry Draper", "HD 33111"},
        {"Hipparcos Number", "HIP 23875"},
        {"Celescope Catalog", "CEL 541"},
        {"Fundamental Katalog 5th Edition", "FK5 188"},
        {"Geneva Identification System", "GEN# +1.00033111"},
        {"Smithsonian Astrophysical Observation", "SAO 131794"},
        {"Wilson Evans Batten Catalogue", "WEB 4660"},
    },
    visualMagnitude: 2.78,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.96264146),
        dec: Angle.Degrees(-05.08626282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129393"},
        {"Hipparcos Number", "HIP 71903"},
        {"Smithsonian Astrophysical Observation", "SAO 140086"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.60647701),
        dec: Angle.Degrees(-05.08543680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33903"},
        {"Hipparcos Number", "HIP 24330"},
        {"Renson", "Renson 8639"},
        {"Smithsonian Astrophysical Observation", "SAO 131879"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.32117336),
        dec: Angle.Degrees(-05.08351999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197967"},
        {"Hipparcos Number", "HIP 102577"},
        {"Geneva Identification System", "GEN# +1.00197967"},
        {"Smithsonian Astrophysical Observation", "SAO 144805"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.80964821),
        dec: Angle.Degrees(-05.08315142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143396"},
        {"Hipparcos Number", "HIP 78396"},
        {"Geneva Identification System", "GEN# +1.00143396"},
        {"Smithsonian Astrophysical Observation", "SAO 140892"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.06886247),
        dec: Angle.Degrees(-05.08161487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193862"},
        {"Hipparcos Number", "HIP 100489"},
        {"Smithsonian Astrophysical Observation", "SAO 144357"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.66713656),
        dec: Angle.Degrees(-05.08114597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13976"},
        {"Hipparcos Number", "HIP 10553"},
        {"Geneva Identification System", "GEN# +1.00013976"},
        {"Smithsonian Astrophysical Observation", "SAO 129786"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.97559867),
        dec: Angle.Degrees(-05.08074119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82447"},
        {"Hipparcos Number", "HIP 46762"},
        {"Smithsonian Astrophysical Observation", "SAO 136931"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.96544598),
        dec: Angle.Degrees(-05.07998417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9807"},
        {"Hipparcos Number", "HIP 7427"},
        {"Smithsonian Astrophysical Observation", "SAO 129391"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.92045504),
        dec: Angle.Degrees(-05.07746687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24120"},
        {"Hipparcos Number", "HIP 17957"},
        {"Smithsonian Astrophysical Observation", "SAO 130764"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.58434583),
        dec: Angle.Degrees(-05.07606464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143295"},
        {"Hipparcos Number", "HIP 78336"},
        {"Geneva Identification System", "GEN# +1.00143295"},
        {"Smithsonian Astrophysical Observation", "SAO 140884"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.92647971),
        dec: Angle.Degrees(-05.07601883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21790"},
        {"Hipparcos Number", "HIP 16341"},
        {"Fundamental Katalog 5th Edition", "FK5 1097"},
        {"Geneva Identification System", "GEN# +1.00021790"},
        {"Smithsonian Astrophysical Observation", "SAO 130528"},
        {"Wilson Evans Batten Catalogue", "WEB 3125"},
    },
    visualMagnitude: 4.74,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.65437447),
        dec: Angle.Degrees(-05.07516332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51673"},
        {"Hipparcos Number", "HIP 33538"},
        {"Geneva Identification System", "GEN# +1.00051673"},
        {"Renson", "Renson 14214"},
        {"Smithsonian Astrophysical Observation", "SAO 133966"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.54955328),
        dec: Angle.Degrees(-05.07479072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35040"},
        {"Hipparcos Number", "HIP 25032"},
        {"Smithsonian Astrophysical Observation", "SAO 132027"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.40877803),
        dec: Angle.Degrees(-05.07451196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85857"},
        {"Hipparcos Number", "HIP 48597"},
        {"Smithsonian Astrophysical Observation", "SAO 137219"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.65504575),
        dec: Angle.Degrees(-05.07268752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120919"},
        {"Hipparcos Number", "HIP 67741"},
        {"Smithsonian Astrophysical Observation", "SAO 139600"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.14666300),
        dec: Angle.Degrees(-05.07044326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103275"},
        {"Hipparcos Number", "HIP 57980"},
        {"Smithsonian Astrophysical Observation", "SAO 138461"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.39777133),
        dec: Angle.Degrees(-05.06896702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 729"},
        {"Hipparcos Number", "HIP 936"},
        {"Smithsonian Astrophysical Observation", "SAO 128632"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.89868324),
        dec: Angle.Degrees(-05.06817692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98281"},
        {"Hipparcos Number", "HIP 55210"},
        {"Cincinnati Publication", "Ci 20 628"},
        {"Fundamental Katalog 5th Edition", "FK5 4994"},
        {"Geneva Identification System", "GEN# +1.00098281"},
        {"Smithsonian Astrophysical Observation", "SAO 138119"},
        {"Wilson Evans Batten Catalogue", "WEB 9949"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.58977483),
        dec: Angle.Degrees(-05.06693610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 794.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42259"},
        {"Hipparcos Number", "HIP 29201"},
        {"Geneva Identification System", "GEN# +1.00042259"},
        {"Smithsonian Astrophysical Observation", "SAO 132898"},
        {"Wilson Evans Batten Catalogue", "WEB 5728"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.39013310),
        dec: Angle.Degrees(-05.06673963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105221"},
        {"Hipparcos Number", "HIP 59082"},
        {"Smithsonian Astrophysical Observation", "SAO 138590"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.74334053),
        dec: Angle.Degrees(-05.06574483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154363"},
        {"Hipparcos Number", "HIP 83591"},
        {"Cincinnati Publication", "Ci 20 1017"},
        {"Fundamental Katalog 5th Edition", "FK5 5505"},
        {"Geneva Identification System", "GEN# +1.00154363A"},
        {"Smithsonian Astrophysical Observation", "SAO 141508"},
        {"Wilson Evans Batten Catalogue", "WEB 14132"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.26637934),
        dec: Angle.Degrees(-05.06374190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -916.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1137.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43950"},
        {"Hipparcos Number", "HIP 29998"},
        {"Geneva Identification System", "GEN# +1.00043950"},
        {"Smithsonian Astrophysical Observation", "SAO 133089"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.71294202),
        dec: Angle.Degrees(-05.06370182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 294788"},
        {"Hipparcos Number", "HIP 29358"},
        {"Smithsonian Astrophysical Observation", "SAO 132932"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.82466602),
        dec: Angle.Degrees(-05.06253237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185094"},
        {"Hipparcos Number", "HIP 96551"},
        {"Geneva Identification System", "GEN# +1.00185094"},
        {"Smithsonian Astrophysical Observation", "SAO 143618"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.43212862),
        dec: Angle.Degrees(-05.06175154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34342"},
        {"Hipparcos Number", "HIP 24596"},
        {"Celescope Catalog", "CEL 589"},
        {"Geneva Identification System", "GEN# +1.00034342"},
        {"Renson", "Renson 8736"},
        {"Smithsonian Astrophysical Observation", "SAO 131934"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.14293939),
        dec: Angle.Degrees(-05.06142273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41595"},
        {"Hipparcos Number", "HIP 28883"},
        {"Smithsonian Astrophysical Observation", "SAO 132826"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.47458592),
        dec: Angle.Degrees(-05.06071569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221296"},
        {"Hipparcos Number", "HIP 116057"},
        {"Smithsonian Astrophysical Observation", "SAO 146747"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.73921754),
        dec: Angle.Degrees(-05.06071512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22171"},
        {"Hipparcos Number", "HIP 16648"},
        {"Smithsonian Astrophysical Observation", "SAO 130580"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.55274663),
        dec: Angle.Degrees(-05.05844288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41105"},
        {"Hipparcos Number", "HIP 28638"},
        {"Smithsonian Astrophysical Observation", "SAO 132775"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.70973800),
        dec: Angle.Degrees(-05.05789247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163289"},
        {"Hipparcos Number", "HIP 87757"},
        {"Smithsonian Astrophysical Observation", "SAO 141961"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.89413133),
        dec: Angle.Degrees(-05.05697219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149268"},
        {"Hipparcos Number", "HIP 81105"},
        {"Smithsonian Astrophysical Observation", "SAO 141244"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.47953476),
        dec: Angle.Degrees(-05.05558238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62549"},
        {"Hipparcos Number", "HIP 37732"},
        {"Geneva Identification System", "GEN# +1.00062549"},
        {"Smithsonian Astrophysical Observation", "SAO 135048"},
        {"Wilson Evans Batten Catalogue", "WEB 7457"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.08234822),
        dec: Angle.Degrees(-05.05541216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 192.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24371"},
        {"Hipparcos Number", "HIP 18122"},
        {"Geneva Identification System", "GEN# +1.00024371"},
        {"Smithsonian Astrophysical Observation", "SAO 130785"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.12855596),
        dec: Angle.Degrees(-05.05421215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3295"},
        {"Hipparcos Number", "HIP 2836"},
        {"Smithsonian Astrophysical Observation", "SAO 128851"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.99078400),
        dec: Angle.Degrees(-05.05268078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109014"},
        {"Hipparcos Number", "HIP 61134"},
        {"Geneva Identification System", "GEN# +1.00109014"},
        {"Smithsonian Astrophysical Observation", "SAO 138832"},
        {"Wilson Evans Batten Catalogue", "WEB 10880"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.91142055),
        dec: Angle.Degrees(-05.05266679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205605"},
        {"Hipparcos Number", "HIP 106686"},
        {"Smithsonian Astrophysical Observation", "SAO 145520"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.13583597),
        dec: Angle.Degrees(-05.05249593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37634"},
        {"Hipparcos Number", "HIP 26641"},
        {"Geneva Identification System", "GEN# +1.00037634"},
        {"Smithsonian Astrophysical Observation", "SAO 132426"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.93428002),
        dec: Angle.Degrees(-05.05144223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 297.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19376"},
        {"Hipparcos Number", "HIP 14473"},
        {"Geneva Identification System", "GEN# +1.00019376"},
        {"Smithsonian Astrophysical Observation", "SAO 130289"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.70015154),
        dec: Angle.Degrees(-05.05099686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131585"},
        {"Hipparcos Number", "HIP 72956"},
        {"Smithsonian Astrophysical Observation", "SAO 140217"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.65346633),
        dec: Angle.Degrees(-05.05060679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163976"},
        {"Hipparcos Number", "HIP 88058"},
        {"Geneva Identification System", "GEN# +1.00163976"},
        {"Smithsonian Astrophysical Observation", "SAO 142007"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.76964779),
        dec: Angle.Degrees(-05.04834189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74687",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74687"},
        {"Smithsonian Astrophysical Observation", "SAO 140419"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.95306867),
        dec: Angle.Degrees(-05.04749701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62693"},
        {"Smithsonian Astrophysical Observation", "SAO 138993"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.69779875),
        dec: Angle.Degrees(-05.04718992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14197"},
        {"Smithsonian Astrophysical Observation", "SAO 130257"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.77247318),
        dec: Angle.Degrees(-05.04711252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7449"},
        {"Hipparcos Number", "HIP 5806"},
        {"Cincinnati Publication", "Ci 18 158"},
        {"Geneva Identification System", "GEN# +1.00007449"},
        {"Smithsonian Astrophysical Observation", "SAO 129195"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.62256714),
        dec: Angle.Degrees(-05.04704963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37444"},
        {"Hipparcos Number", "HIP 26524"},
        {"Celescope Catalog", "CEL 883"},
        {"Geneva Identification System", "GEN# +1.00037444"},
        {"Renson", "Renson 10060"},
        {"Smithsonian Astrophysical Observation", "SAO 132396"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.61258120),
        dec: Angle.Degrees(-05.04465189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80968"},
        {"Hipparcos Number", "HIP 45998"},
        {"Smithsonian Astrophysical Observation", "SAO 136797"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.71081452),
        dec: Angle.Degrees(-05.03935320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4915"},
        {"Hipparcos Number", "HIP 3979"},
        {"Cincinnati Publication", "Ci 18 111"},
        {"Geneva Identification System", "GEN# +1.00004915"},
        {"Smithsonian Astrophysical Observation", "SAO 128986"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.79456039),
        dec: Angle.Degrees(-05.03898875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 262.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28821"},
        {"Hipparcos Number", "HIP 21172"},
        {"Geneva Identification System", "GEN# +1.00028821"},
        {"Smithsonian Astrophysical Observation", "SAO 131278"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.08947123),
        dec: Angle.Degrees(-05.03891942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220320"},
        {"Hipparcos Number", "HIP 115420"},
        {"Smithsonian Astrophysical Observation", "SAO 146676"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.70659052),
        dec: Angle.Degrees(-05.03641100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107018"},
        {"Hipparcos Number", "HIP 60006"},
        {"Smithsonian Astrophysical Observation", "SAO 138705"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.60009501),
        dec: Angle.Degrees(-05.03124215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15598"},
        {"Hipparcos Number", "HIP 11664"},
        {"Geneva Identification System", "GEN# +1.00015598"},
        {"Smithsonian Astrophysical Observation", "SAO 129945"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.61025695),
        dec: Angle.Degrees(-05.03105927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8657"},
        {"Hipparcos Number", "HIP 6654"},
        {"Smithsonian Astrophysical Observation", "SAO 129290"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.33417231),
        dec: Angle.Degrees(-05.02837002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198026"},
        {"Hipparcos Number", "HIP 102624"},
        {"Fundamental Katalog 5th Edition", "FK5 1543"},
        {"Geneva Identification System", "GEN# +1.00198026"},
        {"Smithsonian Astrophysical Observation", "SAO 144814"},
        {"Wilson Evans Batten Catalogue", "WEB 18595"},
    },
    visualMagnitude: 4.43,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.93432462),
        dec: Angle.Degrees(-05.02760303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11453",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11453"},
        {"Smithsonian Astrophysical Observation", "SAO 129919"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.94196562),
        dec: Angle.Degrees(-05.02732592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 239.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64595",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64595"},
        {"Smithsonian Astrophysical Observation", "SAO 139237"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.60308867),
        dec: Angle.Degrees(-05.02715259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16695"},
        {"Hipparcos Number", "HIP 12474"},
        {"Smithsonian Astrophysical Observation", "SAO 130050"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.14262183),
        dec: Angle.Degrees(-05.02575561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114823"},
        {"Hipparcos Number", "HIP 64499"},
        {"Geneva Identification System", "GEN# +1.00114823"},
        {"Smithsonian Astrophysical Observation", "SAO 139225"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.30592621),
        dec: Angle.Degrees(-05.02343833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 235.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81465",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81465"},
        {"Geneva Identification System", "GEN# -0.00404138"},
    },
    visualMagnitude: 10.38,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.58183381),
        dec: Angle.Degrees(-05.02058344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86694"},
        {"Hipparcos Number", "HIP 49021"},
        {"Smithsonian Astrophysical Observation", "SAO 137276"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.01611612),
        dec: Angle.Degrees(-05.01272282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133602"},
        {"Hipparcos Number", "HIP 73843"},
        {"Geneva Identification System", "GEN# +1.00133602"},
        {"Smithsonian Astrophysical Observation", "SAO 140311"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.37179550),
        dec: Angle.Degrees(-05.00975324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42911"},
        {"Hipparcos Number", "HIP 29526"},
        {"Geneva Identification System", "GEN# +1.00042911"},
        {"Smithsonian Astrophysical Observation", "SAO 132977"},
        {"Wilson Evans Batten Catalogue", "WEB 5803"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.30240154),
        dec: Angle.Degrees(-05.00974708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4302"},
        {"Hipparcos Number", "HIP 3549"},
        {"Smithsonian Astrophysical Observation", "SAO 128934"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.33436668),
        dec: Angle.Degrees(-05.00911730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20469",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3176 B"},
        {"Henry Draper", "HD 27810B"},
        {"Hipparcos Number", "HIP 20469"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.80858450),
        dec: Angle.Degrees(-05.00841522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222879"},
        {"Hipparcos Number", "HIP 117119"},
        {"Smithsonian Astrophysical Observation", "SAO 146878"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.14559959),
        dec: Angle.Degrees(-05.00706766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20471",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3176 A"},
        {"Henry Draper", "HD 27810"},
        {"Hipparcos Number", "HIP 20471"},
        {"Smithsonian Astrophysical Observation", "SAO 131166"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.81254718),
        dec: Angle.Degrees(-05.00565075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2324"},
        {"Hipparcos Number", "HIP 2138"},
        {"Smithsonian Astrophysical Observation", "SAO 128766"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.77260435),
        dec: Angle.Degrees(-05.00374259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112018"},
        {"Hipparcos Number", "HIP 62898"},
        {"Smithsonian Astrophysical Observation", "SAO 139023"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.36004633),
        dec: Angle.Degrees(-05.00363616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112135"},
    },
    visualMagnitude: 10.60,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.71663834),
        dec: Angle.Degrees(-04.99832619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -357.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38120"},
        {"Hipparcos Number", "HIP 26955"},
        {"Celescope Catalog", "CEL 942"},
        {"Geneva Identification System", "GEN# +1.00038120"},
        {"Smithsonian Astrophysical Observation", "SAO 132483"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.79954774),
        dec: Angle.Degrees(-04.99718256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169369"},
        {"Hipparcos Number", "HIP 90220"},
        {"Smithsonian Astrophysical Observation", "SAO 142283"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.12931598),
        dec: Angle.Degrees(-04.99437051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35543",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5992 A"},
        {"Henry Draper", "HD 57213"},
        {"Hipparcos Number", "HIP 35543"},
        {"Smithsonian Astrophysical Observation", "SAO 134526"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.01951126),
        dec: Angle.Degrees(-04.99143972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37220",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6245 AB"},
        {"Henry Draper", "HD 61344"},
        {"Hipparcos Number", "HIP 37220"},
        {"Smithsonian Astrophysical Observation", "SAO 134934"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.68030308),
        dec: Angle.Degrees(-04.99137147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63067"},
        {"Hipparcos Number", "HIP 37959"},
        {"Fundamental Katalog 5th Edition", "FK5 4702"},
        {"Geneva Identification System", "GEN# +1.00063067"},
        {"Smithsonian Astrophysical Observation", "SAO 135091"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.71119135),
        dec: Angle.Degrees(-04.99121550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189825"},
        {"Hipparcos Number", "HIP 98643"},
        {"Fundamental Katalog 5th Edition", "FK5 3601"},
        {"Geneva Identification System", "GEN# +1.00189825"},
        {"Smithsonian Astrophysical Observation", "SAO 144009"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.54397052),
        dec: Angle.Degrees(-04.98978212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73309",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9457 A"},
        {"Henry Draper", "HD 132375"},
        {"Henry Draper 2", "HD 132375A"},
        {"Hipparcos Number", "HIP 73309"},
        {"Geneva Identification System", "GEN# +1.00132375"},
        {"Smithsonian Astrophysical Observation", "SAO 140256"},
        {"Wilson Evans Batten Catalogue", "WEB 12557"},
    },
    visualMagnitude: 6.08,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.72080247),
        dec: Angle.Degrees(-04.98899499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -358.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113184",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16365 AB"},
        {"Henry Draper", "HD 216718"},
        {"Hipparcos Number", "HIP 113184"},
        {"Geneva Identification System", "GEN# +1.00216718"},
        {"Smithsonian Astrophysical Observation", "SAO 146388"},
        {"Wilson Evans Batten Catalogue", "WEB 20143"},
    },
    visualMagnitude: 5.72,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.79560112),
        dec: Angle.Degrees(-04.98787812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30637"},
        {"Hipparcos Number", "HIP 22396"},
        {"Smithsonian Astrophysical Observation", "SAO 131515"},
    },
    visualMagnitude: 7.16,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.30635492),
        dec: Angle.Degrees(-04.98650732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13233",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2170 AB"},
        {"Henry Draper", "HD 17699"},
        {"Hipparcos Number", "HIP 13233"},
        {"Smithsonian Astrophysical Observation", "SAO 130139"},
    },
    visualMagnitude: 7.15,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.58945670),
        dec: Angle.Degrees(-04.98642543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151675"},
        {"Hipparcos Number", "HIP 82301"},
        {"Smithsonian Astrophysical Observation", "SAO 141380"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.24432683),
        dec: Angle.Degrees(-04.98517525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101339"},
        {"Hipparcos Number", "HIP 56884"},
        {"Smithsonian Astrophysical Observation", "SAO 138325"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.91595348),
        dec: Angle.Degrees(-04.98443418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69179"},
        {"Hipparcos Number", "HIP 40460"},
        {"Smithsonian Astrophysical Observation", "SAO 135692"},
        {"New General Catalogue", "NGC 2548 2042"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.91751467),
        dec: Angle.Degrees(-04.98055089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123283"},
        {"Hipparcos Number", "HIP 68949"},
        {"Smithsonian Astrophysical Observation", "SAO 139738"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.71580488),
        dec: Angle.Degrees(-04.98015762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6878"},
        {"Hipparcos Number", "HIP 5426"},
        {"Smithsonian Astrophysical Observation", "SAO 129146"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.32192899),
        dec: Angle.Degrees(-04.97856789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1230"},
        {"Hipparcos Number", "HIP 1324"},
        {"Smithsonian Astrophysical Observation", "SAO 128674"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.15908725),
        dec: Angle.Degrees(-04.97765438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39161"},
        {"Hipparcos Number", "HIP 27580"},
        {"Celescope Catalog", "CEL 1003"},
        {"Geneva Identification System", "GEN# +1.00039161"},
        {"Smithsonian Astrophysical Observation", "SAO 132580"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.61927074),
        dec: Angle.Degrees(-04.97707222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86003"},
        {"Hipparcos Number", "HIP 48674"},
        {"Smithsonian Astrophysical Observation", "SAO 137230"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.90411247),
        dec: Angle.Degrees(-04.97617329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24666"},
        {"Hipparcos Number", "HIP 18334"},
        {"Geneva Identification System", "GEN# +1.00024666"},
        {"Smithsonian Astrophysical Observation", "SAO 130818"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.78894679),
        dec: Angle.Degrees(-04.97506179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107794"},
        {"Hipparcos Number", "HIP 60418"},
        {"Smithsonian Astrophysical Observation", "SAO 138750"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.81394956),
        dec: Angle.Degrees(-04.97443301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7659",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7659"},
        {"Smithsonian Astrophysical Observation", "SAO 129421"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.65725593),
        dec: Angle.Degrees(-04.97187646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86441",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10693 BC"},
        {"Henry Draper", "HD 160387"},
        {"Hipparcos Number", "HIP 86441"},
        {"Geneva Identification System", "GEN# +1.00160387"},
        {"Smithsonian Astrophysical Observation", "SAO 141791"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.93965433),
        dec: Angle.Degrees(-04.96839666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86444",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10693 A"},
        {"Henry Draper", "HD 160388"},
        {"Hipparcos Number", "HIP 86444"},
        {"Geneva Identification System", "GEN# +1.00160388A"},
        {"Smithsonian Astrophysical Observation", "SAO 141793"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.94698530),
        dec: Angle.Degrees(-04.96800457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95742"},
        {"Hipparcos Number", "HIP 54014"},
        {"Smithsonian Astrophysical Observation", "SAO 137958"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.74794560),
        dec: Angle.Degrees(-04.96181419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168432"},
        {"Hipparcos Number", "HIP 89816"},
        {"Wilson Evans Batten Catalogue", "WEB 15327"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.95043900),
        dec: Angle.Degrees(-04.96170384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77486",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9796 AB"},
        {"Henry Draper", "HD 141461"},
        {"Hipparcos Number", "HIP 77486"},
        {"Renson", "Renson 40170"},
        {"Smithsonian Astrophysical Observation", "SAO 140782"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.32433922),
        dec: Angle.Degrees(-04.96147275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28672"},
        {"Hipparcos Number", "HIP 21076"},
        {"Smithsonian Astrophysical Observation", "SAO 131262"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.75864186),
        dec: Angle.Degrees(-04.96087414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48272",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48272"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.62404935),
        dec: Angle.Degrees(-04.96051648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101367"},
        {"Hipparcos Number", "HIP 56907"},
        {"Smithsonian Astrophysical Observation", "SAO 138331"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.98323527),
        dec: Angle.Degrees(-04.96032446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9261"},
        {"Hipparcos Number", "HIP 7059"},
        {"Smithsonian Astrophysical Observation", "SAO 129342"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.74894110),
        dec: Angle.Degrees(-04.95972673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34686"},
        {"Hipparcos Number", "HIP 24809"},
        {"Celescope Catalog", "CEL 612"},
        {"Geneva Identification System", "GEN# +1.00034686"},
        {"Smithsonian Astrophysical Observation", "SAO 131976"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.77999031),
        dec: Angle.Degrees(-04.95964365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9334"},
        {"Hipparcos Number", "HIP 7124"},
        {"Smithsonian Astrophysical Observation", "SAO 129350"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.94785905),
        dec: Angle.Degrees(-04.95913314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86897",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86897"},
    },
    visualMagnitude: 11.91,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.33183539),
        dec: Angle.Degrees(-04.95848046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12912",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2111 AB"},
        {"Henry Draper", "HD 17251"},
        {"Hipparcos Number", "HIP 12912"},
        {"Smithsonian Astrophysical Observation", "SAO 130100"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.49830652),
        dec: Angle.Degrees(-04.95647870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100630"},
        {"Hipparcos Number", "HIP 56479"},
        {"Smithsonian Astrophysical Observation", "SAO 138278"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.68873842),
        dec: Angle.Degrees(-04.95442214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11273"},
        {"Hipparcos Number", "HIP 8579"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.65537791),
        dec: Angle.Degrees(-04.95423709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39702"},
        {"Hipparcos Number", "HIP 27886"},
        {"Smithsonian Astrophysical Observation", "SAO 132627"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.51773130),
        dec: Angle.Degrees(-04.95320799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63066"},
        {"Hipparcos Number", "HIP 37964"},
        {"Geneva Identification System", "GEN# +1.00063066"},
        {"Smithsonian Astrophysical Observation", "SAO 135095"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.73343400),
        dec: Angle.Degrees(-04.95313834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201379"},
        {"Hipparcos Number", "HIP 104433"},
        {"Geneva Identification System", "GEN# +1.00201379"},
        {"Smithsonian Astrophysical Observation", "SAO 145151"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.32598479),
        dec: Angle.Degrees(-04.95287562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139198"},
        {"Hipparcos Number", "HIP 76463"},
        {"Smithsonian Astrophysical Observation", "SAO 140654"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.23976329),
        dec: Angle.Degrees(-04.95087447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7627"},
        {"Hipparcos Number", "HIP 5919"},
        {"Smithsonian Astrophysical Observation", "SAO 129200"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.03537287),
        dec: Angle.Degrees(-04.95081370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122605"},
        {"Hipparcos Number", "HIP 68639"},
        {"Smithsonian Astrophysical Observation", "SAO 139699"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.75670323),
        dec: Angle.Degrees(-04.94500261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10479"},
        {"Hipparcos Number", "HIP 7942"},
        {"Smithsonian Astrophysical Observation", "SAO 129456"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.51425105),
        dec: Angle.Degrees(-04.94452666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129191"},
        {"Hipparcos Number", "HIP 71803"},
        {"Geneva Identification System", "GEN# +1.00129191"},
        {"Smithsonian Astrophysical Observation", "SAO 140072"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.31736084),
        dec: Angle.Degrees(-04.94450151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64296",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8807 AB"},
        {"Henry Draper", "HD 114449"},
        {"Hipparcos Number", "HIP 64296"},
        {"Geneva Identification System", "GEN# +1.00114449J"},
        {"Smithsonian Astrophysical Observation", "SAO 139195"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.67670526),
        dec: Angle.Degrees(-04.94181118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6430"},
        {"Smithsonian Astrophysical Observation", "SAO 129264"},
    },
    visualMagnitude: 10.00,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.65062061),
        dec: Angle.Degrees(-04.93668925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127007"},
        {"Hipparcos Number", "HIP 70838"},
        {"Geneva Identification System", "GEN# +1.00127007"},
        {"Smithsonian Astrophysical Observation", "SAO 139963"},
        {"Wilson Evans Batten Catalogue", "WEB 12268"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.29040324),
        dec: Angle.Degrees(-04.93622921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42879"},
        {"Hipparcos Number", "HIP 29513"},
        {"Smithsonian Astrophysical Observation", "SAO 132973"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.26172787),
        dec: Angle.Degrees(-04.93515517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173956"},
        {"Hipparcos Number", "HIP 92278"},
        {"Smithsonian Astrophysical Observation", "SAO 142632"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.09127113),
        dec: Angle.Degrees(-04.93493411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53884"},
        {"Hipparcos Number", "HIP 34290"},
        {"Smithsonian Astrophysical Observation", "SAO 134193"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.63185798),
        dec: Angle.Degrees(-04.93490648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118207"},
        {"Hipparcos Number", "HIP 66311"},
        {"Smithsonian Astrophysical Observation", "SAO 139427"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.85213523),
        dec: Angle.Degrees(-04.93423461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37334"},
        {"Hipparcos Number", "HIP 26442"},
        {"Celescope Catalog", "CEL 869"},
        {"Geneva Identification System", "GEN# +9.00011109"},
        {"Geneva Identification System 2", "GEN# +1.00037334"},
        {"Geneva Identification System 3", "GEN# +2.19761109"},
        {"Smithsonian Astrophysical Observation", "SAO 132378"},
        {"Wilson Evans Batten Catalogue", "WEB 5214"},
    },
    visualMagnitude: 7.15,
    bvColour: -0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.40313502),
        dec: Angle.Degrees(-04.93413105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73281"},
        {"Hipparcos Number", "HIP 42299"},
        {"Geneva Identification System", "GEN# +1.00073281"},
        {"Smithsonian Astrophysical Observation", "SAO 136103"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.36322721),
        dec: Angle.Degrees(-04.93401252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97860"},
        {"Hipparcos Number", "HIP 54973"},
        {"Smithsonian Astrophysical Observation", "SAO 138088"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.84655535),
        dec: Angle.Degrees(-04.93375911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21693"},
        {"Smithsonian Astrophysical Observation", "SAO 131388"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.86339109),
        dec: Angle.Degrees(-04.93245184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224828"},
        {"Hipparcos Number", "HIP 81"},
        {"Cincinnati Publication", "Ci 18 3153"},
        {"Smithsonian Astrophysical Observation", "SAO 147031"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.24386443),
        dec: Angle.Degrees(-04.93211471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196676"},
        {"Hipparcos Number", "HIP 101911"},
        {"Smithsonian Astrophysical Observation", "SAO 144663"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.77443055),
        dec: Angle.Degrees(-04.92950491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210392"},
        {"Hipparcos Number", "HIP 109428"},
        {"Geneva Identification System", "GEN# +1.00210392"},
        {"Smithsonian Astrophysical Observation", "SAO 145912"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.54986486),
        dec: Angle.Degrees(-04.92880257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90127"},
        {"Hipparcos Number", "HIP 50930"},
        {"Smithsonian Astrophysical Observation", "SAO 137539"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.02649456),
        dec: Angle.Degrees(-04.92735566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225184"},
        {"Hipparcos Number", "HIP 327"},
        {"Renson", "Renson 61756"},
        {"Smithsonian Astrophysical Observation", "SAO 128561"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.04616137),
        dec: Angle.Degrees(-04.92610737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116365"},
        {"Hipparcos Number", "HIP 65323"},
        {"Fundamental Katalog 5th Edition", "FK5 3069"},
        {"Geneva Identification System", "GEN# +1.00116365"},
        {"Smithsonian Astrophysical Observation", "SAO 139308"},
        {"Wilson Evans Batten Catalogue", "WEB 11531"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.82877172),
        dec: Angle.Degrees(-04.92438824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172030"},
        {"Hipparcos Number", "HIP 91368"},
        {"Smithsonian Astrophysical Observation", "SAO 142455"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.51464497),
        dec: Angle.Degrees(-04.92236837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17514"},
        {"Hipparcos Number", "HIP 13095"},
        {"Smithsonian Astrophysical Observation", "SAO 130119"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.09420754),
        dec: Angle.Degrees(-04.92080099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59356",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59356"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.65785898),
        dec: Angle.Degrees(-04.91914561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215388"},
        {"Hipparcos Number", "HIP 112309"},
        {"Smithsonian Astrophysical Observation", "SAO 146291"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.22683435),
        dec: Angle.Degrees(-04.91572626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29711",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4865 AB"},
        {"Henry Draper", "HD 43319"},
        {"Hipparcos Number", "HIP 29711"},
        {"Geneva Identification System", "GEN# +1.00043319J"},
        {"Smithsonian Astrophysical Observation", "SAO 133027"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.87358260),
        dec: Angle.Degrees(-04.91463574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199281"},
        {"Hipparcos Number", "HIP 103351"},
        {"Smithsonian Astrophysical Observation", "SAO 144958"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.08509668),
        dec: Angle.Degrees(-04.91197559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107779"},
        {"Hipparcos Number", "HIP 60409"},
        {"Smithsonian Astrophysical Observation", "SAO 138748"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.79356801),
        dec: Angle.Degrees(-04.91179626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9603"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.87574581),
        dec: Angle.Degrees(-04.91103188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39238"},
        {"Hipparcos Number", "HIP 27636"},
        {"Smithsonian Astrophysical Observation", "SAO 132588"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.75853667),
        dec: Angle.Degrees(-04.90997409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8020"},
        {"Hipparcos Number", "HIP 6203"},
        {"Smithsonian Astrophysical Observation", "SAO 129232"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.88262144),
        dec: Angle.Degrees(-04.90993122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55062"},
        {"Hipparcos Number", "HIP 34711"},
        {"Smithsonian Astrophysical Observation", "SAO 134318"},
    },
    visualMagnitude: 8.92,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.82952972),
        dec: Angle.Degrees(-04.90829065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112805"},
        {"Hipparcos Number", "HIP 63391"},
        {"Smithsonian Astrophysical Observation", "SAO 139085"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.84870356),
        dec: Angle.Degrees(-04.90674871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6626"},
        {"Hipparcos Number", "HIP 5237"},
        {"Geneva Identification System", "GEN# +1.00006626"},
        {"Smithsonian Astrophysical Observation", "SAO 129125"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.74420980),
        dec: Angle.Degrees(-04.90610971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27743"},
        {"Hipparcos Number", "HIP 20431"},
        {"Geneva Identification System", "GEN# +1.00027743"},
        {"Smithsonian Astrophysical Observation", "SAO 131156"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.64772777),
        dec: Angle.Degrees(-04.90548128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224121"},
        {"Hipparcos Number", "HIP 117940"},
        {"Geneva Identification System", "GEN# +1.00224121"},
        {"Smithsonian Astrophysical Observation", "SAO 146980"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.84792615),
        dec: Angle.Degrees(-04.90158077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46616"},
        {"Hipparcos Number", "HIP 31338"},
        {"Celescope Catalog", "CEL 1302"},
        {"Geneva Identification System", "GEN# +1.00046616"},
        {"Smithsonian Astrophysical Observation", "SAO 133421"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.57577273),
        dec: Angle.Degrees(-04.90010811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158810"},
        {"Hipparcos Number", "HIP 85761"},
        {"Smithsonian Astrophysical Observation", "SAO 141715"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.86533304),
        dec: Angle.Degrees(-04.89990099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50729"},
        {"Hipparcos Number", "HIP 33173"},
        {"Geneva Identification System", "GEN# +1.00050729"},
        {"Renson", "Renson 13930"},
        {"Smithsonian Astrophysical Observation", "SAO 133866"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.57135458),
        dec: Angle.Degrees(-04.89972993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45583"},
        {"Hipparcos Number", "HIP 30789"},
        {"Celescope Catalog", "CEL 1256"},
        {"Geneva Identification System", "GEN# +2.22320009"},
        {"Renson", "Renson 12120"},
        {"Smithsonian Astrophysical Observation", "SAO 133297"},
        {"New General Catalogue", "NGC 2232 9"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.04486872),
        dec: Angle.Degrees(-04.89902766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22283"},
        {"Hipparcos Number", "HIP 16721"},
        {"Smithsonian Astrophysical Observation", "SAO 130588"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.77689705),
        dec: Angle.Degrees(-04.89866702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178014"},
        {"Hipparcos Number", "HIP 93900"},
        {"Smithsonian Astrophysical Observation", "SAO 143039"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.80941541),
        dec: Angle.Degrees(-04.89818838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80238"},
        {"Hipparcos Number", "HIP 45657"},
        {"Smithsonian Astrophysical Observation", "SAO 136746"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.60267708),
        dec: Angle.Degrees(-04.89800722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74703",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9557 AB"},
        {"Henry Draper", "HD 135578"},
        {"Hipparcos Number", "HIP 74703"},
        {"Geneva Identification System", "GEN# +1.00135578J"},
        {"Smithsonian Astrophysical Observation", "SAO 140421"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.00648503),
        dec: Angle.Degrees(-04.89786905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79681",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79681"},
        {"Smithsonian Astrophysical Observation", "SAO 141067"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.93426441),
        dec: Angle.Degrees(-04.89724211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82957"},
        {"Hipparcos Number", "HIP 47027"},
        {"Smithsonian Astrophysical Observation", "SAO 136974"},
        {"Wilson Evans Batten Catalogue", "WEB 8860"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.76016869),
        dec: Angle.Degrees(-04.88917896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213764"},
        {"Hipparcos Number", "HIP 111381"},
        {"Smithsonian Astrophysical Observation", "SAO 146159"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.47653885),
        dec: Angle.Degrees(-04.88512410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182475"},
        {"Hipparcos Number", "HIP 95453"},
        {"Geneva Identification System", "GEN# +1.00182475"},
        {"Smithsonian Astrophysical Observation", "SAO 143373"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.25629973),
        dec: Angle.Degrees(-04.88455503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177756"},
        {"Hipparcos Number", "HIP 93805"},
        {"Celescope Catalog", "CEL 4697"},
        {"Fundamental Katalog 5th Edition", "FK5 717"},
        {"Geneva Identification System", "GEN# +1.00177756"},
        {"Renson", "Renson 49540"},
        {"Smithsonian Astrophysical Observation", "SAO 143021"},
        {"Wilson Evans Batten Catalogue", "WEB 16307"},
    },
    visualMagnitude: 3.43,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.56229139),
        dec: Angle.Degrees(-04.88233456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65826"},
        {"Hipparcos Number", "HIP 39152"},
        {"Geneva Identification System", "GEN# +1.00065826"},
        {"Smithsonian Astrophysical Observation", "SAO 135360"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.12072633),
        dec: Angle.Degrees(-04.87987581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34774"},
        {"Hipparcos Number", "HIP 24857"},
        {"Celescope Catalog", "CEL 619"},
        {"Geneva Identification System", "GEN# +1.00034774"},
        {"Smithsonian Astrophysical Observation", "SAO 131989"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.92604522),
        dec: Angle.Degrees(-04.87728130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96116",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96116"},
        {"Smithsonian Astrophysical Observation", "SAO 143518"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.13843492),
        dec: Angle.Degrees(-04.87630350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119916"},
        {"Hipparcos Number", "HIP 67209"},
        {"Smithsonian Astrophysical Observation", "SAO 139537"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.57953095),
        dec: Angle.Degrees(-04.87625912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85032"},
        {"Hipparcos Number", "HIP 48167"},
        {"Smithsonian Astrophysical Observation", "SAO 137155"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.27153379),
        dec: Angle.Degrees(-04.87555118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19508",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3041 AB"},
        {"Henry Draper", "HD 26441"},
        {"Hipparcos Number", "HIP 19508"},
        {"Geneva Identification System", "GEN# +1.00026441"},
        {"Smithsonian Astrophysical Observation", "SAO 131003"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.68532621),
        dec: Angle.Degrees(-04.87450715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14292"},
        {"Hipparcos Number", "HIP 10763"},
        {"Smithsonian Astrophysical Observation", "SAO 129816"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.62725831),
        dec: Angle.Degrees(-04.86953896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70053"},
        {"Smithsonian Astrophysical Observation", "SAO 139872"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.03859190),
        dec: Angle.Degrees(-04.86884902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79823"},
        {"Hipparcos Number", "HIP 45489"},
        {"Smithsonian Astrophysical Observation", "SAO 136712"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.03480138),
        dec: Angle.Degrees(-04.86690308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70255"},
        {"Hipparcos Number", "HIP 40907"},
        {"Smithsonian Astrophysical Observation", "SAO 135796"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.21982683),
        dec: Angle.Degrees(-04.86611746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112372"},
        {"Hipparcos Number", "HIP 63139"},
        {"Smithsonian Astrophysical Observation", "SAO 139049"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.06266828),
        dec: Angle.Degrees(-04.86402799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7673"},
        {"Hipparcos Number", "HIP 5945"},
        {"Smithsonian Astrophysical Observation", "SAO 129203"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.12443403),
        dec: Angle.Degrees(-04.86208800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108203"},
        {"Hipparcos Number", "HIP 60645"},
        {"Geneva Identification System", "GEN# +1.00108203"},
        {"Smithsonian Astrophysical Observation", "SAO 138776"},
        {"Wilson Evans Batten Catalogue", "WEB 10785"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.45767941),
        dec: Angle.Degrees(-04.86187740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138612"},
        {"Hipparcos Number", "HIP 76162"},
        {"Geneva Identification System", "GEN# +1.00138612"},
        {"Smithsonian Astrophysical Observation", "SAO 140600"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.32946450),
        dec: Angle.Degrees(-04.86115952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73669"},
        {"Hipparcos Number", "HIP 42461"},
        {"Smithsonian Astrophysical Observation", "SAO 136137"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.85090840),
        dec: Angle.Degrees(-04.86038660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28698"},
        {"Hipparcos Number", "HIP 21095"},
        {"Geneva Identification System", "GEN# +1.00028698"},
        {"Smithsonian Astrophysical Observation", "SAO 131265"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.80569127),
        dec: Angle.Degrees(-04.85985040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11193"},
        {"Hipparcos Number", "HIP 8521"},
        {"Smithsonian Astrophysical Observation", "SAO 129519"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.47756205),
        dec: Angle.Degrees(-04.85952187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76735"},
        {"Hipparcos Number", "HIP 44030"},
        {"Geneva Identification System", "GEN# +1.00076735"},
        {"Smithsonian Astrophysical Observation", "SAO 136450"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.49378284),
        dec: Angle.Degrees(-04.85922074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26268",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4196 A"},
        {"Henry Draper", "HD 37077"},
        {"Hipparcos Number", "HIP 26268"},
        {"Geneva Identification System", "GEN# +9.00010806"},
        {"Geneva Identification System 2", "GEN# +2.19760806"},
        {"Smithsonian Astrophysical Observation", "SAO 132336"},
        {"Wilson Evans Batten Catalogue", "WEB 5157"},
    },
    visualMagnitude: 5.24,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.91452109),
        dec: Angle.Degrees(-04.85608620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152833"},
        {"Hipparcos Number", "HIP 82854"},
        {"Geneva Identification System", "GEN# +1.00152833"},
        {"Smithsonian Astrophysical Observation", "SAO 141445"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.98849260),
        dec: Angle.Degrees(-04.85491925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316"},
        {"Hipparcos Number", "HIP 642"},
        {"Smithsonian Astrophysical Observation", "SAO 128599"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.97130707),
        dec: Angle.Degrees(-04.85488887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 199.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21715"},
        {"Hipparcos Number", "HIP 16299"},
        {"Smithsonian Astrophysical Observation", "SAO 130523"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.53117133),
        dec: Angle.Degrees(-04.85488346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80986"},
        {"Hipparcos Number", "HIP 46000"},
        {"Geneva Identification System", "GEN# +1.00080986"},
        {"Smithsonian Astrophysical Observation", "SAO 136798"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.71923266),
        dec: Angle.Degrees(-04.85446249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129359"},
        {"Hipparcos Number", "HIP 71879"},
        {"Smithsonian Astrophysical Observation", "SAO 140084"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.53656272),
        dec: Angle.Degrees(-04.85243582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160869"},
        {"Hipparcos Number", "HIP 86677"},
        {"Fundamental Katalog 5th Edition", "FK5 5556"},
        {"Smithsonian Astrophysical Observation", "SAO 141821"},
        {"Wilson Evans Batten Catalogue", "WEB 14615"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.64656478),
        dec: Angle.Degrees(-04.84973715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102762"},
        {"Hipparcos Number", "HIP 57690"},
        {"Smithsonian Astrophysical Observation", "SAO 138431"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.46803283),
        dec: Angle.Degrees(-04.84931341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23270"},
        {"Hipparcos Number", "HIP 17399"},
        {"Smithsonian Astrophysical Observation", "SAO 130689"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.91850457),
        dec: Angle.Degrees(-04.84799246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7376"},
        {"Hipparcos Number", "HIP 5754"},
        {"Geneva Identification System", "GEN# +1.00007376"},
        {"Smithsonian Astrophysical Observation", "SAO 129187"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.46692043),
        dec: Angle.Degrees(-04.84731700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103393",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103393"},
        {"Cincinnati Publication", "Ci 20 1243"},
        {"Geneva Identification System", "GEN# +6.00108292A"},
    },
    visualMagnitude: 11.87,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.20029476),
        dec: Angle.Degrees(-04.84643951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 786.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113816"},
        {"Hipparcos Number", "HIP 63958"},
        {"Smithsonian Astrophysical Observation", "SAO 139157"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.60837960),
        dec: Angle.Degrees(-04.84587139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7048"},
        {"Hipparcos Number", "HIP 5524"},
        {"Geneva Identification System", "GEN# +1.00007048"},
        {"Smithsonian Astrophysical Observation", "SAO 129159"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.67930599),
        dec: Angle.Degrees(-04.84219494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209582"},
        {"Hipparcos Number", "HIP 108972"},
        {"Fundamental Katalog 5th Edition", "FK5 5950"},
        {"Geneva Identification System", "GEN# +1.00209582"},
        {"Smithsonian Astrophysical Observation", "SAO 145850"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.14584481),
        dec: Angle.Degrees(-04.84005134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10619",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10619"},
        {"Smithsonian Astrophysical Observation", "SAO 129794"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.17704824),
        dec: Angle.Degrees(-04.84004456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26237",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4187 A"},
        {"Henry Draper", "HD 37018"},
        {"Hipparcos Number", "HIP 26237"},
        {"Celescope Catalog", "CEL 828"},
        {"Geneva Identification System", "GEN# +9.00010659D"},
        {"Geneva Identification System 2", "GEN# +9.00010659"},
        {"Geneva Identification System 3", "GEN# +2.19760659"},
        {"Smithsonian Astrophysical Observation", "SAO 132320"},
        {"Wilson Evans Batten Catalogue", "WEB 5133"},
    },
    visualMagnitude: 4.58,
    bvColour: -0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.84650694),
        dec: Angle.Degrees(-04.83834045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192249"},
        {"Hipparcos Number", "HIP 99720"},
        {"Smithsonian Astrophysical Observation", "SAO 144193"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.52229183),
        dec: Angle.Degrees(-04.83787456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110578",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15902 AB"},
        {"Henry Draper", "HD 212404"},
        {"Hipparcos Number", "HIP 110578"},
        {"Geneva Identification System", "GEN# +1.00212404"},
        {"Smithsonian Astrophysical Observation", "SAO 146067"},
        {"Wilson Evans Batten Catalogue", "WEB 19819"},
    },
    visualMagnitude: 5.79,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.02861939),
        dec: Angle.Degrees(-04.83700102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23795"},
        {"Hipparcos Number", "HIP 17731"},
        {"Smithsonian Astrophysical Observation", "SAO 130725"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.94798769),
        dec: Angle.Degrees(-04.83676046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6203"},
        {"Hipparcos Number", "HIP 4914"},
        {"Geneva Identification System", "GEN# +1.00006203"},
        {"Smithsonian Astrophysical Observation", "SAO 129094"},
        {"Wilson Evans Batten Catalogue", "WEB 971"},
    },
    visualMagnitude: 5.40,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.76085267),
        dec: Angle.Degrees(-04.83635047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110920"},
    },
    visualMagnitude: 10.38,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.08138705),
        dec: Angle.Degrees(-04.83480515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38088"},
        {"Hipparcos Number", "HIP 26934"},
        {"Geneva Identification System", "GEN# +1.00038088"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.74505206),
        dec: Angle.Degrees(-04.83277545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45153"},
        {"Hipparcos Number", "HIP 30580"},
        {"Geneva Identification System", "GEN# +2.22320005"},
        {"Smithsonian Astrophysical Observation", "SAO 133236"},
        {"New General Catalogue", "NGC 2232 5"},
    },
    visualMagnitude: 7.31,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.41219609),
        dec: Angle.Degrees(-04.83228422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91887"},
        {"Hipparcos Number", "HIP 51930"},
        {"Smithsonian Astrophysical Observation", "SAO 137670"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.12456670),
        dec: Angle.Degrees(-04.82905575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200633"},
        {"Hipparcos Number", "HIP 104045"},
        {"Geneva Identification System", "GEN# +1.00200633"},
        {"Smithsonian Astrophysical Observation", "SAO 145075"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.18428911),
        dec: Angle.Degrees(-04.82842386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66594"},
        {"Hipparcos Number", "HIP 39483"},
        {"Geneva Identification System", "GEN# +1.00066594"},
        {"Smithsonian Astrophysical Observation", "SAO 135444"},
        {"Wilson Evans Batten Catalogue", "WEB 7719"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.04222752),
        dec: Angle.Degrees(-04.82694140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39911"},
        {"Hipparcos Number", "HIP 28002"},
        {"Celescope Catalog", "CEL 1035"},
        {"Smithsonian Astrophysical Observation", "SAO 132648"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.85374151),
        dec: Angle.Degrees(-04.82555188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45516"},
        {"Hipparcos Number", "HIP 30758"},
        {"Celescope Catalog", "CEL 1249"},
        {"Geneva Identification System", "GEN# +2.22320008"},
        {"Smithsonian Astrophysical Observation", "SAO 133285"},
        {"New General Catalogue", "NGC 2232 8"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.94841543),
        dec: Angle.Degrees(-04.82471254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114677"},
    },
    visualMagnitude: 12.01,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.46789627),
        dec: Angle.Degrees(-04.82397366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 231.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189824"},
        {"Hipparcos Number", "HIP 98642"},
        {"Smithsonian Astrophysical Observation", "SAO 144010"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.54340176),
        dec: Angle.Degrees(-04.82256371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164064"},
        {"Hipparcos Number", "HIP 88101"},
        {"Geneva Identification System", "GEN# +1.00164064"},
        {"Smithsonian Astrophysical Observation", "SAO 142012"},
        {"Wilson Evans Batten Catalogue", "WEB 14880"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.90318648),
        dec: Angle.Degrees(-04.82091169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143840"},
        {"Hipparcos Number", "HIP 78594"},
        {"Geneva Identification System", "GEN# +1.00143840"},
        {"Smithsonian Astrophysical Observation", "SAO 140914"},
        {"Wilson Evans Batten Catalogue", "WEB 13282"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.70629974),
        dec: Angle.Degrees(-04.81803823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183061"},
        {"Hipparcos Number", "HIP 95698"},
        {"Fundamental Katalog 5th Edition", "FK5 5712"},
        {"Smithsonian Astrophysical Observation", "SAO 143423"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.96717862),
        dec: Angle.Degrees(-04.81777005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 295595"},
        {"Hipparcos Number", "HIP 32633"},
        {"Smithsonian Astrophysical Observation", "SAO 133699"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.10699674),
        dec: Angle.Degrees(-04.81705181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213278"},
        {"Hipparcos Number", "HIP 111102"},
        {"Geneva Identification System", "GEN# +1.00213278"},
        {"Smithsonian Astrophysical Observation", "SAO 146128"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.61586221),
        dec: Angle.Degrees(-04.81669320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181734"},
        {"Hipparcos Number", "HIP 95180"},
        {"Smithsonian Astrophysical Observation", "SAO 143310"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.44294496),
        dec: Angle.Degrees(-04.81415243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37356"},
        {"Hipparcos Number", "HIP 26477"},
        {"Celescope Catalog", "CEL 875"},
        {"Geneva Identification System", "GEN# +9.00011129"},
        {"Geneva Identification System 2", "GEN# +1.00037356"},
        {"Smithsonian Astrophysical Observation", "SAO 132387"},
        {"Wilson Evans Batten Catalogue", "WEB 5219"},
    },
    visualMagnitude: 6.16,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.47244552),
        dec: Angle.Degrees(-04.81403616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171305"},
        {"Hipparcos Number", "HIP 91038"},
        {"Smithsonian Astrophysical Observation", "SAO 142393"},
        {"Wilson Evans Batten Catalogue", "WEB 15622"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.56601527),
        dec: Angle.Degrees(-04.81357039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110918"},
        {"Hipparcos Number", "HIP 62260"},
        {"Smithsonian Astrophysical Observation", "SAO 138955"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.38349409),
        dec: Angle.Degrees(-04.81096177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216953"},
        {"Hipparcos Number", "HIP 113345"},
        {"Geneva Identification System", "GEN# +1.00216953"},
        {"Smithsonian Astrophysical Observation", "SAO 146404"},
        {"Wilson Evans Batten Catalogue", "WEB 20164"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.32169131),
        dec: Angle.Degrees(-04.81009168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74014"},
        {"Hipparcos Number", "HIP 42634"},
        {"Smithsonian Astrophysical Observation", "SAO 136179"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.32720443),
        dec: Angle.Degrees(-04.80885163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14475",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14475"},
        {"Smithsonian Astrophysical Observation", "SAO 130290"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.70335764),
        dec: Angle.Degrees(-04.80848248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101969"},
        {"Hipparcos Number", "HIP 57232"},
        {"Smithsonian Astrophysical Observation", "SAO 138378"},
        {"Wilson Evans Batten Catalogue", "WEB 10293"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.01714668),
        dec: Angle.Degrees(-04.80716528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171954"},
        {"Hipparcos Number", "HIP 91337"},
        {"Geneva Identification System", "GEN# +1.00171954"},
        {"Smithsonian Astrophysical Observation", "SAO 142446"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.43943981),
        dec: Angle.Degrees(-04.80690952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29551"},
        {"Hipparcos Number", "HIP 21669"},
        {"Smithsonian Astrophysical Observation", "SAO 131384"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.77409824),
        dec: Angle.Degrees(-04.80686473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193672"},
        {"Hipparcos Number", "HIP 100407"},
        {"Geneva Identification System", "GEN# +1.00193672"},
        {"Smithsonian Astrophysical Observation", "SAO 144338"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.41573893),
        dec: Angle.Degrees(-04.80553871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36843"},
        {"Hipparcos Number", "HIP 26137"},
        {"Celescope Catalog", "CEL 799"},
        {"Geneva Identification System", "GEN# +9.00010243"},
        {"Renson", "Renson 9660"},
        {"Smithsonian Astrophysical Observation", "SAO 132278"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.60030818),
        dec: Angle.Degrees(-04.80435741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118493"},
        {"Hipparcos Number", "HIP 66450"},
        {"Geneva Identification System", "GEN# +1.00118493"},
        {"Smithsonian Astrophysical Observation", "SAO 139446"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.34297996),
        dec: Angle.Degrees(-04.80401784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56520"},
        {"Hipparcos Number", "HIP 35271"},
        {"Smithsonian Astrophysical Observation", "SAO 134461"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.30445095),
        dec: Angle.Degrees(-04.80067521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217877"},
        {"Hipparcos Number", "HIP 113896"},
        {"Cincinnati Publication", "Ci 18 3012"},
        {"Geneva Identification System", "GEN# +1.00217877"},
        {"Smithsonian Astrophysical Observation", "SAO 146482"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.98785818),
        dec: Angle.Degrees(-04.79495356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 319.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61382"},
        {"Hipparcos Number", "HIP 37239"},
        {"Geneva Identification System", "GEN# +1.00061382"},
        {"Renson", "Renson 16840"},
        {"Smithsonian Astrophysical Observation", "SAO 134938"},
    },
    visualMagnitude: 8.33,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.72203561),
        dec: Angle.Degrees(-04.79406767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198486"},
        {"Hipparcos Number", "HIP 102894"},
        {"Geneva Identification System", "GEN# +1.00198486"},
        {"Smithsonian Astrophysical Observation", "SAO 144867"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.67578178),
        dec: Angle.Degrees(-04.79088579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46802"},
        {"Hipparcos Number", "HIP 31447"},
        {"Smithsonian Astrophysical Observation", "SAO 133439"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.82148315),
        dec: Angle.Degrees(-04.78986983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39927"},
        {"Hipparcos Number", "HIP 28019"},
        {"Celescope Catalog", "CEL 1036"},
        {"Geneva Identification System", "GEN# +1.00039927"},
        {"Smithsonian Astrophysical Observation", "SAO 132653"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.89740347),
        dec: Angle.Degrees(-04.78851544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141247"},
        {"Hipparcos Number", "HIP 77410"},
        {"Geneva Identification System", "GEN# +1.00141247"},
        {"Smithsonian Astrophysical Observation", "SAO 140766"},
        {"Wilson Evans Batten Catalogue", "WEB 13110"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.04928860),
        dec: Angle.Degrees(-04.78594094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124551"},
        {"Hipparcos Number", "HIP 69572"},
        {"Smithsonian Astrophysical Observation", "SAO 139808"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.61444756),
        dec: Angle.Degrees(-04.78562340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77055"},
        {"Hipparcos Number", "HIP 44173"},
        {"Smithsonian Astrophysical Observation", "SAO 136477"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.95565886),
        dec: Angle.Degrees(-04.78554054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25782"},
        {"Hipparcos Number", "HIP 19061"},
        {"Geneva Identification System", "GEN# +1.00025782"},
        {"Smithsonian Astrophysical Observation", "SAO 130929"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.27051251),
        dec: Angle.Degrees(-04.78539237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28863",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4672 AB"},
        {"Henry Draper", "HD 41530"},
        {"Hipparcos Number", "HIP 28863"},
        {"Celescope Catalog", "CEL 1073"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.39340222),
        dec: Angle.Degrees(-04.78447003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18572"},
        {"Hipparcos Number", "HIP 13910"},
        {"Smithsonian Astrophysical Observation", "SAO 130218"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.78504752),
        dec: Angle.Degrees(-04.78333803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103773"},
        {"Hipparcos Number", "HIP 58268"},
        {"Geneva Identification System", "GEN# +1.00103773"},
        {"Smithsonian Astrophysical Observation", "SAO 138496"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.25160936),
        dec: Angle.Degrees(-04.78278855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -154.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31569"},
        {"Hipparcos Number", "HIP 22985"},
        {"Smithsonian Astrophysical Observation", "SAO 131619"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.18637397),
        dec: Angle.Degrees(-04.78109051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75201"},
        {"Geneva Identification System", "GEN# -0.00403873"},
        {"Smithsonian Astrophysical Observation", "SAO 140488"},
        {"Wilson Evans Batten Catalogue", "WEB 12829"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.51780911),
        dec: Angle.Degrees(-04.77742313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -294.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104056"},
        {"Hipparcos Number", "HIP 58443"},
        {"Geneva Identification System", "GEN# +1.00104056"},
        {"Smithsonian Astrophysical Observation", "SAO 138517"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.76257782),
        dec: Angle.Degrees(-04.77704915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162597"},
        {"Hipparcos Number", "HIP 87442"},
        {"Smithsonian Astrophysical Observation", "SAO 141914"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.01507663),
        dec: Angle.Degrees(-04.77694514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218410"},
        {"Hipparcos Number", "HIP 114223"},
        {"Smithsonian Astrophysical Observation", "SAO 146523"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.97744210),
        dec: Angle.Degrees(-04.77674673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184858"},
        {"Hipparcos Number", "HIP 96451"},
        {"Smithsonian Astrophysical Observation", "SAO 143593"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.14205264),
        dec: Angle.Degrees(-04.77170874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40350"},
        {"Hipparcos Number", "HIP 28239"},
        {"Smithsonian Astrophysical Observation", "SAO 132697"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.50607606),
        dec: Angle.Degrees(-04.77154753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16776"},
        {"Hipparcos Number", "HIP 12531"},
        {"Geneva Identification System", "GEN# +1.00016776"},
        {"Smithsonian Astrophysical Observation", "SAO 130056"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.30874383),
        dec: Angle.Degrees(-04.76884396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12065",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12065"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.89554163),
        dec: Angle.Degrees(-04.76676485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 174.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66014"},
        {"Hipparcos Number", "HIP 39239"},
        {"Fundamental Katalog 5th Edition", "FK5 4721"},
        {"Smithsonian Astrophysical Observation", "SAO 135389"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.38239648),
        dec: Angle.Degrees(-04.76558875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10658"},
        {"Hipparcos Number", "HIP 8094"},
        {"Geneva Identification System", "GEN# +1.00010658"},
        {"Smithsonian Astrophysical Observation", "SAO 129477"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.97837552),
        dec: Angle.Degrees(-04.76543961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71057",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71057"},
        {"Smithsonian Astrophysical Observation", "SAO 139984"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.96616235),
        dec: Angle.Degrees(-04.76432922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174856"},
        {"Hipparcos Number", "HIP 92654"},
        {"Fundamental Katalog 5th Edition", "FK5 5664"},
        {"Smithsonian Astrophysical Observation", "SAO 142739"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.20648710),
        dec: Angle.Degrees(-04.76343586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45546"},
        {"Hipparcos Number", "HIP 30772"},
        {"Celescope Catalog", "CEL 1251"},
        {"Fundamental Katalog 5th Edition", "FK5 246"},
        {"Geneva Identification System", "GEN# +2.22320001"},
        {"Smithsonian Astrophysical Observation", "SAO 133290"},
        {"Wilson Evans Batten Catalogue", "WEB 6136"},
        {"New General Catalogue", "NGC 2232 1"},
    },
    visualMagnitude: 5.06,
    bvColour: -0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.98988336),
        dec: Angle.Degrees(-04.76214677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65877"},
        {"Hipparcos Number", "HIP 39176"},
        {"Smithsonian Astrophysical Observation", "SAO 135372"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.19588128),
        dec: Angle.Degrees(-04.75872781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39118",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39118"},
    },
    visualMagnitude: 10.41,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.05091099),
        dec: Angle.Degrees(-04.75790856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110282"},
        {"Hipparcos Number", "HIP 61894"},
        {"Smithsonian Astrophysical Observation", "SAO 138909"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.25469025),
        dec: Angle.Degrees(-04.75643101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208459"},
        {"Hipparcos Number", "HIP 108289"},
        {"Smithsonian Astrophysical Observation", "SAO 145757"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.08592198),
        dec: Angle.Degrees(-04.75636581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56572",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Sagarmatha"},
        {"Henry Draper", "HD 100777"},
        {"Hipparcos Number", "HIP 56572"},
        {"Smithsonian Astrophysical Observation", "SAO 138288"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.96470625),
        dec: Angle.Degrees(-04.75577838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81709"},
        {"Hipparcos Number", "HIP 46359"},
        {"Smithsonian Astrophysical Observation", "SAO 136859"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.78650980),
        dec: Angle.Degrees(-04.75525780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195237"},
        {"Hipparcos Number", "HIP 101162"},
        {"Geneva Identification System", "GEN# +1.00195237"},
        {"Smithsonian Astrophysical Observation", "SAO 144506"},
        {"Wilson Evans Batten Catalogue", "WEB 18272"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.57697042),
        dec: Angle.Degrees(-04.75458998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144492"},
        {"Hipparcos Number", "HIP 78897"},
        {"Geneva Identification System", "GEN# +1.00144492"},
        {"Smithsonian Astrophysical Observation", "SAO 140952"},
        {"Wilson Evans Batten Catalogue", "WEB 13336"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.59301744),
        dec: Angle.Degrees(-04.75418152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44546"},
        {"Hipparcos Number", "HIP 30281"},
        {"Smithsonian Astrophysical Observation", "SAO 133167"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.54353056),
        dec: Angle.Degrees(-04.75361131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165438"},
        {"Hipparcos Number", "HIP 88684"},
        {"Geneva Identification System", "GEN# +1.00165438"},
        {"Smithsonian Astrophysical Observation", "SAO 142085"},
        {"Wilson Evans Batten Catalogue", "WEB 15025"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.56297335),
        dec: Angle.Degrees(-04.75117796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74199",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74199"},
        {"Cincinnati Publication", "Ci 20 913"},
        {"Geneva Identification System", "GEN# +9.80015010"},
    },
    visualMagnitude: 12.01,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.44159120),
        dec: Angle.Degrees(-04.75070646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -467.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131180"},
        {"Hipparcos Number", "HIP 72720"},
        {"Geneva Identification System", "GEN# +1.00131180"},
        {"Smithsonian Astrophysical Observation", "SAO 140189"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.02165585),
        dec: Angle.Degrees(-04.75057768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173764"},
        {"Hipparcos Number", "HIP 92175"},
        {"Fundamental Katalog 5th Edition", "FK5 1489"},
        {"Geneva Identification System", "GEN# +1.00173764"},
        {"Smithsonian Astrophysical Observation", "SAO 142618"},
        {"Wilson Evans Batten Catalogue", "WEB 15894"},
    },
    visualMagnitude: 4.22,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.79365558),
        dec: Angle.Degrees(-04.74782871)
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
    primaryId: "HIP 11268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15034"},
        {"Hipparcos Number", "HIP 11268"},
        {"Smithsonian Astrophysical Observation", "SAO 129889"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.27902299),
        dec: Angle.Degrees(-04.74695981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20620"},
        {"Hipparcos Number", "HIP 15440"},
        {"Smithsonian Astrophysical Observation", "SAO 130414"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.74548519),
        dec: Angle.Degrees(-04.74685959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214721"},
        {"Hipparcos Number", "HIP 111921"},
        {"Smithsonian Astrophysical Observation", "SAO 146234"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.06629465),
        dec: Angle.Degrees(-04.74572780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6705"},
        {"Hipparcos Number", "HIP 5294"},
        {"Smithsonian Astrophysical Observation", "SAO 129136"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.93569086),
        dec: Angle.Degrees(-04.74522400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123475"},
        {"Hipparcos Number", "HIP 69052"},
        {"Smithsonian Astrophysical Observation", "SAO 139746"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.01286420),
        dec: Angle.Degrees(-04.74517971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138762"},
        {"Hipparcos Number", "HIP 76220"},
        {"Geneva Identification System", "GEN# +1.00138762"},
        {"Smithsonian Astrophysical Observation", "SAO 140610"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.55435666),
        dec: Angle.Degrees(-04.74211421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184248"},
        {"Hipparcos Number", "HIP 96202"},
        {"Smithsonian Astrophysical Observation", "SAO 143536"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.43110967),
        dec: Angle.Degrees(-04.74190237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58986",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58986"},
    },
    visualMagnitude: 10.83,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.40948260),
        dec: Angle.Degrees(-04.74021434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95202",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12347 A"},
        {"Henry Draper", "HD 181806"},
        {"Hipparcos Number", "HIP 95202"},
        {"Smithsonian Astrophysical Observation", "SAO 143315"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.51534024),
        dec: Angle.Degrees(-04.73888624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94058"},
        {"Hipparcos Number", "HIP 53055"},
        {"Smithsonian Astrophysical Observation", "SAO 137839"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.82691102),
        dec: Angle.Degrees(-04.73649623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29161"},
        {"Hipparcos Number", "HIP 21383"},
        {"Geneva Identification System", "GEN# +1.00029161"},
        {"Smithsonian Astrophysical Observation", "SAO 131336"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.83983732),
        dec: Angle.Degrees(-04.73597041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95205",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12347 B"},
        {"Hipparcos Number", "HIP 95205"},
        {"Smithsonian Astrophysical Observation", "SAO 143316"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.51736976),
        dec: Angle.Degrees(-04.73372288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174916"},
        {"Hipparcos Number", "HIP 92686"},
        {"Geneva Identification System", "GEN# +1.00174916"},
        {"Renson", "Renson 48960"},
        {"Smithsonian Astrophysical Observation", "SAO 142749"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.29723008),
        dec: Angle.Degrees(-04.73204386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206766"},
        {"Hipparcos Number", "HIP 107336"},
        {"Smithsonian Astrophysical Observation", "SAO 145625"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.09949284),
        dec: Angle.Degrees(-04.73088517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100890"},
        {"Smithsonian Astrophysical Observation", "SAO 144445"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.85528526),
        dec: Angle.Degrees(-04.73083934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199960"},
        {"Hipparcos Number", "HIP 103682"},
        {"Fundamental Katalog 5th Edition", "FK5 789"},
        {"Geneva Identification System", "GEN# +1.00199960"},
        {"Smithsonian Astrophysical Observation", "SAO 145022"},
        {"Wilson Evans Batten Catalogue", "WEB 18872"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.14088420),
        dec: Angle.Degrees(-04.72992404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39747"},
        {"Hipparcos Number", "HIP 27915"},
        {"Geneva Identification System", "GEN# +1.00039747"},
        {"Smithsonian Astrophysical Observation", "SAO 132632"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.59991447),
        dec: Angle.Degrees(-04.72936840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44841"},
        {"Hipparcos Number", "HIP 30430"},
        {"Fundamental Katalog 5th Edition", "FK5 4578"},
        {"Smithsonian Astrophysical Observation", "SAO 133206"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.97343406),
        dec: Angle.Degrees(-04.72882596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193017"},
        {"Hipparcos Number", "HIP 100072"},
        {"Geneva Identification System", "GEN# +1.00193017"},
        {"Smithsonian Astrophysical Observation", "SAO 144266"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.54175750),
        dec: Angle.Degrees(-04.72861347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28073"},
        {"Hipparcos Number", "HIP 20671"},
        {"Geneva Identification System", "GEN# +1.00028073"},
        {"Smithsonian Astrophysical Observation", "SAO 131203"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.42358184),
        dec: Angle.Degrees(-04.72742550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176118"},
        {"Hipparcos Number", "HIP 93190"},
        {"Geneva Identification System", "GEN# +1.00176118"},
        {"Smithsonian Astrophysical Observation", "SAO 142868"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.72128225),
        dec: Angle.Degrees(-04.72666643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115388"},
        {"Hipparcos Number", "HIP 64811"},
        {"Smithsonian Astrophysical Observation", "SAO 139260"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.25170951),
        dec: Angle.Degrees(-04.72558509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43924",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43924"},
        {"Smithsonian Astrophysical Observation", "SAO 136428"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.21010068),
        dec: Angle.Degrees(-04.72497615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18452"},
        {"Hipparcos Number", "HIP 13827"},
        {"Smithsonian Astrophysical Observation", "SAO 130209"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.48954547),
        dec: Angle.Degrees(-04.72432577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6825"},
        {"Hipparcos Number", "HIP 5384"},
        {"Geneva Identification System", "GEN# +1.00006825"},
        {"Smithsonian Astrophysical Observation", "SAO 129142"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.22110876),
        dec: Angle.Degrees(-04.72246098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196147"},
        {"Hipparcos Number", "HIP 101616"},
        {"Geneva Identification System", "GEN# +1.00196147"},
        {"Smithsonian Astrophysical Observation", "SAO 144608"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.91606895),
        dec: Angle.Degrees(-04.72115515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210763"},
        {"Hipparcos Number", "HIP 109647"},
        {"Geneva Identification System", "GEN# +1.00210763"},
        {"Smithsonian Astrophysical Observation", "SAO 145940"},
        {"Wilson Evans Batten Catalogue", "WEB 19700"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.18289491),
        dec: Angle.Degrees(-04.72059382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35562"},
        {"Hipparcos Number", "HIP 25360"},
        {"Smithsonian Astrophysical Observation", "SAO 132085"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.35868718),
        dec: Angle.Degrees(-04.72006342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70937"},
        {"Hipparcos Number", "HIP 41214"},
        {"Geneva Identification System", "GEN# +1.00070937"},
        {"Smithsonian Astrophysical Observation", "SAO 135882"},
        {"Wilson Evans Batten Catalogue", "WEB 7974"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.15175238),
        dec: Angle.Degrees(-04.71686289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25280"},
        {"Hipparcos Number", "HIP 18751"},
        {"Smithsonian Astrophysical Observation", "SAO 130871"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.24801374),
        dec: Angle.Degrees(-04.71563213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17665"},
        {"Hipparcos Number", "HIP 13212"},
        {"Geneva Identification System", "GEN# +1.00017665"},
        {"Smithsonian Astrophysical Observation", "SAO 130137"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.50647760),
        dec: Angle.Degrees(-04.71384923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217563"},
        {"Hipparcos Number", "HIP 113686"},
        {"Geneva Identification System", "GEN# +1.00217563"},
        {"Smithsonian Astrophysical Observation", "SAO 146451"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.38209154),
        dec: Angle.Degrees(-04.71147966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120248"},
        {"Hipparcos Number", "HIP 67366"},
        {"Geneva Identification System", "GEN# +1.00120248"},
        {"Smithsonian Astrophysical Observation", "SAO 139560"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.10875029),
        dec: Angle.Degrees(-04.70937334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171331"},
        {"Hipparcos Number", "HIP 91057"},
        {"Smithsonian Astrophysical Observation", "SAO 142399"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.62267121),
        dec: Angle.Degrees(-04.70927086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62386"},
        {"Hipparcos Number", "HIP 37655"},
        {"Geneva Identification System", "GEN# +1.00062386"},
        {"Smithsonian Astrophysical Observation", "SAO 135034"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.90559998),
        dec: Angle.Degrees(-04.70790368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64215"},
        {"Hipparcos Number", "HIP 38462"},
        {"Smithsonian Astrophysical Observation", "SAO 135203"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.17612538),
        dec: Angle.Degrees(-04.70781239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19379",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19379"},
        {"Smithsonian Astrophysical Observation", "SAO 130985"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.27147285),
        dec: Angle.Degrees(-04.70727776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55036"},
        {"Hipparcos Number", "HIP 34694"},
        {"Geneva Identification System", "GEN# +1.00055036"},
        {"Smithsonian Astrophysical Observation", "SAO 134309"},
        {"Wilson Evans Batten Catalogue", "WEB 6935"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.79379987),
        dec: Angle.Degrees(-04.70332347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198708"},
        {"Hipparcos Number", "HIP 103020"},
        {"Smithsonian Astrophysical Observation", "SAO 144890"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.07819569),
        dec: Angle.Degrees(-04.70259217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49455"},
        {"Hipparcos Number", "HIP 32630"},
        {"Smithsonian Astrophysical Observation", "SAO 133692"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.09680304),
        dec: Angle.Degrees(-04.70215904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 294176"},
        {"Hipparcos Number", "HIP 25669"},
        {"Smithsonian Astrophysical Observation", "SAO 132159"},
    },
    visualMagnitude: 10.23,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.24320488),
        dec: Angle.Degrees(-04.70054701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75561"},
        {"Hipparcos Number", "HIP 43417"},
        {"Renson", "Renson 21140"},
        {"Smithsonian Astrophysical Observation", "SAO 136327"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.65140667),
        dec: Angle.Degrees(-04.69958228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12143"},
        {"Hipparcos Number", "HIP 9266"},
        {"Smithsonian Astrophysical Observation", "SAO 129600"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.77282784),
        dec: Angle.Degrees(-04.69902901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47761"},
        {"Hipparcos Number", "HIP 31894"},
        {"Geneva Identification System", "GEN# +1.00047761"},
        {"Smithsonian Astrophysical Observation", "SAO 133542"},
        {"Wilson Evans Batten Catalogue", "WEB 6410"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.00658780),
        dec: Angle.Degrees(-04.69870864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36017"},
        {"Hipparcos Number", "HIP 25636"},
        {"Fundamental Katalog 5th Edition", "FK5 4502"},
        {"Geneva Identification System", "GEN# +1.00036017J"},
        {"Renson", "Renson 9270"},
        {"Smithsonian Astrophysical Observation", "SAO 132146"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.13845535),
        dec: Angle.Degrees(-04.69701432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45975"},
        {"Hipparcos Number", "HIP 31011"},
        {"Celescope Catalog", "CEL 1269"},
        {"Geneva Identification System", "GEN# +2.22320006"},
        {"Smithsonian Astrophysical Observation", "SAO 133348"},
        {"New General Catalogue", "NGC 2232 6"},
    },
    visualMagnitude: 7.47,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.61446449),
        dec: Angle.Degrees(-04.69681057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38292"},
        {"Hipparcos Number", "HIP 27079"},
        {"Celescope Catalog", "CEL 957"},
        {"Smithsonian Astrophysical Observation", "SAO 132504"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.13195901),
        dec: Angle.Degrees(-04.69575982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102332"},
        {"Hipparcos Number", "HIP 57462"},
        {"Smithsonian Astrophysical Observation", "SAO 138400"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.68434083),
        dec: Angle.Degrees(-04.69552453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112139",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16202 AB"},
        {"Henry Draper", "HD 215095"},
        {"Hipparcos Number", "HIP 112139"},
        {"Smithsonian Astrophysical Observation", "SAO 146265"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.72420960),
        dec: Angle.Degrees(-04.69425666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187570"},
        {"Hipparcos Number", "HIP 97655"},
        {"Smithsonian Astrophysical Observation", "SAO 143839"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.70272598),
        dec: Angle.Degrees(-04.69407670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79882",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Yed Posterior"},
        {"Henry Draper", "HD 146791"},
        {"Hipparcos Number", "HIP 79882"},
        {"Fundamental Katalog 5th Edition", "FK5 605"},
        {"Geneva Identification System", "GEN# +1.00146791"},
        {"Smithsonian Astrophysical Observation", "SAO 141086"},
        {"Wilson Evans Batten Catalogue", "WEB 13523"},
    },
    visualMagnitude: 3.23,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.58016994),
        dec: Angle.Degrees(-04.69260809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90826"},
        {"Hipparcos Number", "HIP 51329"},
        {"Smithsonian Astrophysical Observation", "SAO 137595"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.26920290),
        dec: Angle.Degrees(-04.69241160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -181.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36090"},
        {"Hipparcos Number", "HIP 25673"},
        {"Geneva Identification System", "GEN# +1.00036090A"},
        {"Smithsonian Astrophysical Observation", "SAO 132163"},
        {"Wilson Evans Batten Catalogue", "WEB 4983"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.25369220),
        dec: Angle.Degrees(-04.69240361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205438"},
        {"Hipparcos Number", "HIP 106598"},
        {"Smithsonian Astrophysical Observation", "SAO 145511"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.83570809),
        dec: Angle.Degrees(-04.69083278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44756"},
        {"Hipparcos Number", "HIP 30387"},
        {"Geneva Identification System", "GEN# +1.00044756"},
        {"Smithsonian Astrophysical Observation", "SAO 133199"},
        {"Wilson Evans Batten Catalogue", "WEB 6045"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.84496841),
        dec: Angle.Degrees(-04.68746859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42369"},
        {"Hipparcos Number", "HIP 29267"},
        {"Smithsonian Astrophysical Observation", "SAO 132908"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.55176022),
        dec: Angle.Degrees(-04.68312688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62729",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62729"},
        {"Smithsonian Astrophysical Observation", "SAO 139000"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.81853831),
        dec: Angle.Degrees(-04.68172623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111197"},
        {"Hipparcos Number", "HIP 62422"},
        {"Smithsonian Astrophysical Observation", "SAO 138968"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.89227888),
        dec: Angle.Degrees(-04.68122714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62367"},
        {"Hipparcos Number", "HIP 37647"},
        {"Geneva Identification System", "GEN# +1.00062367"},
        {"Smithsonian Astrophysical Observation", "SAO 135030"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.88388146),
        dec: Angle.Degrees(-04.68065530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59765"},
        {"Hipparcos Number", "HIP 36572"},
        {"Smithsonian Astrophysical Observation", "SAO 134784"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.83888329),
        dec: Angle.Degrees(-04.67893328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95113"},
        {"Hipparcos Number", "HIP 53672"},
        {"Smithsonian Astrophysical Observation", "SAO 137920"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.72251015),
        dec: Angle.Degrees(-04.67800990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34401",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5813 AB"},
        {"Henry Draper", "HD 54250"},
        {"Hipparcos Number", "HIP 34401"},
        {"Smithsonian Astrophysical Observation", "SAO 134234"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.98694887),
        dec: Angle.Degrees(-04.67787594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20407",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3163 AB"},
        {"Henry Draper", "HD 27699"},
        {"Hipparcos Number", "HIP 20407"},
        {"Smithsonian Astrophysical Observation", "SAO 131150"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.54256235),
        dec: Angle.Degrees(-04.67695089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148150"},
        {"Hipparcos Number", "HIP 80519"},
        {"Smithsonian Astrophysical Observation", "SAO 141174"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.56770265),
        dec: Angle.Degrees(-04.67588961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77877"},
        {"Hipparcos Number", "HIP 44575"},
        {"Smithsonian Astrophysical Observation", "SAO 136557"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.23185961),
        dec: Angle.Degrees(-04.67423709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8765"},
        {"Hipparcos Number", "HIP 6712"},
        {"Cincinnati Publication", "Ci 18 193"},
        {"Geneva Identification System", "GEN# +1.00008765"},
        {"Smithsonian Astrophysical Observation", "SAO 129296"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.58026763),
        dec: Angle.Degrees(-04.67385717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17296"},
        {"Hipparcos Number", "HIP 12955"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.64598476),
        dec: Angle.Degrees(-04.67375787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220134"},
        {"Hipparcos Number", "HIP 115316"},
        {"Smithsonian Astrophysical Observation", "SAO 146659"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.33981067),
        dec: Angle.Degrees(-04.67269023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224104"},
        {"Hipparcos Number", "HIP 117926"},
        {"Smithsonian Astrophysical Observation", "SAO 146977"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.78218565),
        dec: Angle.Degrees(-04.66804645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222344"},
        {"Hipparcos Number", "HIP 116753"},
        {"Smithsonian Astrophysical Observation", "SAO 146831"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.93273592),
        dec: Angle.Degrees(-04.66608206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200156"},
        {"Hipparcos Number", "HIP 103785"},
        {"Geneva Identification System", "GEN# +1.00200156"},
        {"Smithsonian Astrophysical Observation", "SAO 145039"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.46838453),
        dec: Angle.Degrees(-04.66603037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33801"},
        {"Hipparcos Number", "HIP 24280"},
        {"Smithsonian Astrophysical Observation", "SAO 131870"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.16055634),
        dec: Angle.Degrees(-04.66567748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135049"},
        {"Hipparcos Number", "HIP 74483"},
        {"Smithsonian Astrophysical Observation", "SAO 140384"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.29383138),
        dec: Angle.Degrees(-04.66562091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29401",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4799 AB"},
        {"Henry Draper", "HD 42657"},
        {"Hipparcos Number", "HIP 29401"},
        {"Celescope Catalog", "CEL 1117"},
        {"Geneva Identification System", "GEN# +1.00042657J"},
        {"Renson", "Renson 11400"},
        {"Smithsonian Astrophysical Observation", "SAO 132941"},
    },
    visualMagnitude: 6.18,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.93216682),
        dec: Angle.Degrees(-04.66543156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65243",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8873 AB"},
        {"Henry Draper", "HD 116209"},
        {"Hipparcos Number", "HIP 65243"},
        {"Smithsonian Astrophysical Observation", "SAO 139299"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.54771273),
        dec: Angle.Degrees(-04.66270606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125710"},
        {"Hipparcos Number", "HIP 70161"},
        {"Smithsonian Astrophysical Observation", "SAO 139882"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.32906205),
        dec: Angle.Degrees(-04.65904590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
