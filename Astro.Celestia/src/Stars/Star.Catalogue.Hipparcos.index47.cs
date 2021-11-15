using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_47() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27507"},
        {"Hipparcos Number", "HIP 20214"},
        {"Geneva Identification System", "GEN# +1.00027507"},
        {"Smithsonian Astrophysical Observation", "SAO 149548"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.97764804),
        dec: Angle.Degrees(-16.93553536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30495"},
        {"Hipparcos Number", "HIP 22263"},
        {"Geneva Identification System", "GEN# +1.00030495"},
        {"Smithsonian Astrophysical Observation", "SAO 149888"},
        {"Wilson Evans Batten Catalogue", "WEB 4286"},
    },
    visualMagnitude: 5.49,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.90088443),
        dec: Angle.Degrees(-16.93486728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 169.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135424"},
        {"Hipparcos Number", "HIP 74669"},
        {"Smithsonian Astrophysical Observation", "SAO 159130"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.89143803),
        dec: Angle.Degrees(-16.93466432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150415"},
        {"Hipparcos Number", "HIP 81723"},
        {"Geneva Identification System", "GEN# +1.00150415"},
        {"Smithsonian Astrophysical Observation", "SAO 160047"},
        {"Wilson Evans Batten Catalogue", "WEB 13804"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.39255251),
        dec: Angle.Degrees(-16.93337587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88359"},
        {"Hipparcos Number", "HIP 49867"},
        {"Smithsonian Astrophysical Observation", "SAO 155793"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.73838485),
        dec: Angle.Degrees(-16.93080617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56705",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8243 A"},
        {"Henry Draper", "HD 101044"},
        {"Hipparcos Number", "HIP 56705"},
        {"Smithsonian Astrophysical Observation", "SAO 156790"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.39521498),
        dec: Angle.Degrees(-16.93070405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11522"},
        {"Hipparcos Number", "HIP 8778"},
        {"Fundamental Katalog 5th Edition", "FK5 2125"},
        {"Geneva Identification System", "GEN# +1.00011522"},
        {"Renson", "Renson 2940"},
        {"Smithsonian Astrophysical Observation", "SAO 148078"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.21703176),
        dec: Angle.Degrees(-16.92912351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56703",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8243 B"},
        {"Hipparcos Number", "HIP 56703"},
        {"Smithsonian Astrophysical Observation", "SAO 156789"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.39509379),
        dec: Angle.Degrees(-16.92693427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118186"},
        {"Hipparcos Number", "HIP 66319"},
        {"Geneva Identification System", "GEN# +1.00118186"},
        {"Smithsonian Astrophysical Observation", "SAO 158026"},
        {"Wilson Evans Batten Catalogue", "WEB 11715"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.87917519),
        dec: Angle.Degrees(-16.92390833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180629"},
        {"Hipparcos Number", "HIP 94839"},
        {"Geneva Identification System", "GEN# +1.00180629"},
        {"Smithsonian Astrophysical Observation", "SAO 162421"},
        {"Wilson Evans Batten Catalogue", "WEB 16550"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.46163291),
        dec: Angle.Degrees(-16.92137149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37548"},
        {"Hipparcos Number", "HIP 26534"},
        {"Geneva Identification System", "GEN# +1.00037548"},
        {"Smithsonian Astrophysical Observation", "SAO 150643"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.65750850),
        dec: Angle.Degrees(-16.91903880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139995"},
        {"Hipparcos Number", "HIP 76879"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.48579205),
        dec: Angle.Degrees(-16.91472760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108564"},
        {"Hipparcos Number", "HIP 60853"},
        {"Cincinnati Publication", "Ci 20 710"},
        {"Geneva Identification System", "GEN# +1.00108564"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.08108690),
        dec: Angle.Degrees(-16.91115889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -560.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96666",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12728 B"},
        {"Henry Draper", "HD 185344B"},
        {"Hipparcos Number", "HIP 96666"},
        {"Smithsonian Astrophysical Observation", "SAO 162852"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.80159275),
        dec: Angle.Degrees(-16.90949451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219202"},
        {"Hipparcos Number", "HIP 114720"},
        {"Smithsonian Astrophysical Observation", "SAO 165574"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.57276113),
        dec: Angle.Degrees(-16.90911690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24335",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24335"},
        {"Smithsonian Astrophysical Observation", "SAO 150249"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.34607866),
        dec: Angle.Degrees(-16.90876806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96667",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12728 A"},
        {"Henry Draper", "HD 185344"},
        {"Hipparcos Number", "HIP 96667"},
        {"Smithsonian Astrophysical Observation", "SAO 162853"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.80398419),
        dec: Angle.Degrees(-16.90793633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154909"},
        {"Hipparcos Number", "HIP 83917"},
        {"Geneva Identification System", "GEN# +1.00154909"},
        {"Smithsonian Astrophysical Observation", "SAO 160313"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.25560999),
        dec: Angle.Degrees(-16.90319465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83131",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10287 AB"},
        {"Henry Draper", "HD 153305"},
        {"Hipparcos Number", "HIP 83131"},
        {"Smithsonian Astrophysical Observation", "SAO 160209"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.82722193),
        dec: Angle.Degrees(-16.90256929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218885"},
        {"Hipparcos Number", "HIP 114519"},
        {"Smithsonian Astrophysical Observation", "SAO 165547"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.92722613),
        dec: Angle.Degrees(-16.90145713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151124"},
        {"Hipparcos Number", "HIP 82089"},
        {"Smithsonian Astrophysical Observation", "SAO 160085"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.52220744),
        dec: Angle.Degrees(-16.90054913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218071"},
        {"Hipparcos Number", "HIP 114010"},
        {"Geneva Identification System", "GEN# +1.00218071"},
        {"Smithsonian Astrophysical Observation", "SAO 165482"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.34211600),
        dec: Angle.Degrees(-16.89843237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170495"},
        {"Hipparcos Number", "HIP 90709"},
        {"Wilson Evans Batten Catalogue", "WEB 15538"},
    },
    visualMagnitude: 9.23,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.60853378),
        dec: Angle.Degrees(-16.89703817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166540"},
        {"Hipparcos Number", "HIP 89164"},
        {"Geneva Identification System", "GEN# +1.00166540"},
        {"Smithsonian Astrophysical Observation", "SAO 161164"},
        {"Wilson Evans Batten Catalogue", "WEB 15143"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.94833904),
        dec: Angle.Degrees(-16.89393114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112342"},
        {"Hipparcos Number", "HIP 63134"},
        {"Smithsonian Astrophysical Observation", "SAO 157603"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.03047323),
        dec: Angle.Degrees(-16.89244684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13805"},
        {"Hipparcos Number", "HIP 10406"},
        {"Geneva Identification System", "GEN# +1.00013805"},
        {"Smithsonian Astrophysical Observation", "SAO 148283"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.52135157),
        dec: Angle.Degrees(-16.89020695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51652"},
        {"Hipparcos Number", "HIP 33476"},
        {"Geneva Identification System", "GEN# +1.00051652"},
        {"Smithsonian Astrophysical Observation", "SAO 152164"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.38295546),
        dec: Angle.Degrees(-16.88958775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97663"},
        {"Hipparcos Number", "HIP 54876"},
        {"Geneva Identification System", "GEN# +1.00097663"},
        {"Smithsonian Astrophysical Observation", "SAO 156554"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.54404634),
        dec: Angle.Degrees(-16.88625427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187801"},
        {"Hipparcos Number", "HIP 97802"},
        {"Fundamental Katalog 5th Edition", "FK5 5755"},
        {"Smithsonian Astrophysical Observation", "SAO 163066"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.11075296),
        dec: Angle.Degrees(-16.88625205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178464"},
        {"Hipparcos Number", "HIP 94110"},
        {"Geneva Identification System", "GEN# +1.00178464"},
        {"Smithsonian Astrophysical Observation", "SAO 162251"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.35127674),
        dec: Angle.Degrees(-16.88575694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72377"},
        {"Hipparcos Number", "HIP 41849"},
        {"Smithsonian Astrophysical Observation", "SAO 154362"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.99521774),
        dec: Angle.Degrees(-16.88480689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144112"},
        {"Hipparcos Number", "HIP 78755"},
        {"Smithsonian Astrophysical Observation", "SAO 159673"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.18196663),
        dec: Angle.Degrees(-16.88440324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113289"},
        {"Hipparcos Number", "HIP 63672"},
        {"Smithsonian Astrophysical Observation", "SAO 157677"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.73957275),
        dec: Angle.Degrees(-16.88135578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217446"},
        {"Hipparcos Number", "HIP 113637"},
        {"Geneva Identification System", "GEN# +1.00217446"},
        {"Smithsonian Astrophysical Observation", "SAO 165434"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.21634115),
        dec: Angle.Degrees(-16.88073355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199706"},
        {"Hipparcos Number", "HIP 103601"},
        {"Smithsonian Astrophysical Observation", "SAO 164041"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.86529203),
        dec: Angle.Degrees(-16.87958361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185571"},
        {"Hipparcos Number", "HIP 96779"},
        {"Smithsonian Astrophysical Observation", "SAO 162877"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.07232947),
        dec: Angle.Degrees(-16.87807046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92214"},
        {"Hipparcos Number", "HIP 52085"},
        {"Fundamental Katalog 5th Edition", "FK5 2850"},
        {"Geneva Identification System", "GEN# +1.00092214"},
        {"Smithsonian Astrophysical Observation", "SAO 156122"},
        {"Wilson Evans Batten Catalogue", "WEB 9494"},
    },
    visualMagnitude: 4.91,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.64588780),
        dec: Angle.Degrees(-16.87663687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219405"},
        {"Hipparcos Number", "HIP 114832"},
        {"Smithsonian Astrophysical Observation", "SAO 165593"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.91673710),
        dec: Angle.Degrees(-16.87608707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220144"},
        {"Hipparcos Number", "HIP 115325"},
        {"Smithsonian Astrophysical Observation", "SAO 165647"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.38096437),
        dec: Angle.Degrees(-16.87572711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96079"},
        {"Hipparcos Number", "HIP 54164"},
        {"Smithsonian Astrophysical Observation", "SAO 156440"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.19634045),
        dec: Angle.Degrees(-16.87473274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129700"},
        {"Hipparcos Number", "HIP 72068"},
        {"Smithsonian Astrophysical Observation", "SAO 158767"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.12148613),
        dec: Angle.Degrees(-16.87468758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47561"},
        {"Hipparcos Number", "HIP 31758"},
        {"Celescope Catalog", "CEL 1338"},
        {"Geneva Identification System", "GEN# +1.00047561"},
        {"Smithsonian Astrophysical Observation", "SAO 151737"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.64763095),
        dec: Angle.Degrees(-16.87348646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140387"},
        {"Hipparcos Number", "HIP 77044"},
        {"Smithsonian Astrophysical Observation", "SAO 159465"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.98810793),
        dec: Angle.Degrees(-16.86924203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189625"},
        {"Hipparcos Number", "HIP 98589"},
        {"Geneva Identification System", "GEN# +1.00189625"},
        {"Smithsonian Astrophysical Observation", "SAO 163190"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.38629401),
        dec: Angle.Degrees(-16.86881347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177423"},
        {"Hipparcos Number", "HIP 93740"},
        {"Smithsonian Astrophysical Observation", "SAO 162170"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.31201889),
        dec: Angle.Degrees(-16.86683123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31127"},
        {"Hipparcos Number", "HIP 22679"},
        {"Smithsonian Astrophysical Observation", "SAO 149959"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.15818666),
        dec: Angle.Degrees(-16.86638817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21443"},
        {"Hipparcos Number", "HIP 16062"},
        {"Smithsonian Astrophysical Observation", "SAO 148966"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.72400150),
        dec: Angle.Degrees(-16.86525094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161100"},
        {"Hipparcos Number", "HIP 86814"},
        {"Geneva Identification System", "GEN# +1.00161100"},
        {"Smithsonian Astrophysical Observation", "SAO 160789"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.08198814),
        dec: Angle.Degrees(-16.86467944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205859"},
        {"Hipparcos Number", "HIP 106859"},
        {"Smithsonian Astrophysical Observation", "SAO 164541"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.64002802),
        dec: Angle.Degrees(-16.86384570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45018",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7222 A"},
        {"Henry Draper", "HD 78891"},
        {"Hipparcos Number", "HIP 45018"},
        {"Geneva Identification System", "GEN# +1.00078891"},
        {"Smithsonian Astrophysical Observation", "SAO 154967"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.54319845),
        dec: Angle.Degrees(-16.86262441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37190"},
        {"Hipparcos Number", "HIP 26303"},
        {"Smithsonian Astrophysical Observation", "SAO 150599"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.02086642),
        dec: Angle.Degrees(-16.86251118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14235"},
        {"Hipparcos Number", "HIP 10706"},
        {"Smithsonian Astrophysical Observation", "SAO 148315"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.45228851),
        dec: Angle.Degrees(-16.86183104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69791"},
        {"Hipparcos Number", "HIP 40660"},
        {"Smithsonian Astrophysical Observation", "SAO 154084"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.50178314),
        dec: Angle.Degrees(-16.86065018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70039"},
        {"Hipparcos Number", "HIP 40771"},
        {"Smithsonian Astrophysical Observation", "SAO 154109"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.81948126),
        dec: Angle.Degrees(-16.86063312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180034"},
        {"Hipparcos Number", "HIP 94647"},
        {"Geneva Identification System", "GEN# +1.00180034"},
        {"Smithsonian Astrophysical Observation", "SAO 162373"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.88862547),
        dec: Angle.Degrees(-16.85909147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116768"},
        {"Hipparcos Number", "HIP 65532"},
        {"Smithsonian Astrophysical Observation", "SAO 157932"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.52602659),
        dec: Angle.Degrees(-16.85862048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163797"},
        {"Hipparcos Number", "HIP 88019"},
        {"Geneva Identification System", "GEN# +1.00163797"},
        {"Smithsonian Astrophysical Observation", "SAO 160954"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.67563665),
        dec: Angle.Degrees(-16.85746494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176680"},
        {"Hipparcos Number", "HIP 93464"},
        {"Geneva Identification System", "GEN# +1.00176680"},
        {"Smithsonian Astrophysical Observation", "SAO 162106"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.52507704),
        dec: Angle.Degrees(-16.85546315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119607"},
        {"Hipparcos Number", "HIP 67055"},
        {"Smithsonian Astrophysical Observation", "SAO 158130"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.12394001),
        dec: Angle.Degrees(-16.85450125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64498"},
        {"Hipparcos Number", "HIP 38556"},
        {"Smithsonian Astrophysical Observation", "SAO 153554"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.42089822),
        dec: Angle.Degrees(-16.85344495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138485"},
        {"Hipparcos Number", "HIP 76126"},
        {"Geneva Identification System", "GEN# +1.00138485"},
        {"Smithsonian Astrophysical Observation", "SAO 159335"},
        {"Wilson Evans Batten Catalogue", "WEB 12932"},
    },
    visualMagnitude: 5.53,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.23011545),
        dec: Angle.Degrees(-16.85280725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192410"},
        {"Hipparcos Number", "HIP 99823"},
        {"Smithsonian Astrophysical Observation", "SAO 163384"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.80655466),
        dec: Angle.Degrees(-16.85089387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100873"},
        {"Hipparcos Number", "HIP 56614"},
        {"Geneva Identification System", "GEN# +1.00100873"},
        {"Smithsonian Astrophysical Observation", "SAO 156783"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.12003317),
        dec: Angle.Degrees(-16.84989382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -165.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149789"},
        {"Hipparcos Number", "HIP 81409"},
        {"Smithsonian Astrophysical Observation", "SAO 160012"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.40491870),
        dec: Angle.Degrees(-16.84982413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84454",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84454"},
    },
    visualMagnitude: 10.77,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.99324739),
        dec: Angle.Degrees(-16.84904968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61589"},
        {"Hipparcos Number", "HIP 37289"},
        {"Smithsonian Astrophysical Observation", "SAO 153204"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.85081931),
        dec: Angle.Degrees(-16.84725474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65674"},
        {"Hipparcos Number", "HIP 39043"},
        {"Geneva Identification System", "GEN# +1.00065674"},
        {"Smithsonian Astrophysical Observation", "SAO 153673"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.81965918),
        dec: Angle.Degrees(-16.84636477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84410"},
        {"Hipparcos Number", "HIP 47813"},
        {"Renson", "Renson 24085"},
        {"Smithsonian Astrophysical Observation", "SAO 155447"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.20278627),
        dec: Angle.Degrees(-16.84611856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221503"},
        {"Hipparcos Number", "HIP 116215"},
        {"Geneva Identification System", "GEN# +1.00221503"},
        {"Smithsonian Astrophysical Observation", "SAO 165756"},
        {"Wilson Evans Batten Catalogue", "WEB 20540"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.20496028),
        dec: Angle.Degrees(-16.84511194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 343.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207552"},
        {"Hipparcos Number", "HIP 107797"},
        {"Geneva Identification System", "GEN# +1.00207552"},
        {"Smithsonian Astrophysical Observation", "SAO 164686"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.55404075),
        dec: Angle.Degrees(-16.84489999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137975"},
        {"Henry Draper 2", "HD 137976"},
        {"Hipparcos Number", "HIP 75858"},
        {"Smithsonian Astrophysical Observation", "SAO 159294"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.43218812),
        dec: Angle.Degrees(-16.84118849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79976"},
        {"Hipparcos Number", "HIP 45528"},
        {"Renson", "Renson 22750"},
        {"Smithsonian Astrophysical Observation", "SAO 155053"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.17437188),
        dec: Angle.Degrees(-16.83698222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182453"},
        {"Hipparcos Number", "HIP 95482"},
        {"Smithsonian Astrophysical Observation", "SAO 162592"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.32903988),
        dec: Angle.Degrees(-16.83644455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90432"},
        {"Hipparcos Number", "HIP 51069"},
        {"Fundamental Katalog 5th Edition", "FK5 389"},
        {"Geneva Identification System", "GEN# +9.00050021"},
        {"Smithsonian Astrophysical Observation", "SAO 155980"},
        {"Wilson Evans Batten Catalogue", "WEB 9336"},
    },
    visualMagnitude: 3.83,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.52293768),
        dec: Angle.Degrees(-16.83609584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203387"},
        {"Hipparcos Number", "HIP 105515"},
        {"Fundamental Katalog 5th Edition", "FK5 1561"},
        {"Geneva Identification System", "GEN# +1.00203387"},
        {"Smithsonian Astrophysical Observation", "SAO 164346"},
        {"Wilson Evans Batten Catalogue", "WEB 19159"},
    },
    visualMagnitude: 4.28,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.56157261),
        dec: Angle.Degrees(-16.83455521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13115"},
        {"Hipparcos Number", "HIP 9939"},
        {"Smithsonian Astrophysical Observation", "SAO 148225"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.99298632),
        dec: Angle.Degrees(-16.83289019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10734"},
        {"Hipparcos Number", "HIP 8136"},
        {"Smithsonian Astrophysical Observation", "SAO 147993"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.15502285),
        dec: Angle.Degrees(-16.83219498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167335"},
        {"Hipparcos Number", "HIP 89453"},
        {"Smithsonian Astrophysical Observation", "SAO 161222"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.83412017),
        dec: Angle.Degrees(-16.83145400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27598"},
        {"Hipparcos Number", "HIP 20269"},
        {"Geneva Identification System", "GEN# +1.00027598"},
        {"Smithsonian Astrophysical Observation", "SAO 149559"},
        {"Wilson Evans Batten Catalogue", "WEB 3876"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.17221370),
        dec: Angle.Degrees(-16.83000376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193479"},
        {"Hipparcos Number", "HIP 100337"},
        {"Smithsonian Astrophysical Observation", "SAO 163474"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.22980358),
        dec: Angle.Degrees(-16.82976043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20340"},
        {"Hipparcos Number", "HIP 15188"},
        {"Geneva Identification System", "GEN# +1.00020340"},
        {"Smithsonian Astrophysical Observation", "SAO 148864"},
        {"Wilson Evans Batten Catalogue", "WEB 2925"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.94108779),
        dec: Angle.Degrees(-16.82872081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29368",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4797 AB"},
        {"Henry Draper", "HD 42692"},
        {"Hipparcos Number", "HIP 29368"},
        {"Smithsonian Astrophysical Observation", "SAO 151200"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.85266618),
        dec: Angle.Degrees(-16.82856297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161822"},
        {"Hipparcos Number", "HIP 87161"},
        {"Smithsonian Astrophysical Observation", "SAO 160829"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.10649374),
        dec: Angle.Degrees(-16.82715790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61463",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8603 AP"},
        {"Henry Draper", "HD 109557"},
        {"Hipparcos Number", "HIP 61463"},
        {"Smithsonian Astrophysical Observation", "SAO 157382"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.92838675),
        dec: Angle.Degrees(-16.82613623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8037",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8037"},
        {"Smithsonian Astrophysical Observation", "SAO 147975"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.80097912),
        dec: Angle.Degrees(-16.82595755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60162"},
        {"Hipparcos Number", "HIP 36670"},
        {"Smithsonian Astrophysical Observation", "SAO 153039"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.15873033),
        dec: Angle.Degrees(-16.82482793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 192.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 115.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166287"},
        {"Hipparcos Number", "HIP 89060"},
        {"Geneva Identification System", "GEN# +1.00166287"},
        {"Smithsonian Astrophysical Observation", "SAO 161142"},
        {"Wilson Evans Batten Catalogue", "WEB 15118"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.65778413),
        dec: Angle.Degrees(-16.82452233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84944"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.40395667),
        dec: Angle.Degrees(-16.82123954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127844"},
        {"Hipparcos Number", "HIP 71234"},
        {"Smithsonian Astrophysical Observation", "SAO 158642"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.51564115),
        dec: Angle.Degrees(-16.81956453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70031",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70031"},
        {"Smithsonian Astrophysical Observation", "SAO 158496"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.95078349),
        dec: Angle.Degrees(-16.81934266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43827"},
        {"Hipparcos Number", "HIP 29895"},
        {"Geneva Identification System", "GEN# +1.00043827"},
        {"Smithsonian Astrophysical Observation", "SAO 151322"},
        {"Wilson Evans Batten Catalogue", "WEB 5920"},
    },
    visualMagnitude: 5.15,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.42388578),
        dec: Angle.Degrees(-16.81591325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40045"},
        {"Hipparcos Number", "HIP 28038"},
        {"Smithsonian Astrophysical Observation", "SAO 150945"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.94241295),
        dec: Angle.Degrees(-16.81475559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17560"},
        {"Hipparcos Number", "HIP 13114"},
        {"Geneva Identification System", "GEN# +1.00017560"},
        {"Smithsonian Astrophysical Observation", "SAO 148619"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.16565180),
        dec: Angle.Degrees(-16.81124910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142913"},
        {"Hipparcos Number", "HIP 78171"},
        {"Smithsonian Astrophysical Observation", "SAO 159601"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.42207392),
        dec: Angle.Degrees(-16.81076145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82494"},
        {"Hipparcos Number", "HIP 46773"},
        {"Geneva Identification System", "GEN# +1.00082494"},
        {"Smithsonian Astrophysical Observation", "SAO 155264"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.98764202),
        dec: Angle.Degrees(-16.80691695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152781"},
        {"Hipparcos Number", "HIP 82861"},
        {"Geneva Identification System", "GEN# +1.00152781"},
        {"Smithsonian Astrophysical Observation", "SAO 160171"},
        {"Wilson Evans Batten Catalogue", "WEB 14004"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.00747514),
        dec: Angle.Degrees(-16.80633820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47039"},
        {"Hipparcos Number", "HIP 31518"},
        {"Smithsonian Astrophysical Observation", "SAO 151684"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.99207332),
        dec: Angle.Degrees(-16.80432372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44485"},
        {"Hipparcos Number", "HIP 30207"},
        {"Celescope Catalog", "CEL 1195"},
        {"Smithsonian Astrophysical Observation", "SAO 151402"},
    },
    visualMagnitude: 7.54,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.33158187),
        dec: Angle.Degrees(-16.80377439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14256"},
        {"Hipparcos Number", "HIP 10720"},
        {"Smithsonian Astrophysical Observation", "SAO 148317"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.50088348),
        dec: Angle.Degrees(-16.80138271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80369"},
        {"Hipparcos Number", "HIP 45697"},
        {"Geneva Identification System", "GEN# +1.00080369"},
        {"Smithsonian Astrophysical Observation", "SAO 155084"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.74167091),
        dec: Angle.Degrees(-16.80077447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131827"},
        {"Hipparcos Number", "HIP 73097"},
        {"Geneva Identification System", "GEN# +1.00131827"},
        {"Smithsonian Astrophysical Observation", "SAO 158907"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.08262752),
        dec: Angle.Degrees(-16.80067289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79289"},
        {"Hipparcos Number", "HIP 45210"},
        {"Renson", "Renson 22500"},
        {"Smithsonian Astrophysical Observation", "SAO 155001"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.19833551),
        dec: Angle.Degrees(-16.79956786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169315"},
        {"Hipparcos Number", "HIP 90241"},
        {"Geneva Identification System", "GEN# +1.00169315"},
        {"Smithsonian Astrophysical Observation", "SAO 161444"},
        {"Wilson Evans Batten Catalogue", "WEB 15436"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.18542178),
        dec: Angle.Degrees(-16.79716970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94605"},
        {"Hipparcos Number", "HIP 53386"},
        {"Smithsonian Astrophysical Observation", "SAO 156324"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.79246179),
        dec: Angle.Degrees(-16.79632031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2796"},
        {"Hipparcos Number", "HIP 2463"},
        {"Geneva Identification System", "GEN# +1.00002796"},
        {"Smithsonian Astrophysical Observation", "SAO 147321"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.82048101),
        dec: Angle.Degrees(-16.79453948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160428"},
        {"Hipparcos Number", "HIP 86495"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.13251375),
        dec: Angle.Degrees(-16.79341236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7407",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1247 AB"},
        {"Henry Draper", "HD 9793"},
        {"Hipparcos Number", "HIP 7407"},
        {"Smithsonian Astrophysical Observation", "SAO 147895"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.86459523),
        dec: Angle.Degrees(-16.79293162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18164"},
        {"Hipparcos Number", "HIP 13551"},
        {"Smithsonian Astrophysical Observation", "SAO 148662"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.63543447),
        dec: Angle.Degrees(-16.79159147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158335"},
        {"Hipparcos Number", "HIP 85581"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.33144456),
        dec: Angle.Degrees(-16.79139245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59426",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8444"},
        {"Henry Draper", "HD 105913"},
        {"Hipparcos Number", "HIP 59426"},
        {"Smithsonian Astrophysical Observation", "SAO 157133"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.84583247),
        dec: Angle.Degrees(-16.79070419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40673"},
        {"Hipparcos Number", "HIP 28369"},
        {"Geneva Identification System", "GEN# +1.00040673"},
        {"Smithsonian Astrophysical Observation", "SAO 151002"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.90530003),
        dec: Angle.Degrees(-16.78626530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172904"},
        {"Hipparcos Number", "HIP 91839"},
        {"Smithsonian Astrophysical Observation", "SAO 161764"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.86062946),
        dec: Angle.Degrees(-16.78482377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182742"},
        {"Hipparcos Number", "HIP 95610"},
        {"Smithsonian Astrophysical Observation", "SAO 162622"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.69249642),
        dec: Angle.Degrees(-16.78347895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12550",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2053 AB"},
        {"Henry Draper", "HD 16828"},
        {"Hipparcos Number", "HIP 12550"},
        {"Renson", "Renson 4260"},
        {"Smithsonian Astrophysical Observation", "SAO 148548"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.36514432),
        dec: Angle.Degrees(-16.78341137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31810"},
        {"Hipparcos Number", "HIP 23090"},
        {"Smithsonian Astrophysical Observation", "SAO 150038"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.54347801),
        dec: Angle.Degrees(-16.78020186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100445",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13751 AB"},
        {"Henry Draper", "HD 193713"},
        {"Hipparcos Number", "HIP 100445"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.54913915),
        dec: Angle.Degrees(-16.77993176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21919"},
        {"Hipparcos Number", "HIP 16422"},
        {"Geneva Identification System", "GEN# +1.00021919"},
        {"Smithsonian Astrophysical Observation", "SAO 149013"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.85620274),
        dec: Angle.Degrees(-16.77903271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20028"},
        {"Hipparcos Number", "HIP 14938"},
        {"Smithsonian Astrophysical Observation", "SAO 148835"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.15134873),
        dec: Angle.Degrees(-16.77770216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202939"},
        {"Hipparcos Number", "HIP 105292"},
        {"Smithsonian Astrophysical Observation", "SAO 164307"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.90306740),
        dec: Angle.Degrees(-16.77707644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173822"},
        {"Hipparcos Number", "HIP 92246"},
        {"Geneva Identification System", "GEN# +1.00173822"},
        {"Smithsonian Astrophysical Observation", "SAO 161835"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.99656341),
        dec: Angle.Degrees(-16.77643155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24148"},
        {"Hipparcos Number", "HIP 17938"},
        {"Smithsonian Astrophysical Observation", "SAO 149197"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.54310338),
        dec: Angle.Degrees(-16.77526548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53594",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53594"},
        {"Geneva Identification System", "GEN# -0.01603156"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.46233838),
        dec: Angle.Degrees(-16.77386419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11217"},
        {"Hipparcos Number", "HIP 8518"},
        {"Smithsonian Astrophysical Observation", "SAO 148042"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.46898655),
        dec: Angle.Degrees(-16.77235032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151656"},
        {"Hipparcos Number", "HIP 82331"},
        {"Smithsonian Astrophysical Observation", "SAO 160113"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.34327975),
        dec: Angle.Degrees(-16.77209845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26927",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26927"},
        {"Geneva Identification System", "GEN# -0.01601217"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.72812222),
        dec: Angle.Degrees(-16.77123155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214772"},
        {"Hipparcos Number", "HIP 111953"},
        {"Smithsonian Astrophysical Observation", "SAO 165229"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.16264741),
        dec: Angle.Degrees(-16.77091961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9327"},
        {"Hipparcos Number", "HIP 7105"},
        {"Smithsonian Astrophysical Observation", "SAO 147859"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.88952209),
        dec: Angle.Degrees(-16.77089803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101181"},
        {"Hipparcos Number", "HIP 56791"},
        {"Smithsonian Astrophysical Observation", "SAO 156800"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.64513064),
        dec: Angle.Degrees(-16.77054726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2007"},
        {"Hipparcos Number", "HIP 1913"},
        {"Geneva Identification System", "GEN# +1.00002007"},
        {"Smithsonian Astrophysical Observation", "SAO 147252"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.05423976),
        dec: Angle.Degrees(-16.76998699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124277"},
        {"Hipparcos Number", "HIP 69423"},
        {"Smithsonian Astrophysical Observation", "SAO 158425"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.21976858),
        dec: Angle.Degrees(-16.76980649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154189"},
        {"Hipparcos Number", "HIP 83553"},
        {"Smithsonian Astrophysical Observation", "SAO 160260"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.13813414),
        dec: Angle.Degrees(-16.76969349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142664"},
        {"Hipparcos Number", "HIP 78064"},
        {"Smithsonian Astrophysical Observation", "SAO 159585"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.08612386),
        dec: Angle.Degrees(-16.76538640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101704",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101704"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.22214773),
        dec: Angle.Degrees(-16.76482270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161227"},
        {"Hipparcos Number", "HIP 86875"},
        {"Renson", "Renson 45430"},
        {"Smithsonian Astrophysical Observation", "SAO 160798"},
        {"Wilson Evans Batten Catalogue", "WEB 14654"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.24686176),
        dec: Angle.Degrees(-16.76292590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207174"},
        {"Hipparcos Number", "HIP 107590"},
        {"Smithsonian Astrophysical Observation", "SAO 164651"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.86982814),
        dec: Angle.Degrees(-16.76237532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78670"},
        {"Hipparcos Number", "HIP 44927"},
        {"Geneva Identification System", "GEN# +1.00078670"},
        {"Smithsonian Astrophysical Observation", "SAO 154952"},
        {"Wilson Evans Batten Catalogue", "WEB 8582"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.27457884),
        dec: Angle.Degrees(-16.75866356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1101"},
        {"Hipparcos Number", "HIP 1231"},
        {"Fundamental Katalog 5th Edition", "FK5 4026"},
        {"Geneva Identification System", "GEN# +1.00001101"},
        {"Smithsonian Astrophysical Observation", "SAO 147179"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.81823774),
        dec: Angle.Degrees(-16.75619511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139784"},
        {"Hipparcos Number", "HIP 76787"},
        {"Smithsonian Astrophysical Observation", "SAO 159429"},
        {"Wilson Evans Batten Catalogue", "WEB 13030"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.16876127),
        dec: Angle.Degrees(-16.75562979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109721"},
        {"Hipparcos Number", "HIP 61567"},
        {"Smithsonian Astrophysical Observation", "SAO 157399"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.23050903),
        dec: Angle.Degrees(-16.75562661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116191"},
        {"Geneva Identification System", "GEN# -0.01706768J"},
    },
    visualMagnitude: 10.39,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.19358433),
        dec: Angle.Degrees(-16.75293185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 545.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 326.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86300"},
        {"Hipparcos Number", "HIP 48801"},
        {"Smithsonian Astrophysical Observation", "SAO 155616"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.30401369),
        dec: Angle.Degrees(-16.75107979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192330"},
        {"Hipparcos Number", "HIP 99800"},
        {"Smithsonian Astrophysical Observation", "SAO 163377"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.72284395),
        dec: Angle.Degrees(-16.75072951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218444"},
        {"Hipparcos Number", "HIP 114251"},
        {"Smithsonian Astrophysical Observation", "SAO 165508"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.07877332),
        dec: Angle.Degrees(-16.75030518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208010"},
        {"Hipparcos Number", "HIP 108064"},
        {"Smithsonian Astrophysical Observation", "SAO 164718"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.42136999),
        dec: Angle.Degrees(-16.75020697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56369"},
        {"Hipparcos Number", "HIP 35169"},
        {"Smithsonian Astrophysical Observation", "SAO 152639"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.03196580),
        dec: Angle.Degrees(-16.74986793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108066",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108066"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.42468104),
        dec: Angle.Degrees(-16.74885049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76947"},
        {"Hipparcos Number", "HIP 44083"},
        {"Smithsonian Astrophysical Observation", "SAO 154806"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.69312056),
        dec: Angle.Degrees(-16.74856669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70693"},
        {"Hipparcos Number", "HIP 41072"},
        {"Smithsonian Astrophysical Observation", "SAO 154179"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.70161763),
        dec: Angle.Degrees(-16.74681601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221152"},
        {"Hipparcos Number", "HIP 115960"},
        {"Smithsonian Astrophysical Observation", "SAO 165719"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.40551042),
        dec: Angle.Degrees(-16.74579452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129907"},
        {"Hipparcos Number", "HIP 72161"},
        {"Geneva Identification System", "GEN# +1.00129907"},
        {"Smithsonian Astrophysical Observation", "SAO 158778"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.39930553),
        dec: Angle.Degrees(-16.74374799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110778",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15934"},
        {"Hipparcos Number", "HIP 110778"},
    },
    visualMagnitude: 5.55,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.64228154),
        dec: Angle.Degrees(-16.74214759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 209.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31414"},
        {"Hipparcos Number", "HIP 22860"},
        {"Geneva Identification System", "GEN# +1.00031414"},
        {"Smithsonian Astrophysical Observation", "SAO 149985"},
        {"Wilson Evans Batten Catalogue", "WEB 4429"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.77841969),
        dec: Angle.Degrees(-16.74064825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11377"},
        {"Hipparcos Number", "HIP 8647"},
        {"Smithsonian Astrophysical Observation", "SAO 148062"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.86865129),
        dec: Angle.Degrees(-16.74027940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198029"},
        {"Hipparcos Number", "HIP 102659"},
        {"Geneva Identification System", "GEN# +1.00198029"},
        {"Smithsonian Astrophysical Observation", "SAO 163888"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.05488994),
        dec: Angle.Degrees(-16.73875161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155"},
        {"Hipparcos Number", "HIP 533"},
        {"Smithsonian Astrophysical Observation", "SAO 147085"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.61287384),
        dec: Angle.Degrees(-16.73761149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15190"},
        {"Hipparcos Number", "HIP 11374"},
        {"Smithsonian Astrophysical Observation", "SAO 148389"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.62432764),
        dec: Angle.Degrees(-16.73681676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93277"},
        {"Hipparcos Number", "HIP 52649"},
        {"Geneva Identification System", "GEN# +1.00093277"},
        {"Smithsonian Astrophysical Observation", "SAO 156206"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.49153948),
        dec: Angle.Degrees(-16.73617387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -296.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27261"},
        {"Hipparcos Number", "HIP 20032"},
        {"Smithsonian Astrophysical Observation", "SAO 149519"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.44456322),
        dec: Angle.Degrees(-16.73297383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8801",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1505 AB"},
        {"Henry Draper", "HD 11561"},
        {"Hipparcos Number", "HIP 8801"},
    },
    visualMagnitude: 8.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.28355250),
        dec: Angle.Degrees(-16.73268630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102600",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102600"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.89288691),
        dec: Angle.Degrees(-16.73254608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139249"},
        {"Hipparcos Number", "HIP 76522"},
        {"Smithsonian Astrophysical Observation", "SAO 159393"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.41636541),
        dec: Angle.Degrees(-16.73129642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30300",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4995 A"},
        {"Henry Draper", "HD 44682"},
        {"Hipparcos Number", "HIP 30300"},
        {"Geneva Identification System", "GEN# +1.00044682"},
        {"Smithsonian Astrophysical Observation", "SAO 151425"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.59869430),
        dec: Angle.Degrees(-16.73051767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142198"},
        {"Hipparcos Number", "HIP 77853"},
        {"Geneva Identification System", "GEN# +1.00142198"},
        {"Smithsonian Astrophysical Observation", "SAO 159563"},
        {"Wilson Evans Batten Catalogue", "WEB 13167"},
    },
    visualMagnitude: 4.13,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.45615438),
        dec: Angle.Degrees(-16.72962230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 135.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29504"},
        {"Hipparcos Number", "HIP 21590"},
        {"Smithsonian Astrophysical Observation", "SAO 149782"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.54041731),
        dec: Angle.Degrees(-16.72724980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201146"},
        {"Hipparcos Number", "HIP 104341"},
        {"Smithsonian Astrophysical Observation", "SAO 164161"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.05552571),
        dec: Angle.Degrees(-16.72665541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112419"},
        {"Hipparcos Number", "HIP 63178"},
        {"Smithsonian Astrophysical Observation", "SAO 157611"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.16119866),
        dec: Angle.Degrees(-16.72653095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57939"},
        {"Hipparcos Number", "HIP 35778"},
        {"Smithsonian Astrophysical Observation", "SAO 152790"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.70345824),
        dec: Angle.Degrees(-16.72627862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37971"},
        {"Hipparcos Number", "HIP 26821"},
        {"Geneva Identification System", "GEN# +1.00037971"},
        {"Smithsonian Astrophysical Observation", "SAO 150703"},
        {"Wilson Evans Batten Catalogue", "WEB 5287"},
    },
    visualMagnitude: 6.22,
    bvColour: -0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.42297149),
        dec: Angle.Degrees(-16.72584331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18683"},
        {"Hipparcos Number", "HIP 13952"},
        {"Geneva Identification System", "GEN# +1.00018683"},
        {"Smithsonian Astrophysical Observation", "SAO 148705"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.92542519),
        dec: Angle.Degrees(-16.72568971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40098"},
        {"Hipparcos Number", "HIP 28082"},
        {"Smithsonian Astrophysical Observation", "SAO 150955"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.04967731),
        dec: Angle.Degrees(-16.72486368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85240",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85240"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.27296114),
        dec: Angle.Degrees(-16.72454962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174089"},
        {"Hipparcos Number", "HIP 92370"},
        {"Geneva Identification System", "GEN# +1.00174089"},
        {"Smithsonian Astrophysical Observation", "SAO 161870"},
        {"Wilson Evans Batten Catalogue", "WEB 15950"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.36912092),
        dec: Angle.Degrees(-16.72301852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77137",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9767 AB"},
        {"Henry Draper", "HD 140576"},
        {"Hipparcos Number", "HIP 77137"},
        {"Smithsonian Astrophysical Observation", "SAO 159478"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.24287369),
        dec: Angle.Degrees(-16.71740376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50624",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7734 C"},
        {"Henry Draper", "HD 89657"},
        {"Hipparcos Number", "HIP 50624"},
        {"Smithsonian Astrophysical Observation", "SAO 155910"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.11231156),
        dec: Angle.Degrees(-16.71720489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56429"},
        {"Hipparcos Number", "HIP 35187"},
        {"Renson", "Renson 15390"},
        {"Smithsonian Astrophysical Observation", "SAO 152646"},
        {"Wilson Evans Batten Catalogue", "WEB 7029"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.08003850),
        dec: Angle.Degrees(-16.71666606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137744"},
        {"Hipparcos Number", "HIP 75730"},
        {"Fundamental Katalog 5th Edition", "FK5 1407"},
        {"Geneva Identification System", "GEN# +1.00137744"},
        {"Smithsonian Astrophysical Observation", "SAO 159280"},
        {"Wilson Evans Batten Catalogue", "WEB 12895"},
    },
    visualMagnitude: 5.64,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.06415852),
        dec: Angle.Degrees(-16.71640310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72011"},
        {"Hipparcos Number", "HIP 41694"},
        {"Smithsonian Astrophysical Observation", "SAO 154320"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.49691801),
        dec: Angle.Degrees(-16.71592383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14375"},
        {"Hipparcos Number", "HIP 10803"},
        {"Smithsonian Astrophysical Observation", "SAO 148326"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.75841597),
        dec: Angle.Degrees(-16.71571351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223809"},
        {"Hipparcos Number", "HIP 117755"},
        {"Smithsonian Astrophysical Observation", "SAO 165938"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.20986478),
        dec: Angle.Degrees(-16.71527193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32349",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Dog Star"},
        {"Common Name 2", "Sirius"},
        {"Common Name 3", "Sirius A"},
        {"Aitken", "ADS 5423 A"},
        {"Henry Draper", "HD 48915"},
        {"Henry Draper 2", "HD 48915A"},
        {"Hipparcos Number", "HIP 32349"},
        {"Celescope Catalog", "CEL 1368"},
        {"Cincinnati Publication", "Ci 20 396"},
        {"Fundamental Katalog 5th Edition", "FK5 257"},
        {"Geneva Identification System", "GEN# +1.00048915A"},
        {"Renson", "Renson 13090"},
        {"Smithsonian Astrophysical Observation", "SAO 151881"},
        {"Wilson Evans Batten Catalogue", "WEB 6525"},
    },
    visualMagnitude: -1.44,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.28854105),
        dec: Angle.Degrees(-16.71314306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -546.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1223.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85270",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85270"},
    },
    visualMagnitude: 11.30,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.35303822),
        dec: Angle.Degrees(-16.71240925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38380"},
        {"Hipparcos Number", "HIP 27087"},
        {"Geneva Identification System", "GEN# +1.00038380"},
        {"Smithsonian Astrophysical Observation", "SAO 150757"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.15246406),
        dec: Angle.Degrees(-16.71171842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204606"},
        {"Hipparcos Number", "HIP 106154"},
        {"Smithsonian Astrophysical Observation", "SAO 164436"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.53014458),
        dec: Angle.Degrees(-16.70981970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76579"},
        {"Hipparcos Number", "HIP 43899"},
        {"Geneva Identification System", "GEN# +1.00076579"},
        {"Smithsonian Astrophysical Observation", "SAO 154773"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.14221654),
        dec: Angle.Degrees(-16.70868242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54307"},
        {"Hipparcos Number", "HIP 34378"},
        {"Smithsonian Astrophysical Observation", "SAO 152422"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.91749978),
        dec: Angle.Degrees(-16.70677879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211738"},
        {"Hipparcos Number", "HIP 110219"},
        {"Geneva Identification System", "GEN# +1.00211738"},
        {"Smithsonian Astrophysical Observation", "SAO 164998"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.89327202),
        dec: Angle.Degrees(-16.70415695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166418"},
        {"Hipparcos Number", "HIP 89111"},
        {"Geneva Identification System", "GEN# +1.00166418J"},
        {"Smithsonian Astrophysical Observation", "SAO 161155"},
        {"Wilson Evans Batten Catalogue", "WEB 15130"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.80512303),
        dec: Angle.Degrees(-16.70390650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115905"},
        {"Hipparcos Number", "HIP 65086"},
        {"Smithsonian Astrophysical Observation", "SAO 157870"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.10950796),
        dec: Angle.Degrees(-16.70364261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4021"},
        {"Hipparcos Number", "HIP 3342"},
        {"Smithsonian Astrophysical Observation", "SAO 147410"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.65022626),
        dec: Angle.Degrees(-16.70327800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37360"},
        {"Hipparcos Number", "HIP 26416"},
        {"Smithsonian Astrophysical Observation", "SAO 150624"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.33229443),
        dec: Angle.Degrees(-16.70008524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33961",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5736 A"},
        {"Henry Draper", "HD 53013"},
        {"Hipparcos Number", "HIP 33961"},
        {"Smithsonian Astrophysical Observation", "SAO 152285"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.70567812),
        dec: Angle.Degrees(-16.69936670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223271"},
        {"Hipparcos Number", "HIP 117391"},
        {"Geneva Identification System", "GEN# +1.00223271"},
        {"Smithsonian Astrophysical Observation", "SAO 165890"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.03926049),
        dec: Angle.Degrees(-16.69902685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18705"},
        {"Hipparcos Number", "HIP 13972"},
        {"Smithsonian Astrophysical Observation", "SAO 148707"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.98997133),
        dec: Angle.Degrees(-16.69869442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46172"},
        {"Hipparcos Number", "HIP 31064"},
        {"Smithsonian Astrophysical Observation", "SAO 151597"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.78856079),
        dec: Angle.Degrees(-16.69824650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102515",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14264 AB"},
        {"Henry Draper", "HD 197802"},
        {"Hipparcos Number", "HIP 102515"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.62982380),
        dec: Angle.Degrees(-16.69792012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224763"},
        {"Hipparcos Number", "HIP 39"},
        {"Geneva Identification System", "GEN# +1.00224763"},
        {"Smithsonian Astrophysical Observation", "SAO 165995"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.11186148),
        dec: Angle.Degrees(-16.69693020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106819"},
        {"Hipparcos Number", "HIP 59895"},
        {"Geneva Identification System", "GEN# +1.00106819"},
        {"Smithsonian Astrophysical Observation", "SAO 157184"},
        {"Wilson Evans Batten Catalogue", "WEB 10642"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.26401068),
        dec: Angle.Degrees(-16.69374078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53757"},
        {"Hipparcos Number", "HIP 34211"},
        {"Smithsonian Astrophysical Observation", "SAO 152359"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.39840886),
        dec: Angle.Degrees(-16.69347905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220143"},
        {"Hipparcos Number", "HIP 115323"},
        {"Geneva Identification System", "GEN# +1.00220143"},
        {"Smithsonian Astrophysical Observation", "SAO 165646"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.36919697),
        dec: Angle.Degrees(-16.68855751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35665",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35665"},
        {"Geneva Identification System", "GEN# -0.01601918"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.38690976),
        dec: Angle.Degrees(-16.68722209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101575"},
        {"Hipparcos Number", "HIP 57005"},
        {"Fundamental Katalog 5th Edition", "FK5 5034"},
        {"Smithsonian Astrophysical Observation", "SAO 156833"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.29511131),
        dec: Angle.Degrees(-16.68308151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156760"},
        {"Hipparcos Number", "HIP 84810"},
        {"Geneva Identification System", "GEN# +1.00156760"},
        {"Smithsonian Astrophysical Observation", "SAO 160467"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.01064109),
        dec: Angle.Degrees(-16.68214570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84295",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84295"},
    },
    visualMagnitude: 11.75,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.49801355),
        dec: Angle.Degrees(-16.68207590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107843"},
        {"Hipparcos Number", "HIP 60452"},
        {"Geneva Identification System", "GEN# +1.00107843"},
        {"Smithsonian Astrophysical Observation", "SAO 157256"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.90069319),
        dec: Angle.Degrees(-16.68076730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44441"},
        {"Hipparcos Number", "HIP 30193"},
        {"Smithsonian Astrophysical Observation", "SAO 151395"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.28670092),
        dec: Angle.Degrees(-16.67722188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145553"},
        {"Hipparcos Number", "HIP 79395"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.04986034),
        dec: Angle.Degrees(-16.67707486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116818"},
        {"Hipparcos Number", "HIP 65552"},
        {"Smithsonian Astrophysical Observation", "SAO 157934"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.58000365),
        dec: Angle.Degrees(-16.67600098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36561"},
        {"Hipparcos Number", "HIP 25922"},
        {"Geneva Identification System", "GEN# +1.00036561"},
        {"Smithsonian Astrophysical Observation", "SAO 150535"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.98167297),
        dec: Angle.Degrees(-16.67587603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -233.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91032"},
        {"Hipparcos Number", "HIP 51430"},
        {"Smithsonian Astrophysical Observation", "SAO 156020"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.55154862),
        dec: Angle.Degrees(-16.67444711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104244"},
        {"Hipparcos Number", "HIP 58539"},
        {"Smithsonian Astrophysical Observation", "SAO 157035"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.06594539),
        dec: Angle.Degrees(-16.67382001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3506"},
        {"Hipparcos Number", "HIP 2976"},
        {"Geneva Identification System", "GEN# +1.00003506"},
        {"Smithsonian Astrophysical Observation", "SAO 147374"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.46861071),
        dec: Angle.Degrees(-16.67187984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1016"},
        {"Hipparcos Number", "HIP 1163"},
        {"Smithsonian Astrophysical Observation", "SAO 147168"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.62650335),
        dec: Angle.Degrees(-16.67175127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192152"},
        {"Hipparcos Number", "HIP 99708"},
        {"Geneva Identification System", "GEN# +1.00192152"},
        {"Smithsonian Astrophysical Observation", "SAO 163364"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.49581225),
        dec: Angle.Degrees(-16.66897742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81148"},
        {"Hipparcos Number", "HIP 46054"},
        {"Smithsonian Astrophysical Observation", "SAO 155143"},
    },
    visualMagnitude: 7.33,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.87618134),
        dec: Angle.Degrees(-16.66625334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65344",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65344"},
        {"Wilson Evans Batten Catalogue", "WEB 11533"},
    },
    visualMagnitude: 11.60,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.88885510),
        dec: Angle.Degrees(-16.66597348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106985",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Nashira"},
        {"Henry Draper", "HD 206088"},
        {"Hipparcos Number", "HIP 106985"},
        {"Fundamental Katalog 5th Edition", "FK5 812"},
        {"Geneva Identification System", "GEN# +1.00206088"},
        {"Renson", "Renson 57390"},
        {"Smithsonian Astrophysical Observation", "SAO 164560"},
        {"Wilson Evans Batten Catalogue", "WEB 19332"},
    },
    visualMagnitude: 3.69,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.02225935),
        dec: Angle.Degrees(-16.66225343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 187.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81767"},
        {"Hipparcos Number", "HIP 46360"},
        {"Geneva Identification System", "GEN# +1.00081767"},
        {"Smithsonian Astrophysical Observation", "SAO 155206"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.78912243),
        dec: Angle.Degrees(-16.66185735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -182.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109181"},
        {"Hipparcos Number", "HIP 61236"},
        {"Smithsonian Astrophysical Observation", "SAO 157355"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.22533792),
        dec: Angle.Degrees(-16.66003959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163513"},
        {"Hipparcos Number", "HIP 87894"},
        {"Smithsonian Astrophysical Observation", "SAO 160931"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.30628742),
        dec: Angle.Degrees(-16.65818766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216346"},
        {"Hipparcos Number", "HIP 112941"},
        {"Smithsonian Astrophysical Observation", "SAO 165348"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.11358849),
        dec: Angle.Degrees(-16.65666172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205443"},
        {"Hipparcos Number", "HIP 106621"},
        {"Smithsonian Astrophysical Observation", "SAO 164504"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.93720196),
        dec: Angle.Degrees(-16.65560562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4375"},
        {"Hipparcos Number", "HIP 3593"},
        {"Smithsonian Astrophysical Observation", "SAO 147437"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.49667642),
        dec: Angle.Degrees(-16.65260653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55636"},
        {"Hipparcos Number", "HIP 34882"},
        {"Celescope Catalog", "CEL 1679"},
        {"Geneva Identification System", "GEN# +1.00055636"},
        {"Smithsonian Astrophysical Observation", "SAO 152572"},
    },
    visualMagnitude: 8.72,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.27154282),
        dec: Angle.Degrees(-16.65043470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13240"},
        {"Hipparcos Number", "HIP 10026"},
        {"Geneva Identification System", "GEN# +1.00013240"},
        {"Smithsonian Astrophysical Observation", "SAO 148239"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.26360847),
        dec: Angle.Degrees(-16.64847447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38699"},
        {"Hipparcos Number", "HIP 27291"},
        {"Smithsonian Astrophysical Observation", "SAO 150803"},
        {"Wilson Evans Batten Catalogue", "WEB 5365"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.74456170),
        dec: Angle.Degrees(-16.64624780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153417"},
        {"Hipparcos Number", "HIP 83192"},
        {"Smithsonian Astrophysical Observation", "SAO 160219"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.03363462),
        dec: Angle.Degrees(-16.64506350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97909",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13067 AB"},
        {"Henry Draper", "HD 188046"},
        {"Hipparcos Number", "HIP 97909"},
        {"Smithsonian Astrophysical Observation", "SAO 163087"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.45253081),
        dec: Angle.Degrees(-16.64475240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178623"},
        {"Hipparcos Number", "HIP 94152"},
        {"Smithsonian Astrophysical Observation", "SAO 162262"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.47332282),
        dec: Angle.Degrees(-16.64280749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90406"},
        {"Hipparcos Number", "HIP 51060"},
        {"Geneva Identification System", "GEN# +9.00050016"},
        {"Smithsonian Astrophysical Observation", "SAO 155978"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.49358273),
        dec: Angle.Degrees(-16.63943806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24147"},
        {"Hipparcos Number", "HIP 17942"},
        {"Geneva Identification System", "GEN# +1.00024147"},
        {"Renson", "Renson 6185"},
        {"Smithsonian Astrophysical Observation", "SAO 149198"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.55162271),
        dec: Angle.Degrees(-16.63665756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108477"},
        {"Hipparcos Number", "HIP 60809"},
        {"Geneva Identification System", "GEN# +1.00108477"},
        {"Smithsonian Astrophysical Observation", "SAO 157299"},
        {"Wilson Evans Batten Catalogue", "WEB 10819"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.95605406),
        dec: Angle.Degrees(-16.63185314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100345"},
        {"Hipparcos Number", "HIP 56314"},
        {"Smithsonian Astrophysical Observation", "SAO 156745"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.17877609),
        dec: Angle.Degrees(-16.63008683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80273"},
        {"Hipparcos Number", "HIP 45662"},
        {"Smithsonian Astrophysical Observation", "SAO 155079"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.60968636),
        dec: Angle.Degrees(-16.63001925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159661"},
        {"Hipparcos Number", "HIP 86171"},
        {"Smithsonian Astrophysical Observation", "SAO 160683"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.13869347),
        dec: Angle.Degrees(-16.62851261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108876",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108876"},
        {"Geneva Identification System", "GEN# -0.01706424"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.83207242),
        dec: Angle.Degrees(-16.62646281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212760"},
        {"Hipparcos Number", "HIP 110802"},
        {"Smithsonian Astrophysical Observation", "SAO 165082"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.73224708),
        dec: Angle.Degrees(-16.62596417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159320"},
        {"Hipparcos Number", "HIP 86023"},
        {"Smithsonian Astrophysical Observation", "SAO 160650"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.69572549),
        dec: Angle.Degrees(-16.62383304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16986"},
        {"Hipparcos Number", "HIP 12689"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.75758619),
        dec: Angle.Degrees(-16.62365209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159662"},
        {"Hipparcos Number", "HIP 86181"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.15354955),
        dec: Angle.Degrees(-16.62301096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7689"},
        {"Hipparcos Number", "HIP 5946"},
        {"Smithsonian Astrophysical Observation", "SAO 147704"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.12567606),
        dec: Angle.Degrees(-16.62259421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210792"},
        {"Hipparcos Number", "HIP 109685"},
        {"Geneva Identification System", "GEN# +1.00210792"},
        {"Smithsonian Astrophysical Observation", "SAO 164930"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.27816630),
        dec: Angle.Degrees(-16.62181147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18420"},
        {"Hipparcos Number", "HIP 13763"},
        {"Smithsonian Astrophysical Observation", "SAO 148681"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.28985483),
        dec: Angle.Degrees(-16.62146527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13184",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13184"},
    },
    visualMagnitude: 10.84,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.41883392),
        dec: Angle.Degrees(-16.62067342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 256.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101370"},
        {"Hipparcos Number", "HIP 56899"},
        {"Geneva Identification System", "GEN# +1.00101370"},
        {"Smithsonian Astrophysical Observation", "SAO 156819"},
        {"Wilson Evans Batten Catalogue", "WEB 10243"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.95977093),
        dec: Angle.Degrees(-16.62020855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17965"},
        {"Hipparcos Number", "HIP 13419"},
        {"Geneva Identification System", "GEN# +1.00017965"},
        {"Smithsonian Astrophysical Observation", "SAO 148651"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.19796788),
        dec: Angle.Degrees(-16.61873608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43544"},
        {"Hipparcos Number", "HIP 29771"},
        {"Geneva Identification System", "GEN# +1.00043544"},
        {"Smithsonian Astrophysical Observation", "SAO 151294"},
        {"Wilson Evans Batten Catalogue", "WEB 5876"},
    },
    visualMagnitude: 5.97,
    bvColour: -0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.03206851),
        dec: Angle.Degrees(-16.61800865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201335"},
        {"Hipparcos Number", "HIP 104444"},
        {"Smithsonian Astrophysical Observation", "SAO 164177"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.35446993),
        dec: Angle.Degrees(-16.61577797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41449"},
        {"Hipparcos Number", "HIP 28779"},
        {"Smithsonian Astrophysical Observation", "SAO 151084"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.14836129),
        dec: Angle.Degrees(-16.61555260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188656"},
        {"Hipparcos Number", "HIP 98150"},
        {"Renson", "Renson 52134"},
        {"Smithsonian Astrophysical Observation", "SAO 163127"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.20181008),
        dec: Angle.Degrees(-16.61531297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80894",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10086 A"},
        {"Henry Draper", "HD 148786"},
        {"Hipparcos Number", "HIP 80894"},
        {"Geneva Identification System", "GEN# +1.00148786"},
        {"Smithsonian Astrophysical Observation", "SAO 159963"},
        {"Wilson Evans Batten Catalogue", "WEB 13681"},
    },
    visualMagnitude: 4.29,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.78497886),
        dec: Angle.Degrees(-16.61264015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101271"},
        {"Hipparcos Number", "HIP 56835"},
        {"Smithsonian Astrophysical Observation", "SAO 156810"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.77343499),
        dec: Angle.Degrees(-16.61230617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210135"},
        {"Hipparcos Number", "HIP 109297"},
        {"Smithsonian Astrophysical Observation", "SAO 164882"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.13198648),
        dec: Angle.Degrees(-16.61182741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184077"},
        {"Hipparcos Number", "HIP 96176"},
        {"Smithsonian Astrophysical Observation", "SAO 162748"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.33476236),
        dec: Angle.Degrees(-16.61008658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101357",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13961 AB"},
        {"Henry Draper", "HD 195536"},
        {"Hipparcos Number", "HIP 101357"},
        {"Geneva Identification System", "GEN# +1.00195536J"},
        {"Smithsonian Astrophysical Observation", "SAO 163666"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.13155660),
        dec: Angle.Degrees(-16.60956380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138137"},
        {"Hipparcos Number", "HIP 75944"},
        {"Geneva Identification System", "GEN# +1.00138137"},
        {"Smithsonian Astrophysical Observation", "SAO 159307"},
        {"Wilson Evans Batten Catalogue", "WEB 12914"},
    },
    visualMagnitude: 5.82,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.66828146),
        dec: Angle.Degrees(-16.60945806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19272"},
        {"Hipparcos Number", "HIP 14380"},
        {"Geneva Identification System", "GEN# +1.00019272"},
        {"Smithsonian Astrophysical Observation", "SAO 148759"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.38089914),
        dec: Angle.Degrees(-16.60817866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102698"},
        {"Hipparcos Number", "HIP 57660"},
        {"Geneva Identification System", "GEN# +1.00102698"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.37671071),
        dec: Angle.Degrees(-16.60561545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98932"},
        {"Hipparcos Number", "HIP 55577"},
        {"Fundamental Katalog 5th Edition", "FK5 5001"},
        {"Geneva Identification System", "GEN# +1.00098932"},
        {"Smithsonian Astrophysical Observation", "SAO 156641"},
        {"Wilson Evans Batten Catalogue", "WEB 9989"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.77185122),
        dec: Angle.Degrees(-16.60483994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6483"},
        {"Hipparcos Number", "HIP 5128"},
        {"Smithsonian Astrophysical Observation", "SAO 147603"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.41611693),
        dec: Angle.Degrees(-16.60169638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34348",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34348"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.80182914),
        dec: Angle.Degrees(-16.60142458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176783"},
        {"Hipparcos Number", "HIP 93501"},
        {"Smithsonian Astrophysical Observation", "SAO 162119"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.63830517),
        dec: Angle.Degrees(-16.59806625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102628"},
        {"Hipparcos Number", "HIP 57621"},
        {"Smithsonian Astrophysical Observation", "SAO 156905"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.21866981),
        dec: Angle.Degrees(-16.59772566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99814"},
        {"Hipparcos Number", "HIP 56019"},
        {"Smithsonian Astrophysical Observation", "SAO 156703"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.21764716),
        dec: Angle.Degrees(-16.59479682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116893",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116893"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.40563667),
        dec: Angle.Degrees(-16.59335961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 145.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103253"},
        {"Hipparcos Number", "HIP 57966"},
        {"Geneva Identification System", "GEN# +1.00103253"},
        {"Smithsonian Astrophysical Observation", "SAO 156964"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.34575213),
        dec: Angle.Degrees(-16.59273210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14101",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14101"},
    },
    visualMagnitude: 10.40,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.46502827),
        dec: Angle.Degrees(-16.59263281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -361.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -304.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111978"},
        {"Hipparcos Number", "HIP 62878"},
        {"Smithsonian Astrophysical Observation", "SAO 157570"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.30071810),
        dec: Angle.Degrees(-16.59218006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133173"},
        {"Hipparcos Number", "HIP 73670"},
        {"Smithsonian Astrophysical Observation", "SAO 158995"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.89024508),
        dec: Angle.Degrees(-16.59213599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87035",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87035"},
    },
    visualMagnitude: 10.65,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.74422264),
        dec: Angle.Degrees(-16.59093445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42680"},
        {"Hipparcos Number", "HIP 29362"},
        {"Smithsonian Astrophysical Observation", "SAO 151198"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.83548177),
        dec: Angle.Degrees(-16.58999126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181737"},
        {"Hipparcos Number", "HIP 95216"},
        {"Smithsonian Astrophysical Observation", "SAO 162526"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.57016296),
        dec: Angle.Degrees(-16.58977057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128830"},
        {"Hipparcos Number", "HIP 71680"},
        {"Smithsonian Astrophysical Observation", "SAO 158705"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.91549145),
        dec: Angle.Degrees(-16.58970503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25700"},
        {"Hipparcos Number", "HIP 18990"},
        {"Fundamental Katalog 5th Edition", "FK5 2293"},
        {"Geneva Identification System", "GEN# +1.00025700"},
        {"Smithsonian Astrophysical Observation", "SAO 149345"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.03604310),
        dec: Angle.Degrees(-16.58857827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94269"},
        {"Hipparcos Number", "HIP 53178"},
        {"Smithsonian Astrophysical Observation", "SAO 156290"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.16906568),
        dec: Angle.Degrees(-16.58840602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215419"},
        {"Hipparcos Number", "HIP 112340"},
        {"Smithsonian Astrophysical Observation", "SAO 165270"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.32153430),
        dec: Angle.Degrees(-16.58788923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62838"},
        {"Hipparcos Number", "HIP 37832"},
        {"Smithsonian Astrophysical Observation", "SAO 153360"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.34146946),
        dec: Angle.Degrees(-16.58669866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104221"},
        {"Hipparcos Number", "HIP 58526"},
        {"Geneva Identification System", "GEN# +1.00104221"},
        {"Smithsonian Astrophysical Observation", "SAO 157033"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.03736283),
        dec: Angle.Degrees(-16.58554513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221815"},
        {"Hipparcos Number", "HIP 116420"},
        {"Fundamental Katalog 5th Edition", "FK5 6087"},
        {"Smithsonian Astrophysical Observation", "SAO 165785"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.86684112),
        dec: Angle.Degrees(-16.58345617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6278"},
        {"Hipparcos Number", "HIP 4954"},
        {"Smithsonian Astrophysical Observation", "SAO 147586"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.88811543),
        dec: Angle.Degrees(-16.57793968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166765"},
        {"Hipparcos Number", "HIP 89251"},
        {"Geneva Identification System", "GEN# +1.00166765"},
        {"Smithsonian Astrophysical Observation", "SAO 161187"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.20114106),
        dec: Angle.Degrees(-16.57565160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170604"},
        {"Hipparcos Number", "HIP 90749"},
        {"Geneva Identification System", "GEN# +1.00170604"},
        {"Smithsonian Astrophysical Observation", "SAO 161556"},
        {"Wilson Evans Batten Catalogue", "WEB 15545"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.74512738),
        dec: Angle.Degrees(-16.57346456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215465"},
        {"Hipparcos Number", "HIP 112367"},
        {"Smithsonian Astrophysical Observation", "SAO 165277"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.39229455),
        dec: Angle.Degrees(-16.57308988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22215"},
        {"Smithsonian Astrophysical Observation", "SAO 149876"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.66339657),
        dec: Angle.Degrees(-16.57281614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123476"},
        {"Hipparcos Number", "HIP 69073"},
        {"Geneva Identification System", "GEN# +1.00123476"},
        {"Smithsonian Astrophysical Observation", "SAO 158377"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.08877531),
        dec: Angle.Degrees(-16.57243406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12480"},
        {"Hipparcos Number", "HIP 9479"},
        {"Fundamental Katalog 5th Edition", "FK5 4182"},
        {"Smithsonian Astrophysical Observation", "SAO 148161"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.48582955),
        dec: Angle.Degrees(-16.56881738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3298"},
        {"Hipparcos Number", "HIP 2819"},
        {"Geneva Identification System", "GEN# +1.00003298"},
        {"Smithsonian Astrophysical Observation", "SAO 147354"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.96505482),
        dec: Angle.Degrees(-16.56869557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1836"},
        {"Hipparcos Number", "HIP 1791"},
        {"Smithsonian Astrophysical Observation", "SAO 147236"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.69280494),
        dec: Angle.Degrees(-16.56764164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189560"},
        {"Hipparcos Number", "HIP 98555"},
        {"Smithsonian Astrophysical Observation", "SAO 163184"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.30180627),
        dec: Angle.Degrees(-16.56760533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12497"},
        {"Hipparcos Number", "HIP 9496"},
        {"Smithsonian Astrophysical Observation", "SAO 148162"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.54522235),
        dec: Angle.Degrees(-16.56760268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142074"},
        {"Hipparcos Number", "HIP 77793"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.27998690),
        dec: Angle.Degrees(-16.56613122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101740",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101740"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.31646116),
        dec: Angle.Degrees(-16.56603003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21500"},
        {"Hipparcos Number", "HIP 16110"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.88441226),
        dec: Angle.Degrees(-16.56536269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136866"},
        {"Hipparcos Number", "HIP 75330"},
        {"Geneva Identification System", "GEN# +1.00136866"},
        {"Smithsonian Astrophysical Observation", "SAO 159218"},
        {"Wilson Evans Batten Catalogue", "WEB 12851"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.87873731),
        dec: Angle.Degrees(-16.56403913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13791"},
        {"Hipparcos Number", "HIP 10399"},
        {"Smithsonian Astrophysical Observation", "SAO 148281"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.48942517),
        dec: Angle.Degrees(-16.56097176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8407"},
        {"Hipparcos Number", "HIP 6458"},
        {"Geneva Identification System", "GEN# +1.00008407"},
        {"Smithsonian Astrophysical Observation", "SAO 147771"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.76065009),
        dec: Angle.Degrees(-16.56046867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170991"},
        {"Hipparcos Number", "HIP 90939"},
        {"Geneva Identification System", "GEN# +1.00170991"},
        {"Smithsonian Astrophysical Observation", "SAO 161590"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.25842541),
        dec: Angle.Degrees(-16.56018960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196617"},
        {"Hipparcos Number", "HIP 101906"},
        {"Geneva Identification System", "GEN# +1.00196617"},
        {"Smithsonian Astrophysical Observation", "SAO 163768"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.76760749),
        dec: Angle.Degrees(-16.55947378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61725"},
        {"Hipparcos Number", "HIP 37359"},
        {"Smithsonian Astrophysical Observation", "SAO 153219"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.02903142),
        dec: Angle.Degrees(-16.55883802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6765"},
        {"Hipparcos Number", "HIP 5329"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.04503019),
        dec: Angle.Degrees(-16.55845499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114944"},
        {"Hipparcos Number", "HIP 64573"},
        {"Smithsonian Astrophysical Observation", "SAO 157805"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.53914287),
        dec: Angle.Degrees(-16.55838608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85431"},
        {"Hipparcos Number", "HIP 48355"},
        {"Geneva Identification System", "GEN# +1.00085431"},
        {"Smithsonian Astrophysical Observation", "SAO 155538"},
        {"Wilson Evans Batten Catalogue", "WEB 9020"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.85347171),
        dec: Angle.Degrees(-16.55831148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153959"},
        {"Hipparcos Number", "HIP 83443"},
        {"Geneva Identification System", "GEN# +1.00153959"},
        {"Smithsonian Astrophysical Observation", "SAO 160243"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.81540223),
        dec: Angle.Degrees(-16.55493113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109062",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109062"},
    },
    visualMagnitude: 11.36,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.40762872),
        dec: Angle.Degrees(-16.55493024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -233.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -241.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20308"},
        {"Hipparcos Number", "HIP 15172"},
        {"Renson", "Renson 5055"},
        {"Smithsonian Astrophysical Observation", "SAO 148862"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.88188321),
        dec: Angle.Degrees(-16.55487164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195243"},
        {"Hipparcos Number", "HIP 101190"},
        {"Geneva Identification System", "GEN# +1.00195243"},
        {"Smithsonian Astrophysical Observation", "SAO 163639"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.66523316),
        dec: Angle.Degrees(-16.55073234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102546"},
        {"Hipparcos Number", "HIP 57576"},
        {"Smithsonian Astrophysical Observation", "SAO 156895"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.03885122),
        dec: Angle.Degrees(-16.54838743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9871"},
        {"Hipparcos Number", "HIP 7469"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.04560800),
        dec: Angle.Degrees(-16.54694090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151884"},
        {"Hipparcos Number", "HIP 82442"},
        {"Geneva Identification System", "GEN# +1.00151884"},
        {"Smithsonian Astrophysical Observation", "SAO 160127"},
        {"Wilson Evans Batten Catalogue", "WEB 13917"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.73117524),
        dec: Angle.Degrees(-16.54689250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84725"},
        {"Hipparcos Number", "HIP 47985"},
        {"Geneva Identification System", "GEN# +1.00084725"},
        {"Smithsonian Astrophysical Observation", "SAO 155472"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.70792938),
        dec: Angle.Degrees(-16.54656642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63481"},
        {"Hipparcos Number", "HIP 38112"},
        {"Smithsonian Astrophysical Observation", "SAO 153432"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.15403004),
        dec: Angle.Degrees(-16.54389818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210123"},
        {"Hipparcos Number", "HIP 109290"},
        {"Fundamental Katalog 5th Edition", "FK5 5955"},
        {"Geneva Identification System", "GEN# +1.00210123"},
        {"Smithsonian Astrophysical Observation", "SAO 164880"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.10895044),
        dec: Angle.Degrees(-16.54300653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21222",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21222"},
    },
    visualMagnitude: 10.88,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.24249481),
        dec: Angle.Degrees(-16.54257610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -214.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159084"},
        {"Hipparcos Number", "HIP 85914"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.35238762),
        dec: Angle.Degrees(-16.54225151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132569"},
        {"Hipparcos Number", "HIP 73428"},
        {"Geneva Identification System", "GEN# +1.00132569"},
        {"Smithsonian Astrophysical Observation", "SAO 158961"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.08324244),
        dec: Angle.Degrees(-16.54099046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145963"},
        {"Hipparcos Number", "HIP 79587"},
        {"Smithsonian Astrophysical Observation", "SAO 159800"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.56773376),
        dec: Angle.Degrees(-16.54074458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128498"},
        {"Hipparcos Number", "HIP 71515"},
        {"Smithsonian Astrophysical Observation", "SAO 158682"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.38800387),
        dec: Angle.Degrees(-16.54065148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25680"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.27184726),
        dec: Angle.Degrees(-16.53938565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 289.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16402"},
        {"Hipparcos Number", "HIP 12223"},
        {"Smithsonian Astrophysical Observation", "SAO 148507"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.34460630),
        dec: Angle.Degrees(-16.53892020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3298",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3298"},
    },
    visualMagnitude: 11.14,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.51276453),
        dec: Angle.Degrees(-16.53790800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 258.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58817"},
        {"Geneva Identification System", "GEN# +9.85794017"},
    },
    visualMagnitude: 10.76,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.95529925),
        dec: Angle.Degrees(-16.53614683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 393.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -444.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85519"},
        {"Hipparcos Number", "HIP 48396"},
        {"Geneva Identification System", "GEN# +1.00085519"},
        {"Smithsonian Astrophysical Observation", "SAO 155553"},
    },
    visualMagnitude: 6.08,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.99802681),
        dec: Angle.Degrees(-16.53461116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216984"},
        {"Hipparcos Number", "HIP 113363"},
        {"Smithsonian Astrophysical Observation", "SAO 165402"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.39298331),
        dec: Angle.Degrees(-16.53380862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112807"},
        {"Hipparcos Number", "HIP 63393"},
        {"Smithsonian Astrophysical Observation", "SAO 157637"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.85983680),
        dec: Angle.Degrees(-16.53358781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39849",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39849"},
        {"Wilson Evans Batten Catalogue", "WEB 7770"},
    },
    visualMagnitude: 11.54,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.11768873),
        dec: Angle.Degrees(-16.53322189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143333"},
        {"Hipparcos Number", "HIP 78400"},
        {"Cincinnati Publication", "Ci 20 957"},
        {"Fundamental Katalog 5th Edition", "FK5 1419"},
        {"Geneva Identification System", "GEN# +1.00143333"},
        {"Smithsonian Astrophysical Observation", "SAO 159625"},
        {"Wilson Evans Batten Catalogue", "WEB 13253"},
    },
    visualMagnitude: 5.47,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.08324525),
        dec: Angle.Degrees(-16.53238334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -636.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -397.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224910"},
        {"Hipparcos Number", "HIP 138"},
        {"Smithsonian Astrophysical Observation", "SAO 166002"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.43720393),
        dec: Angle.Degrees(-16.53172119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111047"},
        {"Hipparcos Number", "HIP 62354"},
        {"Geneva Identification System", "GEN# +1.00111047"},
        {"Smithsonian Astrophysical Observation", "SAO 157503"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.65190471),
        dec: Angle.Degrees(-16.53148819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65141"},
        {"Hipparcos Number", "HIP 38817"},
        {"Geneva Identification System", "GEN# +1.00065141"},
        {"Smithsonian Astrophysical Observation", "SAO 153616"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.16626466),
        dec: Angle.Degrees(-16.53138354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96364"},
        {"Hipparcos Number", "HIP 54290"},
        {"Smithsonian Astrophysical Observation", "SAO 156459"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.60836657),
        dec: Angle.Degrees(-16.53097307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225197"},
        {"Hipparcos Number", "HIP 343"},
        {"Geneva Identification System", "GEN# +1.00225197"},
        {"Smithsonian Astrophysical Observation", "SAO 147064"},
        {"Wilson Evans Batten Catalogue", "WEB 50"},
    },
    visualMagnitude: 5.78,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.08233885),
        dec: Angle.Degrees(-16.52888969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8795"},
        {"Hipparcos Number", "HIP 6716"},
        {"Geneva Identification System", "GEN# +1.00008795"},
        {"Smithsonian Astrophysical Observation", "SAO 147809"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.60858395),
        dec: Angle.Degrees(-16.52823706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206767"},
        {"Hipparcos Number", "HIP 107359"},
        {"Geneva Identification System", "GEN# +1.00206767"},
        {"Smithsonian Astrophysical Observation", "SAO 164620"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.17489768),
        dec: Angle.Degrees(-16.52694489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196078"},
        {"Hipparcos Number", "HIP 101608"},
        {"Geneva Identification System", "GEN# +1.00196078"},
        {"Smithsonian Astrophysical Observation", "SAO 163712"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.88419228),
        dec: Angle.Degrees(-16.52581187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81957"},
        {"Hipparcos Number", "HIP 46466"},
        {"Geneva Identification System", "GEN# +1.00081957"},
        {"Smithsonian Astrophysical Observation", "SAO 155217"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.14469938),
        dec: Angle.Degrees(-16.52365694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35887"},
        {"Hipparcos Number", "HIP 25497"},
        {"Geneva Identification System", "GEN# +1.00035887"},
        {"Smithsonian Astrophysical Observation", "SAO 150463"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.79176428),
        dec: Angle.Degrees(-16.52346423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73191"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.38535229),
        dec: Angle.Degrees(-16.52323669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -182.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86371"},
        {"Hipparcos Number", "HIP 48830"},
        {"Geneva Identification System", "GEN# +1.00086371"},
        {"Smithsonian Astrophysical Observation", "SAO 155622"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.41528746),
        dec: Angle.Degrees(-16.52206008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193765"},
        {"Hipparcos Number", "HIP 100477"},
        {"Smithsonian Astrophysical Observation", "SAO 163503"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.63834905),
        dec: Angle.Degrees(-16.52122499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198041"},
        {"Hipparcos Number", "HIP 102658"},
        {"Geneva Identification System", "GEN# +1.00198041"},
        {"Smithsonian Astrophysical Observation", "SAO 163889"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.05393962),
        dec: Angle.Degrees(-16.52118814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53668"},
        {"Hipparcos Number", "HIP 34176"},
        {"Celescope Catalog", "CEL 1562"},
        {"Geneva Identification System", "GEN# +1.00053668"},
        {"Smithsonian Astrophysical Observation", "SAO 152351"},
    },
    visualMagnitude: 8.70,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.31629560),
        dec: Angle.Degrees(-16.52054581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105048"},
        {"Hipparcos Number", "HIP 58993"},
        {"Smithsonian Astrophysical Observation", "SAO 157080"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.43239298),
        dec: Angle.Degrees(-16.52053972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41818"},
        {"Hipparcos Number", "HIP 28948"},
        {"Geneva Identification System", "GEN# +1.00041818"},
        {"Smithsonian Astrophysical Observation", "SAO 151122"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.65991990),
        dec: Angle.Degrees(-16.51829630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167633"},
        {"Hipparcos Number", "HIP 89584"},
        {"Geneva Identification System", "GEN# +1.00167633"},
        {"Smithsonian Astrophysical Observation", "SAO 161251"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.20689477),
        dec: Angle.Degrees(-16.51785864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183173"},
        {"Hipparcos Number", "HIP 95779"},
        {"Smithsonian Astrophysical Observation", "SAO 162657"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.21106698),
        dec: Angle.Degrees(-16.51743923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3794"},
        {"Hipparcos Number", "HIP 3175"},
        {"Fundamental Katalog 5th Edition", "FK5 4058"},
        {"Geneva Identification System", "GEN# +1.00003794"},
        {"Smithsonian Astrophysical Observation", "SAO 147395"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.11898738),
        dec: Angle.Degrees(-16.51659767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22158",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3435 AB"},
        {"Henry Draper", "HD 30333"},
        {"Hipparcos Number", "HIP 22158"},
        {"Smithsonian Astrophysical Observation", "SAO 149870"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.51213829),
        dec: Angle.Degrees(-16.51578607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144711"},
        {"Hipparcos Number", "HIP 79015"},
        {"Geneva Identification System", "GEN# +1.00144711"},
        {"Smithsonian Astrophysical Observation", "SAO 159717"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.92519004),
        dec: Angle.Degrees(-16.51577613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114268"},
        {"Hipparcos Number", "HIP 64218"},
        {"Smithsonian Astrophysical Observation", "SAO 157759"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.42668862),
        dec: Angle.Degrees(-16.51519285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60965",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Algorab"},
        {"Aitken", "ADS 8572 A"},
        {"Henry Draper", "HD 108767"},
        {"Hipparcos Number", "HIP 60965"},
        {"Celescope Catalog", "CEL 4116"},
        {"Fundamental Katalog 5th Edition", "FK5 465"},
        {"Geneva Identification System", "GEN# +1.00108767A"},
        {"Smithsonian Astrophysical Observation", "SAO 157323"},
        {"Wilson Evans Batten Catalogue", "WEB 10850"},
    },
    visualMagnitude: 2.94,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.46659650),
        dec: Angle.Degrees(-16.51509397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -209.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131958"},
        {"Hipparcos Number", "HIP 73161"},
        {"Smithsonian Astrophysical Observation", "SAO 158920"},
        {"Wilson Evans Batten Catalogue", "WEB 12535"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.28008131),
        dec: Angle.Degrees(-16.51487991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155548"},
        {"Hipparcos Number", "HIP 84227"},
        {"Geneva Identification System", "GEN# +1.00155548"},
        {"Renson", "Renson 43935"},
        {"Smithsonian Astrophysical Observation", "SAO 160368"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.24412537),
        dec: Angle.Degrees(-16.51457671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114625"},
        {"Hipparcos Number", "HIP 64393"},
        {"Smithsonian Astrophysical Observation", "SAO 157786"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.97046629),
        dec: Angle.Degrees(-16.51370539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72873",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9424 AB"},
        {"Henry Draper", "HD 131366"},
        {"Hipparcos Number", "HIP 72873"},
    },
    visualMagnitude: 8.77,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.42322815),
        dec: Angle.Degrees(-16.51274522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174591"},
        {"Hipparcos Number", "HIP 92572"},
        {"Geneva Identification System", "GEN# +1.00174591"},
        {"Smithsonian Astrophysical Observation", "SAO 161918"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.96157044),
        dec: Angle.Degrees(-16.51048509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105683"},
        {"Hipparcos Number", "HIP 59308"},
        {"Smithsonian Astrophysical Observation", "SAO 157119"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.51352809),
        dec: Angle.Degrees(-16.50836573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118086",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118086"},
        {"Geneva Identification System", "GEN# +9.80158012"},
    },
    visualMagnitude: 10.76,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.30891401),
        dec: Angle.Degrees(-16.50824862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 396.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 260.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14743"},
        {"Hipparcos Number", "HIP 11057"},
        {"Smithsonian Astrophysical Observation", "SAO 148358"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.57658746),
        dec: Angle.Degrees(-16.50712431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84870"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.18855874),
        dec: Angle.Degrees(-16.50418374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86762"},
        {"Hipparcos Number", "HIP 49036"},
        {"Smithsonian Astrophysical Observation", "SAO 155648"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.07085917),
        dec: Angle.Degrees(-16.50367181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77015"},
        {"Hipparcos Number", "HIP 44129"},
        {"Smithsonian Astrophysical Observation", "SAO 154810"},
        {"Wilson Evans Batten Catalogue", "WEB 8478"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.80850393),
        dec: Angle.Degrees(-16.50263778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33250",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5584 AB"},
        {"Henry Draper", "HD 51031"},
        {"Hipparcos Number", "HIP 33250"},
        {"Renson", "Renson 14060"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.76708393),
        dec: Angle.Degrees(-16.49590260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84092",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10385 AB"},
        {"Henry Draper", "HD 155317"},
        {"Hipparcos Number", "HIP 84092"},
        {"Smithsonian Astrophysical Observation", "SAO 160347"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.87324324),
        dec: Angle.Degrees(-16.49188649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51650"},
        {"Hipparcos Number", "HIP 33482"},
        {"Geneva Identification System", "GEN# +1.00051650"},
        {"Renson", "Renson 14210"},
        {"Smithsonian Astrophysical Observation", "SAO 152167"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.39928048),
        dec: Angle.Degrees(-16.48993918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137634"},
        {"Hipparcos Number", "HIP 75671"},
        {"Smithsonian Astrophysical Observation", "SAO 159272"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.90565823),
        dec: Angle.Degrees(-16.48930460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17538",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17538"},
        {"Smithsonian Astrophysical Observation", "SAO 149148"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.32300777),
        dec: Angle.Degrees(-16.48918480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11534"},
        {"Hipparcos Number", "HIP 8789"},
        {"Smithsonian Astrophysical Observation", "SAO 148081"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.25465652),
        dec: Angle.Degrees(-16.48901080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8406"},
        {"Hipparcos Number", "HIP 6455"},
        {"Geneva Identification System", "GEN# +1.00008406"},
        {"Smithsonian Astrophysical Observation", "SAO 147769"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.75399055),
        dec: Angle.Degrees(-16.48703344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41511"},
        {"Hipparcos Number", "HIP 28816"},
        {"Geneva Identification System", "GEN# +1.00041511"},
        {"Smithsonian Astrophysical Observation", "SAO 151093"},
        {"Wilson Evans Batten Catalogue", "WEB 5638"},
    },
    visualMagnitude: 4.92,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.24638576),
        dec: Angle.Degrees(-16.48442713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133800"},
        {"Hipparcos Number", "HIP 73953"},
        {"Geneva Identification System", "GEN# +1.00133800"},
        {"Smithsonian Astrophysical Observation", "SAO 159030"},
        {"Wilson Evans Batten Catalogue", "WEB 12630"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.70457650),
        dec: Angle.Degrees(-16.48432063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6346",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1100 AB"},
        {"Henry Draper", "HD 8237"},
        {"Hipparcos Number", "HIP 6346"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.38186054),
        dec: Angle.Degrees(-16.48313669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47920"},
        {"Hipparcos Number", "HIP 31924"},
        {"Smithsonian Astrophysical Observation", "SAO 151774"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.07286581),
        dec: Angle.Degrees(-16.47762460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130156"},
        {"Hipparcos Number", "HIP 72292"},
        {"Renson", "Renson 37077"},
        {"Smithsonian Astrophysical Observation", "SAO 158799"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.75978536),
        dec: Angle.Degrees(-16.47332983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214449"},
        {"Hipparcos Number", "HIP 111780"},
        {"Smithsonian Astrophysical Observation", "SAO 165209"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.62541057),
        dec: Angle.Degrees(-16.47275398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39840",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39840"},
    },
    visualMagnitude: 10.63,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.09728151),
        dec: Angle.Degrees(-16.47130050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213199"},
        {"Hipparcos Number", "HIP 111063"},
        {"Geneva Identification System", "GEN# +1.00213199"},
        {"Smithsonian Astrophysical Observation", "SAO 165122"},
        {"Wilson Evans Batten Catalogue", "WEB 19883"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.49484229),
        dec: Angle.Degrees(-16.46852832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44892"},
        {"Hipparcos Number", "HIP 30414"},
        {"Geneva Identification System", "GEN# +1.00044892"},
        {"Smithsonian Astrophysical Observation", "SAO 151449"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.92818464),
        dec: Angle.Degrees(-16.46721271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2634"},
    },
    visualMagnitude: 11.35,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.36061633),
        dec: Angle.Degrees(-16.46662508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17252"},
        {"Hipparcos Number", "HIP 12897"},
        {"Cincinnati Publication", "Ci 20 183"},
        {"Geneva Identification System", "GEN# +1.00017252"},
        {"Smithsonian Astrophysical Observation", "SAO 148590"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.44679150),
        dec: Angle.Degrees(-16.46162242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 306.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -229.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111472",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111472"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.76964542),
        dec: Angle.Degrees(-16.46111330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 222.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58504"},
        {"Hipparcos Number", "HIP 36016"},
        {"Geneva Identification System", "GEN# +1.00058504"},
        {"Smithsonian Astrophysical Observation", "SAO 152848"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.32944415),
        dec: Angle.Degrees(-16.45904683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104656"},
        {"Hipparcos Number", "HIP 58766"},
        {"Fundamental Katalog 5th Edition", "FK5 5061"},
        {"Smithsonian Astrophysical Observation", "SAO 157063"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.77806578),
        dec: Angle.Degrees(-16.45628956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134440"},
        {"Hipparcos Number", "HIP 74234"},
        {"Cincinnati Publication", "Ci 18 2018"},
        {"Cincinnati Publication 2", "Ci 20 914"},
        {"Geneva Identification System", "GEN# +1.00134440"},
        {"Smithsonian Astrophysical Observation", "SAO 159066"},
        {"Wilson Evans Batten Catalogue", "WEB 12675"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.55657102),
        dec: Angle.Degrees(-16.45431147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1001.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3542.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97109"},
        {"Hipparcos Number", "HIP 54612"},
        {"Smithsonian Astrophysical Observation", "SAO 156511"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.64532584),
        dec: Angle.Degrees(-16.45314496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28680"},
        {"Hipparcos Number", "HIP 21047"},
        {"Smithsonian Astrophysical Observation", "SAO 149695"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.67552998),
        dec: Angle.Degrees(-16.45309713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182925"},
        {"Hipparcos Number", "HIP 95670"},
        {"Geneva Identification System", "GEN# +1.00182925"},
        {"Smithsonian Astrophysical Observation", "SAO 162636"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.89616841),
        dec: Angle.Degrees(-16.45296736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118411"},
        {"Hipparcos Number", "HIP 66423"},
        {"Smithsonian Astrophysical Observation", "SAO 158043"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.26337019),
        dec: Angle.Degrees(-16.44707220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118876"},
        {"Hipparcos Number", "HIP 66663"},
        {"Fundamental Katalog 5th Edition", "FK5 5209"},
        {"Smithsonian Astrophysical Observation", "SAO 158076"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.99383851),
        dec: Angle.Degrees(-16.44651453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26994"},
        {"Hipparcos Number", "HIP 19856"},
        {"Geneva Identification System", "GEN# +1.00026994"},
        {"Smithsonian Astrophysical Observation", "SAO 149491"},
    },
    visualMagnitude: 6.87,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.86147608),
        dec: Angle.Degrees(-16.44517816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81673"},
        {"Hipparcos Number", "HIP 46320"},
        {"Geneva Identification System", "GEN# +1.00081673"},
        {"Smithsonian Astrophysical Observation", "SAO 155190"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.67096347),
        dec: Angle.Degrees(-16.44448692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20229",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3140 A"},
        {"Henry Draper", "HD 27528"},
        {"Hipparcos Number", "HIP 20229"},
        {"Fundamental Katalog 5th Edition", "FK5 1119"},
        {"Geneva Identification System", "GEN# +1.00027528"},
        {"Smithsonian Astrophysical Observation", "SAO 149554"},
    },
    visualMagnitude: 6.80,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.03776658),
        dec: Angle.Degrees(-16.43724438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200069"},
        {"Hipparcos Number", "HIP 103762"},
        {"Smithsonian Astrophysical Observation", "SAO 164069"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.39943907),
        dec: Angle.Degrees(-16.43564146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5262"},
        {"Hipparcos Number", "HIP 4247"},
        {"Smithsonian Astrophysical Observation", "SAO 147509"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.54436383),
        dec: Angle.Degrees(-16.43492452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26809",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26809"},
        {"Smithsonian Astrophysical Observation", "SAO 150701"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.39709124),
        dec: Angle.Degrees(-16.43421329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204137"},
        {"Hipparcos Number", "HIP 105917"},
        {"Smithsonian Astrophysical Observation", "SAO 164397"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.77354196),
        dec: Angle.Degrees(-16.43354877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179177"},
        {"Hipparcos Number", "HIP 94345"},
        {"Geneva Identification System", "GEN# +1.00179177"},
        {"Smithsonian Astrophysical Observation", "SAO 162304"},
        {"Wilson Evans Batten Catalogue", "WEB 16436"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.04049717),
        dec: Angle.Degrees(-16.43037903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169961"},
        {"Hipparcos Number", "HIP 90484"},
        {"Smithsonian Astrophysical Observation", "SAO 161491"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.94956968),
        dec: Angle.Degrees(-16.42728366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136345"},
        {"Hipparcos Number", "HIP 75094"},
        {"Smithsonian Astrophysical Observation", "SAO 159186"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.17360061),
        dec: Angle.Degrees(-16.42645580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7424"},
        {"Hipparcos Number", "HIP 5775"},
        {"Geneva Identification System", "GEN# +1.00007424"},
        {"Smithsonian Astrophysical Observation", "SAO 147686"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.52966556),
        dec: Angle.Degrees(-16.42612160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 198.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3576",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 636 AB"},
        {"Henry Draper", "HD 4338"},
        {"Hipparcos Number", "HIP 3576"},
        {"Geneva Identification System", "GEN# +1.00004338J"},
        {"Smithsonian Astrophysical Observation", "SAO 147436"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.42375052),
        dec: Angle.Degrees(-16.42420509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11984"},
        {"Hipparcos Number", "HIP 9104"},
        {"Smithsonian Astrophysical Observation", "SAO 148124"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.31396871),
        dec: Angle.Degrees(-16.42407720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200994"},
        {"Hipparcos Number", "HIP 104252"},
        {"Smithsonian Astrophysical Observation", "SAO 164150"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.81428921),
        dec: Angle.Degrees(-16.42255886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43291"},
        {"Hipparcos Number", "HIP 29646"},
        {"Smithsonian Astrophysical Observation", "SAO 151267"},
    },
    visualMagnitude: 8.22,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.70471890),
        dec: Angle.Degrees(-16.42196731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28115"},
        {"Hipparcos Number", "HIP 20656"},
        {"Smithsonian Astrophysical Observation", "SAO 149621"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.39447971),
        dec: Angle.Degrees(-16.41848045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31444"},
        {"Hipparcos Number", "HIP 22881"},
        {"Fundamental Katalog 5th Edition", "FK5 2370"},
        {"Geneva Identification System", "GEN# +1.00031444"},
        {"Smithsonian Astrophysical Observation", "SAO 149988"},
        {"Wilson Evans Batten Catalogue", "WEB 4437"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.82767537),
        dec: Angle.Degrees(-16.41785525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165808"},
        {"Hipparcos Number", "HIP 88857"},
        {"Geneva Identification System", "GEN# +1.00165808"},
        {"Smithsonian Astrophysical Observation", "SAO 161102"},
        {"Wilson Evans Batten Catalogue", "WEB 15067"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.11980333),
        dec: Angle.Degrees(-16.41665449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198461"},
        {"Hipparcos Number", "HIP 102922"},
        {"Smithsonian Astrophysical Observation", "SAO 163932"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.77402813),
        dec: Angle.Degrees(-16.41460299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2189",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 7.82,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)27, 39.3200),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)24, 45.400)
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
    primaryId: "HIP 74401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134796"},
        {"Hipparcos Number", "HIP 74401"},
        {"Geneva Identification System", "GEN# +1.00134796"},
        {"Smithsonian Astrophysical Observation", "SAO 159093"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.08731565),
        dec: Angle.Degrees(-16.41106698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215653"},
        {"Hipparcos Number", "HIP 112479"},
        {"Smithsonian Astrophysical Observation", "SAO 165288"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.74986117),
        dec: Angle.Degrees(-16.41049864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23517"},
        {"Hipparcos Number", "HIP 17530"},
        {"Geneva Identification System", "GEN# +1.00023517"},
        {"Smithsonian Astrophysical Observation", "SAO 149147"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.30002348),
        dec: Angle.Degrees(-16.41048515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2190",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 366 A"},
        {"Henry Draper", "HD 2394"},
        {"Hipparcos Number", "HIP 2190"},
        {"Cincinnati Publication", "Ci 18 48"},
        {"Geneva Identification System", "GEN# +1.00002394"},
        {"Smithsonian Astrophysical Observation", "SAO 147286"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.91789141),
        dec: Angle.Degrees(-16.40952353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 199.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130710"},
        {"Hipparcos Number", "HIP 72560"},
        {"Smithsonian Astrophysical Observation", "SAO 158829"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.53245302),
        dec: Angle.Degrees(-16.40640716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133914"},
        {"Hipparcos Number", "HIP 74010"},
        {"Smithsonian Astrophysical Observation", "SAO 159037"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.87447231),
        dec: Angle.Degrees(-16.40535484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94126"},
        {"Hipparcos Number", "HIP 53084"},
        {"Smithsonian Astrophysical Observation", "SAO 156278"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.90265536),
        dec: Angle.Degrees(-16.40423066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -200.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203845"},
        {"Hipparcos Number", "HIP 105754"},
        {"Renson", "Renson 56763"},
        {"Smithsonian Astrophysical Observation", "SAO 164376"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.29369778),
        dec: Angle.Degrees(-16.40214144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143878"},
        {"Hipparcos Number", "HIP 78664"},
        {"Smithsonian Astrophysical Observation", "SAO 159659"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.89009835),
        dec: Angle.Degrees(-16.40211912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60720"},
        {"Hipparcos Number", "HIP 36910"},
        {"Smithsonian Astrophysical Observation", "SAO 153102"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.83279709),
        dec: Angle.Degrees(-16.40184275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145916"},
        {"Hipparcos Number", "HIP 79560"},
        {"Geneva Identification System", "GEN# +1.00145916"},
        {"Smithsonian Astrophysical Observation", "SAO 159794"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.51256602),
        dec: Angle.Degrees(-16.40104364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26298"},
        {"Hipparcos Number", "HIP 19383"},
        {"Geneva Identification System", "GEN# +1.00026298"},
        {"Smithsonian Astrophysical Observation", "SAO 149411"},
        {"Wilson Evans Batten Catalogue", "WEB 3722"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.28223030),
        dec: Angle.Degrees(-16.39987458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 175.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40970"},
        {"Hipparcos Number", "HIP 28547"},
        {"Smithsonian Astrophysical Observation", "SAO 151032"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.39243982),
        dec: Angle.Degrees(-16.39880224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46232"},
        {"Hipparcos Number", "HIP 31093"},
        {"Smithsonian Astrophysical Observation", "SAO 151607"},
    },
    visualMagnitude: 8.80,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.87502650),
        dec: Angle.Degrees(-16.39827408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217276"},
        {"Hipparcos Number", "HIP 113543"},
        {"Geneva Identification System", "GEN# +1.00217276"},
        {"Smithsonian Astrophysical Observation", "SAO 165426"},
        {"Wilson Evans Batten Catalogue", "WEB 20186"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.94470385),
        dec: Angle.Degrees(-16.39809182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131211"},
        {"Hipparcos Number", "HIP 72784"},
        {"Smithsonian Astrophysical Observation", "SAO 158871"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.16186052),
        dec: Angle.Degrees(-16.39772975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183691"},
        {"Hipparcos Number", "HIP 96008"},
        {"Smithsonian Astrophysical Observation", "SAO 162714"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.81574866),
        dec: Angle.Degrees(-16.39741188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57167"},
        {"Hipparcos Number", "HIP 35487"},
        {"Geneva Identification System", "GEN# +1.00057167"},
        {"Smithsonian Astrophysical Observation", "SAO 152724"},
        {"Wilson Evans Batten Catalogue", "WEB 7077"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.86700585),
        dec: Angle.Degrees(-16.39491266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201629"},
        {"Hipparcos Number", "HIP 104591"},
        {"Smithsonian Astrophysical Observation", "SAO 164200"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.81036220),
        dec: Angle.Degrees(-16.39334842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131515"},
        {"Hipparcos Number", "HIP 72947"},
        {"Smithsonian Astrophysical Observation", "SAO 158888"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.62586916),
        dec: Angle.Degrees(-16.39267541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13613"},
        {"Hipparcos Number", "HIP 10291"},
        {"Smithsonian Astrophysical Observation", "SAO 148272"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.12980812),
        dec: Angle.Degrees(-16.39152450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45198"},
        {"Hipparcos Number", "HIP 30562"},
        {"Fundamental Katalog 5th Edition", "FK5 4582"},
        {"Smithsonian Astrophysical Observation", "SAO 151485"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.36415370),
        dec: Angle.Degrees(-16.39117984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4705"},
        {"Hipparcos Number", "HIP 3815"},
        {"Smithsonian Astrophysical Observation", "SAO 147461"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.25773565),
        dec: Angle.Degrees(-16.39091809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117968"},
        {"Hipparcos Number", "HIP 66203"},
        {"Smithsonian Astrophysical Observation", "SAO 158009"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.54473480),
        dec: Angle.Degrees(-16.38895247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9485"},
        {"Hipparcos Number", "HIP 7202"},
        {"Geneva Identification System", "GEN# +1.00009485"},
        {"Smithsonian Astrophysical Observation", "SAO 147877"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.20329479),
        dec: Angle.Degrees(-16.38814440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214080"},
        {"Hipparcos Number", "HIP 111563"},
        {"Fundamental Katalog 5th Edition", "FK5 5993"},
        {"Geneva Identification System", "GEN# +1.00214080"},
        {"Smithsonian Astrophysical Observation", "SAO 165181"},
        {"Wilson Evans Batten Catalogue", "WEB 19943"},
    },
    visualMagnitude: 6.84,
    bvColour: -0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.02680667),
        dec: Angle.Degrees(-16.38794475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26326"},
        {"Hipparcos Number", "HIP 19398"},
        {"Geneva Identification System", "GEN# +1.00026326"},
        {"Smithsonian Astrophysical Observation", "SAO 149412"},
        {"Wilson Evans Batten Catalogue", "WEB 3724"},
    },
    visualMagnitude: 5.45,
    bvColour: -0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.32431793),
        dec: Angle.Degrees(-16.38587725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51599"},
        {"Hipparcos Number", "HIP 33461"},
        {"Geneva Identification System", "GEN# +1.00051599"},
        {"Smithsonian Astrophysical Observation", "SAO 152162"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.34469975),
        dec: Angle.Degrees(-16.38566122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211362"},
        {"Hipparcos Number", "HIP 110004"},
        {"Geneva Identification System", "GEN# +1.00211362"},
        {"Smithsonian Astrophysical Observation", "SAO 164975"},
        {"Wilson Evans Batten Catalogue", "WEB 19749"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.21099819),
        dec: Angle.Degrees(-16.38437096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50393"},
        {"Hipparcos Number", "HIP 32988"},
        {"Smithsonian Astrophysical Observation", "SAO 152035"},
    },
    visualMagnitude: 9.68,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.09045837),
        dec: Angle.Degrees(-16.38404302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174801"},
        {"Hipparcos Number", "HIP 92671"},
        {"Smithsonian Astrophysical Observation", "SAO 161933"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.25184251),
        dec: Angle.Degrees(-16.38146184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166689"},
        {"Hipparcos Number", "HIP 89222"},
        {"Geneva Identification System", "GEN# +1.00166689"},
        {"Smithsonian Astrophysical Observation", "SAO 161180"},
        {"Wilson Evans Batten Catalogue", "WEB 15164"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.11494480),
        dec: Angle.Degrees(-16.38068073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41322",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41322"},
    },
    visualMagnitude: 10.24,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.46548570),
        dec: Angle.Degrees(-16.37986772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -186.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23166",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3588 AB"},
        {"Henry Draper", "HD 31925"},
        {"Hipparcos Number", "HIP 23166"},
        {"Geneva Identification System", "GEN# +1.00031925"},
        {"Smithsonian Astrophysical Observation", "SAO 150052"},
        {"Wilson Evans Batten Catalogue", "WEB 4494"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.75599103),
        dec: Angle.Degrees(-16.37633681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 127.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175317"},
        {"Hipparcos Number", "HIP 92882"},
        {"Fundamental Katalog 5th Edition", "FK5 1495"},
        {"Geneva Identification System", "GEN# +1.00175317"},
        {"Smithsonian Astrophysical Observation", "SAO 161984"},
        {"Wilson Evans Batten Catalogue", "WEB 16080"},
    },
    visualMagnitude: 5.56,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.87925799),
        dec: Angle.Degrees(-16.37618751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82927"},
        {"Hipparcos Number", "HIP 46988"},
        {"Smithsonian Astrophysical Observation", "SAO 155310"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.65636707),
        dec: Angle.Degrees(-16.37580260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168607"},
        {"Hipparcos Number", "HIP 89956"},
        {"Geneva Identification System", "GEN# +1.00168607"},
        {"Smithsonian Astrophysical Observation", "SAO 161374"},
        {"Wilson Evans Batten Catalogue", "WEB 15363"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.31202279),
        dec: Angle.Degrees(-16.37548660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223783"},
        {"Hipparcos Number", "HIP 117738"},
        {"Geneva Identification System", "GEN# +1.00223783"},
        {"Smithsonian Astrophysical Observation", "SAO 165935"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.17257055),
        dec: Angle.Degrees(-16.37468773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184283"},
        {"Hipparcos Number", "HIP 96255"},
        {"Geneva Identification System", "GEN# +1.00184283"},
        {"Smithsonian Astrophysical Observation", "SAO 162777"},
        {"Wilson Evans Batten Catalogue", "WEB 16869"},
    },
    visualMagnitude: 7.05,
    bvColour: 2.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.57913643),
        dec: Angle.Degrees(-16.37417905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168625"},
        {"Hipparcos Number", "HIP 89963"},
        {"Geneva Identification System", "GEN# +1.00168625"},
        {"Smithsonian Astrophysical Observation", "SAO 161375"},
        {"Wilson Evans Batten Catalogue", "WEB 15364"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.33145176),
        dec: Angle.Degrees(-16.37390471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190417"},
        {"Hipparcos Number", "HIP 98947"},
        {"Smithsonian Astrophysical Observation", "SAO 163249"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.34088849),
        dec: Angle.Degrees(-16.37329509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92440"},
        {"Hipparcos Number", "HIP 52220"},
        {"Geneva Identification System", "GEN# +1.00092440"},
        {"Smithsonian Astrophysical Observation", "SAO 156142"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.04025151),
        dec: Angle.Degrees(-16.37213478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188577"},
        {"Hipparcos Number", "HIP 98113"},
        {"Smithsonian Astrophysical Observation", "SAO 163120"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.09401120),
        dec: Angle.Degrees(-16.37197429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134439"},
        {"Hipparcos Number", "HIP 74235"},
        {"Cincinnati Publication", "Ci 20 915"},
        {"Cincinnati Publication 2", "Ci 18 2019"},
        {"Geneva Identification System", "GEN# +1.00134439"},
        {"Smithsonian Astrophysical Observation", "SAO 159067"},
        {"Wilson Evans Batten Catalogue", "WEB 12674"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.55706017),
        dec: Angle.Degrees(-16.37079353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -998.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3542.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214321"},
        {"Hipparcos Number", "HIP 111691"},
        {"Smithsonian Astrophysical Observation", "SAO 165204"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.38232424),
        dec: Angle.Degrees(-16.37073963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90514"},
        {"Hipparcos Number", "HIP 51125"},
        {"Geneva Identification System", "GEN# +1.00090514"},
        {"Smithsonian Astrophysical Observation", "SAO 155987"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.67058924),
        dec: Angle.Degrees(-16.36906118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184919"},
        {"Hipparcos Number", "HIP 96510"},
        {"Renson", "Renson 51015"},
        {"Smithsonian Astrophysical Observation", "SAO 162821"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.30136416),
        dec: Angle.Degrees(-16.36871269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4356",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 780 AB"},
        {"Henry Draper", "HD 5412"},
        {"Hipparcos Number", "HIP 4356"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.95807679),
        dec: Angle.Degrees(-16.36850750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94707"},
        {"Hipparcos Number", "HIP 53429"},
        {"Smithsonian Astrophysical Observation", "SAO 156333"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.94160593),
        dec: Angle.Degrees(-16.36814068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -215.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 141.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194288"},
        {"Hipparcos Number", "HIP 100730"},
        {"Smithsonian Astrophysical Observation", "SAO 163550"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.33041270),
        dec: Angle.Degrees(-16.36713218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211665"},
        {"Hipparcos Number", "HIP 110176"},
        {"Smithsonian Astrophysical Observation", "SAO 164995"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.74810161),
        dec: Angle.Degrees(-16.36446153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 217.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150468"},
        {"Hipparcos Number", "HIP 81745"},
        {"Smithsonian Astrophysical Observation", "SAO 160053"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.45605664),
        dec: Angle.Degrees(-16.36357665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67072"},
        {"Hipparcos Number", "HIP 39618"},
        {"Geneva Identification System", "GEN# +1.00067072"},
        {"Smithsonian Astrophysical Observation", "SAO 153820"},
        {"Wilson Evans Batten Catalogue", "WEB 7743"},
    },
    visualMagnitude: 9.67,
    bvColour: -0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.44253398),
        dec: Angle.Degrees(-16.36303805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127481"},
        {"Hipparcos Number", "HIP 71063"},
        {"Smithsonian Astrophysical Observation", "SAO 158622"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.98918887),
        dec: Angle.Degrees(-16.36249379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29421"},
        {"Hipparcos Number", "HIP 21535"},
        {"Geneva Identification System", "GEN# +1.00029421"},
        {"Smithsonian Astrophysical Observation", "SAO 149771"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.35925780),
        dec: Angle.Degrees(-16.36221333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47246"},
        {"Hipparcos Number", "HIP 31615"},
        {"Celescope Catalog", "CEL 1320"},
        {"Geneva Identification System", "GEN# +1.00047246"},
        {"Smithsonian Astrophysical Observation", "SAO 151707"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.25384225),
        dec: Angle.Degrees(-16.35673395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155198"},
        {"Hipparcos Number", "HIP 84037"},
        {"Smithsonian Astrophysical Observation", "SAO 160336"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.69056570),
        dec: Angle.Degrees(-16.35507410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109421"},
        {"Hipparcos Number", "HIP 61373"},
        {"Geneva Identification System", "GEN# +1.00109421"},
        {"Smithsonian Astrophysical Observation", "SAO 157372"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.65429314),
        dec: Angle.Degrees(-16.35441207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95234"},
        {"Hipparcos Number", "HIP 53723"},
        {"Geneva Identification System", "GEN# +1.00095234"},
        {"Smithsonian Astrophysical Observation", "SAO 156372"},
        {"Wilson Evans Batten Catalogue", "WEB 9733"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.87897514),
        dec: Angle.Degrees(-16.35368059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34322"},
        {"Hipparcos Number", "HIP 24551"},
        {"Smithsonian Astrophysical Observation", "SAO 150283"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.99907834),
        dec: Angle.Degrees(-16.35287508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117517"},
        {"Hipparcos Number", "HIP 65939"},
        {"Geneva Identification System", "GEN# +1.00117517"},
        {"Smithsonian Astrophysical Observation", "SAO 157976"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.77482705),
        dec: Angle.Degrees(-16.35266627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97909"},
        {"Hipparcos Number", "HIP 55001"},
        {"Smithsonian Astrophysical Observation", "SAO 156570"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.92091939),
        dec: Angle.Degrees(-16.35246409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50645",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7733 AB"},
        {"Henry Draper", "HD 89675"},
        {"Hipparcos Number", "HIP 50645"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.15277564),
        dec: Angle.Degrees(-16.35076089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55000",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55000"},
        {"Smithsonian Astrophysical Observation", "SAO 156569"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.91610267),
        dec: Angle.Degrees(-16.34978484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175382"},
        {"Hipparcos Number", "HIP 92900"},
        {"Geneva Identification System", "GEN# +1.00175382"},
        {"Smithsonian Astrophysical Observation", "SAO 161989"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.93638072),
        dec: Angle.Degrees(-16.34908550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133215"},
        {"Hipparcos Number", "HIP 73692"},
        {"Smithsonian Astrophysical Observation", "SAO 158996"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.93813903),
        dec: Angle.Degrees(-16.34696703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213251"},
        {"Hipparcos Number", "HIP 111100"},
        {"Geneva Identification System", "GEN# +1.00213251"},
        {"Smithsonian Astrophysical Observation", "SAO 165129"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.61125325),
        dec: Angle.Degrees(-16.34678570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12293"},
        {"Hipparcos Number", "HIP 9361"},
        {"Smithsonian Astrophysical Observation", "SAO 148149"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.06923073),
        dec: Angle.Degrees(-16.34610211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115045",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16658 AB"},
        {"Henry Draper", "HD 219703"},
        {"Hipparcos Number", "HIP 115045"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.50653796),
        dec: Angle.Degrees(-16.34591127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51905",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7847 A"},
        {"Henry Draper", "HD 91880"},
        {"Hipparcos Number", "HIP 51905"},
        {"Geneva Identification System", "GEN# +1.00091880"},
        {"Smithsonian Astrophysical Observation", "SAO 156093"},
        {"Wilson Evans Batten Catalogue", "WEB 9473"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.06948890),
        dec: Angle.Degrees(-16.34433285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74000"},
        {"Hipparcos Number", "HIP 42592"},
        {"Cincinnati Publication", "Ci 20 481"},
        {"Geneva Identification System", "GEN# +1.00074000"},
        {"Smithsonian Astrophysical Observation", "SAO 154538"},
        {"Wilson Evans Batten Catalogue", "WEB 8219"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.21079195),
        dec: Angle.Degrees(-16.34396672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 351.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -484.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66644"},
        {"Hipparcos Number", "HIP 39462"},
        {"Fundamental Katalog 5th Edition", "FK5 4727"},
        {"Smithsonian Astrophysical Observation", "SAO 153775"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.98981855),
        dec: Angle.Degrees(-16.34227815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10037",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10037"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.29411376),
        dec: Angle.Degrees(-16.33978445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 517.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87721"},
        {"Hipparcos Number", "HIP 49512"},
        {"Smithsonian Astrophysical Observation", "SAO 155726"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.63770879),
        dec: Angle.Degrees(-16.33851153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113414"},
        {"Hipparcos Number", "HIP 63734"},
        {"Geneva Identification System", "GEN# +1.00113414"},
        {"Smithsonian Astrophysical Observation", "SAO 157688"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.91281521),
        dec: Angle.Degrees(-16.33650247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122958"},
        {"Hipparcos Number", "HIP 68808"},
        {"Geneva Identification System", "GEN# +1.00122958"},
        {"Smithsonian Astrophysical Observation", "SAO 158331"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.30838189),
        dec: Angle.Degrees(-16.33598528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151528"},
        {"Hipparcos Number", "HIP 82260"},
        {"Geneva Identification System", "GEN# +1.00151528"},
        {"Smithsonian Astrophysical Observation", "SAO 160105"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.11824891),
        dec: Angle.Degrees(-16.33387962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -270.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35851"},
        {"Hipparcos Number", "HIP 25478"},
        {"Geneva Identification System", "GEN# +1.00035851"},
        {"Smithsonian Astrophysical Observation", "SAO 150460"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.74125214),
        dec: Angle.Degrees(-16.33122236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30606"},
        {"Hipparcos Number", "HIP 22325"},
        {"Geneva Identification System", "GEN# +1.00030606"},
        {"Smithsonian Astrophysical Observation", "SAO 149901"},
        {"Wilson Evans Batten Catalogue", "WEB 4302"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.13553607),
        dec: Angle.Degrees(-16.32958093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92415"},
        {"Hipparcos Number", "HIP 52209"},
        {"Geneva Identification System", "GEN# +1.00092415"},
        {"Smithsonian Astrophysical Observation", "SAO 156140"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.99816010),
        dec: Angle.Degrees(-16.32873471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47679",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7501 A"},
        {"Henry Draper", "HD 84223"},
        {"Hipparcos Number", "HIP 47679"},
        {"Smithsonian Astrophysical Observation", "SAO 155432"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.82730625),
        dec: Angle.Degrees(-16.32823975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122218"},
        {"Hipparcos Number", "HIP 68451"},
        {"Smithsonian Astrophysical Observation", "SAO 158288"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.21205920),
        dec: Angle.Degrees(-16.32473859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168701"},
        {"Henry Draper 2", "HD 168702"},
        {"Hipparcos Number", "HIP 90001"},
        {"Smithsonian Astrophysical Observation", "SAO 161385"},
        {"Wilson Evans Batten Catalogue", "WEB 15375"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.45355840),
        dec: Angle.Degrees(-16.32457832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118055"},
        {"Hipparcos Number", "HIP 66246"},
        {"Geneva Identification System", "GEN# +1.00118055"},
        {"Smithsonian Astrophysical Observation", "SAO 158018"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.66635570),
        dec: Angle.Degrees(-16.32294215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36656"},
        {"Hipparcos Number", "HIP 25981"},
        {"Smithsonian Astrophysical Observation", "SAO 150546"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.17431910),
        dec: Angle.Degrees(-16.31930192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14139"},
        {"Hipparcos Number", "HIP 10637"},
        {"Smithsonian Astrophysical Observation", "SAO 148308"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.23412806),
        dec: Angle.Degrees(-16.31796475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23054"},
        {"Hipparcos Number", "HIP 17233"},
        {"Smithsonian Astrophysical Observation", "SAO 149115"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.35939411),
        dec: Angle.Degrees(-16.31775872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11397"},
        {"Hipparcos Number", "HIP 8674"},
        {"Cincinnati Publication", "Ci 18 250"},
        {"Geneva Identification System", "GEN# +1.00011397"},
        {"Smithsonian Astrophysical Observation", "SAO 148067"},
        {"Wilson Evans Batten Catalogue", "WEB 1831"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.91854083),
        dec: Angle.Degrees(-16.31676388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -363.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184266"},
        {"Hipparcos Number", "HIP 96248"},
        {"Geneva Identification System", "GEN# +1.00184266"},
        {"Smithsonian Astrophysical Observation", "SAO 162774"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.56378133),
        dec: Angle.Degrees(-16.31624771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216085"},
        {"Hipparcos Number", "HIP 112755"},
        {"Smithsonian Astrophysical Observation", "SAO 165324"},
        {"Wilson Evans Batten Catalogue", "WEB 20090"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.52424512),
        dec: Angle.Degrees(-16.31377151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221631"},
        {"Hipparcos Number", "HIP 116302"},
        {"Smithsonian Astrophysical Observation", "SAO 165767"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.46793582),
        dec: Angle.Degrees(-16.31311927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155047"},
        {"Hipparcos Number", "HIP 83967"},
        {"Smithsonian Astrophysical Observation", "SAO 160323"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.45995822),
        dec: Angle.Degrees(-16.31280466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156462"},
        {"Hipparcos Number", "HIP 84649"},
        {"Geneva Identification System", "GEN# +1.00156462"},
        {"Smithsonian Astrophysical Observation", "SAO 160440"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.58029693),
        dec: Angle.Degrees(-16.31190245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57820"},
        {"Hipparcos Number", "HIP 35740"},
        {"Smithsonian Astrophysical Observation", "SAO 152778"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.58181016),
        dec: Angle.Degrees(-16.31133916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49845"},
        {"Hipparcos Number", "HIP 32747"},
        {"Smithsonian Astrophysical Observation", "SAO 151977"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.43652433),
        dec: Angle.Degrees(-16.31007212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172032"},
        {"Hipparcos Number", "HIP 91414"},
        {"Geneva Identification System", "GEN# +1.00172032"},
        {"Renson", "Renson 48210"},
        {"Smithsonian Astrophysical Observation", "SAO 161689"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.65325634),
        dec: Angle.Degrees(-16.31005430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16675"},
        {"Hipparcos Number", "HIP 12429"},
        {"Smithsonian Astrophysical Observation", "SAO 148534"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.00304950),
        dec: Angle.Degrees(-16.30837841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7026"},
        {"Hipparcos Number", "HIP 5498"},
        {"Geneva Identification System", "GEN# +1.00007026"},
        {"Smithsonian Astrophysical Observation", "SAO 147650"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.59706275),
        dec: Angle.Degrees(-16.30674710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204632"},
        {"Hipparcos Number", "HIP 106165"},
        {"Smithsonian Astrophysical Observation", "SAO 164438"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.57247657),
        dec: Angle.Degrees(-16.30468233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16741"},
        {"Hipparcos Number", "HIP 12475"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.15220899),
        dec: Angle.Degrees(-16.30376423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8265",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8265"},
        {"Smithsonian Astrophysical Observation", "SAO 148006"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.61534024),
        dec: Angle.Degrees(-16.30368693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123934"},
        {"Hipparcos Number", "HIP 69269"},
        {"Geneva Identification System", "GEN# +1.00123934"},
        {"Smithsonian Astrophysical Observation", "SAO 158401"},
        {"Wilson Evans Batten Catalogue", "WEB 12085"},
    },
    visualMagnitude: 4.93,
    bvColour: 1.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.71034788),
        dec: Angle.Degrees(-16.30200362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66492"},
        {"Hipparcos Number", "HIP 39397"},
        {"Smithsonian Astrophysical Observation", "SAO 153757"},
    },
    visualMagnitude: 9.09,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.80857562),
        dec: Angle.Degrees(-16.29953583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126456"},
        {"Hipparcos Number", "HIP 70554"},
        {"Smithsonian Astrophysical Observation", "SAO 158562"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.48829148),
        dec: Angle.Degrees(-16.29922777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87413"},
    },
    visualMagnitude: 11.39,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.96110062),
        dec: Angle.Degrees(-16.29584924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192544"},
        {"Hipparcos Number", "HIP 99892"},
        {"Smithsonian Astrophysical Observation", "SAO 163399"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.01158015),
        dec: Angle.Degrees(-16.29556561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6022"},
        {"Hipparcos Number", "HIP 4774"},
        {"Geneva Identification System", "GEN# +1.00006022"},
        {"Smithsonian Astrophysical Observation", "SAO 147569"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.33386015),
        dec: Angle.Degrees(-16.29453976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96808",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12767 A"},
        {"Henry Draper", "HD 185644"},
        {"Hipparcos Number", "HIP 96808"},
        {"Fundamental Katalog 5th Edition", "FK5 1512"},
        {"Geneva Identification System", "GEN# +1.00185644A"},
        {"Smithsonian Astrophysical Observation", "SAO 162883"},
        {"Wilson Evans Batten Catalogue", "WEB 16984"},
    },
    visualMagnitude: 5.30,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.18058838),
        dec: Angle.Degrees(-16.29314555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10318"},
        {"Hipparcos Number", "HIP 7821"},
        {"Geneva Identification System", "GEN# +1.00010318"},
        {"Smithsonian Astrophysical Observation", "SAO 147952"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.14829208),
        dec: Angle.Degrees(-16.29249439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90722"},
        {"Hipparcos Number", "HIP 51258"},
        {"Geneva Identification System", "GEN# +1.00090722"},
        {"Smithsonian Astrophysical Observation", "SAO 156003"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.05817132),
        dec: Angle.Degrees(-16.28936749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221879"},
        {"Hipparcos Number", "HIP 116468"},
        {"Smithsonian Astrophysical Observation", "SAO 165790"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.98921547),
        dec: Angle.Degrees(-16.28935024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12754"},
        {"Hipparcos Number", "HIP 9692"},
        {"Smithsonian Astrophysical Observation", "SAO 148185"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.16869560),
        dec: Angle.Degrees(-16.28762846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69665"},
        {"Hipparcos Number", "HIP 40604"},
        {"Geneva Identification System", "GEN# +1.00069665"},
        {"Smithsonian Astrophysical Observation", "SAO 154076"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.34641379),
        dec: Angle.Degrees(-16.28509282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53545"},
        {"Hipparcos Number", "HIP 34146"},
        {"Geneva Identification System", "GEN# +1.00053545"},
        {"Smithsonian Astrophysical Observation", "SAO 152337"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.20580089),
        dec: Angle.Degrees(-16.28458758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100418"},
        {"Hipparcos Number", "HIP 56364"},
        {"Geneva Identification System", "GEN# +1.00100418"},
        {"Smithsonian Astrophysical Observation", "SAO 156750"},
        {"Wilson Evans Batten Catalogue", "WEB 10132"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.31171227),
        dec: Angle.Degrees(-16.28027347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220776"},
        {"Hipparcos Number", "HIP 115707"},
        {"Smithsonian Astrophysical Observation", "SAO 165694"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.64660577),
        dec: Angle.Degrees(-16.27889263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56994"},
        {"Hipparcos Number", "HIP 35417"},
        {"Smithsonian Astrophysical Observation", "SAO 152701"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.68605865),
        dec: Angle.Degrees(-16.27752945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78614"},
        {"Hipparcos Number", "HIP 44888"},
        {"Smithsonian Astrophysical Observation", "SAO 154944"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.18549628),
        dec: Angle.Degrees(-16.27715750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107149"},
        {"Hipparcos Number", "HIP 60086"},
        {"Smithsonian Astrophysical Observation", "SAO 157207"},
        {"Wilson Evans Batten Catalogue", "WEB 10677"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.82849012),
        dec: Angle.Degrees(-16.27390364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96217",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12595 AB"},
        {"Henry Draper", "HD 184223"},
        {"Hipparcos Number", "HIP 96217"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.49061293),
        dec: Angle.Degrees(-16.27387585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203311"},
        {"Hipparcos Number", "HIP 105481"},
        {"Geneva Identification System", "GEN# +1.00203311"},
        {"Smithsonian Astrophysical Observation", "SAO 164338"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.46253939),
        dec: Angle.Degrees(-16.27345161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21077"},
        {"Hipparcos Number", "HIP 15788"},
        {"Smithsonian Astrophysical Observation", "SAO 148937"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.87169363),
        dec: Angle.Degrees(-16.27279133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216640"},
        {"Hipparcos Number", "HIP 113148"},
        {"Geneva Identification System", "GEN# +1.00216640"},
        {"Smithsonian Astrophysical Observation", "SAO 165376"},
        {"Wilson Evans Batten Catalogue", "WEB 20139"},
    },
    visualMagnitude: 5.53,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.69002010),
        dec: Angle.Degrees(-16.27174207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -223.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216883"},
        {"Hipparcos Number", "HIP 113314"},
        {"Smithsonian Astrophysical Observation", "SAO 165397"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.22399457),
        dec: Angle.Degrees(-16.27049848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149434"},
        {"Hipparcos Number", "HIP 81220"},
        {"Smithsonian Astrophysical Observation", "SAO 159989"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.84028566),
        dec: Angle.Degrees(-16.26699004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6037"},
        {"Hipparcos Number", "HIP 4801"},
        {"Fundamental Katalog 5th Edition", "FK5 1025"},
        {"Geneva Identification System", "GEN# +1.00006037"},
        {"Smithsonian Astrophysical Observation", "SAO 147572"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.41083745),
        dec: Angle.Degrees(-16.26535068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39688"},
        {"Hipparcos Number", "HIP 27849"},
        {"Geneva Identification System", "GEN# +1.00039688"},
        {"Smithsonian Astrophysical Observation", "SAO 150919"},
        {"Wilson Evans Batten Catalogue", "WEB 5453"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.37876402),
        dec: Angle.Degrees(-16.26479190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156716"},
        {"Hipparcos Number", "HIP 84791"},
        {"Smithsonian Astrophysical Observation", "SAO 160463"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.97139908),
        dec: Angle.Degrees(-16.26193950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47596"},
        {"Hipparcos Number", "HIP 31785"},
        {"Smithsonian Astrophysical Observation", "SAO 151742"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.69005514),
        dec: Angle.Degrees(-16.26084766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70185"},
    },
    visualMagnitude: 13.45,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.39429535),
        dec: Angle.Degrees(-16.25847186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133774"},
        {"Hipparcos Number", "HIP 73945"},
        {"Fundamental Katalog 5th Edition", "FK5 3193"},
        {"Geneva Identification System", "GEN# +1.00133774"},
        {"Smithsonian Astrophysical Observation", "SAO 159028"},
        {"Wilson Evans Batten Catalogue", "WEB 12628"},
    },
    visualMagnitude: 5.19,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.65674312),
        dec: Angle.Degrees(-16.25676124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14940"},
        {"Hipparcos Number", "HIP 11192"},
        {"Geneva Identification System", "GEN# +1.00014940"},
        {"Smithsonian Astrophysical Observation", "SAO 148373"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.03992405),
        dec: Angle.Degrees(-16.25432040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125715"},
        {"Hipparcos Number", "HIP 70186"},
        {"Smithsonian Astrophysical Observation", "SAO 158511"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.39515618),
        dec: Angle.Degrees(-16.25272998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205749"},
        {"Hipparcos Number", "HIP 106789"},
        {"Geneva Identification System", "GEN# +1.00205749"},
        {"Smithsonian Astrophysical Observation", "SAO 164533"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.45184183),
        dec: Angle.Degrees(-16.25224428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218857"},
        {"Hipparcos Number", "HIP 114502"},
        {"Geneva Identification System", "GEN# +1.00218857"},
        {"Smithsonian Astrophysical Observation", "SAO 165543"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.85260684),
        dec: Angle.Degrees(-16.25088660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161925"},
        {"Hipparcos Number", "HIP 87207"},
        {"Smithsonian Astrophysical Observation", "SAO 160834"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.25461564),
        dec: Angle.Degrees(-16.24989863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39943",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6632 A"},
        {"Henry Draper", "HD 67880"},
        {"Hipparcos Number", "HIP 39943"},
        {"Geneva Identification System", "GEN# +1.00067880J"},
        {"Smithsonian Astrophysical Observation", "SAO 153898"},
        {"Wilson Evans Batten Catalogue", "WEB 7784"},
    },
    visualMagnitude: 5.66,
    bvColour: -0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.36891634),
        dec: Angle.Degrees(-16.24890678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96078"},
        {"Hipparcos Number", "HIP 54160"},
        {"Smithsonian Astrophysical Observation", "SAO 156439"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.18809279),
        dec: Angle.Degrees(-16.24885290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98411"},
        {"Hipparcos Number", "HIP 55274"},
        {"Smithsonian Astrophysical Observation", "SAO 156603"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.80437825),
        dec: Angle.Degrees(-16.24570888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3537"},
        {"Hipparcos Number", "HIP 3002"},
        {"Geneva Identification System", "GEN# +1.00003537"},
        {"Smithsonian Astrophysical Observation", "SAO 147375"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.54871482),
        dec: Angle.Degrees(-16.24511941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216505"},
        {"Hipparcos Number", "HIP 113047"},
        {"Smithsonian Astrophysical Observation", "SAO 165360"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.41128289),
        dec: Angle.Degrees(-16.24130136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80750"},
        {"Hipparcos Number", "HIP 45865"},
        {"Smithsonian Astrophysical Observation", "SAO 155119"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.28454462),
        dec: Angle.Degrees(-16.23993900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219314"},
        {"Hipparcos Number", "HIP 114767"},
        {"Smithsonian Astrophysical Observation", "SAO 165581"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.72146874),
        dec: Angle.Degrees(-16.23929565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38713"},
        {"Hipparcos Number", "HIP 27308"},
        {"Geneva Identification System", "GEN# +1.00038713"},
        {"Smithsonian Astrophysical Observation", "SAO 150806"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.78254305),
        dec: Angle.Degrees(-16.23805509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15627"},
        {"Hipparcos Number", "HIP 11655"},
        {"Smithsonian Astrophysical Observation", "SAO 148430"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.58179379),
        dec: Angle.Degrees(-16.23784411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40554",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6716 AB"},
        {"Henry Draper", "HD 69531"},
        {"Hipparcos Number", "HIP 40554"},
        {"Smithsonian Astrophysical Observation", "SAO 154064"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.21995896),
        dec: Angle.Degrees(-16.23755525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4632",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4632"},
        {"Smithsonian Astrophysical Observation", "SAO 147558"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.86188208),
        dec: Angle.Degrees(-16.23658608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41647"},
        {"Hipparcos Number", "HIP 28879"},
        {"Geneva Identification System", "GEN# +1.00041647"},
        {"Smithsonian Astrophysical Observation", "SAO 151105"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.46004677),
        dec: Angle.Degrees(-16.23621437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22284"},
        {"Hipparcos Number", "HIP 16687"},
        {"Smithsonian Astrophysical Observation", "SAO 149052"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.67666349),
        dec: Angle.Degrees(-16.23614189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56310"},
        {"Hipparcos Number", "HIP 35149"},
        {"Celescope Catalog", "CEL 1723"},
        {"Geneva Identification System", "GEN# +1.00056310"},
        {"Smithsonian Astrophysical Observation", "SAO 152630"},
        {"Wilson Evans Batten Catalogue", "WEB 7024"},
    },
    visualMagnitude: 6.87,
    bvColour: -0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.98448820),
        dec: Angle.Degrees(-16.23537322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54834"},
        {"Hipparcos Number", "HIP 34589"},
        {"Geneva Identification System", "GEN# +1.00054834"},
        {"Smithsonian Astrophysical Observation", "SAO 152484"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.46745475),
        dec: Angle.Degrees(-16.23472715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34561",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5837 A"},
        {"Henry Draper", "HD 54764"},
        {"Hipparcos Number", "HIP 34561"},
        {"Celescope Catalog", "CEL 1624"},
        {"Geneva Identification System", "GEN# +1.00054764A"},
        {"Smithsonian Astrophysical Observation", "SAO 152477"},
        {"Wilson Evans Batten Catalogue", "WEB 6918"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.38902350),
        dec: Angle.Degrees(-16.23450762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93855",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12039 AB"},
        {"Henry Draper", "HD 177817"},
        {"Hipparcos Number", "HIP 93855"},
        {"Fundamental Katalog 5th Edition", "FK5 5681"},
        {"Geneva Identification System", "GEN# +1.00177817J"},
        {"Smithsonian Astrophysical Observation", "SAO 162201"},
        {"Wilson Evans Batten Catalogue", "WEB 16323"},
    },
    visualMagnitude: 6.00,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.71715788),
        dec: Angle.Degrees(-16.22923584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2247",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Felixvarela"},
        {"Hipparcos Number", "HIP 2247"},
        {"Cincinnati Publication", "Ci 20 33"},
        {"Geneva Identification System", "GEN# -0.01700063"},
        {"Smithsonian Astrophysical Observation", "SAO 147293"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.14384042),
        dec: Angle.Degrees(-16.22578934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -354.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -228.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164513"},
        {"Hipparcos Number", "HIP 88317"},
        {"Geneva Identification System", "GEN# +1.00164513"},
        {"Smithsonian Astrophysical Observation", "SAO 161012"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.54418084),
        dec: Angle.Degrees(-16.22530406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30469",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5034 A"},
        {"Henry Draper", "HD 45016"},
        {"Hipparcos Number", "HIP 30469"},
        {"Smithsonian Astrophysical Observation", "SAO 151462"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.08815020),
        dec: Angle.Degrees(-16.22454855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30471",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5034 B"},
        {"Hipparcos Number", "HIP 30471"},
        {"Smithsonian Astrophysical Observation", "SAO 151463"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.09292580),
        dec: Angle.Degrees(-16.22434847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117451"},
        {"Hipparcos Number", "HIP 65912"},
        {"Smithsonian Astrophysical Observation", "SAO 157972"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.67253735),
        dec: Angle.Degrees(-16.22266301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170885"},
        {"Hipparcos Number", "HIP 90888"},
        {"Smithsonian Astrophysical Observation", "SAO 161579"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.08882730),
        dec: Angle.Degrees(-16.22264896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8459"},
        {"Hipparcos Number", "HIP 6506"},
        {"Smithsonian Astrophysical Observation", "SAO 147780"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.88756633),
        dec: Angle.Degrees(-16.22218899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143131"},
        {"Hipparcos Number", "HIP 78295"},
        {"Geneva Identification System", "GEN# +1.00143131"},
        {"Smithsonian Astrophysical Observation", "SAO 159619"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.80704423),
        dec: Angle.Degrees(-16.22172392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30814"},
        {"Hipparcos Number", "HIP 22479"},
        {"Geneva Identification System", "GEN# +1.00030814"},
        {"Smithsonian Astrophysical Observation", "SAO 149924"},
        {"Wilson Evans Batten Catalogue", "WEB 4336"},
    },
    visualMagnitude: 5.03,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.54828803),
        dec: Angle.Degrees(-16.21728342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12745"},
        {"Hipparcos Number", "HIP 9678"},
        {"Geneva Identification System", "GEN# +1.00012745"},
        {"Smithsonian Astrophysical Observation", "SAO 148183"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.12642327),
        dec: Angle.Degrees(-16.21685623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68673"},
        {"Hipparcos Number", "HIP 40223"},
        {"Smithsonian Astrophysical Observation", "SAO 153981"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.22240639),
        dec: Angle.Degrees(-16.21608831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123180"},
        {"Hipparcos Number", "HIP 68900"},
        {"Geneva Identification System", "GEN# +1.00123180"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.60165070),
        dec: Angle.Degrees(-16.21258768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -210.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50463"},
        {"Hipparcos Number", "HIP 33013"},
        {"Celescope Catalog", "CEL 1415"},
        {"Geneva Identification System", "GEN# +1.00050463"},
        {"Smithsonian Astrophysical Observation", "SAO 152041"},
        {"Wilson Evans Batten Catalogue", "WEB 6648"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.19164973),
        dec: Angle.Degrees(-16.21224416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148394"},
        {"Hipparcos Number", "HIP 80677"},
        {"Smithsonian Astrophysical Observation", "SAO 159929"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.06692672),
        dec: Angle.Degrees(-16.21212246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32664",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5484 AB"},
        {"Henry Draper", "HD 49649"},
        {"Hipparcos Number", "HIP 32664"},
        {"Smithsonian Astrophysical Observation", "SAO 151957"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.20326424),
        dec: Angle.Degrees(-16.21145697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210486"},
        {"Hipparcos Number", "HIP 109500"},
        {"Smithsonian Astrophysical Observation", "SAO 164912"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.73775330),
        dec: Angle.Degrees(-16.20967814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186711"},
        {"Hipparcos Number", "HIP 97303"},
        {"Smithsonian Astrophysical Observation", "SAO 162968"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.63393771),
        dec: Angle.Degrees(-16.20927635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128987"},
        {"Hipparcos Number", "HIP 71743"},
        {"Geneva Identification System", "GEN# +1.00128987"},
        {"Smithsonian Astrophysical Observation", "SAO 158720"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.12989224),
        dec: Angle.Degrees(-16.20913162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1736"},
        {"Hipparcos Number", "HIP 1718"},
        {"Geneva Identification System", "GEN# +1.00001736"},
        {"Smithsonian Astrophysical Observation", "SAO 147229"},
        {"Wilson Evans Batten Catalogue", "WEB 311"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.39781584),
        dec: Angle.Degrees(-16.20752837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33904"},
        {"Hipparcos Number", "HIP 24305"},
        {"Fundamental Katalog 5th Edition", "FK5 1144"},
        {"Geneva Identification System", "GEN# +1.00033904"},
        {"Renson", "Renson 8640"},
        {"Smithsonian Astrophysical Observation", "SAO 150237"},
        {"Wilson Evans Batten Catalogue", "WEB 4714"},
    },
    visualMagnitude: 3.29,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.23280460),
        dec: Angle.Degrees(-16.20542901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19377"},
        {"Hipparcos Number", "HIP 14447"},
        {"Smithsonian Astrophysical Observation", "SAO 148770"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.61386615),
        dec: Angle.Degrees(-16.20210806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128924"},
        {"Hipparcos Number", "HIP 71713"},
        {"Smithsonian Astrophysical Observation", "SAO 158715"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.03527587),
        dec: Angle.Degrees(-16.20169453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58343"},
        {"Hipparcos Number", "HIP 35951"},
        {"Celescope Catalog", "CEL 1832"},
        {"Geneva Identification System", "GEN# +1.00058343"},
        {"Smithsonian Astrophysical Observation", "SAO 152834"},
        {"Wilson Evans Batten Catalogue", "WEB 7159"},
    },
    visualMagnitude: 5.18,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.16745993),
        dec: Angle.Degrees(-16.20142374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52244"},
        {"Hipparcos Number", "HIP 33676"},
        {"Celescope Catalog", "CEL 1484"},
        {"Geneva Identification System", "GEN# +1.00052244"},
        {"Smithsonian Astrophysical Observation", "SAO 152216"},
        {"Wilson Evans Batten Catalogue", "WEB 6767"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.94358281),
        dec: Angle.Degrees(-16.20075860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106456",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15080 AB"},
        {"Henry Draper", "HD 205132"},
        {"Hipparcos Number", "HIP 106456"},
        {"Geneva Identification System", "GEN# +1.00205132"},
        {"Smithsonian Astrophysical Observation", "SAO 164476"},
        {"Wilson Evans Batten Catalogue", "WEB 19271"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.41761310),
        dec: Angle.Degrees(-16.20070486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101199"},
        {"Hipparcos Number", "HIP 56801"},
        {"Smithsonian Astrophysical Observation", "SAO 156803"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.66538272),
        dec: Angle.Degrees(-16.19987590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82581"},
        {"Smithsonian Astrophysical Observation", "SAO 160143"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.23091713),
        dec: Angle.Degrees(-16.19832674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114642"},
        {"Hipparcos Number", "HIP 64407"},
        {"Geneva Identification System", "GEN# +1.00114642"},
        {"Smithsonian Astrophysical Observation", "SAO 157788"},
        {"Wilson Evans Batten Catalogue", "WEB 11384"},
    },
    visualMagnitude: 5.04,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.01451923),
        dec: Angle.Degrees(-16.19790340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -287.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26954"},
        {"Hipparcos Number", "HIP 19839"},
        {"Geneva Identification System", "GEN# +1.00026954"},
        {"Smithsonian Astrophysical Observation", "SAO 149489"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.80232386),
        dec: Angle.Degrees(-16.19653945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121550"},
        {"Hipparcos Number", "HIP 68090"},
        {"Geneva Identification System", "GEN# +1.00121550"},
        {"Smithsonian Astrophysical Observation", "SAO 158245"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.11330859),
        dec: Angle.Degrees(-16.19622339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -227.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207583"},
        {"Hipparcos Number", "HIP 107805"},
        {"Geneva Identification System", "GEN# +1.00207583"},
        {"Smithsonian Astrophysical Observation", "SAO 164689"},
        {"Wilson Evans Batten Catalogue", "WEB 19441"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.59646679),
        dec: Angle.Degrees(-16.19618759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156058"},
        {"Hipparcos Number", "HIP 84459"},
        {"Geneva Identification System", "GEN# +1.00156058"},
        {"Smithsonian Astrophysical Observation", "SAO 160410"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.99876356),
        dec: Angle.Degrees(-16.19592854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109085"},
        {"Hipparcos Number", "HIP 61174"},
        {"Celescope Catalog", "CEL 4119"},
        {"Cincinnati Publication", "Ci 20 714"},
        {"Geneva Identification System", "GEN# +1.00109085"},
        {"Smithsonian Astrophysical Observation", "SAO 157345"},
        {"Wilson Evans Batten Catalogue", "WEB 10892"},
    },
    visualMagnitude: 4.30,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.01868646),
        dec: Angle.Degrees(-16.19586556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -424.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6701"},
        {"Hipparcos Number", "HIP 5282"},
        {"Smithsonian Astrophysical Observation", "SAO 147619"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.89110858),
        dec: Angle.Degrees(-16.19469047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93813"},
        {"Hipparcos Number", "HIP 52943"},
        {"Fundamental Katalog 5th Edition", "FK5 410"},
        {"Geneva Identification System", "GEN# +1.00093813"},
        {"Smithsonian Astrophysical Observation", "SAO 156256"},
        {"Wilson Evans Batten Catalogue", "WEB 9633"},
    },
    visualMagnitude: 3.11,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.40596699),
        dec: Angle.Degrees(-16.19413208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 199.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48630",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7576 A"},
        {"Henry Draper", "HD 85949"},
        {"Hipparcos Number", "HIP 48630"},
        {"Fundamental Katalog 5th Edition", "FK5 4883"},
        {"Smithsonian Astrophysical Observation", "SAO 155592"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.75059574),
        dec: Angle.Degrees(-16.19391855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154116"},
        {"Hipparcos Number", "HIP 83514"},
        {"Geneva Identification System", "GEN# +1.00154116"},
        {"Smithsonian Astrophysical Observation", "SAO 160251"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.826,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.01282882),
        dec: Angle.Degrees(-16.19245034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -243.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170456"},
        {"Hipparcos Number", "HIP 90678"},
        {"Geneva Identification System", "GEN# +1.00170456"},
        {"Smithsonian Astrophysical Observation", "SAO 161539"},
        {"Wilson Evans Batten Catalogue", "WEB 15530"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.53238569),
        dec: Angle.Degrees(-16.19128513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147930"},
        {"Hipparcos Number", "HIP 80447"},
        {"Geneva Identification System", "GEN# +1.00147930"},
        {"Smithsonian Astrophysical Observation", "SAO 159906"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.31988584),
        dec: Angle.Degrees(-16.19071032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123307"},
        {"Hipparcos Number", "HIP 68970"},
        {"Geneva Identification System", "GEN# +1.00123307"},
        {"Smithsonian Astrophysical Observation", "SAO 158363"},
    },
    visualMagnitude: 7.28,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.80779511),
        dec: Angle.Degrees(-16.19045357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218678"},
        {"Hipparcos Number", "HIP 114394"},
        {"Smithsonian Astrophysical Observation", "SAO 165527"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.51890150),
        dec: Angle.Degrees(-16.18855739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60513"},
        {"Hipparcos Number", "HIP 36809"},
        {"Fundamental Katalog 5th Edition", "FK5 2588"},
        {"Geneva Identification System", "GEN# +1.00060513"},
        {"Smithsonian Astrophysical Observation", "SAO 153080"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.55502049),
        dec: Angle.Degrees(-16.18809032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 132.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8143"},
        {"Hipparcos Number", "HIP 6284"},
        {"Smithsonian Astrophysical Observation", "SAO 147748"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.15354345),
        dec: Angle.Degrees(-16.18808987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81998"},
        {"Hipparcos Number", "HIP 46487"},
        {"Smithsonian Astrophysical Observation", "SAO 155223"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.21908260),
        dec: Angle.Degrees(-16.18771309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34616"},
        {"Hipparcos Number", "HIP 24723"},
        {"Geneva Identification System", "GEN# +1.00034616"},
        {"Smithsonian Astrophysical Observation", "SAO 150319"},
        {"Wilson Evans Batten Catalogue", "WEB 4783"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.53719214),
        dec: Angle.Degrees(-16.18712905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68998"},
        {"Hipparcos Number", "HIP 40355"},
        {"Geneva Identification System", "GEN# +1.00068998"},
        {"Renson", "Renson 19120"},
        {"Smithsonian Astrophysical Observation", "SAO 154010"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.59030239),
        dec: Angle.Degrees(-16.18573898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31788"},
        {"Hipparcos Number", "HIP 23083"},
        {"Smithsonian Astrophysical Observation", "SAO 150036"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.51717021),
        dec: Angle.Degrees(-16.18521599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213004"},
        {"Hipparcos Number", "HIP 110942"},
        {"Smithsonian Astrophysical Observation", "SAO 165102"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.17474904),
        dec: Angle.Degrees(-16.18437013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117462",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117462"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.826,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.25436309),
        dec: Angle.Degrees(-16.18227455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26940"},
        {"Hipparcos Number", "HIP 19820"},
        {"Geneva Identification System", "GEN# +1.00026940"},
        {"Smithsonian Astrophysical Observation", "SAO 149487"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.75126431),
        dec: Angle.Degrees(-16.18065489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202890"},
        {"Hipparcos Number", "HIP 105256"},
        {"Geneva Identification System", "GEN# +1.00202890"},
        {"Smithsonian Astrophysical Observation", "SAO 164301"},
        {"Wilson Evans Batten Catalogue", "WEB 19116"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.81220656),
        dec: Angle.Degrees(-16.17946928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119605"},
        {"Hipparcos Number", "HIP 67057"},
        {"Fundamental Katalog 5th Edition", "FK5 1357"},
        {"Geneva Identification System", "GEN# +1.00119605"},
        {"Smithsonian Astrophysical Observation", "SAO 158131"},
        {"Wilson Evans Batten Catalogue", "WEB 11810"},
    },
    visualMagnitude: 5.55,
    bvColour: 0.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.12424684),
        dec: Angle.Degrees(-16.17905873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62530"},
        {"Hipparcos Number", "HIP 37688"},
        {"Geneva Identification System", "GEN# +1.00062530"},
        {"Renson", "Renson 17150"},
        {"Smithsonian Astrophysical Observation", "SAO 153319"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.98132916),
        dec: Angle.Degrees(-16.17810114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119131"},
        {"Hipparcos Number", "HIP 66811"},
        {"Smithsonian Astrophysical Observation", "SAO 158091"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.41960308),
        dec: Angle.Degrees(-16.17589475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5247"},
        {"Hipparcos Number", "HIP 4240"},
        {"Smithsonian Astrophysical Observation", "SAO 147507"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.52857045),
        dec: Angle.Degrees(-16.17527810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77334"},
        {"Smithsonian Astrophysical Observation", "SAO 159493"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.82166480),
        dec: Angle.Degrees(-16.17472008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219639"},
        {"Hipparcos Number", "HIP 114998"},
        {"Geneva Identification System", "GEN# +1.00219639"},
        {"Smithsonian Astrophysical Observation", "SAO 165607"},
    },
    visualMagnitude: 6.72,
    bvColour: -0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.36814490),
        dec: Angle.Degrees(-16.17218598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90014"},
        {"Hipparcos Number", "HIP 50854"},
        {"Smithsonian Astrophysical Observation", "SAO 155945"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.76297613),
        dec: Angle.Degrees(-16.16963785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32397"},
        {"Hipparcos Number", "HIP 23445"},
        {"Smithsonian Astrophysical Observation", "SAO 150092"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.59232617),
        dec: Angle.Degrees(-16.16822385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4803"},
        {"Hipparcos Number", "HIP 3895"},
        {"Smithsonian Astrophysical Observation", "SAO 147469"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.49250207),
        dec: Angle.Degrees(-16.16747640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183570"},
        {"Hipparcos Number", "HIP 95952"},
        {"Geneva Identification System", "GEN# +1.00183570"},
        {"Smithsonian Astrophysical Observation", "SAO 162703"},
        {"Wilson Evans Batten Catalogue", "WEB 16803"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.69474867),
        dec: Angle.Degrees(-16.16679134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98884"},
        {"Hipparcos Number", "HIP 55550"},
        {"Smithsonian Astrophysical Observation", "SAO 156636"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.67748032),
        dec: Angle.Degrees(-16.16620155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103059",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14377 AB"},
        {"Henry Draper", "HD 198730"},
        {"Hipparcos Number", "HIP 103059"},
        {"Smithsonian Astrophysical Observation", "SAO 163948"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.20679328),
        dec: Angle.Degrees(-16.16516960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22228"},
        {"Hipparcos Number", "HIP 16647"},
    },
    visualMagnitude: 10.37,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.55197615),
        dec: Angle.Degrees(-16.16407439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187082"},
        {"Hipparcos Number", "HIP 97460"},
        {"Smithsonian Astrophysical Observation", "SAO 163005"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.14130513),
        dec: Angle.Degrees(-16.16368449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174466"},
        {"Hipparcos Number", "HIP 92515"},
        {"Geneva Identification System", "GEN# +1.00174466"},
        {"Smithsonian Astrophysical Observation", "SAO 161908"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.81586801),
        dec: Angle.Degrees(-16.16160119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140836"},
        {"Hipparcos Number", "HIP 77250"},
        {"Smithsonian Astrophysical Observation", "SAO 159487"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.60011807),
        dec: Angle.Degrees(-16.16139089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201314"},
        {"Hipparcos Number", "HIP 104420"},
        {"Smithsonian Astrophysical Observation", "SAO 164175"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.29305272),
        dec: Angle.Degrees(-16.16014476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134700"},
        {"Hipparcos Number", "HIP 74367"},
        {"Smithsonian Astrophysical Observation", "SAO 159085"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.95827176),
        dec: Angle.Degrees(-16.15950480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25038",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25038"},
        {"Smithsonian Astrophysical Observation", "SAO 150374"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.42108842),
        dec: Angle.Degrees(-16.15835536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80776"},
        {"Smithsonian Astrophysical Observation", "SAO 159944"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.39150327),
        dec: Angle.Degrees(-16.15646007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162254"},
        {"Hipparcos Number", "HIP 87333"},
        {"Smithsonian Astrophysical Observation", "SAO 160854"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.67678016),
        dec: Angle.Degrees(-16.15431047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77200"},
        {"Hipparcos Number", "HIP 44238"},
        {"Geneva Identification System", "GEN# +1.00077200"},
        {"Smithsonian Astrophysical Observation", "SAO 154829"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.13906317),
        dec: Angle.Degrees(-16.15346006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213030"},
        {"Hipparcos Number", "HIP 110963"},
        {"Smithsonian Astrophysical Observation", "SAO 165107"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.22305928),
        dec: Angle.Degrees(-16.15200631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59406"},
        {"Hipparcos Number", "HIP 36372"},
        {"Smithsonian Astrophysical Observation", "SAO 152940"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.30232798),
        dec: Angle.Degrees(-16.15023476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9462"},
        {"Hipparcos Number", "HIP 7190"},
        {"Smithsonian Astrophysical Observation", "SAO 147876"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.15811342),
        dec: Angle.Degrees(-16.14840945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110212"},
        {"Hipparcos Number", "HIP 61866"},
        {"Fundamental Katalog 5th Edition", "FK5 5117"},
        {"Smithsonian Astrophysical Observation", "SAO 157443"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.17919808),
        dec: Angle.Degrees(-16.14675836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112504",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16265 AB"},
        {"Henry Draper", "HD 215696"},
        {"Hipparcos Number", "HIP 112504"},
        {"Cincinnati Publication", "Ci 18 2972"},
        {"Geneva Identification System", "GEN# +1.00215696J"},
        {"Smithsonian Astrophysical Observation", "SAO 165289"},
        {"Wilson Evans Batten Catalogue", "WEB 20061"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.83552566),
        dec: Angle.Degrees(-16.14622908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 366.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144523"},
        {"Hipparcos Number", "HIP 78941"},
        {"Smithsonian Astrophysical Observation", "SAO 159702"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.72129627),
        dec: Angle.Degrees(-16.14598878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79165"},
        {"Hipparcos Number", "HIP 45164"},
        {"Smithsonian Astrophysical Observation", "SAO 154990"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.01074435),
        dec: Angle.Degrees(-16.14500062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121423"},
        {"Hipparcos Number", "HIP 68007"},
        {"Smithsonian Astrophysical Observation", "SAO 158237"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.90362174),
        dec: Angle.Degrees(-16.14447291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220703"},
        {"Hipparcos Number", "HIP 115668"},
        {"Smithsonian Astrophysical Observation", "SAO 165687"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.50970851),
        dec: Angle.Degrees(-16.14230049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89088"},
        {"Hipparcos Number", "HIP 50306"},
        {"Smithsonian Astrophysical Observation", "SAO 155858"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.06808468),
        dec: Angle.Degrees(-16.14211309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171413"},
        {"Hipparcos Number", "HIP 91131"},
        {"Geneva Identification System", "GEN# +1.00171413"},
        {"Smithsonian Astrophysical Observation", "SAO 161636"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.83582066),
        dec: Angle.Degrees(-16.14063013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22992",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3556 B"},
        {"Hipparcos Number", "HIP 22992"},
    },
    visualMagnitude: 9.48,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)56, 48.7700),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)08, 24.500)
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
    primaryId: "HIP 3970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4908"},
        {"Hipparcos Number", "HIP 3970"},
        {"Smithsonian Astrophysical Observation", "SAO 147477"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.76566668),
        dec: Angle.Degrees(-16.14010221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44322"},
        {"Hipparcos Number", "HIP 30140"},
        {"Smithsonian Astrophysical Observation", "SAO 151376"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.14499419),
        dec: Angle.Degrees(-16.13788620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112209",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16215 AB"},
        {"Henry Draper", "HD 215166"},
        {"Hipparcos Number", "HIP 112209"},
        {"Wilson Evans Batten Catalogue", "WEB 20023"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.88459481),
        dec: Angle.Degrees(-16.13768347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54998"},
        {"Hipparcos Number", "HIP 34647"},
        {"Smithsonian Astrophysical Observation", "SAO 152508"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.63556781),
        dec: Angle.Degrees(-16.13763123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45663"},
        {"Hipparcos Number", "HIP 30782"},
        {"Smithsonian Astrophysical Observation", "SAO 151532"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.01447549),
        dec: Angle.Degrees(-16.13723453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22991",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3556 A"},
        {"Henry Draper", "HD 31636"},
        {"Hipparcos Number", "HIP 22991"},
        {"Smithsonian Astrophysical Observation", "SAO 150011"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.19961624),
        dec: Angle.Degrees(-16.13506171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9112"},
        {"Hipparcos Number", "HIP 6951"},
        {"Smithsonian Astrophysical Observation", "SAO 147839"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.37615591),
        dec: Angle.Degrees(-16.13487560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2141"},
        {"Hipparcos Number", "HIP 2014"},
        {"Cincinnati Publication", "Ci 18 45"},
        {"Geneva Identification System", "GEN# +1.00002141"},
        {"Smithsonian Astrophysical Observation", "SAO 147264"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.38611826),
        dec: Angle.Degrees(-16.13337986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 204.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76932"},
        {"Hipparcos Number", "HIP 44075"},
        {"Fundamental Katalog 5th Edition", "FK5 2713"},
        {"Geneva Identification System", "GEN# +1.00076932"},
        {"Smithsonian Astrophysical Observation", "SAO 154804"},
        {"Wilson Evans Batten Catalogue", "WEB 8470"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.68243659),
        dec: Angle.Degrees(-16.13324587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 244.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 213.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1242",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1242"},
        {"Geneva Identification System", "GEN# +9.80158050"},
    },
    visualMagnitude: 11.49,
    bvColour: 1.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.86528051),
        dec: Angle.Degrees(-16.13230661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 728.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -617.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12031"},
        {"Hipparcos Number", "HIP 9135"},
        {"Smithsonian Astrophysical Observation", "SAO 148128"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.44116917),
        dec: Angle.Degrees(-16.13212305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16020"},
        {"Hipparcos Number", "HIP 11937"},
        {"Smithsonian Astrophysical Observation", "SAO 148472"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.50927050),
        dec: Angle.Degrees(-16.13086580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7427"},
        {"Hipparcos Number", "HIP 5785"},
        {"Smithsonian Astrophysical Observation", "SAO 147688"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.54933162),
        dec: Angle.Degrees(-16.12985230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139517"},
        {"Hipparcos Number", "HIP 76647"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.77708206),
        dec: Angle.Degrees(-16.12876989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107556",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Deneb Algedi"},
        {"Aitken", "ADS 15314 A"},
        {"Henry Draper", "HD 207098"},
        {"Hipparcos Number", "HIP 107556"},
        {"Fundamental Katalog 5th Edition", "FK5 819"},
        {"Geneva Identification System", "GEN# +1.00207098"},
        {"Renson", "Renson 57630"},
        {"Smithsonian Astrophysical Observation", "SAO 164644"},
        {"Wilson Evans Batten Catalogue", "WEB 19412"},
    },
    visualMagnitude: 2.85,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.75952199),
        dec: Angle.Degrees(-16.12656595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 263.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -296.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13304"},
        {"Hipparcos Number", "HIP 10076"},
        {"Geneva Identification System", "GEN# +1.00013304"},
        {"Smithsonian Astrophysical Observation", "SAO 148244"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.40409069),
        dec: Angle.Degrees(-16.12626364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196857"},
        {"Hipparcos Number", "HIP 102026"},
        {"Geneva Identification System", "GEN# +1.00196857"},
        {"Smithsonian Astrophysical Observation", "SAO 163783"},
        {"Wilson Evans Batten Catalogue", "WEB 18446"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.13566467),
        dec: Angle.Degrees(-16.12435941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186005"},
        {"Hipparcos Number", "HIP 96950"},
        {"Fundamental Katalog 5th Edition", "FK5 1514"},
        {"Geneva Identification System", "GEN# +1.00186005"},
        {"Smithsonian Astrophysical Observation", "SAO 162915"},
        {"Wilson Evans Batten Catalogue", "WEB 17015"},
    },
    visualMagnitude: 5.06,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.62955250),
        dec: Angle.Degrees(-16.12397392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223585"},
        {"Hipparcos Number", "HIP 117587"},
        {"Smithsonian Astrophysical Observation", "SAO 165916"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.70736084),
        dec: Angle.Degrees(-16.12394876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62729"},
        {"Hipparcos Number", "HIP 37784"},
        {"Geneva Identification System", "GEN# +1.00062729"},
        {"Smithsonian Astrophysical Observation", "SAO 153341"},
        {"Wilson Evans Batten Catalogue", "WEB 7466"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.21982873),
        dec: Angle.Degrees(-16.12224001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149618"},
        {"Hipparcos Number", "HIP 81315"},
        {"Smithsonian Astrophysical Observation", "SAO 159997"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.11660925),
        dec: Angle.Degrees(-16.12066623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78178"},
        {"Hipparcos Number", "HIP 44681"},
        {"Smithsonian Astrophysical Observation", "SAO 154910"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.58887730),
        dec: Angle.Degrees(-16.11805657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103276"},
        {"Hipparcos Number", "HIP 57979"},
        {"Smithsonian Astrophysical Observation", "SAO 156966"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.39033389),
        dec: Angle.Degrees(-16.11490524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8560"},
        {"Smithsonian Astrophysical Observation", "SAO 148051"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.60575904),
        dec: Angle.Degrees(-16.11218276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126829"},
        {"Hipparcos Number", "HIP 70756"},
        {"Geneva Identification System", "GEN# +1.00126829"},
        {"Smithsonian Astrophysical Observation", "SAO 158583"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.05101092),
        dec: Angle.Degrees(-16.11009825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72665"},
        {"Hipparcos Number", "HIP 41992"},
        {"Smithsonian Astrophysical Observation", "SAO 154395"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.38964080),
        dec: Angle.Degrees(-16.10962674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217253"},
        {"Hipparcos Number", "HIP 113533"},
        {"Smithsonian Astrophysical Observation", "SAO 165424"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.90186800),
        dec: Angle.Degrees(-16.10927691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176186"},
        {"Hipparcos Number", "HIP 93249"},
        {"Smithsonian Astrophysical Observation", "SAO 162059"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.91046787),
        dec: Angle.Degrees(-16.10848371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116857"},
        {"Hipparcos Number", "HIP 65575"},
        {"Smithsonian Astrophysical Observation", "SAO 157936"},
        {"Wilson Evans Batten Catalogue", "WEB 11588"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.66905274),
        dec: Angle.Degrees(-16.10456757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31502",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5242 A"},
        {"Henry Draper", "HD 47011"},
        {"Hipparcos Number", "HIP 31502"},
        {"Celescope Catalog", "CEL 1313"},
        {"Geneva Identification System", "GEN# +1.00047011"},
        {"Smithsonian Astrophysical Observation", "SAO 151681"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.96178757),
        dec: Angle.Degrees(-16.10275871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29841"},
        {"Smithsonian Astrophysical Observation", "SAO 151312"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.24843905),
        dec: Angle.Degrees(-16.10271181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126131"},
        {"Hipparcos Number", "HIP 70379"},
        {"Fundamental Katalog 5th Edition", "FK5 3140"},
        {"Geneva Identification System", "GEN# +1.00126131"},
        {"Smithsonian Astrophysical Observation", "SAO 158539"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.99051134),
        dec: Angle.Degrees(-16.10189900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31500",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 7.37,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)35, 50.0500),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)06, 04.300)
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
    primaryId: "HIP 94635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180015"},
        {"Hipparcos Number", "HIP 94635"},
        {"Smithsonian Astrophysical Observation", "SAO 162370"},
        {"Wilson Evans Batten Catalogue", "WEB 16494"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.85882560),
        dec: Angle.Degrees(-16.09911710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16674"},
        {"Hipparcos Number", "HIP 12430"},
        {"Geneva Identification System", "GEN# +1.00016674"},
        {"Smithsonian Astrophysical Observation", "SAO 148533"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.00327238),
        dec: Angle.Degrees(-16.09719962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54786"},
        {"Hipparcos Number", "HIP 34569"},
        {"Geneva Identification System", "GEN# +1.00054786"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.40408450),
        dec: Angle.Degrees(-16.09633678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118100",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17121 A"},
        {"Henry Draper", "HD 224374"},
        {"Henry Draper 2", "HD 224374A"},
        {"Hipparcos Number", "HIP 118100"},
        {"Smithsonian Astrophysical Observation", "SAO 165968"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.34639332),
        dec: Angle.Degrees(-16.09569671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18489"},
        {"Smithsonian Astrophysical Observation", "SAO 149276"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.29444320),
        dec: Angle.Degrees(-16.09468854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59094"},
        {"Hipparcos Number", "HIP 36250"},
        {"Celescope Catalog", "CEL 1865"},
        {"Geneva Identification System", "GEN# +1.00059094"},
        {"Smithsonian Astrophysical Observation", "SAO 152911"},
        {"Wilson Evans Batten Catalogue", "WEB 7219"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.96252503),
        dec: Angle.Degrees(-16.09388011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144893"},
        {"Hipparcos Number", "HIP 79094"},
        {"Geneva Identification System", "GEN# +1.00144893"},
        {"Smithsonian Astrophysical Observation", "SAO 159730"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.17350263),
        dec: Angle.Degrees(-16.09328496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103576",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103576"},
    },
    visualMagnitude: 11.31,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.77766499),
        dec: Angle.Degrees(-16.09296866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -242.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92708"},
        {"Hipparcos Number", "HIP 52364"},
        {"Smithsonian Astrophysical Observation", "SAO 156166"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.53431111),
        dec: Angle.Degrees(-16.09175993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118101",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17121 B"},
        {"Henry Draper", "HD 224374B"},
        {"Hipparcos Number", "HIP 118101"},
    },
    visualMagnitude: 10.79,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.34693797),
        dec: Angle.Degrees(-16.09164653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202334"},
        {"Hipparcos Number", "HIP 104956"},
        {"Geneva Identification System", "GEN# +1.00202334"},
        {"Smithsonian Astrophysical Observation", "SAO 164262"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.89560721),
        dec: Angle.Degrees(-16.09112476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49984",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7682 A"},
        {"Henry Draper", "HD 88536"},
        {"Hipparcos Number", "HIP 49984"},
        {"Smithsonian Astrophysical Observation", "SAO 155811"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.07191764),
        dec: Angle.Degrees(-16.08645649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72928"},
        {"Hipparcos Number", "HIP 42108"},
        {"Geneva Identification System", "GEN# +1.00072928"},
    },
    visualMagnitude: 10.28,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.75202698),
        dec: Angle.Degrees(-16.08635605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49981",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7682 B"},
        {"Hipparcos Number", "HIP 49981"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.06860641),
        dec: Angle.Degrees(-16.08605018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147983"},
        {"Hipparcos Number", "HIP 80472"},
        {"Smithsonian Astrophysical Observation", "SAO 159909"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.39564596),
        dec: Angle.Degrees(-16.08493465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173224"},
        {"Hipparcos Number", "HIP 91976"},
        {"Smithsonian Astrophysical Observation", "SAO 161784"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.20854019),
        dec: Angle.Degrees(-16.08174792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124759"},
        {"Hipparcos Number", "HIP 69683"},
        {"Fundamental Katalog 5th Edition", "FK5 5260"},
        {"Smithsonian Astrophysical Observation", "SAO 158453"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.95937642),
        dec: Angle.Degrees(-16.08138592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207237"},
        {"Hipparcos Number", "HIP 107618"},
        {"Geneva Identification System", "GEN# +1.00207237"},
        {"Smithsonian Astrophysical Observation", "SAO 164659"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.95995883),
        dec: Angle.Degrees(-16.07963206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102196"},
        {"Hipparcos Number", "HIP 57366"},
        {"Geneva Identification System", "GEN# +1.00102196"},
        {"Smithsonian Astrophysical Observation", "SAO 156873"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.41034160),
        dec: Angle.Degrees(-16.07808812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23225"},
        {"Hipparcos Number", "HIP 17355"},
        {"Smithsonian Astrophysical Observation", "SAO 149129"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.72044199),
        dec: Angle.Degrees(-16.07586929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180511"},
        {"Hipparcos Number", "HIP 94803"},
        {"Smithsonian Astrophysical Observation", "SAO 162407"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.34935853),
        dec: Angle.Degrees(-16.07336507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13944"},
        {"Hipparcos Number", "HIP 10502"},
        {"Smithsonian Astrophysical Observation", "SAO 148292"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.84281983),
        dec: Angle.Degrees(-16.07180587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62202"},
        {"Hipparcos Number", "HIP 37542"},
        {"Smithsonian Astrophysical Observation", "SAO 153288"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.57867435),
        dec: Angle.Degrees(-16.06919205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27716",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27716"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.03628071),
        dec: Angle.Degrees(-16.06824643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -234.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18721"},
        {"Hipparcos Number", "HIP 13981"},
        {"Smithsonian Astrophysical Observation", "SAO 148709"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.02058587),
        dec: Angle.Degrees(-16.06669977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164104"},
        {"Hipparcos Number", "HIP 88145"},
        {"Geneva Identification System", "GEN# +1.00164104"},
        {"Smithsonian Astrophysical Observation", "SAO 160978"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.05340091),
        dec: Angle.Degrees(-16.06667642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31347"},
        {"Hipparcos Number", "HIP 22811"},
        {"Smithsonian Astrophysical Observation", "SAO 149979"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.61486402),
        dec: Angle.Degrees(-16.06549710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30157"},
        {"Hipparcos Number", "HIP 22052"},
        {"Geneva Identification System", "GEN# +1.00030157"},
        {"Smithsonian Astrophysical Observation", "SAO 149859"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.14089658),
        dec: Angle.Degrees(-16.06510966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120151"},
        {"Hipparcos Number", "HIP 67328"},
        {"Smithsonian Astrophysical Observation", "SAO 158172"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.99363041),
        dec: Angle.Degrees(-16.06499954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153316"},
        {"Hipparcos Number", "HIP 83139"},
        {"Smithsonian Astrophysical Observation", "SAO 160214"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.84704468),
        dec: Angle.Degrees(-16.06431508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41596"},
        {"Smithsonian Astrophysical Observation", "SAO 154299"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.20769695),
        dec: Angle.Degrees(-16.06333681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20479"},
        {"Hipparcos Number", "HIP 15287"},
        {"Smithsonian Astrophysical Observation", "SAO 148877"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.31187991),
        dec: Angle.Degrees(-16.06316827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22027",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22027"},
        {"Smithsonian Astrophysical Observation", "SAO 149855"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.03023689),
        dec: Angle.Degrees(-16.06295817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203706"},
        {"Hipparcos Number", "HIP 105684"},
        {"Smithsonian Astrophysical Observation", "SAO 164366"},
    },
    visualMagnitude: 8.70,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.08655031),
        dec: Angle.Degrees(-16.06219174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55884",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55884"},
        {"Geneva Identification System", "GEN# -0.01503267"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.81122110),
        dec: Angle.Degrees(-16.06179990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -186.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18298"},
        {"Hipparcos Number", "HIP 13661"},
        {"Smithsonian Astrophysical Observation", "SAO 148673"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.97727151),
        dec: Angle.Degrees(-16.05933825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19986"},
        {"Hipparcos Number", "HIP 14899"},
        {"Smithsonian Astrophysical Observation", "SAO 148831"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.06630278),
        dec: Angle.Degrees(-16.05836385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42886"},
        {"Hipparcos Number", "HIP 29473"},
        {"Smithsonian Astrophysical Observation", "SAO 151221"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.15112489),
        dec: Angle.Degrees(-16.05835999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173499"},
        {"Hipparcos Number", "HIP 92105"},
        {"Smithsonian Astrophysical Observation", "SAO 161810"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.57005290),
        dec: Angle.Degrees(-16.05578049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1077"},
        {"Hipparcos Number", "HIP 1201"},
        {"Geneva Identification System", "GEN# +1.00001077"},
        {"Smithsonian Astrophysical Observation", "SAO 147176"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.75564930),
        dec: Angle.Degrees(-16.05470664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51876"},
        {"Hipparcos Number", "HIP 33556"},
        {"Celescope Catalog", "CEL 1463"},
        {"Geneva Identification System", "GEN# +1.00051876"},
        {"Smithsonian Astrophysical Observation", "SAO 152182"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.60102635),
        dec: Angle.Degrees(-16.05462555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75667"},
        {"Hipparcos Number", "HIP 43436"},
        {"Smithsonian Astrophysical Observation", "SAO 154685"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.70057456),
        dec: Angle.Degrees(-16.05071862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18218"},
        {"Hipparcos Number", "HIP 13590"},
        {"Smithsonian Astrophysical Observation", "SAO 148665"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.78237330),
        dec: Angle.Degrees(-16.04716975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100537"},
        {"Hipparcos Number", "HIP 56418"},
        {"Smithsonian Astrophysical Observation", "SAO 156754"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.51568626),
        dec: Angle.Degrees(-16.04589486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61323"},
        {"Hipparcos Number", "HIP 37155"},
        {"Smithsonian Astrophysical Observation", "SAO 153180"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.53630934),
        dec: Angle.Degrees(-16.04435637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110823"},
        {"Hipparcos Number", "HIP 62211"},
        {"Geneva Identification System", "GEN# +1.00110823"},
        {"Smithsonian Astrophysical Observation", "SAO 157487"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.25866848),
        dec: Angle.Degrees(-16.04337818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41255"},
        {"Hipparcos Number", "HIP 28678"},
        {"Geneva Identification System", "GEN# +1.00041255"},
        {"Smithsonian Astrophysical Observation", "SAO 151066"},
        {"Wilson Evans Batten Catalogue", "WEB 5607"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.82485802),
        dec: Angle.Degrees(-16.04309794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27956"},
        {"Hipparcos Number", "HIP 20549"},
        {"Smithsonian Astrophysical Observation", "SAO 149609"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.04210011),
        dec: Angle.Degrees(-16.04170695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72622",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Zubenelgenubi"},
        {"Henry Draper", "HD 130841"},
        {"Hipparcos Number", "HIP 72622"},
        {"Fundamental Katalog 5th Edition", "FK5 548"},
        {"Geneva Identification System", "GEN# +1.00130841"},
        {"Renson", "Renson 37210"},
        {"Smithsonian Astrophysical Observation", "SAO 158840"},
        {"Wilson Evans Batten Catalogue", "WEB 12484"},
    },
    visualMagnitude: 2.75,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.71990536),
        dec: Angle.Degrees(-16.04161047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165673"},
        {"Hipparcos Number", "HIP 88806"},
        {"Smithsonian Astrophysical Observation", "SAO 161092"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.93217266),
        dec: Angle.Degrees(-16.04136938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82811"},
        {"Geneva Identification System", "GEN# -0.01504408"},
        {"Smithsonian Astrophysical Observation", "SAO 160164"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.86230648),
        dec: Angle.Degrees(-16.03949992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15909"},
        {"Hipparcos Number", "HIP 11860"},
        {"Smithsonian Astrophysical Observation", "SAO 148457"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.26574143),
        dec: Angle.Degrees(-16.03900273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211436"},
        {"Hipparcos Number", "HIP 110046"},
        {"Smithsonian Astrophysical Observation", "SAO 164982"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.34237917),
        dec: Angle.Degrees(-16.03850564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157379"},
        {"Hipparcos Number", "HIP 85105"},
        {"Geneva Identification System", "GEN# +1.00157379"},
        {"Smithsonian Astrophysical Observation", "SAO 160515"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.90089516),
        dec: Angle.Degrees(-16.03828534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73455"},
        {"Hipparcos Number", "HIP 42350"},
        {"Renson", "Renson 20390"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.51324453),
        dec: Angle.Degrees(-16.03758923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158374"},
        {"Hipparcos Number", "HIP 85600"},
        {"Smithsonian Astrophysical Observation", "SAO 160578"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.37336367),
        dec: Angle.Degrees(-16.03461063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78120",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9848 A"},
        {"Henry Draper", "HD 142804"},
        {"Hipparcos Number", "HIP 78120"},
        {"Geneva Identification System", "GEN# +1.00142804A"},
        {"Smithsonian Astrophysical Observation", "SAO 159598"},
        {"Wilson Evans Batten Catalogue", "WEB 13211"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.27167772),
        dec: Angle.Degrees(-16.03432762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42435",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6912 AB"},
        {"Henry Draper", "HD 73716"},
        {"Hipparcos Number", "HIP 42435"},
        {"Smithsonian Astrophysical Observation", "SAO 154503"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.79444063),
        dec: Angle.Degrees(-16.03266211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199443"},
        {"Hipparcos Number", "HIP 103460"},
        {"Fundamental Katalog 5th Edition", "FK5 1548"},
        {"Geneva Identification System", "GEN# +1.00199443"},
        {"Renson", "Renson 55580"},
        {"Smithsonian Astrophysical Observation", "SAO 164013"},
        {"Wilson Evans Batten Catalogue", "WEB 18820"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.41922341),
        dec: Angle.Degrees(-16.03154355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32811",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5503 AB"},
        {"Henry Draper", "HD 49978"},
        {"Hipparcos Number", "HIP 32811"},
        {"Celescope Catalog", "CEL 1403"},
        {"Geneva Identification System", "GEN# +1.00049978J"},
        {"Smithsonian Astrophysical Observation", "SAO 151994"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.59969065),
        dec: Angle.Degrees(-16.03039948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156519"},
        {"Hipparcos Number", "HIP 84675"},
        {"Smithsonian Astrophysical Observation", "SAO 160445"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.66337285),
        dec: Angle.Degrees(-16.02972576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84898"},
        {"Hipparcos Number", "HIP 48084"},
        {"Geneva Identification System", "GEN# +1.00084898"},
        {"Smithsonian Astrophysical Observation", "SAO 155494"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.04262616),
        dec: Angle.Degrees(-16.02967449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2078"},
        {"Hipparcos Number", "HIP 1967"},
        {"Smithsonian Astrophysical Observation", "SAO 147259"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.22399371),
        dec: Angle.Degrees(-16.02826415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61611"},
        {"Hipparcos Number", "HIP 37308"},
        {"Smithsonian Astrophysical Observation", "SAO 153207"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.89560607),
        dec: Angle.Degrees(-16.02719569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201644"},
        {"Hipparcos Number", "HIP 104600"},
        {"Geneva Identification System", "GEN# +1.00201644"},
        {"Smithsonian Astrophysical Observation", "SAO 164201"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.84313269),
        dec: Angle.Degrees(-16.02654343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195638"},
        {"Hipparcos Number", "HIP 101409"},
        {"Renson", "Renson 54515"},
        {"Smithsonian Astrophysical Observation", "SAO 163672"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.26995077),
        dec: Angle.Degrees(-16.02599984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125129"},
        {"Hipparcos Number", "HIP 69861"},
        {"Smithsonian Astrophysical Observation", "SAO 158472"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.45479725),
        dec: Angle.Degrees(-16.02579370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19887"},
        {"Hipparcos Number", "HIP 14814"},
        {"Geneva Identification System", "GEN# +1.00019887"},
        {"Smithsonian Astrophysical Observation", "SAO 148821"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.81976899),
        dec: Angle.Degrees(-16.02493952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168302"},
        {"Hipparcos Number", "HIP 89804"},
        {"Geneva Identification System", "GEN# +2.66180062"},
        {"Smithsonian Astrophysical Observation", "SAO 161334"},
        {"Wilson Evans Batten Catalogue", "WEB 15324"},
        {"New General Catalogue", "NGC 6618 62"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.91423474),
        dec: Angle.Degrees(-16.02231272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16912"},
        {"Hipparcos Number", "HIP 12630"},
        {"Geneva Identification System", "GEN# +1.00016912"},
        {"Renson", "Renson 4294"},
        {"Smithsonian Astrophysical Observation", "SAO 148558"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.57775032),
        dec: Angle.Degrees(-16.02143292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73282"},
        {"Hipparcos Number", "HIP 42271"},
        {"Smithsonian Astrophysical Observation", "SAO 154461"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.29012324),
        dec: Angle.Degrees(-16.01972163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19651"},
        {"Hipparcos Number", "HIP 14648"},
        {"Smithsonian Astrophysical Observation", "SAO 148795"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.32736878),
        dec: Angle.Degrees(-16.01875635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145698"},
        {"Hipparcos Number", "HIP 79450"},
        {"Smithsonian Astrophysical Observation", "SAO 159779"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.21032345),
        dec: Angle.Degrees(-16.01733873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9891"},
        {"Hipparcos Number", "HIP 7480"},
        {"Smithsonian Astrophysical Observation", "SAO 147904"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.08435459),
        dec: Angle.Degrees(-16.01660797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87098"},
        {"Hipparcos Number", "HIP 49199"},
        {"Renson", "Renson 24905"},
        {"Smithsonian Astrophysical Observation", "SAO 155679"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.62476140),
        dec: Angle.Degrees(-16.01613745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63323"},
        {"Hipparcos Number", "HIP 38037"},
        {"Geneva Identification System", "GEN# +1.00063323"},
        {"Smithsonian Astrophysical Observation", "SAO 153409"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.93838574),
        dec: Angle.Degrees(-16.01448125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35161"},
        {"Hipparcos Number", "HIP 25087"},
        {"Smithsonian Astrophysical Observation", "SAO 150382"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.56106445),
        dec: Angle.Degrees(-16.01399946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76954",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9751 AB"},
        {"Henry Draper", "HD 140164"},
        {"Hipparcos Number", "HIP 76954"},
        {"Geneva Identification System", "GEN# +1.00140164J"},
        {"Smithsonian Astrophysical Observation", "SAO 159453"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.69341767),
        dec: Angle.Degrees(-16.01357643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81731"},
        {"Hipparcos Number", "HIP 46350"},
        {"Smithsonian Astrophysical Observation", "SAO 155196"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.75353434),
        dec: Angle.Degrees(-16.01316254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81270"},
        {"Hipparcos Number", "HIP 46113"},
        {"Geneva Identification System", "GEN# +1.00081270"},
        {"Smithsonian Astrophysical Observation", "SAO 155151"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.06355147),
        dec: Angle.Degrees(-16.01307225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -231.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86593"},
        {"Hipparcos Number", "HIP 48947"},
        {"Smithsonian Astrophysical Observation", "SAO 155634"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.78560660),
        dec: Angle.Degrees(-16.01160165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46719"},
        {"Hipparcos Number", "HIP 31341"},
        {"Geneva Identification System", "GEN# +1.00046719"},
        {"Smithsonian Astrophysical Observation", "SAO 151652"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.58308683),
        dec: Angle.Degrees(-16.01097937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217932"},
        {"Hipparcos Number", "HIP 113930"},
        {"Smithsonian Astrophysical Observation", "SAO 165473"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.07163241),
        dec: Angle.Degrees(-16.00986792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13239"},
        {"Hipparcos Number", "HIP 10010"},
        {"Geneva Identification System", "GEN# +1.00013239"},
        {"Smithsonian Astrophysical Observation", "SAO 148238"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.23039092),
        dec: Angle.Degrees(-16.00960946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46956"},
        {"Hipparcos Number", "HIP 31472"},
        {"Geneva Identification System", "GEN# +1.00046956"},
        {"Smithsonian Astrophysical Observation", "SAO 151672"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.88888130),
        dec: Angle.Degrees(-16.00777091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32069",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5358 AB"},
        {"Henry Draper", "HD 48287"},
        {"Hipparcos Number", "HIP 32069"},
        {"Celescope Catalog", "CEL 1358"},
        {"Geneva Identification System", "GEN# +1.00048287J"},
        {"Smithsonian Astrophysical Observation", "SAO 151807"},
    },
    visualMagnitude: 6.94,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.49875180),
        dec: Angle.Degrees(-16.00722009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32774"},
        {"Hipparcos Number", "HIP 23646"},
        {"Smithsonian Astrophysical Observation", "SAO 150131"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.23736372),
        dec: Angle.Degrees(-16.00599976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206046"},
        {"Hipparcos Number", "HIP 106961"},
        {"Geneva Identification System", "GEN# +1.00206046"},
        {"Smithsonian Astrophysical Observation", "SAO 164558"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.95370481),
        dec: Angle.Degrees(-16.00583776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108599"},
        {"Hipparcos Number", "HIP 60881"},
        {"Smithsonian Astrophysical Observation", "SAO 157315"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.16190932),
        dec: Angle.Degrees(-16.00560411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135228"},
        {"Hipparcos Number", "HIP 74591"},
        {"Smithsonian Astrophysical Observation", "SAO 159120"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.61436279),
        dec: Angle.Degrees(-16.00438794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161523"},
        {"Hipparcos Number", "HIP 86992"},
        {"Geneva Identification System", "GEN# +1.00161523"},
        {"Smithsonian Astrophysical Observation", "SAO 160812"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.65141760),
        dec: Angle.Degrees(-16.00359940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210045"},
        {"Hipparcos Number", "HIP 109243"},
        {"Smithsonian Astrophysical Observation", "SAO 164873"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.96833523),
        dec: Angle.Degrees(-16.00145357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61826",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61826"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.06352091),
        dec: Angle.Degrees(-15.99930281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -222.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120999"},
        {"Hipparcos Number", "HIP 67784"},
        {"Geneva Identification System", "GEN# +1.00120999"},
        {"Smithsonian Astrophysical Observation", "SAO 158214"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.29969176),
        dec: Angle.Degrees(-15.99823879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10011"},
        {"Hipparcos Number", "HIP 7565"},
        {"Geneva Identification System", "GEN# +1.00010011"},
        {"Smithsonian Astrophysical Observation", "SAO 147916"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.35847696),
        dec: Angle.Degrees(-15.99773999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1525"},
        {"Smithsonian Astrophysical Observation", "SAO 147214"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.74602113),
        dec: Angle.Degrees(-15.99729066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130819"},
        {"Hipparcos Number", "HIP 72603"},
        {"Fundamental Katalog 5th Edition", "FK5 1387"},
        {"Geneva Identification System", "GEN# +1.00130819"},
        {"Smithsonian Astrophysical Observation", "SAO 158836"},
        {"Wilson Evans Batten Catalogue", "WEB 12481"},
    },
    visualMagnitude: 5.15,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.67193219),
        dec: Angle.Degrees(-15.99709226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84082"},
        {"Hipparcos Number", "HIP 47596"},
        {"Smithsonian Astrophysical Observation", "SAO 155417"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.57276427),
        dec: Angle.Degrees(-15.99649275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59711"},
        {"Henry Draper 2", "HD 59711A"},
        {"Hipparcos Number", "HIP 36512"},
        {"Geneva Identification System", "GEN# +1.00059711"},
        {"Smithsonian Astrophysical Observation", "SAO 152981"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.66660135),
        dec: Angle.Degrees(-15.99432149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26829"},
        {"Hipparcos Number", "HIP 19752"},
        {"Smithsonian Astrophysical Observation", "SAO 149472"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.51479370),
        dec: Angle.Degrees(-15.99312726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160789"},
        {"Hipparcos Number", "HIP 86669"},
        {"Smithsonian Astrophysical Observation", "SAO 160766"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.62130278),
        dec: Angle.Degrees(-15.99293106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63302"},
        {"Hipparcos Number", "HIP 38031"},
        {"Geneva Identification System", "GEN# +1.00063302"},
        {"Smithsonian Astrophysical Observation", "SAO 153404"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.91053163),
        dec: Angle.Degrees(-15.99069738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26054"},
        {"Hipparcos Number", "HIP 19204"},
        {"Geneva Identification System", "GEN# +1.00026054"},
        {"Smithsonian Astrophysical Observation", "SAO 149382"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.74545049),
        dec: Angle.Degrees(-15.98920320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33558"},
        {"Hipparcos Number", "HIP 24094"},
        {"Smithsonian Astrophysical Observation", "SAO 150197"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.63819169),
        dec: Angle.Degrees(-15.98764650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11652"},
        {"Hipparcos Number", "HIP 8863"},
        {"Smithsonian Astrophysical Observation", "SAO 148090"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.50673743),
        dec: Angle.Degrees(-15.98737462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149013"},
        {"Hipparcos Number", "HIP 81010"},
        {"Geneva Identification System", "GEN# +1.00149013"},
        {"Smithsonian Astrophysical Observation", "SAO 159971"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.15898740),
        dec: Angle.Degrees(-15.98720859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4492"},
        {"Hipparcos Number", "HIP 3659"},
        {"Smithsonian Astrophysical Observation", "SAO 147443"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.70838273),
        dec: Angle.Degrees(-15.98708501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74285"},
        {"Hipparcos Number", "HIP 42742"},
        {"Smithsonian Astrophysical Observation", "SAO 154564"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.66757401),
        dec: Angle.Degrees(-15.98606722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76962"},
        {"Hipparcos Number", "HIP 44096"},
        {"Smithsonian Astrophysical Observation", "SAO 154808"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.73073435),
        dec: Angle.Degrees(-15.98490030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119481"},
        {"Hipparcos Number", "HIP 66994"},
        {"Smithsonian Astrophysical Observation", "SAO 158119"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.94555997),
        dec: Angle.Degrees(-15.98410588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173745"},
        {"Hipparcos Number", "HIP 92205"},
        {"Cincinnati Publication", "Ci 18 2457"},
        {"Geneva Identification System", "GEN# +1.00173745"},
        {"Smithsonian Astrophysical Observation", "SAO 161826"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.87850163),
        dec: Angle.Degrees(-15.98350071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221282"},
        {"Hipparcos Number", "HIP 116051"},
        {"Geneva Identification System", "GEN# +1.00221282"},
        {"Smithsonian Astrophysical Observation", "SAO 165730"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.72610694),
        dec: Angle.Degrees(-15.98226926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223206"},
        {"Hipparcos Number", "HIP 117344"},
        {"Geneva Identification System", "GEN# +1.00223206"},
        {"Smithsonian Astrophysical Observation", "SAO 165884"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.89987967),
        dec: Angle.Degrees(-15.98163882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20027"},
        {"Hipparcos Number", "HIP 14941"},
        {"Smithsonian Astrophysical Observation", "SAO 148836"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.15644346),
        dec: Angle.Degrees(-15.98144565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211463"},
        {"Hipparcos Number", "HIP 110054"},
        {"Smithsonian Astrophysical Observation", "SAO 164984"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.36321923),
        dec: Angle.Degrees(-15.97976638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33648",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33648"},
        {"Smithsonian Astrophysical Observation", "SAO 152207"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.85545257),
        dec: Angle.Degrees(-15.97934912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9617"},
        {"Smithsonian Astrophysical Observation", "SAO 148175"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.90298534),
        dec: Angle.Degrees(-15.97786427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67771"},
        {"Hipparcos Number", "HIP 39895"},
        {"Smithsonian Astrophysical Observation", "SAO 153889"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.23296610),
        dec: Angle.Degrees(-15.97784717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203310"},
        {"Hipparcos Number", "HIP 105474"},
        {"Smithsonian Astrophysical Observation", "SAO 164336"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.45033495),
        dec: Angle.Degrees(-15.97713281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106299"},
        {"Hipparcos Number", "HIP 59637"},
        {"Smithsonian Astrophysical Observation", "SAO 157156"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.46332516),
        dec: Angle.Degrees(-15.97620226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13960"},
        {"Hipparcos Number", "HIP 10511"},
        {"Smithsonian Astrophysical Observation", "SAO 148294"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.86659914),
        dec: Angle.Degrees(-15.97609850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183430"},
        {"Hipparcos Number", "HIP 95884"},
        {"Smithsonian Astrophysical Observation", "SAO 162682"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.50895739),
        dec: Angle.Degrees(-15.97559689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116976"},
        {"Hipparcos Number", "HIP 65639"},
        {"Geneva Identification System", "GEN# +1.00116976"},
        {"Smithsonian Astrophysical Observation", "SAO 157946"},
        {"Wilson Evans Batten Catalogue", "WEB 11614"},
    },
    visualMagnitude: 4.76,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.86349201),
        dec: Angle.Degrees(-15.97363075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62653"},
        {"Hipparcos Number", "HIP 37754"},
        {"Smithsonian Astrophysical Observation", "SAO 153333"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.14726558),
        dec: Angle.Degrees(-15.97340780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206703"},
        {"Hipparcos Number", "HIP 107324"},
        {"Smithsonian Astrophysical Observation", "SAO 164615"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.07874020),
        dec: Angle.Degrees(-15.97154057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47615"},
        {"Hipparcos Number", "HIP 31799"},
        {"Smithsonian Astrophysical Observation", "SAO 151744"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.72796040),
        dec: Angle.Degrees(-15.96972931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188960"},
        {"Hipparcos Number", "HIP 98286"},
        {"Smithsonian Astrophysical Observation", "SAO 163146"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.54903782),
        dec: Angle.Degrees(-15.96957265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26549"},
        {"Hipparcos Number", "HIP 19562"},
        {"Smithsonian Astrophysical Observation", "SAO 149440"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.85668230),
        dec: Angle.Degrees(-15.96846815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158051"},
        {"Hipparcos Number", "HIP 85441"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.90575498),
        dec: Angle.Degrees(-15.96724291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94823",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12266"},
        {"Henry Draper", "HD 180562"},
        {"Hipparcos Number", "HIP 94823"},
        {"Geneva Identification System", "GEN# +1.00180562"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.41643589),
        dec: Angle.Degrees(-15.96709261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212292"},
        {"Hipparcos Number", "HIP 110537"},
        {"Smithsonian Astrophysical Observation", "SAO 165034"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.88771884),
        dec: Angle.Degrees(-15.96617222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151450"},
        {"Hipparcos Number", "HIP 82233"},
        {"Geneva Identification System", "GEN# +1.00151450"},
        {"Smithsonian Astrophysical Observation", "SAO 160101"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.00747576),
        dec: Angle.Degrees(-15.96372733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17303",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2707 AB"},
        {"Henry Draper", "HD 23145"},
        {"Hipparcos Number", "HIP 17303"},
        {"Smithsonian Astrophysical Observation", "SAO 149123"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.55721377),
        dec: Angle.Degrees(-15.96323850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83620"},
        {"Hipparcos Number", "HIP 47406"},
        {"Geneva Identification System", "GEN# +1.00083620"},
        {"Renson", "Renson 23840"},
        {"Smithsonian Astrophysical Observation", "SAO 155373"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.87622668),
        dec: Angle.Degrees(-15.96177782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54434",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8069 A"},
        {"Henry Draper", "HD 96712"},
        {"Hipparcos Number", "HIP 54434"},
        {"Geneva Identification System", "GEN# +1.00096712"},
        {"Smithsonian Astrophysical Observation", "SAO 156481"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.07244526),
        dec: Angle.Degrees(-15.96149947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208531"},
        {"Hipparcos Number", "HIP 108358"},
        {"Smithsonian Astrophysical Observation", "SAO 164763"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.27962829),
        dec: Angle.Degrees(-15.96134173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85722"},
        {"Hipparcos Number", "HIP 48488"},
        {"Smithsonian Astrophysical Observation", "SAO 155570"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.32540964),
        dec: Angle.Degrees(-15.96018968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32819",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32819"},
        {"Smithsonian Astrophysical Observation", "SAO 151997"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.61821292),
        dec: Angle.Degrees(-15.95909183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111911",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16160 AB"},
        {"Henry Draper", "HD 214688"},
        {"Hipparcos Number", "HIP 111911"},
        {"Smithsonian Astrophysical Observation", "SAO 165225"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.03381960),
        dec: Angle.Degrees(-15.95868547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4725"},
    },
    visualMagnitude: 11.80,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.16787348),
        dec: Angle.Degrees(-15.95761225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181615"},
        {"Henry Draper 2", "HD 181616"},
        {"Hipparcos Number", "HIP 95176"},
        {"Fundamental Katalog 5th Edition", "FK5 727"},
        {"Geneva Identification System", "GEN# +1.00181615J"},
        {"Renson", "Renson 50300"},
        {"Smithsonian Astrophysical Observation", "SAO 162518"},
        {"Wilson Evans Batten Catalogue", "WEB 16625"},
    },
    visualMagnitude: 4.52,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.43175842),
        dec: Angle.Degrees(-15.95500233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180695"},
        {"Hipparcos Number", "HIP 94855"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.52308537),
        dec: Angle.Degrees(-15.95373805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38577"},
        {"Hipparcos Number", "HIP 27232"},
        {"Smithsonian Astrophysical Observation", "SAO 150790"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.56745314),
        dec: Angle.Degrees(-15.95290592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103579"},
        {"Hipparcos Number", "HIP 58152"},
        {"Smithsonian Astrophysical Observation", "SAO 156983"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.88421316),
        dec: Angle.Degrees(-15.95276536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -195.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6708"},
        {"Hipparcos Number", "HIP 5295"},
        {"Geneva Identification System", "GEN# +1.00006708"},
        {"Smithsonian Astrophysical Observation", "SAO 147624"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.93653509),
        dec: Angle.Degrees(-15.94954279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 268.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171662"},
        {"Hipparcos Number", "HIP 91251"},
        {"Smithsonian Astrophysical Observation", "SAO 161660"},
        {"Wilson Evans Batten Catalogue", "WEB 15676"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.19798954),
        dec: Angle.Degrees(-15.94546240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42662",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6937 A"},
        {"Henry Draper", "HD 74137"},
        {"Hipparcos Number", "HIP 42662"},
        {"Fundamental Katalog 5th Edition", "FK5 2684"},
        {"Geneva Identification System", "GEN# +1.00074137"},
        {"Smithsonian Astrophysical Observation", "SAO 154552"},
        {"Wilson Evans Batten Catalogue", "WEB 8237"},
    },
    visualMagnitude: 4.87,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.43055822),
        dec: Angle.Degrees(-15.94314865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1879"},
        {"Hipparcos Number", "HIP 1821"},
        {"Geneva Identification System", "GEN# +1.00001879"},
        {"Smithsonian Astrophysical Observation", "SAO 147241"},
        {"Wilson Evans Batten Catalogue", "WEB 325"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.76813086),
        dec: Angle.Degrees(-15.94261714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210393"},
        {"Hipparcos Number", "HIP 109444"},
        {"Smithsonian Astrophysical Observation", "SAO 164906"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.58971946),
        dec: Angle.Degrees(-15.94074790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10700"},
        {"Hipparcos Number", "HIP 8102"},
        {"Cincinnati Publication", "Ci 20 124"},
        {"Fundamental Katalog 5th Edition", "FK5 59"},
        {"Geneva Identification System", "GEN# +1.00010700"},
        {"Smithsonian Astrophysical Observation", "SAO 147986"},
        {"Wilson Evans Batten Catalogue", "WEB 1733"},
    },
    visualMagnitude: 3.49,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.02136441),
        dec: Angle.Degrees(-15.93955597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1721.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 854.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158960"},
        {"Hipparcos Number", "HIP 85860"},
        {"Smithsonian Astrophysical Observation", "SAO 160623"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.18455658),
        dec: Angle.Degrees(-15.93492503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54575"},
        {"Hipparcos Number", "HIP 34485"},
        {"Geneva Identification System", "GEN# +1.00054575"},
        {"Smithsonian Astrophysical Observation", "SAO 152458"},
        {"Wilson Evans Batten Catalogue", "WEB 6908"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.19764438),
        dec: Angle.Degrees(-15.93414921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132817"},
        {"Hipparcos Number", "HIP 73517"},
        {"Smithsonian Astrophysical Observation", "SAO 158976"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.39190199),
        dec: Angle.Degrees(-15.93411118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154230"},
        {"Hipparcos Number", "HIP 83577"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.21169946),
        dec: Angle.Degrees(-15.93304748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170904"},
        {"Hipparcos Number", "HIP 90897"},
        {"Smithsonian Astrophysical Observation", "SAO 161583"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.11376001),
        dec: Angle.Degrees(-15.93201753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116319"},
        {"Hipparcos Number", "HIP 65310"},
        {"Smithsonian Astrophysical Observation", "SAO 157903"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.77882389),
        dec: Angle.Degrees(-15.92807034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95653"},
        {"Hipparcos Number", "HIP 53942"},
        {"Smithsonian Astrophysical Observation", "SAO 156414"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.56011820),
        dec: Angle.Degrees(-15.92724390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -252.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 144.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178924"},
        {"Hipparcos Number", "HIP 94248"},
        {"Smithsonian Astrophysical Observation", "SAO 162280"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.77328836),
        dec: Angle.Degrees(-15.92033346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66904"},
        {"Hipparcos Number", "HIP 39560"},
        {"Geneva Identification System", "GEN# +1.00066904"},
        {"Smithsonian Astrophysical Observation", "SAO 153802"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.25819309),
        dec: Angle.Degrees(-15.91875693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21293",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21293"},
        {"Smithsonian Astrophysical Observation", "SAO 149734"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.52932854),
        dec: Angle.Degrees(-15.91832570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90667"},
        {"Hipparcos Number", "HIP 51231"},
        {"Geneva Identification System", "GEN# +1.00090667"},
        {"Smithsonian Astrophysical Observation", "SAO 156000"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.95867477),
        dec: Angle.Degrees(-15.91823839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19512"},
        {"Smithsonian Astrophysical Observation", "SAO 149433"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.70237686),
        dec: Angle.Degrees(-15.91708074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41061"},
        {"Geneva Identification System", "GEN# -0.01502405"},
        {"Wilson Evans Batten Catalogue", "WEB 7955"},
    },
    visualMagnitude: 8.79,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.68400664),
        dec: Angle.Degrees(-15.91650136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11368"},
        {"Hipparcos Number", "HIP 8638"},
        {"Smithsonian Astrophysical Observation", "SAO 148058"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.85117146),
        dec: Angle.Degrees(-15.91647839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2694"},
        {"Hipparcos Number", "HIP 2386"},
        {"Geneva Identification System", "GEN# +1.00002694"},
        {"Smithsonian Astrophysical Observation", "SAO 147312"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.61102844),
        dec: Angle.Degrees(-15.91532980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156036"},
        {"Hipparcos Number", "HIP 84450"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.97796080),
        dec: Angle.Degrees(-15.91505737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118983"},
        {"Hipparcos Number", "HIP 66743"},
        {"Smithsonian Astrophysical Observation", "SAO 158083"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.19786399),
        dec: Angle.Degrees(-15.91420579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77825"},
        {"Hipparcos Number", "HIP 44526"},
        {"Geneva Identification System", "GEN# +1.00077825"},
        {"Smithsonian Astrophysical Observation", "SAO 154881"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.08649723),
        dec: Angle.Degrees(-15.91417598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155844"},
        {"Hipparcos Number", "HIP 84351"},
        {"Smithsonian Astrophysical Observation", "SAO 160396"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.67690222),
        dec: Angle.Degrees(-15.91371972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188220"},
        {"Hipparcos Number", "HIP 97972"},
        {"Geneva Identification System", "GEN# +1.00188220"},
        {"Smithsonian Astrophysical Observation", "SAO 163099"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.67063249),
        dec: Angle.Degrees(-15.91358866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209448"},
        {"Hipparcos Number", "HIP 108918"},
        {"Smithsonian Astrophysical Observation", "SAO 164839"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.94082599),
        dec: Angle.Degrees(-15.91350807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14255"},
        {"Hipparcos Number", "HIP 10719"},
        {"Smithsonian Astrophysical Observation", "SAO 148316"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.50037326),
        dec: Angle.Degrees(-15.91174617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36236"},
        {"Hipparcos Number", "HIP 25734"},
        {"Smithsonian Astrophysical Observation", "SAO 150496"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.42965917),
        dec: Angle.Degrees(-15.90957171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95474",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95474"},
        {"Smithsonian Astrophysical Observation", "SAO 162591"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.31084841),
        dec: Angle.Degrees(-15.90937616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197198"},
        {"Hipparcos Number", "HIP 102222"},
        {"Smithsonian Astrophysical Observation", "SAO 163816"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.69042281),
        dec: Angle.Degrees(-15.90877198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180953"},
        {"Hipparcos Number", "HIP 94940"},
        {"Geneva Identification System", "GEN# +1.00180953"},
        {"Smithsonian Astrophysical Observation", "SAO 162465"},
        {"Wilson Evans Batten Catalogue", "WEB 16578"},
    },
    visualMagnitude: 6.86,
    bvColour: 2.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.78994895),
        dec: Angle.Degrees(-15.90832993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194581"},
        {"Hipparcos Number", "HIP 100855"},
        {"Geneva Identification System", "GEN# +1.00194581"},
        {"Smithsonian Astrophysical Observation", "SAO 163579"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.74031029),
        dec: Angle.Degrees(-15.90813424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8999"},
        {"Hipparcos Number", "HIP 6870"},
        {"Smithsonian Astrophysical Observation", "SAO 147825"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.10258458),
        dec: Angle.Degrees(-15.90756083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217080"},
        {"Hipparcos Number", "HIP 113417"},
        {"Geneva Identification System", "GEN# +1.00217080"},
        {"Smithsonian Astrophysical Observation", "SAO 165411"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.54513023),
        dec: Angle.Degrees(-15.90594743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18206"},
        {"Hipparcos Number", "HIP 13583"},
        {"Smithsonian Astrophysical Observation", "SAO 148664"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.74588503),
        dec: Angle.Degrees(-15.90535174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121910"},
        {"Hipparcos Number", "HIP 68293"},
        {"Smithsonian Astrophysical Observation", "SAO 158270"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.69327098),
        dec: Angle.Degrees(-15.90503082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42074"},
        {"Hipparcos Number", "HIP 29083"},
        {"Geneva Identification System", "GEN# +1.00042074"},
        {"Smithsonian Astrophysical Observation", "SAO 151148"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.02683035),
        dec: Angle.Degrees(-15.90115596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215145"},
        {"Hipparcos Number", "HIP 112192"},
        {"Smithsonian Astrophysical Observation", "SAO 165250"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.84307832),
        dec: Angle.Degrees(-15.89681440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10785"},
        {"Hipparcos Number", "HIP 8188"},
        {"Cincinnati Publication", "Ci 18 242"},
        {"Geneva Identification System", "GEN# +1.00010785"},
        {"Smithsonian Astrophysical Observation", "SAO 147997"},
        {"Wilson Evans Batten Catalogue", "WEB 1744"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.31749715),
        dec: Angle.Degrees(-15.89525017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 280.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86264"},
        {"Hipparcos Number", "HIP 48780"},
        {"Geneva Identification System", "GEN# +1.00086264"},
        {"Smithsonian Astrophysical Observation", "SAO 155612"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.24102963),
        dec: Angle.Degrees(-15.89496075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166417"},
        {"Hipparcos Number", "HIP 89107"},
        {"Smithsonian Astrophysical Observation", "SAO 161154"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.79455814),
        dec: Angle.Degrees(-15.89487687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14000"},
        {"Hipparcos Number", "HIP 10545"},
        {"Smithsonian Astrophysical Observation", "SAO 148299"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.95595766),
        dec: Angle.Degrees(-15.89269898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42460"},
        {"Hipparcos Number", "HIP 29270"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.55598730),
        dec: Angle.Degrees(-15.89255134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122487"},
        {"Hipparcos Number", "HIP 68606"},
        {"Smithsonian Astrophysical Observation", "SAO 158301"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.64591039),
        dec: Angle.Degrees(-15.89129093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202669"},
        {"Hipparcos Number", "HIP 105131"},
        {"Geneva Identification System", "GEN# +1.00202669"},
        {"Smithsonian Astrophysical Observation", "SAO 164285"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.46513924),
        dec: Angle.Degrees(-15.89103887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26297"},
        {"Hipparcos Number", "HIP 19378"},
        {"Geneva Identification System", "GEN# +1.00026297"},
        {"Smithsonian Astrophysical Observation", "SAO 149407"},
        {"Wilson Evans Batten Catalogue", "WEB 3721"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.26412853),
        dec: Angle.Degrees(-15.89084033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88562"},
        {"Hipparcos Number", "HIP 50006"},
        {"Geneva Identification System", "GEN# +1.00088562"},
        {"Smithsonian Astrophysical Observation", "SAO 155816"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.12476528),
        dec: Angle.Degrees(-15.88974438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225226"},
        {"Hipparcos Number", "HIP 364"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.15203505),
        dec: Angle.Degrees(-15.88920125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146255"},
        {"Hipparcos Number", "HIP 79696"},
        {"Smithsonian Astrophysical Observation", "SAO 159822"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.97374926),
        dec: Angle.Degrees(-15.88764218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189437"},
        {"Hipparcos Number", "HIP 98488"},
        {"Geneva Identification System", "GEN# +1.00189437"},
        {"Smithsonian Astrophysical Observation", "SAO 163173"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.12455071),
        dec: Angle.Degrees(-15.88688524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111210",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111210"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.94833351),
        dec: Angle.Degrees(-15.88580977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 217.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152156"},
        {"Hipparcos Number", "HIP 82536"},
        {"Geneva Identification System", "GEN# +1.00152156"},
        {"Smithsonian Astrophysical Observation", "SAO 160135"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.06283884),
        dec: Angle.Degrees(-15.88301349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111500"},
        {"Hipparcos Number", "HIP 62610"},
        {"Smithsonian Astrophysical Observation", "SAO 157535"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.44033226),
        dec: Angle.Degrees(-15.88296532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85382"},
        {"Hipparcos Number", "HIP 48318"},
        {"Smithsonian Astrophysical Observation", "SAO 155529"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.74764560),
        dec: Angle.Degrees(-15.87962652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178269"},
        {"Hipparcos Number", "HIP 94016"},
        {"Smithsonian Astrophysical Observation", "SAO 162231"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.12099300),
        dec: Angle.Degrees(-15.87861922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4823"},
        {"Hipparcos Number", "HIP 3918"},
        {"Smithsonian Astrophysical Observation", "SAO 147472"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.56842643),
        dec: Angle.Degrees(-15.87855703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189827"},
        {"Hipparcos Number", "HIP 98676"},
        {"Smithsonian Astrophysical Observation", "SAO 163200"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.63836168),
        dec: Angle.Degrees(-15.87430276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10100"},
        {"Hipparcos Number", "HIP 7639"},
        {"Smithsonian Astrophysical Observation", "SAO 147921"},
        {"Wilson Evans Batten Catalogue", "WEB 1633"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.60673341),
        dec: Angle.Degrees(-15.87191301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71811"},
        {"Hipparcos Number", "HIP 41609"},
        {"Geneva Identification System", "GEN# +1.00071811"},
        {"Smithsonian Astrophysical Observation", "SAO 154301"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.23564630),
        dec: Angle.Degrees(-15.87013642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38508"},
        {"Hipparcos Number", "HIP 27185"},
        {"Smithsonian Astrophysical Observation", "SAO 150778"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.42481611),
        dec: Angle.Degrees(-15.86983105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187625"},
        {"Hipparcos Number", "HIP 97715"},
        {"Smithsonian Astrophysical Observation", "SAO 163045"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.87308502),
        dec: Angle.Degrees(-15.86851827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37664"},
        {"Hipparcos Number", "HIP 26628"},
        {"Smithsonian Astrophysical Observation", "SAO 150657"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.89412684),
        dec: Angle.Degrees(-15.86811233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154035"},
        {"Hipparcos Number", "HIP 83479"},
        {"Smithsonian Astrophysical Observation", "SAO 160248"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.91621016),
        dec: Angle.Degrees(-15.86604967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191640"},
        {"Hipparcos Number", "HIP 99491"},
        {"Smithsonian Astrophysical Observation", "SAO 163324"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.86210735),
        dec: Angle.Degrees(-15.86513194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70536"},
        {"Hipparcos Number", "HIP 40996"},
        {"Smithsonian Astrophysical Observation", "SAO 154162"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.49527755),
        dec: Angle.Degrees(-15.86378026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102845"},
        {"Hipparcos Number", "HIP 57732"},
        {"Geneva Identification System", "GEN# +1.00102845"},
        {"Smithsonian Astrophysical Observation", "SAO 156926"},
    },
    visualMagnitude: 6.13,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.58168578),
        dec: Angle.Degrees(-15.86370603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25370"},
        {"Hipparcos Number", "HIP 18768"},
        {"Geneva Identification System", "GEN# +1.00025370"},
        {"Smithsonian Astrophysical Observation", "SAO 149318"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.30353179),
        dec: Angle.Degrees(-15.86297484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33919"},
        {"Hipparcos Number", "HIP 24312"},
        {"Geneva Identification System", "GEN# +1.00033919"},
        {"Smithsonian Astrophysical Observation", "SAO 150238"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.26170454),
        dec: Angle.Degrees(-15.86279231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64432"},
        {"Hipparcos Number", "HIP 38520"},
        {"Smithsonian Astrophysical Observation", "SAO 153547"},
    },
    visualMagnitude: 8.64,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.32952970),
        dec: Angle.Degrees(-15.86262283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223428"},
        {"Hipparcos Number", "HIP 117494"},
        {"Geneva Identification System", "GEN# +1.00223428"},
        {"Smithsonian Astrophysical Observation", "SAO 165905"},
    },
    visualMagnitude: 6.21,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.38157430),
        dec: Angle.Degrees(-15.86120258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99669"},
        {"Hipparcos Number", "HIP 55937"},
        {"Fundamental Katalog 5th Edition", "FK5 5010"},
        {"Smithsonian Astrophysical Observation", "SAO 156693"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.96046020),
        dec: Angle.Degrees(-15.86001586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176079"},
        {"Hipparcos Number", "HIP 93202"},
        {"Smithsonian Astrophysical Observation", "SAO 162044"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.77282844),
        dec: Angle.Degrees(-15.86001405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218947"},
        {"Hipparcos Number", "HIP 114556"},
        {"Smithsonian Astrophysical Observation", "SAO 165552"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.06891867),
        dec: Angle.Degrees(-15.85891539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193104"},
        {"Hipparcos Number", "HIP 100154"},
        {"Smithsonian Astrophysical Observation", "SAO 163437"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.73823096),
        dec: Angle.Degrees(-15.85775506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172694"},
        {"Hipparcos Number", "HIP 91725"},
        {"Geneva Identification System", "GEN# +1.00172694"},
        {"Wilson Evans Batten Catalogue", "WEB 15775"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.56904851),
        dec: Angle.Degrees(-15.85578080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192468"},
        {"Hipparcos Number", "HIP 99854"},
        {"Geneva Identification System", "GEN# +1.00192468"},
        {"Smithsonian Astrophysical Observation", "SAO 163389"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.87758589),
        dec: Angle.Degrees(-15.85559036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208447"},
        {"Hipparcos Number", "HIP 108309"},
        {"Geneva Identification System", "GEN# +1.00208447"},
        {"Smithsonian Astrophysical Observation", "SAO 164754"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.13208281),
        dec: Angle.Degrees(-15.85504114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223737"},
        {"Hipparcos Number", "HIP 117703"},
        {"Smithsonian Astrophysical Observation", "SAO 165928"},
        {"Wilson Evans Batten Catalogue", "WEB 20713"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.06089542),
        dec: Angle.Degrees(-15.85458619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31932",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5324 AB"},
        {"Henry Draper", "HD 47940"},
        {"Hipparcos Number", "HIP 31932"},
        {"Smithsonian Astrophysical Observation", "SAO 151778"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.10074178),
        dec: Angle.Degrees(-15.85351649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157969"},
        {"Hipparcos Number", "HIP 85405"},
        {"Smithsonian Astrophysical Observation", "SAO 160554"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.79118923),
        dec: Angle.Degrees(-15.85333977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21813"},
        {"Hipparcos Number", "HIP 16331"},
        {"Smithsonian Astrophysical Observation", "SAO 148995"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.62921859),
        dec: Angle.Degrees(-15.85312732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199295"},
        {"Hipparcos Number", "HIP 103386"},
        {"Smithsonian Astrophysical Observation", "SAO 163997"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.19086581),
        dec: Angle.Degrees(-15.85129130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 233"},
        {"Hipparcos Number", "HIP 584"},
        {"Geneva Identification System", "GEN# +1.00000233"},
        {"Smithsonian Astrophysical Observation", "SAO 147089"},
        {"Wilson Evans Batten Catalogue", "WEB 101"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.78153664),
        dec: Angle.Degrees(-15.85008750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59629"},
        {"Hipparcos Number", "HIP 36472"},
        {"Smithsonian Astrophysical Observation", "SAO 152973"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.57597645),
        dec: Angle.Degrees(-15.84960848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201846"},
        {"Hipparcos Number", "HIP 104713"},
        {"Geneva Identification System", "GEN# +1.00201846"},
        {"Smithsonian Astrophysical Observation", "SAO 164217"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.17268114),
        dec: Angle.Degrees(-15.84842355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224481"},
        {"Hipparcos Number", "HIP 118178"},
        {"Fundamental Katalog 5th Edition", "FK5 3925"},
        {"Geneva Identification System", "GEN# +1.00224481"},
        {"Smithsonian Astrophysical Observation", "SAO 165972"},
        {"Wilson Evans Batten Catalogue", "WEB 20775"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.58822629),
        dec: Angle.Degrees(-15.84746438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94125"},
        {"Hipparcos Number", "HIP 53088"},
        {"Smithsonian Astrophysical Observation", "SAO 156279"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.91523570),
        dec: Angle.Degrees(-15.84699101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34865"},
        {"Hipparcos Number", "HIP 24874"},
        {"Geneva Identification System", "GEN# +1.00034865"},
        {"Smithsonian Astrophysical Observation", "SAO 150347"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.99779615),
        dec: Angle.Degrees(-15.84014212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 204.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46430"},
        {"Hipparcos Number", "HIP 31194"},
        {"Smithsonian Astrophysical Observation", "SAO 151624"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.16754354),
        dec: Angle.Degrees(-15.83871817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13831",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2247 AB"},
        {"Henry Draper", "HD 18498"},
        {"Hipparcos Number", "HIP 13831"},
        {"Smithsonian Astrophysical Observation", "SAO 148689"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.50971986),
        dec: Angle.Degrees(-15.83855879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 140.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72173"},
        {"Hipparcos Number", "HIP 41757"},
        {"Smithsonian Astrophysical Observation", "SAO 154340"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.72292437),
        dec: Angle.Degrees(-15.83467909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45743",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7302 A"},
        {"Henry Draper", "HD 80479"},
        {"Hipparcos Number", "HIP 45743"},
        {"Geneva Identification System", "GEN# +1.00080479"},
        {"Smithsonian Astrophysical Observation", "SAO 155091"},
        {"Wilson Evans Batten Catalogue", "WEB 8678"},
    },
    visualMagnitude: 5.79,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.88796486),
        dec: Angle.Degrees(-15.83453443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48518"},
        {"Hipparcos Number", "HIP 32186"},
        {"Smithsonian Astrophysical Observation", "SAO 151838"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.80201177),
        dec: Angle.Degrees(-15.83343159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199946"},
        {"Hipparcos Number", "HIP 103697"},
        {"Smithsonian Astrophysical Observation", "SAO 164060"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.19262339),
        dec: Angle.Degrees(-15.83285627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168415"},
        {"Hipparcos Number", "HIP 89851"},
        {"Geneva Identification System", "GEN# +1.00168415"},
        {"Smithsonian Astrophysical Observation", "SAO 161348"},
        {"Wilson Evans Batten Catalogue", "WEB 15335"},
    },
    visualMagnitude: 5.39,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.03653519),
        dec: Angle.Degrees(-15.83160305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225005"},
        {"Hipparcos Number", "HIP 203"},
        {"Smithsonian Astrophysical Observation", "SAO 147052"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.64222918),
        dec: Angle.Degrees(-15.83126945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159528"},
        {"Hipparcos Number", "HIP 86104"},
        {"Smithsonian Astrophysical Observation", "SAO 160672"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.95485569),
        dec: Angle.Degrees(-15.83085014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61649"},
        {"Hipparcos Number", "HIP 37321"},
        {"Smithsonian Astrophysical Observation", "SAO 153211"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.93024460),
        dec: Angle.Degrees(-15.82783637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192823"},
        {"Hipparcos Number", "HIP 100014"},
        {"Geneva Identification System", "GEN# +1.00192823"},
        {"Smithsonian Astrophysical Observation", "SAO 163418"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.36164936),
        dec: Angle.Degrees(-15.82763144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193726"},
        {"Hipparcos Number", "HIP 100463"},
        {"Geneva Identification System", "GEN# +1.00193726"},
        {"Smithsonian Astrophysical Observation", "SAO 163500"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.59189782),
        dec: Angle.Degrees(-15.82753246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3478"},
        {"Hipparcos Number", "HIP 2956"},
        {"Smithsonian Astrophysical Observation", "SAO 147373"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.38750631),
        dec: Angle.Degrees(-15.82745335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34101"},
        {"Hipparcos Number", "HIP 24419"},
        {"Cincinnati Publication", "Ci 18 677"},
        {"Geneva Identification System", "GEN# +1.00034101"},
        {"Smithsonian Astrophysical Observation", "SAO 150263"},
        {"Wilson Evans Batten Catalogue", "WEB 4730"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.58306312),
        dec: Angle.Degrees(-15.82608507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -224.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184208"},
        {"Hipparcos Number", "HIP 96212"},
        {"Smithsonian Astrophysical Observation", "SAO 162764"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.46025898),
        dec: Angle.Degrees(-15.82428685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113136",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Skat"},
        {"Henry Draper", "HD 216627"},
        {"Hipparcos Number", "HIP 113136"},
        {"Fundamental Katalog 5th Edition", "FK5 866"},
        {"Geneva Identification System", "GEN# +1.00216627"},
        {"Smithsonian Astrophysical Observation", "SAO 165375"},
        {"Wilson Evans Batten Catalogue", "WEB 20136"},
    },
    visualMagnitude: 3.27,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.66266350),
        dec: Angle.Degrees(-15.82075994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94387"},
        {"Hipparcos Number", "HIP 53250"},
        {"Cincinnati Publication", "Ci 18 1318"},
        {"Geneva Identification System", "GEN# +1.00094387"},
        {"Smithsonian Astrophysical Observation", "SAO 156300"},
        {"Wilson Evans Batten Catalogue", "WEB 9667"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.36598229),
        dec: Angle.Degrees(-15.82062384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -329.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7495"},
        {"Hipparcos Number", "HIP 5840"},
        {"Geneva Identification System", "GEN# +1.00007495"},
        {"Smithsonian Astrophysical Observation", "SAO 147692"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.72606156),
        dec: Angle.Degrees(-15.81874123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51642",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51642"},
        {"Smithsonian Astrophysical Observation", "SAO 156054"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.26928075),
        dec: Angle.Degrees(-15.81808111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211038"},
        {"Hipparcos Number", "HIP 109822"},
        {"Fundamental Katalog 5th Edition", "FK5 1582"},
        {"Geneva Identification System", "GEN# +1.00211038"},
        {"Smithsonian Astrophysical Observation", "SAO 164949"},
        {"Wilson Evans Batten Catalogue", "WEB 19724"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.65926191),
        dec: Angle.Degrees(-15.81766487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -356.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107404"},
        {"Hipparcos Number", "HIP 60217"},
        {"Geneva Identification System", "GEN# +1.00107404"},
        {"Smithsonian Astrophysical Observation", "SAO 157225"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.22457215),
        dec: Angle.Degrees(-15.81518719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6234",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1087 AB"},
        {"Aitken 2", "ADS 1087"},
        {"Henry Draper", "HD 8071"},
        {"Hipparcos Number", "HIP 6234"},
        {"Smithsonian Astrophysical Observation", "SAO 147741"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.99052523),
        dec: Angle.Degrees(-15.81408369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126701"},
        {"Hipparcos Number", "HIP 70682"},
        {"Smithsonian Astrophysical Observation", "SAO 158575"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.85582267),
        dec: Angle.Degrees(-15.81321849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87813",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10891 A"},
        {"Henry Draper", "HD 163336"},
        {"Hipparcos Number", "HIP 87813"},
        {"Geneva Identification System", "GEN# +1.00163336J"},
        {"Smithsonian Astrophysical Observation", "SAO 160915"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.07933864),
        dec: Angle.Degrees(-15.81236072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182090"},
        {"Hipparcos Number", "HIP 95323"},
        {"Smithsonian Astrophysical Observation", "SAO 162560"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.90448869),
        dec: Angle.Degrees(-15.81231293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153276"},
        {"Hipparcos Number", "HIP 83107"},
        {"Geneva Identification System", "GEN# +1.00153276"},
        {"Smithsonian Astrophysical Observation", "SAO 160206"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.74170588),
        dec: Angle.Degrees(-15.81186169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29952",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29952"},
        {"Smithsonian Astrophysical Observation", "SAO 151333"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.57301728),
        dec: Angle.Degrees(-15.80990715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185590"},
        {"Hipparcos Number", "HIP 96782"},
        {"Smithsonian Astrophysical Observation", "SAO 162879"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.08794380),
        dec: Angle.Degrees(-15.80956063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30744"},
        {"Hipparcos Number", "HIP 22432"},
        {"Geneva Identification System", "GEN# +1.00030744"},
        {"Smithsonian Astrophysical Observation", "SAO 149915"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.40843423),
        dec: Angle.Degrees(-15.80881297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40687"},
        {"Hipparcos Number", "HIP 28386"},
        {"Smithsonian Astrophysical Observation", "SAO 151004"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.94106455),
        dec: Angle.Degrees(-15.80465675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21991",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21991"},
        {"Geneva Identification System", "GEN# -0.01600931"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.90135808),
        dec: Angle.Degrees(-15.80460310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30801"},
        {"Hipparcos Number", "HIP 22467"},
        {"Smithsonian Astrophysical Observation", "SAO 149923"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.52832928),
        dec: Angle.Degrees(-15.80425946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164188"},
        {"Hipparcos Number", "HIP 88193"},
        {"Geneva Identification System", "GEN# +1.00164188"},
        {"Smithsonian Astrophysical Observation", "SAO 160986"},
        {"Wilson Evans Batten Catalogue", "WEB 14901"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.16103285),
        dec: Angle.Degrees(-15.80238212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81147"},
        {"Hipparcos Number", "HIP 46057"},
        {"Smithsonian Astrophysical Observation", "SAO 155144"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.88215568),
        dec: Angle.Degrees(-15.80144721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32077"},
        {"Hipparcos Number", "HIP 23237"},
        {"Smithsonian Astrophysical Observation", "SAO 150066"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.00516923),
        dec: Angle.Degrees(-15.79866337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156461"},
        {"Hipparcos Number", "HIP 84647"},
        {"Geneva Identification System", "GEN# +1.00156461"},
        {"Smithsonian Astrophysical Observation", "SAO 160439"},
        {"Wilson Evans Batten Catalogue", "WEB 14295"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.57474190),
        dec: Angle.Degrees(-15.79862073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197593"},
        {"Hipparcos Number", "HIP 102419"},
        {"Geneva Identification System", "GEN# +1.00197593"},
        {"Smithsonian Astrophysical Observation", "SAO 163848"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.31222173),
        dec: Angle.Degrees(-15.79827056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20875"},
        {"Hipparcos Number", "HIP 15649"},
        {"Smithsonian Astrophysical Observation", "SAO 148916"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.36215734),
        dec: Angle.Degrees(-15.79781725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195952"},
        {"Hipparcos Number", "HIP 101555"},
        {"Geneva Identification System", "GEN# +1.00195952"},
        {"Smithsonian Astrophysical Observation", "SAO 163701"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.70830028),
        dec: Angle.Degrees(-15.79737233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43415"},
        {"Hipparcos Number", "HIP 29703"},
        {"Smithsonian Astrophysical Observation", "SAO 151276"},
    },
    visualMagnitude: 9.06,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.85430826),
        dec: Angle.Degrees(-15.79730389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70904"},
        {"Hipparcos Number", "HIP 41171"},
        {"Smithsonian Astrophysical Observation", "SAO 154208"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.00293958),
        dec: Angle.Degrees(-15.79711229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113069"},
        {"Hipparcos Number", "HIP 63546"},
        {"Smithsonian Astrophysical Observation", "SAO 157655"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.32201773),
        dec: Angle.Degrees(-15.79387003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42659"},
        {"Hipparcos Number", "HIP 29365"},
        {"Geneva Identification System", "GEN# +1.00042659"},
        {"Renson", "Renson 11403"},
        {"Smithsonian Astrophysical Observation", "SAO 151199"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.84063110),
        dec: Angle.Degrees(-15.79301604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75097"},
        {"Hipparcos Number", "HIP 43159"},
        {"Smithsonian Astrophysical Observation", "SAO 154638"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.85761793),
        dec: Angle.Degrees(-15.79262546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95441"},
        {"Hipparcos Number", "HIP 53849"},
        {"Geneva Identification System", "GEN# +1.00095441"},
        {"Smithsonian Astrophysical Observation", "SAO 156396"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.23890236),
        dec: Angle.Degrees(-15.79259236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11996"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.66782545),
        dec: Angle.Degrees(-15.79166315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 319.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62219"},
        {"Hipparcos Number", "HIP 37543"},
        {"Renson", "Renson 17056"},
        {"Smithsonian Astrophysical Observation", "SAO 153277"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.58024859),
        dec: Angle.Degrees(-15.79042203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18553"},
        {"Hipparcos Number", "HIP 13862"},
        {"Smithsonian Astrophysical Observation", "SAO 148693"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.61515385),
        dec: Angle.Degrees(-15.78900361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68752"},
        {"Hipparcos Number", "HIP 40259"},
        {"Fundamental Katalog 5th Edition", "FK5 311"},
        {"Geneva Identification System", "GEN# +1.00068752"},
        {"Smithsonian Astrophysical Observation", "SAO 153993"},
        {"Wilson Evans Batten Catalogue", "WEB 7849"},
    },
    visualMagnitude: 4.99,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.33322933),
        dec: Angle.Degrees(-15.78821451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5616"},
        {"Hipparcos Number", "HIP 4506"},
        {"Geneva Identification System", "GEN# +1.00005616"},
        {"Smithsonian Astrophysical Observation", "SAO 147538"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.43240698),
        dec: Angle.Degrees(-15.78702995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17057"},
        {"Hipparcos Number", "HIP 12759"},
        {"Smithsonian Astrophysical Observation", "SAO 148573"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.99291694),
        dec: Angle.Degrees(-15.78553202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5507"},
        {"Hipparcos Number", "HIP 4426"},
        {"Geneva Identification System", "GEN# +1.00005507"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.17633969),
        dec: Angle.Degrees(-15.78228061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219920"},
        {"Hipparcos Number", "HIP 115170"},
        {"Fundamental Katalog 5th Edition", "FK5 6062"},
        {"Geneva Identification System", "GEN# +1.00219920"},
        {"Smithsonian Astrophysical Observation", "SAO 165632"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.91928280),
        dec: Angle.Degrees(-15.78227098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137537"},
        {"Hipparcos Number", "HIP 75622"},
        {"Smithsonian Astrophysical Observation", "SAO 159268"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.77521093),
        dec: Angle.Degrees(-15.78077482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76321"},
        {"Hipparcos Number", "HIP 43772"},
        {"Smithsonian Astrophysical Observation", "SAO 154737"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.74053255),
        dec: Angle.Degrees(-15.77942562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176656"},
        {"Hipparcos Number", "HIP 93452"},
        {"Renson", "Renson 49300"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.48617060),
        dec: Angle.Degrees(-15.77883844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145789"},
        {"Hipparcos Number", "HIP 79500"},
        {"Geneva Identification System", "GEN# +1.00145789"},
        {"Smithsonian Astrophysical Observation", "SAO 159787"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.35406452),
        dec: Angle.Degrees(-15.77346294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195258"},
        {"Hipparcos Number", "HIP 101199"},
        {"Smithsonian Astrophysical Observation", "SAO 163641"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.69226303),
        dec: Angle.Degrees(-15.77142905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58760"},
        {"Hipparcos Number", "HIP 36121"},
        {"Geneva Identification System", "GEN# +1.00058760"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.61055982),
        dec: Angle.Degrees(-15.77009219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80384"},
        {"Smithsonian Astrophysical Observation", "SAO 159901"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.11960389),
        dec: Angle.Degrees(-15.76921401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28935"},
        {"Hipparcos Number", "HIP 21210"},
        {"Geneva Identification System", "GEN# +1.00028935"},
        {"Smithsonian Astrophysical Observation", "SAO 149721"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.24207014),
        dec: Angle.Degrees(-15.76815880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14655"},
        {"Hipparcos Number", "HIP 10990"},
        {"Geneva Identification System", "GEN# +1.00014655"},
        {"Smithsonian Astrophysical Observation", "SAO 148349"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.41090053),
        dec: Angle.Degrees(-15.76787186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60802"},
        {"Geneva Identification System", "GEN# -0.01403519"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.91787217),
        dec: Angle.Degrees(-15.76775947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119786"},
        {"Hipparcos Number", "HIP 67139"},
        {"Geneva Identification System", "GEN# +1.00119786"},
        {"Smithsonian Astrophysical Observation", "SAO 158147"},
        {"Wilson Evans Batten Catalogue", "WEB 11821"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.39622140),
        dec: Angle.Degrees(-15.76740920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72568"},
        {"Hipparcos Number", "HIP 41956"},
        {"Smithsonian Astrophysical Observation", "SAO 154383"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.28833985),
        dec: Angle.Degrees(-15.76448003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35809"},
        {"Hipparcos Number", "HIP 25462"},
        {"Smithsonian Astrophysical Observation", "SAO 150455"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.68152517),
        dec: Angle.Degrees(-15.76325799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206450"},
        {"Hipparcos Number", "HIP 107176"},
        {"Smithsonian Astrophysical Observation", "SAO 164589"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.63862647),
        dec: Angle.Degrees(-15.76157427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86412",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10683 AB"},
        {"Henry Draper", "HD 160239"},
        {"Hipparcos Number", "HIP 86412"},
        {"Geneva Identification System", "GEN# +1.00160239"},
        {"Smithsonian Astrophysical Observation", "SAO 160722"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.85116237),
        dec: Angle.Degrees(-15.76140226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22821"},
        {"Hipparcos Number", "HIP 17061"},
        {"Smithsonian Astrophysical Observation", "SAO 149083"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.85983882),
        dec: Angle.Degrees(-15.75755128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190524"},
        {"Hipparcos Number", "HIP 98993"},
        {"Smithsonian Astrophysical Observation", "SAO 163258"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.45245704),
        dec: Angle.Degrees(-15.75598837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75941"},
        {"Hipparcos Number", "HIP 43585"},
        {"Smithsonian Astrophysical Observation", "SAO 154706"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.14775867),
        dec: Angle.Degrees(-15.75168528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183921"},
        {"Hipparcos Number", "HIP 96109"},
        {"Smithsonian Astrophysical Observation", "SAO 162739"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.10841386),
        dec: Angle.Degrees(-15.75152560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210777"},
        {"Hipparcos Number", "HIP 109675"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.25705108),
        dec: Angle.Degrees(-15.75104099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 181.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175277"},
        {"Hipparcos Number", "HIP 92852"},
        {"Smithsonian Astrophysical Observation", "SAO 161977"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.81215392),
        dec: Angle.Degrees(-15.74874341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51544"},
        {"Hipparcos Number", "HIP 33438"},
        {"Smithsonian Astrophysical Observation", "SAO 152154"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.29214580),
        dec: Angle.Degrees(-15.74320097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24425"},
        {"Hipparcos Number", "HIP 18126"},
        {"Smithsonian Astrophysical Observation", "SAO 149223"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.14478712),
        dec: Angle.Degrees(-15.74153369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194918"},
        {"Hipparcos Number", "HIP 101011"},
        {"Geneva Identification System", "GEN# +1.00194918"},
        {"Smithsonian Astrophysical Observation", "SAO 163612"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.18160334),
        dec: Angle.Degrees(-15.74149651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22442"},
        {"Geneva Identification System", "GEN# -0.01500872"},
        {"Smithsonian Astrophysical Observation", "SAO 149918"},
        {"Wilson Evans Batten Catalogue", "WEB 4329"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.43458766),
        dec: Angle.Degrees(-15.74115442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202282"},
        {"Hipparcos Number", "HIP 104922"},
        {"Geneva Identification System", "GEN# +1.00202282"},
        {"Smithsonian Astrophysical Observation", "SAO 164252"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.79878502),
        dec: Angle.Degrees(-15.74085715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46676",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7409 AB"},
        {"Henry Draper", "HD 82339"},
        {"Hipparcos Number", "HIP 46676"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.73780891),
        dec: Angle.Degrees(-15.73881444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65996"},
        {"Hipparcos Number", "HIP 39187"},
        {"Geneva Identification System", "GEN# +1.00065996"},
        {"Smithsonian Astrophysical Observation", "SAO 153714"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.22612555),
        dec: Angle.Degrees(-15.73878604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82283",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82283"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.19151985),
        dec: Angle.Degrees(-15.73839731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -223.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37104"},
        {"Hipparcos Number", "HIP 26243"},
        {"Smithsonian Astrophysical Observation", "SAO 150588"},
    },
    visualMagnitude: 6.82,
    bvColour: -0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.86071612),
        dec: Angle.Degrees(-15.73795201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2049"},
        {"Hipparcos Number", "HIP 1950"},
        {"Smithsonian Astrophysical Observation", "SAO 147255"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.15992945),
        dec: Angle.Degrees(-15.73782629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94915"},
        {"Hipparcos Number", "HIP 53549"},
        {"Geneva Identification System", "GEN# +1.00094915"},
        {"Smithsonian Astrophysical Observation", "SAO 156349"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.32265814),
        dec: Angle.Degrees(-15.73477037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48077"},
        {"Smithsonian Astrophysical Observation", "SAO 155490"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.01837791),
        dec: Angle.Degrees(-15.73445493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48458"},
        {"Hipparcos Number", "HIP 32161"},
        {"Geneva Identification System", "GEN# +1.00048458"},
        {"Smithsonian Astrophysical Observation", "SAO 151828"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.73775577),
        dec: Angle.Degrees(-15.73416226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27914",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4500 A"},
        {"Henry Draper", "HD 39817"},
        {"Hipparcos Number", "HIP 27914"},
        {"Smithsonian Astrophysical Observation", "SAO 150927"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.59864712),
        dec: Angle.Degrees(-15.73199438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93408"},
        {"Hipparcos Number", "HIP 52743"},
        {"Smithsonian Astrophysical Observation", "SAO 156223"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.74350243),
        dec: Angle.Degrees(-15.73189203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
